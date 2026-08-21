using FileProcessingDM.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.SeedExtension
{
    public static class SeedingDbSet
    {
        public static DbSet<Roles> Roles(this AppDbContext context) => context.Set<Roles>();
        public static DbSet<User> Users(this AppDbContext context) => context.Set<User>();
    }
}
