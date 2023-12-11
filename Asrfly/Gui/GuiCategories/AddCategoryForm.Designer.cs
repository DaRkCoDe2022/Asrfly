namespace Asrfly.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxBalance = new TextBox();
            comboBoxType = new ComboBox();
            richTextBoxDetails = new RichTextBox();
            buttonSaveAndClose = new Button();
            buttonSave = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 74);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 459);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "اسم الصف";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(5, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(490, 30);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 0;
            label2.Text = "نوع الصف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 162);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 392);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new Point(5, 416);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(490, 30);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new Point(5, 117);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(490, 32);
            comboBoxType.TabIndex = 2;
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new Point(5, 188);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new Size(490, 172);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.BackColor = Color.White;
            buttonSaveAndClose.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveAndClose.Image = Properties.Resources.Save;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(334, 5);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Padding = new Padding(5);
            buttonSaveAndClose.Size = new Size(180, 65);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "    حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = false;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Image = Properties.Resources.Save_1;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(5, 5);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(5);
            buttonSave.Size = new Size(144, 65);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "     حفظ";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 564);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل صنف";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboBoxType;
        private TextBox textBoxBalance;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBoxDetails;
        private Button buttonSave;
        private Button buttonSaveAndClose;
    }
}