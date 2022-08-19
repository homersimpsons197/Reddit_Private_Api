namespace Redditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gBoxAction = new System.Windows.Forms.GroupBox();
            this.chBoxThread = new System.Windows.Forms.CheckBox();
            this.chBoxComment = new System.Windows.Forms.CheckBox();
            this.chBoxUpvote = new System.Windows.Forms.CheckBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(731, 324);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUser,
            this.dgvProxy,
            this.dgvAction,
            this.dgvDesc,
            this.dgvStatus});
            this.dgv.Location = new System.Drawing.Point(12, 90);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(794, 228);
            this.dgv.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.HeaderText = "User";
            this.dgvUser.Name = "dgvUser";
            // 
            // dgvProxy
            // 
            this.dgvProxy.HeaderText = "Proxy";
            this.dgvProxy.Name = "dgvProxy";
            this.dgvProxy.Width = 150;
            // 
            // dgvAction
            // 
            this.dgvAction.HeaderText = "Action";
            this.dgvAction.Name = "dgvAction";
            // 
            // dgvDesc
            // 
            this.dgvDesc.HeaderText = "Description";
            this.dgvDesc.Name = "dgvDesc";
            this.dgvDesc.Width = 300;
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.Name = "dgvStatus";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(48, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(250, 20);
            this.txtPath.TabIndex = 3;
            // 
            // gBoxAction
            // 
            this.gBoxAction.Controls.Add(this.chBoxThread);
            this.gBoxAction.Controls.Add(this.chBoxComment);
            this.gBoxAction.Controls.Add(this.chBoxUpvote);
            this.gBoxAction.Location = new System.Drawing.Point(48, 36);
            this.gBoxAction.Name = "gBoxAction";
            this.gBoxAction.Size = new System.Drawing.Size(250, 48);
            this.gBoxAction.TabIndex = 4;
            this.gBoxAction.TabStop = false;
            this.gBoxAction.Text = "Actions";
            // 
            // chBoxThread
            // 
            this.chBoxThread.AutoSize = true;
            this.chBoxThread.Location = new System.Drawing.Point(184, 19);
            this.chBoxThread.Name = "chBoxThread";
            this.chBoxThread.Size = new System.Drawing.Size(60, 17);
            this.chBoxThread.TabIndex = 2;
            this.chBoxThread.Text = "Thread";
            this.chBoxThread.UseVisualStyleBackColor = true;
            // 
            // chBoxComment
            // 
            this.chBoxComment.AutoSize = true;
            this.chBoxComment.Location = new System.Drawing.Point(86, 19);
            this.chBoxComment.Name = "chBoxComment";
            this.chBoxComment.Size = new System.Drawing.Size(70, 17);
            this.chBoxComment.TabIndex = 1;
            this.chBoxComment.Text = "Comment";
            this.chBoxComment.UseVisualStyleBackColor = true;
            // 
            // chBoxUpvote
            // 
            this.chBoxUpvote.AutoSize = true;
            this.chBoxUpvote.Location = new System.Drawing.Point(7, 20);
            this.chBoxUpvote.Name = "chBoxUpvote";
            this.chBoxUpvote.Size = new System.Drawing.Size(61, 17);
            this.chBoxUpvote.TabIndex = 0;
            this.chBoxUpvote.Text = "Upvote";
            this.chBoxUpvote.UseVisualStyleBackColor = true;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoosePath.BackgroundImage")));
            this.btnChoosePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoosePath.Location = new System.Drawing.Point(304, 6);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(28, 27);
            this.btnChoosePath.TabIndex = 5;
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnStatus.Location = new System.Drawing.Point(679, 10);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(62, 20);
            this.lblConnStatus.TabIndex = 7;
            this.lblConnStatus.Text = "Status";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 324);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 353);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.gBoxAction);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gBoxAction.ResumeLayout(false);
            this.gBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblPath;
        public System.Windows.Forms.GroupBox gBoxAction;
        public System.Windows.Forms.CheckBox chBoxThread;
        public System.Windows.Forms.CheckBox chBoxComment;
        public System.Windows.Forms.CheckBox chBoxUpvote;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        public System.Windows.Forms.Button btnChoosePath;
        public System.Windows.Forms.TextBox txtPath;
        public System.Windows.Forms.Label lblConnStatus;
        public System.Windows.Forms.Button btnConnect;
    }
}

