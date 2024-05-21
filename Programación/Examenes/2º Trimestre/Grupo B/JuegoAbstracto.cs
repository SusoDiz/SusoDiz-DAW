public abstract class JuegoAbstracto
{
	private const int RETARDO_INICIAL = 1000;
	protected Jugador? ganador;

	protected Pantalla pantallaVolatil = new Pantalla(5, 5, RETARDO_INICIAL);

	public abstract Boolean Jugar();
	public abstract Jugador GetLider();
}
