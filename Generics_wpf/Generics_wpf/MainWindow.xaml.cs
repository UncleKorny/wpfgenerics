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
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float x = (float)XnumericUpDown.Value;
            float y = (float)YnumericUpDown.Value;
            List<DataItem> result = new List<DataItem>();
            result.Add(new DataItem(x,y));
            dataGridView1.Items.Add(r);
            //MessageBox.Show(result.ToString());
            int sum = 0;
            
        }

        private void mainform_Loaded(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
public class DataItem
{
    public DataItem(float col1, float col2)
    {
        Column1 = col1;
        Column2 = col2;
    }
    public float Column1 { get; set; }
    public float Column2 { get; set; }
}
