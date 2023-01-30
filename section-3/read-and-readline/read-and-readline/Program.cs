namespace read_and_readline
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello\t" + name + " \t how are you?");// this is doing the string var above which is looking for an input from the user
            int ascicode = Console.Read();
            Console.WriteLine("ASCI CODE INFORMATION IS AS FOLLOWS \t" + ascicode);


            Console.ReadKey();// gives you the ASCI code equivalant for the first let of the word you typed

            

        }
    }
}