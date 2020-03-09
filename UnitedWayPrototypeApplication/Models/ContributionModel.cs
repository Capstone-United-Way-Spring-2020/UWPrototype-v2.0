﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Contribution ID")]
        public int ContributionID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "CWID")]
        [Range(00000001, 99999999, ErrorMessage = "CWID must be valid.")]
        [Required(ErrorMessage = "You must enter an employee CWID.")]
        public int CWID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Employee First Name")]
        [Required(ErrorMessage = "You must enter an employee first name.")]
        public string contributionfname { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Employee Last Name")]
        [Required(ErrorMessage = "You must enter an employee last name.")]
        public string contributionlname { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Agency ID")]
        public int AgencyID { get; set; }

        [Display(Name = "Type of Contribution")]
        [Required(ErrorMessage = "You must select a contribution type.")]
        public string UWType { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Amount")]
        public double UWMonthly { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Number of Months")]
        [Range(0, 12, ErrorMessage = "Number of Months must be a valid number.")]
        public int UWMonths { get; set; }

        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Total Contribution Amount")]
        public double uwcontributionamount { get; set; }

        [Display(Name = "Current Year")]
        public int UWYear { get; set; }

        // Commented out in HTML
        [DataType(DataType.Date)]
        [Display(Name = "Date of Contribution")]
        public System.DateTime UWDateCreated { get; set; } = DateTime.Now;

        // Commented out in HTML
        [DataType(DataType.Date)]
        [Display(Name = "Date of Edit")]
        public System.DateTime UWDateLastEdited { get; set; } = DateTime.Now;
    }
}