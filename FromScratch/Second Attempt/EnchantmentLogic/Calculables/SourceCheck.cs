using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    class SourceCheck : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "SourceCheck";
        [DataMember]
        public EnchantmentUtilities.SourceTypes SourceType;
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
            if(SourceType == ep.triggerSource)
            {
                return 1;
            }
            return 0;
        }
    }
}
