namespace FinjectorV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            codeEditor = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            pbStatusGreen = new CodeeloUI.Controls.CodeeloPictureBox();
            pbStatusRed = new CodeeloUI.Controls.CodeeloPictureBox();
            btnMinimize = new CodeeloUI.Controls.CodeeloButton();
            btnClose = new CodeeloUI.Controls.CodeeloButton();
            btnExecute = new CodeeloUI.Controls.CodeeloButton();
            btnClear = new CodeeloUI.Controls.CodeeloButton();
            btnAttach = new CodeeloUI.Controls.CodeeloButton();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)codeEditor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatusGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusRed).BeginInit();
            SuspendLayout();
            // 
            // codeEditor
            // 
            codeEditor.AllowExternalDrop = true;
            codeEditor.CreationProperties = null;
            codeEditor.DefaultBackgroundColor = Color.White;
            codeEditor.Location = new Point(12, 78);
            codeEditor.Name = "codeEditor";
            codeEditor.Size = new Size(643, 360);
            codeEditor.TabIndex = 0;
            codeEditor.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(pbStatusGreen);
            panel1.Controls.Add(pbStatusRed);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 32);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pbStatusGreen
            // 
            pbStatusGreen.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbStatusGreen.BorderColorFirst = Color.RoyalBlue;
            pbStatusGreen.BorderColorSecond = Color.HotPink;
            pbStatusGreen.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbStatusGreen.BorderSize = 2;
            pbStatusGreen.DrawBorder = false;
            pbStatusGreen.DrawBorderInside = false;
            pbStatusGreen.DrawCircle = false;
            pbStatusGreen.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            pbStatusGreen.Image = (Image)resources.GetObject("pbStatusGreen.Image");
            pbStatusGreen.Location = new Point(17, 3);
            pbStatusGreen.Name = "pbStatusGreen";
            pbStatusGreen.Size = new Size(21, 19);
            pbStatusGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStatusGreen.TabIndex = 7;
            pbStatusGreen.TabStop = false;
            pbStatusGreen.UseGradient = false;
            // 
            // pbStatusRed
            // 
            pbStatusRed.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbStatusRed.BorderColorFirst = Color.RoyalBlue;
            pbStatusRed.BorderColorSecond = Color.HotPink;
            pbStatusRed.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbStatusRed.BorderSize = 2;
            pbStatusRed.DrawBorder = false;
            pbStatusRed.DrawBorderInside = false;
            pbStatusRed.DrawCircle = false;
            pbStatusRed.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            pbStatusRed.Image = (Image)resources.GetObject("pbStatusRed.Image");
            pbStatusRed.Location = new Point(17, 3);
            pbStatusRed.Name = "pbStatusRed";
            pbStatusRed.Size = new Size(21, 19);
            pbStatusRed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStatusRed.TabIndex = 6;
            pbStatusRed.TabStop = false;
            pbStatusRed.UseGradient = false;
            // 
            // btnMinimize
            // 
            btnMinimize.AccessibleRole = null;
            btnMinimize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BorderColor_1 = Color.Transparent;
            btnMinimize.BorderColor_2 = Color.Transparent;
            btnMinimize.BorderRadius = 5;
            btnMinimize.BorderSize = 3;
            btnMinimize.CausesValidation = false;
            btnMinimize.ColorFill_1 = Color.FromArgb(18, 18, 18);
            btnMinimize.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnMinimize.DialogResult = false;
            btnMinimize.DrawTextShadow = true;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.Silver;
            btnMinimize.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnMinimize.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnMinimize.Location = new Point(715, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.OnClick_BorderColor_1 = Color.Transparent;
            btnMinimize.OnClick_BorderColor_2 = Color.Transparent;
            btnMinimize.OnClick_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnMinimize.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnMinimize.OnOver_BorderColor_1 = Color.Transparent;
            btnMinimize.OnOver_BorderColor_2 = Color.Transparent;
            btnMinimize.OnOver_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnMinimize.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnMinimize.Size = new Size(36, 28);
            btnMinimize.TabIndex = 6;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "-";
            btnMinimize.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnMinimize.UseMnemonic = false;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.AccessibleRole = null;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderColor_1 = Color.Transparent;
            btnClose.BorderColor_2 = Color.Transparent;
            btnClose.BorderRadius = 5;
            btnClose.BorderSize = 3;
            btnClose.CausesValidation = false;
            btnClose.ColorFill_1 = Color.FromArgb(18, 18, 18);
            btnClose.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnClose.DialogResult = false;
            btnClose.DrawTextShadow = true;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Silver;
            btnClose.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClose.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClose.Location = new Point(757, 3);
            btnClose.Name = "btnClose";
            btnClose.OnClick_BorderColor_1 = Color.Transparent;
            btnClose.OnClick_BorderColor_2 = Color.Transparent;
            btnClose.OnClick_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnClose.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnClose.OnOver_BorderColor_1 = Color.Transparent;
            btnClose.OnOver_BorderColor_2 = Color.Transparent;
            btnClose.OnOver_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnClose.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnClose.Size = new Size(36, 28);
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnClose.UseMnemonic = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExecute
            // 
            btnExecute.AccessibleRole = null;
            btnExecute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExecute.BackColor = Color.Transparent;
            btnExecute.BorderColor_1 = Color.Transparent;
            btnExecute.BorderColor_2 = Color.Transparent;
            btnExecute.BorderRadius = 5;
            btnExecute.BorderSize = 3;
            btnExecute.CausesValidation = false;
            btnExecute.ColorFill_1 = Color.FromArgb(30, 30, 30);
            btnExecute.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnExecute.DialogResult = false;
            btnExecute.DrawTextShadow = true;
            btnExecute.FlatAppearance.BorderSize = 0;
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExecute.ForeColor = Color.Silver;
            btnExecute.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnExecute.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnExecute.Location = new Point(12, 38);
            btnExecute.Name = "btnExecute";
            btnExecute.OnClick_BorderColor_1 = Color.Transparent;
            btnExecute.OnClick_BorderColor_2 = Color.Transparent;
            btnExecute.OnClick_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnExecute.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnExecute.OnOver_BorderColor_1 = Color.Transparent;
            btnExecute.OnOver_BorderColor_2 = Color.Transparent;
            btnExecute.OnOver_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnExecute.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnExecute.Size = new Size(96, 34);
            btnExecute.TabIndex = 2;
            btnExecute.TabStop = false;
            btnExecute.Text = "Execute";
            btnExecute.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnExecute.UseMnemonic = false;
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnClear
            // 
            btnClear.AccessibleRole = null;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.BackColor = Color.Transparent;
            btnClear.BorderColor_1 = Color.Transparent;
            btnClear.BorderColor_2 = Color.Transparent;
            btnClear.BorderRadius = 5;
            btnClear.BorderSize = 3;
            btnClear.CausesValidation = false;
            btnClear.ColorFill_1 = Color.FromArgb(30, 30, 30);
            btnClear.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnClear.DialogResult = false;
            btnClear.DrawTextShadow = true;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Silver;
            btnClear.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClear.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnClear.Location = new Point(114, 38);
            btnClear.Name = "btnClear";
            btnClear.OnClick_BorderColor_1 = Color.Transparent;
            btnClear.OnClick_BorderColor_2 = Color.Transparent;
            btnClear.OnClick_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnClear.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnClear.OnOver_BorderColor_1 = Color.Transparent;
            btnClear.OnOver_BorderColor_2 = Color.Transparent;
            btnClear.OnOver_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnClear.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnClear.Size = new Size(96, 34);
            btnClear.TabIndex = 3;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnClear.UseMnemonic = false;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAttach
            // 
            btnAttach.AccessibleRole = null;
            btnAttach.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAttach.BackColor = Color.Transparent;
            btnAttach.BorderColor_1 = Color.Transparent;
            btnAttach.BorderColor_2 = Color.Transparent;
            btnAttach.BorderRadius = 5;
            btnAttach.BorderSize = 3;
            btnAttach.CausesValidation = false;
            btnAttach.ColorFill_1 = Color.FromArgb(30, 30, 30);
            btnAttach.ColorFill_2 = Color.FromArgb(159, 185, 189);
            btnAttach.DialogResult = false;
            btnAttach.DrawTextShadow = true;
            btnAttach.FlatAppearance.BorderSize = 0;
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttach.ForeColor = Color.Silver;
            btnAttach.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAttach.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAttach.Location = new Point(692, 38);
            btnAttach.Name = "btnAttach";
            btnAttach.OnClick_BorderColor_1 = Color.Transparent;
            btnAttach.OnClick_BorderColor_2 = Color.Transparent;
            btnAttach.OnClick_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnAttach.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnAttach.OnOver_BorderColor_1 = Color.Transparent;
            btnAttach.OnOver_BorderColor_2 = Color.Transparent;
            btnAttach.OnOver_FillColor_1 = Color.FromArgb(220, 85, 85);
            btnAttach.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnAttach.Size = new Size(96, 34);
            btnAttach.TabIndex = 4;
            btnAttach.TabStop = false;
            btnAttach.Text = "Attach";
            btnAttach.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnAttach.UseMnemonic = false;
            btnAttach.UseVisualStyleBackColor = false;
            btnAttach.Click += btnAttach_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(796, 450);
            Controls.Add(btnAttach);
            Controls.Add(btnClear);
            Controls.Add(btnExecute);
            Controls.Add(panel1);
            Controls.Add(codeEditor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)codeEditor).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStatusGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatusRed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 codeEditor;
        private Panel panel1;
        private CodeeloUI.Controls.CodeeloButton btnExecute;
        private CodeeloUI.Controls.CodeeloButton btnClear;
        private CodeeloUI.Controls.CodeeloButton btnAttach;
        private CodeeloUI.Controls.CodeeloButton btnMinimize;
        private CodeeloUI.Controls.CodeeloButton btnClose;
        private CodeeloUI.Controls.CodeeloPictureBox pbStatusGreen;
        private CodeeloUI.Controls.CodeeloPictureBox pbStatusRed;
        private System.Windows.Forms.Timer timer1;
    }
}
