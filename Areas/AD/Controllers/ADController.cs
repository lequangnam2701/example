using Microsoft.AspNetCore.Mvc;
using eLearning.Models;
using eLearning.Repository;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Areas.Admin.Controllers
{
    [Area("AD")]
    public class ADController : Controller
    {
        private readonly DataContext _context;

        public ADController(DataContext context)
        {
            _context = context;
        }

        // GET INDEX
        public IActionResult Index()
        {
            var enrollments = _context.EnrollmentForm.ToList();
            return View(enrollments);
        }

         // GET EDIT
        public async Task<IActionResult> Edit(int id)
        {
            var enrollmentForm = await _context.EnrollmentForm
                .Include(e => e.EnrollmentDetails)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (enrollmentForm == null)
            {
                return NotFound();
            }

            return View(enrollmentForm);
        }

        // POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EnrollmentCode,Email,Name,DateOfBirth,Gender,FieldId,EnrollmentDetailsId,AddressId,CreatedDate")] EnrollmentFormModel enrollmentForm)
        {
            if (id != enrollmentForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollmentForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollmentFormExists(enrollmentForm.Id))
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
            return View(enrollmentForm);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var enrollmentForm = await _context.EnrollmentForm.FindAsync(id);
            if (enrollmentForm != null)
            {
                _context.EnrollmentForm.Remove(enrollmentForm);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        private bool EnrollmentFormExists(int id)
        {
            return _context.EnrollmentForm.Any(e => e.Id == id);
        }



        // DISPLAY DETAIL
        public IActionResult Detail(int id)
        {
            var enrollmentForm = _context.EnrollmentForm
                                        .Include(e => e.EnrollmentDetails)  
                                        .FirstOrDefault(e => e.Id == id);

            if (enrollmentForm == null)
            {
                return NotFound();
            }

            return View(enrollmentForm); 
        }

        // EDIT
        [HttpGet]
        public IActionResult Edit_Detail(int id)
        {
        var enrollmentForm = _context.EnrollmentForm
                                    .Include(e => e.EnrollmentDetails)
                                    .FirstOrDefault(e => e.Id == id);

        if (enrollmentForm == null)
        {
            return NotFound();
        }

        return View(enrollmentForm);
         }
            
                                      



    }
}
