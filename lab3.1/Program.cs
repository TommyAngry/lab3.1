using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab3._1
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 для вывода группы сноубордистов, 2- для вывода лыжников" +
                "любую другую кнопку для выхода");
            while (true) 
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Snowboarder snowboarder = new Snowboarder();
                }
                if (a == 2)
                {
                    Skiers skiers = new Skiers();

                }
                else
                {
                    break;
                  
                }
            }
          

        }

    }
}

    
    
    



