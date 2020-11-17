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

        static Santa[] pullSants = new Santa[2];

        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы программы");


            pullSants[0].Name = "Ivan";
            pullSants[1].Name = "Peter";

            //Добавляем имена сант и желания
         //   foreach (Santa santa in pullSants)
         //   {
         //       santa.Name = ReadFiles();
         //       santa.santasWish = ReadFiles();
         //   }
            //Находим сантам получателей 
            foreach (Santa santa in pullSants)
            {
                santa.giftRecipient = searchRecipient(santa.giftRecipient);
            }



        }

        static string searchRecipient(string santaName)
        {

            Random rnd = new Random();

            string name = pullSants[Convert.ToInt32(rnd)].Name;
            if (santaName == name )
                return searchRecipient(santaName);
            else
                return name;

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
