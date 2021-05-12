using System.Threading.Tasks;
using Wingap.Configuration.Dto;

namespace Wingap.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
