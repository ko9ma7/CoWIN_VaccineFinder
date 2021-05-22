﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineFinder
{
    public class GenerateMobileOTPRequest
    {
        public string mobile { get; set; }
        public string secret { get; set; }
    }
    public class ValidateMobileOTPRequest
    {
        public string otp { get; set; }
        public string txnId { get; set; }
    }

    public class SlotBookingRequest
    {
        public int dose { get; set; }
        public string session_id { get; set; }
        public string slot { get; set; }
        public List<string> beneficiaries { get; set; }
    }
}
