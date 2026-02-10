namespace WMS_Project
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";  // {get; }: más osztályok lekérhetik
        
        /// <summary>
        /// Adószám
        /// </summary>
        public string TaxNumber { get; } = "1234567-8-90";

        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int DaysOff { get; } = 10;
    }
}
