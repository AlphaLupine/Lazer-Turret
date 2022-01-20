#include<Servo.h>

Servo serX;
Servo serY;

String serialData;

void setup() {
  // put your setup code here, to run once:
  serX.attach(11);
  serY.attach(10);

  Serial.begin(9600);
  Serial.setTimeout(10);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  
}

void serialEvent() {
  serialData = Serial.readString();

  serX.write(parseX(serialData));
  serY.write(parseY(serialData));
}

int parseX(String data) {
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);
  return data.toInt();
}

int parseY(String data) {
  data.remove(0, data.indexOf("Y") + 1);
  return data.toInt();
}
