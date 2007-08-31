﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indy.IL2CPU.Assembler {
	public class JumpIfNotZero: Instruction {
		public readonly string Address;
		public JumpIfNotZero(string aAddress) {
			Address = aAddress;
		}
		public override string ToString() {
			return "jne " + Address;
		}
	}
}
