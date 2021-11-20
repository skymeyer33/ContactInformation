using ContactInformation.Models;
using ContactInformation.Repos.Interfaces;

namespace ContactInformation.Repos
{
    public class ContactInformationRepo : IContactInformationRepo
    {
        private static IList<Employee> employeesContactInformation = new List<Employee>();
        private static readonly ContactInformationRepo contactInformationRepo = new ContactInformationRepo();
        public Employee GeContactInformation(int employeeId)
        {
           return  employeesContactInformation.FirstOrDefault(x => x.EmployeedId == employeeId);     
        }

        public void SaveContactInformation(Employee employee)
        {
            employeesContactInformation.Add(employee);
        }
    }
}
