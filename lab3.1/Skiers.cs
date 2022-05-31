using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    public class Skiers:SkySportsman
    {
        public override List<User> GetContent()
        {
            
            List<User> users = new List<User>()
            {
                new User{Team="Grozny",Name="Liza",Age = 38, Group="Мастер спорта"},
                new User{Team= "Developers",Name = "Ilya", Age = 18, Group = "Юношеский разряд"},
                new User{Team= "Developers",Name = "Vany", Age = 20},
                new User{Team="Grozny",Name = "Igor", Age = 20, Group = "Мастер спорта"},
                new User{Team= "Developers",Name = "Sasha", Age = 19},
                  new User{Team="la-la card",Name="Yra",Age = 45},
            };
            return users;
        }
    }
}
