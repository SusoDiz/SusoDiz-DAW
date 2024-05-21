public class Punto
{
	private int x, y;
	private static Random alea = new Random();
	public Punto(int x, int y) {
		this.x = x;
		this.y = y;
	}
	public int GetX() { return x; }
	public int GetY() { return y; }

	public override string ToString()
	{
		return $"Punto(x:{x},y:{y})";
	}
}
