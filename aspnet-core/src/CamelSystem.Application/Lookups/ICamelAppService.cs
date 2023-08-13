using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CamelSystem.Lookups.Dto;

namespace CamelSystem.Lookups
{
    public interface ICamelAppService : IAsyncCrudAppService<CamelDto, long, PagedCamelResultRequestDto, CreateCamelDto, UpdateCamelDto>
    {
        Task<GetCamelForEditOutput> GetCamelForEdit(EntityDto input);
        Task<ListResultDto<CamelListDto>> GetCamelsAsync(GetCamelsInput input);
        /*Task<GetAnthropometricMeasurementOutput> GetAnthropometricMeasurementForEdit(EntityDto input);
        Task<AnthropometricMeasurementDto> CreateAnthropometricMeasurementAsync(CreateAnthropometricMeasurementDto input);
        Task<AnthropometricMeasurementDto> UpdateAnthropometricMeasurementAsync(AnthropometricMeasurementDto input);
        Task<GetMechanicalMeasurementOutput> GetMechanicalMeasurementForEdit(EntityDto input);
        Task<MechanicalMeasurementDto> CreateMechanicalMeasurementAsync(CreateMechanicalMeasurementDto input);
        Task<MechanicalMeasurementDto> UpdateMechanicalMeasurementAsync(MechanicalMeasurementDto input);*/

    }
}
