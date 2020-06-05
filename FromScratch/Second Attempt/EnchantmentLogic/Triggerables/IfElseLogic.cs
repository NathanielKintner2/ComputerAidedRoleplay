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
    [KnownType(typeof(PrintMessage))]
    [KnownType(typeof(IfElseLogic))]
    [KnownType(typeof(ReturnValue))]
    [KnownType(typeof(MathLogic))]
    [KnownType(typeof(DoubleValue))]
    [KnownType(typeof(SetVariable))]
    [KnownType(typeof(GetVariable))]
    [KnownType(typeof(SourceCheck))]
    [KnownType(typeof(ParamReader))]
    [KnownType(typeof(MakeAttack))]
    [KnownType(typeof(EffectTypeCheck))]
    [KnownType(typeof(CreateEffect))]

    public class IfElseLogic : Logic, Triggerable
    {
        public Character CharParent;
        public Logic parent;
        [DataMember]
        public List<Calculable> conditions = new List<Calculable>();
        [DataMember]
        public List<Triggerable> ifResults = new List<Triggerable>();
        [DataMember]
        public List<Triggerable> elseResults = new List<Triggerable>();
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "IfElseLogic";
        [DataMember]
        public List<Object[]> variables = new List<Object[]>();
        
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
            if(this.parent != null)
            {
                return parent.GetParentChar();
            }
            else
            {
                return CharParent;
            }
        }
        public Dictionary<String, Object[]> GetVariables()
        {
            Dictionary<String, Object[]> ret = new Dictionary<String, Object[]>();
            foreach(Object[] t in variables)
            {
                ret.Add((String)t[0], t);
            }
            if(parent != null)
            {
                Dictionary<String, Object[]> prev = parent.GetVariables();
                foreach (String s in prev.Keys)
                {
                    if (!ret.ContainsKey(s))
                    {
                        ret.Add(s, prev[s]);
                    }
                }
            }
            return ret;
        }

        public void UpdateAfterSave()
        {
            foreach (Logic l in conditions)
            {
                l.Parent = this;
                l.UpdateAfterSave();
            }
            foreach (Logic l in ifResults)
            {
                l.Parent = this;
                l.UpdateAfterSave();
            }
            foreach (Logic l in elseResults)
            {
                l.Parent = this;
                l.UpdateAfterSave();
            }
        }
        public void Delete()
        {
            if(display != null)
                this.display.Close();
            foreach (Calculable c in conditions)
            {
                ((Logic)c).Delete();
            }
            foreach (Triggerable t in ifResults)
            {
                ((Logic)t).Delete();
            }
            foreach (Triggerable t in elseResults)
            {
                ((Logic)t).Delete();
            }
            conditions.Clear();
            ifResults.Clear();
            elseResults.Clear();
            this.parent = null;
        }

        public double Trigger(EnchantmentParameters ep)
        {
            double ret = 0.0;
            bool conditionsMet = true;
            foreach(Calculable c in conditions)
            {
                double? calc = c.Calculate(ep);
                if (calc == null || calc <= 0)
                {
                    conditionsMet = false;
                }
            }
            if (conditionsMet)
            {
                foreach (Triggerable t in ifResults)
                {
                    ret += t.Trigger(ep);
                }
            }
            else
            {
                foreach (Triggerable t in elseResults)
                {
                    ret += t.Trigger(ep);
                }
            }
            return ret;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Serialize()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(IfElseLogic));
            string xmlString;
            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                    serializer.WriteObject(writer, this);
                    writer.Flush();
                    xmlString = sw.ToString();
                }
            }
            return xmlString;
        }
        public static IfElseLogic Deserialize(string strCharacterXml)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(strCharacterXml)))
            {
                DataContractSerializer formatter0 =
                    new DataContractSerializer(typeof(IfElseLogic));
                return (IfElseLogic)formatter0.ReadObject(reader);
            }
        }

        public IfElseLogic MakeDeepCopy()
        {
            String copyString = this.Serialize();
            IfElseLogic ret = Deserialize(copyString);
            return ret;
        }
    }
}
