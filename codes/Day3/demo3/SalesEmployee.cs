using System;
namespace HR
{
    public class SalesEmployee:Employee
    {
        public float commission { set; get; }

        public SalesEmployee(int id, string dept, float salary, float basicsalary, int workingdays, float commission):base(id, dept, salary, basicsalary, workingdays)
        {
            this.commission = commission;
        }

        public override float CalculateSalary()
        {
            return base.CalculateSalary()+this.commission;
        }

        public override string ToString()
        {
            return base.ToString()+" "+this.commission;
        }
    }
}
