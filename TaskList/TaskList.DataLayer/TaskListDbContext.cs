using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Entities;

namespace TaskList.DataLayer
{
    public partial class TaskListDbContext:DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TaskListDbContext(DbContextOptions<TaskListDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
                _httpContextAccessor = httpContextAccessor;
        }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
