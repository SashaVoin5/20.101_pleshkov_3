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
using _20._101_pleshkov_3.Entity;

namespace _20._101_pleshkov_3
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

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                var discipline = Entities.GetContext().Discipline.Where(p => p.IdDiscipline == 2).ToList(); //Считываем из базы данных значения по условию IdDiscipline = 2
                if (discipline.Count != 0)
                {
                    LoadData.ItemsSource = discipline; //Записываем данные в датагрид

                }
                else
                {
                    MessageBox.Show("Ничего не найдено", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                

            }
            catch
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK,MessageBoxImage.Error);
            }
           
        }
    }
}
