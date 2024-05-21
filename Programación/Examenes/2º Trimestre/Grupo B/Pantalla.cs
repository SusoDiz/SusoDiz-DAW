public class Pantalla
{
	private int x, y;
	private int lapso;
	private String PRE = "-----> ";
	private String POS = " <-----";

	public Pantalla(int x, int y, int lapso)
	{
		this.x = x;
		this.y = y;
		this.lapso = lapso;
	}
	public void Mostrar(Object obj)
	{
		Console.Clear();
		Console.SetCursorPosition(x, y);
		Console.Write(PRE + obj + POS);
		Thread.Sleep(lapso);
		lapso = lapso*2/3;
		Ocultar(obj);
	}
	private void Ocultar(Object obj)
	{
		int caracteres = (PRE + obj + POS).Length;
		Console.SetCursorPosition(x, y);
		for (int i = 0; i < caracteres; i++)
			Console.Write(' ');
	}
}
