﻿using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class OperationClaim : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

    }
}