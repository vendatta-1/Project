namespace Project;
public class Program
{
    public static void Main()
    {
        try
        {

            using var file = File.Open("Text.txt", FileMode.Append);

            //file.Dispose();

            //TextWriter
            //TextReader
            //StreamReader
            //StreamWriter
            //StreamContent
            //Stream


            file.Close();

            File.WriteAllText("Text.txt", "Content2");



        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }





    }
    private static int Sum(int x, int y, out int result)
    {
        return result = x + y;
    }
}


/// first must have a department without ProjectList and EmployeeList
/// Employee without projectList
/// Project without  EmployeeList