﻿using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IBookingDetailRepository : IGenericRepository<BookingDetail>
    {
        Task<List<BookingDetail>> GetBookingByStylistIdAsync(int stylistId);
    }
}
