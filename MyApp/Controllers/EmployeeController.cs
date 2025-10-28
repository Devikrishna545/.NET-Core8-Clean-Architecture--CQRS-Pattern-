using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpPost("addEmployee")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await mediator.Send(new AddEmployeeCommand(employee));
            return Ok();
        }

        [HttpPost("updateEmployees/{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employee)
        {
            var result = await mediator.Send(new UpdateEmployeeCommand(employeeId, employee));
            return Ok();
        }

        [HttpDelete("deleteEmployees/{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await mediator.Send(new DeleteEmployeeCommand(employeeId));
            return Ok();
        }

        [HttpGet("getEmployeeById/{employeeId}")]
        public async Task<IActionResult> GetEmployeeById([FromRoute] Guid employeeId)
        {
            var result = await mediator.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }

        [HttpGet("getAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await mediator.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }
    }
}
