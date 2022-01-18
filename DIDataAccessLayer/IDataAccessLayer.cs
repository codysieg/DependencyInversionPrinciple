using DIDataAccessLayer.Models;

namespace DIDataAccessLayer
{
    public interface IDataAccessLayer
    {
        void CompleteChore(IChore chore);
        void StartChore(IChore chore);
    }
}