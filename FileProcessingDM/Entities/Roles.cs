using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingDM.Entities
{
    public sealed class Roles
    {

        public uint Id { get; set; }
        
        public string RoleName { get; set; } = string.Empty;

        public string NormalizedName { get; set; } = string.Empty;
       

    }
}
