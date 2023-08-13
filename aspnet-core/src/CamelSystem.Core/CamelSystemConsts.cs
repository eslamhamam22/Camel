using CamelSystem.Debugging;

namespace CamelSystem
{
    public class CamelSystemConsts
    {
        public const string LocalizationSourceName = "CamelSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1c63790619764fc6b7264399fccbe6b6";
    }
}
