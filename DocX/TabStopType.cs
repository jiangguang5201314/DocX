namespace Novacode
{
    public enum TabStopType
    {
        Left,
        Center,
        Right,
        Decimal,
        Bar
    }

    public static class TabStopTypeExtensions
    {
        public static string GetValue(this TabStopType type)
        {
            return type.ToString().ToLower();
        }
    }
}