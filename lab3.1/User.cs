namespace lab3._1
{
    public partial class SkySportsman
    {
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Group { get; set; }
             public string Team { get; set; }
            public override string ToString()
            {
                return $"Команда {Team}\n {Name}  \t возраст- {Age} \t {Group}";
            }
            public User()
            {

            }
            public User(string name,int age, string group)
            {
                Name = name;
                Age = age;
                Group = group;
            }
            public User(string name, int age, string team, string group)
            {
                Name = name;
                Age = age;
                Group = group;
                Team = team;

            }


        }


      
    }
}       

