namespace Project.Core.Interfaces.IRepositories;

public interface IBaseRepository<T> where T : class
{
    Task<T> Create(T model);
}