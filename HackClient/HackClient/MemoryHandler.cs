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

        public string getHp()
        {
            return memory.read2Byte(player.offsetLeben).ToString();
        }


        public void setPosition(string x, string y, string z)
        {
            memory.writeMemory(player.offsetx, "float", x);
            memory.writeMemory(player.offsety, "float", y);
            memory.writeMemory(player.offsetz, "float", z);
        }

        public string[] getPosition()
        {
            string[] position = new string[3];
            position[0] = memory.readFloat(player.offsetx).ToString();
            position[1] = memory.readFloat(player.offsety).ToString();
            position[2] = memory.readFloat(player.offsetz).ToString();
            return position;
        }

        public void toggleGodmode(bool newstatus)
        {
            if (newstatus)
            {
                immortal = false;
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
