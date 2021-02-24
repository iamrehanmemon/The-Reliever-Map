using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TheRelieverMap.Models;
using TheRelieverMap.ViewModels;

namespace TheRelieverMap.Controllers
{
    public class AddToiletController : Controller
    {
        private ApplicationDbContext _context;
        public AddToiletController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult ViewToilet()
        {
            var viewtoilet = _context.AddToilets.Include(v => v.Provider)
                .Include(v => v.Type).Include(v => v.State).Include(v => v.Compatibility)
                .Where(v => !v.IsCancelled);

            return View(viewtoilet);
        }


        //Edit and Update a Toilet

        [Authorize]
        public ActionResult MyToilet()
        {
            var userId = User.Identity.GetUserId();
            var toilet = _context.AddToilets.Where(t => t.Provider.Id == userId && !t.IsCancelled)
                .Include(t => t.Type).Include(t => t.State).Include(t => t.Compatibility)
                .ToList();

            return View(toilet);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var userId = User.Identity.GetUserId();
            var edit = _context.AddToilets.SingleOrDefault(e => e.Id == id && e.Provider.Id == userId);

            var viewModel = new AddToiletViewModel
            {
                Heading = "Edit Toilet Details",
                Id = edit.Id,
                Types = _context.ToiletTypes.ToList(),
                States = _context.States.ToList(),
                Compatible = _context.CompatibleFor.ToList(),
                Type = edit.Type.Id,
                State = edit.State.Id,
                Compatibility = edit.Compatibility.Id,
                Name = edit.Name,
                Address = edit.Address,
                City = edit.City

            };
            return View("Add", viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(AddToiletViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.ToiletTypes.ToList();
                viewModel.States = _context.States.ToList();
                viewModel.Compatible = _context.CompatibleFor.ToList();
                return View("Add", viewModel);
            }

            var userId = User.Identity.GetUserId();
            var update = _context.AddToilets.SingleOrDefault(u => u.Id == viewModel.Id && u.Provider.Id == userId);
            var type = _context.ToiletTypes.SingleOrDefault(t => t.Id == viewModel.Type);
            var state = _context.States.SingleOrDefault(s => s.Id == viewModel.State);
            var compatibility = _context.CompatibleFor.SingleOrDefault(c => c.Id == viewModel.Compatibility);

            update.Name = viewModel.Name;
            update.City = viewModel.City;
            update.Address = viewModel.Address;
            update.State = state;
            update.Type = type;
            update.Compatibility = compatibility;

            _context.SaveChanges();

            return RedirectToAction("MyToilet", "AddToilet");
        }

        //Add a Toilet

        [Authorize]
        public ActionResult Add()
        {
            var viewModel = new AddToiletViewModel
            {
                Types = _context.ToiletTypes.ToList(),
                States = _context.States.ToList(),
                Compatible = _context.CompatibleFor.ToList(),
                Heading = "Add a Toilet"
            };
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddToiletViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.ToiletTypes.ToList();
                viewModel.States = _context.States.ToList();
                viewModel.Compatible = _context.CompatibleFor.ToList();
                return View("Add", viewModel);
            }


            var providerId = User.Identity.GetUserId();
            var provider = _context.Users.SingleOrDefault(u => u.Id == providerId);
            var type = _context.ToiletTypes.SingleOrDefault(t => t.Id == viewModel.Type);
            var state = _context.States.SingleOrDefault(s => s.Id == viewModel.State);
            var compatibility = _context.CompatibleFor.SingleOrDefault(c => c.Id == viewModel.Compatibility);

            var toilet = new AddToilet
            {
                Provider = provider,
                Name = viewModel.Name,
                Type = type,
                State = state,
                City = viewModel.City,
                Address = viewModel.Address,
                Compatibility = compatibility
            };
            _context.AddToilets.Add(toilet);
            _context.SaveChanges();

            return RedirectToAction("ViewToilet", "AddToilet");
        }
    }
}