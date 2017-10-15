using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
    public class UserHomeLoanRepository : EFRepository<UserHomeLoanDetail>
    {
        #region Constructors

        public UserHomeLoanRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateUserHomeLoan(UserHomeLoanDetail userHomeLoan)
        {
            if (userHomeLoan == null) return false;

            var entity = GetFirstOrDefault(x => x.UserId == userHomeLoan.UserId && x.BankId == userHomeLoan.BankId);
            if (entity != null) return false;

            Insert(userHomeLoan);
            Commit();

            return true;
        }

        public bool UpdateUserHomeLoan(UserHomeLoanDetail userHomeLoan)
        {
            if (userHomeLoan == null || userHomeLoan.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == userHomeLoan.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<UserHomeLoanDetail> GetAllUserHomeLoans()
        {
            return GetAll().ToList();
        }

        public UserHomeLoanDetail GetUserHomeLoanByID(int userHomeLoanID)
        {
            if (userHomeLoanID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == userHomeLoanID);
        }

        public bool DeleteUserHomeLoan(int userHomeLoanID)
        {
            Delete(userHomeLoanID);
            Commit();
            return true;
        }

        #endregion
    }
}




