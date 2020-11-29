using PortalProject.Abstract;
using PortalProject.Entites;
using PortalProject.Models;

namespace PortalProject.Concrete
{
    public class Starbucks : BaseCustomer
    {
        private ICustomerCheck _customerCheck;

        public Starbucks(ICustomerCheck customerCheck)
        {
            _customerCheck = customerCheck;
        }

        public override CustomerResponseModel Save(Customer customer)
        {
            if (_customerCheck.CustomerCheck(customer))
            {
                var save = base.Save(customer);
                return save;
            }
            else
            { 
                return new CustomerResponseModel()
                {
                    isSave = false,
                    responseMessage = "Tc doğrulamanız başarısız olmuştur."
                };
            }
        }


    }
}
