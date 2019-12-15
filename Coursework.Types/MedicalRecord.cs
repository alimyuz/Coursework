﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Coursework.Types
{
    public class MedicalRecord : IEquatable<MedicalRecord>
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public string Diagnosis { get; set; }

        public MedicalRecord()
        {
        }

        public MedicalRecord(Patient patient, DateTime from, DateTime until, string diagnosis)
        {
            this.Patient = patient;
            this.From = from;
            this.Until = until;
            this.Diagnosis = diagnosis;
        }


        public bool Equals([AllowNull] MedicalRecord other)
        {
            if (other == null)
                return false;

            return this.Id == other.Id;
        }
    }
}
