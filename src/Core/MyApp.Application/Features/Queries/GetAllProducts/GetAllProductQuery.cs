using AutoMapper;
using MediatR;
using MyApp.Application.Dto;
using MyApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<List<ProductDto>>
    {

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductDto>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;

            public GetAllProductQueryHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }
            public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                return mapper.Map<List<ProductDto>>(products);
            }
        }
    }
}
