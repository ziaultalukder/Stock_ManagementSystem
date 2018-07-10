using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockeManagement.Models.Models;
using StockManagement.BLL.Base;
using StockManagement.Repository;
using StockManagement.Repository.Base;

namespace StockManagement.BLL
{
    public class EmployeeManager:Manager<Employee>
    {
        public EmployeeManager() : base(new EmployeeRepository())
        {
        }
        public override bool Add(Employee employee)
        {
            return base.Add(employee);
        }

        
    }
}
