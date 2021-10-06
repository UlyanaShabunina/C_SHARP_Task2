using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\input.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                
                StreamWriter sw = new StreamWriter("..\\..\\output.txt");
               
                sr.Close();
                sw.Close();
                File.Copy("..\\..\\input.txt", "..\\..\\output.txt", true);
                File.WriteAllText("..\\..\\output.txt", File.ReadAllText("..\\..\\output.txt", Encoding.Default).Replace(". ", "\n"));
                
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
