namespace Novacode
{
    public class TabStop
    {
        public TabStop()
        {
        }

        public TabStop(int position)
        {
            Position = position;
        }

        public TabStop(int position, TabStopType type)
        {
            Position = position;
            Type = type;
        }

        public int Position { get; set; }
        public TabStopType Type { get; set; }
    }
}