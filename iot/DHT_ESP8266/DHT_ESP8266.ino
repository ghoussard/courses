#include "DHTesp.h"

#ifdef ESP32
#pragma message(THIS EXAMPLE IS FOR ESP8266 ONLY!)
#error Select ESP8266 board.
#endif

#define TEMP_LED D2

DHTesp dht;

void setup()
{
  Serial.begin(115200);
  Serial.println();
  Serial.println("Status\tHumidity (%)\tTemperature (C)\t(F)\tHeatIndex (C)\t(F)");
  String thisBoard= ARDUINO_BOARD;
  Serial.println(thisBoard);

  pinMode(TEMP_LED, OUTPUT);

  // Autodetect is not working reliable, don't use the following line
  // dht.setup(17);
  // use this instead: 
  dht.setup(D4, DHTesp::DHT11); // Connect DHT sensor to GPIO 17
}

void loop()
{
  delay(dht.getMinimumSamplingPeriod());

  float humidity = dht.getHumidity();
  float temperature = dht.getTemperature();

  //Serial.print(dht.getStatusString());
  //Serial.print("\t");
  //Serial.print(humidity, 1);
  //Serial.print("\t\t");
  Serial.print("Température : ");
  Serial.println(temperature, 1);
  if(temperature > 23) {
    Serial.println("LED allumée");
    digitalWrite(TEMP_LED, HIGH);
  } else {
    Serial.println("LED éteinte");
    digitalWrite(TEMP_LED, LOW);
  }
  //Serial.print("\t\t");
  //Serial.print(dht.toFahrenheit(temperature), 1);
  //Serial.print("\t\t");
  //Serial.print(dht.computeHeatIndex(temperature, humidity, false), 1);
  //Serial.print("\t\t");
  //Serial.println(dht.computeHeatIndex(dht.toFahrenheit(temperature), humidity, true), 1);
  delay(2000);
}
