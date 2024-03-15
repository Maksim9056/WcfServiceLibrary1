
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static WcfServiceLibrary1.Service1;
namespace WcfServiceLibrary1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public List<Contrack> Services = new List<Contrack>();
        public List<Contrack> contracks = new List<Contrack>();

        public string AddGet(Contrack contrack)
        {

            Services.Add(contrack);
            return "Добавился" ;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }



        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        [DataContract]

        public class Contrack
        {
            [DataMember]

            public int Id { get; set; }
            [DataMember]

            public string Name_Contrack { get; set; }
            public Contrack(int id, string name_Contrack)
            {
                Id = id;
                Name_Contrack = name_Contrack;
            }   

        }


        public List<Contrack> ListContrat()
        {
            
            return Services;
        }

        public string Push(int  contrack)
        {
            Contrack contrack1 = Services.Find(find => find.Id == contrack);

            return contrack1.Name_Contrack;
        }


        
        public void AddGetDB(Contrack contrack)
        {


            using (WorkForData WorkForData = new WorkForData())
            {

                WorkForData.Contrack.AddRange(contrack);
                WorkForData.SaveChanges();
            }
        }

        public void DeleteDB(int id)
        {

            using (WorkForData WorkForData = new WorkForData())
            {
                Contrack user = WorkForData.Contrack.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    WorkForData.Contrack.Remove(user);
                    WorkForData.SaveChanges();
                }
            }
            //throw new System.NotImplementedException();
        }

        public void AddCreateDB()
        {
            using (WorkForData WorkForData = new WorkForData())
            { 
            }
        }

        public List<Contrack> SelectDb()
        {
            try
            {


                using (WorkForData WorkForData = new WorkForData())
                {
                    contracks = WorkForData.Contrack.ToList();
                }
            }
            catch { 
            }

            return contracks;
        }

        public Contrack SelectDb1(int id)
        {
            Contrack contrack = null;

            try
            {


                using (WorkForData WorkForData = new WorkForData())
                {
                    contrack = WorkForData.Contrack.FirstOrDefault(i => i.Id == id);
                }
            }
            catch
            {
            
            
            }

            return contrack;
        }

        public void Update(Contrack contrackt)
        {
            using (WorkForData WorkForData = new WorkForData())
            {
                var   update = WorkForData.Contrack.FirstOrDefault(i => i.Id == contrackt.Id);
                update.Name_Contrack = contrackt.Name_Contrack;

                // Save the changes to the database
                WorkForData.SaveChanges();
            }
            //throw new System.NotImplementedException();
        }
    }

    public class WorkForData : DbContext
    {

        public WorkForData(DbContextOptions<WorkForData> options) : base(options)
        {
        }

        public DbSet<Contrack> Contrack { get; set; } = null;

        public WorkForData()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {

            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Wcf;Username=postgres;Password=1");
        }
    }
 }
