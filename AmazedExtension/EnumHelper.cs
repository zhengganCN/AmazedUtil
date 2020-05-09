﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace AmazedExtension
{
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举列表
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns></returns>
        public static List<EnumModel> GetEnumList(Type enumType)
        {
            var fieldInfos = enumType.GetFields();//.GetType().GetFields();
            var list = new List<EnumModel>();
            foreach (var fieldInfo in fieldInfos)
            {
                if (fieldInfo.FieldType == enumType)
                {
                    var description = ((DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)))?.Description;
                    list.Add(new EnumModel
                    {
                        EnumKey = fieldInfo.Name,
                        EnumValue = (int)fieldInfo.GetValue(fieldInfo),
                        EnumDescription = !string.IsNullOrEmpty(description) ? description : fieldInfo.Name
                    });
                }
            }
            return list;
        }
    }
}
