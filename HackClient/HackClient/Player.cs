using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace HackClient
{
    class Player
    {
        public string offsetLeben;
        public string offsetx;
        public string offsety;
        public string offsetz;
        public string offsetFirstItem;
        public string ownOffset;
        public string offsetName;
        public long mainoffset;
        public string name;

        public Player(long offset, bool isSelf)
        {
            if (isSelf)
            {
                
            }
            else
            {
                ownOffset = "0x" + offset.ToString("x8");
                offsetLeben = "0x" + (offset + 104).ToString("x8");
              mainoffset = offset;
            }
            
            //getting name

        }
    }
}
