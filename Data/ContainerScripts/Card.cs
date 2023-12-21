﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebB.Data.ContainerScripts
{
	public enum CardSystem
	{
		MIR,
		VISA,
		MASTERCARD
	}
	public class Card : BankAccount
	{
		public CardSystem System;
        public double Money;
        public int Number;
        public string Name;
        public string svgcode;
    }
}
