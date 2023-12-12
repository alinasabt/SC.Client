using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using StudentControl.Domain.Model;

namespace StudentControl.DTO
{

    public class StudentDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string? Middle_name { get; set; } = string.Empty;
        public Status? Status { get; set; } = null;
        public short Graduate { get; set; } = 0;
        public string? Snils { get; set; } = string.Empty;


        
    }
}
