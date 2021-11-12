using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
             * Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
             * Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
             * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
            angle angle1 = new angle(20,3, 1);
                       
            Console.WriteLine("Угол задан градусами ,минутами и секундами. Требуется перевести в радианы");
            Console.WriteLine("Градусы  {0}", angle1.gradus);
            Console.WriteLine("Минуты  {0}", angle1.min);
            Console.WriteLine("Секунды  {0}", angle1.sec);

            angle1.ToRadians(20, 2, 1);
            
            Console.ReadKey();

        }
    }
    class angle
    {//поля 
        public int gradus;
        public int min;
        public int sec;


        
        //Конструктор 
        public angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        //метод
        public void ToRadians(int gradus, int min, int sec)
        {
             
           double S= ((gradus+ (min/60)+ (sec /3600))* Math.PI) / 180.0;
            Console.WriteLine("Угол в радианах: {0:N3} ", S);


        }





    }
}
