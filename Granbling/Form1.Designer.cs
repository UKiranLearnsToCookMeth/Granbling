
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
            this.pnlBlackjack = new System.Windows.Forms.Panel();
            this.btnBJ_Hit = new System.Windows.Forms.Button();
            this.lblBJ_DealerCards = new System.Windows.Forms.Label();
            this.lblBJ_PlayerCards = new System.Windows.Forms.Label();
            this.btnBJ_Stay = new System.Windows.Forms.Button();
            this.btnBJ_Exit = new System.Windows.Forms.Button();
            this.gboxDebug.SuspendLayout();
            this.pnlBlackjack.SuspendLayout();
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
            // pnlBlackjack
            // 
            this.pnlBlackjack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBlackjack.Controls.Add(this.btnBJ_Exit);
            this.pnlBlackjack.Controls.Add(this.btnBJ_Stay);
            this.pnlBlackjack.Controls.Add(this.btnBJ_Hit);
            this.pnlBlackjack.Controls.Add(this.lblBJ_DealerCards);
            this.pnlBlackjack.Controls.Add(this.lblBJ_PlayerCards);
            this.pnlBlackjack.Location = new System.Drawing.Point(12, 12);
            this.pnlBlackjack.Name = "pnlBlackjack";
            this.pnlBlackjack.Size = new System.Drawing.Size(851, 383);
            this.pnlBlackjack.TabIndex = 1;
            // 
            // btnBJ_Hit
            // 
            this.btnBJ_Hit.Location = new System.Drawing.Point(203, 215);
            this.btnBJ_Hit.Name = "btnBJ_Hit";
            this.btnBJ_Hit.Size = new System.Drawing.Size(75, 23);
            this.btnBJ_Hit.TabIndex = 2;
            this.btnBJ_Hit.Text = "Hit!";
            this.btnBJ_Hit.UseVisualStyleBackColor = true;
            this.btnBJ_Hit.Click += new System.EventHandler(this.btnBJ_Hit_Click);
            // 
            // lblBJ_DealerCards
            // 
            this.lblBJ_DealerCards.AutoSize = true;
            this.lblBJ_DealerCards.Location = new System.Drawing.Point(202, 180);
            this.lblBJ_DealerCards.Name = "lblBJ_DealerCards";
            this.lblBJ_DealerCards.Size = new System.Drawing.Size(76, 13);
            this.lblBJ_DealerCards.TabIndex = 1;
            this.lblBJ_DealerCards.Text = "Dealers Cards:";
            // 
            // lblBJ_PlayerCards
            // 
            this.lblBJ_PlayerCards.AutoSize = true;
            this.lblBJ_PlayerCards.Location = new System.Drawing.Point(200, 154);
            this.lblBJ_PlayerCards.Name = "lblBJ_PlayerCards";
            this.lblBJ_PlayerCards.Size = new System.Drawing.Size(62, 13);
            this.lblBJ_PlayerCards.TabIndex = 0;
            this.lblBJ_PlayerCards.Text = "Your Cards:";
            // 
            // btnBJ_Stay
            // 
            this.btnBJ_Stay.Location = new System.Drawing.Point(284, 215);
            this.btnBJ_Stay.Name = "btnBJ_Stay";
            this.btnBJ_Stay.Size = new System.Drawing.Size(75, 23);
            this.btnBJ_Stay.TabIndex = 3;
            this.btnBJ_Stay.Text = "Stay!";
            this.btnBJ_Stay.UseVisualStyleBackColor = true;
            this.btnBJ_Stay.Click += new System.EventHandler(this.btnBJ_Stay_Click);
            // 
            // btnBJ_Exit
            // 
            this.btnBJ_Exit.Location = new System.Drawing.Point(202, 284);
            this.btnBJ_Exit.Name = "btnBJ_Exit";
            this.btnBJ_Exit.Size = new System.Drawing.Size(75, 23);
            this.btnBJ_Exit.TabIndex = 4;
            this.btnBJ_Exit.Text = "Exit";
            this.btnBJ_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 450);
            this.Controls.Add(this.pnlBlackjack);
            this.Controls.Add(this.gboxDebug);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Granbling - Jurm 2 in 2024";
            this.gboxDebug.ResumeLayout(false);
            this.pnlBlackjack.ResumeLayout(false);
            this.pnlBlackjack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDebug;
        private System.Windows.Forms.Button btnShowVar;
        private System.Windows.Forms.Button btnSlots;
        private System.Windows.Forms.Button btnBlackjack;
        private System.Windows.Forms.Panel pnlBlackjack;
        private System.Windows.Forms.Label lblBJ_PlayerCards;
        private System.Windows.Forms.Label lblBJ_DealerCards;
        private System.Windows.Forms.Button btnBJ_Hit;
        private System.Windows.Forms.Button btnBJ_Exit;
        private System.Windows.Forms.Button btnBJ_Stay;
    }
}

