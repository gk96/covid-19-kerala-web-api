﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Covid19KeralaApi.Configuration.Dto;

namespace Covid19KeralaApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Covid19KeralaApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
