using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AdminPaneNew.Areas.OfficialAdmin.Models
{
    public class Home
    {

    }
   
    public class Contact
    {
        [Key]
        public int Contactid { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime date { get; set; }
    }
  
    public class Account
    {
        [Key]
        public int Accountid { get; set; }
        [Required]
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Usename { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime date { get; set; }
    }
    public class StudentReg
    {
        [Key]
        public int Studentid { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Contact { get; set; }
        public string Laststudy { get; set; }
        public string Medical { get; set; }
        public string Refusal { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", ErrorMessage = "You must provide a valid email address.")]
        public string Email { get; set; }
        public string Password { get; set; }
        public int RollNo { get; set; }
        public string Fileno { get; set; }

    }
    public class fees
    {
        [Key]
        public int feeid { get; set; }
        public string studentid { get; set; }
        public int Package { get; set; }
        public int Advance { get; set; }
        public int pay { get; set; }
        public int balance { get; set; }
    }
    public class SingleFee
    {
        [Key]
        public int sfid { get; set; }
        public string studentid { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
        public int Paid { get; set; }
        public int Billno { get; set; }
        public string Receivedby { get; set; }

    }
}