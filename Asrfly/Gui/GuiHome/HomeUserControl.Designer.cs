namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutput = new Button();
            buttonAddUser = new Button();
            buttonAddProject = new Button();
            buttonAddSupplier = new Button();
            buttonAddCustomer = new Button();
            buttonAddCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            labelCompanyName = new Label();
            labelWellcome = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 204);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(126, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.BackColor = Color.White;
            buttonAddInput.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddInput.Image = Properties.Resources.Input;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(63, 39);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Padding = new Padding(5);
            buttonAddInput.Size = new Size(118, 73);
            buttonAddInput.TabIndex = 1;
            buttonAddInput.Text = "       قبض";
            buttonAddInput.UseVisualStyleBackColor = false;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.BackColor = Color.White;
            buttonAddOutput.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddOutput.Image = Properties.Resources.Output;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(193, 39);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Padding = new Padding(5);
            buttonAddOutput.Size = new Size(119, 73);
            buttonAddOutput.TabIndex = 1;
            buttonAddOutput.Text = "       صرف";
            buttonAddOutput.UseVisualStyleBackColor = false;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.White;
            buttonAddUser.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddUser.Image = Properties.Resources.Users_1;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(324, 39);
            buttonAddUser.Margin = new Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Padding = new Padding(5);
            buttonAddUser.Size = new Size(137, 73);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "       مستخدم";
            buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // buttonAddProject
            // 
            buttonAddProject.BackColor = Color.White;
            buttonAddProject.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProject.Image = Properties.Resources.Microsoft_Project_1;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(473, 39);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Padding = new Padding(5);
            buttonAddProject.Size = new Size(128, 73);
            buttonAddProject.TabIndex = 1;
            buttonAddProject.Text = "       مشروع";
            buttonAddProject.UseVisualStyleBackColor = false;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.BackColor = Color.White;
            buttonAddSupplier.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddSupplier.Image = Properties.Resources.Crowd_1;
            buttonAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new Point(613, 39);
            buttonAddSupplier.Margin = new Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Padding = new Padding(5);
            buttonAddSupplier.Size = new Size(118, 73);
            buttonAddSupplier.TabIndex = 1;
            buttonAddSupplier.Text = "       مورد";
            buttonAddSupplier.UseVisualStyleBackColor = false;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = Color.White;
            buttonAddCustomer.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCustomer.Image = Properties.Resources.Conference_Skin_Type_7;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(743, 39);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Padding = new Padding(5);
            buttonAddCustomer.Size = new Size(118, 73);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "       عميل";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = Color.White;
            buttonAddCategory.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddCategory.Image = Properties.Resources.Categorize_1;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(873, 39);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Padding = new Padding(5);
            buttonAddCategory.Size = new Size(118, 73);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "      صنف";
            buttonAddCategory.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(516, 12);
            label1.Name = "label1";
            label1.Size = new Size(161, 35);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Controls.Add(labelCompanyName);
            panel2.Location = new Point(658, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 125);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources._0_Circled;
            pictureBoxLogo.Location = new Point(361, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(98, 125);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(3, 21);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(289, 81);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "ZeRoCoDe Developer";
            labelCompanyName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelWellcome.Location = new Point(3, 45);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(352, 81);
            labelWellcome.TabIndex = 0;
            labelWellcome.Text = "مرحبا بك مجددا مصطفي سليم";
            labelWellcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(labelWellcome);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddCustomer;
        private Button buttonAddInput;
        private Button buttonAddOutput;
        private Button buttonAddUser;
        private Button buttonAddProject;
        private Button buttonAddSupplier;
        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Label labelCompanyName;
        private Label labelWellcome;
    }
}
