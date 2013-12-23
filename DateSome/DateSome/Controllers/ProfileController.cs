using DateSome.DataAccess;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace DateSome.Controllers
{
    public class ProfileController : Controller
    {
        private readonly DateSomeDbContext _db = new DateSomeDbContext();

        public ActionResult Show(int userProfileId)
        {
            var selectedUserProfile = _db.UserProfiles.Where(up => up.Id == userProfileId).Include(up => up.Hobbies).Single();
            return View(selectedUserProfile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}