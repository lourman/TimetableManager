using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableManager
{
    public class Module
    {
        private string code;
        private string description;
        private int credits;

        public Module()
        {
            code = "N/A";
            description = "N/A";
        }

        /// <summary>
        /// Constructor for creating a module by supplying the unique code
        /// and a brief description of the module.
        /// </summary>
        /// <param name="ucascode"></param>
        /// <param name="moduleDescription"></param>
        public Module(string ucascode, string moduleDescription)
        {
            code = ucascode;
            description = moduleDescription;
        }

        /// <summary>
        /// Accessors for obtaining the code of the module
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            return code;
        }

        /// <summary>
        /// Accessors for obtaining the description of the module
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return description;
        }
    }
}
