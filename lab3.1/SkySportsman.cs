using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    //нахождение чела из списка по группе или по имени или по фамилии
    public partial class SkySportsman
    {
       
       public SkySportsman()
        {
           
            List<User> users = GetContent();
            Print(users);
        }
       



        private static void Print(List<User> users)//вспомогательный метод - выводит на экран коллекцию
        {
            int x = 1;
            foreach (var us in users)
            {
                Console.WriteLine(x + ". " + us);
                x++;
            }
        }



        public  virtual List<User> GetContent()//вспомогательный метод формирует коллекцию
        {
            
            List<User> users = new List<User>()
            {
               
            };
            return users;
        }
      
    }
}       

