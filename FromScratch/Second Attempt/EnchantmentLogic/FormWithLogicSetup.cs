using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt.EnchantmentLogic
{
    public interface FormWithLogicSetup
    {
        Logic Data();
        void Setup(Logic l);
        void Show();
        void Hide();
    }
}
