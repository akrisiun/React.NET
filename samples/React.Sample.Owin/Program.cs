/*
 * Copyright (c) Facebook, Inc. and its affiliates.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

using System;
using Microsoft.Owin.Hosting;

namespace React.Sample.Owin
{
	class Program
	{
		static void Main(string[] args)
		{
			// System.TypeLoadException: Could not load type 'React.MemoryFileCache' 
			// from assembly 'React.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=9aed67b161f7db78'.

			var cache = typeof(MemoryFileCache);

			using (WebApp.Start<Startup>("http://localhost:12345"))
			{
				Console.WriteLine("Running on localhost:12345, press enter to quit");
				Console.ReadLine();
			}
		}
	}
}
