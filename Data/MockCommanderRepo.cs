using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0,HowTo="Boil an egg", Line="Boil water", Platform="Kettle & pan"},
                new Command{Id=2,HowTo="do something else", Line="do it", Platform="pan & pen"},
                new Command{Id=1,HowTo="make tea", Line="Boil water", Platform="teaPot"}
                
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil an egg", Line="Boil water", Platform="Kettle & pen"};
            
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}