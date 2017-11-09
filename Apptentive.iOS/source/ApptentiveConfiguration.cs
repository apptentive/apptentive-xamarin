using System;
namespace ApptentiveSDK.iOS
{
    /// <summary>
    /// This class wraps the native ApptentiveConfiguration class and adds
    /// DistributionName and DistributionVersion on top of the basic configuration
    /// </summary>
    public class ApptentiveConfiguration
    {
        readonly IApptentiveConfiguration configuration;

        public ApptentiveConfiguration(string apptentiveKey, string apptentiveSignature)
        {
            if (string.IsNullOrEmpty(apptentiveKey))
            {
                throw new ArgumentException("Apptentive key is null or empty");
            }

            if (string.IsNullOrEmpty(apptentiveSignature))
            {
                throw new ArgumentException("Apptentive signature is null or empty");
            }

            configuration = new IApptentiveConfiguration(apptentiveKey, apptentiveSignature);
            configuration.DistributionName = "Xamarin";
            configuration.DistributionVersion = GetType().Assembly.GetName().Version.ToString(3);
        }

        public ApptentiveLogLevel LogLevel
        {
            get { return configuration.LogLevel; }
            set { configuration.LogLevel = value; }
        }

        // Implicit cast operator for API compatibility
        public static implicit operator IApptentiveConfiguration(ApptentiveConfiguration c)
        {
            return c.configuration;
        }
    }
}
