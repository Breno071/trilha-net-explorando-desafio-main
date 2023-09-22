using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{

	[Serializable]
	public class CapacidadeNaoSuportadaException : Exception
	{
		public CapacidadeNaoSuportadaException() { }
		public CapacidadeNaoSuportadaException(string message) : base(message) { }
		public CapacidadeNaoSuportadaException(string message, Exception inner) : base(message, inner) { }
		protected CapacidadeNaoSuportadaException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
