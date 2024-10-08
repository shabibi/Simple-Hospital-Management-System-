using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    // managing scheduling operations
    public interface ISchedulable
    {
        void ScheduleAppointment(Patient patient, DateTime date, TimeSpan time, bool isbooked);
        public void CancelAppointment(Patient patient, DateTime dateTime, TimeSpan time);
    }
}
