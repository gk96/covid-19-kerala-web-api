using System.Threading.Tasks;
using Covid19KeralaApi.Configuration.Dto;

namespace Covid19KeralaApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
