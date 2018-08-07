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
using System.Collections.ObjectModel;


namespace TabsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ViewModel mainViewModel = new ViewModel(); //Создаем эземпляр viewmodel

        public MainWindow()//Констуруктор
        {
            InitializeComponent();

            this.DataContext = mainViewModel; //Задаем DataContext нашего VIEW в пространство ViewModel            

            mainViewModel.Tabs.Add(new TabItem { Header = "1TAB", Content = "1 content" });
            

        }

        int count = 2;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            mainViewModel.Tabs.Add(new TabItem { Header = $"{count}TAB", Content = $"{ count } content" });
            count++;
        }       
              

    }
}
