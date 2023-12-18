using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductController
    {
        readonly IGetProductInputPort InputPort;
        readonly IGetProductOutputPort OutputPort;

        public GetProductController(IGetProductInputPort inputPort, IGetProductOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpGet]
        public async Task<ProductDTO> GetProduct(int productId)
        {
            await InputPort.Handle(productId);
            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }
    }
}
