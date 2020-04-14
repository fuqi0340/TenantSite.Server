﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlonsoAdmin.Services.System.Request
{
    public class LoginLogAddRequest
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        public string Os { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 浏览器信息
        /// </summary>
        public string BrowserInfo { get; set; }

        /// <summary>
        /// 耗时（毫秒）
        /// </summary>
        public long ElapsedMilliseconds { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        public bool? Status { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 创建者Id
        /// </summary>
        public long? CreatedBy { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string CreatedByName { get; set; }
    }
}
