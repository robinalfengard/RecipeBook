namespace Assignment4_RobinAlfengård
{
    partial class CookingInstructionForm
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
        private void CookingInstructionForm_Load(object sender, EventArgs e)
        {
            // Your code for form load event handling goes here
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IngridientsLabelForm3 = new Label();
            IngridientsListerLabelForm3 = new Label();
            CookingInstructionLabelForm3 = new Label();
            OkCookingInstructionButton = new Button();
            SuspendLayout();
            // 
            // IngridientsLabelForm3
            // 
            IngridientsLabelForm3.AutoSize = true;
            IngridientsLabelForm3.Location = new Point(25, 30);
            IngridientsLabelForm3.Name = "IngridientsLabelForm3";
            IngridientsLabelForm3.Size = new Size(96, 25);
            IngridientsLabelForm3.TabIndex = 2;
            IngridientsLabelForm3.Text = "Ingridients";
            // 
            // IngridientsListerLabelForm3
            // 
            IngridientsListerLabelForm3.AutoSize = true;
            IngridientsListerLabelForm3.Location = new Point(25, 75);
            IngridientsListerLabelForm3.Name = "IngridientsListerLabelForm3";
            IngridientsListerLabelForm3.Size = new Size(0, 25);
            IngridientsListerLabelForm3.TabIndex = 4;
            // 
            // CookingInstructionLabelForm3
            // 
            CookingInstructionLabelForm3.Location = new Point(25, 116);
            CookingInstructionLabelForm3.Name = "CookingInstructionLabelForm3";
            CookingInstructionLabelForm3.Size = new Size(739, 648);
            CookingInstructionLabelForm3.TabIndex = 6;
            // 
            // OkCookingInstructionButton
            // 
            OkCookingInstructionButton.BackColor = SystemColors.ControlLight;
            OkCookingInstructionButton.Location = new Point(314, 812);
            OkCookingInstructionButton.Name = "OkCookingInstructionButton";
            OkCookingInstructionButton.Size = new Size(167, 34);
            OkCookingInstructionButton.TabIndex = 9;
            OkCookingInstructionButton.Text = "OK";
            OkCookingInstructionButton.UseVisualStyleBackColor = false;
            // 
            // CookingInstructionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 885);
            Controls.Add(OkCookingInstructionButton);
            Controls.Add(CookingInstructionLabelForm3);
            Controls.Add(IngridientsListerLabelForm3);
            Controls.Add(IngridientsLabelForm3);
            Name = "CookingInstructionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cooking Instructions";
            Load += this.CookingInstructionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IngridientsLabelForm3;
        private Label IngridientsListerLabelForm3;
        private Label CookingInstructionLabelForm3;
        private Button OkCookingInstructionButton;
    }
}