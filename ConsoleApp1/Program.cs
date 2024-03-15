using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service2/");
            using (ServiceHost host = new ServiceHost(typeof(Service1), uri))
            {
                host.Open();
                Console.WriteLine("Сервис запущен.");
                Console.WriteLine("Нажмите Enter для остановки сервиса…");
                Console.ReadLine();
                host.Close();
            }

        }
    }
}
