using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BrookW.Extend
{
    public static class Msg
    {
        public static DialogResult ShowWarning(string message, string caption = "运行提示")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowInfo(string message, string caption = "信息提示")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowError(string message, string caption = "运行提示")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowConfirm(string message, string caption = "确认操作")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }


        public const string SERVEREMPTY = "服务器地址不能为空";
        public const string PASSWORDEMPTY = "密码不能为空";
        public const string ADDSCUESS = "添加成功";
        public const string UNSELECTED = "下拉框没有选中服务器";


    }
}
