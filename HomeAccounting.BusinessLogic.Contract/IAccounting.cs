using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contracts
{
    public interface IAccounting
    {
        void Create(Account account);
        Account GetById(int id);
        void Save(Account account);
    }
}
