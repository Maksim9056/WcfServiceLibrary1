using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WcfServiceLibrary1;
using static WcfServiceLibrary1.Service1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Service1 service1 = new Service1();

        public MainWindow()
        {
            InitializeComponent();
            service1.AddCreateDB();

        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {


                int ID = Convert.ToInt32(Dom.Text);
                string namecontackt = filtr.Text;
                Contrack contrack = new Contrack(ID, namecontackt);
                service1.AddGetDB(contrack);
            }
            catch
            {

            }
   
            //Dom.Text;
            //while (true)
            //{
            //    Uri uri = new Uri("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/mex");
            //    using (ServiceHost host = new ServiceHost(typeof(Service1), uri))
            //    {
            //        host.Open();
            //        Console.WriteLine("Сервис запущен.");
            //        Console.WriteLine("Нажмите Enter для остановки сервиса…");
            //        Console.ReadLine();
            //        host.Close();
            //    }
            //}

        }
        private void Data_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int values = Convert.ToInt32(Dom.Text);
                service1.DeleteDB(values);
            }
            catch
            {

            }
        }
        //q
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int values = Convert.ToInt32(Dom.Text);

                var contract = service1.SelectDb1(values);
                filtr.Text = contract.Name_Contrack;
            }
            catch
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {


                var contracks = service1.SelectDb();
                Data.ItemsSource = service1.contracks;
            }
            catch
            {

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {

                int ID = Convert.ToInt32(Dom.Text);
                string namecontackt = filtr.Text;
                Contrack contrack = new Contrack(ID, namecontackt);
                service1.Update(contrack);
            }
            catch
            {

            }
        }
    }
}
