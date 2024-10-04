using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BookManager;
namespace BookManager
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            LoadBooks();
            RefreshBookList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = titleTextBox.Text,
                Author = authorTextBox.Text,
                Year = int.Parse(yearTextBox.Text),
                Genre = genreTextBox.Text,
               
            };
            books.Add(book);
            RefreshBookList();
            SaveBooks();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var index = dataGridView.SelectedRows[0].Index;
                books[index].Title = titleTextBox.Text;
                books[index].Author = authorTextBox.Text;
                books[index].Year = int.Parse(yearTextBox.Text);
                books[index].Genre = genreTextBox.Text;
                //RefreshBookList();
                SaveBooks();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var index = dataGridView.SelectedRows[0].Index;
                books.RemoveAt(index);
                RefreshBookList();
                SaveBooks();
            }
        }

        private void RefreshBookList()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = books;
        }

        private void LoadBooks()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "books.csv");
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        var book = new Book
                        {
                            Title = parts[0],
                            Author = parts[1],
                            Year = int.Parse(parts[2]),
                            Genre = parts[3],
                            IsRead = bool.Parse(parts[4])
                        };
                        books.Add(book);
                    }
                }
            }
        }

        private void SaveBooks()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "books.csv");
            using (var writer = new StreamWriter(path))
            {
                foreach (var book in books)
                {
                    writer.WriteLine($"{book.Title},{book.Author},{book.Year},{book.Genre},{book.IsRead}");
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchedBooks = books.Where(b => b.Title.Contains(searchTextBox.Text) || b.Author.Contains(searchTextBox.Text)).ToList();
            dataGridView.DataSource = null;
            dataGridView.DataSource = searchedBooks;
        }
    }
}
