using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
