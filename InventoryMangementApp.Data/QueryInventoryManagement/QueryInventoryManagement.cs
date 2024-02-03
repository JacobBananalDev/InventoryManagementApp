using InventoryMangementApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementApp.Data.QueryInventoryManagementSQL
{
    public class QueryInventoryManagement : IQueryInventoryMangement
    {
        private static QueryInventoryManagement m_SingletonInstance = null;
        public static QueryInventoryManagement Instance
        {
            get
            {
                if (m_SingletonInstance == null)
                {
                    m_SingletonInstance= new QueryInventoryManagement();
                }
                return m_SingletonInstance;
            }
        }

        private QueryInventoryManagement()
        {

        }
    }
}
