﻿using Microsoft.EntityFrameworkCore;
using TimeTrackerCourse.Shared.Entities;

namespace TimeTrackerCourse.Data.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<TimeEntry> TimeEntries { get; set; }
}
