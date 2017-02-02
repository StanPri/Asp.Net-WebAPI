using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    class ProductServices : IProductServices
    {

        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public ProductServices()
        {
            _unitOfWork = new UnitOfWork();
        }
    }
}
