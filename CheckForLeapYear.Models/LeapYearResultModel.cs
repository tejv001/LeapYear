using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForLeapYear.Models
{
    public class LeapYearResultModel
    {
        private bool _isLeapYear;
        public LeapYearResultModel(bool isLeapyear)
        {
            _isLeapYear = isLeapyear;
        }

        public bool GetResult()
        {
            return _isLeapYear;
        }
    }
}
