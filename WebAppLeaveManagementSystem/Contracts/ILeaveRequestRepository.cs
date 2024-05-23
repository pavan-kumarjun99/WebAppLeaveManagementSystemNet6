﻿using WebAppLeaveManagementSystem.Data;
using WebAppLeaveManagementSystem.Models;

namespace WebAppLeaveManagementSystem.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
    }
}
