using System.Data;
using System.Text.RegularExpressions;

namespace FPWinery
{
    public partial class HomePage : Form
    {

        private Database myDB;
        public HomePage()
        {
            InitializeComponent();
            myDB = new Database();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            myDB.InitDB();
            PopulateWineTable();
            PopulateSupplierTable();
        }

        public void PopulateSupplierTable()
        {
            WineSupplier.Items.Clear();

            List<Supplier> suppliers = myDB.GetSuppliers();

            if(suppliers == null)
            {
                return;
            }
            
            DataTable dtSup = new();

            dtSup.Columns.Add("ID",typeof(int));
            dtSup.Columns.Add("Name",typeof(string));
            dtSup.Columns.Add("Location", typeof(string));
            dtSup.Columns.Add("Email", typeof(string));

            foreach (Supplier supplier in suppliers)
            {
                dtSup.Rows.Add(supplier.SupplierID,supplier.SuppName,supplier.Location,supplier.Email);
                WineSupplier.Items.Add(supplier.SuppName);
            }

            SupplierSource.DataSource = dtSup;

        }

        public void PopulateWineTable()
        {

            List<Wine> Wines = myDB.GetWine();

            if(Wines == null)
            {
                return;
            }

            DataTable WineTable = new DataTable();

            WineTable.Columns.Add("ID",typeof(int));
            WineTable.Columns.Add("Name", typeof(string));
            WineTable.Columns.Add("Price", typeof(double));
            WineTable.Columns.Add("Stock", typeof(int));
            WineTable.Columns.Add("Supplier", typeof(string));

            foreach(Wine wine in Wines)
            {
                WineTable.Rows.Add(wine.WineId, wine.WineName, wine.Price, wine.Stock, wine.SupplierName);
            }

            WineDataGrid.DataSource = WineTable;
        }

        private void SaveWine_Click(object sender, EventArgs e)
        {
            string name = WineName.Text;
            int stock = Convert.ToInt32(WineStock.Text);
            double price = Convert.ToDouble(WinePrice.Text);
            string supplier = WineSupplier.Text;

            Supplier selectedSupplier = myDB.GetSupplierByName(supplier);

            Wine wine = new(0, name, stock, price, selectedSupplier.SupplierID);

            bool result = myDB.AddWine(wine);
            if (result)
            {
                WineName.Clear();
                WineStock.Clear();
                WinePrice.Clear();
                MessageBox.Show("Wine Added!");
                // repopulate the database
                PopulateWineTable();
            }
        }

        private void SaveSup_Click(object sender, EventArgs e)
        {
            string name = SupName.Text;
            string location = SupLocation.Text;
            string email = SupEmail.Text;
            
            // validate email address
            Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                MessageBox.Show("Invalid Email address");
                return;
            }
            
            Supplier newSUp = new(0,name,location,email);

            bool addSup = myDB.AddSupplier(newSUp);

            if(addSup)
            {
                MessageBox.Show("Sup added");
                SupName.Clear();
                SupLocation.Clear();
                SupEmail.Clear();
                // repopulate
                PopulateSupplierTable();
            }

        }
    }
}