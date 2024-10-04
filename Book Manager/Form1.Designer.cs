namespace BookManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            yearTextBox = new TextBox();
            genreTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 109);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(600, 241);
            dataGridView.TabIndex = 0;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Название";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 1;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(118, 12);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.PlaceholderText = "Автор";
            authorTextBox.Size = new Size(100, 23);
            authorTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(224, 12);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Год";
            yearTextBox.Size = new Size(100, 23);
            yearTextBox.TabIndex = 3;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(330, 12);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.PlaceholderText = "Жанр";
            genreTextBox.Size = new Size(100, 23);
            genreTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 50);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(93, 50);
            editButton.Name = "editButton";
            editButton.Size = new Size(97, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(196, 51);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 80);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Поиск по названию или автору";
            searchTextBox.Size = new Size(600, 23);
            searchTextBox.TabIndex = 9;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(12, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 23);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(56, 112);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(154, 112);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Location = new Point(252, 112);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 13;
            label3.Text = "Год";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Location = new Point(353, 113);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "Жанр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonShadow;
            label5.Location = new Point(459, 112);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 15;
            label5.Text = "Прочитано?";
            // 
            // Form1
            // 
            BackgroundImage = Book_Manager.Properties.Resources.back;
            ClientSize = new Size(624, 361);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(searchTextBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(genreTextBox);
            Controls.Add(yearTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = " Книгоменеджероинатор 3000";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
