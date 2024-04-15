using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Permission : ModelBase
    {
        public string Name { get; set; }
        public ICollection<GroupPermission> Groups { get; set; }
    }
}
