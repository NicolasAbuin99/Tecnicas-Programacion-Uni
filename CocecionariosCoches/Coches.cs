namespace CocecionariosCoches
{
    public class Coches
    {
		private string _modelo;

		public string Modelo
		{
			get { return _modelo; }
			set { _modelo = value; }
		}

		private string _color;

		public string Color
		{
			get { return _color; }
			set { _color = value; }
		}
		private int _precio;

		public int Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		public Coches(string modelo, string color, int precio)
		{
			this._modelo = modelo;
			this._color = color;
			this._precio = precio;
		}

        public override string ToString()
        {
            return Modelo + Color + Precio;
        }
    }
}
