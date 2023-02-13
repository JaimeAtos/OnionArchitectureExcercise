using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Candidate : AuditableBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Client { get; set; }
        public string Phone { get; set; }
        public string Recrutier { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string EducationLevel { get; set; }
        public string CurrentPosition { get; set; }
        public float SalaryExpectations { get; set; }
        public float CurrentSalaryGross { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Notes { get; set; }
        //public List<Language> Languages { get; set; } = new List<Language>();
        
    }

    
}
