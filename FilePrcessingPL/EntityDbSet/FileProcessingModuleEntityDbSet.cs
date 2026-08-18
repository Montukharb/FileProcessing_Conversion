using FileProcessingDM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.EntityDbSet
{
    public static class FileProcessingModuleEntityDbSet
    {
        public static void FileProcessingModuleDbSetExt(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}
