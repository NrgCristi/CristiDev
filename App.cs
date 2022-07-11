// Decompiled with JetBrains decompiler
// Type: CristiDev.App
// Assembly: CristiDev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C3D7EF8D-93FB-46AC-9D58-B36B3502F1BF
// Assembly location: C:\Users\User\Desktop\CristiDev.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace CristiDev
{
  public class App : Application
  {
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent() => this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
