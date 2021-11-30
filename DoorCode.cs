using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNc
{
    public class Door
    {
        public bool OpenDoor(string key)
        {
            key = "Open";
            if (key == "Open")
            {
                return true;

            }
            return true;
        }

            public bool CloseDoor(string key)
            {
                key = "Close";
                if (key == "Close")
                {
                    return false;

                }
                return false;
            }
        }
    } 