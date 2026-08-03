using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClickMacroApp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private const int HOTKEY_ID_START = 1;
        private const int HOTKEY_ID_STOP = 2;

        private Timer clickTimer = new Timer();
        private int clickX = 500;
        private int clickY = 500;

        public Form1()
        {
            InitializeComponent();

            clickTimer.Tick += ClickTimer_Tick;
            lblStatus.Text = "상태: 대기 중";

            RegisterHotKey(this.Handle, HOTKEY_ID_START, 0, (uint)Keys.F6);
            RegisterHotKey(this.Handle, HOTKEY_ID_STOP, 0, (uint)Keys.F7);
        }

        private void btnSetPos_Click(object sender, EventArgs e)
        {
            clickX = Cursor.Position.X;
            clickY = Cursor.Position.Y;
            MessageBox.Show($"클릭 위치가 설정되었습니다: X={clickX}, Y={clickY}");
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            clickX = Cursor.Position.X;
            clickY = Cursor.Position.Y;
            SetCursorPos(clickX, clickY);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, clickX, clickY, 0, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_START)
                {
                    if (int.TryParse(txtInterval.Text, out int interval))
                    {
                        clickTimer.Interval = interval;
                        clickTimer.Start();
                        lblStatus.Text = "상태: 실행 중";
                    }
                    else
                    {
                        MessageBox.Show("올바른 숫자를 입력하세요 (예: 1000)");
                    }
                }
                else if (id == HOTKEY_ID_STOP)
                {
                    clickTimer.Stop();
                    lblStatus.Text = "상태: 중지됨";
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);
            base.OnFormClosing(e);
        }
    }
}
