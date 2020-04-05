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

};

RedGreenBlue rgb[2] = {RedGreenBlue(11, 9, 10),  RedGreenBlue(6, 3, 5)};
 
void setup()
{
  Serial.begin(9600);
}


void loop()
{
  if (Serial.available())
  {
      String d;
      d = Serial.readStringUntil('\n');


      if(d[1] == '#') //np: 0#A018CF
      {
         rgb[d[0]-'0'].setColor(hex(d[2], d[3]), hex(d[4], d[5]), hex(d[6], d[7]));
         Serial.println(hex(d[2], d[3]));
         Serial.println(hex(d[4], d[5]));
         Serial.println(hex(d[6], d[7]));
      }
  }
  

}
