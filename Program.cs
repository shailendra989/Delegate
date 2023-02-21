namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calculation obj = new Calculation(Delegatessc1.Addition);
            obj.Invoke(10,31);
            obj = Delegatessc1.Subtraction;
            obj(300,31);
            Console.ReadLine();
        }
    }
}