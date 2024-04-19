using CostManager.Pwa.Models;

namespace CostManager.Pwa.Services
{
    public interface IFieldService
    {
        Task<List<Field>> GetFields();
        Task AddField(Field field);
        Task UpdateField(Field field);
        Task DeleteField(int id);
    }
}