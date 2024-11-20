﻿using StudentManagementSystem.Core.Models.Admin.Teacher;

namespace StudentManagementSystem.Core.Contracts.Admin
{
    public interface IAdminTeacherService
    {
        Task<int> CreateTeacherAsync(TeacherFormViewModel model);
        Task EditTeacherAsync(int id, TeacherFormViewModel model);
        Task DeleteTeacherAsync(int id);
        Task<IEnumerable<TeacherServiceModel>> GetAllTeachersAsync();
        Task<TeacherServiceModel> GetTeacherByIdAsync(int id);
    }
}