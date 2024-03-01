using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using WcfServiceLibrary1;
using static WcfServiceLibrary1.Service1;

namespace Kt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine("Сервис запущен.");
                Console.WriteLine("Нажмите Enter для остановки сервиса…");
                Console.ReadLine();
                host.Close();
            }

            //Service1 service1 = new Service1();
            //while (true)
            //{
            //    Console.WriteLine("Print :");
            //    Console.WriteLine("0 -List contrack ");
            //    Console.WriteLine("1 -Add contrack ");
            //    Console.WriteLine("2-Find contrack id");
            //    Console.WriteLine("3-Close");

            //    int numbers = Convert.ToInt32(Console.ReadLine());
            //    switch (numbers)
            //    {
            //        case 0:

            //            var Select = service1.ListContrat();
            //            foreach (var item in Select)
            //            {
            //                Console.WriteLine($"{item.Id} {item.Name_Contrack}");

            //            }
            //            if (Select.Count > 0)
            //            {
            //                Console.WriteLine("Not contrack");
            //            }


            //            break;

            //        case 1:
            //            Console.WriteLine("Id indificate enter");
            //            int i = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Enter name Contrack");
            //            string name = Console.ReadLine();
            //            Contrack contrack = new Contrack(i, name);
            //            service1.AddGet(contrack);
            //            break;

            //        case 2:
            //            Console.WriteLine("Id  contrack  enter for find");
            //            i = Convert.ToInt32(Console.ReadLine());

            //            service1.Push(i);

            //            break;
            //        case 3:
            //            System.Environment.Exit(1);

            //            break;
            //    }

        }


        }
    }

