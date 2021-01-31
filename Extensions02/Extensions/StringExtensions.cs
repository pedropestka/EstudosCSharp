namespace System
{
	static class StringExtensions
	{
		public static string Cortar(this string EsteObjeto, int contar)
		{
			if (EsteObjeto.Length <= contar)
			{
				return EsteObjeto;
			}
			else
			{
				return EsteObjeto.Substring(0, contar) + "...";
			}
		}
	}
}
