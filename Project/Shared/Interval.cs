using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Shared
{
    public record Interval

    {
        //public bool IsOverlapping(Interval otherInterval)
        //{
        //    if (otherInterval == null)
        //        throw new ArgumentNullException(nameof(otherInterval));
        //    return (StartDate <= otherInterval.StartDate && StartDate <= otherInterval.EndDate.GetValueOrDefault(DateTime.MaxValue.TimeOfDay))
        //                    || (otherInterval.StartDate <= StartDate && otherInterval.StartDate <= EndDate.GetValueOrDefault(DateTime.MaxValue.TimeOfDay));
        //}
        [Column(name: "StartDate")]
        public DateOnly StartDate { get; private set; }

        [Column(name: "EndDate")]
        public DateOnly? EndDate { get; set; }
        public int? IntervalLength
        {
            get
            {
                return (EndDate.HasValue ? EndDate.Value.Day - StartDate.Day : 0);
            }
        }
        public override string ToString()
        {
            if (EndDate.HasValue)
                return $"{StartDate.ToString("HH:mm")} - {EndDate.Value.ToString("HH:mm")}";
            else
                return $"{StartDate.ToString("HH:mm")} - Infinite";
        }
        public Interval(DateOnly StartDate, DateOnly? EndDate)
        {
            if (EndDate.HasValue && (EndDate.Value < StartDate))
                throw new Exception("the start date can not exceed the end date ");

            this.StartDate = StartDate;

            this.EndDate = EndDate.HasValue ? EndDate : null;
        }

    }
}
// ---> 5 days
// --->  tomorrow overlap 
//race condition (two or more users Access the same record at the same time and modifiy it)

