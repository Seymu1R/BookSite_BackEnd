using Aplication.Dtos;
using Aplication.Features.Comands.CreateBookComand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Book, BookView>()
                .ReverseMap();
            CreateMap<Book, AllBookView>()
                .ReverseMap();
            CreateMap<Book, CreateBookComand>()
                .ReverseMap();
        }
    }
}
