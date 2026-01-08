using NotenVerwaltung.Frontend.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services
{
    public class TeacherService : ITeacherService
    {
        // Beispiel-Daten für die Simulation
        private List<TeacherDTO> _teachers = new()
        {
            new TeacherDTO { Id = 1, FirstName = "Hans", LastName = "Müller", Email = "hans.mueller@gibz.ch" },
            new TeacherDTO { Id = 2, FirstName = "Sarah", LastName = "Meier", Email = "sarah.meier@gibz.ch" },
            new TeacherDTO { Id = 3, FirstName = "Beat", LastName = "Zgraggen", Email = "beat.zgraggen@gibz.ch" }
        };

        private int _nextId = 4;

        public async Task<IEnumerable<TeacherDTO>> GetAllTeachersAsync()
        {
            await Task.Delay(200); // Simuliert Netzwerk-Verzögerung
            return _teachers;
        }

        public async Task<TeacherDTO?> GetTeacherByIdAsync(int id)
        {
            await Task.Delay(100);
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public async Task<TeacherDTO> CreateTeacherAsync(TeacherDTO teacherDto)
        {
            await Task.Delay(300);
            teacherDto.Id = _nextId++;
            _teachers.Add(teacherDto);
            return teacherDto;
        }
    }
}