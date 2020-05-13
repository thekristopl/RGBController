class Function
{
public:
  Function(){;}
  virtual int f(unsigned long x)
  {
    return 0;
  }
};


class Const : public Function
{
  int high = 255;
  
public:
  Const(int high)
  {
    this->high = high;
  }
  virtual int f(unsigned long x)
  {
    return high;
  }
};


class Fade : public Function
{
  int min, max;
  int a, b, c, d, p;

public:
  Fade(int p, int a, int b, int c, int d, int min, int max)
  {
    this->min = min;
    this->max = max;
    this->a = a;
    this->b = b;
    this->c = c;
    this->d = d;
    if (p < a + b + c + d)
      this->p = p;
    else
      this->p = 0;
  }

  virtual int f(unsigned long x)
  {
    int t = (x + p) % (a + b + c + d);
    if (t < a)
      return ((double)(max - min) / (double)a) * t + min;
    else if (t < a + b)
      return max;
    else if (t < a + b + c)
      return (-(double)(max - min) / (double)(c)) * (t - (a + b)) + max;
    else
      return min;
  }
};


class Sin : public Function
{
  int freq, min, max;
public:
  Sin(int freq, int min, int max)
  {
    this->freq = freq;
    this->min = min;
    this->max = max;
  }

  virtual int f(unsigned long x)
  {
    return (sin(radians((x*2*(M_PI))/freq))/2 + 0.5) * (max - min) + min;
  }
};
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

class Strip
{
  int redPin, greenPin, bluePin;
  Function *r = new Const(255), *g = new Const(255), *b = new Const(255);
  int brightness = 255;
  float speed = 1;
  bool isOn = false;

  void setColor(int r, int g, int b)
  {
    if (r < 0) r = 0;
    if (g < 0) g = 0;
    if (b < 0) b = 0;

    if (r > 255) r = 255;
    if (g > 255) g = 255;
    if (b > 255) b = 255;
    
    analogWrite(redPin, map(r, 0, 255, 0, brightness));
    analogWrite(greenPin, map(g, 0, 255, 0, brightness));
    analogWrite(bluePin, map(b, 0, 255, 0, brightness));
  }

public:
  Strip(int r, int g, int b)
  {
    redPin = r;
    greenPin = g;
    bluePin = b;
  }

  void setFunctions(Function *r, Function *g, Function *b){ this->r = r; this->g = g; this->b = b;}

  void setSpeed(float speed){this->speed = speed;}
  void setBrightness(int brightness){this->brightness = brightness;}

  void on(){isOn = true;}
  void off(){isOn = false; setColor(0,0,0);}

  void step()
  {
    if(isOn)
    {
      unsigned long t = millis()*speed;
      this->setColor(r->f(t), g->f(t), b->f(t));
    }
  }
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Strip left = Strip(10, 9, 11);
Strip right = Strip(6, 3, 5);

void setup()
{
  Serial.begin(9600);

  left.setFunctions(new Fade(0, 1800, 0, 1800, 1800, 0, 255), new Fade(1800, 1800, 0, 1800, 1800, 0, 255), new Fade(3600, 1800, 0, 1800, 1800, 0, 255));
  right.setFunctions(new Fade(0, 1800, 0, 1800, 1800, 0, 255), new Fade(1800, 1800, 0, 1800, 1800, 0, 255), new Fade(3600, 1800, 0, 1800, 1800, 0, 255));
  left.on();
  right.on();
}

void loop()
{
  int len = Serial.available();
  int headerLen = 5;
  if (len >= headerLen)
  {
    String header = "";
    for(int i=0; i < headerLen-1; i++) header += (char)Serial.read();
    int optionsLength = (int)(Serial.read());
    
    byte options[optionsLength];
    Serial.readBytes(options, optionsLength);
    
   
    
    if (header == "STAR") 
    {
      Serial.println("STA_");  
      left.on(); right.on();
    }
    else if (header == "STOP")
    {
      Serial.println("STO_");
      left.off(); right.off();
    }
    else if (header == "SPEE") 
    {
      float x = ((float)options[0])/20;
      float b = x/(-0.8*x + 9);
      left.setSpeed(b); 
      right.setSpeed(b);
      Serial.println(b);
    }
    else if (header == "BRIG")
    {
      left.setBrightness((int)options[0]); 
      right.setBrightness((int)options[0]);
    }
    else if (header == "MODE")
    {
      switch(options[0])
      {
        case 0:  //left led static color
          left.setFunctions(new Const((int)options[1]), new Const((int)options[2]), new Const((int)options[3])); 
          break;
        case 1:  //right led static color
          right.setFunctions(new Const((int)options[1]), new Const((int)options[2]), new Const((int)options[3]));
          break;
        case 2:  //single fade
          left.setFunctions(new Fade(0, 1800, 0, 1800, 1800, 0, 255), new Fade(1800, 1800, 0, 1800, 1800, 0, 255), new Fade(3600, 1800, 0, 1800, 1800, 0, 255));
          right.setFunctions(new Fade(0, 1800, 0, 1800, 1800, 0, 255), new Fade(1800, 1800, 0, 1800, 1800, 0, 255), new Fade(3600, 1800, 0, 1800, 1800, 0, 255));
          break;
        case 3:  //double fade
          left.setFunctions(new Fade(0, 1800, 0, 1800, 1800, 0, 255), new Fade(1800, 1800, 0, 1800, 1800, 0, 255), new Fade(3600, 1800, 0, 1800, 1800, 0, 255));
          right.setFunctions(new Fade(1200, 1800, 0, 1800, 1800, 0, 255), new Fade(3000, 1800, 0, 1800, 1800, 0, 255), new Fade(4800, 1800, 0, 1800, 1800, 0, 255));
          break;
      }
    }
  }

  left.step();
  right.step();
}
