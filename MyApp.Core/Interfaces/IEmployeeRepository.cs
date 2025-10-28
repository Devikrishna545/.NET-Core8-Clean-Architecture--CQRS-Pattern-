using MyApp.Core.Entities;

namespace MyApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<EmployeeEntity>> GetAllEmployees();        

        public Task<EmployeeEntity> GetEmployeeById(Guid Id);
       
        public Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity);       

        public Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity);       

        public Task<bool> DeleteEmployeeAsync(Guid employeeId);        
    }
}
