using System;
using System.IO;
using System.Linq;

namespace WAGrapher
{
	public class WhatsAppGrapher
	{
		public Action<float> OnProgressUpdated;
		private EvaluationMethodBase[] methods;


		public WhatsAppGrapher(EvaluationMethodBase[] methods)
		{
			this.methods = methods;
		}

		public void Analyse(string path)
		{
			string[] lines = File.ReadLines(path).ToArray();

			string cache = "";

			foreach (var method in methods)
			{
				method.Initialize();
			}

			for (int i = lines.Length - 1; i >= 0; i--)
			{
				float progress = ((float)lines.Length - i) / lines.Length;
				if (OnProgressUpdated != null)
				{
					OnProgressUpdated.Invoke(progress);
				}

				string data = lines[i];
				Message messageData = ExtractMessage(data);

				if (messageData == null)
				{
					cache = data + cache;
					continue;
				}

				foreach (var method in methods)
				{
					method.Process(messageData);
				}
			}
		}

		private Message ExtractMessage(string data)
		{
			try
			{
				DateTime date = DateTime.Parse(data.Substring(1, 20));
				string sender = data.Substring(22).Split(':')[0];
				string text = data.Substring(22 + sender.Length + 2);

				bool isImage = text == "image omitted"; // TODO: check whether this also works with other files. 

				Message message = new Message()
				{
					Date = date,
					Sender = sender,
					Text = isImage ? "" : text, 
					HasFileLink = isImage
				};

				return message;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
