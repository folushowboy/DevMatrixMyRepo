using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    /// <summary>
    /// This class is about a particular institution employee data
    /// </summary>
    internal class EmployeeData
    {
        /// <summary>
        /// 
        /// </summary>
        public int id {  get; set; }

        /// <summary>
        /// it is used for checking if a value is deleted
        /// </summary>
        /// <param name="x"></param>
        /// <returns>bool</returns>
        public static bool IsDeleted(string x)
        {
            x = "welcome";
            return true;
        }
    }
}
