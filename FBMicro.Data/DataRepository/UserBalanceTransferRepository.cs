using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
    public class UserBalanceTransferRepository : EFRepository<UserBalanceTransferDetail>
    {
        #region Constructors

        public UserBalanceTransferRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateUserBalanceTransfer(UserBalanceTransferDetail userBalanceTransfer)
        {
            if (userBalanceTransfer == null) return false;

            var entity = GetFirstOrDefault(x => x.UserId == userBalanceTransfer.UserId && x.BankId == userBalanceTransfer.BankId);
            if (entity != null) return false;

            Insert(userBalanceTransfer);
            Commit();

            return true;
        }

        public bool UpdateUserBalanceTransfer(UserBalanceTransferDetail userBalanceTransfer)
        {
            if (userBalanceTransfer == null || userBalanceTransfer.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == userBalanceTransfer.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<UserBalanceTransferDetail> GetAllUserBalanceTransfers()
        {
            return GetAll().ToList();
        }

        public UserBalanceTransferDetail GetUserBalanceTransferByID(int userBalanceTransferID)
        {
            if (userBalanceTransferID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == userBalanceTransferID);
        }

        public bool DeleteUserBalanceTransfer(int userBalanceTransferID)
        {
            Delete(userBalanceTransferID);
            Commit();
            return true;
        }

        #endregion
    }
}



