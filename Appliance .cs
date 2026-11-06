using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceMaintenanceSystem
{
        
        // Base Abstract Class
        abstract class Appliance : IApplianceMaintenance
        {
        
            private string serialNumber; // Serial number 
            private string brand;        // Brand
            private bool isRepaired;     // Repair status

            


            // Abstract method that every subclass must implement in its own way
            public abstract double CalculateRepairCost();

            public virtual string GetDeviceInfo()
            {
               return $"Device: {this.GetType().Name} | Brand: {brand}, Serial: {serialNumber}";
            }
        }
}
