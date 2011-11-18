using System;

namespace TwitterClone.Models
{
	public class Clam
	{
		public Clam()
		{
			Timestamp = DateTime.Now;
		}

		public virtual Guid Id { get; set; }
		public virtual string UserName { get; set; }
		public virtual string Pearl { get; set; }
		public virtual DateTime Timestamp { get; protected set; }
	}
}