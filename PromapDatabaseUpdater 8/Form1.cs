using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

// Program's Main Form
namespace PromapDatabaseUpdater_8
{
    public partial class Form1 : Form
    {
        private static string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = E:/User/work/Remap/source - Developing/ProMap 20190911(Ver 1)- Source/67 ProMap 991107 zarvan v5.2.0/ProMap/PromapDatabase.mdb";
        private OleDbConnection dbcon;
        private string query = "";
        private const string ECU_CELL_CLICKED_EX_MSG = "Could Not Read The Data From The Row ";
        private const string ADD_ITEM_MSG = "Are youe Sure to Add Item?";
        private const string UPDATE_ITEM_MSG = "Are youe Sure to Update Item?";
        private const string DELETE_ITEM_MSG = "Are youe Sure to Delete Item?";
        private const string CONFIRM_TITLE = "Please Confirm ";
        private const string DONE_TITLE = "Done!";
        private const string ECU_INSERT_MSG = "ECU Inserted";
        private const string ECU_UPDATE_MSG = "ECU Updated";
        private const string ECU_DELETE_MSG = "ECU Deleted";
        private string ID = "";
        private string Manufacturer = "";
        private string DeviceName = "";
        private string Type = "";
        private string BootRef = "";
        private string SoftRef = "";
        private string Calibration = "";
        private string BinFileName = "";
        private string BaudRate = "";
        private string CRC_Address = "";
        private int    ConnectionID = 0;
        private string Type1_AddressRemap = "";
        private string Type2_TableRemap = "";
        private string ProductNumber = "";
        private string HardwareCode = "";
        private string Comment = "";
        private int    UserID = 0;
        private string type1Cryption = "";
        private string type2Cryption = "";
        private string binCryption = "";
        private string crcCryption = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ECUsList.DataSource = getEcus();
        }

