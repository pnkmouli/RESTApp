using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using RESTApp.Lib.Domain.Interfaces;

namespace RESTApp.Lib.Domain.Implementation
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,   ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RESTAppServices : IRESTAppServices
    {
        public string GetClientNameById(string Id)
        {
            Random r = new Random();
            string ReturnString = "";
            int Idnum = Convert.ToInt32(Id);
            for (int i = 0; i < Idnum; i++)
                ReturnString += char.ConvertFromUtf32(r.Next(65, 85));

            return ReturnString;

        }
    }
}
