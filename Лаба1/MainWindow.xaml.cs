using ConsoleApp8.Kontroller;
using ConsoleApp8.Model;
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

namespace Лаба1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OformlenieZakaza oformlenie = new OformlenieZakaza();
        TheHavchik todayMenu;
        int Mode;
        public MainWindow()
        {
            todayMenu = new TheHavchik();

            InitializeComponent();

            MenuView.ItemsSource = todayMenu.TheHavchick;
            SpisokZakaza.ItemsSource = oformlenie.AYF;
            SpisokVsehZakazov.ItemsSource = oformlenie.AYF2;

        }

        private void MenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void ZurBestellunghinzufugen_Click(object sender, RoutedEventArgs e)
        {
            oformlenie.Vybrat((Bludo)MenuView.SelectedItem, Convert.ToInt32(Kolvo.Text));
            SpisokZakaza.Items.Refresh();
        }

        private void Bestellungbeenden_Click(object sender, RoutedEventArgs e)
        {
            oformlenie.Sozdat();
            SpisokVsehZakazov.Items.Refresh();

        }

        private void Zakaz_Click(object sender, RoutedEventArgs e)
        {
            SpisokZakaza.ItemsSource = oformlenie.AYF;
        }

        private void OldZakaz_Click(object sender, RoutedEventArgs e)
        {
            SpisokZakaza.ItemsSource = ((ZakazDannie)SpisokVsehZakazov.SelectedItem).SpisokBlyud;
        }
    }
}
