﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OAuth2Provider.Request;

namespace OAuth2Provider.Authorization
{
    public interface IAuthorizeTokenRequest
    {
        Token Authorize(IOAuthRequest request);
    }
}
