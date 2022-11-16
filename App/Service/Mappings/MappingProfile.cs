using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Book;
using Service.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappings
{
    public class MappingProfile :Profile
    {
        
        public MappingProfile()
        {
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();

            CreateMap<BookListDto, Book>();
            CreateMap<Book, BookCreateAndUpdateDto>();
            CreateMap<BookCreateAndUpdateDto, Book>().ReverseMap();
        }
    }
}
