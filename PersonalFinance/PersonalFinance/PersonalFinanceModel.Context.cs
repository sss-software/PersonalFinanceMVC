﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalFinance
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PersonalFinanceAppEntities : DbContext
    {
        public PersonalFinanceAppEntities()
            : base("name=PersonalFinanceAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User_Accounts> User_Accounts { get; set; }
        public virtual DbSet<User_Items> User_Items { get; set; }
        public virtual DbSet<User_Transactions> User_Transactions { get; set; }
    
        public virtual int Insert_UserAccount(string accountID, string userID, string accountName, Nullable<decimal> balance)
        {
            var accountIDParameter = accountID != null ?
                new ObjectParameter("AccountID", accountID) :
                new ObjectParameter("AccountID", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            var accountNameParameter = accountName != null ?
                new ObjectParameter("AccountName", accountName) :
                new ObjectParameter("AccountName", typeof(string));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("Balance", balance) :
                new ObjectParameter("Balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_UserAccount", accountIDParameter, userIDParameter, accountNameParameter, balanceParameter);
        }
    
        public virtual int Insert_UserItems(string iD, string access_Token, string item_ID)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var access_TokenParameter = access_Token != null ?
                new ObjectParameter("Access_Token", access_Token) :
                new ObjectParameter("Access_Token", typeof(string));
    
            var item_IDParameter = item_ID != null ?
                new ObjectParameter("Item_ID", item_ID) :
                new ObjectParameter("Item_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_UserItems", iDParameter, access_TokenParameter, item_IDParameter);
        }
    
        public virtual int Insert_UserTransaction(string transactionID, string accountID, string categoryID, Nullable<System.DateTime> date, string location_Name, string location_City, string location_State, Nullable<decimal> amount)
        {
            var transactionIDParameter = transactionID != null ?
                new ObjectParameter("TransactionID", transactionID) :
                new ObjectParameter("TransactionID", typeof(string));
    
            var accountIDParameter = accountID != null ?
                new ObjectParameter("AccountID", accountID) :
                new ObjectParameter("AccountID", typeof(string));
    
            var categoryIDParameter = categoryID != null ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var location_NameParameter = location_Name != null ?
                new ObjectParameter("Location_Name", location_Name) :
                new ObjectParameter("Location_Name", typeof(string));
    
            var location_CityParameter = location_City != null ?
                new ObjectParameter("Location_City", location_City) :
                new ObjectParameter("Location_City", typeof(string));
    
            var location_StateParameter = location_State != null ?
                new ObjectParameter("Location_State", location_State) :
                new ObjectParameter("Location_State", typeof(string));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_UserTransaction", transactionIDParameter, accountIDParameter, categoryIDParameter, dateParameter, location_NameParameter, location_CityParameter, location_StateParameter, amountParameter);
        }
    }
}