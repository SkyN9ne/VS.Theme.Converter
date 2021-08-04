﻿namespace VSCodeThemeImporter
{
    using System.Runtime.Serialization;

    [DataContract]
    public class SettingsContract
    {
        [DataMember(Name = "foreground", IsRequired = false)]
        public string Foreground { get; set; }

        [DataMember(Name = "background", IsRequired = false)]
        public string Background { get; set; }
    }
}
