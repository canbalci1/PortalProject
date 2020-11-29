using PortalProject.Abstract;
using PortalProject.Entites;

namespace PortalProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheck
    {

        public bool CustomerCheck(Customer customer)
        {
            if (customer.BirthYear > 1994)
            {
                return true;
            }
            return false;
        }
    }
}
