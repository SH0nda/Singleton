using System;

class SingletonTest
{
	public static void Main(string[] args)
	{
		Renban renban = null;
		for (int i = 0; i < 9999; i++)
		{
			renban = Renban.getInstance();
			Console.WriteLine(renban.getNumber());
		}

		Console.ReadLine();	//終了後にコンソールが消えないようにする
	}
}

class Renban
{
	private static Renban jittai = new Renban();
	private int num = 0;

	public static Renban getInstance()
	{
		return jittai;
	}

	public int getNumber()
	{
		num++;
		return num;
	}
}