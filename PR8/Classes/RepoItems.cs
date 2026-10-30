using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8.Classes
{
    public class RepoItems
    {

        public static List<object> AllItems()
        {

            List<object> allItems = new List<object>();

            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Children("Мягкая игрушка кошка подушка", 1754, 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 4913, "S"));
            allItems.Add(new Sport("Мяч для водного поло", 812, "61-63 см"));
            allItems.Add(new Sport("Набор для гольфа Partida", 3950, "600*800 мм"));
            allItems.Add(new electronics("Наикрутейший аккумулятор", 1444, 100,1000));
            allItems.Add(new electronics("Не оч аккумулятор", 222, 1, 333));

            return allItems;
        }
    }
}
