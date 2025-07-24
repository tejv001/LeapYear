using CheckForLeapYear.Models;
namespace CheckForLeapYear.Managers
{
    public class CheckIfLeapYearManager
    {
        public bool CheckIfYearIsLeapMethod(YearToBeCheckedModel model)
        {
            bool isLeapYear = false;
            int year = model.GetYear();
            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                isLeapYear = true;
            }
            LeapYearResultModel resObj = new LeapYearResultModel(isLeapYear);
            return resObj.GetResult();
        }
    }
}
