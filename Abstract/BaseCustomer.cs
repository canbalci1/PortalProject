using PortalProject.Entites;
using PortalProject.Models;

namespace PortalProject.Abstract
{
    public abstract class BaseCustomer:ICustomer
    {
        public virtual CustomerResponseModel Save(Customer customer)
        {
            //Veritabanı işlemleri yapıldığı yer.
            return new CustomerResponseModel(){isSave = true,responseMessage = "Kayıt Başarılı"};
        }
    }
}
