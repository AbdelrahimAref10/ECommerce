using CSharpFunctionalExtensions;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Query.GetProductById
{
    public sealed record GetProductByIDQuery : IRequest<Result<ProductByIdVm>>
    {
        public int ProductId { get; set; }
        private class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, Result<ProductByIdVm>>
        {
            private readonly DatabaseContext _context;

            public GetProductByIDQueryHandler(DatabaseContext context)
            {
                _context = context;
            }
            public async Task<Result<ProductByIdVm>> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
            {
                var product = await _context.Products.Where(p => request.ProductId == p.ProductId)
                    .Select(a => new ProductByIdVm
                    {
                        ProductId = a.ProductId,
                        ProductName = a.ProductName,
                        ProductDescription = a.ProductDescription,
                        Price = a.Price,
                        CategoryName = a.Category.CategoryName
                    }).FirstOrDefaultAsync();

                if (product is null)
                {
                    return Result.Failure<ProductByIdVm>("Product not found");
                }

                return Result.Success(product);

            }
        }

    }
}
