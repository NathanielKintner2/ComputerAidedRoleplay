using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class ReturnValue : Logic, Triggerable
    {
        public Logic parent;
        [DataMember]
        public Calculable valueToReturn;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "ReturnValue";
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
        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void UpdateAfterSave()
        {
            ((Logic)valueToReturn).Parent = this;
            ((Logic)valueToReturn).UpdateAfterSave();
        }
        public void Delete()
        {
            if (display != null)
                this.display.Close();
            this.parent = null;
        }
        public double Trigger(EnchantmentParameters ep)
        {
            double? valn = valueToReturn.Calculate(ep);
            if(valn == null)
            {
                return 0;
            }
            return (double)valn;
        }
    }
}
