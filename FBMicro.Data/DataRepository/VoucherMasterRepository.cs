using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
    public class VoucherMasterRepository : EFRepository<VoucherMaster>
    {
        #region Constructors

        public VoucherMasterRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateVoucherMaster(VoucherMaster voucherMaster)
        {
            if (voucherMaster == null) return false;

            var entity = GetFirstOrDefault(x => x.VoucherName.Equals(voucherMaster.VoucherName));
            if (entity != null) return false;

            Insert(voucherMaster);
            Commit();

            return true;
        }

        public bool UpdateVoucherMaster(VoucherMaster voucherMaster)
        {
            if (voucherMaster == null || voucherMaster.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == voucherMaster.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<VoucherMaster> GetAllVoucherMasters()
        {
            return GetAll().ToList();
        }

        public VoucherMaster GetVoucherMasterByID(int voucherMasterID)
        {
            if (voucherMasterID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == voucherMasterID);
        }

        public bool DeleteVoucherMaster(int voucherMasterID)
        {
            Delete(voucherMasterID);
            Commit();
            return true;
        }

        #endregion
    }
}




