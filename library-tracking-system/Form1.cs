using library_tracking_system.Entities;

namespace library_tracking_system
{
    public partial class Form1 : Form
    {
        private List<Book> bookList = new List<Book>();

        private List<string> genres = new List<string>
        {
            "Fiction",
            "Non-Fiction",
            "Mystery",
            "Science Fiction",
            "Fantasy",
            "Biography",
            "History",
            "Romance",
            "Thriller",
            "Horror"
        };

        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = genres;
            numericUpDown1.Maximum = 10000;// capped with 100 so i made it 10k
            listBox1.Items.AddRange(genres.ToArray());


        }

        //showing the books in list and the categories on the right side

        private void ShowBooks(IEnumerable<Book> books)
        {
            listView1.Items.Clear();


            foreach (Book b in books)
            {
                ListViewItem item = new ListViewItem(b.BookTitle);
                item.SubItems.Add(b.BookAuthor);
                item.SubItems.Add(b.BookGenre);
                item.SubItems.Add(b.BookPageNumber.ToString());
                item.SubItems.Add(b.IsAvailable ? "Yes" : "No");
                item.Tag = b;   // this is made only to find which book are we going to delete when we click delete
                listView1.Items.Add(item);
            }
        }

        //cleaning function -> adding this as a function so when someone adds

        private void ClearInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = numericUpDown1.Minimum;
            checkBox1.Checked = false;
        }

        // adding a book
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill in the book title, author and genre.");
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Page number must be greater than 0.");
                return;
            }

            Book newBook = new Book
            {
                BookTitle = textBox1.Text.Trim(),
                BookAuthor = textBox2.Text.Trim(),
                BookGenre = comboBox1.SelectedItem.ToString()!,
                BookPageNumber = (int)numericUpDown1.Value,
                IsAvailable = checkBox1.Checked
            };

            bookList.Add(newBook);
            ShowBooks(bookList);
            ClearInputs();
        }

        // cleaning button
        private void button3_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // LIST (tüm kitapları gösterir)
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            ShowBooks(bookList);
        }

        //search
        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox3.Text.Trim();

            var results = bookList.Where(b =>
                b.BookTitle.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                b.BookAuthor.Contains(keyword, StringComparison.CurrentCultureIgnoreCase)).ToList();

            ShowBooks(results);
        }

        //delete selected 
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select a book to delete.");
                return;
            }

            foreach (ListViewItem item in listView1.SelectedItems.Cast<ListViewItem>().ToList())
            {
                if (item.Tag is Book book)
                {
                    bookList.Remove(book);
                }
                listView1.Items.Remove(item);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Yes.";
            }
            else
            {
                checkBox1.Text = "No";
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Please select a book first.");
                return;
            }

            if (listView1.SelectedItems[0].Tag is Book book)
            {
                MessageBox.Show(
                    $"The selected book is:\n\n" +
                    $"Title: {book.BookTitle}\n" +
                    $"Author: {book.BookAuthor}\n" +
                    $"Genre: {book.BookGenre}\n" +
                    $"Pages: {book.BookPageNumber}\n" +
                    $"Available: {(book.IsAvailable ? "Yes" : "No")}",
                    "Selected Book");
            }
        }
    }
}