namespace Zad2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Driver
    {
        public Driver(string fullName, int driverLicenseNumber, int violations, double amountFees)
        {
            this.FullName = fullName;
            this.Status = "Изряден";
            this.DriverLicenseNumber = driverLicenseNumber;
            this.Violations = violations;
            this.AmountFees = amountFees;
        }

        public string FullName { get; set; }

        public string Status { get; set; }

        public int DriverLicenseNumber { get; set; }

        public int Violations { get; set; }

        public double AmountFees { get; set; }

        public void RegisterViolation(double fee)
        {
            this.Violations++;
            this.AmountFees += fee;
        }

        public void CheckStatus()
        {
            if (this.Violations == 3 && this.AmountFees <= 1000)
            {
                this.Status = "Заплашен от отнемане на книжка";
            }
            else 
            {
                this.Status = "Отнемане на книжка";
            }
        }
    }
}
