using System.IO;

namespace DependencyInversion
{
	public class FileLogger : ILogger
	{
		private readonly TextWriter _writer;

		public FileLogger(TextWriter writer)
		{
			_writer = writer;
		}

		public void Log(string message)
		{
			_writer.Write(message);
		}
	}
}
