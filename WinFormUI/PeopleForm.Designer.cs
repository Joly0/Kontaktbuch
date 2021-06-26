namespace WinFormUI
{
    partial class PeopleForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lieblingsLehrerText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lieblingsDinoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonLöschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(46, 101);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(135, 36);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Vorname";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(46, 190);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(157, 36);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Nachname";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(52, 137);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(234, 41);
            this.firstNameText.TabIndex = 5;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(52, 226);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(234, 41);
            this.lastNameText.TabIndex = 6;
            // 
            // lieblingsLehrerText
            // 
            this.lieblingsLehrerText.Location = new System.Drawing.Point(52, 330);
            this.lieblingsLehrerText.Name = "lieblingsLehrerText";
            this.lieblingsLehrerText.Size = new System.Drawing.Size(234, 41);
            this.lieblingsLehrerText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lieblingslehrer";
            // 
            // lieblingsDinoText
            // 
            this.lieblingsDinoText.Location = new System.Drawing.Point(52, 443);
            this.lieblingsDinoText.Name = "lieblingsDinoText";
            this.lieblingsDinoText.Size = new System.Drawing.Size(234, 41);
            this.lieblingsDinoText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lieblingsdino";
            // 
            // addPersonHeader
            // 
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(32, 42);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(305, 52);
            this.addPersonHeader.TabIndex = 9;
            this.addPersonHeader.Text = "Dateneingabe";
            // 
            // listPeopleHeader
            // 
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(380, 42);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(202, 52);
            this.listPeopleHeader.TabIndex = 10;
            this.listPeopleHeader.Text = "Kontakte";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(52, 540);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(234, 69);
            this.addPersonButton.TabIndex = 11;
            this.addPersonButton.Text = "Hinzufügen\r\nÄndern";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 364);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // PersonLöschen
            // 
            this.PersonLöschen.Location = new System.Drawing.Point(354, 540);
            this.PersonLöschen.Name = "PersonLöschen";
            this.PersonLöschen.Size = new System.Drawing.Size(206, 69);
            this.PersonLöschen.TabIndex = 14;
            this.PersonLöschen.Text = "Löschen";
            this.PersonLöschen.UseVisualStyleBackColor = true;
            this.PersonLöschen.Click += new System.EventHandler(this.personLöschen_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 650);
            this.Controls.Add(this.PersonLöschen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.lieblingsDinoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lieblingsLehrerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontaktbuch";
            this.Shown += new System.EventHandler(this.People_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox lieblingsLehrerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lieblingsDinoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PersonLöschen;
    }
}

