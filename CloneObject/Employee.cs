namespace CloneObject
{
    public enum EmployeeType
    {
        Fulltime,
        Contract
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public byte[] Signature { get; set; }
        public EmployeeType Type { get; set; }

    }
}
