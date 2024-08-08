using Application.Features.Products.Command;
using Application.Features.Products.Query.GetProductById;
using Application.Features.Products.Query.GetProductList;
using AutoMapper;
using Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductsVm>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }

    }
}
