using eLearning.Models;
using eLearning.Models.ViewModels;
using eLearning.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly DataContext _context;
        private readonly EmailService _emailService;
        public EnrollmentController(DataContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fields = new SelectList(_context.Fields, "Id", "Name");
            return View(new EnrollmentFormViewModel());
        }

        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(EnrollmentFormViewModel viewModel)
        {
            ViewBag.Fields = new SelectList(_context.Fields, "Id", "Name", viewModel.FieldId);

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            // Map ViewModel data to the actual models
            var address = new AddressModel
            {
                State = viewModel.Address.State,
                City = viewModel.Address.City,
                Street = viewModel.Address.Street
            };

            var enrollmentDetails = new EnrollmentDetailsModel
            {
                University = viewModel.EnrollmentDetails.University,
                EnrollmentNumber = viewModel.EnrollmentDetails.EnrollmentNumber,
                Field = viewModel.EnrollmentDetails.Field,
                MarksSecured = viewModel.EnrollmentDetails.MarksSecured
            };

            var enrollmentForm = new EnrollmentFormModel
            {
                Email = viewModel.Email,
                Name = viewModel.Name,
                DateOfBirth = viewModel.DateOfBirth,
                Gender = viewModel.Gender,
                FieldId = viewModel.FieldId,
                Address = address,
                EnrollmentDetails = enrollmentDetails,
                CreatedDate = DateTime.Now,
                EnrollmentCode = Guid.NewGuid().ToString()
            };

            _context.EnrollmentForm.Add(enrollmentForm);
            await _context.SaveChangesAsync();

            var initialStatus = await _context.Status.FirstOrDefaultAsync(s => s.Name == "Pending");

            if (initialStatus != null)
            {
                var enrollmentStatusHistory = new EnrollmentStatusHistory
                {
                    EnrollmentFormId = enrollmentForm.Id,
                    StatusId = initialStatus.Id,
                    ChangedDate = DateTime.Now
                };

                _context.EnrollmentStatus.Add(enrollmentStatusHistory);
                await _context.SaveChangesAsync();
            }

            var subject = "Your Enrollment Code";
            var body = $"Dear {enrollmentForm.Name},<br><br>Your enrollment has been successfully submitted. Your Enrollment Code is: <strong>{enrollmentForm.EnrollmentCode}</strong>.<br><br>Thank you!";

            await _emailService.SendEmailAsync(enrollmentForm.Email, subject, body);

            return RedirectToAction("Success");
        }
    }
}
