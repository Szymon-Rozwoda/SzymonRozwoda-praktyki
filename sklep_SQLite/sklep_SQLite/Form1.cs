using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


namespace sklep_SQLite
{
    public partial class Form1 : Form
    {
        SQLiteConnection sqliteConnection;
        public Form1()
        {
            InitializeComponent();
            
            
            sqliteConnection = CreateConnection();
            CreateTable1(sqliteConnection);
            CreateTable2(sqliteConnection);
            CreateTable3(sqliteConnection);
            CreateTable4(sqliteConnection);
            
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn;
            sqliteConn = new SQLiteConnection("Data Source=database.db; version = 3; New = True; Compress = True");
            try
            {
                sqliteConn.Open();
            }
            catch
            {

            }
            return sqliteConn;
        }

        static void CreateTable1(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            string createSQL = "CREATE TABLE IF NOT EXISTS products(id VARCHAR(25), name VARCHAR(25),price VARCHAR(25), vat VARCHAR(25), details VARCHAR(100),available VARCHAR(3))";
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = createSQL;
            sqliteCommand.ExecuteNonQuery();
        }
        static void CreateTable2(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            string createSQL = "CREATE TABLE IF NOT EXISTS clients(id VARCHAR(25), name VARCHAR(25), details VARCHAR(100))";
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = createSQL;
            sqliteCommand.ExecuteNonQuery();
        }
        static void CreateTable3(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            string createSQL = "CREATE TABLE IF NOT EXISTS orders(id VARCHAR(25),clientid VARCHAR(25),creationdate VARCHAR(10), deliverydate VARCHAR(10), total VARCHAR(25))";
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = createSQL;
            sqliteCommand.ExecuteNonQuery();
        }
        static void CreateTable4(SQLiteConnection conn)
        {
            SQLiteCommand sqliteCommand;
            string createSQL = "CREATE TABLE IF NOT EXISTS product_x_order(productid VARCHAR(25),orderid VARCHAR(25),quantity VARCHAR(25), subtotal VARCHAR(25))";
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = createSQL;
            sqliteCommand.ExecuteNonQuery();
        }
        static string ReadData(SQLiteConnection conn,string tabela)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("SELECT * FROM "+tabela);
            sqliteReader = sqliteCommand.ExecuteReader();

            string tekst = "";
            for(int i = 0; i < sqliteReader.FieldCount; i++)
            {
                tekst += sqliteReader.GetName(i) + "\t";
                Console.WriteLine( sqliteReader.GetName(i)+"\t" );
            }
            tekst += "\r\n";
            Console.WriteLine();
            while (sqliteReader.Read())
            {
                for(int i = 0;i< sqliteReader.FieldCount; i++)
                {
                    tekst += sqliteReader.GetValue(i) + "\t";
                    Console.Write(sqliteReader.GetValue(i)+"\t");
                }
                Console.WriteLine() ;
                tekst += "\r\n";
            }
           
