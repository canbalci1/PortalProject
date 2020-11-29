using PortalProject.Abstract;
using PortalProject.Entites;
using PortalProject.Models;

namespace PortalProject.Concrete
{
    public class Portal : BaseCustomer
    {
        private readonly ICustomerCheck _check;
        public Portal(ICustomerCheck check)
        {
            _check = check;
        }
        public override CustomerResponseModel Save(Customer customer)
        {
            if (_check.CustomerCheck(customer))
            {
                var save = base.Save(customer);
                return save;
            }
            else
            {
                return new CustomerResponseModel()
                {
                    isSave = false,
                    responseMessage = "Yaşınız tutmuyor."
                };
            }
        }
    }
}
