using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine("1.Reqem: ");
        int reqem1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2.Reqem: ");
        int reqem2 = int.Parse(Console.ReadLine());
        var toplam = Cem(reqem1, reqem2);
        Console.WriteLine(toplam);
    }
    
    static int Cem(int req1, int req2){
        int cem2=0;
        while(req1<=req2)
        {
            cem2+=req1;
            req1++;
        }
        return cem2;
    }
}