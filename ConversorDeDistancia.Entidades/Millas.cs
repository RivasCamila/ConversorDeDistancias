public class Millas
{
    public double Velocidad { get; set; }

    public Millas(double velocidad)
    {
        Velocidad = velocidad;
    }
    public Millas()
    {
        Velocidad = 100;
    }
    public double ConvertirAKilometros(double millas)
    {
        return millas * 1.60934;
    }

    public double ConvertirAMillas(double kilometros)
    {
        return kilometros * 0.621371;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Millas))
        {
            return false;
        }
        return this.Velocidad == ((Millas)obj).Velocidad;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public static bool operator ==(Millas millas1, Millas millas2)
    {
        return millas1.Velocidad.Equals(millas2.Velocidad);
    }

    public static bool operator !=(Millas millas1, Millas millas2)
    {
        return !(millas1.Velocidad == millas2.Velocidad);
    }
}

