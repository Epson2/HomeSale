using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Sales person's: danielle, edward, francis");
    string initial = "";
    double d = 0.00;
    double e = 0.00;
    double f = 0.00;
    double x = 0.00;

    while (initial != "z"){
      Console.WriteLine("please enter a sales persons first initial(D,E,F, Z to exit): ");
      initial = Console.ReadLine().ToLower();

      if (initial == "d" || initial == "e" || initial == "f"){
        Console.WriteLine("enter number of sales: ");
        double sales = Convert.ToDouble(Console.ReadLine());

        if (initial == "d"){
          d += sales;
        }
        else if (initial == "e"){
          e += sales;
        }
        else if (initial == "f"){
          f += sales;
        }
        x = d + e + f;
      }
      else{
          Console.WriteLine("Error, invalid salesperson, please try again");
        }
    }
    Console.WriteLine("\nDanielle's amount: {0:c}" + "\nEdward's amount: {1:c}" + "\nFranci's amount: {2:c}" + "\n\nTotal: {3:c}", d,e,f,x);

    if(d>e){
        Console.WriteLine("highest amount: D");
      }
    else if(e>f){
        Console.WriteLine("highest amount: E");
      }
    else if(f>e){
        Console.WriteLine("highest amount: F");
      }
  }
}