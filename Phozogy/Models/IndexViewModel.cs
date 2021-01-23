using Phozogy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phozogy.Models
{
    public class IndexViewModel
    {
        public IEnumerable<BlogModel> Blog { get; set; }
        public PageViewModel PageView { get; set; }
    }
}
