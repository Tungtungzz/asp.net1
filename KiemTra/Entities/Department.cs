using System.Collections.Generic;

namespace KiemTra.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public string Location { get; set; }
        public int NumberOfPersonals { get; set; }

        // Navigation property
        public ICollection<Employee>? Employees { get; set; }
    }
}
