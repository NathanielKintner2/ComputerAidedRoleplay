using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class GetVariable : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public String varName;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "GetVariable";
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
            object ret = GetVariables()[varName][1];
            double d = 0.0;
            Double.TryParse(ret.ToString(), out d);
            return d;
        }
    }
}

