<?php
/**
 * Created by PhpStorm.
 * User: Jorge Hernández García
 * Date: 6/11/16
 * Time: 10:25 PM
 */

include_once "nusoap/nusoap.php";

$wsdl = "http://localhost/sustentabilidadWS/service.php?wsdl";

$client = new nusoap_client($wsdl, 'wsdl', '', '', '', '');
$client->soap_defencoding = 'UTF-8';
$client->debug_flag = false;

$soapError = $client->getError();
if (!empty($soapError)) {
    $errorMessage = 'Nusoap object creation failed: ' . $soapError;
    die($errorMessage);
}

$result = $client->call('getRainPobability', array());
$soapError = $client->getError();
if (!empty($soapError)) {
    $errorMessage = 'SOAP method invocation (getRainPobability) failed: ' . $soapError;
    die($errorMessage);
}

if ($client->fault) {
    $fault = "{$client->faultcode}: {$client->faultdetail} ";
    die($fault);
}

echo $result;