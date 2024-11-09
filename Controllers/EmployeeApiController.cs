using ERPCloudMaker.DataBaseContext;
using ERPCloudMaker.ModelRP;
using ERPCloudMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPCloudMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        // GET: api/<EmployeeApiController>
        //[HttpGet]
        //public async Task<List<Employees>> Get()
        //{
        //    List<Employees> lstempdetails = new List<Employees>();
        //    //var UserId = Convert.ToInt32(HttpContext.Session.GetInt32("LoggedInUserID")); 
        //    using (var context = new CloudDBContext())
        //    {
        //        lstempdetails = await context.Employees.ToListAsync();
        //    } 
        //    return lstempdetails;
        //}

        // GET api/<EmployeeApiController>/5
        [HttpGet("{id}")]
        public async Task<Employees> Get(int id)
        {
            //var loggedInUserRole = HttpContext.Session.GetString("LoggedInUserRole");
            //var menuName = "Diagrams";
            //var permission = "Edit";
            //if (!Common.hasPermission(loggedInUserRole, menuName, permission))
            //{
            //    throw new System.Exception("Sorry, you have no permission to access");
            //}
            Employees employees = new Employees();
            using (var context = new CloudDBContext())
            {
                employees = context.Employees.Where(s => s.Id == id).FirstOrDefault<Employees>();
            }
            return employees;
        }

        // POST api/<EmployeeApiController>
        [HttpPost]  
        public async Task<UserCreateResponseRP> Post(Employees employee)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var existingUser = await context.Employees.Where(x => x.EmpName == employee.EmpName).FirstOrDefaultAsync();
                    if (existingUser != null)
                    {
                        var _response = new UserCreateResponseRP
                        {
                            Status = false,
                            UserID = -1,
                            Message = existingUser.EmpName == employee.EmpName ? "Employee Name already exists." : ""
                        };
                        return _response;
                    }

                    var _employee  = new Employees();
                    _employee.EmpID = employee.EmpID;
                    _employee.EmpName = employee.EmpName;
                    _employee.Gender = employee.Gender;
                    _employee.DateofBirth = employee.DateofBirth;
                    _employee.Nationality = employee.Nationality;
                    _employee.Education = employee.Education;
                    _employee.DateofJoining = employee.DateofJoining;
                    _employee.Designation = employee.Designation;
                    _employee.DepName = employee.DepName;
                    _employee.TeamName = employee.TeamName;
                    _employee.Contracttype = employee.Contracttype;
                    _employee.contractexpirydate = employee.contractexpirydate;
                    _employee.DisconnectDate = employee.DisconnectDate;
                    _employee.workingfor = employee.workingfor;
                    _employee.VisaFrom = employee.VisaFrom;
                    _employee.CostCat = employee.CostCat; 
                     
                    _employee.Empaddress = employee.Empaddress;
                    _employee.EmpCity = employee.EmpCity;
                    _employee.Empcontactno = employee.Empcontactno;
                    _employee.emailid = employee.emailid;

                    _employee.Peraddress = employee.Peraddress;
                    _employee.PerCity = employee.PerCity;
                    _employee.Percontactno1 = employee.Percontactno1;
                    _employee.Percontactno2 = employee.Percontactno2;
                    _employee.Peremailid = employee.Peremailid;

                    _employee.RefAddress = employee.RefAddress;                     
                    _employee.RefCity = employee.RefCity;
                    _employee.RefContactNo1 = employee.RefContactNo1;
                    _employee.RefContactNo2 = employee.RefContactNo2;
                    _employee.RefEmailid = employee.RefEmailid;
                    _employee.RefNotes = employee.RefNotes;
                    _employee.barcode = employee.barcode;
                    _employee.IsActive = employee.IsActive;
                    context.Employees.Add(_employee);
                    var result = await context.SaveChangesAsync();

                }
            }
            catch (Exception ex)
            {
                throw;

            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Employee Created Successfully!"
            };

        }


        // PUT api/<EmployeeApiController>/5 
        public async Task<UserCreateResponseRP> Put(Employees employee)
        {
            using (var context = new CloudDBContext())
            {
                Employees _employee = context.Employees.FirstOrDefault(item => item.Id == employee.Id);

                // Validate entity is not null
                if (_employee != null)
                { 
                    _employee.EmpID = employee.EmpID;
                    _employee.EmpName = employee.EmpName;
                    _employee.Gender = employee.Gender;
                    _employee.DateofBirth = employee.DateofBirth;
                    _employee.Nationality = employee.Nationality;
                    _employee.Education = employee.Education;
                    _employee.DateofJoining = employee.DateofJoining;
                    _employee.Designation = employee.Designation;
                    _employee.DepName = employee.DepName;
                    _employee.TeamName = employee.TeamName;
                    _employee.Contracttype = employee.Contracttype;
                    _employee.contractexpirydate = employee.contractexpirydate;
                    _employee.DisconnectDate = employee.DisconnectDate;
                    _employee.workingfor = employee.workingfor;
                    _employee.VisaFrom = employee.VisaFrom;
                    _employee.CostCat = employee.CostCat;

                    _employee.Empaddress = employee.Empaddress;
                    _employee.EmpCity = employee.EmpCity;
                    _employee.Empcontactno = employee.Empcontactno;
                    _employee.emailid = employee.emailid;

                    _employee.Peraddress = employee.Peraddress;
                    _employee.PerCity = employee.PerCity;
                    _employee.Percontactno1 = employee.Percontactno1;
                    _employee.Percontactno2 = employee.Percontactno2;
                    _employee.Peremailid = employee.Peremailid;

                    _employee.RefName = employee.RefName;
                    _employee.RefAddress = employee.RefAddress;
                    _employee.RefCity = employee.RefCity;
                    _employee.RefContactNo1 = employee.RefContactNo1;
                    _employee.RefContactNo2 = employee.RefContactNo2;
                    _employee.RefEmailid = employee.RefEmailid;
                    _employee.RefNotes = employee.RefNotes;

                    _employee.EmpPersonalID= employee.EmpPersonalID;
                    _employee.bankcode = employee.bankcode;
                    _employee.bankacno = employee.bankacno;
                    _employee.Basicsalary = employee.Basicsalary;
                    _employee.rateperhour = employee.rateperhour;
                    _employee.SalaryType = employee.SalaryType;


                    _employee.empbankname= employee.empbankname;
                    _employee.empbankacno = employee.empbankacno;
                    _employee.empbankbranch = employee.empbankbranch;
                    _employee.bankifsccode = employee.bankifsccode;
                    _employee.bankmicrcode = employee.bankmicrcode;
                    _employee.barcode = employee.barcode;
                    _employee.IsActive = employee.IsActive;
                    // Save changes in database
                    var result = context.SaveChanges();
                }
            }
            return new UserCreateResponseRP
            {
                Status = true,
                UserID = 1,
                Message = "Employee updated Successfully!"
            };
        }

        // DELETE api/<EmployeeApiController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                using (var context = new CloudDBContext())
                {
                    var doc = context.Employees.Where(s => s.Id == id).FirstOrDefault<Employees>();
                    if (doc != null)
                    {
                        context.Employees.Remove(doc);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting Employee");
            }
        }

        [HttpGet]
        public async Task<List<Employees>> Get()
        {
            using (var context = new CloudDBContext())
            {
                var lstEmpdetails = await (from employee in context.Employees
                                           select new Employees
                                           {
                                               Id = employee.Id,
                                               EmpName = employee.EmpName,
                                               EmpID = employee.EmpID,
                                               Gender = employee.Gender,
                                               Designation = employee.Designation,
                                               emailid = employee.emailid,
                                               Empaddress = employee.Empaddress,
                                               Empcontactno = employee.Empcontactno,
                                               IsActive = employee.IsActive
                                           }).ToListAsync();

                return lstEmpdetails;
            }
        }



        [HttpDelete]
        public async Task<IActionResult> DeleteEmployees([FromBody] DeleteRequest request)
        {
            if (request?.Ids == null || !request.Ids.Any())
            {
                return BadRequest(new { success = false, message = "No IDs provided for deletion." });
            }
            try
            {
                using (var context = new CloudDBContext())
                {
                    var employeesToDelete = await context.Employees
                    .Where(employee => request.Ids.Contains(employee.Id))
                    .ToListAsync();

                    if (employeesToDelete.Any())
                    {
                        context.Employees.RemoveRange(employeesToDelete);
                        await context.SaveChangesAsync();
                        return Ok(new { success = true, message = "Employees successfully deleted." });
                    }
                    else
                    {
                        return NotFound(new { success = false, message = "No matching employees found." });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "An error occurred.", details = ex.Message });
            }
        }

    }
}
