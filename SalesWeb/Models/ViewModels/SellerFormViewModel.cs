namespace SalesWeb.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
        public SellerFormViewModel()
        {
            Departments = new List<Department>();
        }
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void RemoveDepartment(Department department)
        {
            Departments.Remove(department);
        }
    }
}
