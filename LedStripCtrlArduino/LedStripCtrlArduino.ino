#include <SoftwareSerial.h>
#include "Adafruit_WS2801.h"
#include "SPI.h" // Comment out this line if using Trinket or Gemma

uint8_t dataPin  = 2;    // Yellow wire on Adafruit Pixels
uint8_t clockPin = 3;    // Green wire on Adafruit Pixels
char inChar = -1;
int lastSeparator = 0;
String receivedData;
int red;
int green;
int blue;
int effectNo;
int delayTimer;

// Set the first variable to the NUMBER of pixels. 25 = 25 pixels in a row
Adafruit_WS2801 strip = Adafruit_WS2801(70, dataPin, clockPin);

void setup() {
  strip.begin();
  // update all LEDs
  strip.show();
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  // open serial port
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for connect
  }
}

void loop() {

  // wait for serial data
  while (Serial.available() > 0) {

      // get data
      receivedData = Serial.readString();

      // find end of line
      int endOfLine = receivedData.indexOf('\n');
      receivedData = receivedData.substring(0, endOfLine);

      // get separator positions
      int commaIndex  = receivedData.indexOf(',');  //4
      int secondCommaIndex = receivedData.indexOf(',', commaIndex + 1);
      int thirdCommaIndex = receivedData.indexOf(',', secondCommaIndex + 1);

      // extract values
      String firstValue  = receivedData.substring(0, commaIndex);
      String secondValue = receivedData.substring(commaIndex + 1, secondCommaIndex);
      String thirdValue  = receivedData.substring(secondCommaIndex + 1,thirdCommaIndex );
      String fourthValue = receivedData.substring(thirdCommaIndex + 1);

      // convert values
      red   = firstValue.toInt();
      green = secondValue.toInt();
      blue  = thirdValue.toInt();
      effectNo = fourthValue.toInt();

      // set stripe color
      for (int i=0; i < strip.numPixels(); i++) {
        strip.setPixelColor(i, red, blue, green);
        strip.show();
        delay(10);
      }

      // only for diag
      // Serial.println(receivedData);
      // Serial.println(red);
      // Serial.println(green);
      // Serial.println(blue);
  }

  // select effect
  switch(effectNo)
  {
    case 0: break;
    case 1: knightRider(15); break;
    case 2: RGBLoop(); break;
    case 3: rainbowCycle(20); break;
  }
  
}

// ----------------------------------------------------------------------------------------------
// Rainbow cycle effect
void rainbowCycle(uint8_t wait) {
  int i, j;
  
  for (j=0; j < 256 * 5; j++) {     // 5 cycles of all 25 colors in the wheel
    for (i=0; i < strip.numPixels(); i++) {
      // tricky math! we use each pixel as a fraction of the full 96-color wheel
      // (thats the i / strip.numPixels() part)
      // Then add in j which makes the colors go around per pixel
      // the % 96 is to make the wheel cycle around
      strip.setPixelColor(i, Wheel( ((i * 256 / strip.numPixels()) + j) % 256) );
    }  
    strip.show();   // write all the pixels out
    delay(wait);
  }
}

//Input a value 0 to 255 to get a color value.
//The colours are a transition r - g -b - back to r
uint32_t Wheel(byte WheelPos)
{
  if (WheelPos < 85) {
   return Color(WheelPos * 3, 255 - WheelPos * 3, 0);
  } else if (WheelPos < 170) {
   WheelPos -= 85;
   return Color(255 - WheelPos * 3, 0, WheelPos * 3);
  } else {
   WheelPos -= 170; 
   return Color(0, WheelPos * 3, 255 - WheelPos * 3);
  }
}

// Create a 24 bit color value from R,G,B
uint32_t Color(byte r, byte b, byte g)
{
  uint32_t c;
  c = r;
  c <<= 8;
  c |= g;
  c <<= 8;
  c |= b;
  return c;
}

// ----------------------------------------------------------------------------------------------
// RGB wheel effect
void RGBLoop(){
  for(int j = 0; j < 3; j++ ) { 
    
    // Fade in
    for(int k = 0; k < 256; k++) { 
      switch(j) { 
        case 0: setAll(k,0,0); break;
        case 1: setAll(0,k,0); break;
        case 2: setAll(0,0,k); break;
      }
      strip.show();
      delay(1);
  }

  // Fade out
  for(int k = 255; k >= 0; k--) { 
    switch(j) { 
      case 0: setAll(k,0,0); break;
      case 1: setAll(0,k,0); break;
      case 2: setAll(0,0,k); break;
    }
    strip.show();
    delay(1);
   }
  }
}

// Set all leds
void setAll(int r, int g, int b)
{
  for (int i=0; i < strip.numPixels(); i++) {
    strip.setPixelColor(i, r, g, b);
  }
}

// ----------------------------------------------------------------------------------------------
// Knight Rider Effect
void knightRider(int speed)
{
  int eyeSize = 4;
  for (int i=eyeSize; i < strip.numPixels() - eyeSize; i++) {
    strip.setPixelColor(i-eyeSize, 0, 0, 0);
    strip.setPixelColor(i-3, 10, 0, 0);
    strip.setPixelColor(i-2, 50, 0, 0);
    strip.setPixelColor(i-1, 100, 0, 0);
    strip.setPixelColor(i, 255, 0, 0);
    strip.setPixelColor(i+1, 100, 0, 0);
    strip.setPixelColor(i+2, 50, 0, 0);
    strip.setPixelColor(i+3, 10, 0, 0);
    strip.setPixelColor(i+eyeSize, 0, 0, 0);
    strip.show();
    delay(speed);
  }
  for (int i=strip.numPixels() - eyeSize; i > eyeSize; i--) {
    strip.setPixelColor(i-eyeSize, 0, 0, 0);
    strip.setPixelColor(i-3, 10, 0, 0);
    strip.setPixelColor(i-2, 50, 0, 0);
    strip.setPixelColor(i-1, 100, 0, 0);
    strip.setPixelColor(i, 255, 0, 0);
    strip.setPixelColor(i+1, 100, 0, 0);
    strip.setPixelColor(i+2, 50, 0, 0);
    strip.setPixelColor(i+3, 10, 0, 0);
    strip.setPixelColor(i+eyeSize, 0, 0, 0);
    strip.show();
    delay(speed);
  }
}
