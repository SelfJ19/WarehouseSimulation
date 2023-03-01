using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Dock
    {
        /// <summary>
        /// dock's unique id number, truck's in the dock's line, total cost of all crates unloaded at this dock, total number of crates unloaded at this dock, total number of trucks processed at this dock, total number of time increments this dock was loading a truck, total number of time increments this dock was NOT loading a truck 
        /// </summary>
        string Id { get; set; }
        Queue<Truck> Line { get; set; }
        double TotalSales { get; set; }
        int TotalCrates { get; set; }
        int TotalTrucks { get; set; }
        int TimeInUse { get; set; }
        int TimeNotInUse { get; set; }

        /// <summary>
        /// Adds a truck to the dock's line
        /// </summary>
        /// <param name="truck"></param>
        void JoinLine(Truck truck)
        {
            Line = new Queue<Truck>();
        }

        /// <summary>
        /// Removes and returns the first Truck from the dock's line
        /// </summary>
        /// <returns></returns>
        Truck SendOff()
        {
            return Line.Dequeue();
        }
    }
}
