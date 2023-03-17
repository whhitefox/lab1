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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SotrudnikiButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Source = new Uri("SotrudnikiPage.xaml", UriKind.Relative);
        }

        private void AnimalsButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Source = new Uri("AnimalsPage.xaml", UriKind.Relative);
        }
    }
}
