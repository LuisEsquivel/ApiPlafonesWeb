using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public string MainDescription { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifiedBy { get; set; }
        public string ModifiedDateTime { get; set; }
    }
}
