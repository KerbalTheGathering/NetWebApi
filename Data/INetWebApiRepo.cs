using System.Collections;
using System.Collections.Generic;
using NetWebApi.Models;

namespace NetWebApi.Data
{
	public interface INetWebApiRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
