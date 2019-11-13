namespace DeckOfCards_Serialization
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
            this.serializeDeckButton = new System.Windows.Forms.Button();
            this.readDeckButton = new System.Windows.Forms.Button();
            this.serializeDecksButton = new System.Windows.Forms.Button();
            this.readDecksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serializeDeckButton
            // 
            this.serializeDeckButton.Location = new System.Drawing.Point(12, 12);
            this.serializeDeckButton.Name = "serializeDeckButton";
            this.serializeDeckButton.Size = new System.Drawing.Size(124, 23);
            this.serializeDeckButton.TabIndex = 0;
            this.serializeDeckButton.Text = "Serialize random deck";
            this.serializeDeckButton.UseVisualStyleBackColor = true;
            this.serializeDeckButton.Click += new System.EventHandler(this.serializeDeckButton_Click);
            // 
            // readDeckButton
            // 
            this.readDeckButton.Location = new System.Drawing.Point(142, 12);
            this.readDeckButton.Name = "readDeckButton";
            this.readDeckButton.Size = new System.Drawing.Size(124, 23);
            this.readDeckButton.TabIndex = 1;
            this.readDeckButton.Text = "Read deck from file";
            this.readDeckButton.UseVisualStyleBackColor = true;
            this.readDeckButton.Click += new System.EventHandler(this.readDeckButton_Click);
            // 
            // serializeDecksButton
            // 
            this.serializeDecksButton.Location = new System.Drawing.Point(12, 41);
            this.serializeDecksButton.Name = "serializeDecksButton";
            this.serializeDecksButton.Size = new System.Drawing.Size(124, 23);
            this.serializeDecksButton.TabIndex = 2;
            this.serializeDecksButton.Text = "Serialize random decks";
            this.serializeDecksButton.UseVisualStyleBackColor = true;
            this.serializeDecksButton.Click += new System.EventHandler(this.serializeDecksButton_Click);
            // 
            // readDecksButton
            // 
            this.readDecksButton.Location = new System.Drawing.Point(142, 41);
            this.readDecksButton.Name = "readDecksButton";
            this.readDecksButton.Size = new System.Drawing.Size(124, 23);
            this.readDecksButton.TabIndex = 3;
            this.readDecksButton.Text = "Read decks from file";
            this.readDecksButton.UseVisualStyleBackColor = true;
            this.readDecksButton.Click += new System.EventHandler(this.readDecksButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.readDecksButton);
            this.Controls.Add(this.serializeDecksButton);
            this.Controls.Add(this.readDeckButton);
            this.Controls.Add(this.serializeDeckButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Decks Serialization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serializeDeckButton;
        private System.Windows.Forms.Button readDeckButton;
        private System.Windows.Forms.Button serializeDecksButton;
        private System.Windows.Forms.Button readDecksButton;
    }
}

