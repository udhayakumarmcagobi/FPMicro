using FBMicro.Data.DataProvider;
using FBMicro.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMicro.Data.DataRepository
{
   public class UserDetailRepository  :EFRepository<UserDetail>
    {
        #region Constructors

        public UserDetailRepository() : base(new EFUnitOfWork()) { }

        #endregion

        #region Public Methods

        public bool CreateUser(UserDetail user)
        {
            if (user == null) return false;

            var entity = GetFirstOrDefault(x => x.Name.Equals(user.Name) && x.ContactNo.Equals(user.ContactNo));
            if (entity != null)
            {
                user.Id = entity.Id;
                return true;
            }
            Insert(user);
            Commit();

            return true;
        }

        public bool UpdateUser(UserDetail user)
        {
            if (user == null || user.Id <= 0) return false;

            var entity = GetFirstOrDefault(x => x.Id == user.Id);
            if (entity == null) return false;

            Update(entity);
            Commit();

            return true;
        }

        public IEnumerable<UserDetail> GetAllUsers()
        {
            return GetAll().ToList();
        }

        public UserDetail GetUserByID(int userID)
        {
            if (userID <= 0) return null;

            return GetFirstOrDefault(x => x.Id == userID);
        }

        public UserDetail GetUserByName(string userName, string contactNo)
        {
            if (string.IsNullOrWhiteSpace(userName)) return null;

            return GetFirstOrDefault(x => x.Name.Equals(userName) && x.ContactNo.Equals(contactNo));
        }

        public bool DeleteUser(int userID)
        {
            Delete(userID);
            Commit();
            return true;
        }

        #endregion
    }
}
