using LatinoNet.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCasesPorts
{
    public interface IGetProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
