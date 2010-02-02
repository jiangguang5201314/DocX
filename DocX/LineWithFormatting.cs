using System.Collections.Generic;

namespace Novacode
{
    public class LineWithFormatting
    {
        public string Text { get; set; }
        public Formatting Formatting { get; set; }
        public IList<TabStop> TabStops { get; set; }
        public Alignment Alignment { get; set; }

        public LineWithFormatting()
        {
            Alignment = Alignment.left;
        }
    }
}