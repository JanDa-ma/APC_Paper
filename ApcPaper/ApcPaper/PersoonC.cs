namespace ApcPaper
{
    public class PersoonC
    {
        public string Naam { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this)) //Controle op zichzelf
                return true;
            if (obj.GetType() != this.GetType()) //Verschillend type
                return false;
            PersoonC persoon = obj as PersoonC;
            return persoon.Naam == this.Naam;
        }

        public static bool operator ==(PersoonC p1, PersoonC p2)
        {
            return object.Equals(p1, p2);
        }

        public static bool operator !=(PersoonC p1, PersoonC p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return this.Naam.GetHashCode();
        }

        public PersoonC()
        {
        }
    }
}