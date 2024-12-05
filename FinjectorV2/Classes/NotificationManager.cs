using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class NotificationManager
{
    private static int notificationCount = 0; 

    private static Image LoadImage(string primaryPath, string fallbackPath)
    {
        if (System.IO.File.Exists(primaryPath))
        {
            return Image.FromFile(primaryPath);
        }
        else if (System.IO.File.Exists(fallbackPath))
        {
            return Image.FromFile(fallbackPath);
        }
        else
        {
            throw new System.IO.FileNotFoundException("Image not found in both primary and fallback paths.");
        }
    }

    public static async void ShowSuccessNotification(string message)
    {
        await ShowNotification(
            message,
            backgroundColor: Color.FromArgb(20, 20, 20),
            textColor: Color.FromArgb(103, 192, 0),
            font: new Font("Consolas", 12, FontStyle.Regular),
            logo: LoadImage("Finjector/Icons/Success.png", "workspace/Finjector/Icons/Success.png"),
            hoverOpacity: 1.0,
            regularOpacity: 0.85,
            duration: 2000, // 2 seconds
            size: new Size(250, 60),
            position: NotificationPosition.BottomRight
        );
    }

    public static async void ShowErrorNotification(string message)
    {
        await ShowNotification(
            message,
            backgroundColor: Color.FromArgb(20, 20, 20),
            textColor: Color.FromArgb(255, 0, 0),
            font: new Font("Consolas", 10, FontStyle.Regular),
            logo: LoadImage("Finjector/Icons/Error.png", "workspace/Finjector/Icons/Error.png"),
            hoverOpacity: 1.0,
            regularOpacity: 0.85,
            duration: 3000,
            size: new Size(250, 60),
            position: NotificationPosition.BottomRight
        );
    }

    public static async void ShowInfoNotification(string message)
    {
        await ShowNotification(
            message,
            backgroundColor: Color.FromArgb(20, 20, 20),
            textColor: Color.FromArgb(0, 0, 250),
            font: new Font("Consolas", 10, FontStyle.Regular),
            logo: LoadImage("Finjector/Icons/Info.png", "workspace/Finjector/Icons/Info.png"),
            hoverOpacity: 1.0,
            regularOpacity: 0.85,
            duration: 3000,
            size: new Size(250, 60),
            position: NotificationPosition.BottomRight
        );
    }

    private static async Task ShowNotification(
        string text,
        Color? backgroundColor,
        Color? textColor,
        Font font,
        Image logo,
        double hoverOpacity,
        double regularOpacity,
        int duration,
        Size size,
        NotificationPosition position)
    {

        Form notificationForm = new Form
        {
            Size = size,
            BackColor = backgroundColor ?? Color.DarkGray,
            FormBorderStyle = FormBorderStyle.None,
            StartPosition = FormStartPosition.Manual,
            TopMost = true,
            Opacity = regularOpacity,
            ShowInTaskbar = false 
        };

        notificationForm.Location = CalculatePosition(size, position);

        if (logo != null)
        {
            var pictureBox = new PictureBox
            {
                Image = logo,
                Size = new Size(30, 30),
                Location = new Point(10, 15),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            notificationForm.Controls.Add(pictureBox);
        }

        var label = new Label
        {
            Text = text,
            Font = font,
            ForeColor = textColor ?? Color.White,
            BackColor = Color.Transparent,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleLeft,
            Location = new Point(50, 10),
            Size = new Size(size.Width - 60, size.Height - 20)
        };
        notificationForm.Controls.Add(label);

        notificationForm.MouseEnter += (s, e) => notificationForm.Opacity = hoverOpacity;
        notificationForm.MouseLeave += (s, e) => notificationForm.Opacity = regularOpacity;

        notificationForm.Show();
        notificationCount++;

        for (double i = 0; i <= 1; i += 0.05)
        {
            notificationForm.Opacity = i;
            await Task.Delay(20);
        }

        await Task.Delay(duration);

        for (double i = 1; i >= 0; i -= 0.05)
        {
            notificationForm.Opacity = i;
            await Task.Delay(20);
        }

        if (!notificationForm.IsDisposed)
        {
            notificationForm.Close();
        }

        notificationCount--;
    }

    private static Point CalculatePosition(Size notificationSize, NotificationPosition position)
    {
        var screenBounds = Screen.PrimaryScreen.WorkingArea;

        int verticalOffset = notificationCount * (notificationSize.Height + 10); 

        return position switch
        {
            NotificationPosition.TopRight => new Point(
                screenBounds.Right - notificationSize.Width - 10,
                screenBounds.Top + verticalOffset + 10),
            NotificationPosition.TopLeft => new Point(
                screenBounds.Left + 10,
                screenBounds.Top + verticalOffset + 10),
            NotificationPosition.BottomRight => new Point(
                screenBounds.Right - notificationSize.Width - 10,
                screenBounds.Bottom - notificationSize.Height - verticalOffset - 10),
            NotificationPosition.BottomLeft => new Point(
                screenBounds.Left + 10,
                screenBounds.Bottom - notificationSize.Height - verticalOffset - 10),
            _ => new Point(screenBounds.Right - notificationSize.Width - 10, screenBounds.Bottom - notificationSize.Height - verticalOffset - 10)
        };
    }
}

public enum NotificationPosition
{
    TopRight,
    TopLeft,
    BottomRight,
    BottomLeft
}