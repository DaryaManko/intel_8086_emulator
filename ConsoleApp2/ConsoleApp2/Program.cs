using System;

//class Program
//{
    // static int metoda (int a, int b)
    // {
    //      return a + 10 - b;
    // }
    //static void Main()
    // {
    //   Func<int, int,int> d1 = metoda;
    // Console.WriteLine(" wynik : " + d1(10, 8));
    //     Console.In.ReadLine();
    // }

    //static bool metoda(int a)
    //  {
    //  return (a != 10);
    // }
    //static void Main()
    // {
    //   Predicate<int> d1 = metoda;
    //  Console.WriteLine(" wynik : " + d1(9));
    //   Console.In.ReadLine();
    // }

    public class Watek
{
   // public static void metoda()
   // {
     //   int p = 0;
     //   while (true)
      //  {
          //  Thread.Sleep(500);
            //p++;
           // Console.WriteLine("licznik: " + p);
       // }

    static readonly object obj = new object();

    public static void metoda()
    {
        int p = 0;
        lock (obj)
        {
            int d = 0;
            Console.WriteLine("Komunikat z watku");
            while (p < 10)
            {
                Thread.Sleep(500);
                p++;
                Console.WriteLine("licznik: " + p);
            }
            {
                Console.WriteLine("zatrzymano watek");
            }
        }
    }
    }
    class Program
    {
        public static void Main()
        {
            Thread w1 = new Thread (new ThreadStart(Watek.metoda)); 
            Thread w2 = new Thread (new ThreadStart(Watek.metoda)); 
            w1.Start();
            w1.Join();
            w2.Start();
            Thread.Sleep(3000);
            new Thread(new ThreadStart(Watek.metoda)).Start();  
            Console.ReadKey(true);
        }
    }



    

