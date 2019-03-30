﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    class Leave
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public LeaveType Type { get; set; }
    }

    enum LeaveType { Sickness, Rest, Parental, Unpaid };
}