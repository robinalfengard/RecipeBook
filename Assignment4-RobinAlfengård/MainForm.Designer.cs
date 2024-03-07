namespace Assignment4_RobinAlfengård
{
    partial class RecipeBookWindow
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
            LeftBigBox = new GroupBox();
            InstructionsLabel = new Label();
            AddRecipeButton = new Button();
            InstructionsInput = new TextBox();
            AddIngridientButton = new Button();
            CategorySelection = new ComboBox();
            CategoryLabel = new Label();
            NameOfRecipeInput = new TextBox();
            NameOfRecipeLabel = new Label();
            ListOfRecipieNames = new ListView();
            EditBeginButton = new Button();
            EditFinishButton = new Button();
            DeleteButton = new Button();
            ClearSelectionButton = new Button();
            NameOfRecipe = new Label();
            label2 = new Label();
            label3 = new Label();
            LeftBigBox.SuspendLayout();
            SuspendLayout();
            // 
            // LeftBigBox
            // 
            LeftBigBox.Controls.Add(InstructionsLabel);
            LeftBigBox.Controls.Add(AddRecipeButton);
            LeftBigBox.Controls.Add(InstructionsInput);
            LeftBigBox.Controls.Add(AddIngridientButton);
            LeftBigBox.Controls.Add(CategorySelection);
            LeftBigBox.Controls.Add(CategoryLabel);
            LeftBigBox.Controls.Add(NameOfRecipeInput);
            LeftBigBox.Controls.Add(NameOfRecipeLabel);
            LeftBigBox.Location = new Point(32, 40);
            LeftBigBox.Name = "LeftBigBox";
            LeftBigBox.Size = new Size(600, 819);
            LeftBigBox.TabIndex = 0;
            LeftBigBox.TabStop = false;
            LeftBigBox.Text = "Add New Recipe";
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.AutoSize = true;
            InstructionsLabel.Location = new Point(33, 174);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(104, 25);
            InstructionsLabel.TabIndex = 7;
            InstructionsLabel.Text = "Instructions";
            // 
            // AddRecipeButton
            // 
            AddRecipeButton.BackColor = SystemColors.ControlLight;
            AddRecipeButton.Location = new Point(132, 723);
            AddRecipeButton.Name = "AddRecipeButton";
            AddRecipeButton.Size = new Size(303, 57);
            AddRecipeButton.TabIndex = 6;
            AddRecipeButton.Text = "Add Recipe";
            AddRecipeButton.UseVisualStyleBackColor = false;
            AddRecipeButton.Click += AddRecipeOnClick;
            // 
            // InstructionsInput
            // 
            InstructionsInput.BorderStyle = BorderStyle.FixedSingle;
            InstructionsInput.Location = new Point(33, 202);
            InstructionsInput.Multiline = true;
            InstructionsInput.Name = "InstructionsInput";
            InstructionsInput.Size = new Size(519, 474);
            InstructionsInput.TabIndex = 5;
            // 
            // AddIngridientButton
            // 
            AddIngridientButton.BackColor = SystemColors.ControlLight;
            AddIngridientButton.Location = new Point(385, 122);
            AddIngridientButton.Name = "AddIngridientButton";
            AddIngridientButton.Size = new Size(167, 34);
            AddIngridientButton.TabIndex = 4;
            AddIngridientButton.Text = "Add Ingridients";
            AddIngridientButton.UseVisualStyleBackColor = false;
            AddIngridientButton.Click += AddIngridientsClick;
            // 
            // CategorySelection
            // 
            CategorySelection.DropDownStyle = ComboBoxStyle.DropDownList;
            CategorySelection.FormattingEnabled = true;
            CategorySelection.Location = new Point(192, 123);
            CategorySelection.Name = "CategorySelection";
            CategorySelection.Size = new Size(155, 33);
            CategorySelection.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(6, 126);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 25);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category";
            // 
            // NameOfRecipeInput
            // 
            NameOfRecipeInput.BorderStyle = BorderStyle.FixedSingle;
            NameOfRecipeInput.Location = new Point(192, 52);
            NameOfRecipeInput.Name = "NameOfRecipeInput";
            NameOfRecipeInput.Size = new Size(360, 31);
            NameOfRecipeInput.TabIndex = 1;
            // 
            // NameOfRecipeLabel
            // 
            NameOfRecipeLabel.AutoSize = true;
            NameOfRecipeLabel.Location = new Point(6, 52);
            NameOfRecipeLabel.Name = "NameOfRecipeLabel";
            NameOfRecipeLabel.Size = new Size(137, 25);
            NameOfRecipeLabel.TabIndex = 0;
            NameOfRecipeLabel.Text = "Name of Recipe";
            // 
            // ListOfRecipieNames
            // 
            ListOfRecipieNames.Alignment = ListViewAlignment.Default;
            ListOfRecipieNames.Location = new Point(678, 121);
            ListOfRecipieNames.Name = "ListOfRecipieNames";
            ListOfRecipieNames.Size = new Size(750, 595);
            ListOfRecipieNames.TabIndex = 1;
            ListOfRecipieNames.UseCompatibleStateImageBehavior = false;
            ListOfRecipieNames.View = View.List;
            ListOfRecipieNames.MouseDoubleClick += ShowInstructions;
            // 
            // EditBeginButton
            // 
            EditBeginButton.BackColor = SystemColors.ControlLight;
            EditBeginButton.Location = new Point(678, 747);
            EditBeginButton.Name = "EditBeginButton";
            EditBeginButton.Size = new Size(167, 34);
            EditBeginButton.TabIndex = 7;
            EditBeginButton.Text = "Edit-Begin";
            EditBeginButton.UseVisualStyleBackColor = false;
            EditBeginButton.Click += StartEditingRecipeClick;
            // 
            // EditFinishButton
            // 
            EditFinishButton.BackColor = SystemColors.ControlLight;
            EditFinishButton.Location = new Point(874, 747);
            EditFinishButton.Name = "EditFinishButton";
            EditFinishButton.Size = new Size(167, 34);
            EditFinishButton.TabIndex = 10;
            EditFinishButton.Text = "Edit-Finish";
            EditFinishButton.UseVisualStyleBackColor = false;
            EditFinishButton.Click += FinishEditRecipeClick;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ControlLight;
            DeleteButton.Location = new Point(1069, 747);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(167, 34);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteSelectedRecipe;
            // 
            // ClearSelectionButton
            // 
            ClearSelectionButton.BackColor = SystemColors.ControlLight;
            ClearSelectionButton.Location = new Point(1261, 747);
            ClearSelectionButton.Name = "ClearSelectionButton";
            ClearSelectionButton.Size = new Size(167, 34);
            ClearSelectionButton.TabIndex = 12;
            ClearSelectionButton.Text = "Clear Selection";
            ClearSelectionButton.UseVisualStyleBackColor = false;
            ClearSelectionButton.Click += ResetClick;
            // 
            // NameOfRecipe
            // 
            NameOfRecipe.AutoSize = true;
            NameOfRecipe.Location = new Point(678, 82);
            NameOfRecipe.Name = "NameOfRecipe";
            NameOfRecipe.Size = new Size(137, 25);
            NameOfRecipe.TabIndex = 8;
            NameOfRecipe.Text = "Name of Recipe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(995, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 13;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1278, 82);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 14;
            label3.Text = "No Of Ingridients";
            // 
            // RecipeBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 893);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NameOfRecipe);
            Controls.Add(ClearSelectionButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditFinishButton);
            Controls.Add(EditBeginButton);
            Controls.Add(ListOfRecipieNames);
            Controls.Add(LeftBigBox);
            Name = "RecipeBookWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Book";
            Load += RecipeBookWindow_Load;
            LeftBigBox.ResumeLayout(false);
            LeftBigBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox LeftBigBox;
        private Label CategoryLabel;
        private TextBox NameOfRecipeInput;
        private Label NameOfRecipeLabel;
        private Button AddIngridientButton;
        private ComboBox CategorySelection;
        private TextBox InstructionsInput;
        private Button AddRecipeButton;
        private ListView ListOfRecipieNames;
        private Button EditBeginButton;
        private Button EditFinishButton;
        private Button DeleteButton;
        private Button ClearSelectionButton;
        private Label InstructionsLabel;
        private Label NameOfRecipe;
        private Label label2;
        private Label label3;
    }
}
