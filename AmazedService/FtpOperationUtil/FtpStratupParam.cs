﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazedService.FtpOperationUtil
{
    /// <summary>
    /// ftp启动参数
    /// </summary>
    public class FtpStratupParam
    {
        /// <summary>
        /// 主机地址
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
