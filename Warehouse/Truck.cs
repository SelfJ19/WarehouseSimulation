using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Truck
    {
        /// <summary>
        /// the driver's name, delivery company that the driver works for, the crates in the truck's trailer
        /// </summary>
        string driver { get; set; }
        string deliveryCompany { get; set; }
        Stack<Crate> Trailer { get; set; }

        /// <summary>
        /// Adds a crate to the truck's trailer, being sure to load from back to front
        /// </summary>
        /// <param name="crate"></param>
        void Load(Crate crate)
        {

        }

        /// <summary>
        /// removes a crate from the front of the truck's trailer, moving from front to back
        /// </summary>
        /// <returns></returns>
        Crate Unload()
        {
            return Trailer.Pop();
        }
    }
}
