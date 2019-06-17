using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsDateBefore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        [HttpGet]
        public bool GetIsDate1BeforeDate2(int year1, int month1, int day1, int year2, int month2, int day2)
        {
            bool Year1IsBeforeYear2 = false;
            bool Month1IsBeforeMonth2 = false;
            bool Day1IsBeforeDay2 = false;

            if(IsFirstEqualToSecond(year1, year2) && IsFirstEqualToSecond(month1, month2) && IsFirstEqualToSecond(day1, day2))
            {
                return false;
            }
            if (IsFirstLessThanSecond(year1, year2))
            {
                Year1IsBeforeYear2 = true;
            }
            if (Year1IsBeforeYear2 && IsFirstLessThanSecond(month1, month2))
            {
                Month1IsBeforeMonth2 = true;
            }
            if (Month1IsBeforeMonth2 && IsFirstLessThanSecond(day1, day2))
            {
                 Day1IsBeforeDay2 = true;
            }

            if ((Year1IsBeforeYear2) && !(IsFirstEqualToSecond(year1,year2)))
                return true;
            else if ((Month1IsBeforeMonth2) && !(IsFirstEqualToSecond(month1, month2)))
                return true;
            else if ((Day1IsBeforeDay2) && !(IsFirstEqualToSecond(day1, day2)))
                return true;
            else
                return false;
        }

        private bool IsFirstLessThanSecond(int first, int second)
        {
            if (first <= second)
                return true;
            else
                return false;
            
        }

        private bool IsFirstEqualToSecond(int first, int second)
        {
            if (first == second)
                return true;
            else
                return false;
        }
    }
}