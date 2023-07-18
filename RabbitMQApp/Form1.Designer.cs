﻿namespace RabbitMQApp
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
            this.SuspendLayout();
            // 
            // btnConnectRabbitMq
            // 
            this.btnConnectRabbitMq.Location = new System.Drawing.Point(64, 46);
            this.btnConnectRabbitMq.Name = "btnConnectRabbitMq";
            this.btnConnectRabbitMq.Size = new System.Drawing.Size(206, 70);
            this.btnConnectRabbitMq.TabIndex = 0;
            this.btnConnectRabbitMq.Text = "Connect RabbitMQ";
            this.btnConnectRabbitMq.UseVisualStyleBackColor = true;
            this.btnConnectRabbitMq.Click += new System.EventHandler(this.btnConnectRabbitMq_Click);
            // 
            // btnCreateExchange
            // 
            this.btnCreateExchange.Location = new System.Drawing.Point(64, 137);
            this.btnCreateExchange.Name = "btnCreateExchange";
            this.btnCreateExchange.Size = new System.Drawing.Size(206, 59);
            this.btnCreateExchange.TabIndex = 1;
            this.btnCreateExchange.Text = "Create Exchange";
            this.btnCreateExchange.UseVisualStyleBackColor = true;
            this.btnCreateExchange.Click += new System.EventHandler(this.btnCreateExchange_Click);
            // 
            // btnCreateQueues
            // 
            this.btnCreateQueues.Location = new System.Drawing.Point(64, 229);
            this.btnCreateQueues.Name = "btnCreateQueues";
            this.btnCreateQueues.Size = new System.Drawing.Size(206, 63);
            this.btnCreateQueues.TabIndex = 2;
            this.btnCreateQueues.Text = "Create Queues";
            this.btnCreateQueues.UseVisualStyleBackColor = true;
            this.btnCreateQueues.Click += new System.EventHandler(this.btnCreateQueues_Click);
            // 
            // btnBindQueues
            // 
            this.btnBindQueues.Location = new System.Drawing.Point(64, 315);
            this.btnBindQueues.Name = "btnBindQueues";
            this.btnBindQueues.Size = new System.Drawing.Size(206, 63);
            this.btnBindQueues.TabIndex = 3;
            this.btnBindQueues.Text = "Bind Queues";
            this.btnBindQueues.UseVisualStyleBackColor = true;
            this.btnBindQueues.Click += new System.EventHandler(this.btnBindQueues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBindQueues);
            this.Controls.Add(this.btnCreateQueues);
            this.Controls.Add(this.btnCreateExchange);
            this.Controls.Add(this.btnConnectRabbitMq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectRabbitMq;
        private System.Windows.Forms.Button btnCreateExchange;
        private System.Windows.Forms.Button btnCreateQueues;
        private System.Windows.Forms.Button btnBindQueues;
    }
}

