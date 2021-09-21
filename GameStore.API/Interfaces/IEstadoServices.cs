﻿using GameStore.Domain.Models;
using GameStore.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Interfaces
{
    public interface IEstadoServices : IRepository<Estado>
    {
    }
}
