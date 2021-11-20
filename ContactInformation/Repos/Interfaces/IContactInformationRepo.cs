using ContactInformation.Models;

namespace ContactInformation.Repos.Interfaces
{
    public interface IContactInformationRepo
    {
        public void SaveContactInformation(Employee employee);
        public Employee GeContactInformation(int employeeId);
    }
}
