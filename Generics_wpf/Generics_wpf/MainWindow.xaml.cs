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
            dataGridView2.ItemsSource = result2;
        }
        ObservableCollection<DataItem> result = new ObservableCollection<DataItem>();
        ObservableCollection<DataItem> result2 = new ObservableCollection<DataItem>();
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

        private void solvebtn_Click(object sender, RoutedEventArgs e)
        {
            result2.Clear();
            dataGridView2.ItemsSource = "";
            foreach(DataItem dt in result)
            {
                if (dt.x < 0) result2.Add(dt);
            }
            foreach(DataItem dt in result2)
            {
                result.Remove(dt);
            }
            dataGridView2.ItemsSource = result2;
        }

        private void closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void sortbtn_Click(object sender, RoutedEventArgs e)
        {
            List<DataItem> items = new List<DataItem>();
            items = result2.ToList();
            items.Sort();
            dataGridView2.ItemsSource = items;
            /* int temp;
             foreach(DataItem dt in result)
             {
                 for(int j = 1; j < result.Count; j++)
                 {

                 }
             }*/
            //for(int i = 0; i < result2.Count; i++)
            //{
            //    for(int j = i + 1; j < result2.Count; j++)
            //    {
            //        if()
            //    }
            //}
        }
    }
}
public class DataItem:IComparable
{
    public DataItem(float col1, float col2)
    {
        x = col1;
        y = col2;
    }
    public float x { get; set; }
    public float y { get; set; }
    public int CompareTo(object obj)
    {
        DataItem p = (DataItem)obj;
        if (x > p.x)
            return 1;
        if (x == p.x)
            return 0;
        return -1;
    }
}
