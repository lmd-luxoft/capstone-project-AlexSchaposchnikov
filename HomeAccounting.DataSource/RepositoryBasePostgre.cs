using Dapper;
using HomeAccounting.DataSource.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HomeAccounting.DataSource
{
    public class RepositoryBasePostgre : IRepository
    {
        private readonly String _connectionString = "Server=1-ПК;Database=Learning;User Id=sa;Password=007;";

        public void Add(DbAccount account)
        {
            using(SqlConnection db = new SqlConnection(_connectionString) )
            {
                db.Open();
                db.Execute("insert into dbo.Accounts(CreationDate, Title) Values(@CreationDate, @Title)", new { account.CreationDate, account.Title } );
                db.Close();
            }
        }

        public DbAccount GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
