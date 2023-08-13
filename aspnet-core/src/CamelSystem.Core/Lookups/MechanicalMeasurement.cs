using Abp.Domain.Entities.Auditing;
using CamelSystem.Authorization.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Lookups
{
    [Table("MechanicalMeasurements")]
    public class MechanicalMeasurement : FullAuditedEntity<long, User>
    {
        public double TotalWeight { get; set; }
        public double StrokeDistance { get; set; }
        public double Work { get; set; }
        public double StrokTime { get; set; }
        public double GenralAbility { get; set; }
        public double Velocity { get; set; }
        public double Gravity { get; set; }
        public double Mass { get; set; }
        public double PushingForce { get; set; }
        public long? CamelId { get; set; }
        [ForeignKey("CamelId")]
        public Camel Camel { get; set; }
    }
}