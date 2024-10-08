﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Room :IRoomManagement ,IDisplayInfo
    {
        public int RoomNumber;
        public enum RoomTypes { IPR, OPR }
        public RoomTypes RoomType;

        public bool IsOccupied { set ; get; }

        public Room(int RNumber , RoomTypes Rtype )
        { 
            RoomNumber = RNumber;
            RoomType = Rtype;
        }

        //Methods
        //: Marks the room as occupied.
        public bool OccupyRoom()
        {
           return IsOccupied=true;
        }

        //Marks the room as available
        public bool VacateRoom()
        {
            return IsOccupied =false;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine($"Room Number :{RoomNumber} RoomType :{RoomType} IsOccupied :{IsOccupied}");
        }
    }
}
