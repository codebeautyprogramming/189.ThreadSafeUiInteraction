﻿namespace CookBook.UI
{
    partial class RecipeTypesForm
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
            label1 = new Label();
            NewTypeTxt = new TextBox();
            AddRecipeTypeBtn = new Button();
            RecipeTypesCustomLbx = new CustomUserControls.CustomListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(131, 31);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(202, 35);
            NewTypeTxt.TabIndex = 1;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(34, 465);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(299, 53);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipeTypesCustomLbx
            // 
            RecipeTypesCustomLbx.Location = new Point(34, 97);
            RecipeTypesCustomLbx.Name = "RecipeTypesCustomLbx";
            RecipeTypesCustomLbx.SelectedItem = null;
            RecipeTypesCustomLbx.Size = new Size(299, 334);
            RecipeTypesCustomLbx.TabIndex = 4;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 557);
            Controls.Add(RecipeTypesCustomLbx);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(NewTypeTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeTypesForm";
            Text = "RecipeTypesForm";
            Load += RecipeTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewTypeTxt;
        private Button AddRecipeTypeBtn;
        private CustomUserControls.CustomListBox RecipeTypesCustomLbx;
    }
}