#include <LiquidCrystal_I2C.h>
#include <TimedAction.h>

class Light {

  public:
    int lightNumber;
    int colorCount;
    int currentColorNumber = 1;
    boolean fadeIn;
    boolean fadeOut;
    
    Light(int number) {
      lightNumber = number;
      void(*functions[]) = {fadeCallToLight1, fadeCallToLight2, fadeCallToLight3, fadeCallToLight4};
      fadeOutTimer = TimedAction(1, functions[number - 1]);
    }

    void connect(int redPin, int greenPin, int bluePin){
      pinMode(redPin, OUTPUT);
      pinMode(greenPin, OUTPUT);
      pinMode(bluePin, OUTPUT);
      colorPins[0] = redPin;
      colorPins[1] = greenPin;
      colorPins[2] = bluePin;
    }

    void attachMotors(int xPin, int yPin){
      
    }

    void setRed(int value) {
      if(brightness > 50) value = map(brightness, 50, 100, value, 255);
      else value = map(brightness, 0, 50, 0, value);
      int voltage = map(value, 0, 255, 0, 130);
      analogWrite(colorPins[0], voltage);
    }

    void setGreen(int value) {
      if(brightness > 50) value = map(brightness, 50, 100, value, 255);
      else value = map(brightness, 0, 50, 0, value);
      int voltage = map(value, 0, 255, 0, 130);
      analogWrite(colorPins[1], voltage);
    }
    
    void setBlue(int value) {
      if(brightness > 50) value = map(brightness, 50, 100, value, 255);
      else value = map(brightness, 0, 50, 0, value);
      int voltage = map(value, 0, 255, 0, 130);
      analogWrite(colorPins[2], voltage);
    }

    void setBrightness(int value) {
      brightness = value;
    }

   void updateColors(int colors[8][3]){
    for(int i = 0; i < 8; i++){
      memcpy(lightColors[i], colors[i], 8);
    }
      Serial.println("-color:" + String(lightColors[0][1]) + 
      String(lightColors[0][1]) + String(lightColors[0][2]));
      Serial.println("-color:" + String(lightColors[1][1]) + 
      String(lightColors[1][1]) + String(lightColors[1][2]));
   }

   void updateColor(int colorNumber, int values[3]){
      for(int i = 0; i < 3; i++) lightColors[colorNumber][i] = values[i];
      int r1 = values[0];
      int g1 = values[1];
      int b1 = values[2];
      Serial.println(String(r1) + "/" + String(g1) + "/" + String(b1));
      int r = lightColors[colorNumber][0];
      int g = lightColors[colorNumber][1];
      int b = lightColors[colorNumber][2];
      Serial.println(String(r) + "/" + String(g) + "/" + String(b));
   }

    void nextColor() {
      extern int beatDistance;
      if((beatSpeed > 0) || (!twoBeatLimiter)) currentColorNumber++;
      twoBeatLimiter = !twoBeatLimiter;
      if(currentColorNumber > colorCount) currentColorNumber = 1;
      showColor();
      int colorIndex = currentColorNumber - 1;
      int colors[3];
      for(int i = 0; i < 3; i++){
        if(brightness > 50) colors[i] = map(brightness, 50, 100, lightColors[colorIndex][i], 255);
        else colors[i] = map(brightness, 0, 50, 0, lightColors[colorIndex][i]);
        if((beatSpeed > 0) || (!twoBeatLimiter)) fadeColors[i] = colors[i];
      }
       if(beatDistance > 300) {
         float colorChangesCount = pow(2, beatSpeed - 1);
         if(beatSpeed == 0) colorChangesCount = 0.5;
         extern int beatDistance;
         for(int i = 0; i < 3; i++) {
          int nextValue = fadeIn ? lightColors[currentColorNumber % colorCount][i] : 0;
          fadeColorFactor[i] = (nextValue - fadeColors[i]) / beatDistance * 15.0 * colorChangesCount;
         }
       }
      Serial.println("-lights:" + String(lightNumber) + ">" + colors[0] + 
      "|" + colors[1] + "|" + colors[2]);
    }

