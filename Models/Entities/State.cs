﻿using System;
using System.Collections.Generic;

namespace Week10.lab.Models.Entities;

public partial class State
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
