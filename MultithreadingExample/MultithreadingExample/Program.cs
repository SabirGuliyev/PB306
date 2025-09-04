namespace MultithreadingExample
{
    internal class Program
    {
        public static int Count { get; set; } = 0;
        
        private static readonly object LockObject = new();
        static async Task Main(string[] args)
        {
            //Thread thread = new Thread(GetFirst);
            //Thread thread2=new Thread(GetSecond);


            //thread.Start();
            //thread2.Start();


            ////Console.WriteLine("!");

            //thread.Join();
            //thread2.Join();

            //Console.WriteLine(Count);
            
          await Task.WhenAll(Test(), Test2());


            Console.WriteLine("Program bitdi");




            //Task
            //Console.WriteLine("Main thread code ushe dushdu  khagshdahsdv asjhvdajhsvdjv savdsahvd");
        }
        

        public static async Task Test()
        {
           await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {

                    Console.WriteLine($"1-ci dovr ishleyir{i}");

                }
            });

        }

        public static async Task Test2()
        {
           await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {

                    Console.WriteLine($"2-ci dovr{i}");

                }
            });

        }


        public static void GetFirst()
        {
            for (int i = 0; i < 100000; i++) {

                //lock (LockObject)
                //{
                //    lock (LockObject2)
                //    {
                //        Count++;
                //    }
                   
                //}
                //Console.WriteLine($"1-ci dovr ishleyir{i}");
               
            }
        }
        public static void GetSecond()
        {
            for (int i = 0; i < 100000; i++)
            {
                //lock (LockObject2)
                //{
                //    lock (LockObject)
                //    {
                //        Count--;
                //    }
                //}
               
                //Console.WriteLine($"2-ci dovr{i}");
               
            }
        }
    }
}
