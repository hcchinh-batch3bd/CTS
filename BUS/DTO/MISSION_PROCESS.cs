using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien.DTO
{
    class MISSION_PROCESS_DTO
    {
        private string _id_employee;
        public string id_employee
        {
            get { return _id_employee; }
            set { _id_employee = value; }
        }
        private string _id_mission;
        public string id_mission
        {
            get { return _id_mission; }
            set { _id_mission = value; }
        }
        private byte _status;
        public byte status
        {

            get { return _status; }
            set { _status = value; }
        }
        private DateTime _date;
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
