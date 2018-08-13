using System;
using System.Collections.Generic;
using System.Text;

namespace Irpf.BLL
{
    public interface CalculoIrpf
    {
        double calculaImposto(Contribuinte c);
    }
}
