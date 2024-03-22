using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using static WcfServiceLibrary1.Service1;

namespace WcfServiceLibrary1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        List<Contrack> ListContrat();
        [OperationContract]

        string AddGet(Contrack contrack);
        [OperationContract]

        void AddCreateDB();
        [OperationContract]

        void AddGetDB(Contrack contrack);
        [OperationContract]

        List <Contrack> SelectDb();
        [OperationContract]

        Contrack SelectDb1(int id);
        [OperationContract]

        void DeleteDB(int id);
        [OperationContract]

        void Update(Contrack contrackt);
        [OperationContract]

        string Push(int id);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
