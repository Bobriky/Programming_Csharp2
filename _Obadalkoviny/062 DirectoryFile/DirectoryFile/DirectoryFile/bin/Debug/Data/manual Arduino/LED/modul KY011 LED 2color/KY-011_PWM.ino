int Led_Red = 10;
int Led_Green = 11;
 
int val;
 
void setup () {
  // Output pin initialization for the LEDs
  pinMode (Led_Red, OUTPUT); 
  pinMode (Led_Green, OUTPUT); 
}
void loop () {
   // In this for loop, the two LEDs will get different PWM-Values. 
   // Via mixing the brightness of the different LEDs, you will get different colors. 
   for (val = 255; val> 0; val--)
      {
      analogWrite (Led_Green, val);
      analogWrite (Led_Red, 255-val);
      delay (15);
   }
   // You will go backwards through the color range in this second loop.
   for (val = 0; val <255; val++)
      {
      analogWrite (Led_Green, val);
      analogWrite (Led_Red, 255-val);
      delay (15);
   }
}
