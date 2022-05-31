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
            List<User> users = new List<User>()
            {
                new User{Team="TrueCommand",Name="Inna",Age = 29 },
                new User{Team = "Strela", Name = "Ivan", Age = 18},
                new User{Team="TrueCommand",Name = "Lena", Age = 20, Group="1-разряд"},
                new User{Team = "Strela", Name = "Petya", Age = 20, Group = "3-разряд"},
                new User{Team="TrueCommand",Name = "Sasha", Age = 19, Group = "1-рязряд"},
           
            };
            return users;
        }
    }
}
