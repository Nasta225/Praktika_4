using Praktika_4.ApplicationData;
using Praktika_4.PageMain;
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

namespace Praktika_4
{
    /// <summary>
    /// Логика взаимодействия для Otel.xaml
    /// </summary>
    public partial class Otel : Window
    {
        public Otel()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            NewGost newGost = new NewGost();
            newGost.Show();
            myWindows.Close();
        }

        private void Nomera_Click(object sender, RoutedEventArgs e)
        {
            AppConnect.modelOdb = new GostinizaEntities(); // соединение с БД
            AppFrame.FrameMain = FrameMain;  //загрузка фрейма со стартом
            FrameMain.Navigate(new PageNomer());// страница PageFrutyr
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Raspisanie_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new PageRaspisanie());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
