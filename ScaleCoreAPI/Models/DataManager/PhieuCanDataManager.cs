using ScaleCoreAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaleCoreAPI.Models.DataManager
{
    public class PhieuCanDataManager : IDataRepository<Phieucan>
    {
        readonly SCALES_WITH_ALPR_DBContext _scaleDBContext;

        public PhieuCanDataManager(SCALES_WITH_ALPR_DBContext scaleDBContext)
        {
            _scaleDBContext = scaleDBContext;
        }

        public IEnumerable<Phieucan> GetAll()
        {
            return _scaleDBContext.Phieucan.ToList<Phieucan>();
            
        }

        public void Add(Phieucan entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Phieucan entity)
        {
            throw new NotImplementedException();
        }

        public Phieucan Get(long id)
        {
            throw new NotImplementedException();
        }
              

        public void Update(Phieucan entityToUpdate, Phieucan entity)
        {
            throw new NotImplementedException();
        }
    }
}
