using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Data.Models
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
    }
}
