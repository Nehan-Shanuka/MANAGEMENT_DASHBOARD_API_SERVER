﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models.FireApp_Regional_Class_Summary
{
    public class NonMotorClassBMData
    {
        public string REGION { get; set; }
        public int BRANCH_CODE { get; set; }
        public string BRANCH_NAME { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public double MOTOR_TOTAL_PREMIUM { get; set; }
        public double MOTOR_TOTAL_TARGET { get; set; }
        public double FIRE_TOTAL_PREMIUM { get; set; }
        public double FIRE_TOTAL_TARGET { get; set; }
        public double GENERAL_ACCIDENT_TOTAL_PREMIUM { get; set; }
        public double GENERAL_ACCIDENT_TOTAL_TARGET { get; set; }
        public double MARINE_TOTAL_PREMIUM { get; set; }
        public double MARINE_TOTAL_TARGET { get; set; }
        public double LEGAL_TOTAL_PREMIUM { get; set; }
        public double LEGAL_TOTAL_TARGET { get; set; }
        public double WCI_TOTAL_PREMIUM { get; set; }
        public double WCI_TOTAL_TARGET { get; set; }
        public double ESI_TOTAL_PREMIUM { get; set; }
        public double ESI_TOTAL_TARGET { get; set; }
        public double TOTAL_PREMIUM { get; set; }
    }
}