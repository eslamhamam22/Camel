using Abp.Domain.Entities.Auditing;
using CamelSystem.Authorization.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CamelSystem.Lookups
{
    [Table("CausalVariables")]
    public class CausalVariable : FullAuditedEntity<long, User>
    {
        public double Mass { get; set; }
        public double Velocity { get; set; }
        public double KineticEnergy { get; set; }
        public double VectorDistance { get; set; }
        public double VectorTime { get; set; }
        public double VectorVelocity { get; set; }
        public double LengthCycle { get; set; }
        public double FrequencyCycle { get; set; }
        public double RateVelocity { get; set; }
        public double RightFrontFootSupportTime { get; set; }
        public double LeftFrontFootSupportTime { get; set; }
        public double RightFootSupportTime { get; set; }
        public double LeftFootSupportTime { get; set; }
        public double TotalStepCycleTime { get; set; }
        public long? CamelId { get; set; }
        [ForeignKey("CamelId")]
        public Camel Camel { get; set; }
    }
}