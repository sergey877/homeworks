// Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.

System.Console.WriteLine("intput first number: ");
 int n = Convert.ToInt32(Console.ReadLine());

 if(n>=10 && n<=99)
 {
   int ed=n%10;
   int dec=n/10; 
   System.Console.WriteLine( $"{dec},{ed}"); 
 }  
 else if (n>=100 && n<=999)
 {   
    int sot=n/100;
    int dec=n/10%10;
    int ed=n%10;
      
   System.Console.WriteLine( $"{sot},{dec},{ed}"); 
 }