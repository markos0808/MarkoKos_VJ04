namespace piClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationAddress = new System.Windows.Forms.MaskedTextBox();
            this.DestinationSetAction = new System.Windows.Forms.Button();
            this.ReceiveContainer = new System.Windows.Forms.TextBox();
            this.MessageToSend = new System.Windows.Forms.TextBox();
            this.MessageSendAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination";
            // 
            // DestinationAddress
            // 
            this.DestinationAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.DestinationAddress.Location = new System.Drawing.Point(91, 11);
            this.DestinationAddress.Mask = "990\\.990\\.990\\.990";
            this.DestinationAddress.Name = "DestinationAddress";
            this.DestinationAddress.Size = new System.Drawing.Size(100, 20);
            this.DestinationAddress.TabIndex = 1;
            this.DestinationAddress.Text = "000000000000";
            // 
            // DestinationSetAction
            // 
            this.DestinationSetAction.Location = new System.Drawing.Point(197, 9);
            this.DestinationSetAction.Name = "DestinationSetAction";
            this.DestinationSetAction.Size = new System.Drawing.Size(75, 23);
            this.DestinationSetAction.TabIndex = 2;
            this.DestinationSetAction.Text = "Set";
            this.DestinationSetAction.UseVisualStyleBackColor = true;
            this.DestinationSetAction.Click += new System.EventHandler(this.DestinationSetAction_Click);
            // 
            // ReceiveContainer
            // 
            this.ReceiveContainer.Location = new System.Drawing.Point(15, 51);
            this.ReceiveContainer.Multiline = true;
            this.ReceiveContainer.Name = "ReceiveContainer";
            this.ReceiveContainer.Size = new System.Drawing.Size(257, 161);
            this.ReceiveContainer.TabIndex = 3;
            // 
            // MessageToSend
            // 
            this.MessageToSend.Location = new System.Drawing.Point(15, 229);
            this.MessageToSend.Name = "MessageToSend";
            this.MessageToSend.Size = new System.Drawing.Size(147, 20);
            this.MessageToSend.TabIndex = 4;
            // 
            // MessageSendAction
            // 
            this.MessageSendAction.Location = new System.Drawing.Point(179, 227);
            this.MessageSendAction.Name = "MessageSendAction";
            this.MessageSendAction.Size = new System.Drawing.Size(75, 23);
            this.MessageSendAction.TabIndex = 5;
            this.MessageSendAction.Text = "Send";
            this.MessageSendAction.UseVisualStyleBackColor = true;
            this.MessageSendAction.Click += new System.EventHandler(this.MessageSendAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MessageSendAction);
            this.Controls.Add(this.MessageToSend);
            this.Controls.Add(this.ReceiveContainer);
            this.Controls.Add(this.DestinationSetAction);
            this.Controls.Add(this.DestinationAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "piClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox DestinationAddress;
        private System.Windows.Forms.Button DestinationSetAction;
        private System.Windows.Forms.TextBox ReceiveContainer;
        private System.Windows.Forms.TextBox MessageToSend;
        private System.Windows.Forms.Button MessageSendAction;
    }
}

