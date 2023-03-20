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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(SotrudnikGrid.SelectedItem as DataRowView).Row[0];
            Sotrudniki.SotrudnikDelete(id);
            SotrudnikGrid.ItemsSource = Sotrudniki.GetData();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (SotrudnikGrid.SelectedItem != null)
            {
                
                int id = (int)(SotrudnikGrid.SelectedItem as DataRowView).Row[0]; 
                Sotrudniki.UpdateQuery(NameTextBox.Text, Convert.ToInt32(AnimalsidTextBox.Text), (id));
                SotrudnikGrid.ItemsSource = Sotrudniki.GetData();
            }

        }

        private void SotrudnikGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SotrudnikGrid.SelectedItem != null)
            {
                String name = (SotrudnikGrid.SelectedItem as DataRowView).Row[1].ToString(); 
                NameTextBox.Text = name;
                String ai = (SotrudnikGrid.SelectedItem as DataRowView).Row[2].ToString(); 
                AnimalsidTextBox.Text = ai;
            }

        }
    }
}
