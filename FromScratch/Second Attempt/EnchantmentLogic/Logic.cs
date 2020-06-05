using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt
{
    public interface Logic
    {
        Logic Parent
        {
            get;
            set;
        }

        String Name
        {
            get;
            set;
        }

        String LogicType
        {
            get;
            set;
        }

        Form Display
        {
            get;
            set;
        }

        Dictionary<String, Object[]> GetVariables();

        Character GetParentChar();

        void Delete();
        void UpdateAfterSave();
    }
}
