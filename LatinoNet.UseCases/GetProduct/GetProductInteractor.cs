using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetProduct
{
    public class GetProductInteractor:IGetProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetProductOutputPort OutPutPort;

        public GetProductInteractor(IProductRepository repository, IGetProductOutputPort outPutPort)
        {
            Repository = repository;
            OutPutPort = outPutPort;
        }

        public Task Handle(int productId)
        {
            var product = Repository.GetProduct(productId);
            var productOutputPort = new ProductDTO { ProductId=product.ProductId, ProductName=product.ProductName, UnitPrice=product.UnitPrice};
            OutPutPort.Handle(productOutputPort);
            return Task.CompletedTask;
        }
    }
}
