namespace _2_задание
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
            textBoxName = new TextBox();
            buttonGreat = new Button();
            labelGreeting = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Info;
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxName.ForeColor = Color.RosyBrown;
            textBoxName.Location = new Point(46, 44);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(373, 36);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Ваше имя";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonGreat
            // 
            buttonGreat.BackColor = SystemColors.ActiveCaption;
            buttonGreat.Cursor = Cursors.Hand;
            buttonGreat.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            buttonGreat.FlatAppearance.BorderSize = 3;
            buttonGreat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonGreat.ForeColor = SystemColors.MenuHighlight;
            buttonGreat.Location = new Point(96, 118);
            buttonGreat.Name = "buttonGreat";
            buttonGreat.Size = new Size(282, 43);
            buttonGreat.TabIndex = 1;
            buttonGreat.Text = "Приветствие";
            buttonGreat.UseVisualStyleBackColor = false;
            buttonGreat.Click += buttonGreat_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.Cursor = Cursors.IBeam;
            labelGreeting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelGreeting.ForeColor = SystemColors.HotTrack;
            labelGreeting.Location = new Point(46, 209);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(373, 44);
            labelGreeting.TabIndex = 2;
            labelGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(466, 281);
            Controls.Add(labelGreeting);
            Controls.Add(buttonGreat);
            Controls.Add(textBoxName);
            ForeColor = SystemColors.WindowText;
            Name = "Form1";
            Text = "Приветствие";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Button buttonGreat;
        private Label labelGreeting;
    }
}
