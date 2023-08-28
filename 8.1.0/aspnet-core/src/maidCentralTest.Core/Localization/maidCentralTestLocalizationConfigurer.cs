using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace maidCentralTest.Localization
{
    public static class maidCentralTestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(maidCentralTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(maidCentralTestLocalizationConfigurer).GetAssembly(),
                        "maidCentralTest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
