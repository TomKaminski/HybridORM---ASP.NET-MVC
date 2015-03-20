using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Model
{
    public class Form:Entity<int>
    {
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public string CoAuthorName { get; set; }
        public string CoAuthorLastName { get; set; }
        public string KeeperName { get; set; }
        public string KeeperLastName { get; set; }
        public string UniversityName { get; set; }
        public string UniversityAddress { get; set; }
        public string ReportTitle { get; set; }
        public string ReportSummary { get; set; }
        public string AuthorEmail { get; set; }
    }
}
