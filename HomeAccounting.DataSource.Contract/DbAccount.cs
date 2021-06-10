using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contracts
{
    public class DbAccount
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
    }
}
