
namespace SQL_transaktion_Forms
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
            this.FlyNummerLabel = new System.Windows.Forms.Label();
            this.FlyNummerComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionLabel = new System.Windows.Forms.Label();
            this.GetSeatLabel = new System.Windows.Forms.Label();
            this.GetSeatsLabel = new System.Windows.Forms.Label();
            this.UncommitedButton = new System.Windows.Forms.Button();
            this.SerializableButton = new System.Windows.Forms.Button();
            this.FreeSeatsLabel = new System.Windows.Forms.Label();
            this.FreeSeatsTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfSeatsLabel = new System.Windows.Forms.Label();
            this.ReserveTextbox = new System.Windows.Forms.TextBox();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.FeedbackTextbox = new System.Windows.Forms.TextBox();
            this.CommitButton = new System.Windows.Forms.Button();
            this.RollbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlyNummerLabel
            // 
            this.FlyNummerLabel.AutoSize = true;
            this.FlyNummerLabel.Location = new System.Drawing.Point(52, 43);
            this.FlyNummerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlyNummerLabel.Name = "FlyNummerLabel";
            this.FlyNummerLabel.Size = new System.Drawing.Size(79, 16);
            this.FlyNummerLabel.TabIndex = 0;
            this.FlyNummerLabel.Text = "Fly nummer:";
            // 
            // FlyNummerComboBox
            // 
            this.FlyNummerComboBox.FormattingEnabled = true;
            this.FlyNummerComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.FlyNummerComboBox.Location = new System.Drawing.Point(175, 43);
            this.FlyNummerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlyNummerComboBox.Name = "FlyNummerComboBox";
            this.FlyNummerComboBox.Size = new System.Drawing.Size(160, 24);
            this.FlyNummerComboBox.TabIndex = 1;
            this.FlyNummerComboBox.SelectedIndexChanged += new System.EventHandler(this.FlyNummerComboBox_SelectedIndexChanged);
            // 
            // TransactionLabel
            // 
            this.TransactionLabel.AutoSize = true;
            this.TransactionLabel.Location = new System.Drawing.Point(52, 116);
            this.TransactionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransactionLabel.Name = "TransactionLabel";
            this.TransactionLabel.Size = new System.Drawing.Size(81, 16);
            this.TransactionLabel.TabIndex = 2;
            this.TransactionLabel.Text = "Transaction:";
            // 
            // GetSeatLabel
            // 
            this.GetSeatLabel.AutoSize = true;
            this.GetSeatLabel.Location = new System.Drawing.Point(79, 154);
            this.GetSeatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetSeatLabel.Name = "GetSeatLabel";
            this.GetSeatLabel.Size = new System.Drawing.Size(67, 16);
            this.GetSeatLabel.TabIndex = 3;
            this.GetSeatLabel.Text = "Get seats:";
            // 
            // GetSeatsLabel
            // 
            this.GetSeatsLabel.AutoSize = true;
            this.GetSeatsLabel.Location = new System.Drawing.Point(83, 193);
            this.GetSeatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetSeatsLabel.Name = "GetSeatsLabel";
            this.GetSeatsLabel.Size = new System.Drawing.Size(192, 16);
            this.GetSeatsLabel.TabIndex = 4;
            this.GetSeatsLabel.Text = "Get available seats by method:";
            // 
            // UncommitedButton
            // 
            this.UncommitedButton.Location = new System.Drawing.Point(40, 238);
            this.UncommitedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UncommitedButton.Name = "UncommitedButton";
            this.UncommitedButton.Size = new System.Drawing.Size(136, 28);
            this.UncommitedButton.TabIndex = 5;
            this.UncommitedButton.Text = "Read uncommited";
            this.UncommitedButton.UseVisualStyleBackColor = true;
            this.UncommitedButton.Click += new System.EventHandler(this.UncommitedButton_Click);
            // 
            // SerializableButton
            // 
            this.SerializableButton.Location = new System.Drawing.Point(216, 238);
            this.SerializableButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerializableButton.Name = "SerializableButton";
            this.SerializableButton.Size = new System.Drawing.Size(100, 28);
            this.SerializableButton.TabIndex = 6;
            this.SerializableButton.Text = "Serializable";
            this.SerializableButton.UseVisualStyleBackColor = true;
            this.SerializableButton.Click += new System.EventHandler(this.SerializableButton_Click);
            // 
            // FreeSeatsLabel
            // 
            this.FreeSeatsLabel.AutoSize = true;
            this.FreeSeatsLabel.Location = new System.Drawing.Point(52, 295);
            this.FreeSeatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FreeSeatsLabel.Name = "FreeSeatsLabel";
            this.FreeSeatsLabel.Size = new System.Drawing.Size(161, 16);
            this.FreeSeatsLabel.TabIndex = 7;
            this.FreeSeatsLabel.Text = "Free seats on the flightNo:";
            // 
            // FreeSeatsTextbox
            // 
            this.FreeSeatsTextbox.Location = new System.Drawing.Point(240, 295);
            this.FreeSeatsTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FreeSeatsTextbox.Name = "FreeSeatsTextbox";
            this.FreeSeatsTextbox.Size = new System.Drawing.Size(132, 22);
            this.FreeSeatsTextbox.TabIndex = 8;
            // 
            // NumberOfSeatsLabel
            // 
            this.NumberOfSeatsLabel.AutoSize = true;
            this.NumberOfSeatsLabel.Location = new System.Drawing.Point(41, 369);
            this.NumberOfSeatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel";
            this.NumberOfSeatsLabel.Size = new System.Drawing.Size(176, 16);
            this.NumberOfSeatsLabel.TabIndex = 9;
            this.NumberOfSeatsLabel.Text = "Number og seats to reserve:";
            // 
            // ReserveTextbox
            // 
            this.ReserveTextbox.Location = new System.Drawing.Point(240, 369);
            this.ReserveTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReserveTextbox.Name = "ReserveTextbox";
            this.ReserveTextbox.Size = new System.Drawing.Size(132, 22);
            this.ReserveTextbox.TabIndex = 10;
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(115, 430);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(128, 28);
            this.ReserveButton.TabIndex = 11;
            this.ReserveButton.Text = "Reserve Seats";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(52, 581);
            this.FeedbackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(142, 16);
            this.FeedbackLabel.TabIndex = 12;
            this.FeedbackLabel.Text = "Feedback from server:";
            // 
            // FeedbackTextbox
            // 
            this.FeedbackTextbox.Location = new System.Drawing.Point(216, 581);
            this.FeedbackTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FeedbackTextbox.Name = "FeedbackTextbox";
            this.FeedbackTextbox.Size = new System.Drawing.Size(132, 22);
            this.FeedbackTextbox.TabIndex = 13;
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(56, 501);
            this.CommitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(100, 28);
            this.CommitButton.TabIndex = 14;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            // 
            // RollbackButton
            // 
            this.RollbackButton.Location = new System.Drawing.Point(185, 501);
            this.RollbackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RollbackButton.Name = "RollbackButton";
            this.RollbackButton.Size = new System.Drawing.Size(100, 28);
            this.RollbackButton.TabIndex = 15;
            this.RollbackButton.Text = "Rollback";
            this.RollbackButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 657);
            this.Controls.Add(this.RollbackButton);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.FeedbackTextbox);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.ReserveTextbox);
            this.Controls.Add(this.NumberOfSeatsLabel);
            this.Controls.Add(this.FreeSeatsTextbox);
            this.Controls.Add(this.FreeSeatsLabel);
            this.Controls.Add(this.SerializableButton);
            this.Controls.Add(this.UncommitedButton);
            this.Controls.Add(this.GetSeatsLabel);
            this.Controls.Add(this.GetSeatLabel);
            this.Controls.Add(this.TransactionLabel);
            this.Controls.Add(this.FlyNummerComboBox);
            this.Controls.Add(this.FlyNummerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlyNummerLabel;
        private System.Windows.Forms.ComboBox FlyNummerComboBox;
        private System.Windows.Forms.Label TransactionLabel;
        private System.Windows.Forms.Label GetSeatLabel;
        private System.Windows.Forms.Label GetSeatsLabel;
        private System.Windows.Forms.Button UncommitedButton;
        private System.Windows.Forms.Button SerializableButton;
        private System.Windows.Forms.Label FreeSeatsLabel;
        private System.Windows.Forms.TextBox FreeSeatsTextbox;
        private System.Windows.Forms.Label NumberOfSeatsLabel;
        private System.Windows.Forms.TextBox ReserveTextbox;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.TextBox FeedbackTextbox;
        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.Button RollbackButton;
    }
}

