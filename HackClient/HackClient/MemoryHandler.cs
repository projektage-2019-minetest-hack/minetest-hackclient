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
        public Player player = new Player();
        public bool immortal = false;
        private Thread godmode;
        public MemoryHandler()
        {
            bool processExsits = false;
            processID = memory.getProcIDFromName("minetest");
            if(processID > 0)
            {
                processExsits = memory.OpenProcess(processID);
            }
            godmode = new Thread(godLoop);
        }

        public void setHP(string HP)
        {
            memory.writeMemory(player.offsetLeben, "2bytes", HP);
        }


        public void setPosition(string x, string y, string z)
        {
            memory.writeMemory(player.offsetx, "float", x);
            memory.writeMemory(player.offsety, "float", y);
            memory.writeMemory(player.offsetz, "float", z);
        }

        public void toggleGodmode()
        {
            if (immortal)
            {
                immortal = false;
                godmode.Abort();
            }
            else
            {
                immortal = true;
                godmode.Start();
            }
        }
        public void godLoop()
        {
            while (immortal)
            {
                setHP("20");
            }
        }
    }
}
