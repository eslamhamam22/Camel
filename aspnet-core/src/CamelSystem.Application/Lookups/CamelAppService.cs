using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using CamelSystem.Authorization;
using CamelSystem.Authorization.Roles;
using CamelSystem.Authorization.Users;
using CamelSystem.Lookups;
using CamelSystem.Lookups.Dto;
using CamelSystem.Users.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CamelSystem.Lookups
{
    [AbpAuthorize(PermissionNames.Pages_Camels)]
    public class CamelAppService : AsyncCrudAppService<Camel, CamelDto, long, PagedCamelResultRequestDto, CreateCamelDto, UpdateCamelDto>, ICamelAppService
    {
        private readonly IRepository<AnthropometricMeasurement, long> _anthropometricMeasurementRepository;
        private readonly IRepository<MechanicalMeasurement, long> _mechanicalMeasurementRepository;
        private readonly IRepository<CausalVariable, long> _causalVariableRepository;
        public CamelAppService(IRepository<Camel, long> repository, IRepository<AnthropometricMeasurement, long> anthropometricMeasurementRepository, IRepository<MechanicalMeasurement, long> mechanicalMeasurementRepository, IRepository<CausalVariable, long> causalVariableRepository)
            : base(repository)
        {
            _anthropometricMeasurementRepository = anthropometricMeasurementRepository;
            _mechanicalMeasurementRepository = mechanicalMeasurementRepository;
            _causalVariableRepository = causalVariableRepository;
        }

        public override async Task<CamelDto> CreateAsync(CreateCamelDto input)
        {
            CheckCreatePermission();

            var camel = ObjectMapper.Map<Camel>(input);

            camel = await Repository.InsertAsync(camel);
            await CurrentUnitOfWork.SaveChangesAsync();
            if (input.Anthropometric != null)
            {
                input.Anthropometric.CamelId = camel.Id;
                await CreateAnthropometricMeasurementAsync(input.Anthropometric);
            }
            if (input.Mechanical != null)
            {
                input.Mechanical.CamelId = camel.Id;
                await CreateMechanicalMeasurementAsync(input.Mechanical);
            }
            if (input.Causal != null)
            {
                input.Causal.CamelId = camel.Id;
                await CreateCausalVariableAsync(input.Causal);
            }
            return MapToEntityDto(camel);
        }

        public async Task<ListResultDto<CamelListDto>> GetCamelsAsync(GetCamelsInput input)
        {
            var camels = await Repository.GetAll().ToListAsync();

            return new ListResultDto<CamelListDto>(ObjectMapper.Map<List<CamelListDto>>(camels));
        }

        public override async Task<CamelDto> UpdateAsync(UpdateCamelDto input)
        {
            try
            {
                CheckUpdatePermission();

                var camel = await Repository.FirstOrDefaultAsync(input.Id);
                //ObjectMapper.Map(input, camel);
                camel.Video = input.Video;
                camel.Description = input.Description;
                await Repository.UpdateAsync(camel);
                if (input.Anthropometric != null)
                {
                    input.Anthropometric.CamelId = camel.Id;
                    var anthropometric = await _anthropometricMeasurementRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
                    if (anthropometric == null)
                        await CreateAnthropometricMeasurementAsync(input.Anthropometric);
                    else
                        await UpdateAnthropometricMeasurementAsync(input.Anthropometric);
                }
                if (input.Mechanical != null)
                {
                    input.Mechanical.CamelId = camel.Id;
                    var mechanical = await _mechanicalMeasurementRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
                    if (mechanical == null)
                        await CreateMechanicalMeasurementAsync(input.Mechanical);
                    else
                        await UpdateMechanicalMeasurementAsync(input.Mechanical);
                }
                if (input.Causal != null)
                {
                    input.Causal.CamelId = camel.Id;
                    var causal = await _causalVariableRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
                    if (causal == null)
                        await CreateCausalVariableAsync(input.Causal);
                    else
                        await UpdateCausalVariableAsync(input.Causal);
                }
                return MapToEntityDto(camel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override async Task DeleteAsync(EntityDto<long> input)
        {
            CheckDeletePermission();

            var camel = await Repository.FirstOrDefaultAsync(input.Id);
            await _anthropometricMeasurementRepository.DeleteAsync(x => x.CamelId == input.Id);
            await _mechanicalMeasurementRepository.DeleteAsync(x => x.CamelId == input.Id);
            await _causalVariableRepository.DeleteAsync(x => x.CamelId == input.Id);
            await Repository.DeleteAsync(camel);
        }

        protected override IQueryable<Camel> CreateFilteredQuery(PagedCamelResultRequestDto input)
        {
            return Repository.GetAllIncluding(x => x.CreatorUser)
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Keyword));
        }

        protected override async Task<Camel> GetEntityByIdAsync(long id)
        {
            return await Repository.GetAllIncluding(x => x.CreatorUser).FirstOrDefaultAsync(x => x.Id == id);
        }

        protected override IQueryable<Camel> ApplySorting(IQueryable<Camel> query, PagedCamelResultRequestDto input)
        {
            return query.OrderBy(r => r.CreationTime);
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        public async Task<GetCamelForEditOutput> GetCamelForEdit(EntityDto input)
        {
            var camel = await Repository.FirstOrDefaultAsync(input.Id);
            var camelEditDto = ObjectMapper.Map<CamelEditDto>(camel);
            camelEditDto.Anthropometric = await GetAnthropometricMeasurementForEdit(input);
            camelEditDto.Mechanical = await GetMechanicalMeasurementForEdit(input);
            camelEditDto.Causal = await GetCausalVariableForEdit(input);
            return new GetCamelForEditOutput
            {
                Camel = camelEditDto
            };
        }

        private async Task<AnthropometricMeasurementDto> GetAnthropometricMeasurementForEdit(EntityDto input)
        {
            var camel = await _anthropometricMeasurementRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
            var camelEditDto = ObjectMapper.Map<AnthropometricMeasurementDto>(camel);
            return camelEditDto;
        }

        private async Task<AnthropometricMeasurementDto> CreateAnthropometricMeasurementAsync(CreateAnthropometricMeasurementDto input)
        {
            CheckCreatePermission();

            var camel = ObjectMapper.Map<AnthropometricMeasurement>(input);

            await _anthropometricMeasurementRepository.InsertAsync(camel);

            return ObjectMapper.Map<AnthropometricMeasurementDto>(camel);
        }

        private async Task<AnthropometricMeasurementDto> UpdateAnthropometricMeasurementAsync(CreateAnthropometricMeasurementDto input)
        {
            CheckUpdatePermission();

            var camel = await _anthropometricMeasurementRepository.FirstOrDefaultAsync(input.Id.Value);

            ObjectMapper.Map(input, camel);

            await _anthropometricMeasurementRepository.UpdateAsync(camel);

            return ObjectMapper.Map<AnthropometricMeasurementDto>(camel);
        }

        private async Task<MechanicalMeasurementDto> GetMechanicalMeasurementForEdit(EntityDto input)
        {
            var camel = await _mechanicalMeasurementRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
            var camelEditDto = ObjectMapper.Map<MechanicalMeasurementDto>(camel);
            return camelEditDto;
        }

        private async Task<MechanicalMeasurementDto> CreateMechanicalMeasurementAsync(CreateMechanicalMeasurementDto input)
        {
            CheckCreatePermission();

            var camel = ObjectMapper.Map<MechanicalMeasurement>(input);

            await _mechanicalMeasurementRepository.InsertAsync(camel);

            return ObjectMapper.Map<MechanicalMeasurementDto>(camel);
        }

        private async Task<MechanicalMeasurementDto> UpdateMechanicalMeasurementAsync(CreateMechanicalMeasurementDto input)
        {
            CheckUpdatePermission();

            var camel = await _mechanicalMeasurementRepository.FirstOrDefaultAsync(input.Id.Value);

            ObjectMapper.Map(input, camel);

            await _mechanicalMeasurementRepository.UpdateAsync(camel);

            return ObjectMapper.Map<MechanicalMeasurementDto>(camel);
        }

        private async Task<CausalVariableDto> GetCausalVariableForEdit(EntityDto input)
        {
            var camel = await _causalVariableRepository.FirstOrDefaultAsync(x => x.CamelId == input.Id);
            var camelEditDto = ObjectMapper.Map<CausalVariableDto>(camel);
            return camelEditDto;
        }

        private async Task<CausalVariableDto> CreateCausalVariableAsync(CreateCausalVariableDto input)
        {
            CheckCreatePermission();

            var camel = ObjectMapper.Map<CausalVariable>(input);

            await _causalVariableRepository.InsertAsync(camel);

            return ObjectMapper.Map<CausalVariableDto>(camel);
        }

        private async Task<CausalVariableDto> UpdateCausalVariableAsync(CreateCausalVariableDto input)
        {
            CheckUpdatePermission();

            var camel = await _causalVariableRepository.FirstOrDefaultAsync(input.Id.Value);

            ObjectMapper.Map(input, camel);

            await _causalVariableRepository.UpdateAsync(camel);

            return ObjectMapper.Map<CausalVariableDto>(camel);
        }

    }
}

