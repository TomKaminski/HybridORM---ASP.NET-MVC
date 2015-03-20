﻿using System.Collections.Generic;

namespace MvcEfRepoPatternExample.ViewModels
{
    public class IndexViewModel
    {
        public AddReportViewModel Report { get; set; }
        public List<IndexListModel> IndexList { get; set; }
    }

    public class IndexListModel
    {
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public string Email { get; set; }
        public string CoAuthorName { get; set; }
        public string CoAuthorLastName { get; set; }
        public string KeeperName { get; set; }
        public string KeeperLastName { get; set; }
        public string ReportTitle { get; set; }
    }
}