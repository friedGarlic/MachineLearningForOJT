﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_ASP.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        ISubmissionRepository Submission { get; }

        IAccountRepository Account { get; }

        void Save();
    }
}
