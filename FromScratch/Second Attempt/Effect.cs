using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Second_Attempt
{
    [DataContract]
    public class Effect
    {

        [DataMember]
        public List<EffectHolder.EffectType> effectTypes { get; set; }
        

        [DataMember]
        public EffectHolder.EffectTag effectTag { get; set; }


        [DataMember]
        public Utilities.DamageType? damageType { get; set; }


        [DataMember]
        public double effectStrength { get; set; }

        [DataMember]
        public double deterioration { get; set; }

        [DataMember]
        public int effectLength { get; set; }

        public Effect()
        {

        }

        public Effect(EffectHolder.EffectType efTyp, double efSt, int efLeng, double efDet)
        {
            effectTypes = new List<EffectHolder.EffectType>();
            effectTypes.Add(efTyp);
            effectStrength = efSt;
            effectLength = efLeng;
            deterioration = efDet;
        }
        public Effect(List<EffectHolder.EffectType> efTyplst, double efSt, int efLeng, double efDet)
        {
            effectTypes = efTyplst;
            effectStrength = efSt;
            effectLength = efLeng;
            deterioration = efDet;
        }
        public string getDisplayString()
        {
            //+"Potency Scaling = \t\t" + s.SpellEffects[e].Item1.ToString() + "\n"
            string ret = "";
            foreach (EffectHolder.EffectType ef in effectTypes) {
                ret += ef.ToString() + " ";
            }

            ret += "\nTag =\t\t\t" + effectTag.ToString();
            if (damageType != null)
                ret += "\nDamage Type = \t\t" + damageType.ToString();
            ret += "\nPotency of Effect =\t\t" + effectStrength.ToString()
                    + "\nLength in rounds =\t\t" + effectLength.ToString()
                    + "\nDeterioration =\t\t" + deterioration.ToString()
                    + "\n";
            return ret;
        }
        public string Serialize()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Effect));
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
        public static Effect Deserialize(string strCharacterXml)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(strCharacterXml)))
            {
                DataContractSerializer formatter0 =
                    new DataContractSerializer(typeof(Effect));
                return (Effect)formatter0.ReadObject(reader);
            }
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Effect p = (Effect)obj;
            bool ret = true;
            foreach (EffectHolder.EffectType et in effectTypes) {
                if (!p.effectTypes.Contains(et)) {
                    ret = false;
                }
            }
            foreach (EffectHolder.EffectType et in p.effectTypes)
            {
                if (!effectTypes.Contains(et))
                {
                    ret = false;
                }
            }
            if (!((damageType == null && p.damageType == null) || damageType == p.damageType))
                ret = false;

            return (ret && 
                    Math.Abs(deterioration - p.deterioration) < 0.0001 && 
                    effectLength == p.effectLength &&
                    Math.Abs(effectStrength - p.effectStrength) < 0.0001 &&
                    effectTag == p.effectTag);
        }

        public override int GetHashCode()
        {
            int hashcode = 17;
            hashcode = hashcode * 23 + deterioration.GetHashCode();
            hashcode = hashcode * 23 + effectLength.GetHashCode();
            hashcode = hashcode * 23 + effectStrength.GetHashCode();
            return hashcode;
        }
    }
}
