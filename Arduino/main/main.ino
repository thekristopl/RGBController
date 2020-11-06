#include <FastLED.h>

#define LAMP_SW_PIN   2
#define LAMP_PIN      6
#define BP_PIN        3
#define YP_PIN        5
#define R_PIN         11
#define G_PIN         9
#define B_PIN         10
#define PC_PIN        12
#define SCR_PIN       13

#define PC_NUM        45
#define SCR_NUM       9
#define LED_TYPE      NEOPIXEL

/////////////////////////////////////////////////////////////////////////////////////////////////

byte lampBright = 0;
byte yellowBright = 0;
byte blueBright = 0;

CRGB rgb = CRGB(0,0,0); 
byte rgbBright = 0;

CRGB PC[PC_NUM];
CRGB SCR[SCR_NUM];


/////////////////////////////////////////////////////////////////////////////////////////////////

void showAnalogRGB() 
{
  analogWrite(R_PIN, (byte)rgb.r * ((double)rgbBright / 255)); 
  analogWrite(G_PIN, (byte)rgb.g * ((double)rgbBright / 255)); 
  analogWrite(B_PIN, (byte)rgb.b * ((double)rgbBright / 255));
}

void lampSwitch() {analogWrite(LAMP_PIN, 255*(!digitalRead(LAMP_SW_PIN)));}

void setup()
{
    Serial.begin(9600);

    attachInterrupt(digitalPinToInterrupt(LAMP_SW_PIN), lampSwitch, CHANGE);

    pinMode(LAMP_SW_PIN, INPUT_PULLUP);

    FastLED.addLeds<LED_TYPE, PC_PIN>(PC, PC_NUM);
    FastLED.addLeds<LED_TYPE, SCR_PIN>(SCR, SCR_NUM);
}

void loop()
{   
    if (Serial.available() >= 2)
    {
        byte head = Serial.read();
        byte optLen = Serial.read();
        byte opt[optLen]; 

        Serial.readBytes(opt, optLen);
        
       
        switch(head)
        {
            case 0: //STOP
                Serial.write(0);
                break;

            case 1: //START
                Serial.write(1);
                break;

            case 2: //LAMP BRIGHT
                analogWrite(LAMP_PIN, opt[0]);
                break;
                
            case 3: //BLUE LAMP BRIGHT
                analogWrite(BP_PIN, opt[0]);
                break;
                
            case 4: //YELLOW LAMP BRIGHT
                analogWrite(YP_PIN, opt[0]);
                break;
                
            case 5: //RGB COLLOR
                rgb = CRGB(opt[0], opt[1], opt[2]);
                showAnalogRGB();
                break;
                                
            case 6: //RGB BRIGHT
                rgbBright = opt[0];
                showAnalogRGB();
                break;

            case 7: //ADDRESS RGB COLLOR
                FastLED.showColor(CRGB(opt[0], opt[1], opt[2]));
                break;

            
            case 255: //READ DATA
                Serial.write(lampBright);
                Serial.write(yellowBright);
                Serial.write(blueBright);
                Serial.write(rgbBright);
                Serial.write(rgb.r);
                Serial.write(rgb.g);
                Serial.write(rgb.b);
                break;

        }
        
    }
}
