using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using HtmlAgilityPack;

namespace Second_Attempt
{
    public static class HTMLWriter
    {
        public static string BaseURL()
        {
            string ret = "";
            try
            {
                while (Utilities.ServerWasStarted == false && SimpleServer.isRunning) { }
                if (!SimpleServer.isRunning)
                {
                    throw new InvalidOperationException("Server is not running");
                }
                string localIP;
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIP = endPoint.Address.ToString();
                }
                ret = "http://" + localIP + ":";
                ret += Utilities.myServer.Port.ToString();
            }
            catch
            {
                ret = "Failed To Connect";
            }
            return ret;
        }
        public static string StandardStyle()
        {
            StreamReader input = new StreamReader(new FileStream("ZZZStylePart.html", FileMode.Open));
            string ret = input.ReadToEnd();
            input.Close();
            return ret;
        }
        public static string Test()
        {
            StreamReader input = new StreamReader(new FileStream("ZZZStyleTest.html", FileMode.Open));
            string ret = input.ReadToEnd();
            input.Close();
            var doc = new HtmlDocument();
            doc.Load("ZZZStyleTest.html");
            var nodewep = doc.GetElementbyId("selectedweapon");
            var wep = nodewep.Attributes["value"].Value;
            var node = doc.DocumentNode.SelectSingleNode("//div");
            var node2 = node.ChildNodes[1];
            return ret;
        }
        public static string EndBit()
        {
            return "</body>\n</html>\n";
        }
        public static string MainMenu()
        {
            string ret = StandardStyle();             
            ret += "<a href = \"" + BaseURL() + "/Weapons\">Weapons</a><br>";
            ret += "<a href = \"" + BaseURL() + "/Characters\">Characters</a><br>";
            ret += "<a href = \"" + BaseURL() + "/Combat\">Combat</a><br>";
            ret += "<a href = \"" + BaseURL() + "/Data\">Send Data</a><br>";
            ret += EndBit();
            return ret;
        }
        public static string WeaponsMenu()
        {
            string ret = StandardStyle();
            foreach(String str in Utilities.GetWeaponNames())
            {
                ret += "<a href = \"" + BaseURL() + "/Weapons/" + str + "\">" + str + "</a><br>";
            }
            
            ret += EndBit();
            return ret;
        }

        public static string CharacterMenu()
        {
            string ret = StandardStyle();
            foreach (String str in Utilities.GetCharacterNames())
            {
                ret += "<a href = \"" + BaseURL() + "/Characters/" + str + "\">" + str + "</a><br>";
            }

            ret += EndBit();
            return ret;
        }


        public static string CombatMenu()
        {
            string ret = StandardStyle();
            foreach (Character c in CombatHolder._inCombatChars)
            {
                ret += "<a href = \"" + BaseURL() + "/Combat/" + c.CombatStuff.CombatName + "\">" + c.CombatStuff.CombatName + "</a><br>";
            }

            ret += EndBit();
            return ret;
        }

        public static string WeaponDisplay(Weapon w)
        {
            string ret = StandardStyle();
            ret += w.ItemName + "<br>\n";
            ret += w.Description + "<br>\n";
            foreach (Utilities.DamageType dt in w.DamageTypes.Keys)
            {
                ret += dt.ToString() + " " + w.DamageTypes[dt] + "<br>\n";
            }
            ret += EndBit();
            return ret;
        }

