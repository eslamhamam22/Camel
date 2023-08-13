using Abp.Domain.Entities.Auditing;
using CamelSystem.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Lookups
{
    [Table("Camels")]
    public class Camel : FullAuditedEntity<long, User>
    {
        public string Video { get; set; }
        public string Description { get; set; }
    }
}