using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP_Portfolio_Subproject_2.DataLayer.Domain
{

    public class userRate
    {
        public string? Uid { get; set; }
        public string? Tconst { get; set; }
        public int Rate { get; set; }
    }
}
