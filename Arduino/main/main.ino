int hex(char a, char b)
{
  int n = 0;

  if (a < 'a')
    n = n + 16 * (a - '0');
  else
    n = n + 16 * (a - 'a' + 10);

  if (b < 'a')
    n = n + (b - '0');
  else
    n = n + (b - 'a' + 10);

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

    void setColor(int r, int g, int b)
    {
      analogWrite(redPin, r);
      analogWrite(greenPin, g);
      analogWrite(bluePin, b);
    }

    void turnOff()
    {
      this->setColor(0, 0, 0);
    }
};

RedGreenBlue rgb0 = RedGreenBlue(11, 9, 10);
RedGreenBlue rgb1 = RedGreenBlue(6, 3, 5);
String d;

void fadeMode(int delayTime)
{
  int r = 254, g = 1, b = 127;
  int r_ = -1, g_ = 1, b_ = -1;
  while (Serial.peek() == -1)
  {
    r += r_;
    g += g_;
    b += b_;

    if (r >= 255 || r <= 0)
      r_ = r_ * -1;
    if (g >= 255 || g <= 0)
      g_ = g_ * -1;
    if (b >= 255 || b <= 0)
      b_ = b_ * -1;

    rgb0.setColor(r, g, b);
    rgb1.setColor(r, g, b);

    delay(delayTime);
  }
}

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available())
  {
    d = Serial.readStringUntil('\n');

    if (d == "START")
    {
      Serial.println("START_");
      rgb0.setColor(255, 255, 255);
      rgb1.setColor(255, 255, 255);
    }
    else if (d == "STOP")
    {
      Serial.println("STOP_");
      rgb0.turnOff();
      rgb1.turnOff();
    }
    else if (d == "FADE")
    {
      fadeMode(15);
    }
  }
}
