using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8.Model
{
    class TheHavchik
    {
        public List<Bludo> TheHavchick = new List<Bludo>();
        public TheHavchik()
        {
            Bludo Rolton = new Hot(10, 40, "Ролтик", 1, 15);
            Bludo MaminSyp = new Hot(15, 100, "Мамин суп", 2, 0);
            Bludo SOSIska = new Hot(10, 80, "СОСИска с Гречкой", 3, 40);
            Bludo Papyas = new Cold(10, 150, "Салат Папуас", 4, 70);
            Bludo Mazhor = new Cold(10, 250, "Мажорные устрицы", 5, 120);
            Bludo Chervyak = new Cold(10, 200, "Тонкие креветки", 6, 100);
            Bludo Morozhka = new Desert(10, 25, "КДшная Морожка", 7, 5.99);
            Bludo Bulgakov = new Desert(5, 30, "Булка из Булгакова", 8, 15);
            Bludo Pokramsali = new Desert(3, 50, "Фруктовый салатик", 9, 20);
            Bludo Baltika = new Drink(0, 50, "Лучшее пиво", 10, 39.99);
            Bludo SamagonDeda = new Drink(0, 300, "Самагон деда", 11, 0);
            Bludo BabyschkinSok = new Drink(0, 25, "Бабушкин сок", 12, 0);
            Bludo Kolbaski = new Snacks(10, 100, "Колбаски", 13, 50);
            Bludo Syrok = new Snacks(10, 100, "Сырный сыр", 14, 50);
            Bludo Ovosch = new Snacks(10, 85, "Овощи зарезанные", 15, 40);
            TheHavchick.Add(Rolton);
            TheHavchick.Add(MaminSyp);
            TheHavchick.Add(SOSIska);
            TheHavchick.Add(Papyas);
            TheHavchick.Add(Mazhor);
            TheHavchick.Add(Chervyak);
            TheHavchick.Add(Morozhka);
            TheHavchick.Add(Bulgakov);
            TheHavchick.Add(Pokramsali);
            TheHavchick.Add(Baltika);
            TheHavchick.Add(SamagonDeda);
            TheHavchick.Add(BabyschkinSok);
            TheHavchick.Add(Kolbaski);
            TheHavchick.Add(Syrok);
            TheHavchick.Add(Ovosch);
        }
        
        

    }
}
