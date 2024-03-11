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

        // Does not load like it should

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ingridientsLabelForm3 = new Label();
            ingridientsListerLabelForm3 = new Label();
            cookingInstructionLabel = new Label();
            okCookingInstructionButton = new Button();
            SuspendLayout();
            // 
            // ingridientsLabelForm3
            // 
            ingridientsLabelForm3.AutoSize = true;
            ingridientsLabelForm3.Location = new Point(25, 50);
            ingridientsLabelForm3.Name = "ingridientsLabelForm3";
            ingridientsLabelForm3.Size = new Size(100, 25);
            ingridientsLabelForm3.TabIndex = 2;
            ingridientsLabelForm3.Text = "Ingridients:";
            // 
            // ingridientsListerLabelForm3
            // 
            ingridientsListerLabelForm3.AutoSize = true;
            ingridientsListerLabelForm3.Location = new Point(25, 75);
            ingridientsListerLabelForm3.Name = "ingridientsListerLabelForm3";
            ingridientsListerLabelForm3.Size = new Size(0, 25);
            ingridientsListerLabelForm3.TabIndex = 4;
            // 
            // cookingInstructionLabel
            // 
            cookingInstructionLabel.BackColor = SystemColors.ButtonHighlight;
            cookingInstructionLabel.BorderStyle = BorderStyle.FixedSingle;
            cookingInstructionLabel.Location = new Point(25, 116);
            cookingInstructionLabel.Name = "cookingInstructionLabel";
            cookingInstructionLabel.Size = new Size(739, 648);
            cookingInstructionLabel.TabIndex = 6;
            cookingInstructionLabel.Text = "Instructions:";
            // 
            // okCookingInstructionButton
            // 
            okCookingInstructionButton.BackColor = SystemColors.ControlLight;
            okCookingInstructionButton.Location = new Point(314, 812);
            okCookingInstructionButton.Name = "okCookingInstructionButton";
            okCookingInstructionButton.Size = new Size(167, 34);
            okCookingInstructionButton.TabIndex = 9;
            okCookingInstructionButton.Text = "OK";
            okCookingInstructionButton.UseVisualStyleBackColor = false;
            okCookingInstructionButton.Click += OkButtonClick;
            // 
            // CookingInstructionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 885);
            Controls.Add(okCookingInstructionButton);
            Controls.Add(cookingInstructionLabel);
            Controls.Add(ingridientsListerLabelForm3);
            Controls.Add(ingridientsLabelForm3);
            Name = "CookingInstructionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cooking Instructions";
            Load += CookingInstructionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ingridientsLabelForm3;
        private Label ingridientsListerLabelForm3;
        private Label cookingInstructionLabel;
        private Button okCookingInstructionButton;
    }
}