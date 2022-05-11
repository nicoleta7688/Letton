﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letton.BusinessLogic.Interfaces;

namespace Letton.BusinessLogic
{
    public class MyBusinessLogic
    {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
          public IProduct GetProductBL()
          {
               return new ProductBL();
          }
     }
}
