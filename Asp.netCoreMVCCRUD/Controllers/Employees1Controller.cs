using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreMVCCRUD.Models;

namespace Asp.netCoreMVCCRUD.Controllers
{
    public class Employees1Controller : Controller
    {
        private readonly EmployeeContext _context;

        public Employees1Controller(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Employees1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

 

        // GET: Employees1/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id==0)
            return View(new Employee());
            else
            return View(_context.Employees.Find(id));

        }

        // POST: Employees1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("employeeId,FullName,LastName,EmpCode,Position,OfficeLocation")] Employee employee)
        {
            if (ModelState.IsValid)
            {
               if(employee.employeeId==0)
                _context.Add(employee);

               else
                    
                    _context.Update(employee);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        // GET: Employees1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

 
    }
}
