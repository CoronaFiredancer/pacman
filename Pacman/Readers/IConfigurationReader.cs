using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Readers
{
	public interface IConfigurationReader
	{
		Configuration Read();
	}
}
