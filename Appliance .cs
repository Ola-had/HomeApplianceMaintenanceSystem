using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceMaintenanceSystem
{
        // ==========================================
        // 2. Inheritance 
        // ==========================================

        // Base Abstract Class
        abstract class Appliance : IApplianceMaintenance
        {
            // 3. Encapsulation
            // All fields are private and cannot be accessed directly
            private string serialNumber; // Serial number (sensitive, cannot be modified)
            private string brand;        // Brand
            private bool isRepaired;     // Repair status

            


            // Abstract method that every subclass must implement in its own way
            public abstract double CalculateRepairCost();

            public virtual string GetDeviceInfo()
            {
                return $"Brand: {brand}, Serial: {serialNumber}";
            }
        }
}
