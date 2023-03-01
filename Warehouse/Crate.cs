using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Crate
    {
        /// <summary>
        /// the crates unique id number and the cost of the crates contents which will be a random value from 50-500 dollars
        /// </summary>
        string Id { get; set; }
        double Price { get; set; }
    }
}
