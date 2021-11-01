using bdDemoStudent.Class;
using System.Linq;
using System.Windows;

namespace bdDemoStudent.View
{
    /// <summary>
    /// Логика взаимодействия для WinActiv.xaml
    /// </summary>
    public partial class WinActiv : Window
    {
        public WinActiv()
        {
            InitializeComponent();
            
        }
        private void Action(object sender, RoutedEventArgs e)
        {
            var men = Helper.demoBd.Activites.Where(i => i.Id > 0).ToList();
            GriAction.ItemsSource = men;
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            foreach (var i in GriAction.ItemsSource)
                Helper.demoBd.Activites.Remove(i as Activites);
            Helper.demoBd.SaveChanges();
            this.Close();
        }
    }
}
