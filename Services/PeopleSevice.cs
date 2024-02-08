using Data_People_C_Sharp.Models;

namespace Data_People_C_Sharp.Services
{
    public class PeopleSevice : IPeopleService
    {
        private List<People> people = new List<People>()
        {
            new People(){id=1, name="fabith", age=29},
            new People(){id=2, name="isabela", age=27}
        };
        public People? Get(int id) => people.FirstOrDefault(p => p.id == id);
        

        public IEnumerable<People> Get() => people;
    }

}
