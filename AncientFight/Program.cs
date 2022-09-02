using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AncientFight;

Footman sniper = new Footman();
Mage Rubick = new Mage();

//Console.WriteLine("Привет странник, выбери героя за которого хочешь начать приключение!\n1.Footman\nЗдоровье - " + sniper.health 
//    + "\nУрон - " + sniper.Damage + "\n2.Rubick\nЗдоровье - " + Rubick.health + "\nУрон - " + Rubick.Damage);

while(sniper.health > 0 && Rubick.health > 0)
{
    Console.WriteLine("Здоровье героя - " + sniper.health + "\nЗдоровье врага - " + Rubick.health);
    Console.WriteLine("\nВыберите действие героя:\n1.Атаковать\n2.Восстановить Здоровье\n3.Использовать супер-умение\n");

    string UserChoose = Console.ReadLine();
    int pseudoRand = new Random().Next(1,3);

    if(UserChoose == "1")
    {
        Console.WriteLine("Вы нанесли урона - " + sniper.Damage);
        Rubick.health -= sniper.Damage;
        Console.WriteLine("Враг нанес урон по вам - " + Rubick.Damage);
        sniper.health = Rubick.Damage - sniper.Armor;
    }
    if(UserChoose == "2")
    {
        if (pseudoRand > 1)
        {
            Console.WriteLine("Вам удалось выпить целебный напиток!");
        }
        else
        {
            Console.WriteLine("Враг воспользовался вашей беспомощностью во время битвы и нанес урон сквозь броню - " + Rubick.Damage);
            sniper.health -= Rubick.Damage;
        }
    }
    if(UserChoose == "3")
    {
        Console.WriteLine("Ваш урон увеличен на 2 ед. на 2 атаки");
        for(int i = 0;i > 0; i++)
        {
            sniper.Damage += 2;
            i--;
        }
    }
    if (UserChoose == "LOSERMOD")
    {
        Rubick.Damage += 1000;
        Rubick.health += 1000;
        Rubick.Armor += 1000;
    }
}
if (sniper.health > 0)
{
    Console.WriteLine("You are winner");
}
else
{
    Console.WriteLine("You lose");
}
