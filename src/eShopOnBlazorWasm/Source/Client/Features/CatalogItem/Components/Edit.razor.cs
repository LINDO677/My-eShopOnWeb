﻿namespace eShopOnBlazorWasm.Features.CatalogItems.Components
{
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  public partial class Edit
  {
    [Parameter] public string CatalogItemId { get; set; }
  }
}