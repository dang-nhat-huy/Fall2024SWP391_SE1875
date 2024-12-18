﻿using BusinessObject;
using BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IScheduleUserRepository : IGenericRepository<ScheduleUser>
    {
        Task<IQueryable<ScheduleUser>> GetListScheduleByRoleAsync();
        Task<ScheduleUser?> GetByUserAndScheduleIdAsync(int? userId, int? scheduleId);
        Task<List<ScheduleUser>> GetScheduleUserByStylistIdAsync(int stylistId);
        Task<List<ScheduleUser>> GetScheduleUsersOfStylistsAsync();
        //Task<int?> GetExcludedUserIdByScheduleIdAsync(int scheduleId);
        Task<List<int>> GetExcludedUserIdsByScheduleIdAsync(int scheduleId);
        Task<List<ScheduleUser>> GetSchedulesWithNoUserAsync();
        Task<List<ScheduleUser>> GetSchedulesOfStylistAsync(int userId);
    }
}
