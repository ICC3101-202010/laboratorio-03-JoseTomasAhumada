using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Employee : Persona
    {
        private string workplace;
        private int salary;
        private string startTime;
        private string endTime;
        public Employee(string rut, string firstName, string lastName, string birth, string nacionality, string workplace, int salary, string startTime, string endTime) : base(rut, firstName, lastName, birth, nacionality)
        {
            this.workplace = workplace;
            this.salary = salary;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public string Workplace()
        {
            return workplace;
        }
        public int Salary()
        {
            return salary;
        }
        public string StartTime()
        {
            return startTime;
        }
        public string EndTime()
        {
            return endTime;
        }
        public void changeWorkplace(string workplace)
        {
            this.workplace = workplace;
        }
        public void changeSalary(int salary)
        {
            this.salary = salary;
        }
        public void changeworkingHours(string startTime, string endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
