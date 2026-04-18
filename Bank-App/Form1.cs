namespace Bank_App
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }


        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();

            OwnerTxt.Text = "";
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                selectedBankAccount.Balance += AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                selectedBankAccount.Balance -= AmountNum.Value;
                RefreshGrid();
                AmountNum.Value = 0;
            }
        }
    }
}
