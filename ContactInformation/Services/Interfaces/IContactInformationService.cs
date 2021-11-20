using ContactInformation.Models;

namespace ContactInformation.Services.Interfaces
{
    public interface IContactInformationService
    {
        public bool SaveContactInformation(Employee employee);
        public Employee GetContactInformation(int employeeId);
    }
}
