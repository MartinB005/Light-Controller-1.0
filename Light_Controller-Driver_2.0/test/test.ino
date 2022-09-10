int pins[] = {2, 3, 4, 5, 6, 7, 8, 9, 10};

void setup() {
  Serial.begin(115200);
  for(int pin : pins) pinMode(pin, OUTPUT);
}

void loop() {
  Serial.println(analogRead(A0));
  for(int pin : pins) {
    digitalWrite(pin, HIGH);
    delay(500);
    digitalWrite(pin, LOW);
  }
}
