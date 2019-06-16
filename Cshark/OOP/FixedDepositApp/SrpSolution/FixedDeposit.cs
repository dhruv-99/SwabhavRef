using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SrpSolution.Festivals;

namespace SrpSolution
{
    class FixedDeposit
    {
        private string _name;
        private int _year;
        private double _principle;
        private IRateDeciider _festival;


        public FixedDeposit(string name, double principle, int year, IRateDeciider festival)
        {
            _name = name;
            _principle = principle;
            _year = year;
            _festival = festival;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Principle
        {
            get
            {
                return _principle;
            }
        }
        public double Year
        {
            get
            {
                return _year;
            }
        }
        public IRateDeciider Festival
        {
            get
            {
                return _festival;
            }
        }
        public double CalculateeSimpleInterest()
        {
            return (_principle * _year *  _festival.CalculateRate()) / 100; 
        }
            
        
    }
}
