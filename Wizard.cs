using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Wizard : Warrior //унаследован от класса воин
    {
        
        public int magicDamage = 30; // добавляем новое поле
       
        //констуркторы
        public Wizard(string hero_name) : base(hero_name) //унаследованный метод создания экземпляра героя
        {
            this.classID = 2;
            this.name = hero_name;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = this.health - rnd.Next(10, 40); // волшебник наносит меньший урон и у него меньше жизней
            this.damage = this.damage - rnd.Next(5, 15);
            this.mana = 100 + rnd.Next(-20, 20);
        }
        public Wizard() // создаем с заданными значениями
        {
            this.classID = 2;
            this.name = "Merlin";
            this.health = this.health - 20;
            this.damage = this.damage - 10;
        }

        //методы
        // override позволяет нам перегрузить методы 
        public override int MagicAttack()  // у волшебника есть свой метод магической атаки
        {
            this.mana -= 10;
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                return this.magicDamage + rnd.Next(1, 10); ;
            }
            else
            {
                return 0;
            }
        }
        public new int getMana() => this.mana;  // вернуть количество очков маны героя
    }
}
