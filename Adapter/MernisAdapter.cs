using System;
using PortalProject.Abstract;
using PortalProject.Entites;
using PortalProject.MernisServiceReference;

namespace PortalProject.Adapter
{
    public class MernisAdapter : ICustomerCheck
    {
        /// <summary>
        /// Mernis Doğrulama
        /// </summary>
        public bool CustomerCheck(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.IdentyNumber), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthYear);
        }
    }
}
