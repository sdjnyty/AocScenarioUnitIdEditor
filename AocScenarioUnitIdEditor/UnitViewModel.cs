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
  public class UnitViewModel : INotifyPropertyChanged
  {
    public Unit Model { get; }

    public int Id
    {
      get => Model.Id;
      set
      {
        Model.Id = value;
        OnPropertyChanged(nameof(Id));
      }
    }

    public UnitViewModel(Unit model)
    {
      Model = model;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
