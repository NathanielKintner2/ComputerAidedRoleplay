using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    class EffectTypeCheck : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "EffectTypeCheck";
        [DataMember]
        public string effTag;
        [DataMember]
        public string effType;
        [DataMember]
        public string damType;
        public String LogicType
        {
            get { return logicType; }
            set { logicType = value; }
        }
        public Form Display
        {
            get { return display; }
            set { display = value; }
        }
        public Logic Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Character GetParentChar()
        {
            return parent.GetParentChar();
        }

        public void UpdateAfterSave()
        {
        }

        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void Delete()
        {
            if (display != null)
                this.display.Close();
            this.parent = null;
        }

        public double? Calculate(EnchantmentParameters ep)
        {
            string effTagforcalc = EnchantmentUtilities.checkForVariable(effTag, this);
            string effTypeforcalc = EnchantmentUtilities.checkForVariable(effType, this);
            string damTypeforcalc = EnchantmentUtilities.checkForVariable(damType, this);
            if ((ep.eta == null || effTagforcalc == ep.eta.ToString()) &&
                (ep.ety == null || effTypeforcalc == ep.ety.ToString()) &&
                 (damTypeforcalc ?? "") == ep.dty.ToString())
            {
                return 1;
            }
            return 0;
        }
    }
}

