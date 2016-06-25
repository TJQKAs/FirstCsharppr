using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding binding = new Binding();
            binding.ElementName = "Textb3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pusto = "Надо ввести имя и фамилию в поля текста"; 
            string name = Name.Text;
            string surname = Surname.Text;
            string phrase;
            if (name == "" || surname == "")
            {
                MessageBox.Show(pusto); 
            }
             else
            {
               phrase = "Приветствую Вас " + name + " " + surname + " !";
                Textb3.Text = phrase;
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e) {
               Textb3.Text = "";
            Name.Text = "";
            Surname.Text = "";
        }
    }


}
