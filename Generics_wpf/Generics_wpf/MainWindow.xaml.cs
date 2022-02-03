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
using System.Collections;
using System.Collections.ObjectModel;

namespace Generics_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGridView1.ItemsSource = result;
        }
        ObservableCollection<DataItem> result = new ObservableCollection<DataItem>();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float x = (float)XnumericUpDown.Value;
            float y = (float)YnumericUpDown.Value;
            result.Add(new DataItem(x,y));
            
        }

        private void mainform_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void dataGridView1_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var num = dataGridView1.SelectedIndex;
                result.RemoveAt(num);
                dataGridView1.ItemsSource = result;
            }
            catch
            {
                MessageBox.Show("Выберите точку!");
            }
        }
    }
}
public class DataItem
{
    public DataItem(float col1, float col2)
    {
        x = col1;
        y = col2;
    }
    public float x { get; set; }
    public float y { get; set; }
}
