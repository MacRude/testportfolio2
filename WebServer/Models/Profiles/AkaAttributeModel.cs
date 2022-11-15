using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebServer.Models.Profiles
{

    public class AkaAttributeModel
    {
        [Key]
        public string? Url { get; set; }
        public int Ordering { get; set; }
        public string? Attribute { get; set; }
    }
}
