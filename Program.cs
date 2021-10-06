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
                //Передайте путь к файлу и имя файла конструктору StreamReader
                StreamReader sr = new StreamReader("..\\..\\input.txt");
                //Прочитайте первую строку текста
                line = sr.ReadLine();
                //Продолжайте читать, пока не дойдете до конца файла
                while (line != null)
                {
                    //напишите строку в окно консоли
                    Console.WriteLine(line);
                    //Прочтите следующую строчку
                    line = sr.ReadLine();
                }

                StreamWriter sw = new StreamWriter("..\\..\\output.txt");
               
                //Close the file
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
