namespace CTIExerciseOne
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
            this.lblMain = new System.Windows.Forms.Label();
            this.gbInsultSelection = new System.Windows.Forms.GroupBox();
            this.cbPunchLine = new System.Windows.Forms.ComboBox();
            this.cbInsult = new System.Windows.Forms.ComboBox();
            this.cbTarget = new System.Windows.Forms.ComboBox();
            this.btnInsult = new System.Windows.Forms.Button();
            this.lblPunchLine = new System.Windows.Forms.Label();
            this.lblInsult = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.gbInsultEditor = new System.Windows.Forms.GroupBox();
            this.txtbNewPunchLine = new System.Windows.Forms.TextBox();
            this.txtbNewInsult = new System.Windows.Forms.TextBox();
            this.txtbNewTarget = new System.Windows.Forms.TextBox();
            this.btnNewPunchLineAdd = new System.Windows.Forms.Button();
            this.btnNewInsultAdd = new System.Windows.Forms.Button();
            this.btnNewTargetAdd = new System.Windows.Forms.Button();
            this.lblNewPunchLine = new System.Windows.Forms.Label();
            this.lblNewInsult = new System.Windows.Forms.Label();
            this.lblNewTarget = new System.Windows.Forms.Label();
            this.gbInusltPictureEditor = new System.Windows.Forms.GroupBox();
            this.gbLower = new System.Windows.Forms.GroupBox();
            this.rdbLowerUgly = new System.Windows.Forms.RadioButton();
            this.rdbLowerFat = new System.Windows.Forms.RadioButton();
            this.rdbLowerDumb = new System.Windows.Forms.RadioButton();
            this.gbUpper = new System.Windows.Forms.GroupBox();
            this.rdbUpperUgly = new System.Windows.Forms.RadioButton();
            this.rdbUpperFat = new System.Windows.Forms.RadioButton();
            this.rdbUpperDumb = new System.Windows.Forms.RadioButton();
            this.gbHead = new System.Windows.Forms.GroupBox();
            this.rdbHeadUgly = new System.Windows.Forms.RadioButton();
            this.rdbHeadFat = new System.Windows.Forms.RadioButton();
            this.rdbHeadDumb = new System.Windows.Forms.RadioButton();
            this.gbInsultPicture = new System.Windows.Forms.GroupBox();
            this.pbLower = new System.Windows.Forms.PictureBox();
            this.pbUpper = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.gbInsultSelection.SuspendLayout();
            this.gbInsultEditor.SuspendLayout();
            this.gbInusltPictureEditor.SuspendLayout();
            this.gbLower.SuspendLayout();
            this.gbUpper.SuspendLayout();
            this.gbHead.SuspendLayout();
            this.gbInsultPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(21, 17);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(69, 13);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "lblCompInsult";
            // 
            // gbInsultSelection
            // 
            this.gbInsultSelection.Controls.Add(this.cbPunchLine);
            this.gbInsultSelection.Controls.Add(this.cbInsult);
            this.gbInsultSelection.Controls.Add(this.cbTarget);
            this.gbInsultSelection.Controls.Add(this.btnInsult);
            this.gbInsultSelection.Controls.Add(this.lblPunchLine);
            this.gbInsultSelection.Controls.Add(this.lblInsult);
            this.gbInsultSelection.Controls.Add(this.lblTarget);
            this.gbInsultSelection.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbInsultSelection.Location = new System.Drawing.Point(12, 46);
            this.gbInsultSelection.Name = "gbInsultSelection";
            this.gbInsultSelection.Size = new System.Drawing.Size(400, 141);
            this.gbInsultSelection.TabIndex = 1;
            this.gbInsultSelection.TabStop = false;
            this.gbInsultSelection.Text = "Insult Selection";
            // 
            // cbPunchLine
            // 
            this.cbPunchLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPunchLine.FormattingEnabled = true;
            this.cbPunchLine.Location = new System.Drawing.Point(101, 88);
            this.cbPunchLine.Name = "cbPunchLine";
            this.cbPunchLine.Size = new System.Drawing.Size(277, 21);
            this.cbPunchLine.TabIndex = 6;
            // 
            // cbInsult
            // 
            this.cbInsult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsult.FormattingEnabled = true;
            this.cbInsult.Location = new System.Drawing.Point(101, 57);
            this.cbInsult.Name = "cbInsult";
            this.cbInsult.Size = new System.Drawing.Size(277, 21);
            this.cbInsult.TabIndex = 5;
            // 
            // cbTarget
            // 
            this.cbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTarget.Location = new System.Drawing.Point(101, 28);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(153, 21);
            this.cbTarget.TabIndex = 4;
            // 
            // btnInsult
            // 
            this.btnInsult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInsult.Location = new System.Drawing.Point(10, 112);
            this.btnInsult.Name = "btnInsult";
            this.btnInsult.Size = new System.Drawing.Size(75, 23);
            this.btnInsult.TabIndex = 3;
            this.btnInsult.Text = "Insult!";
            this.btnInsult.UseVisualStyleBackColor = true;
            this.btnInsult.Click += new System.EventHandler(this.btnInsult_Click);
            // 
            // lblPunchLine
            // 
            this.lblPunchLine.AutoSize = true;
            this.lblPunchLine.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPunchLine.Location = new System.Drawing.Point(13, 88);
            this.lblPunchLine.Name = "lblPunchLine";
            this.lblPunchLine.Size = new System.Drawing.Size(64, 13);
            this.lblPunchLine.TabIndex = 2;
            this.lblPunchLine.Text = "Punch Line:";
            // 
            // lblInsult
            // 
            this.lblInsult.AutoSize = true;
            this.lblInsult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInsult.Location = new System.Drawing.Point(13, 57);
            this.lblInsult.Name = "lblInsult";
            this.lblInsult.Size = new System.Drawing.Size(35, 13);
            this.lblInsult.TabIndex = 1;
            this.lblInsult.Text = "Insult:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTarget.Location = new System.Drawing.Point(13, 28);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(41, 13);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "Target:";
            // 
            // gbInsultEditor
            // 
            this.gbInsultEditor.Controls.Add(this.txtbNewPunchLine);
            this.gbInsultEditor.Controls.Add(this.txtbNewInsult);
            this.gbInsultEditor.Controls.Add(this.txtbNewTarget);
            this.gbInsultEditor.Controls.Add(this.btnNewPunchLineAdd);
            this.gbInsultEditor.Controls.Add(this.btnNewInsultAdd);
            this.gbInsultEditor.Controls.Add(this.btnNewTargetAdd);
            this.gbInsultEditor.Controls.Add(this.lblNewPunchLine);
            this.gbInsultEditor.Controls.Add(this.lblNewInsult);
            this.gbInsultEditor.Controls.Add(this.lblNewTarget);
            this.gbInsultEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbInsultEditor.Location = new System.Drawing.Point(12, 199);
            this.gbInsultEditor.Name = "gbInsultEditor";
            this.gbInsultEditor.Size = new System.Drawing.Size(400, 120);
            this.gbInsultEditor.TabIndex = 2;
            this.gbInsultEditor.TabStop = false;
            this.gbInsultEditor.Text = "Insult Editor";
            // 
            // txtbNewPunchLine
            // 
            this.txtbNewPunchLine.Location = new System.Drawing.Point(116, 70);
            this.txtbNewPunchLine.Name = "txtbNewPunchLine";
            this.txtbNewPunchLine.Size = new System.Drawing.Size(207, 20);
            this.txtbNewPunchLine.TabIndex = 11;
            // 
            // txtbNewInsult
            // 
            this.txtbNewInsult.Location = new System.Drawing.Point(116, 43);
            this.txtbNewInsult.Name = "txtbNewInsult";
            this.txtbNewInsult.Size = new System.Drawing.Size(207, 20);
            this.txtbNewInsult.TabIndex = 10;
            // 
            // txtbNewTarget
            // 
            this.txtbNewTarget.Location = new System.Drawing.Point(116, 16);
            this.txtbNewTarget.Name = "txtbNewTarget";
            this.txtbNewTarget.Size = new System.Drawing.Size(207, 20);
            this.txtbNewTarget.TabIndex = 9;
            // 
            // btnNewPunchLineAdd
            // 
            this.btnNewPunchLineAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNewPunchLineAdd.Location = new System.Drawing.Point(329, 68);
            this.btnNewPunchLineAdd.Name = "btnNewPunchLineAdd";
            this.btnNewPunchLineAdd.Size = new System.Drawing.Size(49, 23);
            this.btnNewPunchLineAdd.TabIndex = 8;
            this.btnNewPunchLineAdd.Text = "Add";
            this.btnNewPunchLineAdd.UseVisualStyleBackColor = true;
            this.btnNewPunchLineAdd.Click += new System.EventHandler(this.btnNewPunchLineAdd_Click);
            // 
            // btnNewInsultAdd
            // 
            this.btnNewInsultAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNewInsultAdd.Location = new System.Drawing.Point(329, 41);
            this.btnNewInsultAdd.Name = "btnNewInsultAdd";
            this.btnNewInsultAdd.Size = new System.Drawing.Size(49, 23);
            this.btnNewInsultAdd.TabIndex = 7;
            this.btnNewInsultAdd.Text = "Add";
            this.btnNewInsultAdd.UseVisualStyleBackColor = true;
            this.btnNewInsultAdd.Click += new System.EventHandler(this.btnNewInsultAdd_Click);
            // 
            // btnNewTargetAdd
            // 
            this.btnNewTargetAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNewTargetAdd.Location = new System.Drawing.Point(329, 14);
            this.btnNewTargetAdd.Name = "btnNewTargetAdd";
            this.btnNewTargetAdd.Size = new System.Drawing.Size(49, 23);
            this.btnNewTargetAdd.TabIndex = 6;
            this.btnNewTargetAdd.Text = "Add";
            this.btnNewTargetAdd.UseVisualStyleBackColor = true;
            this.btnNewTargetAdd.Click += new System.EventHandler(this.btnNewTargetAdd_Click);
            // 
            // lblNewPunchLine
            // 
            this.lblNewPunchLine.AutoSize = true;
            this.lblNewPunchLine.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNewPunchLine.Location = new System.Drawing.Point(13, 77);
            this.lblNewPunchLine.Name = "lblNewPunchLine";
            this.lblNewPunchLine.Size = new System.Drawing.Size(89, 13);
            this.lblNewPunchLine.TabIndex = 2;
            this.lblNewPunchLine.Text = "New Punch Line:";
            // 
            // lblNewInsult
            // 
            this.lblNewInsult.AutoSize = true;
            this.lblNewInsult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNewInsult.Location = new System.Drawing.Point(13, 46);
            this.lblNewInsult.Name = "lblNewInsult";
            this.lblNewInsult.Size = new System.Drawing.Size(60, 13);
            this.lblNewInsult.TabIndex = 1;
            this.lblNewInsult.Text = "New Insult:";
            // 
            // lblNewTarget
            // 
            this.lblNewTarget.AutoSize = true;
            this.lblNewTarget.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNewTarget.Location = new System.Drawing.Point(13, 19);
            this.lblNewTarget.Name = "lblNewTarget";
            this.lblNewTarget.Size = new System.Drawing.Size(66, 13);
            this.lblNewTarget.TabIndex = 0;
            this.lblNewTarget.Text = "New Target:";
            // 
            // gbInusltPictureEditor
            // 
            this.gbInusltPictureEditor.Controls.Add(this.gbLower);
            this.gbInusltPictureEditor.Controls.Add(this.gbUpper);
            this.gbInusltPictureEditor.Controls.Add(this.gbHead);
            this.gbInusltPictureEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbInusltPictureEditor.Location = new System.Drawing.Point(16, 329);
            this.gbInusltPictureEditor.Name = "gbInusltPictureEditor";
            this.gbInusltPictureEditor.Size = new System.Drawing.Size(284, 118);
            this.gbInusltPictureEditor.TabIndex = 3;
            this.gbInusltPictureEditor.TabStop = false;
            this.gbInusltPictureEditor.Text = "Insult Picture Editor";
            // 
            // gbLower
            // 
            this.gbLower.Controls.Add(this.rdbLowerUgly);
            this.gbLower.Controls.Add(this.rdbLowerFat);
            this.gbLower.Controls.Add(this.rdbLowerDumb);
            this.gbLower.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbLower.Location = new System.Drawing.Point(197, 19);
            this.gbLower.Name = "gbLower";
            this.gbLower.Size = new System.Drawing.Size(73, 90);
            this.gbLower.TabIndex = 2;
            this.gbLower.TabStop = false;
            this.gbLower.Text = "Lower";
            // 
            // rdbLowerUgly
            // 
            this.rdbLowerUgly.AutoSize = true;
            this.rdbLowerUgly.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbLowerUgly.Location = new System.Drawing.Point(7, 67);
            this.rdbLowerUgly.Name = "rdbLowerUgly";
            this.rdbLowerUgly.Size = new System.Drawing.Size(46, 17);
            this.rdbLowerUgly.TabIndex = 2;
            this.rdbLowerUgly.TabStop = true;
            this.rdbLowerUgly.Text = "Ugly";
            this.rdbLowerUgly.UseVisualStyleBackColor = true;
            this.rdbLowerUgly.CheckedChanged += new System.EventHandler(this.rdbLowerUgly_CheckedChanged);
            // 
            // rdbLowerFat
            // 
            this.rdbLowerFat.AutoSize = true;
            this.rdbLowerFat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbLowerFat.Location = new System.Drawing.Point(7, 44);
            this.rdbLowerFat.Name = "rdbLowerFat";
            this.rdbLowerFat.Size = new System.Drawing.Size(40, 17);
            this.rdbLowerFat.TabIndex = 1;
            this.rdbLowerFat.TabStop = true;
            this.rdbLowerFat.Text = "Fat";
            this.rdbLowerFat.UseVisualStyleBackColor = true;
            this.rdbLowerFat.CheckedChanged += new System.EventHandler(this.rdbLowerFat_CheckedChanged);
            // 
            // rdbLowerDumb
            // 
            this.rdbLowerDumb.AutoSize = true;
            this.rdbLowerDumb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbLowerDumb.Location = new System.Drawing.Point(7, 20);
            this.rdbLowerDumb.Name = "rdbLowerDumb";
            this.rdbLowerDumb.Size = new System.Drawing.Size(53, 17);
            this.rdbLowerDumb.TabIndex = 0;
            this.rdbLowerDumb.TabStop = true;
            this.rdbLowerDumb.Text = "Dumb";
            this.rdbLowerDumb.UseVisualStyleBackColor = true;
            this.rdbLowerDumb.CheckedChanged += new System.EventHandler(this.rdbLowerDumb_CheckedChanged);
            // 
            // gbUpper
            // 
            this.gbUpper.Controls.Add(this.rdbUpperUgly);
            this.gbUpper.Controls.Add(this.rdbUpperFat);
            this.gbUpper.Controls.Add(this.rdbUpperDumb);
            this.gbUpper.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbUpper.Location = new System.Drawing.Point(112, 19);
            this.gbUpper.Name = "gbUpper";
            this.gbUpper.Size = new System.Drawing.Size(79, 90);
            this.gbUpper.TabIndex = 1;
            this.gbUpper.TabStop = false;
            this.gbUpper.Text = "Upper";
            // 
            // rdbUpperUgly
            // 
            this.rdbUpperUgly.AutoSize = true;
            this.rdbUpperUgly.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbUpperUgly.Location = new System.Drawing.Point(6, 67);
            this.rdbUpperUgly.Name = "rdbUpperUgly";
            this.rdbUpperUgly.Size = new System.Drawing.Size(46, 17);
            this.rdbUpperUgly.TabIndex = 2;
            this.rdbUpperUgly.TabStop = true;
            this.rdbUpperUgly.Text = "Ugly";
            this.rdbUpperUgly.UseVisualStyleBackColor = true;
            this.rdbUpperUgly.CheckedChanged += new System.EventHandler(this.rdbUpperUgly_CheckedChanged);
            // 
            // rdbUpperFat
            // 
            this.rdbUpperFat.AutoSize = true;
            this.rdbUpperFat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbUpperFat.Location = new System.Drawing.Point(6, 44);
            this.rdbUpperFat.Name = "rdbUpperFat";
            this.rdbUpperFat.Size = new System.Drawing.Size(40, 17);
            this.rdbUpperFat.TabIndex = 1;
            this.rdbUpperFat.TabStop = true;
            this.rdbUpperFat.Text = "Fat";
            this.rdbUpperFat.UseVisualStyleBackColor = true;
            this.rdbUpperFat.CheckedChanged += new System.EventHandler(this.rdbUpperFat_CheckedChanged);
            // 
            // rdbUpperDumb
            // 
            this.rdbUpperDumb.AutoSize = true;
            this.rdbUpperDumb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbUpperDumb.Location = new System.Drawing.Point(6, 19);
            this.rdbUpperDumb.Name = "rdbUpperDumb";
            this.rdbUpperDumb.Size = new System.Drawing.Size(53, 17);
            this.rdbUpperDumb.TabIndex = 0;
            this.rdbUpperDumb.TabStop = true;
            this.rdbUpperDumb.Text = "Dumb";
            this.rdbUpperDumb.UseVisualStyleBackColor = true;
            this.rdbUpperDumb.CheckedChanged += new System.EventHandler(this.rdbUpperDumb_CheckedChanged);
            // 
            // gbHead
            // 
            this.gbHead.Controls.Add(this.rdbHeadUgly);
            this.gbHead.Controls.Add(this.rdbHeadFat);
            this.gbHead.Controls.Add(this.rdbHeadDumb);
            this.gbHead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbHead.Location = new System.Drawing.Point(12, 19);
            this.gbHead.Name = "gbHead";
            this.gbHead.Size = new System.Drawing.Size(93, 90);
            this.gbHead.TabIndex = 0;
            this.gbHead.TabStop = false;
            this.gbHead.Text = "Head";
            // 
            // rdbHeadUgly
            // 
            this.rdbHeadUgly.AutoSize = true;
            this.rdbHeadUgly.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbHeadUgly.Location = new System.Drawing.Point(6, 67);
            this.rdbHeadUgly.Name = "rdbHeadUgly";
            this.rdbHeadUgly.Size = new System.Drawing.Size(46, 17);
            this.rdbHeadUgly.TabIndex = 2;
            this.rdbHeadUgly.TabStop = true;
            this.rdbHeadUgly.Text = "Ugly";
            this.rdbHeadUgly.UseVisualStyleBackColor = true;
            this.rdbHeadUgly.CheckedChanged += new System.EventHandler(this.rdbHeadUgly_CheckedChanged);
            // 
            // rdbHeadFat
            // 
            this.rdbHeadFat.AutoSize = true;
            this.rdbHeadFat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbHeadFat.Location = new System.Drawing.Point(6, 44);
            this.rdbHeadFat.Name = "rdbHeadFat";
            this.rdbHeadFat.Size = new System.Drawing.Size(40, 17);
            this.rdbHeadFat.TabIndex = 1;
            this.rdbHeadFat.TabStop = true;
            this.rdbHeadFat.Text = "Fat";
            this.rdbHeadFat.UseVisualStyleBackColor = true;
            this.rdbHeadFat.CheckedChanged += new System.EventHandler(this.rdbHeadFat_CheckedChanged);
            // 
            // rdbHeadDumb
            // 
            this.rdbHeadDumb.AutoSize = true;
            this.rdbHeadDumb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbHeadDumb.Location = new System.Drawing.Point(6, 19);
            this.rdbHeadDumb.Name = "rdbHeadDumb";
            this.rdbHeadDumb.Size = new System.Drawing.Size(53, 17);
            this.rdbHeadDumb.TabIndex = 0;
            this.rdbHeadDumb.TabStop = true;
            this.rdbHeadDumb.Text = "Dumb";
            this.rdbHeadDumb.UseVisualStyleBackColor = true;
            this.rdbHeadDumb.CheckedChanged += new System.EventHandler(this.rdbHeadDumb_CheckedChanged);
            // 
            // gbInsultPicture
            // 
            this.gbInsultPicture.Controls.Add(this.pbLower);
            this.gbInsultPicture.Controls.Add(this.pbUpper);
            this.gbInsultPicture.Controls.Add(this.pbHead);
            this.gbInsultPicture.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbInsultPicture.Location = new System.Drawing.Point(440, 46);
            this.gbInsultPicture.Name = "gbInsultPicture";
            this.gbInsultPicture.Size = new System.Drawing.Size(162, 401);
            this.gbInsultPicture.TabIndex = 4;
            this.gbInsultPicture.TabStop = false;
            this.gbInsultPicture.Text = "Insult Picture";
            // 
            // pbLower
            // 
            this.pbLower.Image = global::CTIExerciseOne.Properties.Resources.dumbLower;
            this.pbLower.Location = new System.Drawing.Point(15, 279);
            this.pbLower.Name = "pbLower";
            this.pbLower.Size = new System.Drawing.Size(129, 107);
            this.pbLower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLower.TabIndex = 2;
            this.pbLower.TabStop = false;
            // 
            // pbUpper
            // 
            this.pbUpper.Image = global::CTIExerciseOne.Properties.Resources.dumbUpper;
            this.pbUpper.Location = new System.Drawing.Point(15, 153);
            this.pbUpper.Name = "pbUpper";
            this.pbUpper.Size = new System.Drawing.Size(129, 107);
            this.pbUpper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpper.TabIndex = 1;
            this.pbUpper.TabStop = false;
            // 
            // pbHead
            // 
            this.pbHead.Image = global::CTIExerciseOne.Properties.Resources.dumbHead;
            this.pbHead.Location = new System.Drawing.Point(15, 28);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(129, 107);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(614, 462);
            this.Controls.Add(this.gbInsultPicture);
            this.Controls.Add(this.gbInusltPictureEditor);
            this.Controls.Add(this.gbInsultEditor);
            this.Controls.Add(this.gbInsultSelection);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "Insult App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbInsultSelection.ResumeLayout(false);
            this.gbInsultSelection.PerformLayout();
            this.gbInsultEditor.ResumeLayout(false);
            this.gbInsultEditor.PerformLayout();
            this.gbInusltPictureEditor.ResumeLayout(false);
            this.gbLower.ResumeLayout(false);
            this.gbLower.PerformLayout();
            this.gbUpper.ResumeLayout(false);
            this.gbUpper.PerformLayout();
            this.gbHead.ResumeLayout(false);
            this.gbHead.PerformLayout();
            this.gbInsultPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox gbInsultSelection;
        private System.Windows.Forms.ComboBox cbPunchLine;
        private System.Windows.Forms.ComboBox cbInsult;
        private System.Windows.Forms.ComboBox cbTarget;
        private System.Windows.Forms.Button btnInsult;
        private System.Windows.Forms.Label lblPunchLine;
        private System.Windows.Forms.Label lblInsult;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.GroupBox gbInsultEditor;
        private System.Windows.Forms.Button btnNewPunchLineAdd;
        private System.Windows.Forms.Button btnNewInsultAdd;
        private System.Windows.Forms.Button btnNewTargetAdd;
        private System.Windows.Forms.Label lblNewPunchLine;
        private System.Windows.Forms.Label lblNewInsult;
        private System.Windows.Forms.Label lblNewTarget;
        private System.Windows.Forms.GroupBox gbInusltPictureEditor;
        private System.Windows.Forms.GroupBox gbLower;
        private System.Windows.Forms.RadioButton rdbLowerUgly;
        private System.Windows.Forms.RadioButton rdbLowerFat;
        private System.Windows.Forms.RadioButton rdbLowerDumb;
        private System.Windows.Forms.GroupBox gbUpper;
        private System.Windows.Forms.RadioButton rdbUpperUgly;
        private System.Windows.Forms.RadioButton rdbUpperFat;
        private System.Windows.Forms.RadioButton rdbUpperDumb;
        private System.Windows.Forms.GroupBox gbHead;
        private System.Windows.Forms.RadioButton rdbHeadUgly;
        private System.Windows.Forms.RadioButton rdbHeadFat;
        private System.Windows.Forms.RadioButton rdbHeadDumb;
        private System.Windows.Forms.GroupBox gbInsultPicture;
        private System.Windows.Forms.PictureBox pbLower;
        private System.Windows.Forms.PictureBox pbUpper;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.TextBox txtbNewPunchLine;
        private System.Windows.Forms.TextBox txtbNewInsult;
        private System.Windows.Forms.TextBox txtbNewTarget;
    }
}

