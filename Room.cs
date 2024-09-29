using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Room
    {
        public int RoomNumber;
        public enum RoomTypes { General, ICU, OperationTheater }
        public RoomTypes RoomType;
        protected bool IsOccupied = false;

        public Room(int RNumber , RoomTypes Rtype )
        { 
            RoomNumber = RNumber;
            RoomType = Rtype;
        }

    }
}
