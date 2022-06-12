using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static StreamWriter Yaz = null;
        static void Main(string[] args)
        {

            try
            {
                Yaz = new StreamWriter(@"C:\Users\TUNAHAN\source\repos\RandomNumberGenerator\data2.txt");
                for (int i = 0; i < 1000000; i++)
                {
                    //Console.Write(RandomNumberGenerator.Instance.Generate(0, 1)+" ");

                    Yaz.Write(RandomNumberGenerator.Instance.Generate(0, 1) + ";");
                }

            }
            catch (Exception ex)
            {


                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                Yaz.Flush();
                Yaz.Close();

            }




        }
    }
}