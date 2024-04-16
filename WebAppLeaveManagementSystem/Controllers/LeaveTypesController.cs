using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppLeaveManagementSystem.Data;
using WebAppLeaveManagementSystem.Models;

namespace WebAppLeaveManagementSystem.Controllers
{
    public class LeaveTypesController : Controller
    {
        //Dependency Injection
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper; //Data Model to View model DI

        public LeaveTypesController(ApplicationDbContext context, IMapper Mapper) //context will hold the connection
        {
            _context = context; //Connection is passed to _context field
            this.mapper = Mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index() //Asynchronous Task returns IActionResults(Allows to return Views)
        {
            //return View(await _context.LeaveTypes.ToListAsync()); // Select * from LeaveTypes; -- LeaveTypes Table is connected to DbContext
                                                                  // connect to db > Select * from LeaveTypes > Push values to List : EF Core            
                                                                    //var LeaveTypes = (await _context.LeaveTypes.ToListAsync()); 
            var LeaveTypes = mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync()); // Data Model to View Model -- Everything should be in List to casting to List type
            return View(LeaveTypes);
                                                                  //return _context.LeaveTypes != null ? 
                                                                  //          View(await _context.LeaveTypes.ToListAsync()) :
                                                                  //          Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]  //security
        public async Task<IActionResult> Create(LeaveTypeVM LeaveTypeVM) //public async Task<IActionResult> Create([Bind("Name,DefaultDays,Id,DateCreated,DateModified")] LeaveTypeVM LeaveTypeVM) Removing Bind use Automapper to map the data to correct datatypes
        {
            if (ModelState.IsValid)
            {
                var LeaveType = mapper.Map<LeaveTypeVM>(LeaveTypeVM); //We here changed leaveType to LeavetypeVM and since we dont have leavetypeVm data in db so we will use auto mapper to change incoming data of type LeavetypeVM to LeaveType and then add that to Database
                _context.Add(LeaveType); //Add or create 
                await _context.SaveChangesAsync(); //savechanges or commit
                return RedirectToAction(nameof(Index));
            }
            return View(LeaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            return View(leaveType);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,DefaultDays,Id,DateCreated,DateModified")] LeaveType leaveType)
        {
            if (id != leaveType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveTypeExists(leaveType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveType);
        }

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeaveTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
            }
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveTypeExists(int id)
        {
          return (_context.LeaveTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
