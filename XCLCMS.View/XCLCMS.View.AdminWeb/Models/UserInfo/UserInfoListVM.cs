﻿using System.Collections.Generic;

namespace XCLCMS.View.AdminWeb.Models.UserInfo
{
    public class UserInfoListVM
    {
        /// <summary>
        /// 查询控件
        /// </summary>
        public XCLNetSearch.Search Search { get; set; }

        /// <summary>
        /// 分页控件
        /// </summary>
        public XCLNetTools.Entity.PagerInfo PagerModel { get; set; }

        /// <summary>
        /// 用户信息列表
        /// </summary>
        public List<XCLCMS.Data.Model.View.v_UserInfo> UserInfoList { get; set; }
    }
}