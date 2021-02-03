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
        new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
        new Command { Id = 1, HowTo = "Cut bread", Line = "Cut bread", Platform = "Table" },
        new Command { Id = 2, HowTo = "Get a knife", Line = "Get knife", Platform = "Table" },
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
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
