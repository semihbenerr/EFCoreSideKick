using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreSideKick.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public EmployeeController(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            var employees = _dataContext.Employees.ToList();
            var employeModel = _mapper.Map<List<ResultEmployeeDTO>>(employees);
            return View(employeModel);
        } 
    }
}
