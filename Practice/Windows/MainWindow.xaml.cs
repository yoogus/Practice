using Practice.HelperClass;
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


namespace Practice
{


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EmployeeViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new EmployeeViewModel();
            DataContext = ViewModel;
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (tbxFName.Text == null || tbxLName.Text == null || tbxPost.Text == null)
            {
                MessageBox.Show("Вы не заполнили поля!");
            } 
            else
            {
                string firstname = tbxFName.Text;
                string lastname = tbxLName.Text;
                string post = tbxPost.Text;

                ViewModel.AddEmployee(firstname, lastname, post);

                tbxFName.Text = string.Empty;
                tbxLName.Text = string.Empty;
                tbxPost.Text = string.Empty;
            }
        }
    }
}
