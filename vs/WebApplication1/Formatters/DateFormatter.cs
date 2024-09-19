namespace WebApplication1.Formatters
{
    public class DateFormatter
    {
        public string DateToStrng(DateTime dt)
        {
            return dt.ToString("yyyy.MM.dd");
        }
    }
}