    static void invokeNextColor1(){
      extern Light light[];
      light[0].nextColor();
      light[0].colorChangeCount++;
    }

     static void invokeNextColor2(){
      extern Light light[];
      light[1].nextColor();
      light[1].colorChangeCount++;
    }

    static void invokeNextColor3(){
      extern Light light[];
      light[2].nextColor();
      light[2].colorChangeCount++;
    }

    static void invokeNextColor4(){
      extern Light light[];
      light[3].nextColor();
      light[3].colorChangeCount++;
    }

    TimedAction fadeOutTimer = TimedAction(100000, invokeNextColor1);
    TimedAction delayColorTimer = TimedAction(100000, invokeNextColor1);

    boolean checkSpeed() {
      if(beatSpeed > 1) {
        extern int beatDistance;
        if(beatDistance > 300) {
          int count = pow(2, beatSpeed - 1);
          void(*function[]) = {invokeNextColor1, invokeNextColor2, invokeNextColor3, invokeNextColor4};
          int delayTime = beatDistance / count;
          delayColorTimer = TimedAction(delayTime, function[lightNumber - 1]);
          colorChangeCount = 0;
          return true;
        }
      }
       return false;
    }
    
    void setLightSpeed(int lightSpeed) {
      twoBeatLimiter = lightSpeed == 0; 
      beatSpeed = lightSpeed;
    }

    void showColor() {
      extern int beatDistance;
      if(!fadeOut) {
        int colorIndex = currentColorNumber - 1;
        setRed(lightColors[colorIndex][0]); 
        setGreen(lightColors[colorIndex][1]);
        setBlue(lightColors[colorIndex][2]);
      }
     else if(beatDistance > 300) fadeOutTimer.check();
      if(beatSpeed > 1) {
        int count = pow(2, beatSpeed - 1) - 1;
        if(colorChangeCount <= count) delayColorTimer.check();
      }
    }


  private:

    int brightness = 50;
    int colorPins[3];
    int lightColors[8][3];
    int beatSpeed = 1;
    int colorChangeCount;
    float fadeColors[3];
    float fadeColorFactor[3];
    boolean twoBeatLimiter;
  
   void nextFadeOutValue() {
     for(int i = 0; i < 3; i++){
       if(i == 0) setRed(fadeColors[0]);
       else if(i == 1) setGreen(fadeColors[1]);
       else setBlue(fadeColors[2]);
       if(fadeColors[i] > 0) fadeColors[i] += fadeColorFactor[i];
       if(fadeColors[i] < 0) fadeColors[i] = 0;
     }
    }

    static void fadeCallToLight1(){
      extern Light light[];
      light[0].nextFadeOutValue();
    }

     static void fadeCallToLight2(){
      extern Light light[];
      light[1].nextFadeOutValue();
    }

    static void fadeCallToLight3(){
      extern Light light[];
      light[2].nextFadeOutValue();
    }

    static void fadeCallToLight4(){
      extern Light light[];
      light[3].nextFadeOutValue();    }
};

LiquidCrystal_I2C lcd(0x27,16,2); 
int counterPins[] = {50, 51, 52, 53};
int vuMeterPins[] = {48, 46, 44, 42, 49, 47};
int audioValues[] = {370, 400, 430, 460, 490, 520};
int keyboardLinePins[] = {32, 30, 28, 26};
int keyboardColumnPins[] = {36, 38, 34};
int currentBeat;
int limiter;
int brightnessMemory;
int beatDistance;
int speedMemory;
int selectionMemory;
boolean brigthnessControlComputer;
boolean computerConnected;
boolean speedControlComputer;
boolean mainButtonIsPressed;
boolean locked;
boolean pressedKeys[4][3];
String pendingCommands;

Light light[4] = {(1), (2), (3), (4)};

void setup() {
  lcd.init();
  lcd.backlight();
  lcd.print( "starting...");
  Serial.begin(115200);
  for(int pin : counterPins) pinMode(pin, OUTPUT);
  for(int vuPin : vuMeterPins) pinMode(vuPin, OUTPUT);
  for(int keyPin : keyboardLinePins) pinMode(keyPin, OUTPUT);
  for(int readingPin : keyboardColumnPins) pinMode(readingPin, INPUT_PULLUP);
  pinMode(A0,INPUT);
  pinMode(41, INPUT_PULLUP);
  light[0].connect(2, 3, 4);
  light[1].connect(8, 9, 10);
  light[2].connect(5, 6, 7);
}

