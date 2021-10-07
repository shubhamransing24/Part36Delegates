using System;

namespace Part36Delegates
{
   public delegate void HelloFromDele(string strmassage);
    class Program
    {
        
        static void Main(string[] args)
        {
            HelloFromDele dele = new HelloFromDele(Hello);
            dele("Hello From Delegate");
        }
        public static void Hello(string strmassage)
        {
            Console.WriteLine(strmassage);
        }
    }
}
