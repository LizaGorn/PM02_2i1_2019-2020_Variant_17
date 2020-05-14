using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.IO;

namespace wordscount
{
    class Program
    {
        static void Main(string[] args)
        {                   
            string O = "" ;             
            string[] X;
            StreamReader G = new StreamReader("file.txt",System.Text.Encoding.Default);
            Console.OutputEncoding = Encoding.GetEncoding(866);
            while (G.EndOfStream != true)
            {
                O = G.ReadLine();                
            }
            X = O.Split(' ');
            Console.WriteLine("Количество слов:");             
            Console.WriteLine(X.Length);
            G.Close();
            Console.ReadLine();
        }
    }
}