using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt.EnchantmentLogic
{
    public interface Triggerable
    {
        double Trigger(EnchantmentParameters ep);
    }
}
