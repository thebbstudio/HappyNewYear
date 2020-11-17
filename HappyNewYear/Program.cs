using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNewYear
{
    class Program
    {

        //Список имён
        public static Santa[] pullSants ;
        
        static void ReadAndWriteFiles(string path)
        {

        }

        static void Main(string[] args)
        {
            pullSants = new Santa[2];
            Console.WriteLine("Начало работы программы");

            for(int i = 0; i < pullSants.Length; i++)
            {
                Console.WriteLine("Name?");
                pullSants[i].santasName = Console.ReadLine();

            }
            //Записываем имена получателя, желания получателя в экземпляре санты
            // С помощью forech пробегаем по массиву сант
            // Случайным образом выбирает человека который Получает подарок проверяя что это не отправитель и удаляем имя из списка 
            // В файл с именем Дарящего добавляется Текст с описанием, рекомендации, Имя человека, список его дежалинй


        }
    }
}
