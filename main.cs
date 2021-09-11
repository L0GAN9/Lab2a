using System;

class Program {
  public static void Main (string[] args) {

   Console.WriteLine("Enter Name of Item");

   var Name = Console.ReadLine();

   Console.WriteLine("Enter Quantity");

   var x = Console.ReadLine();

   Console.WriteLine("Enter Price");

   var y = Console.ReadLine();

   Console.Write("Total Price of ");
   Console.WriteLine(Name);

   double x1 = Convert.ToDouble(x);
   
   double y1 = Convert.ToDouble(y);

   Console.WriteLine(x1*y1);
  }
}