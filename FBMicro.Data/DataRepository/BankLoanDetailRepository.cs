using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
    public class BankLoanDetailRepository : EFRepository<BankLoanDetail>
    {
        #region Constructors

        public BankLoanDetailRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateBankLoanDetail(BankLoanDetail bankLoanDetail)
        {
            if (bankLoanDetail == null) return false;

            var entity = GetFirstOrDefault(x => x.BankId == bankLoanDetail.BankId);
            if (entity != null) return false;

            Insert(bankLoanDetail);
            Commit();

            return true;
        }

        public bool UpdateBankLoanDetail(BankLoanDetail bankLoanDetail)
        {
            if (bankLoanDetail == null || bankLoanDetail.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == bankLoanDetail.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<BankLoanDetail> GetAllBankLoanDetails()
        {
            return GetAll().ToList();
        }

        public BankLoanDetail GetBankLoanDetailByID(int bankLoanID)
        {
            if (bankLoanID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == bankLoanID);
        }

        public bool DeleteBankLoanDetail(int bankLoanID)
        {
            Delete(bankLoanID);
            Commit();
            return true;
        }

        #endregion
    }
}

