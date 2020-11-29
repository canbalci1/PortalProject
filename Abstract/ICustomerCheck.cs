using PortalProject.Entites;

namespace PortalProject.Abstract
{
    public interface ICustomerCheck
    {
        /// <summary>
        /// Mernis müşteri sorgulama
        /// </summary>
        /// <param name="customer"></param>
        bool CustomerCheck(Customer customer);
    }
}
