using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LitwareLib
{

    internal class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private string Designation;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        double GS;

        

        public virtual void SetEmployee(int EmpNo, string EmpName, double Salary, string Designation)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.Designation = Designation;


            // double sal = this.Salary;
            if (this.Salary < 5000)
            {

                this.HRA = (Salary / 100) * 10;
                double hra = this.HRA;
                this.TA = (Salary / 100) * 05;
                double ta = this.TA;
                this.DA = (Salary / 100) * 15;
                double da = this.DA;
                double G;
                if (this.Designation == "Employee")
                {
                    CalculateGrossSalary(hra, ta, da, Salary);
                }
                else if (this.Designation == "Manager")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    Manager mng = new Manager();
                    this.GrossSalary = mng.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mng.CalculateNetSalary(G);
                }
                else if (this.Designation == "Marketing Executive")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    MarketingExecutive mrkexe = new MarketingExecutive();
                    this.GrossSalary = mrkexe.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mrkexe.CalculateNetSalary(this.GrossSalary);
                }

            }
            else if (this.Salary < 10000)
            {
                this.HRA = this.Salary * .15;
                double hra = this.HRA;
                this.TA = this.Salary * .10;
                double ta = this.TA;
                this.DA = this.Salary * .20;
                double da = this.DA;
                double G;
                if (this.Designation == "Employee")
                {
                    CalculateGrossSalary(hra, ta, da, Salary);
                }
                else if (this.Designation == "Manager")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    Manager mng = new Manager();
                    this.GrossSalary = mng.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mng.CalculateNetSalary(G);
                }
                else if (this.Designation == "Marketing Executive")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    MarketingExecutive mrkexe = new MarketingExecutive();
                    this.GrossSalary = mrkexe.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mrkexe.CalculateNetSalary(this.GrossSalary);
                }

            }
            else if (this.Salary < 15000)
            {
                this.HRA = this.Salary * .20;
                double hra = this.HRA;
                this.TA = this.Salary * .15;
                double ta = this.TA;
                this.DA = this.Salary * .25;
                double da = this.DA;
                double G;
                if (this.Designation == "Employee")
                {
                    CalculateGrossSalary(hra, ta, da, Salary);
                }
                else if (this.Designation == "Manager")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    Manager mng = new Manager();
                    this.GrossSalary = mng.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mng.CalculateNetSalary(G);
                }
                else if (this.Designation == "Marketing Executive")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    MarketingExecutive mrkexe = new MarketingExecutive();
                    this.GrossSalary = mrkexe.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mrkexe.CalculateNetSalary(this.GrossSalary);
                }
            }
            else if (this.Salary < 20000)
            {
                this.HRA = this.Salary * .25;
                double hra = this.HRA;
                this.TA = this.Salary * .20;
                double ta = this.TA;
                this.DA = this.Salary * .30;
                double da = this.DA;
                double G;
                if (this.Designation == "Employee")
                {
                    CalculateGrossSalary(hra, ta, da, Salary);
                }
                else if (this.Designation == "Manager")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    Manager mng = new Manager();
                    this.GrossSalary = mng.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mng.CalculateNetSalary(G);
                }
                else if (this.Designation == "Marketing Executive")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    MarketingExecutive mrkexe = new MarketingExecutive();
                    this.GrossSalary = mrkexe.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mrkexe.CalculateNetSalary(this.GrossSalary);
                }

            }
            else if (this.Salary >= 20000)
            {
                this.HRA = this.Salary * .30;
                double hra = this.HRA;
                this.TA = this.Salary * .25;
                double ta = this.TA;
                this.DA = this.Salary * .35;
                double da = this.DA;
                double G;
                if (this.Designation == "Employee")
                {
                    CalculateGrossSalary(hra, ta, da, Salary);
                }
                else if (this.Designation == "Manager")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    Manager mng = new Manager();
                    this.GrossSalary = mng.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mng.CalculateNetSalary(G);
                }
                else if (this.Designation == "Marketing Executive")
                {
                    G = CalculateGrossSalary(hra, ta, da, Salary);
                    MarketingExecutive mrkexe = new MarketingExecutive();
                    this.GrossSalary = mrkexe.CalculateGrossSalary(hra, ta, da, Salary);
                    this.NetSalary = mrkexe.CalculateNetSalary(this.GrossSalary);
                }
            }

        }


        public virtual double CalculateGrossSalary(double hra, double ta, double da, double sa)
        {
            this.GrossSalary = sa + hra + ta + da;
            GS = this.GrossSalary;
            this.NetSalary = CalculateNetSalary(GS);
            return GS;

        }
        public virtual double CalculateNetSalary(double GS)
        {
            this.PF = (GS / 100) * 10;
            this.TDS = (GS / 100) * 18;
            this.NetSalary = GS - (this.PF + this.TDS);
            double N = this.NetSalary;
            return N;
        }


        public double ta { get { return TA; } set { TA = value; } }
        public double da { get { return DA; } set { DA = value; } }
        public double hra { get { return HRA; } set { HRA = value; } }
        public double pf { get { return PF; } set { PF = value; } }
        public double tds { get { return TDS; } set { TDS = value; } }
        public string name { get { return EmpName; } set { EmpName = value; } }
        public int number { get { return EmpNo; } set { EmpNo = value; } }
        public double salary { get { return Salary; } set { Salary = value; } }
        public string designation { get { return Designation; } set { Designation = value; } }


        public double gross { get { return GrossSalary; } set { GrossSalary = value; } }
        public double net { get { return NetSalary; } set { NetSalary = value; } }



    }

    

   








}

