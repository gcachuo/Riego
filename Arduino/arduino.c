int sensorPin0 = A0;
int sensorPin1 = A1;

int sensorValor0 = 0;
int sensorValor1 = 0;

void setup() 
{
  Serial.begin(9600);
  for(int estePin = 2; estePin < 5; estePin++)
  {
      pinMode(estePin, OUTPUT);
  }
}

void loop() 
{
    if(Serial.available() > 0)
    {
        int lecturaByte = Serial.read();

        switch(lecturaByte)
        {
            case 'a':
              digitalWrite(2, HIGH);
              break;
              
            case 'A':
              digitalWrite(2, LOW);
              break;
                          
            case 'b':
              digitalWrite(3, HIGH);
              break;

            case 'B':
              digitalWrite(3, LOW);
              break;

            case 'c':
              digitalWrite(4, HIGH);
              break;
              
            case 'C':
              digitalWrite(4, LOW);
              break;

           case 'd':
              digitalWrite(5, HIGH);
              break;

           case 'D':
              digitalWrite(5, LOW);
              break;


            //Condicionales para recibir temperatura y luminosidad
           case 'L':
              sensorValor0 = analogRead(sensorPin0);
              //Serial.print("A0:");
              Serial.print(sensorValor0);
              Serial.print("\n");
              break;

           case 'T':
              sensorValor1 = analogRead(sensorPin1);
              //Serial.print("A1:");
              Serial.print(sensorValor1);
              Serial.print("\n");
              break;

           default:
              break;
        }
    }

}