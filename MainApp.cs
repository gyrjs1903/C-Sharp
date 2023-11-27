namespace Hello
{
    class MainApp
    {
        //프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length ==0) {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
