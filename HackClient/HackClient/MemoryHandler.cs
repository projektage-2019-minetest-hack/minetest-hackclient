using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Memory;

namespace HackClient
{
    class MemoryHandler
    {
        //private static extern short getAsyncKeyState(System.Windows.Forms.Keys vKey);
        //private static extern short getAsyncKeyState(System.Int32 vKey);
        Mem memory = new Mem();
        public int processID = 0;
        public bool processExsits = false;
        //public Player player = new Player();
        public List<Player> playerlist = new List<Player>();
        public bool immortal = false;
        private Thread godmode;
        public int playerId = 0;
        public Player Self;
        public Player chosenPlayer;

        public MemoryHandler()
        {
            bool processExsits = false;
            processID = memory.getProcIDFromName("minetest");
            if (processID > 0)
            {
                processExsits = memory.OpenProcess(processID);
                //getPlayer();
            }
            godmode = new Thread(godLoop);
        }

        public async void getPlayerList()
        {
            playerlist.Clear();
            //83 EC 0C C7 05 98 19 AE 00 01 00 00 00
                //E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05
                //bool keepGoing = true;
                //int playernumber = 1;
                //while (keepGoing)
            List<long> offsetofplayer = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).ToList();
            /*if (offsetofplayer <= 0)
            {
                continue;
            }
            else
            {
                Player player = new Player(offsetofplayer);
                playerlist.Add(player);
            }*/
            foreach (long offset in offsetofplayer)
            {
                Player player = new Player(offset, false);
                //byte[] bA = memory.readBytes("0x" + (player.mainoffset + 516).ToString("x8"),4); //bA = base Adress
                                                                                                 //player.name = memory.readString("0x" + (baseOfNameAdress + 172).ToString("x8"));
                //ulong adresse = memory.readUInt("0x" + (player.mainoffset + 516).ToString("x8"));//"0x" + bA[3].ToString("x2") + "" + bA[2].ToString("x2") + "" + bA[1].ToString("x2") + "" + bA[0].ToString("x2"));

//player.name
                playerlist.Add(player);
            }

            long offsetself = (await memory.AoBScan("18 FC A9 00 00 00 00 00", true)).FirstOrDefault();
            Self = new Player(offsetself, true);
            //long playeroffset = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).FirstOrDefault();
            //player.ownOffset = "0x"+playeroffset.ToString("x8");
            //player.offsetLeben = "0x"+(playeroffset + 104).ToString("x8");
        }

        public void setChosenPlayer(int id)
        {
            if(id == -1)
            {
                chosenPlayer = Self;
                playerId = -1;
            }
            else
            {
                chosenPlayer = playerlist[id];
                playerId = id;
            }
        }

        public void setHP(string HP)
        {
            //memory.writeMemory(playerlist[playerId].offsetLeben, "2bytes", HP);
            if (!(chosenPlayer.offsetLeben == "NO"))
            {
                memory.writeMemory(chosenPlayer.offsetLeben, "2bytes", HP);
            }
            
        }

        public string getHp()
        {
            //return memory.read2Byte(playerlist[playerId].offsetLeben).ToString();

            if (!(chosenPlayer.offsetLeben == "NO"))
            {
                    string HP = memory.read2Byte(chosenPlayer.offsetLeben).ToString();
                    return HP;
            }
            else
            {
                return "Not Possible";
            }
        }

        public void SetName()
        {

        }

        public string getName()
        {
            if (!(chosenPlayer.offsetName == "NO"))
            {
                string name = memory.readString(chosenPlayer.offsetName);
                return name;
            }
            else
            {
                return "Not Possible";
            }
        }

        public void setPosition(string x, string y, string z)
        {
            /*
            memory.writeMemory(playerlist[playerId].offsetx, "float", x);
            memory.writeMemory(playerlist[playerId].offsety, "float", y);
            memory.writeMemory(playerlist[playerId].offsetz, "float", z);
            */
            if (!(chosenPlayer.offsetx == "NO"))
            {
                memory.writeMemory(chosenPlayer.offsetx, "float", x);
                memory.writeMemory(chosenPlayer.offsety, "float", y);
                memory.writeMemory(chosenPlayer.offsetz, "float", z);
            }
        }

        //get the position of the currently chosen
        public string[] getPosition()
        {
            string[] position = new string[3];
            /*
            position[0] = memory.readFloat(playerlist[playerId].offsetx).ToString();
            position[1] = memory.readFloat(playerlist[playerId].offsety).ToString();
            position[2] = memory.readFloat(playerlist[playerId].offsetz).ToString();
            */
            if (!(chosenPlayer.offsetx == "NO"))
            {
                position[0] = memory.readFloat(chosenPlayer.offsetx).ToString();
                position[1] = memory.readFloat(chosenPlayer.offsety).ToString();
                position[2] = memory.readFloat(chosenPlayer.offsetz).ToString();
            return position;
            }
            else
            {
                for (int i= 0; i > 3; i++)
                {
                    position[i] = "Not Possible";
                }
                return position;
            }
            
        }

        //sets the amount of items in the first inventoryspace
        public void setFistInventorySpace(string amount)
        {
            memory.writeMemory(playerlist[playerId].offsetFirstItem, "int", amount);
        }

        //starts of stops the godmode based on the status of the checkbox
        public void toggleGodmode(bool newstatus)
        {
            if (!newstatus)
            {
                immortal = false;
            }
            else
            {
                immortal = true;
                godmode.Start();
            }
        }

        //Loop that causes the "GodMode"
        public void godLoop()
        {
            //setFistInventorySpace("999999999");
            while (immortal)
            {
                setHP("20");

            }
        }

        public void ghostmode()
        {
            setHP("0");
        }

        /*public void flymode()
        {
            while (true)
            {
                getAsyncKeyState(Module1)
            }
        }*/
    }
}
