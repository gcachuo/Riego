<?php
/**
 * Created by PhpStorm.
 * User: Jorge Hernández García
 * Date: 6/11/16
 * Time: 1:20 PM
 */

include_once "nusoap/nusoap.php";
include_once "RESThelper.php";

$server = new nusoap_server();

$namespace = "http://localhost/sustentabilidadWS/service.php";
$server->wsdl->schemaTargetNamespace = $namespace;

$server->configureWSDL("sustentabilidadWS");

$server->soap_defencoding = 'UTF-8';
$server->decode_utf8 = false;
$server->encode_utf8 = true;

$server->register(
    'getRainPobability',
    array(),
    array('return'=>'xsd:string'),
    $namespace,
    false,
    'rpc',
    'encoded',
    'Sustentabilidad WS'
);

function getRainPobability()
{
    $apiKey = "HnQjjK3L4n52UUKXG3zGEHTpFZnjuc3h";
    $locationKey = "243361";
    $language = "es-mx";
    $details = "true";

    $data = array(
        "apikey" => $apiKey,
        "language" => $language,
        "details" => $details
    );

    $url = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/$locationKey";
    $result = json_decode(
        CallAPI("GET", $url, $data),
        true
    );

    $dayRainProbability = $result["DailyForecasts"][0]["Day"]["PrecipitationProbability"];
    $nightRainProbability = $result["DailyForecasts"][0]["Night"]["PrecipitationProbability"];

    return "$dayRainProbability;$nightRainProbability";
}

$POST_DATA = isset($GLOBALS['HTTP_RAW_POST_DATA']) ? $GLOBALS['HTTP_RAW_POST_DATA'] : '';
$server->service($POST_DATA);

