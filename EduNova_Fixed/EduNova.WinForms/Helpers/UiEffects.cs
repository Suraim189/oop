using System;
using System.Drawing;
using System.Windows.Forms;

namespace EduNova.WinForms.Helpers
{
    public static class UiEffects
    {
        public static void WireHoverGold(Button btn)
        {
            Color original = btn.BackColor;
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Theme.AccentHover;
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 0.5f, btn.Font.Style);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = original;
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size - 0.5f, btn.Font.Style);
            };
        }

        public static void WireHoverDark(Button btn)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(Theme.BtnSecondary.R + 20, Theme.BtnSecondary.G + 20, Theme.BtnSecondary.B + 20);
            btn.MouseLeave += (s, e) => btn.BackColor = Theme.BtnSecondary;
        }

        public static void FadeIn(Form form)
        {
            form.Opacity = 0;
            var t = new Timer { Interval = 50 };
            t.Tick += (s, e) =>
            {
                form.Opacity += 0.05;
                if (form.Opacity >= 1) t.Stop();
            };
            t.Start();
        }

        public static void FadeOut(Form form, Action onComplete)
        {
            var t = new Timer { Interval = 50 };
            t.Tick += (s, e) =>
            {
                form.Opacity -= 0.05;
                if (form.Opacity <= 0)
                {
                    t.Stop();
                    onComplete?.Invoke();
                }
            };
            t.Start();
        }

        public static void StartClock(Label lbl)
        {
            lbl.Text = DateTime.Now.ToString("HH:mm:ss  dddd, dd MMM yyyy");
            var t = new Timer { Interval = 1000 };
            t.Tick += (s, e) => lbl.Text = DateTime.Now.ToString("HH:mm:ss  dddd, dd MMM yyyy");
            t.Start();
        }

        public static void SlideFormIn(Form form)
        {
            int targetX = form.Left;
            form.Left = Screen.PrimaryScreen.WorkingArea.Width;
            var t = new Timer { Interval = 10 };
            t.Tick += (s, e) =>
            {
                form.Left -= 30;
                if (form.Left <= targetX)
                {
                    form.Left = targetX;
                    t.Stop();
                }
            };
            t.Start();
        }

        public static void AnimateSidebarButton(Button btn, Color targetColor)
        {
            btn.BackColor = targetColor;
        }
    }
}
