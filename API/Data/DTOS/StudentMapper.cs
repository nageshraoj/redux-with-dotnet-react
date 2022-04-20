using API.Models;
using AutoMapper;

namespace API.Data.DTOS;

public static class StudentMapper
{
    public static MapperConfiguration Student()
    {
        var mapper = new MapperConfiguration(config =>
        {
            config.CreateMap<StudentDTO, Student>().ReverseMap();
            config.CreateMap<NewStudentDTO, Student>().ReverseMap();
        });

        return mapper;
    }
}