﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //categoryId
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; }
    }
}
