namespace Lesson19._1
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
            progressPB = new ProgressBar();
            buttonStartBTM = new Button();
            buttonSecond = new Button();
            SecondsProgressPB = new ProgressBar();
            SuspendLayout();
            // 
            // progressPB
            // 
            progressPB.Location = new Point(17, 11);
            progressPB.Name = "progressPB";
            progressPB.Size = new Size(1013, 16);
            progressPB.TabIndex = 0;
            // 
            // buttonStartBTM
            // 
            buttonStartBTM.Location = new Point(883, 33);
            buttonStartBTM.Name = "buttonStartBTM";
            buttonStartBTM.Size = new Size(147, 33);
            buttonStartBTM.TabIndex = 1;
            buttonStartBTM.Text = "Запуск";
            buttonStartBTM.UseVisualStyleBackColor = true;
            buttonStartBTM.Click += buttonStartBTM_Click;
            // 
            // buttonSecond
            // 
            buttonSecond.Location = new Point(883, 94);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(147, 33);
            buttonSecond.TabIndex = 3;
            buttonSecond.Text = "Запуск";
            buttonSecond.UseVisualStyleBackColor = true;
            buttonSecond.Click += buttonSecond_Click;
            // 
            // SecondsProgressPB
            // 
            SecondsProgressPB.Location = new Point(17, 72);
            SecondsProgressPB.Name = "SecondsProgressPB";
            SecondsProgressPB.Size = new Size(1013, 16);
            SecondsProgressPB.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 144);
            Controls.Add(buttonSecond);
            Controls.Add(SecondsProgressPB);
            Controls.Add(buttonStartBTM);
            Controls.Add(progressPB);
            Name = "Form1";
            Text = "Потоки";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressPB;
        private Button buttonStartBTM;
        private Button buttonSecond;
        private ProgressBar SecondsProgressPB;
    }
}