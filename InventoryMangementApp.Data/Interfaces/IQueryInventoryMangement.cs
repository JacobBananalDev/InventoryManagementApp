using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementApp.Data.Interfaces
{
    public interface IQueryInventoryMangement
    {
        void AddUser(string username, string password, string firstName, string lastName);
        
    }
}
