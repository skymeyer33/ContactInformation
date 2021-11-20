using ContactInformation.Models;
using ContactInformation.Repos.Interfaces;
using ContactInformation.Services;
using ContactInformation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContactInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationController : ControllerBase
    {
        public IContactInformationService contactInformationService { get; set; }
        public ContactInformationController(IContactInformationRepo contactInformationRepo)
        {
            contactInformationService = new ContactInformationService(contactInformationRepo);
        }

        [HttpPost]
        public ActionResult CreateContact(Employee employee)
        {
          bool saveSuccessful =  contactInformationService.SaveContactInformation(employee);
            if (saveSuccessful)
                return CreatedAtAction("GetContactInformation", employee.EmployeedId);
            else
                throw new Exception("client not saved");
        }

        [HttpGet]
        public ActionResult GetContactInformation(int employeeId)
        {
            Employee employee = contactInformationService.GetContactInformation(employeeId);
            if (employee != null)
                return new JsonResult(employee);
            else
                return NotFound(employeeId);
        }
    }
}
