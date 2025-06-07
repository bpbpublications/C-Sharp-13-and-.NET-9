string Weekend(DayOfWeek dayOfWeek)
{
    return dayOfWeek switch
    {
        DayOfWeek.Sunday => "Sunday",
        DayOfWeek.Saturday => "Saturday",
        _ => "It's not weekend!"
    };
}