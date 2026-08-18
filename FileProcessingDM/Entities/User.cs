using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FileProcessingDM.Entities
{
    public sealed class User
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}
