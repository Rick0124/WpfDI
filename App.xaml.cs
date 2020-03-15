using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WpfDI {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup (StartupEventArgs e)
    {
      base.OnStartup (e);

      var collection = new ServiceCollection ();
      collection.AddTransient <MainWindow> ();
      collection.AddScoped<TestClass>();

      var provider = collection.BuildServiceProvider ();
      var mainWindow = provider.GetRequiredService <MainWindow> ();

      mainWindow.Show ();
    }
  }
}
