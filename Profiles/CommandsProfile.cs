using AutoMapper;
using NetWebApi.Dtos;
using NetWebApi.Models;

namespace NetWebApi.Profiles
{
	public class CommandsProfile : Profile
	{
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
	}
}
