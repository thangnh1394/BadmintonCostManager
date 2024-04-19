using CostManager.Pwa.Models;

namespace CostManager.Pwa.Services
{
    public class FieldService: IFieldService
    {
         private List<Field> _fields = new List<Field>();

        public Task<List<Field>> GetFields()
        {
            return Task.FromResult(_fields);
        }

        public Task AddField(Field field)
        {
            _fields.Add(field);
            return Task.CompletedTask;
        }

        public Task UpdateField(Field field)
        {
            var index = _fields.FindIndex(f => f.Id == field.Id);
            if (index == -1)
            {
                throw new ArgumentException("Field not found");
            }
            _fields[index] = field;
            return Task.CompletedTask;
        }

        public Task DeleteField(int id)
        {
            var field = _fields.FirstOrDefault(f => f.Id == id);
            if (field == null)
            {
                throw new ArgumentException("Field not found");
            }
            _fields.Remove(field);
            return Task.CompletedTask;
        }
    }
}