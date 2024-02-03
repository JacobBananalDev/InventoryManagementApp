using InventoryManagementApp.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.ViewModels
{
    public class InventoryManagementViewModel : ViewModelBase
    {
        private static InventoryManagementViewModel m_SingletonInstance = null;
        public static InventoryManagementViewModel Instance
        {
            get
            {
                if (m_SingletonInstance == null)
                {
                    m_SingletonInstance = new InventoryManagementViewModel();
                }
                return m_SingletonInstance;
            }
        }

        private InventoryManagementViewModel()
        {

        }
    }
}
