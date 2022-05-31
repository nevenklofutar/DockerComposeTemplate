namespace Api.Models.Error
{
	public class BadRequestException : Exception
	{
		public BadRequestException(string message)
			: base(message)
		{
		}
	}
}
