using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    public class Snowboarder:SkySportsman
    {
       public override List<User> GetContent()
       {
            Group group = new Group() { Name = "Сноубордисты" };
            List<User> users = new List<User>()
            {
                new User{Name = "Ivan", Age = 18, Group = group},
                new User{Name = "Lena", Age = 20, Group = group},
                new User{Name = "Petya", Age = 20, Group = group},
                new User{Name = "Sasha", Age = 19, Group = group},
            };
            return users;
        }
    }
}
