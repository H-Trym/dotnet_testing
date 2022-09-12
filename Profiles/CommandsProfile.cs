using AutoMapper;
using dotnetTest.Models;
using dotnetTest.DTO;

namespace dotnetTest.Profiles 
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}