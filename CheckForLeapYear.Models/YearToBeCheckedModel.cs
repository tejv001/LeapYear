namespace CheckForLeapYear.Models
{
    public class YearToBeCheckedModel
    {
        private int _year;

        public YearToBeCheckedModel(int year)
        {
            _year = year;
        }

        public int GetYear()
        {
            return _year;    
        }
    }
}
