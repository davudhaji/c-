/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("1.Reqem: ");
    int reqem1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2.Reqem: ");
    int reqem2 = int.Parse(Console.ReadLine());

    

    var tuple = end(reqem1, reqem2);
    Console.WriteLine("Cem: "+tuple.Item1);
    Console.WriteLine("Hasil: "+tuple.Item2);
  }
  static Tuple<int,int> end(int eded1, int eded2){
    int cem = eded1 + eded2;
    int hasil = eded1 * eded2;
    return new Tuple<int,int>(cem,hasil);
  }    
}
