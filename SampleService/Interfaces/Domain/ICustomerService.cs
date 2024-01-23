

public interface ICustomerService{

    public List<string> GetAllCustomer();
    public Dictionary<string,int> GetCustomerByIdWithEmployeeCode(int id);
}