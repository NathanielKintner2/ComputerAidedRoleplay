using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class PrintMessage : Logic, Triggerable
    {
        public Logic parent;
        [DataMember]
        public String message = "";
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "PrintMessage";
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

        public double Trigger(EnchantmentParameters ep)
        {
            Character c = GetParentChar();
            Logic recurse = this;
            while (recurse.Parent != null)
            {
                recurse = recurse.Parent;
            }
            double idx = recurse.GetHashCode();
            c.EnchantmentMessagesForGoogle[idx] = "\n" + message + "\n";
            return 0.0;
        }
    }
}
