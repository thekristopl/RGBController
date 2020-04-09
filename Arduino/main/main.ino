int hex(char a, char b)
{
  int n = 0;

  if(a<'a') n=n+16*(a-'0');
  else n=n+16*(a-'a'+10);

  if(b<'a') n=n+(b-'0');
  else n=n+(b-'a'+10);
    
  return n;
}

class RedGreenBlue
{
  public:
  int redPin;
  int greenPin;
  int bluePin;

  RedGreenBlue(int r, int g, int b)
  {
    redPin = r;
    greenPin = g;
    bluePin = b;
  }
  
  void setColor(int r,int g,int b)
  {
    analogWrite(redPin, r);
    analogWrite(greenPin, g);
    analogWrite(bluePin, b);
  }

  void turnOff()
  {
    this->setColor(0,0,0);
  }

};

RedGreenBlue rgb[2] = {RedGreenBlue(11, 9, 10),  RedGreenBlue(6, 3, 5)};
String d;

void setup()
{
  Serial.begin(9600);
}


void loop()
{
  if (Serial.available())
  {
      d = Serial.readStringUntil('\n');

      if(d=="START")
      {
        Serial.println("START_");
        rgb[0].setColor(255,255,255);
        rgb[1].setColor(255,255,255);
      }
      else if(d == "STOP")
      {
        Serial.println("STOP_");
        rgb[0].turnOff();
        rgb[1].turnOff();
      }
      if(d[1] == '#')
      {
         rgb[d[0]-'0'].setColor(hex(d[2], d[3]), hex(d[4], d[5]), hex(d[6], d[7]));
      }
      
      
  }
  

}