TimedAction readingThread = TimedAction(10, readAudio);
TimedAction potentiometersThread = TimedAction(10, checkPotentiometers);
TimedAction keyboardThread = TimedAction(10, checkNumericKeyboard);

void readAudio() {
  int  input = analogRead(A0);
  int progress = map(input, 340, 510, 100, 0);
  String message = "-audio:" + String(progress);
  if(progress > 0) Serial.println(message);
  for(int i = 0; i < sizeof(vuMeterPins); i++) {
     digitalWrite(vuMeterPins[i], input < audioValues[i] ? HIGH : LOW);
  }
  updateAllLights(false);
  limiter = 0;
}

void checkPotentiometers(){
  int brightness = map(analogRead(A3), 1023, 0, 0, 100);
  setMasterBrightness(brightness, true);
  int value = analogRead(A2);
  if(abs(speedMemory - value) > 25){
    setMasterSpeed(map(value, 1020, 16, 0, 4), true);
    speedMemory = value;
  }
  int selectionValue = analogRead(A8);
  if(abs(selectionMemory - selectionValue) > 25) {
    Serial.println("-selection:" + String(selectionValue));
    selectionMemory = selectionValue;
  }
  if((digitalRead(41) == LOW)&&(mainButtonIsPressed == false)) 
    Serial.println("-button:startNext");
  mainButtonIsPressed = digitalRead(41) == LOW;
    
}

void setMasterBrightness(int brightness, boolean fromReal) {
  if((!brigthnessControlComputer) || (!fromReal)){
    for(int i = 0; i < 4; i++) {
      light[i].setBrightness(brightness);
    }
  }
  if(abs(brightnessMemory - brightness) > 4) {
    if(fromReal) brigthnessControlComputer = false;
    else brigthnessControlComputer = true;
    String text = "Brightness: " + String(brightness);
      if((!brigthnessControlComputer) || (!fromReal)){
        lcd.clear();
        lcd.print(text);
    }
    if(!brigthnessControlComputer) {
      Serial.println("-display:" + text);  
      brightnessMemory = brightness;
    }
  }
}

void setMasterSpeed(int lightSpeed, boolean fromReal) {
      if((!locked)||(!fromReal))
        for(int i = 0; i < 4; i++)
          light[i].setLightSpeed(lightSpeed);
      String values[] = {"2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt"}; 
      String text = "Color speed: " + values[lightSpeed];
      if(fromReal) Serial.println("-display:" + text);
      lcd.clear();
      lcd.print(text);
}

void loop() {
  String message = "";
  while(Serial.available()) {
      char c = Serial.read();
      message += c;
      delayMicroseconds(100);
  }
  if (message.length() > 0) {
    if(!computerConnected) {
      computerConnected = true;
      lcd.clear();
      lcd.print("Computer connected");
      Serial.println("-requestColors:all");
    }
    Serial.read();
    String key = message.substring(message.indexOf("-")+1, message.indexOf(':'));
    String data = message.substring(message.indexOf(':') + 1);
    recognizeCommand(key, data);
    delay(1);
  }
  readingThread.check();
  potentiometersThread.check();
  keyboardThread.check();
}

void recognizeCommand(String key, String data) {
    if(key.equals("beat")) {
      int number = data.toInt();
      if(number != 0) onBeat(number);
    }
    else if(key.equals("brightness")) setMasterBrightness(data.toInt(), false);
    else if(key.equals("colorSpeed")) setMasterSpeed(data.toInt(), false);
    else if(key.equals("beatDistance")) beatDistance = data.toInt();
    else if(key.equals("setColor")) setColor(data);
    else if(key.equals("colorCount")) setColorCount(data);
    else if(key.equals("fadeOut")) setMasterFadeOut(data.startsWith("True"));
    else if(key.equals("fadeIn")) setMasterFadeIn(data.startsWith("True"));
    else if(key.equals("locked")) locked = data.startsWith("True");
    else if(key.equals("disconnect")) computerConnected = false;
    else if(key.equals("skipToBeat")) skipToBeat(data.toInt());
    else if(key.equals("commands")) receiveMoreCommands(data);
    else if(key.equals("lcd")) {
      lcd.clear();
      lcd.print(data);
    }
    else Serial.println("unknown command");
}

