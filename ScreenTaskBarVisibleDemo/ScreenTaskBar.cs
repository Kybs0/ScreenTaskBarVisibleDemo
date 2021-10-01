using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;

namespace ScreenTaskBarVisibleDemo
{
    internal class ScreenTaskBar
    {
        private const int SwHide = 0; //隐藏任务栏
        private const int SwRestore = 9;//显示任务栏
        public static void Show(Window window)
        {
            var taskBar = FindMatchingTaskBar(window);
            if (taskBar.IsVisible)
            {
                return;
            }
            User32.ShowWindow(taskBar.Hwnd,SwRestore);
        }

        private static WindowInfo FindMatchingTaskBar(Window window)
        {
            var windowInfos = WindowEnumerator.FindAll();
            var taskBars = windowInfos.Where(i => i.ClassName.Contains("TrayWnd"));
            var intPtr = new WindowInteropHelper(window).Handle;//获取当前窗口的句柄
            var screen = Screen.FromHandle(intPtr);//获取当前屏幕
            var currentScreenBounds = screen.Bounds;
            var currentTaskBar = taskBars.FirstOrDefault(i => i.Bounds.IntersectsWith(currentScreenBounds));
            return currentTaskBar;
        }

        public static void Hide(Window window)
        {
            var taskBar = FindMatchingTaskBar(window);
            if (!taskBar.IsVisible)
            {
                return;
            }
            User32.ShowWindow(taskBar.Hwnd, SwHide);
        }
    }
}
