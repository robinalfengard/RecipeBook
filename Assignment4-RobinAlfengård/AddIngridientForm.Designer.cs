namespace Assignment4_RobinAlfengård
{
    partial class AddIngridientsForm
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
            IngridientsBoxForm2 = new GroupBox();
            EditIngridientButton = new Button();
            DeleteIngridientButton = new Button();
            AddIngridientButton = new Button();
            ListOfIngridientsForm2 = new ListView();
            IngridientInput = new TextBox();
            NumberOfIngridientsLabel = new Label();
            IngridientCounterLabel = new Label();
            OkButton = new Button();
            CancelButton = new Button();
            IngridientsBoxForm2.SuspendLayout();
            SuspendLayout();
            // 
            // IngridientsBoxForm2
            // 
            IngridientsBoxForm2.Controls.Add(EditIngridientButton);
            IngridientsBoxForm2.Controls.Add(DeleteIngridientButton);
            IngridientsBoxForm2.Controls.Add(AddIngridientButton);
            IngridientsBoxForm2.Controls.Add(ListOfIngridientsForm2);
            IngridientsBoxForm2.Controls.Add(IngridientInput);
            IngridientsBoxForm2.Location = new Point(29, 94);
            IngridientsBoxForm2.Name = "IngridientsBoxForm2";
            IngridientsBoxForm2.Size = new Size(753, 662);
            IngridientsBoxForm2.TabIndex = 0;
            IngridientsBoxForm2.TabStop = false;
            IngridientsBoxForm2.Text = "Ingridient";
            // 
            // EditIngridientButton
            // 
            EditIngridientButton.BackColor = SystemColors.ControlLight;
            EditIngridientButton.Location = new Point(570, 148);
            EditIngridientButton.Name = "EditIngridientButton";
            EditIngridientButton.Size = new Size(167, 34);
            EditIngridientButton.TabIndex = 10;
            EditIngridientButton.Text = "Edit";
            EditIngridientButton.UseVisualStyleBackColor = false;
            EditIngridientButton.Click += EditIngridient;
            // 
            // DeleteIngridientButton
            // 
            DeleteIngridientButton.BackColor = SystemColors.ControlLight;
            DeleteIngridientButton.Location = new Point(570, 204);
            DeleteIngridientButton.Name = "DeleteIngridientButton";
            DeleteIngridientButton.Size = new Size(167, 34);
            DeleteIngridientButton.TabIndex = 9;
            DeleteIngridientButton.Text = "Delete";
            DeleteIngridientButton.UseVisualStyleBackColor = false;
            DeleteIngridientButton.Click += DeleteIngridient;
            // 
            // AddIngridientButton
            // 
            AddIngridientButton.BackColor = SystemColors.ControlLight;
            AddIngridientButton.Location = new Point(570, 91);
            AddIngridientButton.Name = "AddIngridientButton";
            AddIngridientButton.Size = new Size(167, 34);
            AddIngridientButton.TabIndex = 8;
            AddIngridientButton.Text = "Add";
            AddIngridientButton.UseVisualStyleBackColor = false;
            AddIngridientButton.Click += AddIngridient;
            // 
            // ListOfIngridientsForm2
            // 
            ListOfIngridientsForm2.Location = new Point(17, 91);
            ListOfIngridientsForm2.MultiSelect = false;
            ListOfIngridientsForm2.Name = "ListOfIngridientsForm2";
            ListOfIngridientsForm2.Size = new Size(547, 529);
            ListOfIngridientsForm2.TabIndex = 2;
            ListOfIngridientsForm2.UseCompatibleStateImageBehavior = false;
            ListOfIngridientsForm2.View = View.List;
            // 
            // IngridientInput
            // 
            IngridientInput.BorderStyle = BorderStyle.FixedSingle;
            IngridientInput.Location = new Point(17, 39);
            IngridientInput.Name = "IngridientInput";
            IngridientInput.Size = new Size(547, 31);
            IngridientInput.TabIndex = 0;
            // 
            // NumberOfIngridientsLabel
            // 
            NumberOfIngridientsLabel.AutoSize = true;
            NumberOfIngridientsLabel.Location = new Point(29, 36);
            NumberOfIngridientsLabel.Name = "NumberOfIngridientsLabel";
            NumberOfIngridientsLabel.Size = new Size(188, 25);
            NumberOfIngridientsLabel.TabIndex = 1;
            NumberOfIngridientsLabel.Text = "Number of Ingridients";
            // 
            // IngridientCounterLabel
            // 
            IngridientCounterLabel.AutoSize = true;
            IngridientCounterLabel.Location = new Point(239, 36);
            IngridientCounterLabel.Name = "IngridientCounterLabel";
            IngridientCounterLabel.Size = new Size(0, 25);
            IngridientCounterLabel.TabIndex = 2;
            // 
            // OkButton
            // 
            OkButton.BackColor = SystemColors.ControlLight;
            OkButton.Location = new Point(82, 762);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(167, 34);
            OkButton.TabIndex = 11;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += AcceptIngridientListing;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlLight;
            CancelButton.Location = new Point(397, 762);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(167, 34);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelIngridientListing;
            // 
            // AddIngridientsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 838);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(IngridientCounterLabel);
            Controls.Add(NumberOfIngridientsLabel);
            Controls.Add(IngridientsBoxForm2);
            Name = "AddIngridientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Ingridients";
            Load += AddIngridientsForm_Load;
            IngridientsBoxForm2.ResumeLayout(false);
            IngridientsBoxForm2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox IngridientsBoxForm2;
        private TextBox IngridientInput;
        private ListView ListOfIngridientsForm2;
        private Button EditIngridientButton;
        private Button DeleteIngridientButton;
        private Button AddIngridientButton;
        private Label NumberOfIngridientsLabel;
        private Label IngridientCounterLabel;
        private Button OkButton;
        private Button CancelButton;
    }
}