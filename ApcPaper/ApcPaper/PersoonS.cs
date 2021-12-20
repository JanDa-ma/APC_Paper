using System;

namespace ApcPaper
{
    public struct PersoonS : IEquatable<PersoonS>
    {
        public string Naam { get; set; }

        public bool Equals(PersoonS other)
        {
            return this.Naam == other.Naam;
        }

        public override bool Equals(object obj)
        {
            if (obj is PersoonS)
                return Equals(obj);
            else
                return false;
        }

        public static bool operator ==(PersoonS p1, PersoonS p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(PersoonS p1, PersoonS p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return this.Naam.GetHashCode();
        }
    }
}