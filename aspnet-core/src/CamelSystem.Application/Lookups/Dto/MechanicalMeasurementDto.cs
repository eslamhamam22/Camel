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
    [AutoMapFrom(typeof(MechanicalMeasurement))]
    public class MechanicalMeasurementDto : EntityDto<long>
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
        public CamelDto Camel { get; set; }
    }
    public class GetMechanicalMeasurementOutput
    {
        public MechanicalMeasurementDto Camel { get; set; }
    }
    [AutoMapTo(typeof(MechanicalMeasurement))]
    public class CreateMechanicalMeasurementDto
    {
        public long? Id { get; set; }
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
    }
}