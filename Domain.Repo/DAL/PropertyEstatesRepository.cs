using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repo.DAL
{
    public class PropertyEstatesRepository : IPropertyEstatesRepository, IDisposable
    {
        private WaltonPropertiesEntities context;

        public PropertyEstatesRepository(WaltonPropertiesEntities context)
        {
            this.context = context;
        }
       

        public IEnumerable<PropertyEstate> GetProperties()
        {
            return context.PropertyEstates.ToList();
        }

        public PropertyEstate GetPropertyEstateID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
