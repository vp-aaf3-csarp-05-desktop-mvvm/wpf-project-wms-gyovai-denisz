namespace WMS_Project
{
    public class EmployeeViewModel
    {
        public string Name { get; } = "Nagy Anna";  // {get; }: más osztályok lekérhetik
        public string Adoszam { get; } = "1234567890";
        public int Szabadnapok { get; } = 10;
    }
}
