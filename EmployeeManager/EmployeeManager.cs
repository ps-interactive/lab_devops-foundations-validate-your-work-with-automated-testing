namespace EmployeeManager
{
    public static class EmployeeManager
    {
        public static string GetEmployeeFriendlyName(Employee employee)
        {
            return employee.FirstName + employee.LastName;
        }
    }
}