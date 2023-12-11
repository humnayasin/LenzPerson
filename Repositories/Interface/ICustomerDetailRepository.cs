using LenzPerson.api.Models.DomainModels;

namespace LenzPerson.api.Repositories.Interface
{
    public interface ICustomerDetailRepository
    {


        Task<CustomerDetail> CreateCustomer(CustomerDetail request);

    }
}
