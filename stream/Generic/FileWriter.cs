﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace stream.Generic
{
	class FileWriter<T> where T : FormatBase
	{
		public void Write(IEnumerable<T> objects, string destination)
		{
			var objs = objects as IList<T> ?? objects.ToList();
			if (objs.Any())
			{
				using (var sw = new StreamWriter(destination))
				{
					foreach (var obj in objs)
					{
						sw.WriteLine(obj.ToFormat());
					}
				}
			}
		}
	}
}
