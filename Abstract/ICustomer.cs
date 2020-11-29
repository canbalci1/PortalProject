using PortalProject.Entites;
using PortalProject.Models;

namespace PortalProject.Abstract
{
    public interface ICustomer
    {
        /// <summary>
        /// Müşteri kayıt
        /// </summary>
        /// <param name="customer">customer model</param>
        CustomerResponseModel Save(Customer customer);
    }
}
