namespace Delegate
{
    //public delegate int AddDelegate(int a, int b);
    public delegate void RectDel(double x, double y);

    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)

        {
            var reult=Add(10, 20);
            //AddDelegate newResult = new AddDelegate(Add);
            //var result = newResult(80,20);
            //Console.WriteLine(result);
            //Console.ReadLine();



            Rectangle rect= new Rectangle();
            RectDel rectDel = new RectDel(rect.GetArea);
            rectDel += rect.GetPerimeter;
            rectDel.Invoke(17.77, 40.22);
            Console.ReadLine();

        }
    }
}