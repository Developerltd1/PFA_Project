﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PFA_Project.Models;

public partial class TblTransaction
{
    public int TransactionId { get; set; }

    public int FundTypeId { get; set; }

    public decimal Amount { get; set; }

    public string TransactionDetails { get; set; }

    public DateTime EntryDate { get; set; }

    public int EnterByUserId { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? ModifyByUserId { get; set; }

    public bool TrasactionType { get; set; }

    public bool IsActive { get; set; }
}