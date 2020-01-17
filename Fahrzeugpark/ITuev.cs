using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public interface ITuev
    {
        bool IsTested { get; set; }
        string TuevName { get; set; }

        bool MussFahrzeugZumTüv();
    }

    public interface IEmployeeService
    {
       

    }
}
