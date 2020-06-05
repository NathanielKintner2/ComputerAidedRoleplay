using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt.EnchantmentLogic
{
    public interface Calculable
    {
        double? Calculate(EnchantmentParameters ep);
    }
}
