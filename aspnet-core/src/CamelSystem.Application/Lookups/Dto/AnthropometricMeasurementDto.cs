using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using CamelSystem.Authorization.Roles;

namespace CamelSystem.Lookups.Dto
{
    [AutoMapFrom(typeof(AnthropometricMeasurement))]
    public class AnthropometricMeasurementDto : EntityDto<long>
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
        public CamelDto Camel { get; set; }
    }
    public class GetAnthropometricMeasurementOutput
    {
        public AnthropometricMeasurementDto Camel { get; set; }
    }
    [AutoMapTo(typeof(AnthropometricMeasurement))]
    public class CreateAnthropometricMeasurementDto
    {
        public long? Id { get; set; }
        public double ShoulderHeight { get; set; }
        public double ChestWidth { get; set; }
        public double HumpGirth { get; set; }
        public double LiveWeight { get; set; }
        public double CamelLength { get; set; }
        public double BMI { get; set; }
        public double FatRatioCoefficient { get; set; }
        public double MuscleWeight { get; set; }
        public long? CamelId { get; set; }
    }
}