using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetWebApi.Models;

namespace NetWebApi.Data
{
	public class SqlNetWebApiRepo : INetWebApiRepo
    {
        private readonly NetWebApiContext _context;

        public SqlNetWebApiRepo(NetWebApiContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException(nameof(cmd));
            
            _context.Commands.Remove(cmd);
        }
    }
}
