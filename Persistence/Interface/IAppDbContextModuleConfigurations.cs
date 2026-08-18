using Microsoft.EntityFrameworkCore;


namespace Persistence.Interface
{
    public interface IAppDbContextModuleConfigurations
    {
        void Configure(ModelBuilder modelBuilder);
    }
}
