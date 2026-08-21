using FileProcessingPL.SeedData;
using Persistence.Context;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.SeedExtension
{
    public sealed class RoleSeeding : IAppDbContextSeeder
    {
        public async Task SeedAsync(AppDbContext dbContext, CancellationToken cancellationToken = default)
        {
            var roleEntity = dbContext.Roles();

            foreach (var seed in RoleSeedData.Create())
            {

                var eachSectionData = await roleEntity.FindAsync([seed.Id]);

                if (eachSectionData is null)
                {
                    roleEntity.Add(seed);
                    continue;
                }
                eachSectionData.Id = seed.Id;
                eachSectionData.RoleName = seed.RoleName;
            }
            await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
