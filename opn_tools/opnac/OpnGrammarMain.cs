using System;
using Irony;
using Irony.Parsing;
namespace Netfox.Opn
{
	public partial class OpnGrammar : Grammar 
	{
		public static Parser GetParser()
		{
			var grammar = new OpnGrammar();
			var parser = new Parser(grammar);
			return parser;
		}
	}
}
