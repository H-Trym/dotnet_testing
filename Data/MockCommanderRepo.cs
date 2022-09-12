using dotnetTest.Models;

namespace dotnetTest.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="folk har ikke hørt espen vaular rappe", Line="nå har de det", Platform="youtube nachspill"},
                new Command{Id=1, HowTo="all my friends are dead", Line="push me to the edge", Platform="spotify"},
                new Command{Id=2, HowTo="egodød e vanskelig", Line="gråsonen", Platform="Linni"},
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=0, HowTo="boil an egg", Line="boil wa er", Platform="kettle"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}