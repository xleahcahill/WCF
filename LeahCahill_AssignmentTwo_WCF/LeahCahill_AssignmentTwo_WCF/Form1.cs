using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace LeahCahill_AssignmentTwo_WCF
{

    public partial class Form1 : Form
    {
        public delegate void UpdateListBoxDelegate(string itm);
        public delegate void UpdateList2BoxDelegate2(int prc);
        private Iitem channel;
        private bool userlogged;

        public void AddItem(string itm)
        {
            if (itemlistBox.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                itemlistBox.Invoke(new UpdateListBoxDelegate(AddItem), itm);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                itemlistBox.Items.Add("book");
            }
        }

        public void AddItem2(string itm)
        {
            if (itemlistBox.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                itemlistBox.Invoke(new UpdateListBoxDelegate(AddItem2), itm);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                itemlistBox.Items.Add("CD");
            }
        }
        public void AddItem3(string itm)
        {
            if (itemlistBox.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                itemlistBox.Invoke(new UpdateListBoxDelegate(AddItem3), itm);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                itemlistBox.Items.Add("DVD");
            }
        }
        public void AddItem4(string itm)
        {
            if (itemlistBox.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                itemlistBox.Invoke(new UpdateListBoxDelegate(AddItem4), itm);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                itemlistBox.Items.Add("Lamp");
            }
        }

        public void AddPrice1(string prc)
        {
            if (priceList.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                priceList.Invoke(new UpdateListBoxDelegate(AddPrice1), prc);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                priceList.Items.Add(10);
            }
        }


        public void AddPrice2(string prc)
        {
            if (priceList.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                priceList.Invoke(new UpdateListBoxDelegate(AddPrice2), prc);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                priceList.Items.Add(15);
            }
        }
        public void AddPrice3(string prc)
        {
            if (priceList.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                priceList.Invoke(new UpdateListBoxDelegate(AddPrice3), prc);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                priceList.Items.Add(8);
            }
        }
        public void AddPrice4(string prc)
        {
            if (priceList.InvokeRequired)
            {
                //We are not on the thread which created this control.
                //Must invoke an event to update it.
                priceList.Invoke(new UpdateListBoxDelegate(AddPrice4), prc);
            }
            else
            {
                //We are on the thread which created this control.
                //We can just update it directly.
                priceList.Items.Add(20);
            }
        }

        public Form1()
        {
            InitializeComponent();

            store s1 = new store(this);

            DuplexChannelFactory<Iitem> it = new DuplexChannelFactory<Iitem>(new InstanceContext(s1), "storeEP");
            channel = it.CreateChannel();
            ((ICommunicationObject)channel).Open();
        }

        private void itemlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            channel.SendItem1("book");
            channel.Item1Price(10);
        }

        private void addCDbutton_Click(object sender, EventArgs e)
        {
            channel.SendItem2("CD");
            channel.Item2Price(15);
        }

        private void calcuate_Click(object sender, EventArgs e) // calcuate subtotal
        {
            int i = 0, result = 0;
            while (i < priceList.Items.Count)
            {
                result += Convert.ToInt32(priceList.Items[i++]);
            }

            total.Text = Convert.ToString((double)result);

            totaltextbox.Text = priceList.Items.Count.ToString();
        }

        private void totaltextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Registerbutton_Click(object sender, EventArgs e) // registering user to the database
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\LEAHC\DOCUMENTS\CUSTOMER.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into customer values(@p1,@p2)";
            cmd = new SqlCommand(s, cnn);

            cmd.Parameters.AddWithValue("@p1", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@p2", passwordregistertext.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
          
                try
                {
                    //Create a new file to write our encrypted data to.
                    FileStream fs = new FileStream("Output.txt", FileMode.Create);

                    //Create a new instance of the RijndaelManaged class which will be our cryptography engine.
                    RijndaelManaged cryptEngine = new RijndaelManaged();

                    //Generate a simple key and initialisation vector.
                    byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                    byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                    //Create a CryptoStream, pass it the FileStream, and encrypt cryptography engine.
                    CryptoStream CryptStream = new CryptoStream(fs, cryptEngine.CreateEncryptor(Key, IV), CryptoStreamMode.Write);

                    //Create a StreamWriter to write to the file.
                    StreamWriter SWriter = new StreamWriter(CryptStream);

                    // data to be encrypted.
                    SWriter.WriteLine(passwordregistertext.Text);

                //Close all handles.
                SWriter.Close();
                    CryptStream.Close();
                    fs.Close();
                }
                catch
                {
                }
            MessageBox.Show(" Thank you for signing up. ");
        }

        

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            string userlogin = textBoxLoginusername.Text;
            string userpw = passwordregistertext.Text;

            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\LEAHC\DOCUMENTS\CUSTOMER.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE username = '" + userlogin + "' AND [password] = '" + userpw + "' ", cnn);
            cnn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            //  If the record can be queried, it means passing verification, then open another form.  
            if ((sdr.Read() == true))

            {
                MessageBox.Show("Thank you for logging in");
                //set user logged to true when they have logged in after registering              
                userlogged = true;

            }

            else

            {

                MessageBox.Show("Invalid username or password. Try again.");

            }
        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {

            if (userlogged == true) // checking to see if user has logged in first 
            {
                MessageBox.Show("Purchase complete.");
            }
            else
            {
                MessageBox.Show("You must be logged in to purchase");
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dvdbutton_Click(object sender, EventArgs e)
        {
            channel.SendItem3("DVD");
            channel.Item3Price(8);
        }

        private void button2_Click(object sender, EventArgs e) // for lamp
        {
            channel.SendItem4("Lamp");
            channel.Item4Price(20);
        }

        private void calcTotalwithDelivery_Click(object sender, EventArgs e) // calcuate button (with delivery prices)
        {
            int i = 0, result = 0;
            while (i < priceList.Items.Count)
            {
                result += Convert.ToInt32(priceList.Items[i++]);
            }



            if (result < 50)
            {
                result = result + 6;
                finaltotal.Text = Convert.ToString((double)result); //6
            }
            if (result > 50 && result < 99)
            {
                result = result + 4;
                finaltotal.Text = Convert.ToString((double)result ); //4.50
            }
            if (result > 100 && result < 149.99)
            {
               result = result + 2;
              finaltotal.Text = Convert.ToString((double)result + 2); // 2
            }
            else 
            {
                finaltotal.Text = Convert.ToString((double)result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    //Read the file written previously.
                    FileStream fs = new FileStream("Output.txt", FileMode.Open);

                    //Create a new instance of the RijndaelManaged class which will be our cryptography engine.
                    RijndaelManaged cryptEngine = new RijndaelManaged();

                    //Generate a simple key and initialisation vector.
                    byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                    byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                    //Create a CryptoStream, pass it the FileStream, and decrypt cryptography engine.
                    CryptoStream CryptStream = new CryptoStream(fs, cryptEngine.CreateDecryptor(Key, IV), CryptoStreamMode.Read);

                    //Create a StreamWriter to read the file.
                    StreamReader SRead = new StreamReader(CryptStream);

                    //Read the line from the file.
                    String s = SRead.ReadLine();

                    //Write the result to the console.
                 //   Console.WriteLine(s);
                MessageBox.Show(s);

                //Close all handles.
                SRead.Close();
                    CryptStream.Close();
                    fs.Close();
                }
                catch
                {
                //Inform the user that the file was not read due to an internal failure.
                MessageBox.Show("Could not read file.");
                }
            }

        }
    }

    
 