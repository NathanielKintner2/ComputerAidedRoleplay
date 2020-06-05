using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Second_Attempt
{
    public partial class AttackChart : Form
    {
        private List<DataPoint> _lstData;
        Character _char1 = new Character();
        Character _char2 = new Character();
        public AttackChart(Character char1, Character char2)
        {
            InitializeComponent();            
            _char1 = char1;
            _char2 = char2;
            labelAttacker.Text = char1.Name;
            labelDefender.Text = char2.Name;
        }

        private List<DataPoint> CreateDataPoints()
        {            
            List<DataPoint> lstData = new List<DataPoint>();
            Random r = new Random();
            Double average = 0;
            Character copy1 = Utilities.GetSameCharWithCurrentState(_char1);
            Character copy2 = Utilities.GetSameCharWithCurrentState(_char2);
            for (int i = 1; i < 21;i++ )
            {                
                for (int j = 1; j < 21; j++)
                {
                    copy1.TemporaryEffects = new List<Effect>();
                    foreach (Effect ef in _char1.TemporaryEffects)
                    {
                        copy1.TemporaryEffects.Add(ef);
                    }
                    copy2.TemporaryEffects = new List<Effect>();
                    foreach (Effect ef in _char2.TemporaryEffects)
                    {
                        copy2.TemporaryEffects.Add(ef);
                    }
                    AttackOutcome _outcome = CombatScripts.RunCombat(copy1, copy2, i, j, null);
                    if (!checkBoxDoLocationCheck.Checked)
                    {
                        //_outcome.recalculateWithoutLocation();
                    }
                    
                    double Red = 0;
                    double Blue = 0;
                    double Green = 0;
                    double Damage = 0.0;
                    if (!checkBoxHarm.Checked &&
                        !checkBoxBleed.Checked &&
                        !checkBoxDisorientation.Checked &&
                        !checkBoxImpairment.Checked &&
                        !checkBoxTrauma.Checked &&
                        !checkBoxKO.Checked)
                    {
                        Damage = _outcome.TotalStrikeAmountFromAllTypes();
                    }
                    if (checkBoxHarm.Checked)
                    {
                        Damage += _outcome.harm;
                    }
                    if (checkBoxBleed.Checked)
                    {
                        Damage += _outcome.bleed;
                    }
                    if (checkBoxDisorientation.Checked)
                    {
                        Damage += _outcome.disorientation;
                    }
                    if (checkBoxImpairment.Checked)
                    {
                        Damage += _outcome.impairment;
                    }
                    if (checkBoxTrauma.Checked)
                    {
                        Damage += _outcome.trauma;
                    }
                    if (checkBoxKO.Checked)
                    {
                        Damage += _outcome.ko;
                    }
                    switch (_outcome.Othertext.ToString())
                    {                        
                        case "Miss":
                            Red = 0;
                            Blue = 0;
                            Green = 0;
                            break;                       
                        case "Block":
                            Red = 100;
                            Blue = 100;
                            Green = 100;
                            break;
                        case "Parry":
                            Red = 200;
                            Blue = 200;
                            Green = 200;
                            break;
                        case "Hit":
                            if (Damage < 100)
                            {
                                Red = 255;
                                Blue = 255;
                                Green = 255;
                            }
                            if (Damage < 50)
                            {
                                Red = 200;
                                Blue = 0;
                                Green = 0;
                            }
                            if (Damage < 20)
                            {
                                Red = 200;
                                Blue = 0;
                                Green = 200;
                            }
                            if (Damage < 15)
                            {
                                Red = 0;
                                Blue = 0;
                                Green = 200;
                            }
                            if (Damage < 10)
                            {
                                Red = 0;
                                Blue = 200;
                                Green = 200;
                            }
                            if (Damage < 5)
                            {
                                Red = 0;
                                Blue = 250;
                                Green = 100;
                            }
                            if (Damage < 4)
                            {
                                Red = 50;
                                Blue = 200;
                                Green = 0;
                            }
                            if (Damage < 3)
                            {
                                Red = 100;
                                Blue = 125;
                                Green = 0;
                            }
                            if (Damage < 2)
                            {
                                Red = 200;
                                Blue = 100;
                                Green = 50;
                            }
                            if (Damage < 1)
                            {
                                Red = 225;
                                Blue = 0;
                                Green = 125;
                            }
                            break;
                        default:
                            throw new Exception("WTF did you give me?");
                    }
                    int iRed = Convert.ToInt32(Math.Floor(Red));
                    int iBlue = Convert.ToInt32(Math.Floor(Blue));
                    int iGreen = Convert.ToInt32(Math.Floor(Green));
                    DataPoint dp = new DataPoint(10, 10, 11 * i, 11 * j, iRed, iGreen, iBlue);
                    lstData.Add(dp);
                    average += Damage;
                }
            }
            lblAverage.Text = "Average Damage: " + Math.Round(average * 10/ 400)/10;            
            return lstData;
        }

        private void RenderDataPoints(List<DataPoint> lstData)
        {
            Graphics panelGraphics;
            foreach (DataPoint dp in lstData)
            {
                panelGraphics = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(dp.DisplayColor);
                panelGraphics.FillRectangle(brush, new Rectangle(dp.XCoordinate, 300 - dp.YCoordinate, dp.Width, dp.Height));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _lstData = CreateDataPoints();
            RenderDataPoints(_lstData);
        }

        private void checkBoxHarm_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxBleed_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxDisorientation_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxImpairment_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxTrauma_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxKO_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }

        private void checkBoxDoLocationCheck_CheckedChanged(object sender, EventArgs e)
        {
            panel1_Paint(null, null);
        }
    }

    public class DataPoint
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color DisplayColor { get; set; }
        public DataPoint() { }
        public DataPoint(int iWidth, int iHeight, int iX, int iY, int iRed, int iGreen, int iBlue)
        {
            if (iRed < 0 || iRed > 255)
                throw new ArgumentOutOfRangeException("iRed must be between 0 and 255");
            if (iGreen < 0 || iGreen > 255)
                throw new ArgumentOutOfRangeException("iGreen must be between 0 and 255");
            if (iBlue < 0 || iBlue > 255)
                throw new ArgumentOutOfRangeException("iBlue must be between 0 and 255");

            DisplayColor = Color.FromArgb(iRed, iGreen, iBlue);
            Width = iWidth;
            Height = iHeight;
            XCoordinate = iX;
            YCoordinate = iY;
        }
    }
}
