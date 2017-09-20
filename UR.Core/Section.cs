using System;
using System.Collections.Generic;
using System.Text;

namespace UR.Core
{
    public class Section
    {
        public string Title { get; set; }
        public string Index { get; set; }
        public List<Section> SubSections { get; set; }
    }
}
