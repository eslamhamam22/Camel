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
    [AutoMapFrom(typeof(CausalVariable))]
    public class CausalVariableDto : EntityDto<long>
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
        public CamelDto Camel { get; set; }
    }
    public class GetCausalVariableOutput
    {
        public CausalVariableDto Camel { get; set; }
    }
    [AutoMapTo(typeof(CausalVariable))]
    public class CreateCausalVariableDto
    {
        public long? Id { get; set; }
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
    }
}