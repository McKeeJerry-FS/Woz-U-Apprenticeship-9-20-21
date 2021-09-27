using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPracticeProblem1
{
    // Project 1
    public class Sale
    {
        public string Employee { get; set; }
        public decimal SalesAmount { get; set; }
        private decimal _commissionRate { get; set; }
        public decimal Commission
        {
            get { return SalesAmount * _commissionRate;  }
        }

        public Sale(string Employee, decimal SalesAmount, decimal _commissionRate)
        {
            this.Employee = Employee;
            this.SalesAmount = SalesAmount;
            this._commissionRate = _commissionRate;
        }

        public Sale(string Employee, decimal SalesAmount)
        {
            this.Employee = Employee;
            this.SalesAmount = SalesAmount;
            this._commissionRate = .03m;
        }

        public string SalesTotal(decimal a, decimal b)
        {
            string message = "";
            if (Employee == Employee)
            {
                decimal salesAmountSum = SalesAmount + SalesAmount;
                message = salesAmountSum.ToString();
            }
            else
            {
                message = "Can only add sale objects if the employee is the same. In this case left = \"One\" and Right = \"Two\"";
            }

            return message;
        }

        public Sale(string csv)
        {
            
          
            string[] data = csv.Split('|');
            if (3 != data.Length)
            {
                throw new Exception($"CSV entry '{csv}' does not contain the correct number of commas");
            }
            Employee = data[0];
            decimal temp;
            if (!decimal.TryParse(data[1], out temp))
            {
                throw new Exception($"CSV entry '{csv}' is not recoginizable as a decimal.");
            }
            SalesAmount = temp;
            if (!decimal.TryParse(data[2], out temp))
            {
                throw new Exception($"CSV entry '{csv}' is not recoginizable as a decimal.");
            }
            _commissionRate = temp;
         

        }

        public override string ToString()
        {
            return $"Employee: {Employee,10} Sale Amount: {SalesAmount,15} Rate: {_commissionRate,10} Commission: {Commission}";
        }

        public static Sale operator +(Sale left, Sale right)
        {
            if (left.Employee != right.Employee)
            {
                throw new Exception($"Can only add sale object if Employee is the same. This means '{left.Employee}' = '{right.Employee}'.");
            }
            decimal totalCommission = left.Commission + right.Commission;
            decimal totalSale = left.SalesAmount + right.SalesAmount;
            decimal combinedRate = totalCommission / totalSale;
            return new Sale(left.Employee, totalSale, combinedRate);
        }
    }   
}
