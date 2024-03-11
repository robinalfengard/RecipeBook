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
            leftBigBox = new GroupBox();
            instructionsLabel = new Label();
            addRecipeButton = new Button();
            instructionsInput = new TextBox();
            addIngridientButton = new Button();
            categorySelection = new ComboBox();
            categoryLabel = new Label();
            nameOfRecipeInput = new TextBox();
            nameOfRecipeLabel = new Label();
            listOfRecipieNames = new ListView();
            editBeginButton = new Button();
            editFinishButton = new Button();
            deleteButton = new Button();
            clearSelectionButton = new Button();
            nameOfRecipeOverRecipePresenter = new Label();
            categoryLabelOverRecipePresenter = new Label();
            numberOfIngridientesLabelOverRecipePresenter = new Label();
            leftBigBox.SuspendLayout();
            SuspendLayout();
            // 
            // leftBigBox
            // 
            leftBigBox.Controls.Add(instructionsLabel);
            leftBigBox.Controls.Add(addRecipeButton);
            leftBigBox.Controls.Add(instructionsInput);
            leftBigBox.Controls.Add(addIngridientButton);
            leftBigBox.Controls.Add(categorySelection);
            leftBigBox.Controls.Add(categoryLabel);
            leftBigBox.Controls.Add(nameOfRecipeInput);
            leftBigBox.Controls.Add(nameOfRecipeLabel);
            leftBigBox.Location = new Point(32, 40);
            leftBigBox.Name = "leftBigBox";
            leftBigBox.Size = new Size(600, 819);
            leftBigBox.TabIndex = 0;
            leftBigBox.TabStop = false;
            leftBigBox.Text = "Add New Recipe";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Location = new Point(33, 174);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(104, 25);
            instructionsLabel.TabIndex = 7;
            instructionsLabel.Text = "Instructions";
            // 
            // addRecipeButton
            // 
            addRecipeButton.BackColor = SystemColors.ControlLight;
            addRecipeButton.Location = new Point(132, 723);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(303, 57);
            addRecipeButton.TabIndex = 6;
            addRecipeButton.Text = "Add Recipe";
            addRecipeButton.UseVisualStyleBackColor = false;
            addRecipeButton.Click += AddRecipeOnClick;
            // 
            // instructionsInput
            // 
            instructionsInput.BorderStyle = BorderStyle.FixedSingle;
            instructionsInput.Location = new Point(33, 202);
            instructionsInput.Multiline = true;
            instructionsInput.Name = "instructionsInput";
            instructionsInput.Size = new Size(519, 474);
            instructionsInput.TabIndex = 5;
            // 
            // addIngridientButton
            // 
            addIngridientButton.BackColor = SystemColors.ControlLight;
            addIngridientButton.Location = new Point(385, 122);
            addIngridientButton.Name = "addIngridientButton";
            addIngridientButton.Size = new Size(167, 34);
            addIngridientButton.TabIndex = 4;
            addIngridientButton.Text = "Add Ingridients";
            addIngridientButton.UseVisualStyleBackColor = false;
            addIngridientButton.Click += AddIngridientsClick;
            // 
            // categorySelection
            // 
            categorySelection.DropDownStyle = ComboBoxStyle.DropDownList;
            categorySelection.FormattingEnabled = true;
            categorySelection.Location = new Point(192, 123);
            categorySelection.Name = "categorySelection";
            categorySelection.Size = new Size(155, 33);
            categorySelection.TabIndex = 3;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(6, 126);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 25);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";
            // 
            // nameOfRecipeInput
            // 
            nameOfRecipeInput.BorderStyle = BorderStyle.FixedSingle;
            nameOfRecipeInput.Location = new Point(192, 52);
            nameOfRecipeInput.Name = "nameOfRecipeInput";
            nameOfRecipeInput.Size = new Size(360, 31);
            nameOfRecipeInput.TabIndex = 1;
            // 
            // nameOfRecipeLabel
            // 
            nameOfRecipeLabel.AutoSize = true;
            nameOfRecipeLabel.Location = new Point(6, 52);
            nameOfRecipeLabel.Name = "nameOfRecipeLabel";
            nameOfRecipeLabel.Size = new Size(137, 25);
            nameOfRecipeLabel.TabIndex = 0;
            nameOfRecipeLabel.Text = "Name of Recipe";
            // 
            // listOfRecipieNames
            // 
            listOfRecipieNames.Alignment = ListViewAlignment.Default;
            listOfRecipieNames.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listOfRecipieNames.Location = new Point(678, 121);
            listOfRecipieNames.Name = "listOfRecipieNames";
            listOfRecipieNames.Size = new Size(750, 595);
            listOfRecipieNames.TabIndex = 1;
            listOfRecipieNames.UseCompatibleStateImageBehavior = false;
            listOfRecipieNames.View = View.List;
            listOfRecipieNames.MouseDoubleClick += ShowInstructions;
            // 
            // editBeginButton
            // 
            editBeginButton.BackColor = SystemColors.ControlLight;
            editBeginButton.Location = new Point(678, 747);
            editBeginButton.Name = "editBeginButton";
            editBeginButton.Size = new Size(167, 34);
            editBeginButton.TabIndex = 7;
            editBeginButton.Text = "Edit Recipe";
            editBeginButton.UseVisualStyleBackColor = false;
            editBeginButton.Click += StartEditingRecipeClick;
            // 
            // editFinishButton
            // 
            editFinishButton.BackColor = SystemColors.ControlLight;
            editFinishButton.Enabled = false;
            editFinishButton.Location = new Point(874, 747);
            editFinishButton.Name = "editFinishButton";
            editFinishButton.Size = new Size(167, 34);
            editFinishButton.TabIndex = 10;
            editFinishButton.Text = "Save";
            editFinishButton.UseVisualStyleBackColor = false;
            editFinishButton.Click += FinishEditRecipeClick;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ControlLight;
            deleteButton.Location = new Point(1069, 747);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(167, 34);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteSelectedRecipe;
            // 
            // clearSelectionButton
            // 
            clearSelectionButton.BackColor = SystemColors.ControlLight;
            clearSelectionButton.Enabled = false;
            clearSelectionButton.Location = new Point(1261, 747);
            clearSelectionButton.Name = "clearSelectionButton";
            clearSelectionButton.Size = new Size(167, 34);
            clearSelectionButton.TabIndex = 12;
            clearSelectionButton.Text = "Cancel Edit";
            clearSelectionButton.UseVisualStyleBackColor = false;
            clearSelectionButton.Click += ResetClick;
            // 
            // nameOfRecipeOverRecipePresenter
            // 
            nameOfRecipeOverRecipePresenter.AutoSize = true;
            nameOfRecipeOverRecipePresenter.Location = new Point(678, 82);
            nameOfRecipeOverRecipePresenter.Name = "nameOfRecipeOverRecipePresenter";
            nameOfRecipeOverRecipePresenter.Size = new Size(137, 25);
            nameOfRecipeOverRecipePresenter.TabIndex = 8;
            nameOfRecipeOverRecipePresenter.Text = "Name of Recipe";
            // 
            // categoryLabelOverRecipePresenter
            // 
            categoryLabelOverRecipePresenter.AutoSize = true;
            categoryLabelOverRecipePresenter.Location = new Point(995, 82);
            categoryLabelOverRecipePresenter.Name = "categoryLabelOverRecipePresenter";
            categoryLabelOverRecipePresenter.Size = new Size(84, 25);
            categoryLabelOverRecipePresenter.TabIndex = 13;
            categoryLabelOverRecipePresenter.Text = "Category";
            // 
            // numberOfIngridientesLabelOverRecipePresenter
            // 
            numberOfIngridientesLabelOverRecipePresenter.AutoSize = true;
            numberOfIngridientesLabelOverRecipePresenter.Location = new Point(1278, 82);
            numberOfIngridientesLabelOverRecipePresenter.Name = "numberOfIngridientesLabelOverRecipePresenter";
            numberOfIngridientesLabelOverRecipePresenter.Size = new Size(150, 25);
            numberOfIngridientesLabelOverRecipePresenter.TabIndex = 14;
            numberOfIngridientesLabelOverRecipePresenter.Text = "No Of Ingridients";
            // 
            // RecipeBookWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 893);
            Controls.Add(numberOfIngridientesLabelOverRecipePresenter);
            Controls.Add(categoryLabelOverRecipePresenter);
            Controls.Add(nameOfRecipeOverRecipePresenter);
            Controls.Add(clearSelectionButton);
            Controls.Add(deleteButton);
            Controls.Add(editFinishButton);
            Controls.Add(editBeginButton);
            Controls.Add(listOfRecipieNames);
            Controls.Add(leftBigBox);
            Name = "RecipeBookWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Book";
            Load += RecipeBookWindow_Load;
            leftBigBox.ResumeLayout(false);
            leftBigBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox leftBigBox;
        private Label categoryLabel;
        private TextBox nameOfRecipeInput;
        private Label nameOfRecipeLabel;
        private Button addIngridientButton;
        private ComboBox categorySelection;
        private TextBox instructionsInput;
        private Button addRecipeButton;
        private ListView listOfRecipieNames;
        private Button editBeginButton;
        private Button editFinishButton;
        private Button deleteButton;
        private Button clearSelectionButton;
        private Label instructionsLabel;
        private Label nameOfRecipeOverRecipePresenter;
        private Label categoryLabelOverRecipePresenter;
        private Label numberOfIngridientesLabelOverRecipePresenter;
    }
}
