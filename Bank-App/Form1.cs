namespace Bank_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Abdozy";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 250;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Shtefan";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 367;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Bober";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 2167;

            var bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BankAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
