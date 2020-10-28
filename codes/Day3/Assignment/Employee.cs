using System;
namespace HR
{
    public class Employee:Person
    {
        public int id { get; set; }
        public  string dept { get; set; }
        public  float salary { get; set; }
        public float basicsalary { get; set; }
        public int workingdays { get; set; }


        public Employee():base()
        {
        }

        public Employee(int id, string dept, float salary, float basicsalary, int workingdays)
        {
            this.id = id;
            this.dept = dept;
            this.salary = salary;
            this.basicsalary = basicsalary;
            this.workingdays = workingdays;
        }

      

        public virtual float CalculateSalary() {
            return salary = this.basicsalary + (100 * this.workingdays);

        }

        public override string ToString()
        {
            return base.ToString() + this.id + " " + " " + this.dept + " " + this.salary + " " + this.workingdays + " " + this.basicsalary; 
        }
    }
}
