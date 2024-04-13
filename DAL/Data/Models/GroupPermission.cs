using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class GroupPermission
    {
        public Guid Id { get; set; }
        public Permission Permission { get; set; }
        public Group Group { get; set; }
    }
}
