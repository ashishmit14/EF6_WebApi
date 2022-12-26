﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EF6_WebApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EF6_WebApi.Data
{
    public partial interface ISchoolDBContextProcedures
    {
        Task<List<GetCoursesByStudentIdResult>> GetCoursesByStudentIdAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> sp_DeleteStudentAsync(int? StudentId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<sp_InsertStudentInfoResult>> sp_InsertStudentInfoAsync(int? StandardId, string StudentName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> sp_UpdateStudentAsync(int? StudentId, int? StandardId, string StudentName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
