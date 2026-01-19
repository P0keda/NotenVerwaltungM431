using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class AuthService : IAuthService
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IProrectorRepository _prorectorRepository;

    public AuthService(ITeacherRepository teacherRepository, IProrectorRepository prorectorRepository)
    {
        _teacherRepository = teacherRepository;
        _prorectorRepository = prorectorRepository;
    }

    public object Register(RegisterUserDTO registerUserDTO)
    {
        if (registerUserDTO.Email.EndsWith("@gibz.ch"))
        {
            Teacher existingTeacher = _teacherRepository.GetTeacherByEmail(registerUserDTO.Email);
            if (existingTeacher != null)
            {
                throw new Exception("There is already teacher with this email");
            }

            Teacher teacher = new Teacher
            {
                FullName = registerUserDTO.FullName,
                Email = registerUserDTO.Email,
                Password = registerUserDTO.Password
            };

            _teacherRepository.CreateTeacher(teacher);

            return new TeacherDTO
            {
                Id = teacher.Id,
                Name = teacher.FullName,
                Email = teacher.Email
            };
        }
        else if (registerUserDTO.Email.EndsWith("@zg.ch"))
        {
            Prorector existingProrector = _prorectorRepository.GetProrectorByEmail(registerUserDTO.Email);
            if (existingProrector != null)
            {
                throw new Exception("There is already prorector with this email");
            }

            var prorector = new Prorector
            {
                fullName = registerUserDTO.FullName,
                Email = registerUserDTO.Email,
                Password = registerUserDTO.Password,
                Department = "not defined"
            };

            _prorectorRepository.CreateProrector(prorector);

            return new ProrectorDTO
            {
                Id = prorector.Id,
                Name = prorector.fullName,
                Email = prorector.Email,
                Department = prorector.Department
            };
        }
        else
        {
            throw new Exception("incorrect email domain");
        }
    }
    public object Login(LoginUserDTO loginUserDTO)
    {
        Teacher teacher = _teacherRepository.GetTeacherByEmail(loginUserDTO.Email);
        if (teacher != null)
        {
            if (teacher.Password != loginUserDTO.Password)
            {
                throw new Exception("Email or Passwort are incorrect");
            }

            return new TeacherDTO
            {
                Id = teacher.Id,
                Name = teacher.FullName,
                Email = teacher.Email
            };
        }

        Prorector prorector = _prorectorRepository.GetProrectorByEmail(loginUserDTO.Email);
        if (prorector != null)
        {
            if (prorector.Password != loginUserDTO.Password)
            {
                throw new Exception("Email or Passwort are incorrect");
            }

            return new ProrectorDTO
            {
                Id = prorector.Id,
                Name = prorector.fullName,
                Email = prorector.Email,
                Department = prorector.Department
            };
        }

        throw new Exception("User not found");
    }
}
