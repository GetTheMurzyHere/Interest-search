namespace Поиск_интересов
{
    partial class InterestSearch
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoardWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BoardWindow
            // 
            this.BoardWindow.AutoScroll = true;
            this.BoardWindow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BoardWindow.Location = new System.Drawing.Point(386, 12);
            this.BoardWindow.Name = "BoardWindow";
            this.BoardWindow.Size = new System.Drawing.Size(509, 582);
            this.BoardWindow.TabIndex = 0;
            // 
            // InterestSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 606);
            this.Controls.Add(this.BoardWindow);
            this.Name = "InterestSearch";
            this.Text = "InterestSearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BoardWindow;
    }
}

