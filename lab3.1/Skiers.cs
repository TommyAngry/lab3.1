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
            Group group = new Group() { Name = "Лыжники" };
            List<User> users = new List<User>()
            {
                new User{Name = "Ilya", Age = 18, Group = group},
                new User{Name = "Vany", Age = 20, Group = group},
                new User{Name = "Igor", Age = 20, Group = group},
                new User{Name = "Sasha", Age = 19, Group = group},
            };
            return users;
        }
    }
}
