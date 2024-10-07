using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public interface IPatientCare
    {
        void ProvidingCare();
    }
    public interface IInPatientCare : IPatientCare
    {
        void AssignRoom(Room room);
        void Discharge();
    }

    public interface IOutPatientCare : IPatientCare
    {
        void ScheduleAppointment();
    }
}
