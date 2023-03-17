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
    public partial class SotrudnikiPage : Page
    {
        SotrudnikTableAdapter Sotrudniki = new SotrudnikTableAdapter();
        public SotrudnikiPage()
        {
            InitializeComponent();
            SotrudnikGrid.ItemsSource = Sotrudniki.GetData();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            try
            {
                int animalsid = Convert.ToInt32(AnimalsidTextBox.Text);
                if (name != "" || animalsid > 0)
                {
                    Sotrudniki.InsertQuery(name, animalsid);
                }
            }
            catch { }
            SotrudnikGrid.ItemsSource = Sotrudniki.GetData();
        }
    }
}
