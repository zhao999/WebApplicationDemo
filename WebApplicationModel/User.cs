using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationModel
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public int groupid { get; set; }
        public string groupname { get; set; }
    }
}
