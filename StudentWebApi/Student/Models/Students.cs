using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using global::System.Collections.Generic;

namespace StudentWebApi
{
    public class Students
    {
        public int Id { get; set; }
        public  string? Name { get; set; }
        public int? Age { get; set; }
    }
}
