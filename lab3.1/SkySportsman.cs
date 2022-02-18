using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    //нахождение чела из списка по группе или по имени или по фамилии
    public class SkySportsman
    {
       
       public SkySportsman()
        {
           
            List<User> users = GetContent();
            Console.WriteLine("Стартовый объект");
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

            Group group = new Group();
            List<User> users = new List<User>()
            {
               
            };
            return users;
        }


        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Group Group { get; set; }
            public override string ToString()
            {
                return $"{Name} \t {Group.Name}  \t {Group.Name}";
            }
        }


        public class Group
        {
            public string Name { get; set; }    
        }


      
    }
}       

