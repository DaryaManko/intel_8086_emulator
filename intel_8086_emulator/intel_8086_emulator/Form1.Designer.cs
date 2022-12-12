namespace intel_8086_emulator
{
    partial class Emulator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.Label();
            this.valuebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.startRegisterBox = new System.Windows.Forms.ComboBox();
            this.startRegisterLabel = new System.Windows.Forms.Label();
            this.finishRegisterBox = new System.Windows.Forms.ComboBox();
            this.finishRegisterLabel = new System.Windows.Forms.Label();
            this.mov = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(61, 281);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(682, 45);
            this.result.TabIndex = 5;
            this.result.Text = "operacja zapisu w rejestrze zostala wykonana ";
            // 
            // valuebox
            // 
            this.valuebox.Location = new System.Drawing.Point(38, 61);
            this.valuebox.Name = "valuebox";
            this.valuebox.Size = new System.Drawing.Size(125, 27);
            this.valuebox.TabIndex = 6;
            this.valuebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(47, 19);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(103, 20);
            this.valueLabel.TabIndex = 8;
            this.valueLabel.Text = "dodaj wartosc";
            // 
            // startRegisterBox
            // 
            this.startRegisterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startRegisterBox.FormattingEnabled = true;
            this.startRegisterBox.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX"});
            this.startRegisterBox.Location = new System.Drawing.Point(213, 60);
            this.startRegisterBox.Name = "startRegisterBox";
            this.startRegisterBox.Size = new System.Drawing.Size(151, 28);
            this.startRegisterBox.TabIndex = 9;
            this.startRegisterBox.SelectedIndexChanged += new System.EventHandler(this.startRegisterBox_SelectedIndexChanged);
            // 
            // startRegisterLabel
            // 
            this.startRegisterLabel.AutoSize = true;
            this.startRegisterLabel.Location = new System.Drawing.Point(213, 19);
            this.startRegisterLabel.Name = "startRegisterLabel";
            this.startRegisterLabel.Size = new System.Drawing.Size(133, 20);
            this.startRegisterLabel.TabIndex = 10;
            this.startRegisterLabel.Text = "rejestr poczatkowy";
            // 
            // finishRegisterBox
            // 
            this.finishRegisterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishRegisterBox.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX"});
            this.finishRegisterBox.Location = new System.Drawing.Point(408, 60);
            this.finishRegisterBox.Name = "finishRegisterBox";
            this.finishRegisterBox.Size = new System.Drawing.Size(151, 28);
            this.finishRegisterBox.TabIndex = 11;
            this.finishRegisterBox.SelectedIndexChanged += new System.EventHandler(this.finishRegisterBox_SelectedIndexChanged);
            // 
            // finishRegisterLabel
            // 
            this.finishRegisterLabel.AutoSize = true;
            this.finishRegisterLabel.Location = new System.Drawing.Point(408, 19);
            this.finishRegisterLabel.Name = "finishRegisterLabel";
            this.finishRegisterLabel.Size = new System.Drawing.Size(283, 20);
            this.finishRegisterLabel.TabIndex = 12;
            this.finishRegisterLabel.Text = "rejestr do ktorego chcesz zapisac wartosc";
            // 
            // mov
            // 
            this.mov.Location = new System.Drawing.Point(566, 173);
            this.mov.Name = "mov";
            this.mov.Size = new System.Drawing.Size(207, 29);
            this.mov.TabIndex = 13;
            this.mov.Text = "wykonaj komende MOV ";
            this.mov.UseVisualStyleBackColor = true;
            this.mov.Click += new System.EventHandler(this.mov_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(66, 173);
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Size = new System.Drawing.Size(125, 27);
            this.value.TabIndex = 14;
            this.value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(197, 173);
            this.register.Name = "register";
            this.register.ReadOnly = true;
            this.register.Size = new System.Drawing.Size(125, 27);
            this.register.TabIndex = 15;
            this.register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(617, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.register);
            this.Controls.Add(this.value);
            this.Controls.Add(this.mov);
            this.Controls.Add(this.finishRegisterLabel);
            this.Controls.Add(this.finishRegisterBox);
            this.Controls.Add(this.startRegisterLabel);
            this.Controls.Add(this.startRegisterBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valuebox);
            this.Controls.Add(this.result);
            this.Name = "Emulator";
            this.Text = "Emulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label result;
        private TextBox valuebox;
        private Label label1;
        private Label valueLabel;
        private ComboBox startRegisterBox;
        private Label startRegisterLabel;
        private ComboBox finishRegisterBox;
        private Label finishRegisterLabel;
        private Button mov;
        private TextBox value;
        private TextBox register;
        private Button clearButton;
    }
}