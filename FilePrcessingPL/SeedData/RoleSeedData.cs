using FileProcessingDM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.SeedData
{
    public sealed class RoleSeedData
    {
        public static Roles[] Create() =>
         [

            new Roles { Id = 1, RoleName = "Admin"},
            new Roles { Id = 1, RoleName = "Admin"},
            new Roles { Id = 2, RoleName = "User"},
            new Roles { Id = 3, RoleName = "Manager"},
            new Roles { Id = 4, RoleName = "SuperAdmin"},
            new Roles { Id = 5, RoleName = "Employee"},
            new Roles { Id = 6, RoleName = "Emergency"},
            new Roles { Id = 7, RoleName = "GeneralActivitst"}

         ];
    }
}
