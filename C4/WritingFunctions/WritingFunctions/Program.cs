﻿using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static decimal SalesTax(
  decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08M;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M;
                    break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }

        static void RunSalesTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two letter region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = SalesTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        static void Main(string[] args)
        {
            RunSalesTax();
        }
    }
}
