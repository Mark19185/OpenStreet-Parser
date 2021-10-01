using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStreet_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Для начала парсинга введите адрес:");
             string adress = Console.ReadLine();
             Console.WriteLine("Теперь необходимо ввести название выходного файла (без расширения):");
             string filename = Console.ReadLine();
             Console.WriteLine("Введите офсет между точками:");
             int offset = 1;
             if (int.TryParse(Console.ReadLine(), out offset))
             {
                 Models.OSM _OSM = new Models.OSM(adress, $"{filename}.txt", offset == 0 ? offset = 1:offset);
                 try
                 {
                     _OSM.ProcessAdress();
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.Message);
                 }
             }
             else
             {
                 Console.WriteLine("Укажите корректный шаг!");
             }
             Console.WriteLine("\nЗавершено\nнажмите любую клавишу для того, чтобы начать процесс парсинга заного");
             Console.ReadKey();
             Console.Clear();
             Main(null);*/
            Type t = Type.GetType("OpenStreet_Parser.Models.OSM");
            var methods = from m in t.GetMethods(System.Reflection.BindingFlags.Static) select m.Name;
        }
    }
}
