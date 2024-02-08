using Data_People_C_Sharp.Models;

namespace Data_People_C_Sharp.Services
{
    public interface IPeopleService
    {
        public IEnumerable<People>Get();

        public People? Get(int id);

    }
}
