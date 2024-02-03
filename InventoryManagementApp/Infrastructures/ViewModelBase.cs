using InventoryMangementApp.Data.QueryInventoryManagementSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Infrastructures
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public QueryInventoryManagement QueryInventoryManagement => QueryInventoryManagement.Instance;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
