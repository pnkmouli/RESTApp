using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain.Repo.DAL
{
    public interface IPropertyEstatesRepository : IDisposable
    {
        IEnumerable<PropertyEstate> GetProperties();
        PropertyEstate GetPropertyEstateID(int Id);
        //void InsertStudent(Student student);
        //void DeleteStudent(int studentID);
        //void UpdateStudent(Student student);
        void Save();
    }
}
