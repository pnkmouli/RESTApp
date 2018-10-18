using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;

namespace WcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISaleService" in both code and config file together.
    [ServiceContract]
    public interface ISaleService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/PayBill/{PayId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string PayBill(string PayId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetProperties", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<WrProperty> GetProperties();

        //[OperationContract]
        //[WebGet(UriTemplate = "/GetEmployeeDetails/{EmpId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //Applicant GetEmployeeDetails(string EmpId);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "/AddNewEmployee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        //bool AddNewEmployee(Applicant emp);

        //[OperationContract]
        //[WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        //void UpdateEmployee(Applicant contact);

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteEmployee/{EmpId}")]
        //void DeleteEmployee(string EmpId);

    }
}

