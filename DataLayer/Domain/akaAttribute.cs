using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CITP_Portfolio_Subproject_2.DataLayer.Domain
{

    public class AkaAttribute
    {
        public string Url;

        [Key]
        public string? Tconst { get; set; }
        public int Ordering { get; set; }
        public string? Attribute { get; set; }
    }
}
