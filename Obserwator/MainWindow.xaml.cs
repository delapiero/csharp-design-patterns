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

namespace Obserwator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel vm = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void wyslij_Click(object sender, RoutedEventArgs e)
        {
            vm.Obserwowany.wartosci.Clear();
            vm.Obserwowany.wartosci.Add(Convert.ToDouble(tA.Text));
            vm.Obserwowany.wartosci.Add(Convert.ToDouble(tB.Text));
            vm.Obserwowany.wartosci.Add(Convert.ToDouble(tC.Text));
            vm.Obserwowany.wartosci.Add(Convert.ToDouble(tD.Text));
            vm.Obserwowany.Powiadom();
        }
    }
}
