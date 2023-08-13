using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CamelSystem.Configuration.Dto;

namespace CamelSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CamelSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
