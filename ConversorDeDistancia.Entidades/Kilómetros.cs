namespace ConversorDeDistancia.Entidades
{
    public class Kilómetros
    {
        public double Velocidad { get; set; }

        public Kilómetros(double velocidad)
        {
            Velocidad = velocidad;
        }

        public Kilómetros()
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
            if (obj == null || !(obj is Kilómetros))
            {
                return false;
            }
            return this.Velocidad == ((Kilómetros)obj).Velocidad;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Kilómetros K1, Kilómetros K2)
        {
            return K1.Velocidad.Equals(K2.Velocidad);
        }

        public static bool operator !=(Kilómetros K1, Kilómetros K2)
        {
            return !(K1.Velocidad == K2.Velocidad);
        }

        public static Kilómetros operator +(Kilómetros kilómetros, Millas millas)
        {
            double millasEnKilometros = millas.ConvertirAKilometros(millas.Velocidad);
            return new Kilómetros(kilómetros.Velocidad + millasEnKilometros);
        }

        public static Kilómetros operator -(Kilómetros kilómetros, Millas millas)
        {
            double millasEnKilometros = millas.ConvertirAKilometros(millas.Velocidad);
            return new Kilómetros(kilómetros.Velocidad - millasEnKilometros);
        }
    }
}
