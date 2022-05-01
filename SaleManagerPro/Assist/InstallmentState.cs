using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagerPro.Assist
{
    public enum  InstallmentState
    {
         
         NotToPay, 
         OnForgivness,
         TimeToPay,
         Paid, 
         PartPaid,
         InLowDepartment
    }
    public enum CheckState
    {

        NotToPay,
        TimeToPay,
        Paid,
        InLowDepartment
    }
   
}
