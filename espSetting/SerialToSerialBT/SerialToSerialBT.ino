//This example code is in the Public Domain (or CC0 licensed, at your option.)
//By Evandro Copercini - 2018
//
//This example creates a bridge between Serial and Classical Bluetooth (SPP)
//and also demonstrate that SerialBT have the same functionalities of a normal Serial

#include "BluetoothSerial.h"

#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
#error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif

BluetoothSerial SerialBT;

#define echoPin 12          // Echo Pin
#define trigPin 13          // Trigger Pin
double Duration = 0; //受信した間隔
double Distance = 0; //距離

void setup() {
  Serial.begin(115200);
  SerialBT.begin("ESP32test"); //Bluetooth device name
  pinMode( echoPin, INPUT );
  pinMode( trigPin, OUTPUT );
}

void loop() {
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite( trigPin, HIGH ); //超音波を出力
  delayMicroseconds( 10 ); //
  digitalWrite( trigPin, LOW );
  Duration = pulseIn( echoPin, HIGH ); //センサからの入力

  if (Duration > 0) {
    Duration = Duration / 2; //往復距離を半分にする
    Distance = Duration * 340 * 100 / 1000000; // 音速を340m/sに設定
    SerialBT.println(Distance);

    delay(500);
  }
}
