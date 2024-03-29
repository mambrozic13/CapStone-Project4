﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models.Account;

namespace WebApplication.Web.Models
{
    public class ReservationUserViewModel
    {
        public IList<Pets> Pets { get; set; }
        public IList<Reservation> Reservations { get; set; }
        public User User { get; set; }
        public Reservation Reservation { get; set; }
        public User InvitedUser { get; set; }
        public IList<Reservation> Pending { get; set; }
        public IList<Reservation> Accepted { get; set; }
        public IList<Reservation> Declined { get; set; }

        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }

    }
}
