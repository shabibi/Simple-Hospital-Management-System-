﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public interface IRoomManagement
    {
        bool IsOccupied { set; get; }
        bool OccupyRoom();
        bool VacateRoom();
    }
}
