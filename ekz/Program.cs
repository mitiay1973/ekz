using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ekz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите сумму вклада: ");
                double symma = Convert.ToInt32(Console.ReadLine());      //
                Console.Write("Введите длительность вклада (недель): "); // Ввод входных параметров
                int time = Convert.ToInt32(Console.ReadLine());          // 
                metodi metodi = new metodi();
                Console.WriteLine("Результат записан в файл");
                File.WriteAllText("otvet.txt", "Процент вклада "+Convert.ToString(metodi.Procenti(symma, time)));
                Console.ReadKey();
            }
            catch (Exception)
            {
                TextWriterTraceListener[] traceListener = new TextWriterTraceListener[1];
                {
                    new TextWriterTraceListener("debug.txt"); // Отладочные классы
                }
                Debug.Listeners.AddRange(traceListener);
                Debug.WriteLine("Обнаружена ошибка");
                Debug.Flush();
            }
        }
    }
}
