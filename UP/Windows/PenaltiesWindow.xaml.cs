using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PenaltiesWindow.xaml
    /// </summary>
    public partial class PenaltiesWindow : Window
    {
        public PenaltiesWindow()
        {
            InitializeComponent();
            penaltieGrid.ItemsSource= upEntities.GetContext().penalties.ToList();
          
        }
            private void Editpenaltie(object sender, RoutedEventArgs e)
        {
            var item = (penalties)penaltieGrid.SelectedItem;
            
            new EditPenaltie(item).Show();
            this.Close();
            
        }
        private void Addpenaltie(object sender, RoutedEventArgs e)
        {
            new EditPenaltie().Show();
            this.Close();
        }
        private void Delpenaltie(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = (penalties)penaltieGrid.SelectedItem;
            using (upEntities context = new upEntities())
            { 
                context.penalties.Remove(item);
                context.SaveChanges();
                MessageBox.Show("Выбранный штраф удален");
                new PenaltiesWindow().Show();
                this.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ваша ошибка" + ex);
            }

        }
    }
}