        private DataTable getEcus()
        {
            dbcon = new OleDbConnection(constr);
            DataTable ecusTable = new DataTable();
            query = "SELECT * FROM ECUsSpecification";

            using (OleDbConnection con = new OleDbConnection(constr))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    ecusTable.Load(reader);
                    con.Close();
                }
            }            
            return ecusTable;
        }
                
        private void addEcuBtnClick(object sender, EventArgs e)
        {
            string values = "";
            string insert = "";

            dbcon = new OleDbConnection(constr);
            ecuDataToAdd();
            insert = "INSERT INTO ECUsSpecification([Manufacturer] , [DeviceName], [Type], [BootRef], [SoftRef], [Calibration], [BinFileName], [BaudRate], [CRC_Address], [ConnectionID], [Type1_AddressRemap], [Type2_TableRemap], [ProductNumber], [HardwareCode], [Comment], [UserID], [type1Cryption], [type2Cryption], [binCryption], [crcCryption]) ";
            values = "VALUES('" + Manufacturer + "','" + DeviceName + "','" + Type + "','" + BootRef + "','" + SoftRef + "','" + Calibration + "','" + BinFileName + "','" + BaudRate + "','" + CRC_Address + "'," + ConnectionID + ",'" + Type1_AddressRemap + "','" + Type2_TableRemap + "','" + ProductNumber + "','" + HardwareCode + "','" + Comment + "'," + UserID + ",'" + type1Cryption + "','" + type2Cryption + "','" + binCryption + "','" + crcCryption + "');";
            query = insert + values;

            if (showMessage(ADD_ITEM_MSG, CONFIRM_TITLE))
            {
                try
                {
                    OleDbCommand cmd = dbcon.CreateCommand();
                    dbcon.Open();
                    cmd.CommandText = query;
                    cmd.Connection = dbcon;
                    cmd.ExecuteNonQuery();
                    showMessage(ECU_INSERT_MSG, DONE_TITLE);
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Error: " + ex.Message);
                }
            }
        }

        private static bool showMessage(string text, string title)
        {
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes;
        }

        private void editEcuBtnClick(object sender, EventArgs e)
        {            
            ecuDataToEdit();
            query = "UPDATE ECUsSpecification SET Manufacturer ='" + Manufacturer + 
                    "' ,DeviceName ='" + DeviceName + "' ,Type ='" + Type +
                    "' ,BootRef ='" + BootRef + "' ,SoftRef ='" + SoftRef +
                    "' ,Calibration ='" + Calibration + "' ,BinFileName ='" + BinFileName + 
                    "' ,ProductNumber = '" + ProductNumber + "' ,HardwareCode = '" + HardwareCode + 
                    "' ,Comment = '" + Comment + "' WHERE ID = " + ID;

            if (showMessage(UPDATE_ITEM_MSG, CONFIRM_TITLE))
            {
                if (string.IsNullOrWhiteSpace(ID_txt.Text))
                {
                    MessageBox.Show("Error: Invalid ID");
                    return;
                }

                try
                {
                    OleDbCommand cmd = dbcon.CreateCommand();
                    dbcon.Open();
                    cmd.CommandText = query;
                    cmd.Connection = dbcon;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(ECU_UPDATE_MSG, DONE_TITLE);
                    dbcon.Close();
                }
               catch (Exception ex)
               {
                    MessageBox.Show("Update Error:" + ex.Message);
               }
            }
        }       

        private void deleteEcuBtnClick(object sender, EventArgs e)
        {
            string ID = ID_txt.Text.Trim();
            query = "DELETE FROM ECUsSpecification WHERE ID = " + ID;

            if (showMessage(DELETE_ITEM_MSG, CONFIRM_TITLE))
            {
                if (string.IsNullOrWhiteSpace(ID_txt.Text))
                {
                    MessageBox.Show("Error: Invalid ID");
                }

                try
                {
                    OleDbCommand cmd = dbcon.CreateCommand();
                    dbcon.Open();
                    cmd.CommandText = query;
                    cmd.Connection = dbcon;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(ECU_DELETE_MSG, DONE_TITLE);
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error:" + ex.Message);
                }
            }
        }        

        private void ecusListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearTextBoxValues();
            try
            {
                idTextInit();
                manufacturerTextInit();
                deviceNameTextInit();
                typeTextInit();
                bootrefTextInit();
                softRefTextInit();
                calibrationTextInit();
                binFileNameTextInit();
                baudrateTextInit();
                productNumberTextInit();
                hardwareCodeTextInit();
                commentTextInit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ECU_CELL_CLICKED_EX_MSG + ex);
            }
        }
        
        private void idTextInit()
        {
            if (ECUsList.CurrentRow.Cells[0].Value != null)
                ID_txt.Text = ECUsList.CurrentRow.Cells[0].Value.ToString();
            else
                ID_txt.Text = string.Empty;
        }        
        private void manufacturerTextInit()
        {
            if (ECUsList.CurrentRow.Cells[1].Value != null)
                Manufacturer_txt.Text = ECUsList.CurrentRow.Cells[1].Value.ToString();
            else
                Manufacturer_txt.Text = string.Empty;
        }
        private void deviceNameTextInit()
        {
            if (ECUsList.CurrentRow.Cells[2].Value != null)
                DeviceName_txt.Text = ECUsList.CurrentRow.Cells[2].Value.ToString();
            else
                DeviceName_txt.Text = string.Empty;
        }
        private void typeTextInit()
        {
            if (ECUsList.CurrentRow.Cells[3].Value != null)
                Type_txt.Text = ECUsList.CurrentRow.Cells[3].Value.ToString();
            else
                Type_txt.Text = string.Empty;
        }
        private void bootrefTextInit()
        {
            if (ECUsList.CurrentRow.Cells[4].Value != null)
                BootRef_txt.Text = ECUsList.CurrentRow.Cells[4].Value.ToString();
            else
                BootRef_txt.Text = string.Empty;
        }
        private void softRefTextInit()
        {
            if (ECUsList.CurrentRow.Cells[5].Value != null)
                SoftRef_txt.Text = ECUsList.CurrentRow.Cells[5].Value.ToString();
            else
                SoftRef_txt.Text = string.Empty;
        }
        private void calibrationTextInit()
        {
            if (ECUsList.CurrentRow.Cells[6].Value != null)
                Calibration_txt.Text = ECUsList.CurrentRow.Cells[6].Value.ToString();
            else
                Calibration_txt.Text = string.Empty;
        }
        private void binFileNameTextInit()
        {
            if (ECUsList.CurrentRow.Cells[7].Value != null)
                BinFileName_txt.Text = ECUsList.CurrentRow.Cells[7].Value.ToString();
            else
                BinFileName_txt.Text = string.Empty;
        }
        private void baudrateTextInit()
        {
            if (ECUsList.CurrentRow.Cells[8].Value != null)
                BaudRate_txt.Text = ECUsList.CurrentRow.Cells[8].Value.ToString();
            else
                BaudRate_txt.Text = string.Empty;
        }
        private void productNumberTextInit()
        {
            if (ECUsList.CurrentRow.Cells[12].Value != null)
                ProductNumber_txt.Text = ECUsList.CurrentRow.Cells[12].Value.ToString();
            else
                ProductNumber_txt.Text = string.Empty;
        }
        private void hardwareCodeTextInit()
        {
            if (ECUsList.CurrentRow.Cells[13].Value != null)
                HardwareCode_txt.Text = ECUsList.CurrentRow.Cells[13].Value.ToString();
            else
                HardwareCode_txt.Text = string.Empty;
        }
        private void commentTextInit()
        {
            if (ECUsList.CurrentRow.Cells[14].Value != null)
                Comment_txt.Text = ECUsList.CurrentRow.Cells[14].Value.ToString();
            else
                Comment_txt.Text = string.Empty;
        }

        private void ecuDataToAdd()
        {
            ID = ID_txt.Text.Trim();
            Manufacturer = Manufacturer_txt.Text.Trim();
            DeviceName = DeviceName_txt.Text.Trim();
            Type = Type_txt.Text.Trim();
            BootRef = BootRef_txt.Text.Trim();
            SoftRef = SoftRef_txt.Text.Trim();
            Calibration = Calibration_txt.Text.Trim();
            BinFileName = BinFileName_txt.Text.Trim();
            BaudRate = BaudRate_txt.Text.Trim();
            CRC_Address = CRC_Address_txt.Text.Trim();
            ConnectionID = int.Parse(ConnectionID_txt.Text.Trim());
            Type1_AddressRemap = Type1_AddressRemap_txt.Text.Trim();
            Type2_TableRemap = Type2_TableRemap_txt.Text.Trim();
            ProductNumber = ProductNumber_txt.Text.Trim();
            HardwareCode = HardwareCode_txt.Text.Trim();
            Comment = Comment_txt.Text.Trim();
            UserID = int.Parse(UserID_txt.Text.Trim());
            type1Cryption = type1Cryption_txt.Text.Trim();
            type2Cryption = type2Cryption_txt.Text.Trim();
            binCryption = binCryption_txt.Text.Trim();
            crcCryption = crcCryption_txt.Text.Trim();
        }
        private void ecuDataToEdit()
        {
            ID = ID_txt.Text.Trim();
            Manufacturer = Manufacturer_txt.Text.Trim();
            DeviceName = DeviceName_txt.Text.Trim();
            Type = Type_txt.Text.Trim();
            BootRef = BootRef_txt.Text.Trim();
            SoftRef = SoftRef_txt.Text.Trim();
            Calibration = Calibration_txt.Text.Trim();
            ProductNumber = ProductNumber_txt.Text.Trim();
            HardwareCode = HardwareCode_txt.Text.Trim();
            Comment = Comment_txt.Text.Trim();
            BinFileName = BinFileName_txt.Text.Trim();
        }

        private void clearTextBoxValues()
        {
            try
            {
                foreach (Control txt in this.Controls)
                {

                    if (txt is TextBox)
                    {
                        txt.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showTableBtnClick(object sender, EventArgs e)
        {
            clearTextBoxValues();
            ECUsList.DataSource = getEcus();
        }
    }
}