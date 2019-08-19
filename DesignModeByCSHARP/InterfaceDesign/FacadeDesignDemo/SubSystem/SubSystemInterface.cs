using System.Threading.Tasks;

public interface ISubSystem
{
    Task<bool> IsValidAsync();

    Task<bool> SaveAsync();
}