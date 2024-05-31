using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.TryParse(appointmentDateDescription, out DateTime result) ? result : DateTime.Now;

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate.Ticks < DateTime.Now.Ticks? true : false;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18 ? true : false;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString()}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
}