        public static string ItemDisplay(Item i)
        {
            string ret = StandardStyle();

            ret += "<p style=\"white-space: pre-line;\">\n";
            if (i.IsIdentified)
            {
                ret += i.ItemName + "<br>\n";
            }
            ret += i.UnidentifiedDescription + "<br>\n";
            ret += "Weight: " + i.Weight + "<br>\n";
            if (i.IsIdentified)
            {
                ret += i.Description + "<br>\n";

                ret += "<br>\n";
                ret += "Enchantments:<br>\n";
                foreach (EnchantmentLogic.IfElseLogic iel in i.Enchantments.Keys)
                {
                    ret += iel.Name + "<br>\n";
                }

                ret += "<br>\n";
                ret += "Effects:<br>\n";
                foreach (Effect ef in i.ItemEffects)
                {
                    ret += ef.getDisplayString() + "<br>\n";
                }

                if (i.GetType() == typeof(Armor))
                {
                    ret += "<br>\n";
                    ret += "Covered Areas:<br>\n";
                    foreach (Utilities.BodyParts bp in ((Armor)i).CoveredAreas)
                    {
                        ret += bp.ToString() + "<br>\n";
                    }
                    ret += "<br>\n";
                    ret += "Damage Resistance:<br>\n";
                    foreach (Utilities.DamageType dt in ((Armor)i).DamageResistanceTypes.Keys)
                    {
                        ret += dt.ToString() + ": " + ((Armor)i).DamageResistanceTypes[dt] + "<br>\n";
                    }
                    ret += "<br>\n";
                    ret += "Damage Reduction:<br>\n";
                    foreach (Utilities.DamageType dt in ((Armor)i).DamageReductionTypes.Keys)
                    {
                        ret += dt.ToString() + ": " + ((Armor)i).DamageReductionTypes[dt] + "<br>\n";
                    }
                }
                if (i.GetType() == typeof(Weapon))
                {
                    ret += "<br>\n";
                    ret += "Damage Types:<br>\n";
                    foreach (Utilities.DamageType dt in ((Weapon)i).DamageTypes.Keys)
                    {
                        ret += dt.ToString() + ": " + ((Weapon)i).DamageTypes[dt] + "<br>\n";
                    }
                }
                if (i.GetType() == typeof(Shield))
                {
                    ret += "<br>\n";
                    ret += "Cover Amount:" + ((Shield)i).Coverage + "<br>\n";
                }


            }
            ret += "</p>";
            ret += EndBit();
            return ret;
        }

        public static string CombatTerminalPage(Character c)
        {
            return BaseURL() + "/Combat/" + c.CombatStuff.CombatName;
        }
        public static string ItemBar(Item I, string ButtonOneName, string ButtonTwoName)
        {
            string ret = "<div class=\"singleRow\">\n";

            string displayname = I.ToString();
            if (!I.IsIdentified && I.UnidentifiedDescription != null && I.UnidentifiedDescription != "")
            {
                displayname = I.UnidentifiedDescription.Split('\n')[0] + " (" + I.Count + ")";
            }
            ret += "<div class=\"leftbox\">" + displayname + "</div>\n";
            ret += "<input type = \"submit\" name=\"" + I.ItemName + "\" value=\"" + ButtonOneName + "\" />\n";
            if (ButtonTwoName != "")
            {
                ret += "<input type = \"submit\" name=\"" + I.ItemName + "\" value=\"" + ButtonTwoName + "\" />\n";
            }
            ret += "<input type = \"submit\" name=\"" + I.ItemName + "\" value=\"inspect\" />\n";
            ret += "</div>\n";
            return ret;
        }
        public static string InventoryTerminal(Character c)
        {
            var doc = new HtmlDocument();
            doc.Load("HTMLPages\\InventoryTerminal.html");
            doc.GetElementbyId("menuform").Attributes["action"].Value = BaseURL() + "/Combat/" + c.CombatStuff.CombatName;

            foreach (Item i in c.Inventory) {
                if (i.IsEquipped)
                {
                    doc.GetElementbyId("equipped").InnerHtml += ItemBar(i, "unequip", "drop");
                }
                else
                {
                    if(i.Use == Item.ItemUse.Equipable)
                    {
                        doc.GetElementbyId("unequipped").InnerHtml += ItemBar(i, "equip", "drop");
                    }
                    else if (i.Use == Item.ItemUse.Consumable)
                    {
                        doc.GetElementbyId("unequipped").InnerHtml += ItemBar(i, "consume", "drop");
                    }
                    else
                    {
                        doc.GetElementbyId("unequipped").InnerHtml += ItemBar(i, "drop", "");
                    }

                }
            }
            foreach(Item i in CombatHolder._theGround)
            {
                doc.GetElementbyId("ground").InnerHtml += ItemBar(i, "pick up", "");
            }
            
            return doc.DocumentNode.OuterHtml;
        }

