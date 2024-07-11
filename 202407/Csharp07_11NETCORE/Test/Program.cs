namespace Test
{

    internal class Program
    {

        public void Run()
        {
            Console.Write(Question);
        }
        public bool Question()
        {   
            bool isA = true;
            bool isB = false;
            bool isC = true;
            bool isD = false;
            return !(((isA && isC) || isB) && ((isA && isB) == isD) == true);
        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
