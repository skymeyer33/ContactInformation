using ContactInformation.Models;
using ContactInformation.Repos.Interfaces;
using ContactInformation.Services.Interfaces;

namespace ContactInformation.Services
{
    public class ContactInformationService : IContactInformationService
    {
        private IContactInformationRepo contactInformationRepo { get; set; }
        public ContactInformationService(IContactInformationRepo _contactInformationRepo)
        {
            contactInformationRepo = _contactInformationRepo;
        }
       public Employee GetContactInformation(int employeeId)
        {
            return contactInformationRepo.GeContactInformation(employeeId);
        }

       public  bool SaveContactInformation(Employee employee)
        {
            bool saveSuccessful = true;
            try
            {

                 contactInformationRepo.SaveContactInformation(employee);
            }
            catch (Exception ex)
            {
                saveSuccessful = false;
            }
            return saveSuccessful;
        }
    }
}