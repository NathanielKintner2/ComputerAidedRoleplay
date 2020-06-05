using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class MathLogic : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public Calculable left;
        [DataMember]
        public Calculable right;
        [DataMember]
        public EnchantmentUtilities.MathTypes operation;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "MathLogic";
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
            get{return parent;}
            set{parent = value;}
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
            if (left != null)
            {
                ((Logic)left).Parent = this;
                ((Logic)left).UpdateAfterSave();
            }
            if (right != null)
            {
                ((Logic)right).Parent = this;
                ((Logic)right).UpdateAfterSave();
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
            if (left != null)
                ((Logic)left).Delete();
            if(right != null)
                ((Logic)right).Delete();
            this.left = null;
            this.right = null;
            this.parent = null;
        }

        public double? Calculate(EnchantmentParameters ep)
        {
            switch (operation)
            {
                case EnchantmentUtilities.MathTypes.Add:
                    return left.Calculate(ep) + right.Calculate(ep);
                case EnchantmentUtilities.MathTypes.Divide:
                    return left.Calculate(ep) / right.Calculate(ep);
                case EnchantmentUtilities.MathTypes.Multiply:
                    return left.Calculate(ep) * right.Calculate(ep);
                case EnchantmentUtilities.MathTypes.Subtract:
                    return left.Calculate(ep) - right.Calculate(ep);
                case EnchantmentUtilities.MathTypes.EqualTo:
                    double? lequal = left.Calculate(ep);
                    double? requal = right.Calculate(ep);
                    if (lequal == requal)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case EnchantmentUtilities.MathTypes.GreaterThan:
                    double? lgreater = left.Calculate(ep);
                    double? rlessthan = right.Calculate(ep);
                    if (lgreater > rlessthan)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
            }
            return 0;            
        }
    }
}
