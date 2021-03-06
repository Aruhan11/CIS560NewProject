using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;

namespace LibraryData
{
    public class SqlGeneralQueryRepository: IGeneralQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGeneralQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public User CreateUser(string firstname, string lastname, string phonenumber)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstname));

            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastname));

            if (string.IsNullOrWhiteSpace(phonenumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phonenumber));

            var d = new CreateUserDataDelegate(firstname, lastname, phonenumber);
            return executor.ExecuteNonQuery(d);
        }

        public void DeleteUser(int userID)
        {
         
            if (userID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(userID));

            var d = new DeleteUserDataDelegate(userID);
            executor.ExecuteNonQuery(d);
        }

        public Asset InsertAssetDelegate(string assetname, int assettypeID, string firstname, string lastname, string companyname, DateTime releasedate, int categoryID)
        {
            string tempName = firstname + lastname;
            string tempFullName = firstname + lastname + companyname;

            if ((string.IsNullOrWhiteSpace(firstname) | string.IsNullOrWhiteSpace(lastname) | string.IsNullOrWhiteSpace(companyname)))
                throw new ArgumentException("The paramaters cannot be null or empty.", nameof(tempFullName));


            var d = new InsertAssetDelegate(assetname, assettypeID, firstname, lastname, companyname, releasedate, categoryID);
            return executor.ExecuteNonQuery(d);
        }

        public void SavePhoneNumber(string phonenumber, int userID)
        {
            if (phonenumber == null)
                throw new ArgumentNullException(nameof(phonenumber));


            if (phonenumber.Length != 10)
                throw new ArgumentException("State code must be two characters.", nameof(phonenumber));


            var d = new SavePhoneNumberDelegate(phonenumber, userID);
            executor.ExecuteNonQuery(d);
        }

    }
}
