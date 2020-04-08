﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [ServiceContract]
    interface IService : ILocalItemsService, IItemsQueryService, IItemsEditAddRemoveService
    {
    }
}
