﻿using System.Collections.Generic;

using Core.Entities.Concrete;

namespace Business.Abstact
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
