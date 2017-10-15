using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
    public class BankMasterRepository : EFRepository<BankMaster>
    {
        #region Constructors

        public BankMasterRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateBankMaster(BankMaster bankMaster)
        {
            if (bankMaster == null) return false;

            var entity = GetFirstOrDefault(x => x.Name.Equals(bankMaster.Name));
            if (entity != null) return false;

            Insert(bankMaster);
            Commit();

            return true;
        }

        public bool UpdateBankMaster(BankMaster bankMaster)
        {
            if (bankMaster == null || bankMaster.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == bankMaster.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<BankMaster> GetAllBankMasters()
        {
            return GetAll().ToList();
        }

        public BankMaster GetBankMasterByID(int bankMasterID)
        {
            if (bankMasterID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == bankMasterID);
        }

        public bool DeleteBankMaster(int bankLoanID)
        {
            Delete(bankLoanID);
            Commit();
            return true;
        }

        #endregion
    }
}


