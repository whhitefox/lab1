using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class AnimalsPage : Page
    {
        AnimalsTableAdapter Animals = new AnimalsTableAdapter();
        public AnimalsPage()
        {
            InitializeComponent();
            AnimalsGrid.ItemsSource = Animals.GetData();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            try
            {
                short amount = Convert.ToInt16(AmountTextBox.Text);
                if (name != "" || amount > 0)
                {
                    Animals.InsertQuery(name, amount);
                }
            }
            catch { }
            AnimalsGrid.ItemsSource = Animals.GetData();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(AnimalsGrid.SelectedItem as DataRowView).Row[0];
            Animals.DeleteAnimals(id);
            AnimalsGrid.ItemsSource = Animals.GetData();
        }

    }
}
