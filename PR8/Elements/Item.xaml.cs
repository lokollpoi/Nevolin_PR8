using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR8.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object ItemData)
        {
            InitializeComponent();

            Classes.Shop ShopData = ItemData as Classes.Shop;

            nameProduct.Content = ShopData.Name;
            lablePrice.Content = ShopData.Price;


            if (ItemData is Classes.Children)
            {

                Classes.Children ChildrenData = ItemData as Classes.Children;

                lableCharac.Content = "Возраст: " + ChildrenData.Age;
            }

            if (ItemData is Classes.Sport)
            {

                Classes.Sport SportData = ItemData as Classes.Sport;

                lableCharac.Content = "Размер: " + SportData.Size;
            }
            if (ItemData is Classes.electronics)
            {

                Classes.electronics electData = ItemData as Classes.electronics;

                lableCharac.Content = "Размер Батареии: " + electData.battSize + '\n' + "Скорость езды: " + electData.drivSpeed;
            }
        }
    }
}
