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
    [Table("AnthropometricMeasurements")]
    public class AnthropometricMeasurement : FullAuditedEntity<long, User>
    {
        public double ShoulderHeight { get; set; }
        public double ChestWidth { get; set; }
        public double HumpGirth { get; set; }
        public double LiveWeight { get; set; }
        public double CamelLength { get; set; }
        public double BMI { get; set; }
        public double FatRatioCoefficient { get; set; }
        public double MuscleWeight { get; set; }
        public long? CamelId { get; set; }
        [ForeignKey("CamelId")]
        public Camel Camel { get; set; }
    }
}