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
            ingridientsBoxForm2 = new GroupBox();
            editIngridientButton = new Button();
            deleteIngridientButton = new Button();
            addIngridientButton = new Button();
            listOfIngridientsForm2 = new ListView();
            ingridientInput = new TextBox();
            numberOfIngridientsLabel = new Label();
            ingridientCounterLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            ingridientsBoxForm2.SuspendLayout();
            SuspendLayout();
            // 
            // IngridientsBoxForm2
            // 
            ingridientsBoxForm2.Controls.Add(editIngridientButton);
            ingridientsBoxForm2.Controls.Add(deleteIngridientButton);
            ingridientsBoxForm2.Controls.Add(addIngridientButton);
            ingridientsBoxForm2.Controls.Add(listOfIngridientsForm2);
            ingridientsBoxForm2.Controls.Add(ingridientInput);
            ingridientsBoxForm2.Location = new Point(29, 94);
            ingridientsBoxForm2.Name = "IngridientsBoxForm2";
            ingridientsBoxForm2.Size = new Size(753, 662);
            ingridientsBoxForm2.TabIndex = 0;
            ingridientsBoxForm2.TabStop = false;
            ingridientsBoxForm2.Text = "Ingridient";
            // 
            // EditIngridientButton
            // 
            editIngridientButton.BackColor = SystemColors.ControlLight;
            editIngridientButton.Location = new Point(570, 148);
            editIngridientButton.Name = "EditIngridientButton";
            editIngridientButton.Size = new Size(167, 34);
            editIngridientButton.TabIndex = 10;
            editIngridientButton.Text = "Edit";
            editIngridientButton.UseVisualStyleBackColor = false;
            editIngridientButton.Click += EditIngridient;
            // 
            // DeleteIngridientButton
            // 
            deleteIngridientButton.BackColor = SystemColors.ControlLight;
            deleteIngridientButton.Location = new Point(570, 204);
            deleteIngridientButton.Name = "DeleteIngridientButton";
            deleteIngridientButton.Size = new Size(167, 34);
            deleteIngridientButton.TabIndex = 9;
            deleteIngridientButton.Text = "Delete";
            deleteIngridientButton.UseVisualStyleBackColor = false;
            deleteIngridientButton.Click += DeleteIngridient;
            // 
            // AddIngridientButton
            // 
            addIngridientButton.BackColor = SystemColors.ControlLight;
            addIngridientButton.Location = new Point(570, 91);
            addIngridientButton.Name = "AddIngridientButton";
            addIngridientButton.Size = new Size(167, 34);
            addIngridientButton.TabIndex = 8;
            addIngridientButton.Text = "Add";
            addIngridientButton.UseVisualStyleBackColor = false;
            addIngridientButton.Click += AddIngridient;
            // 
            // ListOfIngridientsForm2
            // 
            listOfIngridientsForm2.Location = new Point(17, 91);
            listOfIngridientsForm2.MultiSelect = false;
            listOfIngridientsForm2.Name = "ListOfIngridientsForm2";
            listOfIngridientsForm2.Size = new Size(547, 529);
            listOfIngridientsForm2.TabIndex = 2;
            listOfIngridientsForm2.UseCompatibleStateImageBehavior = false;
            listOfIngridientsForm2.View = View.List;
            // 
            // IngridientInput
            // 
            ingridientInput.BorderStyle = BorderStyle.FixedSingle;
            ingridientInput.Location = new Point(17, 39);
            ingridientInput.Name = "IngridientInput";
            ingridientInput.Size = new Size(547, 31);
            ingridientInput.TabIndex = 0;
            // 
            // NumberOfIngridientsLabel
            // 
            numberOfIngridientsLabel.AutoSize = true;
            numberOfIngridientsLabel.Location = new Point(29, 36);
            numberOfIngridientsLabel.Name = "NumberOfIngridientsLabel";
            numberOfIngridientsLabel.Size = new Size(188, 25);
            numberOfIngridientsLabel.TabIndex = 1;
            numberOfIngridientsLabel.Text = "Number of Ingridients";
            // 
            // IngridientCounterLabel
            // 
            ingridientCounterLabel.AutoSize = true;
            ingridientCounterLabel.Location = new Point(239, 36);
            ingridientCounterLabel.Name = "IngridientCounterLabel";
            ingridientCounterLabel.Size = new Size(0, 25);
            ingridientCounterLabel.TabIndex = 2;
            // 
            // OkButton
            // 
            okButton.BackColor = SystemColors.ControlLight;
            okButton.Location = new Point(82, 762);
            okButton.Name = "OkButton";
            okButton.Size = new Size(167, 34);
            okButton.TabIndex = 11;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += AcceptIngridientListing;
            // 
            // CancelButton
            // 
            cancelButton.BackColor = SystemColors.ControlLight;
            cancelButton.Location = new Point(397, 762);
            cancelButton.Name = "CancelButton";
            cancelButton.Size = new Size(167, 34);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelIngridientListing;
            // 
            // AddIngridientsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 838);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(ingridientCounterLabel);
            Controls.Add(numberOfIngridientsLabel);
            Controls.Add(ingridientsBoxForm2);
            Name = "AddIngridientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Ingridients";
            Load += AddIngridientsForm_Load;
            ingridientsBoxForm2.ResumeLayout(false);
            ingridientsBoxForm2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ingridientsBoxForm2;
        private TextBox ingridientInput;
        private ListView listOfIngridientsForm2;
        private Button editIngridientButton;
        private Button deleteIngridientButton;
        private Button addIngridientButton;
        private Label numberOfIngridientsLabel;
        private Label ingridientCounterLabel;
        private Button okButton;
        private Button cancelButton;
    }
}