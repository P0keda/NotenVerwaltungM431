using System;
using System.ComponentModel.DataAnnotations;

namespace NotenVerwaltung.Frontend.Models
{
    public class RequestModel
    {
        [Required(ErrorMessage = "Bitte geben Sie den Namen der Lehrkraft ein.")]
        public string TeacherName { get; set; } = "";

        [Required(ErrorMessage = "Bitte geben Sie den Namen des Schülers / der Schülerin ein.")]
        public string StudentName { get; set; } = "";

        [Required(ErrorMessage = "Bitte geben Sie den Namen des Prorektors / der Prorektorin ein.")]
        public string ProrectorName { get; set; } = "";

        [Required(ErrorMessage = "Bitte geben Sie das Fach ein.")]
        public string Subject { get; set; } = "";

        [Required(ErrorMessage = "Bitte wählen Sie die aktuelle Note aus.")]
        public string CurrentGrade { get; set; } = "";

        [Required(ErrorMessage = "Bitte wählen Sie die beantragte Note aus.")]
        public string RequestedGrade { get; set; } = "";

        [Required(ErrorMessage = "Bitte geben Sie eine Begründung ein.")]
        public string Justification { get; set; } = "";

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}