using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Covid19KeralaApi.Localization
{
    public static class Covid19KeralaApiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Covid19KeralaApiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Covid19KeralaApiLocalizationConfigurer).GetAssembly(),
                        "Covid19KeralaApi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
