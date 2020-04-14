﻿using AlonsoAdmin.Common.Extensions;
using AlonsoAdmin.Common.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace AlonsoAdmin.Common.Auth
{
    public class AuthUser: IAuthUser
    {

        private readonly IHttpContextAccessor _accessor;

        public AuthUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        /// <summary>
        /// 用户Id
        /// </summary>

        public long Id
        {
            get
            {
                var id = _accessor?.HttpContext?.User?.FindFirst(ClaimAttributes.UserId);
                if (id != null && id.Value.IsNotNull())
                {
                    return id.Value.ToLong();
                }
                return 0;
            }
        }


        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                var name = _accessor?.HttpContext?.User?.FindFirst(ClaimAttributes.UserName);

                if (name != null && name.Value.IsNotNull())
                {
                    return name.Value;
                }

                return "";
            }
        }

        public string DisplayName
        {
            get
            {
                var name = _accessor?.HttpContext?.User?.FindFirst(ClaimAttributes.DisplayName);

                if (name != null && name.Value.IsNotNull())
                {
                    return name.Value;
                }

                return "";
            }
        }


    }


    /// <summary>
    /// Claim属性
    /// </summary>
    public static class ClaimAttributes
    {

        /// <summary>
        /// 用户Id
        /// </summary>
        public const string UserId = "id";

        /// <summary>
        /// 用户名
        /// </summary>
        public const string UserName = "un";

        /// <summary>
        /// 姓名
        /// </summary>
        public const string DisplayName = "dn";

        /// <summary>
        /// 登录日志Id
        /// </summary>
        public const string UserLoginLogId = "llid";

    }
}