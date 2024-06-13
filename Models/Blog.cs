using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Task__2.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public User User { get; set; }
       

    }
}
