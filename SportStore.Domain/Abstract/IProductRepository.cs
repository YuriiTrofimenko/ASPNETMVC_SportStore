﻿using SportStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
