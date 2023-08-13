using System.Threading.Tasks;
using CamelSystem.Configuration.Dto;

namespace CamelSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
