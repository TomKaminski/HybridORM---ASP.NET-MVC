using System;
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
        private const int PageSize = 2;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        // GET: Form
        [HttpGet]
        public ActionResult Index(int id=1)
        {
            return View(new IndexViewModel
            {
                Report = new AddReportViewModel(),
                IndexList = _formService.GetPagedList(id,PageSize).Select(x=>new IndexListModel
                {
                    AuthorLastName = x.AuthorLastName,
                    AuthorName = x.AuthorName,
                    CoAuthorLastName = x.CoAuthorLastName,
                    CoAuthorName = x.CoAuthorName,
                    Email = x.AuthorEmail,
                    KeeperLastName = x.KeeperLastName,
                    KeeperName = x.KeeperName,
                    ReportTitle = x.ReportTitle,
                    Id = x.Id
                }).ToList(),
                PagingHelper = new PagingHelper
                {
                    ActualPage = id,
                    TotalPages = Math.Ceiling(Convert.ToDouble(_formService.GetCount()) / Convert.ToDouble(PageSize))
                }
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
                IndexList = _formService.GetPagedList(1, PageSize).Select(x => new IndexListModel
                {
                    AuthorLastName = x.AuthorLastName,
                    AuthorName = x.AuthorName,
                    CoAuthorLastName = x.CoAuthorLastName,
                    CoAuthorName = x.CoAuthorName,
                    Email = x.AuthorEmail,
                    KeeperLastName = x.KeeperLastName,
                    KeeperName = x.KeeperName,
                    ReportTitle = x.ReportTitle,
                    Id = x.Id
                }).ToList(),
                PagingHelper = new PagingHelper
                {
                    ActualPage = 1,
                    TotalPages = Math.Ceiling(Convert.ToDouble(_formService.GetCount()) / Convert.ToDouble(PageSize))
                }
            });
        }

        public ActionResult ReportDetails(int id)
        {
            var form = _formService.GetFormDetails(id);
            return View(new DetailsViewModel
            {
                AuthorName = form.AuthorName,
                CoAuthorName = form.CoAuthorName,
                AuthorLastName = form.AuthorLastName,
                KeeperLastName = form.KeeperLastName,
                KeeperName = form.KeeperName,
                CoAuthorLastName = form.CoAuthorLastName,
                ReportTitle = form.ReportTitle,
                ReportDescription = form.ReportSummary,
                Email = form.AuthorEmail,
                UniversityAddress = form.UniversityAddress,
                UniversityName = form.UniversityName
            });
        }
    }
}