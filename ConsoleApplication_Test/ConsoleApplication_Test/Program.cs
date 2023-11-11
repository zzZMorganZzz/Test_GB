using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Test
{
    class Program
    {
        static List<string> _repo = new List<string>();
        static int Len = 3;


        static void Main(string[] args)
        {
            string tmp = string.Empty;
            Console.WriteLine("Тестовое итоговое задание.");
            do
            {
                Console.Write("Введите слово: ");
                tmp = Console.ReadLine();
            } while (FillList(tmp));

            Console.Write("Слова длинной {0} символа:", Len);

            string rep = string.Join(", ", _repo);
            string rez = string.Join(", ", _repo.Where(item=>item.Length==Len));
            Console.WriteLine(string.Format("[{0}] => [{1}]", rep, rez));
            Console.ReadLine();


            
        }

        static bool FillList(string value)
        { 
            if(value.Length!=0)
            {
                _repo.Add(value);
                return true;
            }
            return false; 
        }

        //static List<string> GetItem()
        //{
        //    List<string> _rezult = new List<string>();
        //    foreach (string item in _repo)
        //    {
        //        if (item.Length == Len)
        //        {
        //            _rezult.Add(item);
        //        }
        //    }
        //    return _rezult;
        //}

    }
}
