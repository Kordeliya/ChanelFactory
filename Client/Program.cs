using InterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            using (ChannelFactory<IService> channelFactory = new ChannelFactory<IService>(binding))
            {
                IService service = channelFactory.CreateChannel(new EndpointAddress("http://localhost:54799/Service1.svc"));
                try
                {
                    var result = service.GetBook("Горе от ума");
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
