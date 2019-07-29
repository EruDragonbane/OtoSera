#include <SoftwareSerial.h>
#include <Servo.h>

SoftwareSerial bluetooth(1, 0);
Servo myServo;
int servo_pin=9;
int enable_pin=5;
int input1_pin=6;
int input2_pin=7;
int inData;
int servoData;

void setup() {
  // put your setup code here, to run once:
  pinMode(enable_pin, OUTPUT);
  pinMode(input1_pin, OUTPUT);
  pinMode(input2_pin, OUTPUT);
  myServo.attach(servo_pin);
  //Serial.begin(9600);
  bluetooth.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(bluetooth.available()){
    inData=bluetooth.read();
    if(inData>0 && inData<=30){      
      if(inData==20){
        analogWrite(enable_pin, 0);
        digitalWrite(input1_pin, LOW);
        digitalWrite(input2_pin, LOW);
      }
      else if(inData>0 && inData<=10){
        inData=map(inData, 1, 10, 0, 255);
        analogWrite(enable_pin, inData);
        digitalWrite(input1_pin, HIGH);
        digitalWrite(input2_pin, LOW);
      }
      else if(inData>20 && inData<=30){
        inData=map(inData, 21, 30, 0, 255);
        analogWrite(enable_pin, inData);
        digitalWrite(input1_pin, LOW);
        digitalWrite(input2_pin, HIGH);
      }
    }
   
   if(inData == 250){
    myServo.write(-90);
   }
   else if(in+Data==240){
       myServo.write(90);
    }
  }
}
