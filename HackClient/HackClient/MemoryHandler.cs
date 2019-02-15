using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Memory;
using System.Numerics;
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
            //long offsetcamera = (await memory.AoBScan("18 FC A9 00 00 00 00 00", true)).FirstOrDefault();
            Self = new Player(offsetself, true);

            //long playeroffset = (await memory.AoBScan("E0 22 AA 00 ?? 00 ?? 00 00 00 00 ?? 39 05 39 05", true)).FirstOrDefault();
        }//D8 F4 D9 00 A6 6F 68 00 A0 FA AD

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

        public float getRotation()
        {
            float rotation = 0;
            rotation = memory.readFloat(chosenPlayer.offsetdirection);
            return rotation;
        }

        public void move(double distance)
        {
            string[] currentposition = getPosition();
            //Calculate

            float rotation = getRotation();
            int drehungen = ((int)(rotation / 360));
            rotation -= 360 * drehungen;
            if (rotation < 0)
            {
                rotation = 360+rotation;
            }
            //float rotation = 10;
            /*double xR = Math.Tan(rotation);
            double zR = Math.Sin(rotation);
            double x = Convert.ToDouble(currentposition[0]);
            double z = Convert.ToDouble(currentposition[2]); 
            double dlang = Math.Sqrt(x*x + z*z);
            double wambo = Math.Sqrt(dlang * dlang + distance * distance);

            double dRotationVectorInWorld = distance / dlang;
            dRotationVectorInWorld = Math.Asin(dRotationVectorInWorld);

            currentposition[0] = (2 * Math.Cos(dRotationVectorInWorld) - 2 * Math.Sin(dRotationVectorInWorld)).ToString();
            currentposition[2] = (2 * Math.Sin(dRotationVectorInWorld) - 2 * Math.Cos(dRotationVectorInWorld)).ToString();

            double dAufrechenwert = wambo - dlang;

            currentposition[0] = (Convert.ToDouble(currentposition[0]) + dAufrechenwert).ToString();
            currentposition[2] = (Convert.ToDouble(currentposition[2]) + dAufrechenwert).ToString();
            */

            //rotation = 0;

            //Vector2 vector = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation));
            //rotation = 90;
            double newrotation = 2 * Math.PI / 360 * rotation;
            double sina = Math.Sin(newrotation);
            double cosa = Math.Cos(newrotation);

            double a = sina * distance ;
            double b = cosa* distance  ;

            currentposition[0] = (Convert.ToDouble(currentposition[0]) - a).ToString();
            currentposition[2] = (Convert.ToDouble(currentposition[2]) + b).ToString();
            
            //        double xR = Math.Tan(rotation);
            //        double zR = Math.Sin(rotation);
            //        //normalizing

            //        /*double lang = Math.Sqrt(xR * xR + zR * zR);
            //        xR /= lang;
            //        zR /= lang;

            //*/
            //        xR = distance * xR;
            //        zR = distance * zR;
            //        currentposition[0] = (Convert.ToDouble(currentposition[0]) + xR).ToString();
            //        currentposition[2] = (Convert.ToDouble(currentposition[2]) + zR).ToString();

            setPosition(currentposition[0], currentposition[1], currentposition[2]);

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
