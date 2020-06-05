// MIT License - Copyright (c) 2016 Can Güney Aksakalli
// https://aksakalli.github.io/2014/02/24/simple-http-server-with-csparp.html

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;



namespace Second_Attempt
{
    public class SimpleServer
    {
        private readonly string[] _indexFiles = {
        "index.html",
        "index.htm",
        "default.html",
        "default.htm"
    };

        private static IDictionary<string, string> _mimeTypeMappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
        #region extension to MIME type list
        {".asf", "video/x-ms-asf"},
        {".asx", "video/x-ms-asf"},
        {".avi", "video/x-msvideo"},
        {".bin", "application/octet-stream"},
        {".cco", "application/x-cocoa"},
        {".crt", "application/x-x509-ca-cert"},
        {".css", "text/css"},
        {".deb", "application/octet-stream"},
        {".der", "application/x-x509-ca-cert"},
        {".dll", "application/octet-stream"},
        {".dmg", "application/octet-stream"},
        {".ear", "application/java-archive"},
        {".eot", "application/octet-stream"},
        {".exe", "application/octet-stream"},
        {".flv", "video/x-flv"},
        {".gif", "image/gif"},
        {".hqx", "application/mac-binhex40"},
        {".htc", "text/x-component"},
        {".htm", "text/html"},
        {".html", "text/html"},
        {".ico", "image/x-icon"},
        {".img", "application/octet-stream"},
        {".iso", "application/octet-stream"},
        {".jar", "application/java-archive"},
        {".jardiff", "application/x-java-archive-diff"},
        {".jng", "image/x-jng"},
        {".jnlp", "application/x-java-jnlp-file"},
        {".jpeg", "image/jpeg"},
        {".jpg", "image/jpeg"},
        {".js", "application/x-javascript"},
        {".mml", "text/mathml"},
        {".mng", "video/x-mng"},
        {".mov", "video/quicktime"},
        {".mp3", "audio/mpeg"},
        {".mpeg", "video/mpeg"},
        {".mpg", "video/mpeg"},
        {".msi", "application/octet-stream"},
        {".msm", "application/octet-stream"},
        {".msp", "application/octet-stream"},
        {".pdb", "application/x-pilot"},
        {".pdf", "application/pdf"},
        {".pem", "application/x-x509-ca-cert"},
        {".pl", "application/x-perl"},
        {".pm", "application/x-perl"},
        {".png", "image/png"},
        {".prc", "application/x-pilot"},
        {".ra", "audio/x-realaudio"},
        {".rar", "application/x-rar-compressed"},
        {".rpm", "application/x-redhat-package-manager"},
        {".rss", "text/xml"},
        {".run", "application/x-makeself"},
        {".sea", "application/x-sea"},
        {".shtml", "text/html"},
        {".sit", "application/x-stuffit"},
        {".swf", "application/x-shockwave-flash"},
        {".tcl", "application/x-tcl"},
        {".tk", "application/x-tcl"},
        {".txt", "text/plain"},
        {".war", "application/java-archive"},
        {".wbmp", "image/vnd.wap.wbmp"},
        {".wmv", "video/x-ms-wmv"},
        {".xml", "text/xml"},
        {".xpi", "application/x-xpinstall"},
        {".zip", "application/zip"},
        #endregion
    };
        private Thread _serverThread;
        private Thread _gridThread;
        //private string _rootDirectory;
        private HttpListener _listener;
        private int _port;
        public static bool isRunning = true;

        public int Port
        {
            get { return _port; }
            private set { }
        }

        /// <summary>
        /// Construct server with suitable port.
        /// </summary>
        /// <param name="path">Directory path to serve.</param>
        public SimpleServer(string path)
        {
            try
            {
                //get an empty port
                TcpListener l = new TcpListener(IPAddress.Loopback, 0);
                l.Start();
                int port = ((IPEndPoint)l.LocalEndpoint).Port;
                l.Stop();
                //this.Initialize(path, port);
                this.Initialize(port);
            }
            catch
            {
                Console.WriteLine("Failed To Create Server");
                isRunning = false;
            }
        }

