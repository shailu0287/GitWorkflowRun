
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Security.Permissions;
using System.Configuration;
using System.Collections.Specialized;

namespace ApplicationSettings.Properties
{


    [PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
    [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
    public class EC2DataProvider : SettingsProvider
    {
        private string conn;

        public EC2DataProvider()
        {
        }

        public override void Initialize(string name, NameValueCollection col)
        {
            base.Initialize(this.ApplicationName, col);
        }

        public override string ApplicationName
        {
            get => ApplicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            set
            {
            }
        }


        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            var settings = new SettingsPropertyValueCollection();

            try
            {
                foreach (SettingsProperty propDef in collection)
                {
                    // Compiler will issue a warning if we attempt to use the iteration variable
                    // in a lambda expression, so we reassign propDef to a new variable
                    var lmb_propDef = propDef;
                    // Create a new instance of SettingsPropertyValue from the property definition
                    var setting = new SettingsPropertyValue(propDef);
                    var settingEntity = Environment.GetEnvironmentVariable(lmb_propDef.Name);
                    if (settingEntity != null)
                        // If a matching property is found, its value is used.                    
                        setting.PropertyValue = settingEntity.ToString();
                    else
                    {
                    }

                    settings.Add(setting);

                }

            }
            catch (Exception ex)
            {
            }

            // Return the collection to the settings class
            return settings;
        }


        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
            }
        }
    }
}


