namespace RabbitMQApp
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
            this.btnConnectRabbitMq = new System.Windows.Forms.Button();
            this.btnCreateExchange = new System.Windows.Forms.Button();
            this.btnCreateQueues = new System.Windows.Forms.Button();
            this.btnBindQueues = new System.Windows.Forms.Button();
            this.txtBoxPublishEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublishEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPublishSms = new System.Windows.Forms.TextBox();
            this.btnPublishSMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectRabbitMq
            // 
            this.btnConnectRabbitMq.Location = new System.Drawing.Point(61, 12);
            this.btnConnectRabbitMq.Name = "btnConnectRabbitMq";
            this.btnConnectRabbitMq.Size = new System.Drawing.Size(206, 34);
            this.btnConnectRabbitMq.TabIndex = 0;
            this.btnConnectRabbitMq.Text = "Connect RabbitMQ";
            this.btnConnectRabbitMq.UseVisualStyleBackColor = true;
            this.btnConnectRabbitMq.Click += new System.EventHandler(this.btnConnectRabbitMq_Click);
            // 
            // btnCreateExchange
            // 
            this.btnCreateExchange.Location = new System.Drawing.Point(61, 72);
            this.btnCreateExchange.Name = "btnCreateExchange";
            this.btnCreateExchange.Size = new System.Drawing.Size(206, 29);
            this.btnCreateExchange.TabIndex = 1;
            this.btnCreateExchange.Text = "Create Exchange";
            this.btnCreateExchange.UseVisualStyleBackColor = true;
            this.btnCreateExchange.Click += new System.EventHandler(this.btnCreateExchange_Click);
            // 
            // btnCreateQueues
            // 
            this.btnCreateQueues.Location = new System.Drawing.Point(61, 124);
            this.btnCreateQueues.Name = "btnCreateQueues";
            this.btnCreateQueues.Size = new System.Drawing.Size(206, 40);
            this.btnCreateQueues.TabIndex = 2;
            this.btnCreateQueues.Text = "Create Queues";
            this.btnCreateQueues.UseVisualStyleBackColor = true;
            this.btnCreateQueues.Click += new System.EventHandler(this.btnCreateQueues_Click);
            // 
            // btnBindQueues
            // 
            this.btnBindQueues.Location = new System.Drawing.Point(61, 188);
            this.btnBindQueues.Name = "btnBindQueues";
            this.btnBindQueues.Size = new System.Drawing.Size(206, 36);
            this.btnBindQueues.TabIndex = 3;
            this.btnBindQueues.Text = "Bind Queues";
            this.btnBindQueues.UseVisualStyleBackColor = true;
            this.btnBindQueues.Click += new System.EventHandler(this.btnBindQueues_Click);
            // 
            // txtBoxPublishEmail
            // 
            this.txtBoxPublishEmail.Location = new System.Drawing.Point(61, 274);
            this.txtBoxPublishEmail.Name = "txtBoxPublishEmail";
            this.txtBoxPublishEmail.Size = new System.Drawing.Size(225, 22);
            this.txtBoxPublishEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Publish Email";
            // 
            // btnPublishEmail
            // 
            this.btnPublishEmail.Location = new System.Drawing.Point(166, 313);
            this.btnPublishEmail.Name = "btnPublishEmail";
            this.btnPublishEmail.Size = new System.Drawing.Size(120, 29);
            this.btnPublishEmail.TabIndex = 6;
            this.btnPublishEmail.Text = "Publish Email";
            this.btnPublishEmail.UseVisualStyleBackColor = true;
            this.btnPublishEmail.Click += new System.EventHandler(this.btnPublishEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Publish SMS";
            // 
            // txtBoxPublishSms
            // 
            this.txtBoxPublishSms.Location = new System.Drawing.Point(66, 405);
            this.txtBoxPublishSms.Name = "txtBoxPublishSms";
            this.txtBoxPublishSms.Size = new System.Drawing.Size(220, 22);
            this.txtBoxPublishSms.TabIndex = 8;
            // 
            // btnPublishSMS
            // 
            this.btnPublishSMS.Location = new System.Drawing.Point(177, 450);
            this.btnPublishSMS.Name = "btnPublishSMS";
            this.btnPublishSMS.Size = new System.Drawing.Size(109, 33);
            this.btnPublishSMS.TabIndex = 9;
            this.btnPublishSMS.Text = "Publish SMS";
            this.btnPublishSMS.UseVisualStyleBackColor = true;
            this.btnPublishSMS.Click += new System.EventHandler(this.btnPublishSMS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btnPublishSMS);
            this.Controls.Add(this.txtBoxPublishSms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPublishEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPublishEmail);
            this.Controls.Add(this.btnBindQueues);
            this.Controls.Add(this.btnCreateQueues);
            this.Controls.Add(this.btnCreateExchange);
            this.Controls.Add(this.btnConnectRabbitMq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectRabbitMq;
        private System.Windows.Forms.Button btnCreateExchange;
        private System.Windows.Forms.Button btnCreateQueues;
        private System.Windows.Forms.Button btnBindQueues;
        private System.Windows.Forms.TextBox txtBoxPublishEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPublishEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPublishSms;
        private System.Windows.Forms.Button btnPublishSMS;
    }
}

