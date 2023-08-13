using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using CamelSystem.Authorization.Roles;

namespace CamelSystem.Lookups.Dto
{
    [AutoMapFrom(typeof(Camel))]
    public class CamelDto : EntityDto<long>
    {
        public string Video { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public CreateMechanicalMeasurementDto Mechanical { get; set; }
        public CreateAnthropometricMeasurementDto Anthropometric { get; set; }
        public CreateCausalVariableDto Causal { get; set; }
    }
    [AutoMapTo(typeof(Camel))]
    public class CreateCamelDto
    {
        public long? Id { get; set; }
        public string Video { get; set; }
        public string Description { get; set; }
        public CreateMechanicalMeasurementDto Mechanical { get; set; }
        public CreateAnthropometricMeasurementDto Anthropometric { get; set; }
        public CreateCausalVariableDto Causal { get; set; }
    }
    [AutoMapTo(typeof(Camel))]
    public class UpdateCamelDto : EntityDto<long>
    {
        public string Video { get; set; }
        public string Description { get; set; }
        public CreateMechanicalMeasurementDto Mechanical { get; set; }
        public CreateAnthropometricMeasurementDto Anthropometric { get; set; }
        public CreateCausalVariableDto Causal { get; set; }
    }
    public class PagedCamelResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
    public class GetCamelsInput
    {
        public string Keyword { get; set; }
    }
    public class CamelListDto : EntityDto, IHasCreationTime
    {
        public string Video { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
    [AutoMapFrom(typeof(Camel))]
    public class CamelEditDto : EntityDto<long>
    {
        public string Video { get; set; }
        public string Description { get; set; }
        public MechanicalMeasurementDto Mechanical { get; set; }
        public AnthropometricMeasurementDto Anthropometric { get; set; }
        public CausalVariableDto Causal { get; set; }
    }
    public class GetCamelForEditOutput
    {
        public CamelEditDto Camel { get; set; }
    }
}