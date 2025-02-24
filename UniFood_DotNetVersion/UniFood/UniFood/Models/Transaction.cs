﻿using UniFood.Data.Enum;

namespace UniFood.Models;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TransactionType Type { get; set; }
    public float Amount { get; set; }
    public int ActionId { get; set; } // If reserve, reserve id and if increase credit, its id ...
    
    public string StudentId { get; set; }
    public Student Student { get; set; }
}