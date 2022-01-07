namespace Elevator
{
    partial class Elevator
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
            this.components = new System.ComponentModel.Container();
            this.logTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDisplay = new System.Windows.Forms.Label();
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnGround = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topLeft = new System.Windows.Forms.Label();
            this.topRight = new System.Windows.Forms.Label();
            this.botLeft = new System.Windows.Forms.Label();
            this.botRight = new System.Windows.Forms.Label();
            this.insideEle = new System.Windows.Forms.Label();
            this.rqstFirst = new System.Windows.Forms.Button();
            this.rqstGround = new System.Windows.Forms.Button();
            this.groundDisplay = new System.Windows.Forms.Label();
            this.firstDisplay = new System.Windows.Forms.Label();
            this.eleTimer = new System.Windows.Forms.Timer(this.components);
            this.counter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTable
            // 
            this.logTable.AllowUserToAddRows = false;
            this.logTable.AllowUserToDeleteRows = false;
            this.logTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.logTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cDateTime,
            this.cEntry});
            this.logTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTable.Location = new System.Drawing.Point(0, 0);
            this.logTable.Name = "logTable";
            this.logTable.ReadOnly = true;
            this.logTable.Size = new System.Drawing.Size(563, 641);
            this.logTable.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // cDateTime
            // 
            this.cDateTime.HeaderText = "Date";
            this.cDateTime.Name = "cDateTime";
            this.cDateTime.ReadOnly = true;
            this.cDateTime.Width = 150;
            // 
            // cEntry
            // 
            this.cEntry.HeaderText = "Details";
            this.cEntry.Name = "cEntry";
            this.cEntry.ReadOnly = true;
            this.cEntry.Width = 300;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.logTable);
            this.dataPanel.Location = new System.Drawing.Point(581, 13);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(563, 641);
            this.dataPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.controlDisplay);
            this.controlPanel.Controls.Add(this.btnAlert);
            this.controlPanel.Controls.Add(this.btnClose);
            this.controlPanel.Controls.Add(this.btnOpen);
            this.controlPanel.Controls.Add(this.btnFirst);
            this.controlPanel.Controls.Add(this.btnGround);
            this.controlPanel.Location = new System.Drawing.Point(304, 13);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(271, 465);
            this.controlPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control Panel";
            // 
            // controlDisplay
            // 
            this.controlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlDisplay.Location = new System.Drawing.Point(52, 39);
            this.controlDisplay.Name = "controlDisplay";
            this.controlDisplay.Size = new System.Drawing.Size(156, 156);
            this.controlDisplay.TabIndex = 5;
            this.controlDisplay.Text = "G";
            this.controlDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlert
            // 
            this.btnAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlert.Location = new System.Drawing.Point(90, 360);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(75, 75);
            this.btnAlert.TabIndex = 4;
            this.btnAlert.Text = "🔔";
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(133, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 75);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "> | | <";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(52, 279);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 75);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "< || >";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(52, 198);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 75);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "1";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnGround
            // 
            this.btnGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGround.Location = new System.Drawing.Point(133, 198);
            this.btnGround.Name = "btnGround";
            this.btnGround.Size = new System.Drawing.Size(75, 75);
            this.btnGround.TabIndex = 0;
            this.btnGround.Text = "G";
            this.btnGround.UseVisualStyleBackColor = true;
            this.btnGround.Click += new System.EventHandler(this.btnGround_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.topLeft);
            this.panel1.Controls.Add(this.topRight);
            this.panel1.Controls.Add(this.botLeft);
            this.panel1.Controls.Add(this.botRight);
            this.panel1.Controls.Add(this.insideEle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 692);
            this.panel1.TabIndex = 4;
            // 
            // topLeft
            // 
            this.topLeft.Image = global::Elevator.Properties.Resources.Elevator_Left_Door;
            this.topLeft.Location = new System.Drawing.Point(0, 0);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(122, 346);
            this.topLeft.TabIndex = 7;
            // 
            // topRight
            // 
            this.topRight.Image = global::Elevator.Properties.Resources.Elevator_Right_Door;
            this.topRight.Location = new System.Drawing.Point(122, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(122, 346);
            this.topRight.TabIndex = 8;
            // 
            // botLeft
            // 
            this.botLeft.Image = global::Elevator.Properties.Resources.Elevator_Left_Door;
            this.botLeft.Location = new System.Drawing.Point(0, 346);
            this.botLeft.Name = "botLeft";
            this.botLeft.Size = new System.Drawing.Size(122, 346);
            this.botLeft.TabIndex = 5;
            // 
            // botRight
            // 
            this.botRight.Image = global::Elevator.Properties.Resources.Elevator_Right_Door;
            this.botRight.Location = new System.Drawing.Point(122, 346);
            this.botRight.Name = "botRight";
            this.botRight.Size = new System.Drawing.Size(122, 346);
            this.botRight.TabIndex = 6;
            // 
            // insideEle
            // 
            this.insideEle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insideEle.Image = global::Elevator.Properties.Resources.inside_Elevator;
            this.insideEle.Location = new System.Drawing.Point(0, 346);
            this.insideEle.Name = "insideEle";
            this.insideEle.Size = new System.Drawing.Size(245, 346);
            this.insideEle.TabIndex = 4;
            // 
            // rqstFirst
            // 
            this.rqstFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rqstFirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rqstFirst.Location = new System.Drawing.Point(263, 188);
            this.rqstFirst.Name = "rqstFirst";
            this.rqstFirst.Size = new System.Drawing.Size(35, 35);
            this.rqstFirst.TabIndex = 5;
            this.rqstFirst.Text = "Λ";
            this.rqstFirst.UseVisualStyleBackColor = true;
            this.rqstFirst.Click += new System.EventHandler(this.rqstFirst_Click);
            // 
            // rqstGround
            // 
            this.rqstGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rqstGround.Location = new System.Drawing.Point(263, 526);
            this.rqstGround.Name = "rqstGround";
            this.rqstGround.Size = new System.Drawing.Size(35, 35);
            this.rqstGround.TabIndex = 6;
            this.rqstGround.Text = "V";
            this.rqstGround.UseVisualStyleBackColor = true;
            this.rqstGround.Click += new System.EventHandler(this.rqstGround_Click);
            // 
            // groundDisplay
            // 
            this.groundDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groundDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundDisplay.Location = new System.Drawing.Point(263, 488);
            this.groundDisplay.Name = "groundDisplay";
            this.groundDisplay.Size = new System.Drawing.Size(35, 35);
            this.groundDisplay.TabIndex = 7;
            this.groundDisplay.Text = "G";
            this.groundDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstDisplay
            // 
            this.firstDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDisplay.Location = new System.Drawing.Point(263, 150);
            this.firstDisplay.Name = "firstDisplay";
            this.firstDisplay.Size = new System.Drawing.Size(35, 35);
            this.firstDisplay.TabIndex = 8;
            this.firstDisplay.Text = "G";
            this.firstDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eleTimer
            // 
            this.eleTimer.Enabled = true;
            this.eleTimer.Interval = 10;
            this.eleTimer.Tick += new System.EventHandler(this.eleTimer_Tick);
            // 
            // counter
            // 
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.counter_Tick);
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 717);
            this.Controls.Add(this.firstDisplay);
            this.Controls.Add(this.groundDisplay);
            this.Controls.Add(this.rqstGround);
            this.Controls.Add(this.rqstFirst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.dataPanel);
            this.Name = "Elevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Elevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logTable)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView logTable;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnGround;
        private System.Windows.Forms.Label controlDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label insideEle;
        private System.Windows.Forms.Label botLeft;
        private System.Windows.Forms.Label botRight;
        private System.Windows.Forms.Button rqstFirst;
        private System.Windows.Forms.Button rqstGround;
        private System.Windows.Forms.Label groundDisplay;
        private System.Windows.Forms.Label firstDisplay;
        private System.Windows.Forms.Label topLeft;
        private System.Windows.Forms.Label topRight;
        private System.Windows.Forms.Timer eleTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEntry;
        private System.Windows.Forms.Timer counter;
    }
}

