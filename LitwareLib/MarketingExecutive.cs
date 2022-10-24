using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib


{
    internal class MarketingExecutive : Employee
    {

        private double TourAllowance;
        private double TelephoneAllowance;
        double GS;
        private double GrossSalary;
        private double NetSalary;
        private double TDS;


        public override double CalculateGrossSalary(double hra, double ta, double da, double sa)
        {
            Console.WriteLine(" Enter Kilometer Traveled ");
            double KiloM = double.Parse(Console.ReadLine());
            this.TourAllowance = KiloM * 5;
            double TrAl = this.TourAllowance;
            this.TelephoneAllowance = 1000;
            double TelAl = this.TelephoneAllowance;
            GS = TrAl + TelAl + sa + hra + ta + da;
            this.TDS = (GS / 100) * 18;
            return GS;
        }

        public override double CalculateNetSalary(double G)
        {
            this.NetSalary = GS - (((G / 100) * 10) + this.TDS);
            double N = this.NetSalary;
            return N;
        }

        public  double Gross { get { return GrossSalary; } set { GrossSalary = value; } }
        public  double Net { get { return NetSalary; } set { NetSalary = value; } }

    }
}
