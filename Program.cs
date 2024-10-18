namespace threadsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Thread Thread1 = new Thread(new ThreadStart(Counter));
            Thread Thread2 = new Thread(new ThreadStart(CounterTwo));
            Thread1.Start();
            Thread2.Start();

            Thread1.Join();
            Thread2.Join();

            Console.WriteLine("nu är båda trådar klara");
            
        }
        static void CounterTwo()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
        
        static void Counter()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
