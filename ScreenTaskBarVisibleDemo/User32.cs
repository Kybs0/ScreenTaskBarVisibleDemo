using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenTaskBarVisibleDemo
{
    public class User32
    {
        /// <summary>
        /// 通过句柄，窗体显示函数
        /// </summary>
        /// <param name="hWnd">窗体句柄</param>
        /// <param name="cmdShow">显示方式</param>
        /// <returns>返回成功与否</returns>
        [DllImport("user32.dll", EntryPoint = "ShowWindowAsync", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        /// <summary>
        /// 通过句柄，窗体显示函数
        /// </summary>
        /// <param name="hwnd">窗体句柄</param>
        /// <param name="cmdShow">显示方式</param>
        /// <returns>返回成功与否</returns>
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int cmdShow);
        /// <summary>
        /// 获取窗体的句柄函数
        /// </summary>
        /// <param name="lpClassName">窗口类名</param>
        /// <param name="lpWindowName">窗口标题名</param>
        /// <returns>返回句柄</returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern int FindWindow2(string lpClassName, string lpWindowName);
        /// <summary>
        /// 移动窗体的函数
        /// </summary>
        /// <param name="hWnd">窗体句柄</param>
        /// <param name="x">窗体新位置x轴坐标</param>
        /// <param name="y">窗体新位置y轴坐标</param>
        /// <param name="nWidth">窗体新位置宽度</param>
        /// <param name="nHeight">窗体新位置高度</param>
        /// <param name="BRePaint">是否刷新窗体</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool BRePaint);
        /// <summary>
        /// 发送消息到窗体函数
        /// <para>可以用来发送特定的消息给窗体，比如关闭</para>
        /// </summary>
        /// <param name="hwnd">窗体句柄</param>
        /// <param name="wMsg">消息类型</param>
        /// <param name="wParam">附带消息</param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint wMsg, int wParam, int lParam);
    }
}
