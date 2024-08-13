namespace KiemTra.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string Rank { get; set; }

        // Foreign key
        public int DepartmentId { get; set; }

        // Navigation property
        public Department? Department { get; set; }
    }
}
