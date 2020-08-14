namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblPixel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.lblHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHead.Location = new System.Drawing.Point(394, 274);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(15, 15);
            this.lblHead.TabIndex = 0;
            // 
            // lblPixel
            // 
            this.lblPixel.BackColor = System.Drawing.Color.Crimson;
            this.lblPixel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPixel.ForeColor = System.Drawing.Color.Crimson;
            this.lblPixel.Location = new System.Drawing.Point(146, 59);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(15, 15);
            this.lblPixel.TabIndex = 1;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(564, 433);
            this.Controls.Add(this.lblPixel);
            this.Controls.Add(this.lblHead);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.Timer Timer;
    }
}

