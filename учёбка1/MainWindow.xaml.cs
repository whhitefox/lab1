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
using учёбка1.DataSet1TableAdapters;

namespace учёбка1
{
    public partial class MainWindow : Window
    {
        AnimalsTableAdapter Animals = new AnimalsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            AnimalsGrid.ItemsSource = Animals.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SotrudnikiWindow window = new SotrudnikiWindow();
            window.Show();
        }
    }
}
