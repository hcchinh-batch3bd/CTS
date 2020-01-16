using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlisinhvien.DTO
{
    class EMPLOYEE_DTO
    {
        private string _id_employee;
        public string id_employee
        {
            get { return _id_employee; }
            set { _id_employee = value; }
        }

        private string _name_employee;
        public string name_employee
        {
            get { return _name_employee; }
            set { _name_employee = value; }
        }

        private DateTime _date;
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        private int _level_employee;
        public int level_employee
        {
            get { return _level_employee; }
            set { _level_employee = value; }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private byte _status;
        public byte status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
