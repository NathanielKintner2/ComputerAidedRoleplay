using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public static class Utilities
    {
        #region enums
        public enum DamageType
        {
            Slash,
            Pierce,
            Crush,
            Heat,
            Cold,
            Shock,
            Mental,
            Impact,
            Soul
        }
        public enum AttackResultType
        {
            Miss,
            Block,
            Parry,
            Hit
        }
        public enum CreatureType
        {
            Human,
            Elf,
            Dwarf,
            Undead,
            Demon,
            Natural,
            Mechanical,
            Elemental,
            Spirit,
            Lycanthrope
        }
        public enum ItemType
        {
            Gloves,
            Boots,
            Belt,
            Cape,
            Hood,
            Helmet,
            Cloak,
            Weapon,
            Charm,
            Talisman,
            Amulet,
            Ring,
            Bracelet,
            Necklace,
            Jewel,
            Circlet,
            LightArmor,
            HeavyArmor,
            Potion,
            Currency,
            Tool
        }
        public enum WeaponType
        {
            Melee,
            Ranged,
            Physical,
            Magical,
            Spell,
            FencingSword,
            LightBlade,
            HeavyBlade,
            LightAxe,
            HeavyAxe,
            Spear,
            Polearm,
            Mace,
            Staff,
            Flail,
            ThrownBlade,
            ThrownAxe,
            ThrownSpear,
            Bow,
            Crossbow,
            Claw,
            Grapple,
            Brawl,
            ElementalSpell,
            MentalSpell,
            KineticSpell,
            SpiritSpell,
            Curse,
            Innate,
            Uncategorized
        }
        public enum BodyParts
        {
            RightFoot,
            LeftFoot,
            RightHand,
            LeftHand,
            RightCalf,
            LeftCalf,
            RightArm,
            LeftArm,
            RightThigh,
            LeftThigh,
            RightShoulder,
            LeftShoulder,
            Gut,
            Groin,
            Chest,
            Head,
            Neck
        }

        public static void FindCritLocation(AttackOutcome inputAttack)
        {
            inputAttack.HitLocation = (BodyParts)Math.Min(
                                                addedRandomness.Next(
                                                    Math.Max(0,
                                                        Math.Min(
                                                            (int)((inputAttack.HitCaliber - 2) / 2),
                                                            Enum.GetNames(typeof(BodyParts)).Length)),
                                                        Math.Min(
                                                            8 + (int)(inputAttack.HitCaliber / 2),
                                                            Enum.GetNames(typeof(BodyParts)).Length)),
                                                    Enum.GetNames(typeof(BodyParts)).Length - 1);
        }

        public enum EffectableTypes
        {
            Character,
            Weapon,
            Armor,
            Shield,
            Item
        }
        #endregion
        #region globals
        public static string myFolder = @"C:\Users\GuysAdmin\Documents\GitHub\CAR\FromScratch\Second Attempt\bin\Debug\Data\Loot";
        //create server with auto assigned port
        public static SimpleServer myServer = new SimpleServer(myFolder);
        public static bool ServerWasStarted = false;

        public static Random addedRandomness = new Random();
        #endregion
        #region getnames
        /// <summary>
        /// Returns list of file name from Data\\Characters Directory
        /// </summary>
        /// <returns></returns>
        /// 
        public static List<string> GetCharacterNames()
        {
            List<string> lstCharacterNames = new List<string>();
            DirectoryInfo diCharacters = new DirectoryInfo("Data\\Characters");
            if (!diCharacters.Exists)
            {
                MessageBox.Show("Error, no character data found.");
                return lstCharacterNames;
            }
            foreach (FileInfo fi in diCharacters.EnumerateFiles())
            {
                lstCharacterNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstCharacterNames.Count; i++)
            {
                String st = lstCharacterNames.ElementAt(i);
                lstCharacterNames[i] = st.Substring(0, st.Length - 4);
            }
            lstCharacterNames.Sort();
            return lstCharacterNames;
        }
        public static List<string> GetSpellNames()
        {
            List<string> lstSpellNames = new List<string>();
            DirectoryInfo diCharacters = new DirectoryInfo("Data\\Spells");
            if (!diCharacters.Exists)
            {
                MessageBox.Show("Error, no character data found.");
                return lstSpellNames;
            }
            foreach (FileInfo fi in diCharacters.EnumerateFiles())
            {
                lstSpellNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstSpellNames.Count; i++)
            {
                String st = lstSpellNames.ElementAt(i);
                lstSpellNames[i] = st.Substring(0, st.Length - 4);
            }
            lstSpellNames.Sort();
            return lstSpellNames;
        }

        public static List<string> GetWeaponNames()
        {
            List<string> lstWeaponNames = new List<string>();
            DirectoryInfo diWeapons = new DirectoryInfo("Data\\Weapons");
            if (!diWeapons.Exists)
            {
                MessageBox.Show("Error, no Weapon data found.");
                return lstWeaponNames;
            }
            foreach (FileInfo fi in diWeapons.EnumerateFiles())
            {
                lstWeaponNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstWeaponNames.Count; i++)
            {
                String st = lstWeaponNames.ElementAt(i);
                lstWeaponNames[i] = st.Substring(0, st.Length - 4);
            }
            lstWeaponNames.Sort();
            return lstWeaponNames;
        }
        public static List<string> GetArmorNames()
        {
            List<string> lstArmorNames = new List<string>();
            DirectoryInfo diArmor = new DirectoryInfo("Data\\Armor");
            if (!diArmor.Exists)
            {
                MessageBox.Show("Error, no Armor data found.");
                return lstArmorNames;
            }
            foreach (FileInfo fi in diArmor.EnumerateFiles())
            {
                lstArmorNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstArmorNames.Count; i++)
            {
                String st = lstArmorNames.ElementAt(i);
                lstArmorNames[i] = st.Substring(0, st.Length - 4);
            }
            lstArmorNames.Sort();
            return lstArmorNames;
        }
        public static List<string> GetShieldNames()
        {
            List<string> lstShieldNames = new List<string>();
            DirectoryInfo diShields = new DirectoryInfo("Data\\Shields");
            if (!diShields.Exists)
            {
                MessageBox.Show("Error, no Shield data found.");
                return lstShieldNames;
            }
            foreach (FileInfo fi in diShields.EnumerateFiles())
            {
                lstShieldNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstShieldNames.Count; i++)
            {
                String st = lstShieldNames.ElementAt(i);
                lstShieldNames[i] = st.Substring(0, st.Length - 4);
            }
            lstShieldNames.Sort();
            return lstShieldNames;
        }

        public static List<string> GetEnchantmentNames()
        {
            List<string> lstEnchantmentNames = new List<string>();
            DirectoryInfo diEnchantments = new DirectoryInfo("Data\\Enchantments");
            if (!diEnchantments.Exists)
            {
                MessageBox.Show("Error, no Enchantment data found.");
                return lstEnchantmentNames;
            }
            foreach (FileInfo fi in diEnchantments.EnumerateFiles())
            {
                lstEnchantmentNames.Add(fi.Name);
            }
            //chops off .xml that causes naming headaches later
            for (int i = 0; i < lstEnchantmentNames.Count; i++)
            {
                String st = lstEnchantmentNames.ElementAt(i);
                lstEnchantmentNames[i] = st.Substring(0, st.Length - 4);
            }
            lstEnchantmentNames.Sort();
            return lstEnchantmentNames;
        }

        public static List<string> GetLootNames()
        {
            List<string> lstLootNames = new List<string>();
            DirectoryInfo diLootNames = new DirectoryInfo("Data\\Loot");
            if (!diLootNames.Exists)
            {
                MessageBox.Show("Error, no Loot data found.");
                return lstLootNames;
            }
            foreach (FileInfo fi in diLootNames.EnumerateFiles())
            {
                lstLootNames.Add(fi.Name);
            }
            //chops off .txt that causes naming headaches later
            for (int i = 0; i < lstLootNames.Count; i++)
            {
                String st = lstLootNames.ElementAt(i);
                lstLootNames[i] = st.Substring(0, st.Length - 4);
            }
            lstLootNames.Sort();
            return lstLootNames;
        }
        public static List<string> GetItemNames()
        {
            List<string> lstItemNames = new List<string>();
            DirectoryInfo diItems = new DirectoryInfo("Data\\Items");
            if (!diItems.Exists)
            {
                MessageBox.Show("Error, no Loot data found.");
                return lstItemNames;
            }
            foreach (FileInfo fi in diItems.EnumerateFiles())
            {
                lstItemNames.Add(fi.Name);
            }
            //chops off .txt that causes naming headaches later
            for (int i = 0; i < lstItemNames.Count; i++)
            {
                String st = lstItemNames.ElementAt(i);
                lstItemNames[i] = st.Substring(0, st.Length - 4);
            }
            lstItemNames.Sort();
            return lstItemNames;
        }
        #endregion
        #region inventorymanagement
        public static void RefreshInventoryFromDB(Character currentChar)
        {
            List<Item> refreshInventory = new List<Item>();
            foreach (Item it in currentChar.Inventory)
            {
                Item refresh = new Item();
                if (it.GetType() == typeof(Weapon))
                {
                    refresh = GetWeaponByName(((Weapon)it).ItemName);
                }
                else if (it.GetType() == typeof(Shield))
                {
                    refresh = GetShieldByName(((Shield)it).ItemName);
                }
                else if (it.GetType() == typeof(Armor))
                {
                    refresh = GetArmorByName(((Armor)it).ItemName);
                }
                else
                {
                    refresh = GetItemByName(it.ItemName);
                }

                refresh.IsEquipped = it.IsEquipped;
                refresh.Count = it.Count;
                refresh.UnidentifiedDescription = it.UnidentifiedDescription;
                refresh.IsIdentified = it.IsIdentified;
                refreshInventory.Add(refresh);
            }
            currentChar.Inventory = refreshInventory;
        }

        public static void FillEquipListsFromInventory(Character currentChar)
        {
            currentChar.Weapons = new List<Weapon>();
            currentChar.Armor = new List<Armor>();
            currentChar.Shields = new List<Shield>();
            currentChar.Items = new List<Item>();
            foreach (Item it in currentChar.Inventory)
            {
                if (it.IsEquipped)
                {
                    foreach(IfElseLogic iel in it.Enchantments.Keys)
                    {
                        iel.CharParent = currentChar; 
                    }
                    if (it.GetType() == typeof(Weapon))
                    {
                        currentChar.Weapons.Add((Weapon)it);
                    }
                    else if (it.GetType() == typeof(Shield))
                    {
                        currentChar.Shields.Add((Shield)it);
                    }
                    else if (it.GetType() == typeof(Armor))
                    {
                        currentChar.Armor.Add((Armor)it);
                    }
                    else
                    {
                        currentChar.Items.Add(it);
                    }
                }
            }
            if (!currentChar.Shields.Any())
            {
                currentChar.Shields.Add(new Shield());
            }
            if (!currentChar.Weapons.Any())
            {
                currentChar.Weapons.Add(new Weapon());
            }
            if(currentChar.CombatStuff == null)
            {
                currentChar.CombatStuff = new CombatItems(currentChar);
            }
            if (currentChar.CombatStuff.CombatWeapon != null && currentChar.Weapons.Any(A => A.ItemName == currentChar.CombatStuff.CombatWeapon.ItemName))
            {
                currentChar.CombatStuff.CombatWeapon = currentChar.Weapons.Find(A => A.ItemName == currentChar.CombatStuff.CombatWeapon.ItemName);
            }
            else
            {
                currentChar.CombatStuff.CombatWeapon = new Weapon();
            }
            if (currentChar.CombatStuff.CombatShield != null && currentChar.Shields.Any(A => A.ItemName == currentChar.CombatStuff.CombatShield.ItemName))
            {
                currentChar.CombatStuff.CombatShield = currentChar.Shields.Find(A => A.ItemName == currentChar.CombatStuff.CombatShield.ItemName);
            }
            else
            {
                currentChar.CombatStuff.CombatShield = new Shield();
            }
        }

        public static void RemoveItemFromInventory(Item i, List<Item> Inventory)
        {
            if(i == null)
            {
                return;
            }
            int count = i.Count;
            Item itemToRemove = new Item();
            foreach (Item removalTarget in Inventory)
            {
                if (removalTarget.GetType() == i.GetType() && removalTarget.ItemName == i.ItemName)
                {
                    removalTarget.Count -= count;
                    if (removalTarget.Count < 1)
                    {
                        itemToRemove = removalTarget;
                    }
                    break;
                }
            }
            Inventory.Remove(itemToRemove);
        }

        public static void AddItemToInventory(Item i, List<Item> Inventory)
        {
            if (i == null || i.Count == 0)
            {
                return;
            }
            if (i.Use == Item.ItemUse.Equipable)
            {
                Inventory.Add(i);
                return;
            }
            foreach (Item additionTarget in Inventory)
            {
                if (additionTarget.GetType() == i.GetType() && additionTarget.ItemName == i.ItemName)
                {
                    additionTarget.Count += i.Count;
                    return;
                }
            }
            Inventory.Add(i);
        }
        #endregion
        #region getbyname
        public static Character GetCharByName(string CharName)
        {
            if (!GetCharacterNames().Contains(CharName)) {
                return new Character();
            }
            StreamReader sr = new StreamReader("Data\\Characters\\" + CharName + ".xml");
            string currentCharString = sr.ReadToEnd();
            Character currentChar = Character.Deserialize(currentCharString);
            sr.Close();

            if (currentChar.Inventory == null)
            {
                currentChar.Inventory = new List<Item>();
            }
            if (currentChar.Items == null)
            {
                currentChar.Items = new List<Item>();
            }
            if (currentChar.Weapons == null)
            {
                currentChar.Weapons = new List<Weapon>();
            }
            if (currentChar.Shields == null)
            {
                currentChar.Shields = new List<Shield>();
            }
            if (currentChar.Armor == null)
            {
                currentChar.Armor = new List<Armor>();
            }
            RefreshInventoryFromDB(currentChar);
            FillEquipListsFromInventory(currentChar);
            if (currentChar.Effects == null)
            {
                currentChar.Effects = new List<Effect>();
            }
            if (currentChar.TemporaryEffects == null)
            {
                currentChar.TemporaryEffects = new List<Effect>();
            }
            if (currentChar.CharTypeTag == null) {
                currentChar.CharTypeTag = "";
            }
            if (currentChar.CombatStuff == null) {
                currentChar.CombatStuff = new CombatItems(currentChar);
            }
            if (currentChar.CombatStuff.DefendNotes == null)
            {
                currentChar.CombatStuff.DefendNotes = new CombatNotes();
            }
            if (currentChar.CombatStuff.AttackNotes == null)
            {
                currentChar.CombatStuff.AttackNotes = new CombatNotes();
            }
            if (currentChar.CombatStuff.attackResultsForDisplay == null)
            {
                currentChar.CombatStuff.attackResultsForDisplay = new List<List<string>>();
            }
            if (currentChar.CombatStuff.defendResultsForDisplay == null)
            {
                currentChar.CombatStuff.defendResultsForDisplay = new List<List<string>>();
            }
            if (currentChar.CombatStuff.spellResultsForDisplay== null)
            {
                currentChar.CombatStuff.spellResultsForDisplay = new List<SpellToCast>();
            }
            if (currentChar.Spells == null)
            {
                currentChar.Spells = new List<Spell>();
            }
            if (currentChar.Enchantments == null)
            {
                currentChar.Enchantments = new Dictionary<IfElseLogic, Dictionary<string, Object>>();
            }
            if (currentChar.CreatureTypes == null)
            {
                currentChar.CreatureTypes = new List<CreatureType>();
            }
            if (currentChar.EnchantmentMessagesForGoogle == null)
            {
                currentChar.EnchantmentMessagesForGoogle = new Dictionary<double, string>();
            }
            if (currentChar.CombatStuff.SpellsToCast == null)
            {
                currentChar.CombatStuff.SpellsToCast = new SpellToCast[3];
            }
            List<Spell> refreshSpells = new List<Spell>();
            foreach (Spell s in currentChar.Spells) {
                refreshSpells.Add(GetSpellByName(s.SpellName));
            }
            currentChar.Spells = refreshSpells;
            Dictionary<IfElseLogic, Dictionary<String, Object>> refreshEnchantments = new Dictionary<IfElseLogic, Dictionary<string, Object>>();
            foreach (IfElseLogic iel in currentChar.Enchantments.Keys)
            {
                IfElseLogic ielr = GetEnchantmentByName(iel.name);
                refreshEnchantments.Add(ielr, currentChar.Enchantments[iel]);
                ielr.CharParent = currentChar;
            }
            currentChar.Enchantments = refreshEnchantments;
            SetEnchantmentParams(currentChar.Enchantments);
            
            for (int i = 0; i < 3; i++)
            {
                if (currentChar.CombatStuff.SpellsToCast[i] == null)
                {
                    currentChar.CombatStuff.SpellsToCast[i] = new SpellToCast();
                }
                currentChar.CombatStuff.SpellsToCast[i].targets = new List<Character>();
            }
            

            return currentChar;
            
        }

        public static Character getCharacterFromXmlOrCombatHolderByString(string str)
        {
            Character ret = Utilities.GetCharByName(str);
            if (ret.Name != str)
            {
                if(CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName == str))
                {
                    ret = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == str);
                }
                else
                {
                    return ret;
                }
            }
            else
            {
                ret.Stamina = CombatScripts.GetBaseStamina(ret);
                ret.HitPoints = CombatScripts.GetBaseHealth(ret);
                if (ret.Weapons.Any())
                    ret.CombatStuff.CombatWeapon = ret.Weapons[0];
                if (ret.Shields.Any())
                    ret.CombatStuff.CombatShield = ret.Shields[0];
            }
            return ret;
        }

        public static Spell GetSpellByName(string SpellName)
        {
            if (!GetSpellNames().Contains(SpellName))
            {
                return new Spell();
            }
            StreamReader sr = new StreamReader("Data\\Spells\\" + SpellName + ".xml");
            string currentSpellString = sr.ReadToEnd();
            Spell currentSpell = Spell.Deserialize(currentSpellString);
            sr.Close();
            return currentSpell;
        }
        public static Weapon GetWeaponByName(string WeaponName)
        {
            if (WeaponName.Equals("")) {
                return new Weapon();
            }
            StreamReader sr = new StreamReader("Data\\Weapons\\" + WeaponName + ".xml");
            string currentWepString = sr.ReadToEnd();
            Weapon currentWep = (Weapon)Item.Deserialize(currentWepString, typeof(Weapon));
            sr.Close();
            if (currentWep.Enchantments == null)
            {
                currentWep.Enchantments = new Dictionary<IfElseLogic, Dictionary<String, Object>>();
            }
            if (currentWep.ItemEffects == null)
            {
                currentWep.ItemEffects = new List<Effect>();
            }
            if(currentWep.WeaponTypes == null)
            {
                currentWep.WeaponTypes = new List<WeaponType>();
            }
            Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>> refreshEnchantments = new Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>>();
            foreach (IfElseLogic iel in currentWep.Enchantments.Keys)
            {
                IfElseLogic ielr = GetEnchantmentByName(iel.name);
                refreshEnchantments.Add(ielr, currentWep.Enchantments[iel]);
            }
            currentWep.Enchantments = refreshEnchantments;
            SetEnchantmentParams(currentWep.Enchantments);
            return currentWep;
        }
        public static Armor GetArmorByName(string ArmorName)
        {
            if (ArmorName.Equals(""))
            {
                return new Armor();
            }
            StreamReader sr = new StreamReader("Data\\Armor\\" + ArmorName + ".xml");
            string currentArmorString = sr.ReadToEnd();
            sr.Close();
            Armor currentArmor = (Armor)Armor.Deserialize(currentArmorString, typeof(Armor));
            if(currentArmor.CoveredAreas == null)
            {
                currentArmor.CoveredAreas = new List<BodyParts>();
            }
            if(currentArmor.DamageReductionTypes == null)
            {
                currentArmor.DamageReductionTypes = new Dictionary<DamageType, double>();
            }
            if(currentArmor.DamageResistanceTypes == null)
            {
                currentArmor.DamageResistanceTypes = new Dictionary<DamageType, double>();
            }
            return currentArmor;
        }
        public static Shield GetShieldByName(string ShieldName)
        {
            if (ShieldName.Equals(""))
            {
                return new Shield();
            }
            StreamReader sr = new StreamReader("Data\\Shields\\" + ShieldName + ".xml");
            string currentShieldString = sr.ReadToEnd();
            Shield currentShield = (Shield)Shield.Deserialize(currentShieldString, typeof(Shield));
            sr.Close();
            return currentShield;
        }

        public static IfElseLogic GetEnchantmentByName(string EnchantmentName)
        {
            if (EnchantmentName.Equals(""))
            {
                return new IfElseLogic();
            }
            StreamReader sr = new StreamReader("Data\\Enchantments\\" + EnchantmentName + ".xml");
            string currentEnchantmentString = sr.ReadToEnd();
            IfElseLogic currentEnchantment = IfElseLogic.Deserialize(currentEnchantmentString);
            sr.Close();
            currentEnchantment.UpdateAfterSave();
            return currentEnchantment;
        }

        public static Item GetItemByName(string ItemName)
        {
            if (ItemName.Equals(""))
            {
                return new Item();
            }
            StreamReader sr = new StreamReader("Data\\Items\\" + ItemName + ".xml");
            string currentItemString = sr.ReadToEnd();
            Item currentItem = Item.Deserialize(currentItemString, typeof(Item));
            sr.Close();
            if(currentItem.Enchantments == null)
            {
                currentItem.Enchantments = new Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>>();
            }
            if (currentItem.ItemEffects == null)
            {
                currentItem.ItemEffects = new List<Effect>();
            }
            Dictionary<IfElseLogic, Dictionary<String, Object>> refreshEnchantments = new Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>>();
            foreach (IfElseLogic iel in currentItem.Enchantments.Keys)
            {
                IfElseLogic ielr = GetEnchantmentByName(iel.name);
                refreshEnchantments.Add(ielr, currentItem.Enchantments[iel]);
            }
            currentItem.Enchantments = refreshEnchantments;
            SetEnchantmentParams(currentItem.Enchantments);
            return currentItem;
        }
        #endregion
        #region save
        public static Character ShrinkCharacter(Character c)
        {
            Character SaveClone = Character.Deserialize(c.Serialize());

            List<Spell> compressSpells = new List<Spell>();
            foreach (Spell s in SaveClone.Spells)
            {
                compressSpells.Add(new Spell { SpellName = s.SpellName });
            }
            SaveClone.Spells = compressSpells;

            List<Item> compressInventory = new List<Item>();
            foreach (Item i in SaveClone.Inventory)
            {
                Item shrunkItem = (Item)Activator.CreateInstance(i.GetType());
                shrunkItem.ItemName = i.ItemName;
                shrunkItem.IsEquipped = i.IsEquipped;
                shrunkItem.Count = i.Count;
                shrunkItem.UnidentifiedDescription = i.UnidentifiedDescription;
                shrunkItem.IsIdentified = i.IsIdentified;
                compressInventory.Add(shrunkItem);
            }
            SaveClone.Inventory = compressInventory;

            Dictionary<IfElseLogic, Dictionary<string, object>> compressEnchantments = new Dictionary<IfElseLogic, Dictionary<string, object>>();
            foreach (IfElseLogic iel in SaveClone.Enchantments.Keys)
            {
                compressEnchantments.Add(new IfElseLogic() { name = iel.name }, SaveClone.Enchantments[iel]); 
            }
            SaveClone.Enchantments = compressEnchantments;

            return SaveClone;
        }
        public static void SaveCharacter(Character ToBeSaved)
        {            
            string newSerialize = ShrinkCharacter(ToBeSaved).Serialize();
            StreamWriter sw = new StreamWriter("Data\\Characters\\" + ToBeSaved.Name + ".xml");
            sw.Write(newSerialize);
            sw.Close();
            CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(ToBeSaved);
        }

        public static void SaveArmor(Armor currentArmor)
        {
            string newSerialize = currentArmor.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Armor\\" + currentArmor.ItemName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }

        public static void SaveWeapon(Weapon currentWeap)
        {
            string newSerialize = currentWeap.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Weapons\\" + currentWeap.ItemName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }

        public static void SaveShield(Shield currentShield)
        {
            string newSerialize = currentShield.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Shields\\" + currentShield.ItemName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }

        public static void SaveEnchantment(IfElseLogic ToBeSaved)
        {
            string newSerialize = ToBeSaved.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Enchantments\\" + ToBeSaved.Name + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }

        public static void SaveSpell(Spell ToBeSaved)
        {
            string newSerialize = ToBeSaved.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Spells\\" + ToBeSaved.SpellName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }

        public static void SaveItem(Item ToBeSaved)
        {
            string newSerialize = ToBeSaved.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Items\\" + ToBeSaved.ItemName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
        }
        #endregion
        #region datatransfer
        public static string GenerateDataBlob()
        {
            StringBuilder blob = new StringBuilder();
            SuckAllDataFromDirectory(blob, GetEnchantmentNames(), "Data\\Enchantments\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetItemNames(), "Data\\Items\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetWeaponNames(), "Data\\Weapons\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetArmorNames(), "Data\\Armor\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetShieldNames(), "Data\\Shields\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetSpellNames(), "Data\\Spells\\");
            blob.Append("DIVIDERSTRINGABCDEFFEDCBA");
            SuckAllDataFromDirectory(blob, GetCharacterNames(), "Data\\Characters\\");

            return blob.ToString();
        }

        public static void SuckAllDataFromDirectory(StringBuilder blob, List<String> names, string dir)
        {
            foreach (string name in names)
            {
                StreamReader sr = new StreamReader(dir + name + ".xml");
                string currentCharString = sr.ReadToEnd();
                blob.Append(currentCharString + " |||||||| ");
            }
        }

        public static void SaveDataBlob(string blob)
        {
            string enchantmentblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[0];
            string itemblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[1];
            string weaponblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[2];
            string armorblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[3];
            string shieldblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[4];
            string spellblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[5];
            string charblob = blob.Split(new string[] { "DIVIDERSTRINGABCDEFFEDCBA" }, StringSplitOptions.None)[6];
            foreach (string str in enchantmentblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                IfElseLogic toSave = IfElseLogic.Deserialize(str);
                SaveEnchantment(toSave);
            }
            foreach (string str in itemblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Item toSave = Item.Deserialize(str, typeof(Item));
                SaveItem(toSave);
            }
            foreach (string str in weaponblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Weapon toSave = (Weapon)Item.Deserialize(str, typeof(Weapon));
                SaveWeapon(toSave);
            }
            foreach (string str in armorblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Armor toSave = (Armor)Item.Deserialize(str, typeof(Armor));
                SaveArmor(toSave);
            }
            foreach (string str in shieldblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Shield toSave = (Shield)Item.Deserialize(str, typeof(Shield));
                SaveShield(toSave);
            }
            foreach (string str in spellblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Spell toSave = Spell.Deserialize(str);
                SaveSpell(toSave);
            }
            foreach (string str in charblob.Split(new string[] { " |||||||| " }, StringSplitOptions.RemoveEmptyEntries))
            {
                Character toSave = Character.Deserialize(str);
                SaveCharacter(toSave);
            }
        }
        #endregion

        public static Character GetSameCharWithCurrentState(Character c)
        {
            Character copyChar = GetCharByName(c.Name);
            copyChar.Stamina = c.Stamina;
            copyChar.HitPoints = c.HitPoints;
            copyChar.CombatStuff.CombatWeapon = c.CombatStuff.CombatWeapon;
            copyChar.CombatStuff.CombatShield = c.CombatStuff.CombatShield;
            copyChar.CombatStuff.CombatOB = c.CombatStuff.CombatOB;
            copyChar.CombatStuff.CombatDB = c.CombatStuff.CombatDB;
            copyChar.CombatStuff.CombatName = copyChar.Name + addedRandomness.NextDouble().ToString();
            foreach (IfElseLogic iel in copyChar.Enchantments.Keys)
            {
                iel.CharParent = copyChar;
            }
            foreach(Effect eff in c.TemporaryEffects)
            {
                copyChar.TemporaryEffects.Add(eff);
            }
            Utilities.FillEquipListsFromInventory(copyChar);
            return copyChar;
        }
        public static void updateCharacterInMemoryFromDB(Character c)
        {
            Character updateWith = GetCharByName(c.Name);
            updateWith.HitPoints = c.HitPoints;
            updateWith.Stamina = c.Stamina;
            updateWith.Enchantments = c.Enchantments;
            updateWith.CombatStuff = c.CombatStuff;
            c = updateWith;
        }
        public static void forceTypesToConformToTag(Effect e) {
            List<EffectHolder.EffectType> newEffectTypes = new List<EffectHolder.EffectType>();
            switch (e.effectTag)
            {
                case EffectHolder.EffectTag.Bleed:
                    newEffectTypes.Add(EffectHolder.EffectType.Regeneration);
                    e.deterioration = 1;
                    e.effectLength = (int)(e.effectStrength) * -1;
                    break;
                case EffectHolder.EffectTag.Trauma:
                    newEffectTypes.Add(EffectHolder.EffectType.Focus);
                    e.deterioration = 1;
                    e.effectLength = (int)(e.effectStrength) * -1;
                    break;
                case EffectHolder.EffectTag.BoneImpairment:
                    newEffectTypes.Add(EffectHolder.EffectType.OB);
                    newEffectTypes.Add(EffectHolder.EffectType.DB);
                    e.deterioration = 0;
                    e.effectLength = -1;
                    break;
                case EffectHolder.EffectTag.MuscleImpairment:
                    newEffectTypes.Add(EffectHolder.EffectType.OB);
                    newEffectTypes.Add(EffectHolder.EffectType.DB);
                    e.deterioration = 0;
                    e.effectLength = -1;
                    break;
                case EffectHolder.EffectTag.NerveImpairment:
                    newEffectTypes.Add(EffectHolder.EffectType.OB);
                    newEffectTypes.Add(EffectHolder.EffectType.DB);
                    e.deterioration = 0;
                    e.effectLength = -1;
                    break;
                case EffectHolder.EffectTag.Disorientation:
                    newEffectTypes.Add(EffectHolder.EffectType.OB);
                    newEffectTypes.Add(EffectHolder.EffectType.DB);
                    e.deterioration = 1;
                    e.effectLength = (int)(e.effectStrength) * -1;
                    break;
                case EffectHolder.EffectTag.NoTag:
                    break;
            }
            if (e.effectTag != EffectHolder.EffectTag.NoTag) {
                e.effectTypes = newEffectTypes;
            }            
        }

        public static void SetEnchantmentParams(Dictionary<IfElseLogic, Dictionary<String, Object>> enchantments)
        {
            foreach(IfElseLogic iel in enchantments.Keys)
            {
                foreach(object[] objarr in iel.variables)
                {
                    if (enchantments[iel].ContainsKey((string)objarr[0]))
                    {
                        objarr[1] = enchantments[iel][(string)objarr[0]];
                    }
                }
            }
        }

        public static Tuple<int, int, int> translateNumberToColorValues(double input)
        {
            double Red = 0;
            double Blue = 0;
            double Green = 0;
            switch ((int)input)
            {
                //miss
                case -1:
                    Red = 0;
                    Blue = 0;
                    Green = 0;
                    break;
                //block
                case -2:
                    Red = 100;
                    Blue = 100;
                    Green = 100;
                    break;
                //parry
                case -3:
                    Red = 200;
                    Blue = 200;
                    Green = 200;
                    break;
                default:
                    if (input < 100)
                    {
                        Red = 255;
                        Blue = 255;
                        Green = 255;
                    }
                    if (input < 50)
                    {
                        Red = 200;
                        Blue = 0;
                        Green = 0;
                    }
                    if (input < 20)
                    {
                        Red = 200;
                        Blue = 0;
                        Green = 200;
                    }
                    if (input < 15)
                    {
                        Red = 0;
                        Blue = 0;
                        Green = 200;
                    }
                    if (input < 10)
                    {
                        Red = 0;
                        Blue = 200;
                        Green = 200;
                    }
                    if (input < 5)
                    {
                        Red = 0;
                        Blue = 250;
                        Green = 100;
                    }
                    if (input < 4)
                    {
                        Red = 50;
                        Blue = 200;
                        Green = 0;
                    }
                    if (input < 3)
                    {
                        Red = 100;
                        Blue = 125;
                        Green = 0;
                    }
                    if (input < 2)
                    {
                        Red = 200;
                        Blue = 100;
                        Green = 50;
                    }
                    if (input < 1)
                    {
                        Red = 225;
                        Blue = 0;
                        Green = 125;
                    }
                    break;
            }
            int iRed = Convert.ToInt32(Math.Floor(Red));
            int iBlue = Convert.ToInt32(Math.Floor(Blue));
            int iGreen = Convert.ToInt32(Math.Floor(Green));
            return new Tuple<int, int, int>(iRed, iGreen, iBlue);
        }

        public static List<String> translateAttackOutcomeToDisplayStrings(AttackOutcome ao, string correctUUID) {
            List<String> ret = new List<string>();
            ret.Add("----------------------------------");
            ret.Add("Attacker: " + ao.Attacker.CombatStuff.CombatName);
            ret.Add("Defender: " + ao.Defender.CombatStuff.CombatName);
            ret.Add("Attack Roll: " + ao.attackRoll.ToString());
            ret.Add("Defence Roll: " + ao.defendRoll.ToString());
            ret.Add("Attacker Weapon: " + ao.Notes.attackerWeaponName);
            ret.Add(HTMLWriter.BaseURL() + "/attackResults/" + correctUUID);
            ret.Add("");
            if (ao.Othertext.ToString() == "Miss")
            {
                ret.Add(getStringByValueInList(new List<string>() { "you done missed real bad", "dodged like it was nothing", "dodged easily", "dodged", "just barely dodged", "dodged but they kinda had to parry too" }, new List<int> { -15,-10, -5, -1, 0 }, ao.HitCaliber));
            }
            else if (ao.Othertext.ToString() == "Block")
            {
                ret.Add(getStringByValueInList(new List<string>() { "blocked like it was nothing", "blocked easily", "blocked", "just barely blocked", "blocked but they kinda had to parry too" }, new List<int> { -10, -5, -1, 0 }, ao.HitCaliber));
            }
            else if (ao.Othertext.ToString() == "Parry")
            {
                ret.Add(getStringByValueInList(new List<string>() { "parried like it was nothing","parried easily", "parried", "just barely parried", "tbh you should have hit" }, new List<int> { -10, -5, -1, 0 }, ao.HitCaliber));
            }
            else
            {
                Double constMod = ao.Defender.Statistics.Constitution / 10.0;
                ret.Add("Attack Location: " + ao.HitLocation);
                ret.Add("Attack Accuracy: " + getStringByValueInList(new List<string>() { "(0) Barely Touched", "(1) Connected, But Not By Much", "(2) OK Hit", "(3) Accurate Hit", "(4) Precise hit", "(5) Fantastic Hit", "(6) Incredible Hit", "(7) Surgical Precision And Blinding Speed" }, new List<int> { 0, 1, 3, 7, 14, 20, 30 }, ao.HitCaliber));
                ret.Add("Hit Strength: "  + getStringByValueInList(new List<string>() { "(0) Nothing, sorry", "(1) Weak", "(2) Not Much Impact", "(3) Reasonable Impact", "(4) A Solid Impact", "(5) Strong Impact", "(6) Powerful Impact", "(7) WHACK", "(8) they are indeed feeling it now mr krabs" }, new List<int> { 0, 1, 4, 8, 14, 20, 35, 45 }, ao.HitStrength / constMod));
                ret.Add("Damage: "  + getStringByValueInList(new List<string>() { "(0) Didn't Make It Through The Armor", "(1) Meh", "(2) They'll have a bruise", "(3) That Definitely Hurt", "(4) They've Been Damaged", "(5) That Caused An Injury", "(6) They'll Need Medical Attention", "(7) Major Injury", "(8) Arrow to the Knee" }, new List<int> { 0, 1, 5, 10, 16, 24, 35, 50 }, ao.TotalStrikeAmountFromAllTypes() / constMod));
                ret.Add("");
                ret.Add("Harm: "  + getStringByValueInList(new List<string>() { "(0) No Harm", "(1) Ow", "(2) You Have Somewhat Harmed Them", "(3) That Will Leave A Mark", "(4) Serious Contusions", "(5) You Messed Up Some Internal Organs", "(6) Kills most people", "(7) NOW THATS A LOTTA DAMAGE" }, new List<int> { 0, 1, 5, 10, 20, 30, 40 }, ao.harm / constMod));
                ret.Add("Bleed: "  + getStringByValueInList(new List<string>() { "(0) No Bleed", "(1) A Drop Of Blood", "(2) They'll Want A Band-Aid", "(3) Bleeding Significantly", "(4) Thats A Lot Of Blood", "(5) Bleeding Profusely", "(6) Spurting", "(7) Like a fountain" }, new List<int> { 0, 1, 3, 4, 8, 14, 20 }, ao.bleed / constMod));                
                ret.Add("Disorientation: "  + getStringByValueInList(new List<string>() { "(0) They Noticed You", "(1) A Little Off-Balance", "(2) They Have Been Suprised", "(3) Their Ears Are Ringing", "(4) Mildly Concussed", "(5) Very Concussed", "(6) Basically Falling Over", "(7) They Dont Know Which Way Is Up" }, new List<int> { 0, 1, 3, 6, 9, 15, 20 }, ao.disorientation));
                ret.Add("Impairment: "  + getStringByValueInList(new List<string>() { "(0) Nothing Permanent", "(1) An Annoyance", "(2) They'll Want To Talk To A Healer", "(3) Crunch", "(4) Something Important Broke", "(5) Serious Trauma", "(6) They Are Now A Cripple", "(7) They have ceased to function" }, new List<int> { 0, 1, 2, 3, 5, 7, 10 }, ao.impairment));
                ret.Add("Trauma: "  + getStringByValueInList(new List<string>() { "(0) They're OK", "(1) Briefly Fazed", "(2) Stunned For All Next Round", "(3) Stunned For a While", "(4) They're Gonna Be Out Of It For A Bit", "(5) They Are Taking A Break, It Seems", "(6) They Have Stopped Struggling For The Moment", "(7) Puny God" }, new List<int> { 0, 1, 2, 3, 5, 7, 10 }, ao.trauma));
                ret.Add("KO: "  + getStringByValueInList(new List<string>() { "(0) No KO", "(1) Out Cold, For The Moment", "(2) They Have Gone To Sleep", "(3) Coma", "(4) DED" }, new List<int> { 0, 1, 2, 3 }, ao.ko));
                
            }
            ret.Add("----------------------------------");
            ret.Add("");
            return ret;
        }

        public static string translateCharacterStatusToDisplayString(Character c)
        {
            string ret = "";
            ret += "Stamina " + getStringByValueInList(new List<string>() { "(0)", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }, c.Stamina * 10 / CombatScripts.GetBaseStamina(c));
            ret += " ";
            ret += "Health " + getStringByValueInList(new List<string>() { "UNCONSCIOUS", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 2, 3, 5, 7, 9 }, (c.HitPoints + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health)) * 10 / (CombatScripts.GetBaseHealth(c) + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health)));
            ret += " ";
            ret += "Impairment " + getStringByValueInList(new List<string>() { "(0)", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, -EffectHolder.GetValidEffectsByTag(c, EffectHolder.EffectTag.NerveImpairment));
            ret += " ";
            ret += "Disorientation " + getStringByValueInList(new List<string>() { "(0)", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, -EffectHolder.GetValidEffectsByTag(c, EffectHolder.EffectTag.Disorientation));
            ret += " ";
            ret += "Bleed " + getStringByValueInList(new List<string>() { "(0)", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, -EffectHolder.GetValidEffectsByTag(c, EffectHolder.EffectTag.Bleed) / (CombatScripts.GetBaseHealth(c) + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health)));
            ret += " ";
            ret += "Trauma " + getStringByValueInList(new List<string>() { "(0)", "(1)", "(2)", "(3)", "(4)", "(5)", "(6)", "(7)" }, new List<int> { 0, 1, 2, 4, 6, 10, 15 }, EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Focus));
            ret += " ";
            ret += "KO " + getStringByValueInList(new List<string>() { "(0)", "UNCONSCIOUS", "OUT COLD", "COMA" }, new List<int> { 1, 3, 10 }, EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.KO));
            /* This could be uncommented and edited if we wanted fancier messages. At this point it might just look messy.
            ret += getStringByValueInList(new List<string>() { "(0) Utterly Spent", "(1) About To Drop", "(2) Extremely Exhausted", "(3) Very Tired", "(4) Slowing Down", "(5) Tired", "(6) Beginning to Tire", "(7) Fresh" }, new List<int> { 0, 1, 2, 3, 4, 5, 7 }, c.Stamina * 10 / CombatScripts.GetBaseStamina(c));
            ret += ". ";
            ret += getStringByValueInList(new List<string>() { "(0) Unconcious", "(1) Barely Concious", "(2) Gravely Wounded", "(3) Seriously Injured", "(4) Injured", "(5) Battered", "(6) A Little Hurt", "(7) Unharmed" }, new List<int> { 0, 1, 2, 3, 5, 7, 9 }, (c.HitPoints + EffectHolder.GetValidEffectsByEffect(c.Name, c.CombatStuff.CombatName, EffectHolder.EffectType.Health)) * 10 / (CombatScripts.GetBaseHealth(c) + EffectHolder.GetValidEffectsByEffect(c.Name, c.CombatStuff.CombatName, EffectHolder.EffectType.Health)));
            ret += ". ";
            ret += getStringByValueInList(new List<string>() { "(0) Nothing Permanent", "(1) An Annoyance", "(2) Mildly Impaired", "(3) Fairly Impaired", "(4) Something Important Is Broken", "(5) They'll Never Be The Same", "(6) They Are Now A Cripple", "(7) They have ceased to function" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, EffectHolder.GetValidEffectsByTag(c.Name, c.CombatStuff.CombatName, EffectHolder.EffectTag.NerveImpairment));
            ret += ". ";
            ret += getStringByValueInList(new List<string>() { "(0) Nothing Permanent", "(1) An Annoyance", "(2) Mildly Impaired", "(3) Fairly Impaired", "(4) Something Important Is Broken", "(5) They'll Never Be The Same", "(6) They Are Now A Cripple", "(7) They have ceased to function" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, EffectHolder.GetValidEffectsByTag(c.Name, c.CombatStuff.CombatName, EffectHolder.EffectTag.Disorientation));
            ret += ". ";
            ret += getStringByValueInList(new List<string>() { "(0) Nothing Permanent", "(1) An Annoyance", "(2) Mildly Impaired", "(3) Fairly Impaired", "(4) Something Important Is Broken", "(5) They'll Never Be The Same", "(6) They Are Now A Cripple", "(7) They have ceased to function" }, new List<int> { 0, 1, 3, 6, 12, 20, 30 }, EffectHolder.GetValidEffectsByTag(c.Name, c.CombatStuff.CombatName, EffectHolder.EffectTag.Bleed));*/
            return ret;
        }

        public static double GetTotalOffensiveBonusOfAllArmor(Character c)
        {
            double ret = 0.0;
            foreach(Armor arm in c.Armor)
            {
                ret += arm.OffensiveBonus;
            }
            return ret;
        }

        public static double GetTotalDefensiveBonusOfAllArmor(Character c)
        {
            double ret = 0.0;
            foreach (Armor arm in c.Armor)
            {
                ret += arm.DefensiveBonus;
            }
            return ret;
        }

        public static string translateEnchantmentsToDisplayString(Dictionary<IfElseLogic, Dictionary<String, Object>> Enchantments)
        {
            string ret = "";
            foreach(IfElseLogic iel in Enchantments.Keys)
            {
                ret += iel.Name + "\n";
                foreach(string str in Enchantments[iel].Keys)
                {
                    ret += "  " + str + "     " + Enchantments[iel][str].ToString() + "\n";
                }
                ret += "\n";
            }
            return ret;
        }

        public static string getStringByValueInList(List<String> resultOptions, List<int> switchPoints, double val) {
            if (resultOptions.Count != switchPoints.Count() + 1) {
                return resultOptions.ElementAt(0);
            }
            int i = 0;
            while (i < switchPoints.Count() && val > switchPoints[i]) {
                i++;
            }
            return resultOptions[i];
        }

        public static int rollADTwenty()
        {
            int ret = 0;
            int temp = addedRandomness.Next(1, 21);
            if(temp == 20)
            {
                ret = 20;
                do
                {
                    temp = addedRandomness.Next(1, 21);
                    ret += temp;
                }
                while (temp == 20);
            }
            else if(temp == 1)
            {
                ret = 0;
                temp = 0;
                do
                {
                    temp = addedRandomness.Next(1, 21);
                    ret -= temp;
                }
                while (temp == 20);
            }
            else
            {
                ret = temp;
            }
            return ret;
        }
        // used for google writes. vertical list will be appended to the horizontal list
        public static void MeshVerticalAndHorizontalListLists(List<IList<Object>> vert, List<IList<Object>> horiz)
        {
            int longestList = 0;
            foreach(List<Object> LL in vert)
            {
                if(LL.Count() > longestList)
                {
                    longestList = LL.Count();
                }
            }
            for(int i = 0; i < longestList; i++)
            {
                List<Object> addToHoriz = new List<object>();
                foreach (List<Object> LL in vert)
                {
                    if (LL.Count() > i)
                    {
                        addToHoriz.Add(LL[i]);
                    }
                    else
                    {
                        addToHoriz.Add(null);
                    }
                }
                horiz.Add(addToHoriz);
            }
        }
        public static string HTMLTesterString = "";
        public static string turn2DArrayIntoHTMLTable(List<List<string>> arr)
        {
            string ret = "";
            ret += "<table>\n";
            foreach(List<String> il in arr)
            {
                ret += "\t<tr>\n";
                foreach (String obj in il)
                {
                    if(obj != null)
                    {
                        ret += "\t\t<td>" + obj + "</td>\n";
                    }
                    else
                    {
                        ret += "\t\t<td></td>\n";
                    }
                }
                ret += "\t</tr>\n";
            }
            ret += "</table>\n";
            return ret;
        }
        public static Dictionary<String, String> parseContentFromUser(string content)
        {
            Dictionary<String, String> ret = new Dictionary<string, string>();
            if (content == null || content == "")
            {
                return ret;
            }
            string[] parts = content.Split('&');
            foreach(string str in parts)
            {
                string[] keyvalue = str.Replace('+', ' ').Split('=');
                if(keyvalue.Length != 2)
                {
                    MessageBox.Show("wierd data from user with string " + content);
                }
                else
                {
                    ret[keyvalue[0]] = keyvalue[1];
                }
            }


            return ret;
        }
        public static bool ValidateDoubleOrNegativeTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\-]?[\d\.]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        public static bool ValidatePositiveOrNegativeTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d\-]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        public static bool ValidateIntTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^\d+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        public static bool ValidateDoubleTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d\.]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        public static bool ValidateComboBox(string strText)
        {
            if (!(strText == "" || strText == null))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }

        public static double ParseDoubleFromDangerousString(string str)
        {
            double ret = 0.0;
            if(str != null && str != "")
            {
                Double.TryParse(str, out ret);
            }
            return ret;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[addedRandomness.Next(s.Length)]).ToArray());
        }
    }
}