void onBeat(int number) {
  currentBeat = number;
  updateAllLights(true);
}

void setMasterFadeOut(boolean fade) {
  for(int i = 0; i < 4; i++) light[i].fadeOut = fade;
}

void setMasterFadeIn(boolean fade) {
  for(int i = 0; i < 4; i++) light[i].fadeIn = fade;
}

void setColor(String data) {
  Serial.println("-setcolor" + String(data) + ":" + "  ");
  int lightNumber = data.substring(0, data.indexOf(",")).toInt();
  int colorNumber = data.substring(data.indexOf(",") + 1, data.indexOf(">")).toInt();
  int r = data.substring(data.indexOf(">") + 1, data.indexOf("/")).toInt();
  Serial.println("-setcolor" + String(r) + ":" + "  ");
  int g = data.substring(data.indexOf("/") + 1, data.lastIndexOf("/")).toInt();
  Serial.println("-setcolor" + String(g) + ":" + "  ");
  int b = data.substring(data.lastIndexOf("/") + 1).toInt();
  Serial.println("-setcolor" + String(b) + ":" + "  ");
  int values[] = {r, g, b};
  light[lightNumber].updateColor(colorNumber, values);
}

void setColorCount(String data) {
  int number = 0;
  int index = 0; 
  for(int i = 0; i < sizeof(data) + 2; i++) {
    if(data.substring(i, i+1).equals("/")){
      int count = data.substring(index, i).toInt();
      light[number].colorCount = count;
      index = i + 1;
      number++;
      Serial.println("-" + String(count) + ":" + "*");
    }
  }
}

void skipToBeat(int beat) {
   for(int i = 0; i < 4; i++) light[i].currentColorNumber = beat; 
}

void updateAllLights(boolean beat) {
  for(int i = 0; i < 4; i++) {
      digitalWrite(counterPins[i], currentBeat == i+1 ? HIGH : LOW);
  }
  for(int i = 0; i < 4; i++) {
    if(beat) { 
      if(!light[i].checkSpeed()) light[i].nextColor();
    }
    else light[i].showColor();
  }
}

void receiveMoreCommands(String data){
  data = data.substring(0, data.lastIndexOf(">"));
    Serial.println(data + "-" + String(data.endsWith("|")));
  while(data.endsWith("|")) {
    Serial.println("-k" + data.substring(0, data.indexOf("?")) + " :" + "dfvsmc");
    Serial.println("-k" + data.substring(data.indexOf("?") + 1, data.indexOf("|")) + ":" + "dfvsmc");
    recognizeCommand(data.substring(0, data.indexOf("?")), data.substring(data.indexOf("?") + 1, data.indexOf("|")));
    Serial.println("-qks" + data + " :" + data.substring(data.indexOf("?") + 1, data.indexOf("|")));
    data = data.substring(data.indexOf('|') + 1);
    Serial.println("-qs" + data + " :" + "dfvsmc");
  }
}

void checkNumericKeyboard(){
   String keys[4][3] = {{"1", "2", "3"},  //1, 0  2, 1  3, 2
                        {"4", "5", "6"},
                        {"7", "8", "9"},
                        {"*", "0", "#"}};
   for(int i = 0; i < 4; i++) {
     digitalWrite(keyboardLinePins[i], LOW);
     for(int j = 0; j < 3; j++) {
       boolean pressed = digitalRead(keyboardColumnPins[j]) == 0;
       if((!pressedKeys[i][j])&&(pressed))
         Serial.println("-keyboard:" + keys[i][j]);
       pressedKeys[i][j] = pressed;
     }
    digitalWrite(keyboardLinePins[i], HIGH);
   }
}
