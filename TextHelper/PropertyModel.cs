using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextHelper
{
    public class PropertyModel
    {
        public string Access { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public string Description { get;  set; }
        public bool Nullable { get; set; }
    }
}
