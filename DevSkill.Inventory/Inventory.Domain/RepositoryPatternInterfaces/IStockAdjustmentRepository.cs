﻿using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.RepositoryPatternInterfaces
{
    public interface IStockAdjustmentRepository : IRepositoryBase<StockAdjustment, Guid>
    {
        (IList<StockAdjustment> data, int total, int totaldisplay) GetPagedStockAdjustments(int pageIndex, int pageSize, DataTablesSearch search, string? order);
    }
}
