using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Реализовать приложение текстовый квест.
В игре должно быть не менее трех персонажей. 
У каждого из персонажей есть некоторое количество жизней, здоровья и определенный навык 
(например: волшебство, оружие и т.д.).

Приложение может иметь частичную реализацию, при этом в каждом классе могут быть описаны:
- поля(с комментариями к каждому полю)
- констуркторы
- методы (можно без реализации, но с подробным коментарием, что данный метод делает)

*/

namespace Quest
{
    internal class Warrior : IHero // унаследован от интерфейса
    {
        //поля
        public int classID = 1;         // ID, по которому будем проверять класс героя в течении игры 
        public string name = "Conan";   // имя героя
        public int health = 100;        // количество очков здоровья
        public int damage = 20;         // количество очков урона
        public int mana = 20;           // количество очков маны

        //констуркторы
        public Warrior(string hero_name) //конструктор с именем
        {
            this.name = hero_name;
            Random rnd = new Random(); //задаем поля героя со случайным коофициентом
            this.health = 100 + rnd.Next(-10, 30);      
            this.damage = 20 + rnd.Next(-5, 5); 
        }
        public Warrior() { } //создание героя с полями по умолчанию

        //методы
        public int Attack() // метод атаки: попал или нет
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                return this.damage;
            }
            else
            {
                return 0;
            }
        }
        // virtual позволит нам перегрузить методы ниже в других классах-наследниках
        public virtual int MagicAttack() // воин не умеет в магчиескую атаку
        {
            return 0;
        }

        public virtual int hiddenAttack() // воин не умеет в скрытую атаку
        {
            return 0;
        }

        public int getClassID() => this.classID;    // вернуть id класса героя
        public string getName() =>this.name;    // вернуть имя героя
        public int getHealth() => this.health;  // вернуть количество очков здоровья героя
        public int getDamage() => this.damage;  // вернуть занчение атаки героя
        public int getMana() => this.mana;  // вернуть количество очков маны героя
        public void setHealth(int newHealtch) => this.health = newHealtch;  // задать здоровье героя
        public void setDamage(int newDamage) => this.damage = newDamage;    // задать атаку героя
        public int addHealth(int addHealth) //добавить здоровья герою
        {
            this.health += addHealth;
            return this.health;
        }
        public int addDamage(int addDamage)  //доабвить атаки героюы
        {
            this.damage += addDamage;
            return this.damage;
        }  

    }

    
}
