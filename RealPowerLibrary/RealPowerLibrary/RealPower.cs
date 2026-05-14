using System;

namespace RealPowerLibrary
{
    public struct RealPower
    {
        private const double Tolerance = 1e-13;

        private double baseValue;
        private double exponentValue;

        public double Base
        {
            get => baseValue;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Основание должно быть положительным");
                baseValue = value;
            }
        }

        public double Exponent
        {
            get => exponentValue;
            set => exponentValue = value;
        }

        public double Value => Math.Pow(Base, Exponent);

        public RealPower(double baseValue, double exponentValue) : this()
        {
            Base = baseValue;
            Exponent = exponentValue;
        }

        public override string ToString()
        {
            return $"{Base}E{Exponent}";
        }

        public override bool Equals(object obj)
        {
            if (obj is RealPower other)
                return Math.Abs(Value - other.Value) < Tolerance;
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(RealPower left, RealPower right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RealPower left, RealPower right)
        {
            return !left.Equals(right);
        }

        public static RealPower operator *(RealPower left, RealPower right)
        {
            if (Math.Abs(left.Base - right.Base) >= Tolerance)
                throw new InvalidOperationException("Умножение возможно только при одинаковых основаниях");
            return new RealPower(left.Base, left.Exponent + right.Exponent);
        }

        public static RealPower operator /(RealPower left, RealPower right)
        {
            if (Math.Abs(left.Base - right.Base) >= Tolerance)
                throw new InvalidOperationException("Деление возможно только при одинаковых основаниях");
            return new RealPower(left.Base, left.Exponent - right.Exponent);
        }
    }
}





