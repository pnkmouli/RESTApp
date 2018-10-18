using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using System.Data.Entity;
using Domain.Repo.DAL;

using Domain;
namespace WcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SaleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SaleService.svc or SaleService.svc.cs at the Solution Explorer and start debugging.
    public class SaleService : ISaleService
    {
        private IPropertyEstatesRepository  propertyRepository;

        public SaleService()
        {
            this.propertyRepository = new PropertyEstatesRepository(new Domain.WaltonPropertiesEntities());
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public List<WrProperty> GetProperties()
        {
            List<WrProperty> wrlist = new List<WrProperty>();
           
                var Query = propertyRepository.GetProperties().Take(50);

                if (Query != null && Query.Count() > 0)
                    {
                       foreach (PropertyEstate prop in Query) {
                           WrProperty wr = new WrProperty();
                            wr.Id = prop.id;
                            wr.Address1 = prop.address1;
                            wr.Address2 = prop.address2;
                            wr.Town = prop.towncity;
                            wr.Postcode = prop.postcode;
                            wr.Price = Convert.ToDecimal(prop.priceend);
                            wrlist.Add(wr);
                        }
                }
                return wrlist;
            
            
        }

        //public bool AddNewEmployee(Applicant employee)
        //{
        //    try
        //    {
        //        //XDocument doc = XDocument.Load("H:\\EmployeeData.xml");

        //        //doc.Element("DocumentElement").Add(
        //        //        new XElement("Employees",
        //        //        new XElement("EmployeeID", employee.EmployeeID),
        //        //        new XElement("Name", employee.Name),
        //        //        new XElement("JoiningDate", employee.JoiningDate),
        //        //        new XElement("CompanyName", employee.CompanyName),
        //        //        new XElement("Address", employee.Address)));

        //        //doc.Save("H:\\EmployeeData.xml");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new FaultException<string>
        //                (ex.Message);
        //    }
        //    return true;
        //}

        //public void DeleteEmployee(string EmpId)
        //{
        //    try
        //    {
        //        //XDocument doc = XDocument.Load("H:\\EmployeeData.xml");
        //        //foreach (var result in doc.Descendants("DocumentElement").Descendants("Employees"))
        //        //{
        //        //    if (result.Element("EmployeeID").Value == EmpId.ToString())
        //        //    {
        //        //        result.Remove();
        //        //        break;
        //        //    }
        //        //}
        //        //doc.Save("H:\\EmployeeData.xml");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new FaultException<string>
        //                (ex.Message);
        //    }
        //}

        //public void DoWork()
        //{
        //}

        //public Applicant GetEmployeeDetails(string EmpId)
        //{
        //    Applicant app = applicationService.FindById(EmpId);


        //    return app;
        //}

        public string PayBill(string PayId)
        {

            return "Transaction having PayId " + PayId + " was successful";
        }

        //public void UpdateEmployee(Applicant employee)
        //{
        //    //try
        //    //{
        //    //    XDocument doc = XDocument.Load("H:\\EmployeeData.xml");
        //    //    var target = doc
        //    //         .Element("DocumentElement")
        //    //         .Elements("Employees")
        //    //         .Where(e => e.Element("EmployeeID").Value == employee.EmployeeID)
        //    //         .Single();

        //    //    target.Element("Name").Value = employee.Name;
        //    //    target.Element("JoiningDate").Value = employee.JoiningDate;
        //    //    target.Element("CompanyName").Value = employee.CompanyName;
        //    //    target.Element("Address").Value = employee.Address;

        //    //    doc.Save("H:\\EmployeeData.xml");
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw new FaultException<string>
        //    //            (ex.Message);
        //    //}
        //}

        //private Domain.Services.Applications.ApplicationService _applicationService;
        //private Domain.Services.Applications.ApplicationService applicationService
        //{
        //    get
        //    {
        //        if (_applicationService == null)
        //        {
        //            _applicationService = new Domain.Services.Applications.ApplicationService();
        //        }

        //        return _applicationService;
        //    }
        //}

    }
}
