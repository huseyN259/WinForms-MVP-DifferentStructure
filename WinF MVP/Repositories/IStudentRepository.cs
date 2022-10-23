using WinF_MVP.Models;

namespace WinF_MVP.Repositories;

internal interface IStudentRepository: IRepository<Student>
{
    Student? GetById(Guid Id);
}