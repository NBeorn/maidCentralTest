using maidCentralTest.Debugging;

namespace maidCentralTest
{
    public class maidCentralTestConsts
    {
        public const string LocalizationSourceName = "maidCentralTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "917e4c3d4d8844899c6939d5a7a39a51";
    }
}
