namespace C_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 12, 15, 19, 29, 14, 25, 26 };

        input:
            Console.WriteLine("Enter your age: ");
            bool check = int.TryParse(Console.ReadLine(), out int inputNum);

            if (!check)
            {
                Console.WriteLine("Not number");
                goto input;
            }

            bool output = false;
            foreach (int i in arr)
            {
                if (i == inputNum)
                {
                    output = true;
                    break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
