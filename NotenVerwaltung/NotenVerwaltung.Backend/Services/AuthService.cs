using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class AuthService : IAuthService
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IProrectorRepository _prorectorRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="IAuthService"/> class.
    /// </summary>
    /// <param name="teacherRepository"></param>
    /// <param name="prorectorRepository"></param>
    public AuthService(ITeacherRepository teacherRepository, IProrectorRepository prorectorRepository)
    {
        _teacherRepository = teacherRepository;
        _prorectorRepository = prorectorRepository;
    }

    /// <inheritdoc />
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
                Email = registerUserDTO.Email
            };
            PasswordHasher.CreatePasswordHash(registerUserDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
            teacher.PasswordHash = passwordHash;
            teacher.PasswordSalt = passwordSalt;

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

            Prorector prorector = new Prorector
            {
                fullName = registerUserDTO.FullName,
                Email = registerUserDTO.Email,
                Department = "not defined"
            };

            PasswordHasher.CreatePasswordHash(registerUserDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
            prorector.PasswordHash = passwordHash;
            prorector.PasswordSalt = passwordSalt;

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

    /// <inheritdoc />
    public object Login(LoginUserDTO loginUserDTO)
    {
        Teacher teacher = _teacherRepository.GetTeacherByEmail(loginUserDTO.Email);
        if (teacher != null)
        {
            if (!PasswordHasher.VerifyPassword(loginUserDTO.Password, teacher.PasswordHash, teacher.PasswordSalt))
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
            if (!PasswordHasher.VerifyPassword(loginUserDTO.Password, prorector.PasswordHash, prorector.PasswordSalt))
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
