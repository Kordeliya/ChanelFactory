using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLibrary
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Book GetBook(string value);

    }
}
