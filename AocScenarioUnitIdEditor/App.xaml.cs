using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;

namespace YTY.AocScenarioUnitIdEditor
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public static MainWindowViewModel MainWindowViewModel { get; private set; }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
      MainWindowViewModel = Current.FindResource(nameof(MainWindowViewModel)) as MainWindowViewModel;
    }
  }
}
