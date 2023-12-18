using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutPutPort;

        public GetAllProductsInteractor(IProductRepository repository,
                                        IGetAllProductsOutputPort outPutPort) =>
                                        (Repository, OutPutPort) =
                                        (repository, outPutPort);

        public Task Handle()
        {
            var Products = Repository.GetAll().Select(p =>
            new ProductDTO
            {
                ProductId=p.ProductId,
                ProductName=p.ProductName,
                UnitPrice=p.UnitPrice
            });
            OutPutPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
