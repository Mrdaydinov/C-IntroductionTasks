namespace C_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    int[] arr = { 1, 2, 3, 12, 15, 19, 29, 14, 25, 26 };

            //input:
            //    Console.WriteLine("Enter your age: ");
            //    bool check = int.TryParse(Console.ReadLine(), out int inputNum);

            //    if (!check)
            //    {
            //        Console.WriteLine("Not number");
            //        goto input;
            //    }

            //    bool output = false;
            //    foreach (int i in arr)
            //    {
            //        if (i == inputNum)
            //        {
            //            output = true;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(output);


            string[] students = { "Eli", "Veli", "Pirveli", "Kenan", "Hikmet" };

        input:
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();


            bool flag = false;
            foreach (string student in students)
            {
                if (name == student)
                    flag = true;
            }

            if (flag)
                Console.WriteLine(name);
            else
            {
                Console.WriteLine("Student not found");
                goto input;
            }
        }
    }
}
