using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTApp.Lib.Domain.Interfaces
{
    [ServiceContract(Name = "RESTAppServices")]
    public interface IRESTAppServices
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare)]
        string GetClientNameById(string Id);
    }

    public static class Routing
    {
        public const string GetClientRoute = "/Client/{id}";
    }
}
