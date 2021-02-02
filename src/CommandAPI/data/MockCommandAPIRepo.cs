using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public bool SaveChanges() { throw new System.NotImplementedException(); }
        public IEnumerable<Command> GetAllCommands() { throw new System.NotImplementedException(); }
        public void CreateCommand(Command cmd) { throw new System.NotImplementedException(); }
        public void UpdateCommand(Command cmd) { throw new System.NotImplementedException(); }
        public void DeleteCommand(Command cmd) { throw new System.NotImplementedException(); }
    }
}