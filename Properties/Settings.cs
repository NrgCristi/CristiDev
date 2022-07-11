// Decompiled with JetBrains decompiler
// Type: CristiDev.Properties.Settings
// Assembly: CristiDev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C3D7EF8D-93FB-46AC-9D58-B36B3502F1BF
// Assembly location: C:\Users\User\Desktop\CristiDev.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace CristiDev.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
