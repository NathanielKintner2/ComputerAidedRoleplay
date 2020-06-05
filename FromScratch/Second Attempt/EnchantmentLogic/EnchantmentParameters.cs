using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt.EnchantmentLogic
{
    public class EnchantmentParameters
    {
        public AttackOutcome ao;
        public SpellToCast stc;
        public EnchantmentUtilities.SourceTypes triggerSource;
        public EffectHolder.EffectTag? eta;
        public EffectHolder.EffectType? ety;
        public Utilities.DamageType? dty;

        public EnchantmentParameters()
        {
            
        }
    }
}
