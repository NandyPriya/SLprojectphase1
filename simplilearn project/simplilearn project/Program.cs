using System;
using System.IO;


namespace simplilearn_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            try
            {
                StreamReader g = new StreamReader("D:\\p1.txt");
               
                a = g.ReadLine();
               
                while (a != null)
                {
                    Console.WriteLine(a);
                    
                    a = g.ReadLine();
                }
                g.Close();
               
               
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            Console.ReadLine();
        }
    }
}
