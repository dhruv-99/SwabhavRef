using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixedDepositApp
{
    class FixedDeposit
    {
        private string _name;
        private int _year;
        private double _principle;
        private Festivals _festival;

        public FixedDeposit(string name, double principle, int year, Festivals festival)
        {
            _name = name;
            _principle = principle;
            _year = year;
            _festival = festival;
        }
        public double CalculateSimpleInterest()
        {
            if (_festival == Festivals.HOLI)
                return (_principle * 0.08 * _year) / 100;
            if (_festival == Festivals.NEW_YEAR)
                return (_principle * 0.07 * _year) / 100;
            return (_principle * 0.07 * _year) / 100;
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
        public Festivals Festival
        {
            get
            {
                return _festival;
            }
        }
    }
}
