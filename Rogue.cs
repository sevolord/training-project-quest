using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Rogue : Warrior //унаследован от класса воин 
    {
        //поля
        public int hiddenDamage = 30; // свое поле с скрытой атаки

        //констуркторы
        public Rogue(string hero_name) : base(hero_name)//унаследованный конструктор    
        {
            this.classID = 3;
            this.name = hero_name;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = this.health - rnd.Next(0, 30); // волшебник наносит меньший урон и у него меньше жизней
            this.damage = this.damage - rnd.Next(0, 10);
        }
        public Rogue() : base() //конструкто с заданными характеристиками 
        {
            this.classID = 3;
            this.name = "Bilbo";
            this.health = 100;
            this.damage = 15;
        }
        // override позволяет нам перегрузить методы 
        public override int hiddenAttack() //скрытая атака. Мощная, но реже выпадает
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 5);
            if (result % 2 == 0)
            {
                return this.hiddenDamage;
            }
            else
            {
                return 0;
            }
        }
    }
}
