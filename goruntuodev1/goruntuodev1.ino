
int alinan;

void setup() {
  pinMode(2,OUTPUT);
   pinMode(3,OUTPUT);
    pinMode(4,OUTPUT);
     pinMode(5,OUTPUT);
      pinMode(6,OUTPUT);
       pinMode(7,OUTPUT);
        pinMode(8,OUTPUT);
         pinMode(9,OUTPUT);
          pinMode(10,OUTPUT);
          
          Serial.begin(9600);

}

void loop() {
  if (Serial.available()) { 
    
    alinan = Serial.read(); 
    Serial.print("Alinan Deger: ");
    Serial.print(alinan); 
    
  }


if(alinan=='1')
{


  digitalWrite(2,HIGH);
  digitalWrite(3,LOW);
  digitalWrite(4,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  
  }



else if(alinan=='2')

{
  digitalWrite(5,HIGH);
  digitalWrite(2,LOW);
  digitalWrite(4,LOW);
  digitalWrite(3,LOW);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  }


  else if(alinan=='3')

{
  digitalWrite(8,HIGH);
  digitalWrite(2,LOW);
  digitalWrite(3,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(9,LOW);
  digitalWrite(4,LOW);
  digitalWrite(10,LOW);
  }



  else if(alinan=='4')

{
  digitalWrite(9,HIGH);
  digitalWrite(5,LOW);
  digitalWrite(4,LOW);
  digitalWrite(2,LOW);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  digitalWrite(3,LOW);
  digitalWrite(10,LOW);
  }


 else if(alinan=='5')

{
  digitalWrite(6,HIGH);
  digitalWrite(2,LOW);
  digitalWrite(3,LOW);
  digitalWrite(4,LOW);
  digitalWrite(5,LOW);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  }


  else if(alinan=='6')

{
  digitalWrite(3,HIGH);
  digitalWrite(2,LOW);
  digitalWrite(7,LOW);
  digitalWrite(4,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  }
  


  else if(alinan=='7')

{
  digitalWrite(10,HIGH);
  digitalWrite(9,LOW);
  digitalWrite(4,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(3,LOW);
  digitalWrite(2,LOW);
  digitalWrite(8,LOW);
  digitalWrite(7,LOW);

  
  }



  else if(alinan=='8')

{
  digitalWrite(7,HIGH);
  digitalWrite(3,LOW);
  digitalWrite(9,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(4,LOW);
  digitalWrite(8,LOW);
  digitalWrite(2,LOW);
  digitalWrite(10,LOW);

  
  }


  else if(alinan=='9')

{
  digitalWrite(4,HIGH);
  digitalWrite(3,LOW);
  digitalWrite(7,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(10,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(2,LOW);

  
  }
  
  else if(alinan==0)
  {
    digitalWrite(2,LOW);
    digitalWrite(3,LOW);
  digitalWrite(4,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
    }
 

}
