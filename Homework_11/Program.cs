namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary array = new OtusDictionary();
            array.Add(2, "значение 1");
            array.Add(5, "значение 2");
            //array.Add(2, "kjj");
            array.Add(10, "значение 3");
            array.Add(130, "значение 5");
            array[6] = "5"; ;
            
            Console.WriteLine(array.Get(13));
            Console.WriteLine(array.Get(5));
            Console.WriteLine(array[6]);
            
        }
    }
}