            return tekst;
            
        }
        public static void ReadDataZapytanie(SQLiteConnection conn, string tabela, string kolumna, string dodatkiDoZapytania)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("SELECT " + kolumna + " FROM " + tabela + " " + dodatkiDoZapytania);
            sqliteReader = sqliteCommand.ExecuteReader();
            string tekst = "";
            for (int i = 0; i < sqliteReader.FieldCount; i++)
            {
                tekst += sqliteReader.GetName(i) + "\t";
                Console.WriteLine(sqliteReader.GetName(i) + "\t");
            }
            tekst += "\r\n";
            Console.WriteLine();
            while (sqliteReader.Read())
            {
                for (int i = 0; i < sqliteReader.FieldCount; i++)
                {
                    tekst += sqliteReader.GetValue(i) + "\t";
                    Console.Write(sqliteReader.GetValue(i) + "\t");
                }
                Console.WriteLine();
                tekst += "\r\n";
            }
            MessageBox.Show(tekst);
        }

        static void EditDataZapytanie(SQLiteConnection conn, string tabela, string kolumna,string nowaWartosc, string dodatkiDoZapytania)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("UPDATE "+tabela+" SET "+kolumna+" = "+nowaWartosc+" "+dodatkiDoZapytania);
            sqliteReader = sqliteCommand.ExecuteReader();
            string tekst = "";
            for (int i = 0; i < sqliteReader.FieldCount; i++)
            {
                tekst += sqliteReader.GetName(i) + "\t";
                Console.WriteLine(sqliteReader.GetName(i) + "\t");
            }
            tekst += "\r\n";
            Console.WriteLine();
            while (sqliteReader.Read())
            {
                for (int i = 0; i < sqliteReader.FieldCount; i++)
                {
                    tekst += sqliteReader.GetValue(i) + "\t";
                    Console.Write(sqliteReader.GetValue(i) + "\t");
                }
                Console.WriteLine();
                tekst += "\r\n";
            }
            MessageBox.Show(tekst);
        }
        static void DeleteData(SQLiteConnection conn, string tabela, string dodatkiDoZapytania)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("DELETE FROM "+tabela+" "+dodatkiDoZapytania);
            sqliteReader = sqliteCommand.ExecuteReader();
            string tekst = "";
            for (int i = 0; i < sqliteReader.FieldCount; i++)
            {
                tekst += sqliteReader.GetName(i) + "\t";
                Console.WriteLine(sqliteReader.GetName(i) + "\t");
            }
            tekst += "\r\n";
            Console.WriteLine();
            while (sqliteReader.Read())
            {
                for (int i = 0; i < sqliteReader.FieldCount; i++)
                {
                    tekst += sqliteReader.GetValue(i) + "\t";
                    Console.Write(sqliteReader.GetValue(i) + "\t");
                }
                Console.WriteLine();
                tekst += "\r\n";
            }
            MessageBox.Show(tekst);
        }

        static void InsertData1(SQLiteConnection conn, string id, string name, string price, string vat, string details, string available)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO products(id,name,price,vat,details,available) VALUES ('"+id+"','"+name+"','"+price+"','"+vat+"','"+details+"','"+available+"')");
            sqliteCommand.ExecuteNonQuery();
        }
        static void InsertData2(SQLiteConnection conn, string id, string name, string details)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO clients(id,name,details) VALUES ('"+id+"','"+name+"','"+details+"')");
            sqliteCommand.ExecuteNonQuery();
        }
        static void InsertData3(SQLiteConnection conn, string id, string clientid, string creationdate, string deliverydate, string total)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO orders(id,clientid, creationdate, deliverydate, total) VALUES ('"+id+"','"+clientid+"','"+creationdate+"','"+deliverydate+"','"+total+"')");
            sqliteCommand.ExecuteNonQuery();
        }
        static void InsertData4(SQLiteConnection conn, string productid, string orderid, string quantity, string subtotal)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO product_x_order(productid,orderid, quantity, subtotal) VALUES ('"+productid+"','"+orderid+"','"+quantity+"','"+subtotal+"')");
            
            sqliteCommand.ExecuteNonQuery();
        }
        
        

        
        static bool CzyMoznaZamowic(SQLiteConnection conn, string id)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("SELECT available FROM products WHERE id="+id);
            sqliteReader = sqliteCommand.ExecuteReader();
            string readerString="";
            while (sqliteReader.Read())
            {
                 readerString = sqliteReader.GetString(0);
                //MessageBox.Show(readerString);
            }
            if(readerString == "TAK")
            {
                return true;
            }else
            {
                return false;
            }


        }
        public string pobierzId()
        {
            string id;
            id = textBox14.Text;
                return id;
        }

        static void Zamow(SQLiteConnection conn, string id)
        {
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = ("INSERT INTO orders(id,clientid, creationdate, deliverydate, total) VALUES ('" + id + "','" + "1" + "','" + DateTime.Now + "','" + DateTime.Now + "','" + "0" + "')");
            sqliteCommand.ExecuteNonQuery();
        }




        private void products_CheckedChanged(object sender, EventArgs e)
        {
            SetTable("products");
            zarzadzanielabelami();
        }

        private void clients_CheckedChanged(object sender, EventArgs e)
        {
            SetTable("clients");
            zarzadzanielabelami();
        }

        private void orders_CheckedChanged(object sender, EventArgs e)
        {
            SetTable("orders");
            zarzadzanielabelami();
        }

        private void product_x_order_CheckedChanged(object sender, EventArgs e)
        {
            SetTable("product_x_order");
            zarzadzanielabelami();
        }
        private void SetTable(string Name)
        {
            label1.Text = Name;
            label10.Text = Name;
            label14.Text = Name;
            label16.Text = Name;
        }
        private string wybranaTabla()
        {
            if(label1.Text == "products")
            {
                return "products";
            }
            else if(label1.Text == "clients")
            {
                return "clients";
            }
            else if(label1.Text == "orders")
            {
                return "orders";
            }
            else
            {
                return "product_x_order";
            }
        }
         
         
        public void zarzadzanielabelami()
        {
            if (label1.Text == "products")
            {
                label2.Text = "id";
                label3.Text = "name";
                label4.Text = "price";
                label5.Text = "vat";
                label6.Text = "details";
                label7.Text = "available";
                textBox7.Text = ReadData(sqliteConnection, wybranaTabla());
            }
            else if (label1.Text == "clients")
            {
                label2.Text = "id";
                label3.Text = "name";
                label4.Text = "details";
                label5.Text = "--";
                label6.Text = "--";
                label7.Text = "--";
                textBox7.Text = ReadData(sqliteConnection, wybranaTabla());
            }
            else if (label1.Text == "orders")
            {
                label2.Text = "id";
                label3.Text = "clientid";
                label4.Text = "creationdate";
                label5.Text = "deliverydate";
                label6.Text = "total";
                label7.Text = "--";
                textBox7.Text = ReadData(sqliteConnection, wybranaTabla());
            }
            else
            {
                label2.Text = "productid";
                label3.Text = "orderid";
                label4.Text = "quantity";
                label5.Text = "subtotal";
                label6.Text = "--";
                label7.Text = "--";
                textBox7.Text = ReadData(sqliteConnection, wybranaTabla());
            }
        }
        public string wybranaKolumnaSelect()
        {
            string kolumna = "";
            kolumna = textBox8.Text;
            return kolumna;
        }
        public string dodatkiDoZapytaniaSelect()
        {
            string dodatki = "";
            dodatki = textBox9.Text;
            return dodatki;
        }
        public string wybranaKolumnaUpdate()
        {
            string kolumna = "";
            kolumna = textBox11.Text;
            return kolumna;
        }
        public string nowaWartoscUpdate()
        {
            string nowaWartosc = "";
            nowaWartosc = textBox12.Text;
            return nowaWartosc;
        }
        public string dodatkiDoZapytaniaUpdate()
        {
            string dodatki = "";
            dodatki = textBox13.Text;
            return dodatki;
        }
        public string dodatkiDoZapytaniaDelete()
        {
            string dodatki = "";
            dodatki = textBox10.Text;
            return dodatki;
        }


        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if(wybranaTabla() == "products")
            {
                InsertData1(sqliteConnection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            }
            else if(wybranaTabla() == "clients")
            {
                InsertData2(sqliteConnection, textBox1.Text, textBox2.Text, textBox3.Text);
            }
            else if ((wybranaTabla() == "orders"))
            {
                InsertData3(sqliteConnection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            else
            {
                InsertData4(sqliteConnection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            }
        }

        private void SzukajBtn_Click(object sender, EventArgs e)
        {
            
            ReadDataZapytanie(sqliteConnection, wybranaTabla(), wybranaKolumnaSelect(), dodatkiDoZapytaniaSelect());
            zarzadzanielabelami();
            
        }

        private void EdytujBtn_Click(object sender, EventArgs e)
        {
            EditDataZapytanie(sqliteConnection, wybranaTabla(),wybranaKolumnaUpdate(), nowaWartoscUpdate(), dodatkiDoZapytaniaUpdate());
            zarzadzanielabelami();
        }

        private void UsunBtn_Click(object sender, EventArgs e)
        {
            DeleteData(sqliteConnection, wybranaTabla(), dodatkiDoZapytaniaDelete());
            zarzadzanielabelami();
        }

        private void zamowienie_Click(object sender, EventArgs e)
        {
            pobierzId();

            if (CzyMoznaZamowic(sqliteConnection, pobierzId())) 
            {

                MessageBox.Show("Zamowiono");
            }
            else
            {
                MessageBox.Show("Nie mozna zamowic");
            }

            zarzadzanielabelami();
            Zamow(sqliteConnection, pobierzId());
        }
    }
}