﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP_Portfolio_Subproject_2.DataLayer.Domain
{

    public class titleEpisode
    {

        public string? Tconst { get; set; }
        public string? ParentTconst { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
