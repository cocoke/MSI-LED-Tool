using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MSI_LED_Tool
{
    [DataContract]
    public class LedSettings
    {
        [DataMember]
        public AnimationType AnimationType { get; set; }

        [DataMember]
        public List<string> Colors { get; set; }
        
        [DataMember]
        public int TemperatureUpperLimit { get; set; }

        [DataMember]
        public int TemperatureLowerLimit { get; set; }

        [DataMember]
        public bool OverwriteSecurityChecks { get; set; }

        [DataMember]
        public bool EnableSideLeds { get; set; }

        [DataMember]
        public int BreathingSpeed { get; set; }
    }
}