        public static string InPipe()
        {
            var doc = new HtmlDocument();
            doc.Load("HTMLPages\\InPipe.html");
            return doc.DocumentNode.OuterHtml;
        }

        public static string CombatTerminal(Character c)
        {
            var doc = new HtmlDocument();
            doc.Load("HTMLPages\\CombatTerminal.html");
            
            doc.GetElementbyId("menuform").Attributes["action"].Value = BaseURL();
            doc.GetElementbyId("inventoryform").Attributes["action"].Value = BaseURL() + "/Combat/" + c.CombatStuff.CombatName + "/Inventory";
            doc.GetElementbyId("combatform").Attributes["action"].Value = CombatTerminalPage(c);
            doc.GetElementbyId("CharacterName").InnerHtml = c.Name;
            doc.GetElementbyId("str").InnerHtml = c.Statistics.Strength.ToString();
            doc.GetElementbyId("dex").InnerHtml = c.Statistics.Dexterity.ToString();
            doc.GetElementbyId("con").InnerHtml = c.Statistics.Constitution.ToString();
            doc.GetElementbyId("int").InnerHtml = c.Statistics.Intelligence.ToString();
            doc.GetElementbyId("wis").InnerHtml = c.Statistics.Wisdom.ToString();
            doc.GetElementbyId("cha").InnerHtml = c.Statistics.Charisma.ToString();
            doc.GetElementbyId("hp").InnerHtml = ((int)(c.HitPoints + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health))).ToString();
            doc.GetElementbyId("stamina").InnerHtml = ((int)c.Stamina).ToString();
            doc.GetElementbyId("regen").InnerHtml = EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Regeneration).ToString();
            doc.GetElementbyId("exhaustion").InnerHtml = (Math.Round(1.0 / CombatScripts.GetStaminaFactor(c), 2)).ToString();
            doc.GetElementbyId("obmod").InnerHtml = (EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.OB)).ToString();
            doc.GetElementbyId("dbmod").InnerHtml = (EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.DB)).ToString();
            doc.GetElementbyId("focus").InnerHtml = (EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Focus)).ToString();
            doc.GetElementbyId("weightfactor").InnerHtml = (Math.Round(CombatScripts.GetWeightFactor(c), 2)).ToString();
            doc.GetElementbyId("reflex").InnerHtml = (Math.Round(CombatScripts.CalculateReflex(c, 0), 2)).ToString();
            doc.GetElementbyId("offbonus").Attributes["value"].Value = c.CombatStuff.CombatOB.ToString();
            doc.GetElementbyId("defbonus").Attributes["value"].Value = c.CombatStuff.CombatDB.ToString();
            doc.GetElementbyId("roll").Attributes["value"].Value = c.CombatStuff.CombatRoll.ToString();
            doc.GetElementbyId("spellpower").Attributes["value"].Value = c.CombatStuff.SpellsToCast[0].spellPower.ToString();
            foreach (Character target in CombatHolder._inCombatChars)
            {
                if(target.CombatStuff.CombatName == c.LastAttackTargetSelected)
                {
                    doc.GetElementbyId("targets").InnerHtml += "\r\n<option selected>" + target.CombatStuff.CombatName;
                }
                else
                {
                    doc.GetElementbyId("targets").InnerHtml += "\r\n<option>" + target.CombatStuff.CombatName;
                }

                if (target.CombatStuff.CombatName == c.LastSpellTargetSelected)
                {
                    doc.GetElementbyId("spelltargets").InnerHtml += "\r\n<option selected>" + target.CombatStuff.CombatName;
                }
                else
                {
                    doc.GetElementbyId("spelltargets").InnerHtml += "\r\n<option>" + target.CombatStuff.CombatName;
                }
                
            }
            foreach (Weapon weap in c.Weapons)
            {
                if(weap == c.CombatStuff.CombatWeapon)
                {
                    doc.GetElementbyId("weapons").InnerHtml += "\r\n<option selected>" + weap.ItemName;
                }
                else
                {
                    doc.GetElementbyId("weapons").InnerHtml += "\r\n<option>" + weap.ItemName;
                }
            }

            foreach (Shield sh in c.Shields)
            {
                if (sh == c.CombatStuff.CombatShield)
                {
                    doc.GetElementbyId("shields").InnerHtml += "\r\n<option selected>" + sh.ItemName;
                }
                else
                {
                    doc.GetElementbyId("shields").InnerHtml += "\r\n<option>" + sh.ItemName;
                }
            }

            foreach (Spell sp in c.Spells)
            {
                if (sp == c.CombatStuff.SpellsToCast[0].spell)
                {
                    doc.GetElementbyId("spells").InnerHtml += "\r\n<option selected>" + sp.SpellName;
                }
                else
                {
                    doc.GetElementbyId("spells").InnerHtml += "\r\n<option>" + sp.SpellName;
                }
                
            }

            if (c.CombatStuff.SpellsToCast[0].targets.Any())
            {
                doc.GetElementbyId("attacks").InnerHtml += "\r\n<p>Casting " + c.CombatStuff.SpellsToCast[0].spell.SpellName + " at:";
                foreach(Character target in c.CombatStuff.SpellsToCast[0].targets)
                {
                    doc.GetElementbyId("attacks").InnerHtml += target.CombatStuff.CombatName + "<br>";
                }
                doc.GetElementbyId("attacks").InnerHtml += " </ p > ";
            }
            foreach (Character attacking in CombatHolder._makingAttackChars)
            {
                doc.GetElementbyId("attacks").InnerHtml += "\r\n<p>" + attacking.CombatStuff.CombatName + " is attacking:";
                foreach (Character beingattacked in attacking.CombatStuff.targets)
                {
                    doc.GetElementbyId("attacks").InnerHtml += beingattacked.CombatStuff.CombatName + "<br>";
                }
                doc.GetElementbyId("attacks").InnerHtml += "with " + attacking.CombatStuff.CombatWeapon.ItemName + " </ p > ";
            }
            doc.GetElementbyId("attackresults").InnerHtml += " </ p > ";
            foreach (List<String> attack in c.CombatStuff.attackResultsForDisplay)
            {
                doc.GetElementbyId("attackresults").InnerHtml += "\r\n<p>ATTACK<br>";
                foreach (string str in attack)
                {
                    if(str.Length > 7 && str.Substring(0,7) == "http://")
                    {
                        doc.GetElementbyId("attackresults").InnerHtml += "<a href=\"" + str + "\">Display Attack</a>";
                    }
                    else
                    {
                        doc.GetElementbyId("attackresults").InnerHtml += str + "<br>";
                    }
                }
                doc.GetElementbyId("attackresults").InnerHtml += " </ p > ";
            }
            foreach (List<String> defence in c.CombatStuff.defendResultsForDisplay)
            {
                doc.GetElementbyId("attackresults").InnerHtml += "\r\n<p>DEFENCE<br>";
                foreach (string str in defence)
                {
                    if (str.Length > 7 && str.Substring(0, 7) == "http://")
                    {
                        doc.GetElementbyId("attackresults").InnerHtml += "<a href=\"" + str + "\">Display Defense</a>";
                    }
                    else
                    {
                        doc.GetElementbyId("attackresults").InnerHtml += str + "<br>";
                    }
                }
                doc.GetElementbyId("attackresults").InnerHtml += " </ p > ";
            }
            foreach (SpellToCast castSpell in c.CombatStuff.spellResultsForDisplay)
            {
                doc.GetElementbyId("attackresults").InnerHtml += "\r\n<p>SPELL<br>";
                foreach (Effect eff in castSpell.effectResult.Keys)
                {
                    doc.GetElementbyId("attackresults").InnerHtml += eff.getDisplayString() + "<br>";
                }
                doc.GetElementbyId("attackresults").InnerHtml += " </ p > ";
            }
            String lastAttackExp = "\r\n<p style =\"white-space: pre-line;\">\nLast Attack Explanation\n";
            lastAttackExp += c.CombatStuff.AttackNotes.DisplayResults() + "<br></p>";
            doc.GetElementbyId("attackresults").InnerHtml += lastAttackExp;

            String lastDefenceExp = "\r\n<p style =\"white-space: pre-line;\">\nLast Defence Explanation\n";
            lastDefenceExp += c.CombatStuff.DefendNotes.DisplayResults() + "<br></p>";
            doc.GetElementbyId("attackresults").InnerHtml += lastDefenceExp;

            //nodename.Attributes["value"].Value = c.Name;
            // < option > thief
            var bleh =  doc.DocumentNode.OuterHtml;
            return bleh;
            /*
            ret += wItemName + "<br>\n";
            ret += w.Description + "<br>\n";
            foreach (Utilities.DamageType dt in w.DamageTypes.Keys)
            {
                ret += dt.ToString() + " " + w.DamageTypes[dt] + "<br>\n";
            }
            ret += EndBit();*/
        }

        private static string AttackGridKey()
        {
            List<List<string>> buildKey = new List<List<string>>();
            List<String> miss = new List<string>() { "<div style=\"background-color: #000000; \">  </div>", "<div style=\"width: 60px\"> Miss </div>" };
            buildKey.Add(miss);
            List<String> block = new List<string>() { "<div style=\"background-color: #646464; \">  </div>", "<div style=\"width: 60px\"> Block </div>" };
            buildKey.Add(block);
            List<String> parry = new List<string>() { "<div style=\"background-color: #b8b8b8; \">  </div>", "<div style=\"width: 60px\"> Parry </div>" };
            buildKey.Add(parry);
            List<String> none = new List<string>() { "<div style=\"background-color: #E17D00; \">  </div>", "<div style=\"width: 60px\"> 0-1 </div>" };
            buildKey.Add(none);
            List<String> one = new List<string>() { "<div style=\"background-color: #C83264; \">  </div>", "<div style=\"width: 60px\"> 1-2 </div>" };
            buildKey.Add(one);
            List<String> two = new List<string>() { "<div style=\"background-color: #64007D; \">  </div>", "<div style=\"width: 60px\"> 2-3 </div>" };
            buildKey.Add(two);
            List<String> three = new List<string>() { "<div style=\"background-color: #3200C8; \">  </div>", "<div style=\"width: 60px\"> 3-4 </div>" };
            buildKey.Add(three);
            List<String> four = new List<string>() { "<div style=\"background-color: #0064FA; \">  </div>", "<div style=\"width: 60px\"> 4-5 </div>" };
            buildKey.Add(four);
            List<String> five = new List<string>() { "<div style=\"background-color: #00C8C8; \">  </div>", "<div style=\"width: 60px\"> 5-10 </div>" };
            buildKey.Add(five);
            List<String> six = new List<string>() { "<div style=\"background-color: #00C800; \">  </div>", "<div style=\"width: 60px\"> 10-15 </div>" };
            buildKey.Add(six);
            List<String> seven = new List<string>() { "<div style=\"background-color: #C8C800; \">  </div>", "<div style=\"width: 60px\"> 15-20 </div>" };
            buildKey.Add(seven);
            List<String> eight = new List<string>() { "<div style=\"background-color: #C80000; \">  </div>", "<div style=\"width: 60px\"> 20-50 </div>" };
            buildKey.Add(eight);
            List<String> nine = new List<string>() { "<div style=\"background-color: #000000; \">  </div>", "<div style=\"width: 60px\"> 50-100 </div>" };
            buildKey.Add(nine);
            return Utilities.turn2DArrayIntoHTMLTable(buildKey);
        }

        public static string AttackGrid(string uuid)
        {
            List<List<string>> toTurnToHTML = new List<List<string>>();
            string ret = StandardStyle();
            if (AfterCrits.IndexedAttacks.ContainsKey(uuid))
            {
                if(AfterCrits.IndexedAttacks[uuid].Item2 != null)
                {
                    int rowcount = 0;
                    foreach(List<Double> row in AfterCrits.IndexedAttacks[uuid].Item2)
                    {
                        rowcount++;
                        List<String> tablerow = new List<string>();
                        tablerow.Add("<div style=\"background-color: #ffffff; \">" + (AfterCrits.IndexedAttacks[uuid].Item1.defendRoll - AfterCrits.IndexedAttacks[uuid].Item2.Count/2 + rowcount - 1).ToString() + "</div>");
                        foreach(double d in row)
                        {
                            var colors = Utilities.translateNumberToColorValues(d);
                            string red = colors.Item1.ToString("X");
                            if(red.Length == 1)
                            {
                                red = "0" + red;
                            }
                            string green = colors.Item2.ToString("X");
                            if (green.Length == 1)
                            {
                                green = "0" + green;
                            }
                            string blue = colors.Item3.ToString("X");
                            if (blue.Length == 1)
                            {
                                blue = "0" + blue;
                            }
                            String data = "<div style=\"background-color: #"+ red+green+blue +"; \">  </div>";
                            tablerow.Add(data);
                        }
                        toTurnToHTML.Add(tablerow);
                    }
                    toTurnToHTML[(toTurnToHTML.Count / 2)][(toTurnToHTML.Count / 2)+1] = toTurnToHTML[(toTurnToHTML.Count / 2)][(toTurnToHTML.Count / 2)+1].Replace("; \">  </div>", "; height: 21px; width: 21px; border: 3px solid #ff0000; \">  </div>");
                    List<String> enumeration = new List<string>();
                    for(int i = 0; i <= AfterCrits.IndexedAttacks[uuid].Item2.Count; i++)
                    {
                        enumeration.Add("<div style=\"background-color: #ffffff; \">" + (AfterCrits.IndexedAttacks[uuid].Item1.attackRoll - AfterCrits.IndexedAttacks[uuid].Item2.Count / 2 + i - 1).ToString() + "</div>");
                    }
                    toTurnToHTML.Add(enumeration);
                    toTurnToHTML.Reverse();
                    ret += Utilities.turn2DArrayIntoHTMLTable(toTurnToHTML);
                    return ret + AttackGridKey() + EndBit();
                }

            }
            return ret + "Grid Not Created (Yet?)" + EndBit();
        }

        public static string StatRow(int val, string stat)
        {
            return "<tr>\n<td>" + stat + "</td>\n<td>" + val + "</td>\n<td>" + Math.Floor((val - 10.0) / 2) + "</td>\n<td>" + Math.Ceiling((28.0 - val) / 6) + "</td>\n</tr>\n";
        }

        public static string CharacterSheet(Character c)
        {
            string ret = StandardStyle();
            ret += "<table>\n<tr>\n<td>Stat</td>\n<td>Value</td>\n<td>Mod</td>\n<td>Cost</td>\n</tr>\n";
            ret += StatRow(c.Statistics.Strength, "Strength");
            ret += StatRow(c.Statistics.Dexterity, "Dexterity");
            ret += StatRow(c.Statistics.Constitution, "Constitution");
            ret += StatRow(c.Statistics.Intelligence, "Intelligence");
            ret += StatRow(c.Statistics.Wisdom, "Wisdom");
            ret += StatRow(c.Statistics.Charisma, "Charisma");
            ret += "</table>\n";


            ret += "Creature Types:<br>";
            foreach (Utilities.CreatureType ct in c.CreatureTypes)
            {
                ret += ct.ToString() + "<br>";
            }
            ret += "<br>Armor:<br>";
            foreach(Armor arm in c.Armor)
            {
                ret += arm.ItemName + "<br>";
            }
            ret += "<br>Weapons:<br>";
            foreach (Weapon w in c.Weapons)
            {
                ret += w.ItemName + "<br>";
            }
            ret += "<br>Shields:<br>";
            foreach (Shield s in c.Shields)
            {
                ret += s.ItemName + "<br>";
            }
            ret += "<br>Other Items:<br>";
            foreach (Item i in c.Items)
            {
                ret += i.ItemName + "<br>";
            }
            ret += "<br>Bag:<br>";
            foreach (Item i in c.Inventory)
            {
                if (!i.IsEquipped)
                {
                    ret += i.ToString() + "<br>";
                }
            }
            ret += "<br>Spells:<br>";
            foreach (Spell s in c.Spells)
            {
                ret += s.SpellName + "<br>";
            }
            ret += "<br>Enchantments:<br>";
            foreach (EnchantmentLogic.IfElseLogic iel in c.Enchantments.Keys)
            {
                ret += iel.Name + "<br>";
            }

            ret += EndBit();
            return ret;
        }

    }
}
