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
using System.Windows.Shapes;
using UP.Models;

namespace UP.Windows
{
    /// <summary>
    /// Логика взаимодействия для DriverWindow.xaml
    /// </summary>
    public partial class DriverWindow : Window
    {
        public DriverWindow()
        {
            InitializeComponent();
            driversGrid.ItemsSource=upEntities.GetContext().driver.ToList();
        }
        private void EditWindow(object sender, RoutedEventArgs e) 
        {
            var item = (driver)driversGrid.SelectedItem;
            new EditDriver(item).Show();
            this.Close();
          
        }
        private void AddDriver(object sender, RoutedEventArgs e)
        {
            new EditDriver().Show();
            this.Close();

        }
        private void DelDriver(object sender, RoutedEventArgs e)
        {
            try { 
            var item = (driver)driversGrid.SelectedItem;
            using (upEntities context = new upEntities())
            {
                var entity = context.driver.Find(item.id);

                context.driver.Remove(entity);
                context.SaveChanges();
                MessageBox.Show("Выбранный водитель удален");
                new DriverWindow().Show();
                this.Close();
            }
            }
            catch(Exception ex) {
                MessageBox.Show("Ваша ошибка" +ex);
            }

        }
        private void Window_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
