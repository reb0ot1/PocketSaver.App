﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneySaver.App.Models
{
    public class Transaction
    {
        public string Id { get; set; }

        public DateTime TransactionDate { get; set; }

        public int TransactionCategoryId { get; set; }

        public double Amount { get; set; }

        public string AdditionalNote { get; set; }
    }
}
