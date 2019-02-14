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
        //public Player player = new Player();
        public List<Player> playerlist= new List<Player>();
        public bool immortal = false;
        private Thread godmode;
        public int playerId = 0;


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
        {       //83 EC 0C C7 05 98 19 AE 00 01 00 00 00
                //E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05
            bool keepGoing = true;
            int playernumber = 1;
            while (keepGoing)
            {
                long offsetofplayer = (await memory.AoBScan("E0 22 AA 00 " + playernumber.ToString("x2") + " 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).FirstOrDefault();
                if (offsetofplayer <= 0)
                {
                    keepGoing = false;
                    break;
                }
                Player player = new Player();
                playerlist.Add(player);
                playernumber++;
            }
           
            //long playeroffset = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).FirstOrDefault();
            //player.ownOffset = "0x"+playeroffset.ToString("x8");
            //player.offsetLeben = "0x"+(playeroffset + 104).ToString("x8");
        }

        public void setHP( string HP)
        {
            memory.writeMemory(playerlist[playerId].offsetLeben, "2bytes", HP);
        }

        public string getHp()
        {
            return memory.read2Byte(playerlist[playerId].offsetLeben).ToString();
        }


        public void setPosition( string x, string y, string z)
        {
            memory.writeMemory(playerlist[playerId].offsetx, "float", x);
            memory.writeMemory(playerlist[playerId].offsety, "float", y);
            memory.writeMemory(playerlist[playerId].offsetz, "float", z);
        }

        /**gets the x, y and z position of the Player;
        *
        * 
        * 
        */
        public string[] getPosition()
        {
            string[] position = new string[3];
            position[0] = memory.readFloat(playerlist[playerId].offsetx).ToString();
            position[1] = memory.readFloat(playerlist[playerId].offsety).ToString();
            position[2] = memory.readFloat(playerlist[playerId].offsetz).ToString();
            return position;
        }

        //sets the amount of items in the first inventoryspace
        public void setFistInventorySpace( string amount)
        {
            memory.writeMemory(playerlist[playerId].offsetFirstItem, "int", amount);
        }

        //starts of stops the godmode based on the status of the checkbox
        public void toggleGodmode( bool newstatus)
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
    }
}
