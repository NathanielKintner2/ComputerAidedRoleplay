using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class DoubleValue : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public double val = 0.0;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "DoubleValue";


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
        }
        public void Delete()
        {
            if (display != null)
                this.display.Close();
            this.parent = null;            
        }

        public double? Calculate(EnchantmentParameters ep)
        {
            return val;
        }
    }
}