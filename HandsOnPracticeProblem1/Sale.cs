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
        // Fields and Properties
        public string Employee { get; set; }
        public decimal SalesAmount { get; set; }
        private decimal _commissionRate { get; set; }
        public decimal Commission
        {
            get { return SalesAmount * _commissionRate;  }
        }

        // Constructor (1)
        public Sale(string Employee, decimal SalesAmount, decimal _commissionRate)
        {
            this.Employee = Employee;
            this.SalesAmount = SalesAmount;
            this._commissionRate = _commissionRate;
        }

        // Constructor (2)
        public Sale(string Employee, decimal SalesAmount)
        {
            this.Employee = Employee;
            this.SalesAmount = SalesAmount;
            this._commissionRate = .03m;
        }

        // This method sets up the Exceptions and setting up the data for the Main() Method in the Program Class
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

        // This override method returns the string format that will be written to the console
        public override string ToString()
        {
            return $"Employee: {Employee,10} Sale Amount: {SalesAmount,15} Rate: {_commissionRate,10} Commission: {Commission}";
        }


        // This method is the math to figure out total sales and the combined Commission Rate
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
