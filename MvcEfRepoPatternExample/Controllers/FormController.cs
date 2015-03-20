using System.Linq;
using System.Web.Mvc;
using MvcEfRepoPatternExample.Model;
using MvcEfRepoPatternExample.Service;
using MvcEfRepoPatternExample.ViewModels;

namespace MvcEfRepoPatternExample.Controllers
{
    public class FormController : Controller
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        // GET: Form
        [HttpGet]
        public ActionResult Index()
        {
            return View(new IndexViewModel
            {
                Report = new AddReportViewModel(),
                IndexList = _formService.GetAll().Select(x=>new IndexListModel
                {
                    AuthorLastName = x.AuthorLastName,
                    AuthorName = x.AuthorName,
                    CoAuthorLastName = x.CoAuthorLastName,
                    CoAuthorName = x.CoAuthorName,
                    Email = x.AuthorEmail,
                    KeeperLastName = x.KeeperLastName,
                    KeeperName = x.KeeperName,
                    ReportTitle = x.ReportTitle
                }).ToList()
            });
        }

        [HttpPost]
        public ActionResult Index([Bind(Prefix = "Report")]AddReportViewModel model)
        {
            if (ModelState.IsValid)
            {
                _formService.Create(new Form
                {
                    AuthorLastName = model.AuthorLastName,
                    AuthorName = model.AuthorName,
                    CoAuthorLastName = model.CoAuthorLastName,
                    CoAuthorName = model.CoAuthorName,
                    KeeperLastName = model.KeeperLastName,
                    KeeperName = model.KeeperName,
                    ReportSummary = model.ReportSummary,
                    ReportTitle = model.ReportTitle,
                    UniversityAddress = model.UniversityAddress,
                    UniversityName = model.UniversityName
                });
                return RedirectToAction("Index");
            }
            return View(new IndexViewModel
            {
                Report = model,
                IndexList = _formService.GetAll().Select(x=>new IndexListModel
                {
                    AuthorLastName = x.AuthorLastName,
                    AuthorName = x.AuthorName,
                    CoAuthorLastName = x.CoAuthorLastName,
                    CoAuthorName = x.CoAuthorName,
                    Email = x.AuthorEmail,
                    KeeperLastName = x.KeeperLastName,
                    KeeperName = x.KeeperName,
                    ReportTitle = x.ReportTitle
                }).ToList()
            });
        }
    }
}