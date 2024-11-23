using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class NotificationManager
{
    /// <summary>
    /// Відображення повідомлення про успішну операцію.
    /// </summary>
    /// <param name="message">Текст повідомлення.</param>
    public static async void ShowSuccessNotification(string message)
    {
        await ShowNotification(
            message,
            backgroundColor: Color.FromArgb(20, 20, 20), // Темний фон
            textColor: Color.FromArgb(0, 255, 0), // Зелений текст
            font: new Font("Segoe UI", 9, FontStyle.Regular), // Сучасний шрифт
            logo: Image.FromFile("Icons/Success.png"), // Іконка успіху
            hoverOpacity: 1.0,
            regularOpacity: 0.85,
            duration: 1000, // 4 секунди
            size: new Size(250, 60), // Зменшений розмір
            position: NotificationPosition.BottomRight // Нижній правий кут
        );
    }

    /// <summary>
    /// Відображення повідомлення про неуспішну операцію.
    /// </summary>
    /// <param name="message">Текст повідомлення.</param>
    public static async void ShowErrorNotification(string message)
    {
        await ShowNotification(
            message,
            backgroundColor: Color.FromArgb(20, 20, 20), // Темний фон
            textColor: Color.FromArgb(255, 0, 0), // Червоний текст
            font: new Font("Segoe UI", 9, FontStyle.Regular), // Сучасний шрифт
            logo: Image.FromFile("Icons/Error.png"), // Іконка помилки
            hoverOpacity: 1.0,
            regularOpacity: 0.85,
            duration: 5000, // 5 секунд
            size: new Size(250, 60), // Зменшений розмір
            position: NotificationPosition.BottomRight // Нижній правий кут
        );
    }

    /// <summary>
    /// Базовий метод для створення повідомлення.
    /// </summary>
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
        // Створюємо форму повідомлення
        Form notificationForm = new Form
        {
            Size = size,
            BackColor = backgroundColor ?? Color.DarkGray,
            FormBorderStyle = FormBorderStyle.None,
            StartPosition = FormStartPosition.Manual, // Встановлюємо координати вручну
            TopMost = true,
            Opacity = regularOpacity
        };

        // Встановлюємо позицію в залежності від екрана
        notificationForm.Location = CalculatePosition(size, position);

        // Додаємо іконку
        if (logo != null)
        {
            var pictureBox = new PictureBox
            {
                Image = logo,
                Size = new Size(30, 30), // Зменшена іконка
                Location = new Point(10, 15),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            notificationForm.Controls.Add(pictureBox);
        }

        // Додаємо текст
        var label = new Label
        {
            Text = text,
            Font = font,
            ForeColor = textColor ?? Color.White,
            BackColor = Color.Transparent,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleLeft,
            Location = new Point(50, 10), // Відступ від іконки
            Size = new Size(size.Width - 60, size.Height - 20) // Враховує розмір іконки
        };
        notificationForm.Controls.Add(label);

        // Події для прозорості
        notificationForm.MouseEnter += (s, e) => notificationForm.Opacity = hoverOpacity;
        notificationForm.MouseLeave += (s, e) => notificationForm.Opacity = regularOpacity;

        // Відображаємо повідомлення
        notificationForm.Show();

        // Очікуємо заданий час
        await Task.Delay(duration);

        // Закриваємо повідомлення
        if (!notificationForm.IsDisposed)
        {
            notificationForm.Close();
        }
    }

    /// <summary>
    /// Розрахунок позиції сповіщення.
    /// </summary>
    private static Point CalculatePosition(Size notificationSize, NotificationPosition position)
    {
        var screenBounds = Screen.PrimaryScreen.WorkingArea;

        return position switch
        {
            NotificationPosition.TopRight => new Point(
                screenBounds.Right - notificationSize.Width - 10,
                screenBounds.Top + 10),
            NotificationPosition.TopLeft => new Point(
                screenBounds.Left + 10,
                screenBounds.Top + 10),
            NotificationPosition.BottomRight => new Point(
                screenBounds.Right - notificationSize.Width - 10,
                screenBounds.Bottom - notificationSize.Height - 10),
            NotificationPosition.BottomLeft => new Point(
                screenBounds.Left + 10,
                screenBounds.Bottom - notificationSize.Height - 10),
            _ => new Point(screenBounds.Right - notificationSize.Width - 10, screenBounds.Bottom - notificationSize.Height - 10)
        };
    }
}

/// <summary>
/// Перерахування для позицій сповіщення.
/// </summary>
public enum NotificationPosition
{
    TopRight,
    TopLeft,
    BottomRight,
    BottomLeft
}
