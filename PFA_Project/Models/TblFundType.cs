﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PFA_Project.Models;

public partial class TblFundType
{
    public int FundTypeId { get; set; }

    public string FundTypeName { get; set; }

    public bool IsActive { get; set; }

    public int? CreatedBy { get; set; }
}