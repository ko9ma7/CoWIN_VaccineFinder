﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VaccineFinder
{
    public class UserDetails
    {
        public UserDetails(List<string> emailIds, string pinCode, int ageCriteria)
        {
            EmailIDs = new List<string>();
            EmailIDs.AddRange(emailIds);
            PinCode = pinCode;
            AgeCriteria = ageCriteria;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + (string.IsNullOrWhiteSpace(FirstName) ? "" : " ") + LastName; } }
        public List<string> EmailIDs { get; set; }
        public string EmailIdsString { get { return string.Join(",", EmailIDs); } }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public int AgeCriteria { get; set; }

        public bool IsValidEmailIds(List<string> emailList)
        {
            bool isValid = true;
            foreach (var email in emailList)
            {
                if (!IsValidEmail(email))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        public bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        // Function to validate the pin code of India.
        public bool isValidPinCode(String pinCode)
        {
            Regex regex = new Regex(@"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}$");
            Match match = regex.Match(pinCode);
            return match.Success;
        }
    }
}