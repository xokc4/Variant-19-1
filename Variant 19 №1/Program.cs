using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;

namespace v19_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eng = "abcdefghijklmnopqrstuvwxyz";
            string rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine("Введите предложение: ");

            string s = Console.ReadLine();

            string[] sentences = s.Split('!', '.', '?');

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(' ');
                foreach (string word in words)
                {
                    bool cRus = false;
                    bool cEng = false;
                    for (int k = 0; k < word.Length; k++)
                    {
                        if (eng.Contains(word.ToLower()[k]))
                        {
                            cEng = true;
                        }
                        if (rus.Contains(word.ToLower()[k]))
                        {
                            cRus = true;
                        }
                        if (cEng && cRus)
                        {
                            Console.WriteLine($"неверное слово {word} в {i + 1} предложении");
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Пока");
            Console.ReadLine();
        }
    }
}
