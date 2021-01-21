
namespace Access_Profile_Manager
{
    partial class APManagerForm
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
            this.btnLoadEntitlements = new System.Windows.Forms.Button();
            this.txtAPID = new System.Windows.Forms.TextBox();
            this.lblAPName = new System.Windows.Forms.Label();
            this.lblAPDescription = new System.Windows.Forms.Label();
            this.lblSourceName = new System.Windows.Forms.Label();
            this.txtRemoveEntitlement = new System.Windows.Forms.TextBox();
            this.txtAdditionalEntitlement = new System.Windows.Forms.TextBox();
            this.btnAddEntitlement = new System.Windows.Forms.Button();
            this.btnRemoveEntitlement = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadEntitlements
            // 
            this.btnLoadEntitlements.Location = new System.Drawing.Point(405, 25);
            this.btnLoadEntitlements.Name = "btnLoadEntitlements";
            this.btnLoadEntitlements.Size = new System.Drawing.Size(122, 23);
            this.btnLoadEntitlements.TabIndex = 6;
            this.btnLoadEntitlements.Text = "Load Entitlements";
            this.btnLoadEntitlements.UseVisualStyleBackColor = true;
            this.btnLoadEntitlements.Click += new System.EventHandler(this.btnLoadEntitlements_Click);
            // 
            // txtAPID
            // 
            this.txtAPID.Location = new System.Drawing.Point(143, 27);
            this.txtAPID.Name = "txtAPID";
            this.txtAPID.Size = new System.Drawing.Size(256, 20);
            this.txtAPID.TabIndex = 7;
            // 
            // lblAPName
            // 
            this.lblAPName.AutoSize = true;
            this.lblAPName.Location = new System.Drawing.Point(288, 52);
            this.lblAPName.Name = "lblAPName";
            this.lblAPName.Size = new System.Drawing.Size(0, 13);
            this.lblAPName.TabIndex = 8;
            // 
            // lblAPDescription
            // 
            this.lblAPDescription.AutoSize = true;
            this.lblAPDescription.Location = new System.Drawing.Point(288, 72);
            this.lblAPDescription.Name = "lblAPDescription";
            this.lblAPDescription.Size = new System.Drawing.Size(0, 13);
            this.lblAPDescription.TabIndex = 9;
            // 
            // lblSourceName
            // 
            this.lblSourceName.AutoSize = true;
            this.lblSourceName.Location = new System.Drawing.Point(288, 89);
            this.lblSourceName.Name = "lblSourceName";
            this.lblSourceName.Size = new System.Drawing.Size(0, 13);
            this.lblSourceName.TabIndex = 10;
            // 
            // txtRemoveEntitlement
            // 
            this.txtRemoveEntitlement.Location = new System.Drawing.Point(143, 365);
            this.txtRemoveEntitlement.Name = "txtRemoveEntitlement";
            this.txtRemoveEntitlement.Size = new System.Drawing.Size(256, 20);
            this.txtRemoveEntitlement.TabIndex = 11;
            // 
            // txtAdditionalEntitlement
            // 
            this.txtAdditionalEntitlement.Location = new System.Drawing.Point(405, 365);
            this.txtAdditionalEntitlement.Name = "txtAdditionalEntitlement";
            this.txtAdditionalEntitlement.Size = new System.Drawing.Size(262, 20);
            this.txtAdditionalEntitlement.TabIndex = 12;
            // 
            // btnAddEntitlement
            // 
            this.btnAddEntitlement.Location = new System.Drawing.Point(405, 392);
            this.btnAddEntitlement.Name = "btnAddEntitlement";
            this.btnAddEntitlement.Size = new System.Drawing.Size(262, 23);
            this.btnAddEntitlement.TabIndex = 13;
            this.btnAddEntitlement.Text = "Add Entitlement";
            this.btnAddEntitlement.UseVisualStyleBackColor = true;
            this.btnAddEntitlement.Click += new System.EventHandler(this.btnAddEntitlement_Click);
            // 
            // btnRemoveEntitlement
            // 
            this.btnRemoveEntitlement.Location = new System.Drawing.Point(143, 392);
            this.btnRemoveEntitlement.Name = "btnRemoveEntitlement";
            this.btnRemoveEntitlement.Size = new System.Drawing.Size(256, 23);
            this.btnRemoveEntitlement.TabIndex = 14;
            this.btnRemoveEntitlement.Text = "Remove Entitlement";
            this.btnRemoveEntitlement.UseVisualStyleBackColor = true;
            this.btnRemoveEntitlement.Click += new System.EventHandler(this.btnRemoveEntitlement_Click);
            // 
            // dgView
            // 
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(36, 118);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(720, 205);
            this.dgView.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Access Profile Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Access Profile Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Access Profile Source:";
            // 
            // APManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btnRemoveEntitlement);
            this.Controls.Add(this.btnAddEntitlement);
            this.Controls.Add(this.txtAdditionalEntitlement);
            this.Controls.Add(this.txtRemoveEntitlement);
            this.Controls.Add(this.lblSourceName);
            this.Controls.Add(this.lblAPDescription);
            this.Controls.Add(this.lblAPName);
            this.Controls.Add(this.txtAPID);
            this.Controls.Add(this.btnLoadEntitlements);
            this.Name = "APManagerForm";
            this.Text = "Access Profile Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadEntitlements;
        private System.Windows.Forms.TextBox txtAPID;
        private System.Windows.Forms.Label lblAPName;
        private System.Windows.Forms.Label lblAPDescription;
        private System.Windows.Forms.Label lblSourceName;
        private System.Windows.Forms.TextBox txtRemoveEntitlement;
        private System.Windows.Forms.TextBox txtAdditionalEntitlement;
        private System.Windows.Forms.Button btnAddEntitlement;
        private System.Windows.Forms.Button btnRemoveEntitlement;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

