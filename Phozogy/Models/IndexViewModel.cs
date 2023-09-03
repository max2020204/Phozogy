using System.Collections.Generic;

namespace Phozogy.Models
{
    public class IndexViewModel
    {
        public IEnumerable<BlogModel> Blog { get; set; }
        public PageViewModel PageView { get; set; }
    }
}