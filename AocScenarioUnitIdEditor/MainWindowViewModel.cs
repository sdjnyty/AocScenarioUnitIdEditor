using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using YTY.ScxLib;

namespace YTY.AocScenarioUnitIdEditor
{
  public class MainWindowViewModel : INotifyPropertyChanged
  {
    private ScxFile scx;
    private List<UnitViewModel> units;

    public List<UnitViewModel> Units
    {
      get { return units; }
      set
      {
        units = value;
        OnPropertyChanged(nameof(Units));
      }
    }

    public void LoadScx(string fileName)
    {
      scx = new ScxFile(fileName);
      Units = scx.Units.SelectMany(ul => ul, (_, u) => new UnitViewModel(u)).ToList();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
