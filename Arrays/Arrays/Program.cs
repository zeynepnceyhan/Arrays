namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Zeynep";
            students[1] = "Nadir";
            students[2] = "Elif";


            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}