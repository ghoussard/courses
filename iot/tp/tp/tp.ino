#include "FastLED.h"

#define BUZZER_PIN D4
#define TRIGGER_BUZZER_BYTE 98
#define LED_COUNT 1
#define LED_PIN D2

CRGB strip[LED_COUNT];
//gamme musicale
int frequence[] = {262, 294, 330, 349, 370, 392, 440, 494}; 
int incomingByte = 0; //pour stocker l'octet reçu par la liaison série

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  FastLED.addLeds<WS2812B, LED_PIN, RGB>(strip, LED_COUNT);
}

void loop() {
  // send data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingByte = Serial.read();
    Serial.print("Octet reçu : ");
    Serial.println(incomingByte, DEC);

    //si le charactère de déclenchement est reçu
    if(incomingByte == TRIGGER_BUZZER_BYTE) {
      Serial.println("Buzzer déclenché");
      for (int i = 0; i < 8; i++) {
        //joue chaque note pendant 0.5s
        tone(BUZZER_PIN, frequence[i], 500);
        delay(500);
      }
    }
  }

  //fait clignoter la LED
  for (int i = 0; i < LED_COUNT; i++) {
    strip[i] = CRGB::Red; 
  }
  FastLED.show();
  delay(500);
  for (int i = 0; i < LED_COUNT; i++)
  {
    strip[i] = CRGB::Black;
  }
  FastLED.show();
  delay(500);
}
