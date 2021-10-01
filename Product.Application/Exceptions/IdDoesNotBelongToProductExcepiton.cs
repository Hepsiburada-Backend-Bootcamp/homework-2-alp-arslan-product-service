using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductNS.Application.Exceptions
{
    public class IdDoesNotBelongToProductExcepiton : BadRequestException
    {
        public IdDoesNotBelongToProductExcepiton(int id, string name)
            : base($"The id: {id} does not belong to the product: {name}.")
        {
        }
    }
}
