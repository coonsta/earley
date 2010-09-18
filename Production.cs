// Copyright 2004 Dominic Cooney. All Rights Reserved.

/*
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace Earley
{
	public class Production
	{
		readonly IList<Symbol> symbols = new List<Symbol>();

		public Production(params Symbol[] symbols)
		{
			if (symbols == null) throw new ArgumentNullException();

			for (int i = 0; i < symbols.Length; i++)
			{
				if (symbols[i] == null) throw new ArgumentNullException();
			}

			for (int i = 0; i < symbols.Length; i++)
			{
				this.symbols.Add(symbols[i]);
			}
		}

		internal IList<Symbol> Symbols
		{
			get { return new List<Symbol>(symbols); }
		}
	}
}
