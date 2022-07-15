using Application.Domain.Entities;
using AutoMapper;
using MediatR;
using MyApp.Application.Interfaces.Repository;
using MyApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Commands.CreateProductCommand
{
    public class CreateProductCommand:IRequest<ServiceResponse<Guid>>
    {
        public string? Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
        {
            private readonly IProductRepository productRepository;
            private readonly IMapper mapper;
            public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
            {
                this.productRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var productEntity = mapper.Map<Product>(request);
                await productRepository.AddAsync(productEntity);
                return new ServiceResponse<Guid>(productEntity.Id);
            }
        }
    }
}
