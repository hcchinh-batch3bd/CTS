using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien.DTO
{
    class MISSION_DTO
    {
        private string _id_mission;
        public string id_mission
        {
            get { return _id_mission; }
            set { _id_mission = value; }
        }
        private string _name_mission;
        public string name_mission
        {
            get { return _name_mission; }
            set { _name_mission = value; }
        }
        private DateTime _data;
        public DateTime date
        {
            get { return _data; }
            set { _data = value; }
        }
        private int _point;
        public int point
        {
            get { return _point; }
            set { _point = value; }
        }
        private int _exprie;
        public int exprie
        {
            get { return _exprie; }
            set { _exprie = value; }
        }
        private string _describe;
        public string describe
        {
            get { return _describe; }
            set { _describe = value; }
        }
        private string _id_type;
        public string id_type
        {
            get { return _id_type; }
            set { _id_type = value; }
        }
        private string _id_employee;
        public string id_employee
        {
            get { return _id_employee; }
            set { _id_employee = value; }
        }

    }
}
