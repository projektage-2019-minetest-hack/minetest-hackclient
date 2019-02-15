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
        Mem memory = new Mem();
        public int processID = 0;
        public bool processExsits = false;
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
               
            List<long> offsetofplayer = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).ToList();
      
            foreach (long offset in offsetofplayer)
            {
                Player player = new Player(offset, false);
                playerlist.Add(player);
            }

            long offsetself = (await memory.AoBScan("18 FC A9 00 00 00 00 00", true)).FirstOrDefault();
            Self = new Player(offsetself, true);
            //long playeroffset = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).FirstOrDefault();
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
            if (chosenPlayer.offsetLeben != "NO")
            {
                memory.writeMemory(chosenPlayer.offsetLeben, "2bytes", HP);
            }
            
        }

        public string getHp()
        {
            //return memory.read2Byte(playerlist[playerId].offsetLeben).ToString();
            if (chosenPlayer.offsetLeben != "NO")
            {
                    string HP = memory.read2Byte(chosenPlayer.offsetLeben).ToString();
                    return HP;
            }
            else
            {
                return "Not Possible";
            }
        }

        public string getName()
        {
            if (chosenPlayer.offsetName != "NO")
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
            if (chosenPlayer.offsetx != "NO")
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
            if (chosenPlayer.offsetx != "NO")
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
            while (immortal)
            {
                setHP("20");

            }
        }

        public void ghostmode()
        {
            setHP("0");
        }
    }
}
