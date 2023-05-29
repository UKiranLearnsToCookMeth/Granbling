
namespace Granbling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxDebug = new System.Windows.Forms.GroupBox();
            this.btnShowVar = new System.Windows.Forms.Button();
            this.btnSlots = new System.Windows.Forms.Button();
            this.btnBlackjack = new System.Windows.Forms.Button();
            this.gboxDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDebug
            // 
            this.gboxDebug.Controls.Add(this.btnShowVar);
            this.gboxDebug.Controls.Add(this.btnSlots);
            this.gboxDebug.Controls.Add(this.btnBlackjack);
            this.gboxDebug.Location = new System.Drawing.Point(993, 13);
            this.gboxDebug.Name = "gboxDebug";
            this.gboxDebug.Size = new System.Drawing.Size(241, 425);
            this.gboxDebug.TabIndex = 0;
            this.gboxDebug.TabStop = false;
            this.gboxDebug.Text = "debug box / game handler / whatrever";
            // 
            // btnShowVar
            // 
            this.btnShowVar.Location = new System.Drawing.Point(7, 78);
            this.btnShowVar.Name = "btnShowVar";
            this.btnShowVar.Size = new System.Drawing.Size(88, 23);
            this.btnShowVar.TabIndex = 2;
            this.btnShowVar.Text = "Show Variables";
            this.btnShowVar.UseVisualStyleBackColor = true;
            // 
            // btnSlots
            // 
            this.btnSlots.Location = new System.Drawing.Point(6, 49);
            this.btnSlots.Name = "btnSlots";
            this.btnSlots.Size = new System.Drawing.Size(79, 23);
            this.btnSlots.TabIndex = 1;
            this.btnSlots.Text = "do Slots";
            this.btnSlots.UseVisualStyleBackColor = true;
            this.btnSlots.Click += new System.EventHandler(this.btnSlots_Click);
            // 
            // btnBlackjack
            // 
            this.btnBlackjack.Location = new System.Drawing.Point(7, 20);
            this.btnBlackjack.Name = "btnBlackjack";
            this.btnBlackjack.Size = new System.Drawing.Size(78, 23);
            this.btnBlackjack.TabIndex = 0;
            this.btnBlackjack.Text = "do Blackjack";
            this.btnBlackjack.UseVisualStyleBackColor = true;
            this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 450);
            this.Controls.Add(this.gboxDebug);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Granbling - Jurm 2 in 2024";
            this.gboxDebug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDebug;
        private System.Windows.Forms.Button btnShowVar;
        private System.Windows.Forms.Button btnSlots;
        private System.Windows.Forms.Button btnBlackjack;
    }
}

