// Decompiled with JetBrains decompiler
// Type: CristiDev.Properties.Resources
// Assembly: CristiDev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C3D7EF8D-93FB-46AC-9D58-B36B3502F1BF
// Assembly location: C:\Users\User\Desktop\CristiDev.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CristiDev.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (CristiDev.Properties.Resources.resourceMan == null)
          CristiDev.Properties.Resources.resourceMan = new ResourceManager("CristiDev.Properties.Resources", typeof (CristiDev.Properties.Resources).Assembly);
        return CristiDev.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => CristiDev.Properties.Resources.resourceCulture;
      set => CristiDev.Properties.Resources.resourceCulture = value;
    }
  }
}
