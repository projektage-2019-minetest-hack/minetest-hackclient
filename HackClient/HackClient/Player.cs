﻿using System;
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
        public string offsetdirection;
        public string ownOffset;
        public string offsetName;
        public long mainoffset;

        public Player(long offset, bool isSelf)
        {
            if (isSelf)
            {
                offsetx = "0x" + (offset + 428).ToString("x8");
                offsety = "0x" + (offset + 432).ToString("x8");
                offsetz = "0x" + (offset + 436).ToString("x8");
                offsetLeben = "NO";
                offsetName = "0x" + (offset + 200).ToString("x8");
                
                offsetdirection = "0x" + (offset + 520).ToString("x8");
            }
            else
            {
                offsetLeben = "0x" + (offset + 104).ToString("x8");
                offsetx = "NO";
                offsety = "NO";
                offsetz = "NO";
                offsetName = "NO";
                offsetdirection = "NO";
            }
            ownOffset = "0x" + offset.ToString("x8");
            mainoffset = offset;

            //getting name

        }
    }
}
