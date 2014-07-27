﻿#region Disclaimer/License Info

/* *********************************************** */

// sBlog.Net

// sBlog.Net is a minimalistic blog engine software.

// Homepage: http://sblogproject.net
// Github: http://github.com/karthik25/sBlog.Net

// This project is licensed under the BSD license.  
// See the License.txt file for more information.

/* *********************************************** */

#endregion
using System.Configuration;

namespace sBlog.Net.Configuration
{
    public class SblogNetSettingsConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("connectionString", DefaultValue = "")]
        public string ConnectionString
        {
            get { return (string) this["connectionString"]; }
            set { this["connectionString"] = value; }
        }

        [ConfigurationProperty("enableMiniProfiler", DefaultValue = false)]
        public bool EnableMiniProfiler
        {
            get { return (bool) this["enableMiniProfiler"]; }
            set { this["enableMiniProfiler"] = value; }
        }

        [ConfigurationProperty("hasherFullyQualifiedTypeName")]
        public string HasherFullyQualifiedTypeName
        {
            get { return (string)this["hasherFullyQualifiedTypeName"]; }
            set { this["hasherFullyQualifiedTypeName"] = value; }
        }
        
        [ConfigurationProperty("socialFeatures")]
        public SocialFeaturesElement SocialFeatures
        {
            get { return (SocialFeaturesElement) this["socialFeatures"]; }
            set { this["socialFeatures"] = value; }
        }

        [ConfigurationProperty("theme")]
        public ThemeElement Theme
        {
            get { return (ThemeElement)this["theme"]; }
            set { this["theme"] = value; }
        }
    }
}