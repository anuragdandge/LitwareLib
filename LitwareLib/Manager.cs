using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib
{
    internal class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double GrossSalary;
        private double NetSalary;
        private double TDS;


        double GS;
        public override double CalculateGrossSalary(double hra, double ta, double da, double sa)
        {
            this.PetrolAllowance = (sa / 100) * 08;
            double PA = this.PetrolAllowance;
            this.FoodAllowance = (sa / 100) * 13;
            double FA = this.FoodAllowance;
            this.OtherAllowance = (sa / 100) * 03;
            double OA = this.OtherAllowance;
            this.GrossSalary = sa + PA + FA + OA + ((sa / 100) * 10) + ((sa / 100) * 05) + ((sa / 100) * 15);
            GS = this.GrossSalary;
            this.TDS = (GS / 100) * 18;
            return GS;
        }

        public override double CalculateNetSalary(double G)
        {
            this.NetSalary = GS - (((G / 100) * 10) + this.TDS);
            double N = this.NetSalary;
            return N;
        }

        public new double  gross { get { return GrossSalary; } set { GrossSalary = value; } }
        public new double net { get { return NetSalary; } set { NetSalary = value; } }
    }
}
