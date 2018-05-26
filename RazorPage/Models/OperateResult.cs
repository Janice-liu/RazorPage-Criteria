namespace RazorPage
{
	public class CmdResult<T>
	{
		public bool IsSuccess { get; }
		public string Message { get; }
		public T Data { get; }
		public bool IsFailure => !IsSuccess;
		internal CmdResult(bool isSuccess, string message, T data)
		{
			IsSuccess = isSuccess;
			Message = message;
			Data = data;
		}
	}

	public class CmdResult
	{
		public static CmdResult<T> Success<T>(T data) => Success(data, "Success");

		public static CmdResult<T> Success<T>(T data, string message) =>
				new CmdResult<T>(true, message, data);

		public static CmdResult<T> Fail<T>(string message) =>
			new CmdResult<T>(false, message, default(T));
	}
}
