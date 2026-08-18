using FileProcessingPL.EntityDbSet;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;

namespace FileProcessingPL.Context
{
    public sealed class FileProcessingModuleConfigurations : IAppDbContextModuleConfigurations
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FileProcessingModuleConfigurations).Assembly);
            modelBuilder.FileProcessingModuleDbSetExt();
        }
    }
}
