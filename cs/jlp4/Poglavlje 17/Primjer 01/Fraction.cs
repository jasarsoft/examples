﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgCS
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction rhs)
        {
            if(rhs.denominator != this.denominator)
            {
                return new Fraction(rhs.denominator * numerator + rhs.numerator * denominator, denominator * rhs.denominator);
            }
            return new Fraction(this.numerator + rhs.numerator, this.numerator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