        /// <summary>
        /// Stop server and dispose all functions.
        /// </summary>
        public void Stop()
        {
            try
            {
                _serverThread.Abort();
                _gridThread.Abort();
                _listener.Stop();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Listen()
        {
            try
            {
                _listener = new HttpListener();
                _listener.Prefixes.Add("http://*:" + _port.ToString() + "/");
                _listener.Start();
                Utilities.ServerWasStarted = true;
                while (true)
                {
                    try
                    {
                        HttpListenerContext context = _listener.GetContext();
                        Process(context);
                    }
                    catch (Exception ex)
                    {
                        isRunning = false;
                        Console.Error.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception e)
            {
                isRunning = false;
                Console.WriteLine(e.Message);
            }
        }

        private void Process(HttpListenerContext context)
        {
            string URLFromUser = Uri.UnescapeDataString(context.Request.Url.AbsolutePath);
            string ContentFromUser;
            using (System.IO.Stream body = context.Request.InputStream) // here we have data
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(body, context.Request.ContentEncoding))
                {
                    ContentFromUser = reader.ReadToEnd();
                }
            }
            Console.WriteLine(ContentFromUser + "\n");
            Console.WriteLine(URLFromUser + "\n");
            Dictionary<String, String> args = Utilities.parseContentFromUser(ContentFromUser);
            URLFromUser = URLFromUser.Substring(1);

            try
            {
                //Stream input = new FileStream(URLFromUser, FileMode.Open);
                string toWrite = "";
                switch (URLFromUser.Split('/')[0])
                {
                    case "":
                        toWrite = HTMLWriter.MainMenu();
                        break;
                    case "attackResults":
                        toWrite = HTMLWriter.AttackGrid(URLFromUser.Split('/')[1]);
                        break;
                    case "Weapons":
                        if(URLFromUser.Split('/').Length != 1)
                        {
                            toWrite = HTMLWriter.WeaponDisplay(Utilities.GetWeaponByName(URLFromUser.Split('/')[1]));
                        }
                        else
                        {
                            toWrite = HTMLWriter.WeaponsMenu();
                        }
                        break;
                    case "Characters":
                        if (URLFromUser.Split('/').Length != 1)
                        {
                            toWrite = HTMLWriter.CharacterSheet(Utilities.GetCharByName(URLFromUser.Split('/')[1]));
                        }
                        else
                        {
                            toWrite = HTMLWriter.CharacterMenu();
                        }
                        break;
                    case "Data":
                        toWrite = HTMLWriter.InPipe();
                        if (args.ContainsKey("pipe"))
                        {
                            Utilities.SaveDataBlob(Uri.UnescapeDataString(args["pipe"]));
                        }
                        break;
                    case "Combat":
                        if (URLFromUser.Split('/').Length != 1)
                        {
                            if(CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName == URLFromUser.Split('/')[1]))
                            {
                                Character selectedByUser = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == URLFromUser.Split('/')[1]);
                                if(URLFromUser.Split('/').Length > 2 && URLFromUser.Split('/')[2] == "Inventory")
                                {
                                    toWrite = Inventory(selectedByUser, args);
                                }
                                else
                                {
                                    toWrite = Combat(selectedByUser, args);
                                }
                            }
                        }
                        else
                        {
                            toWrite = HTMLWriter.CombatMenu();
                        }
                        break;
                }
                
                //Adding permanent http response headers
                //string mime;
                //context.Response.ContentType = _mimeTypeMappings.TryGetValue(Path.GetExtension(filename), out mime) ? mime : "application/octet-stream";
                context.Response.ContentType = "text/html";
                //context.Response.ContentLength64 = input.Length + Utilities.HTMLTesterString.Length;
                context.Response.ContentLength64 = toWrite.Length;
                context.Response.AddHeader("Date", DateTime.Now.ToString("r"));
                //context.Response.AddHeader("Last-Modified", System.IO.File.GetLastWriteTime(URLFromUser).ToString("r"));

                byte[] buffer = new byte[1024 * 16];
                /*
                while ((nbytes = input.Read(buffer, 0, buffer.Length)) > 0)
                    context.Response.OutputStream.Write(buffer, 0, nbytes);
                */
                //input.Close();
                //context.Response.OutputStream.Write(Encoding.UTF8.GetBytes(Utilities.HTMLTesterString), 0, Encoding.UTF8.GetBytes(Utilities.HTMLTesterString).Length);

                context.Response.OutputStream.Write(Encoding.UTF8.GetBytes(toWrite), 0, Encoding.UTF8.GetBytes(toWrite).Length);

                context.Response.StatusCode = (int)HttpStatusCode.OK;
                context.Response.OutputStream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            context.Response.OutputStream.Close();
        }

        private string Combat(Character selectedByUser, Dictionary<String, String> args)
        {
            if (args.ContainsKey("selectedweapon"))
            {
                selectedByUser.CombatStuff.CombatWeapon = selectedByUser.Weapons.Find(A => A.ItemName == args["selectedweapon"]);
            }
            if (args.ContainsKey("selectedshield"))
            {
                selectedByUser.CombatStuff.CombatShield = selectedByUser.Shields.Find(A => A.ItemName == args["selectedshield"]);
            }
            if (args.ContainsKey("selectedtargets"))
            {
                selectedByUser.LastAttackTargetSelected = args["selectedtargets"];
                if (args.ContainsKey("action"))
                {
                    if (!CombatHolder._alreadyAttackedThisRound.Contains(selectedByUser))
                    {
                        if (args["action"] == "Add Attack Target")
                        {
                            if (CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName == args["selectedtargets"]))
                            {
                                selectedByUser.CombatStuff.targets.Add(CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == args["selectedtargets"]));
                            }
                        }
                        if (args["action"] == "Remove Attack Target")
                        {
                            if (selectedByUser.CombatStuff.targets.Any(A => A.CombatStuff.CombatName == args["selectedtargets"]))
                            {
                                selectedByUser.CombatStuff.targets.Remove(selectedByUser.CombatStuff.targets.Find(A => A.CombatStuff.CombatName == args["selectedtargets"]));
                            }
                        }
                    }

                }
            }
            if (args.ContainsKey("selectedspelltargets"))
            {
                selectedByUser.LastSpellTargetSelected = args["selectedspelltargets"];
                if (args.ContainsKey("action"))
                {
                    if (args["action"] == "Add Spell Target")
                    {
                        if (CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName == args["selectedspelltargets"]))
                        {
                            selectedByUser.CombatStuff.SpellsToCast[0].targets.Add(CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == args["selectedspelltargets"]));
                        }
                    }
                    if (args["action"] == "Remove Spell Target")
                    {
                        if (selectedByUser.CombatStuff.SpellsToCast[0].targets.Any(A => A.CombatStuff.CombatName == args["selectedspelltargets"]))
                        {
                            selectedByUser.CombatStuff.SpellsToCast[0].targets.Remove(selectedByUser.CombatStuff.SpellsToCast[0].targets.Find(A => A.CombatStuff.CombatName == args["selectedspelltargets"]));
                        }
                    }
                }
            }
            if (args.ContainsKey("spellpower"))
            {
                double d;
                Double.TryParse(args["spellpower"], out d);
                selectedByUser.CombatStuff.SpellsToCast[0].spellPower = d;
            }
            if (args.ContainsKey("selectedspell"))
            {
                selectedByUser.CombatStuff.SpellsToCast[0].spell = selectedByUser.Spells.Find(A => A.SpellName == args["selectedspell"]);
            }
            if (args.ContainsKey("offbonus"))
            {
                double d;
                Double.TryParse(args["offbonus"], out d);
                selectedByUser.CombatStuff.CombatOB = d;
            }
            if (args.ContainsKey("defbonus"))
            {
                double d;
                Double.TryParse(args["defbonus"], out d);
                selectedByUser.CombatStuff.CombatDB = d;
            }
            if (args.ContainsKey("roll"))
            {
                double d;
                Double.TryParse(args["roll"], out d);
                selectedByUser.CombatStuff.CombatRoll = d;
            }
            if (!CombatHolder._alreadyAttackedThisRound.Contains(selectedByUser)
                && !CombatHolder._makingAttackChars.Contains(selectedByUser)
                && selectedByUser.CombatStuff.targets.Any())
            {
                CombatHolder.toggleCharAttack(selectedByUser);
            }
            if (CombatHolder._makingAttackChars.Contains(selectedByUser)
                && !selectedByUser.CombatStuff.targets.Any())
            {
                CombatHolder.toggleCharAttack(selectedByUser);
            }
            selectedByUser.CombatStuff.readyForCombat = true;
            selectedByUser.CombatStuff.rollSet = true;
            selectedByUser.CombatStuff.SpellsToCast[0].caster = selectedByUser;
            return HTMLWriter.CombatTerminal(selectedByUser);
        }

        private string Inventory(Character selectedByUser, Dictionary<String, String> args)
        {
            selectedByUser.Inventory = Utilities.GetCharByName(selectedByUser.Name).Inventory;
            Item toDropOnGround = new Item();
            Item toConsume = new Item();
            int count = 1;
            if (args.ContainsKey("itemamount"))
            {
                Int32.TryParse(args["itemamount"], out count);
            }
            count = Math.Max(count, 1);
            foreach (Item i in selectedByUser.Inventory)
            {
                if (!args.ContainsKey(i.ItemName))
                {
                    continue;
                }
                if (args[i.ItemName] == "drop")
                {
                    toDropOnGround = i;
                }
                if (args[i.ItemName] == "unequip")
                {
                    i.IsEquipped = false;
                    Utilities.SaveCharacter(selectedByUser);
                    break;
                }
                if (args[i.ItemName] == "equip")
                {
                    i.IsEquipped = true;
                    Utilities.SaveCharacter(selectedByUser);
                    break;
                }
                if (args[i.ItemName] == "consume")
                {
                    toConsume = i;
                }
                if (args[i.ItemName] == "inspect")
                {
                    return HTMLWriter.ItemDisplay(i);
                }
            }
            if (toDropOnGround.ItemName != "")
            {
                toDropOnGround = Item.Deserialize(toDropOnGround.Serialize(), toDropOnGround.GetType());
                toDropOnGround.Count = Math.Min(count, toDropOnGround.Count);
                toDropOnGround.IsEquipped = false;
                Utilities.RemoveItemFromInventory(toDropOnGround, selectedByUser.Inventory);
                Utilities.AddItemToInventory(toDropOnGround, CombatHolder._theGround);
                Utilities.SaveCharacter(selectedByUser);
            }
            if (toConsume.ItemName != "")
            {
                toConsume = Item.Deserialize(toConsume.Serialize(), toConsume.GetType());
                toConsume.Count = 1;
                toConsume.IsEquipped = false;
                Utilities.RemoveItemFromInventory(toConsume, selectedByUser.Inventory);
                foreach(Effect ef in toConsume.ItemEffects)
                {
                    EffectHolder.CreateEffect(ef, selectedByUser, false);
                }
                Utilities.SaveCharacter(selectedByUser);
            }
            Item toMoveFromGround = new Item();
            foreach (Item i in CombatHolder._theGround)
            {
                if (!args.ContainsKey(i.ItemName))
                {
                    continue;
                }
                if (args[i.ItemName] == "pick up")
                {
                    toMoveFromGround = i;
                    break;
                }
                if (args[i.ItemName] == "inspect")
                {
                    return HTMLWriter.ItemDisplay(i);
                }
            }
            if (toMoveFromGround.ItemName != "")
            {
                toMoveFromGround = Item.Deserialize(toMoveFromGround.Serialize(), toMoveFromGround.GetType());
                toMoveFromGround.Count = Math.Min(count, toMoveFromGround.Count);
                Utilities.AddItemToInventory(toMoveFromGround, selectedByUser.Inventory);
                Utilities.RemoveItemFromInventory(toMoveFromGround, CombatHolder._theGround);
                Utilities.SaveCharacter(selectedByUser);
            }
            
            return HTMLWriter.InventoryTerminal(selectedByUser);
        }

        //private void Initialize(string path, int port)
        private void Initialize(int port)
        {
            //this._rootDirectory = path;
            this._port = port;
            _serverThread = new Thread(this.Listen);
            _serverThread.Start();
            _gridThread = new Thread(AfterCrits.AddGridToIndexedAttacksForever);
            _gridThread.Start();
        }

    }
}
