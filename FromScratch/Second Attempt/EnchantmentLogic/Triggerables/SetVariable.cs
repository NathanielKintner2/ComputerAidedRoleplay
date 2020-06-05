using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class SetVariable : Logic, Triggerable
    {
        public Logic parent;
        [DataMember]
        public Calculable setTo;
        [DataMember]
        public String varName;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "SetVariable";
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
            if (setTo != null)
            {
                ((Logic)setTo).Parent = this;
                ((Logic)setTo).UpdateAfterSave();
            }
        }

        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void Delete()
        {
            if (display != null)
                this.display.Close();
            if (setTo != null)
                ((Logic)setTo).Delete();
            this.setTo = null;
            this.parent = null;
        }

        public double Trigger(EnchantmentParameters ep)
        {
            double? dn = setTo.Calculate(ep);
            if(dn == null)
            {
                return 0;
            }
            double d = (double)dn;
            GetVariables()[varName][1] = d;
            return 0.0;
        }
    }
}