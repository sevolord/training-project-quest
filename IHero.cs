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
https://metanit.com/sharp/tutorial/3.9.php
*/
namespace Quest
{
    internal interface IHero //интерфейс героя
    {
        // методы
        public int Attack();        // атака
        public int MagicAttack();   // магичсекая атака
        public int hiddenAttack();  // скрытая атака.
        public int getClassID();    // возвращает id класса - для првоерок по ходу игры, за кого мы играем     
        public string getName();    //  возварщает имя персонажа
        public int getHealth();     //  возвращает текущее здоровье персонажа
        public int getDamage();     //  возвращает текущий урон персонажа
        public int getMana();  // вернуть количество очков маны героя
        public void setHealth(int newHealtch); //установить уровень очков здоровья
        public void setDamage(int newDamage);   //установить уровень очков урона
        public int addHealth(int addHealth);    //добавить очков здоровья
        public int addDamage(int addDamage);    //добавить очков урона

    }
}
