using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNewYear
{
    class Program
    {
        //Записываем имена получателя, желания получателя в экземпляре санты
        // С помощью forech пробегаем по массиву сант
        // Случайным образом выбирает человека который Получает подарок проверяя что это не отправитель и удаляем имя из списка 
        // В файл с именем Дарящего добавляется Текст с описанием, рекомендации, Имя человека, список его дежалинй

        //Общий путь к каталогу с двумя папками: Санты и получатели
        public string path = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы программы");

            Santa[] pullSants = new Santa[2];


            //Добавляем имена сант и желания
            foreach (Santa santa in pullSants)
            {
                santa.santasName = ReadFiles();
                santa.santasWish = ReadFiles();
            }


           


        }

        static string ReadFiles()
        {
            // индивидуальный путь
            return "";
        }

        static void WriteFile(string text)
        {
            // индивидуальный путь
        }
    }
}
