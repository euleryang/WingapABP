using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Wingap.Configuration.Dto;

namespace Wingap.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WingapAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
