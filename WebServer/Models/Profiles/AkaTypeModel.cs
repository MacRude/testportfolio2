using System.ComponentModel.DataAnnotations;

namespace WebServer.Models.Profiles
{
    public class AkaTypeModel
    {
        [Key]
        public string? Url { get; set; }
        public int Ordering { get; set; }
        public string? Type { get; set; }
    }
}
