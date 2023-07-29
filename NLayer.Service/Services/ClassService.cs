﻿using NLayer.Core.Concrate;
using NLayer.Core.GenericRepositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Service.GenericManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class ClassService : Service<Class>, IClassService
    {
        public ClassService(IGenericRepository<Class> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}