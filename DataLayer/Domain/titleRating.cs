using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP_Portfolio_Subproject_2.DataLayer.Domain
{

    public class titleRating
    {
        public string? Tconst { get; set; }
        public float AverageRating { get; set; }
        public int NumVotes { get; set; }
    }
}
