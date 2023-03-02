using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Monster : Warrior //все монстры - наследники война
    {
        public Monster(string monster_name) : base(monster_name)  //конструктор с именем
        {
            this.name = monster_name;
            Random rnd = new Random(); //задаем поля монстра со случайным коофициентом, что бы он был слабее героя
            this.health = 50 + rnd.Next(0, 30);
            this.damage = 5 + rnd.Next(0, 5); 
        }

    }
}
