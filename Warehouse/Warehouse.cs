using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Warehouse
    {
        /// <summary>
        /// the warehouse's docks,up to a max of 15, all trucks must pass through the warehouse entrance before joining a line at a dock
        /// </summary>
        List<Dock> Docks { get; set; }
        Queue<Truck> Entrance { get; set; }

        void Run()
        {
            //runs the simulation
        }
    }
}
