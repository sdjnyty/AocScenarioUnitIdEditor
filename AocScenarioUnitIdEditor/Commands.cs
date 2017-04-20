using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;

namespace YTY.AocScenarioUnitIdEditor
{
  public class Commands
  {
    public static ICommand OpenScenario { get; } = new OpenScenarioCommand();

    private class OpenScenarioCommand : ICommand
    {
      public bool CanExecute(object parameter)
      {
        return true;
      }

      public void Execute(object parameter)
      {
        var ofd = new OpenFileDialog();
        var result = ofd.ShowDialog();
        if (!result.HasValue || !result.Value)
          return;
        App.MainWindowViewModel.LoadScx(ofd.FileName);
      }

      public event EventHandler CanExecuteChanged;
    }
  }
}
