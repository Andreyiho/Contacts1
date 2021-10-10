using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Contacts.Services.Settings
{
    public class SettingsManager : ISettingsManager
    {
        int Count { get; set; }
        int ISettingsManager.Count 
        {
            get => Preferences.Get(nameof(Count), 5); 
            set => Preferences.Set(nameof(Count), value); 
        }
    }
}
