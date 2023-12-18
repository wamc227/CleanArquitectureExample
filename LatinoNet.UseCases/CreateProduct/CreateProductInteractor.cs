using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateProductOutputPort OutPutPort;

        public CreateProductInteractor(IProductRepository repository, 
                                        IUnitOfWork unitOfWork, 
                                        ICreateProductOutputPort outPutPort) => 
                                        (Repository,UnitOfWork,OutPutPort) = 
                                        (repository,unitOfWork,outPutPort);
        public async Task Handle(CreateProductDTO product)
        {
            Product newProduct = new Product { 
                ProductName=product.ProductName,
                UnitPrice=product.UnitPrice
            };
            Repository.CreateProduct(newProduct);
            await UnitOfWork.SaveChanges();
            await OutPutPort.Handle(
                new ProductDTO
                {
                    ProductId = newProduct.ProductId,
                    ProductName = newProduct.ProductName,
                    UnitPrice = newProduct.UnitPrice
                });
        }
    }
}
