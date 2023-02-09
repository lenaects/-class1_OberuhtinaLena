using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    //zad1-2
    public class Tel
    {
        public int day;
        public double time;
        public double price;

        public void telephone_call()
        {
            if (day > 0 & day < 8)
            {
                if (day == 6 || day == 7)
                {
                    price *= 0.9;
                }
                double full_call_price = day * time * price;
                Console.WriteLine("Стоимость телефоного разговора равна " + full_call_price);
            }
            else Console.WriteLine("Ошибка. Введите данные повторно");
        }
    }
    //zad3
    public class Input
    {
        public void input_sqare()
        {
            Console.WriteLine("Квадрат числа больше 25!");
        }
    }

    public class Find_square
    {
        public int first_number;
        public int last_number;
        public int find_number;

        public void method_stop_sqare() //Ищет квадрат числа от одного до десяти
        {
            for (int i = first_number; i <= last_number; i++)
            {
                int sqare_number = i * i;
                if (sqare_number > find_number)
                {
                    Input txt = new Input();
                    txt.input_sqare();
                    break;
                }
                Console.WriteLine(sqare_number);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1-2
            Tel call = new Tel();
            Console.WriteLine("Введите день разговора");
            call.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время разговора");
            call.time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость");
            call.price = Convert.ToDouble(Console.ReadLine());
            call.telephone_call();

            //zad3
            Find_square zad3 = new Find_square();
            zad3.first_number = 1;
            zad3.last_number = 10;
            zad3.find_number = 25;
            zad3.method_stop_sqare();
            Console.ReadLine();
        }
    }
}
