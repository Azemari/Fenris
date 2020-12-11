using System;
using ProjectFenris.Models;

namespace ProjectFenris.Utilities
{
    public static class TimeRange
    {
        /// <summary>
        /// Convert the range into a DateTime so we can find out if we need to update the totals for the budget
        /// </summary>
        /// <param name="range">The Date Range between updates</param>
        /// <param name="lastUpdate">To know when we should update the totals</param>
        /// <returns></returns>
        public static DateTime Convert(PeriodRange range, DateTime lastUpdate)
        {
            switch (range)
            {
                case PeriodRange.Once:
                    return lastUpdate;
                case PeriodRange.Daily:
                    return lastUpdate.AddDays(1);
                case PeriodRange.Weekly:
                    return lastUpdate.AddDays(7);
                case PeriodRange.Monthly:
                    return lastUpdate.AddMonths(1);
            }
            throw new Exception("This is not a supported date range");
        }

        public static int DaysUntilNextUpdate(PeriodRange range, DateTime lastUpdated)
        {
            var nextUpdate = Convert(range, lastUpdated);
            if(DateTime.Now >= nextUpdate)
            {
                return -1;
            }
            else
            {
                return DateTime.Now.Subtract(nextUpdate).Days;
            }
        }
    }
}
