﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pegasus.Data
{
    public partial class Barangay
    {
        public Barangay()
        {
            PersonProfile = new HashSet<PersonProfile>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string BarangayName { get; set; }
        [Column(TypeName = "text")]
        public string BarangayAddress { get; set; }
        [Column(TypeName = "text")]
        public string BarangayLocation { get; set; }
        [Column(TypeName = "text")]
        public string BarangayLogoPath { get; set; }
        [Column(TypeName = "text")]
        public string BarangayQrCode { get; set; }
        public int? LguId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }

        [ForeignKey(nameof(LguId))]
        [InverseProperty(nameof(LguProfile.Barangay))]
        public virtual LguProfile Lgu { get; set; }
        [InverseProperty("Brgy")]
        public virtual ICollection<PersonProfile> PersonProfile { get; set; }
    }
}