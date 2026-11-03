using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceMaintenanceSystem
{

    // ==========================================
    // 1. Abstraction
    // ==========================================

    // Interface containing the shared core operations for all appliances
    interface IApplianceMaintenance
    {

        string GetDeviceInfo();
        double CalculateRepairCost();
    }

}


