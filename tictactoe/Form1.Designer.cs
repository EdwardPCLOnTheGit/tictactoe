﻿namespace tictactoe
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUtimer = new System.Windows.Forms.Timer(components);
            Turno = new Label();
            SalvaSuFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "Vittorie Giocatore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(319, 3);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Vittorie CPU";
            label2.Click += SalvaFile;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button1.Location = new Point(12, 51);
            button1.Name = "button1";
            button1.Size = new Size(150, 110);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button2.Location = new Point(168, 51);
            button2.Name = "button2";
            button2.Size = new Size(150, 110);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button3.Location = new Point(332, 51);
            button3.Name = "button3";
            button3.Size = new Size(150, 110);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button4.Location = new Point(332, 176);
            button4.Name = "button4";
            button4.Size = new Size(150, 110);
            button4.TabIndex = 7;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button5.Location = new Point(168, 176);
            button5.Name = "button5";
            button5.Size = new Size(150, 110);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button6.Location = new Point(12, 176);
            button6.Name = "button6";
            button6.Size = new Size(150, 110);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button7.Location = new Point(332, 302);
            button7.Name = "button7";
            button7.Size = new Size(150, 110);
            button7.TabIndex = 10;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button8.Location = new Point(168, 302);
            button8.Name = "button8";
            button8.Size = new Size(150, 110);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            button9.Location = new Point(12, 302);
            button9.Name = "button9";
            button9.Size = new Size(150, 110);
            button9.TabIndex = 8;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClick;
            // 
            // button10
            // 
            button10.Location = new Point(159, 418);
            button10.Name = "button10";
            button10.Size = new Size(159, 34);
            button10.TabIndex = 11;
            button10.Text = "Nuova Partita";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // CPUtimer
            // 
            CPUtimer.Interval = 1000;
            CPUtimer.Tick += CPUmove;
            // 
            // Turno
            // 
            Turno.AutoSize = true;
            Turno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Turno.Location = new Point(206, 3);
            Turno.Name = "Turno";
            Turno.Size = new Size(76, 25);
            Turno.TabIndex = 12;
            Turno.Text = "Turno: ";
            // 
            // SalvaSuFile
            // 
            SalvaSuFile.Location = new Point(342, 418);
            SalvaSuFile.Name = "SalvaSuFile";
            SalvaSuFile.Size = new Size(128, 32);
            SalvaSuFile.TabIndex = 13;
            SalvaSuFile.Text = "Salva su File";
            SalvaSuFile.UseVisualStyleBackColor = true;
            SalvaSuFile.Click += SalvaFile;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(SalvaSuFile);
            Controls.Add(Turno);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUtimer;
        private Label Turno;
        private Button SalvaSuFile;
    }
}
