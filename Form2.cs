using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
     public partial class Game : Form
    {
        IHero hero;//объявляем героя в виде интерфейса, потом назначим как один из классов
        private int currentStep = 0;//глобальная переменная текущего этапа в истории
        private bool battle = false;//флаг, а не режим ли боя сейчас
        Monster curMonster; //глобальный объект с текущим монстром, если сражаемся
        public Game(int heroClass,string heroName) //перегруженный конструктор формы
        {
            InitializeComponent();
            if (heroClass == 0) // в зависимости от переданного значения определяем класс героя
                hero = new Warrior(heroName);
            else if (heroClass == 1)
                hero = new Wizard(heroName);
            else if (heroClass == 2)
                hero = new Rogue(heroName);
            //выводим данные о герое
            LHeroName.Text = hero.getName();
            updateHeroStats(); // отдельный метод обновления данных о герое. т.к. они меняются в ходе игры
            startStep(); //запускаем игру
        }    

        private void startStep()
        {
            //вместо этих функций можно создать класс игры, в котором будут списки с текстами ходов
            //и действий
            //а так же возможность загружать всю историю из файла
            if (currentStep == 0)
            {
                printStep("Пройдя долгий путь, вы оказались перед воротами ужасного замка\n" +
                "вашего заклятого врага: Скелетрона.\n" +
                "Вы можете войти в ворота замка или трусливо сбежать",
                 "Войти в дверь", "Сбежать");
            }
            else if (currentStep == 1)
            {
                printStep("Дверь перед вами открывается, вы видите динный коридок, увешанный чадящими факелами",
                            "Идти по коридору", "Убежать из замка");
            }
            else if (currentStep == 2)
            {
                printStep("Вы идете по коридору, внимательно вглядываясь вперед." +
                    "Вдруг одна из статуй горгулий начинает медленного двигаться, и, разбрасывая каменную крошку, идет к вам",
                            "Атаковать", "Убежать из замка", "попробовать обойти горгулью");
            }
            else if (currentStep == 3)
            {
                if (hero.getClassID() == 1) printStep("Завязывается бой", "Атака");
                else if (hero.getClassID() == 2) printStep("Завязывается бой", "Атака", "Магическая атака");
                else if (hero.getClassID() == 3) printStep("Завязывается бой", "Атака", "Скрытая атака");
                curMonster = new Monster("Горгулья"); // назначаем текущего монстра 
                battle = true; // включаем режим сражения
            }
            else if (currentStep == 4)
            {
                printStep("Вы продолжаете идти по коридору. " +
                    "Коридор оканчивается высокими и массивными воротами." +
                    "Налево из коридора идет проход, в нем виднеется винтовая лестница наверх." +
                    "Направо - проход с уходящими вниз ступенями." +
                    "Куда вы направитесь?",
                    "Налево",
                    "Попробовать открыть ворота",
                    "Направо и вниз");
            }
            else if (currentStep == 5)
            {
                printStep("Вы явно видите винтовую лестницу, которая находится за аркой в стене." +
                    "Однако вы не можете ее достичь: когда вы идете к ней, вы остаетесь на месте." +
                    "Может стоит попробовать пойти в другом направлении?",
                    "Попробовать открыть ворота",
                    "Напрво и вниз");
            }
            else if (currentStep == 6)
            {
                printStep("Ворота выглядят как две огромные деревянные створки, на них не видно нн петель," +
                    "ни ручек. вы толкаете их, но они остаются на месте." +
                    "Возможно, они открываются как-то иначе, стоит поискать",
                    "Пойти налево",
                    "Направо и вниз");
            }
            else if (currentStep == 7)
            {
                printStep("Вы идете направо и спускаетесь вниз по лестнице, прихватив со стены факел." +
                    "Лестница выходит в коридор, уходящий налево и направо. " +
                    "Здесь темно, в стенах виднеются решетки, за которыми ничего не видно.",
                    "Пойти налево",
                    "Пойти направо",
                    "Вернуться наверх");
            }
            else if (currentStep == 8)
            {
                printStep("Вы идете по коридору. C обоих сторон коридора на вас слепо взирают проемы с решетками" +
                    "с тьмой за ними. Вдруг на полу что-то виднеется. Это груда костей вперемешку с обрывками одежды " +
                    "и кусками ржавого метала, по-видимому, ранее бывшими кольчугой, шлемом, щитом и мечом.",
                    "Осмотреть груду костей",
                    "пройти дальше мимо",
                    "Вернуться назад");
            }
            else if (currentStep == 9)
                printStep("При вашем приближении груда костей застучала, зашевилась, кости задвигались. " +
                    "И это не копошащиеся крысы: кости примыкают к друг другу, формируя скелет, который встает перед вами. " +
                    "В руках он держит ржавые меч и щит. Он начинает двигаться к вам, принимая боевую стойку",
                    "Атаковать",
                    "Сбежать");
            else if (currentStep == 10)
            {
                if (hero.getClassID() == 1) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака");
                else if (hero.getClassID() == 2) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака", "Магическая атака");
                else if (hero.getClassID() == 3) printStep("Вы тоже принимаете боевую стойку. Завязывается бой", "Атака", "Скрытая атака");
                curMonster = new Monster("Скелет");
                battle = true;
            }
            else if (currentStep == 11)
            {
                printStep("Конец бета-версии. Вы можете закрыть программу, написав команду \"Выход\"");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (TBActionField.Text == "Продолжить") //Если битва окончена
            {
                currentStep++; //переходим на следующий шаг
                battle = false; //отключаем режим битвы
                startStep();    //идем к следующему этапу 
                return;         //прерываем выполнение функции, иначе у нас будут последющие проверки
            }
            if (battle)
            {   
                
                if (hero.getClassID() == 1) result = checkAction(TBActionField.Text, "Атака", "Сбежать");
                else if (hero.getClassID() == 2) result = checkAction(TBActionField.Text, "Атака", "Магическая атака", "Сбежать");
                else if (hero.getClassID() == 3) result = checkAction(TBActionField.Text, "Атака", "Скрытая атака", "Сбежать");
                if (result == 0)
                {
                    if (hero.getClassID() == 1) printStep("Нет такого действия.", "Атака", "Сбежать");
                    else if (hero.getClassID() == 2) printStep("Нет такого действия.", "Атака", "Магическая атака", "Сбежать");
                    else if (hero.getClassID() == 3) printStep("Нет такого действия.", "Атака", "Скрытая атака", "Сбежать");
                }
                if (result == 1) //Атака
                {
                    int damage = hero.Attack();
                    int enemyDamage = curMonster.Attack();
                    string txtDamage = (damage == 0)?"вы промахнулись": $"нанесли {damage} урона";
                    string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : $"нанес вам {enemyDamage} урона";

                    string txt = $"Вы атаковали монстра {curMonster.getName()} и ";
                    txt+= txtDamage;
                    txt += $" {curMonster.getName()} тоже атаковал вас и ";
                    txt += txtEnemyDamage;
                    txt += "\n";

                    hero.addHealth(-enemyDamage);
                    curMonster.addHealth(-damage);
                    updateHeroStats();

                    txt += $" У вас осталось {hero.getHealth()} очков здоровья, у {curMonster.getName()} {curMonster.getHealth()} очков здоровья";

                    if (hero.getHealth() <= 0) 
                    {
                        txt += "\nВы погибли. Скелетрон уничтожил ваше королевство. Игра окончена";
                        printStep(txt);
                        return;
                    }
                    if (curMonster.getHealth() <= 0) 
                    {
                        txt += $"\n{curMonster.getName()} побежден";
                        Random rnd = new Random();
                        int bonus = rnd.Next(1, 10);
                        txt += $"Вы стали опытнее, и теперь можете наносить на {bonus} больше урона.";
                        hero.addDamage(bonus);
                        updateHeroStats();
                        printStep(txt, "Продолжить");
                        return;
                    }                    

                    if (hero.getClassID() == 1) printStep(txt, "Атака", "Сбежать");
                    else if (hero.getClassID() == 2) printStep(txt, "Атака", "Магическая атака", "Сбежать");
                    else if (hero.getClassID() == 3) printStep(txt, "Атака", "Скрытая атака", "Сбежать");
                }
                else if ((hero.getClassID() == 1 && result == 2) || ((hero.getClassID() == 2 || hero.getClassID() == 3) && result == 3)) //сбежать
                { 
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");
                }
                else if (result == 2) //магическая или скрытая атака 
                {     
                    if (hero.getClassID() == 2)//волшебник
                    {
                        if (hero.getMana() <=10)
                        {
                            printStep($"У вас  недостаточно очков маны, всего лишь {hero.getMana()} ", "Атака", "Магическая атака", "Сбежать");
                        }
                        else 
                        { 
                            int damage = hero.MagicAttack();
                            int enemyDamage = curMonster.Attack();
                            string txtDamage = (damage == 0) ? "вы промахнулись" : $"нанесли {damage} урона";
                            string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : $"нанес вам {enemyDamage} урона";

                            string txt = $" Вы атаковали монстра {curMonster.getName()} и ";
                            txt += txtDamage;
                            txt += $" {curMonster.getName()} тоже атаковал вас и ";
                            txt += txtEnemyDamage;
                            txt += $"\nУ вас осталось {hero.getMana()} очков маны";

                            hero.addHealth(-enemyDamage);
                            curMonster.addHealth(-damage);
                            updateHeroStats();

                            txt += $" У вас осталось {hero.getHealth()} очков здоровья, у {curMonster.getName()} {curMonster.getHealth()} очков здоровья";
                            printStep(txt, "Атака", "Магическая атака", "Сбежать");
                        }
                    }
                    else if (hero.getClassID() == 3)//плут
                    {
                        int damage = hero.hiddenAttack();
                        int enemyDamage = curMonster.Attack();
                        string txtDamage = (damage == 0) ? "вы промахнулись. Скрытой атакой получается нанести урон реже, чем обычной" : $"нанесли {damage} урона";
                        string txtEnemyDamage = (enemyDamage == 0) ? "он промахнулся" : $"нанес вам {enemyDamage} урона";

                        string txt = $" Вы атаковали монстра {curMonster.getName()} и ";
                        txt += txtDamage;
                        txt += $" {curMonster.getName()} тоже атаковал вас и ";
                        txt += txtEnemyDamage;
                        

                        hero.addHealth(-enemyDamage);
                        curMonster.addHealth(-damage);
                        updateHeroStats();

                        txt += $" У вас осталось {hero.getHealth()} очков здоровья, у {curMonster.getName()} {curMonster.getHealth()} очков здоровья";
                        printStep(txt, "Атака", "Скрытая атака", "Сбежать");
                    }
            }    


            }
            else  //если мы в режиме истории, проверяем, что ввел игрок 
            { 
                if (currentStep == 0)
                {
                    result = checkAction(TBActionField.Text,"Войти в дверь", "Сбежать");
                    if (result == 0) printStep("Нет такого действия.", "Войти в дверь", "Сбежать");
                    if (result == 1)
                    {
                        currentStep++;
                        startStep();
                    }
                    else if (result == 2)
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");
                
                }
                else if (currentStep == 1)
                {
                    result = checkAction(TBActionField.Text, "Идти по коридору", "Убежать из замка");
                    if (result == 0) printStep("Нет такого действия.","Идти по коридору","Убежать из замка");
                    if (result == 1)
                    {
                        currentStep++;
                        startStep();
                    }
                    else if (result == 2)
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");                
                }
                else if (currentStep == 2)
                {
                    result = checkAction(TBActionField.Text, "Атаковать", "Убежать из замка", "попробовать обойти горгулью");
                    if (result == 0) printStep("Нет такого действия. Вы можете ", "Атаковать", "Убежать из замка","попробовать обойти горгулью");
                    if (result == 1)
                    {
                        currentStep++;
                        startStep();
                    }
                    else if (result == 2)
                        printStep("Конец игры. Скелетрон унижтожил ваше королевство, а затем и другие.");
                    else if (result == 3)
                    {
                        currentStep=4;
                        startStep();
                    }               

                }
                else if (currentStep == 4)
                {
                    result = checkAction(TBActionField.Text, "Налево", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Налево", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep=5;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep=6;
                        startStep();
                    }

                    else if (result == 3)
                    {
                        currentStep = 7;
                        startStep();
                    }
                }
                else if (currentStep == 5)
                {
                    result = checkAction(TBActionField.Text, "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Попробовать открыть ворота", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep = 6;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep = 7;
                        startStep();
                    }             
                }
                else if (currentStep == 6)
                {
                    result = checkAction(TBActionField.Text, "Пойти налево", "Направо и вниз");
                    if (result == 0) printStep("Нет такого действия.  ", "Пойти налево", "Направо и вниз");
                    if (result == 1)
                    {
                        currentStep = 5;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep = 7;
                        startStep();
                    }
                }
                else if (currentStep == 7)//налево и направо будет скелет... иллюзия выбора
                {
                    result = checkAction(TBActionField.Text, "Пойти налево", "Пойти направо", "Вернуться наверх");
                    if (result == 0) printStep("Нет такого действия.  ", "Пойти налево", "Пойти направо","Вернуться наверх");
                    if (result == 1)
                    {
                        currentStep = 8;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep = 8;
                        startStep();
                    }
                    else if (result == 3)
                    {
                        currentStep = 4;
                        startStep();
                    }
                }
                else if (currentStep == 8)//со скелетом вы все равно будете сражаться...
                {
                    result = checkAction(TBActionField.Text, "Осмотреть груду костей", "пройти дальше мимо", "Вернуться назад");
                    if (result == 0) printStep("Нет такого действия.  ", "Осмотреть груду костей", "пройти дальше мимо", "Вернуться назад");
                    if (result == 1)
                    {
                        currentStep = 9;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep = 9;
                        startStep();
                    }
                    else if (result == 3)
                    {
                        currentStep = 8;
                        startStep();
                    }
                }
                else if (currentStep == 9)//со скелетом вы все равно будете сражаться...
                {
                    result = checkAction(TBActionField.Text, "Атаковать", "Сбежать");
                    if (result == 0) printStep("Нет такого действия.  ", "Атаковать", "Сбежать");
                    if (result == 1)
                    {
                        currentStep = 10;
                        startStep();
                    }
                    else if (result == 2)
                    {
                        currentStep = 8;
                        startStep();
                    }                
                }
                else if (currentStep == 11)
                {
                        result = checkAction(TBActionField.Text, "Выход");
                        if (result == 0) printStep("Нет такого действия", "Выход");
                        else if (result == 1) Application.Exit();
                }    
            }
        }

        public int checkAction(string txtAction, string action1 = "", string action2 = "", string action3 = "")
        {   //метод, который проверяет ввод игрока и сравнивает его с предусмотренными действиями
            if (txtAction == action1) return 1;
            else if (txtAction == action2) return 2;
            else if (txtAction == action3) return 3;
            else return 0;
        }
        public void printStep(string txt, string action1 = "", string action2 = "", string action3 = "")
        {   //метод, который отображает игрровой текст, разделяя его с доступными действиями.
            string str = txt; str += "\n\n";
            str += "Доступные действия:\n";
            str += action1; str += "\n";
            str += action2; str += "\n";
            str += action3; 
            RTBTextField.Text = str;
        }     
        private void updateHeroStats() //обновление характеристик героя, которые могут меняться в течении игры
        {
            LHealth.Text = hero.getHealth().ToString();
            LDamage.Text = hero.getDamage().ToString();
        }

    }
}
