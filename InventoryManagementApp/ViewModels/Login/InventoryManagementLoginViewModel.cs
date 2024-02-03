using InventoryManagementApp.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.ViewModels.Login
{
    public class InventoryManagementLoginViewModel : ViewModelBase
    {
        private static InventoryManagementLoginViewModel m_SingletonInstance = null;
        public static InventoryManagementLoginViewModel Instance
        {
            get
            {
                if (m_SingletonInstance == null)
                {
                    m_SingletonInstance= new InventoryManagementLoginViewModel();
                }
                return m_SingletonInstance;
            }
        }

        private InventoryManagementLoginViewModel()
        {

        }
    }
}
