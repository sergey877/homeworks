// Напишите программу, которая принимает на вход целое 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("intput first number:10 end 99 ");
 int n = Convert.ToInt32(Console.ReadLine());
 
 if(n>10 && n<99)
 {
   int ed=n%10;
   int dec=n/10;
   int max =0;
   if(ed<dec)
   {
    max=dec;
    System.Console.WriteLine(max);
   }
   else
   {
    max=ed;
    System.Console.WriteLine(max);
   }

 }
 else
 {
    System.Console.WriteLine("неправильное число");
 }


