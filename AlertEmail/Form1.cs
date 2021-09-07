using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;

namespace AlertEmail
{
	public partial class Form1 : Form
	{
		char[] delimiter_cc = {','};
		char[] delimiter_Attachments = {'|'};
		public Form1()
		{
			InitializeComponent();
			txtOrigen.Text = "@sumemergencias.com.ar";
			txtBody.ScrollBars = ScrollBars.Vertical;
		}

		private DataView ImportData(string nameFile)
		{
			try
			{
				string connection = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nameFile);
				OleDbConnection con = new OleDbConnection(connection);
				con.Open();


				OleDbCommand query = new OleDbCommand("Select * from [" + txtHoja.Text + "$]", con);

				OleDbDataAdapter adapter = new OleDbDataAdapter
				{
					SelectCommand = query
				};

				DataSet ds = new DataSet();

				adapter.Fill(ds);

				con.Close();

				return ds.Tables[0].DefaultView;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}

			

		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			string emails = "";
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Excel | *.xls;*.xlsx;",
				Title = "Selecccionar Archivo..."
			};

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				dgvEmails.DataSource = ImportData(openFileDialog.FileName);
				try
				{
					for (int i = 0; i < dgvEmails.RowCount - 1; i++)
					{
						if (dgvEmails.Rows[i].Cells[txtCell.Text].Value.ToString().Length > 1 && dgvEmails.Rows[i].Cells["email"].Value.ToString().Contains("@")) 
							emails += dgvEmails.Rows[i].Cells["email"].Value.ToString() + ",";
					}
					emails = emails.Remove(emails.Length - 1);
					txtReceivers.Text = emails;
				}
				catch (Exception ex)
				{

					MessageBox.Show("Error: Revisar nombre de la columna. Det. Error: " + ex.Message);
				}
			}
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			sendEmail("s1000178.ferozo.com", 25, txtOrigen.Text, txtPassword.Text, txtName.Text, txtReceivers.Text, txtCC.Text, txtSubject.Text, txtFiles.Text, txtBody.Text);
		}

		public void sendEmail(
			string host, 
			int port, 
			string sender, 
			string password, 
			string name, 
			string recipients,
			string cc,
			string subject,
			string attachments,
			string body
			)
		{
			try
			{
				SmtpClient client = new SmtpClient(host, port);
				MailMessage email = new MailMessage();

				email.From = new MailAddress(sender, name);
				email.Body = body;
				email.Subject = subject;
				if(recipients == "") { }
				else
				{
					string[] recipientString = recipients.Split(delimiter_cc);
					foreach (string word in recipientString) { email.To.Add(word.Trim()); }
				}

				if (cc == "") { }
				else
				{
					string[] CCString = cc.Split(delimiter_cc);
					foreach (string word in CCString) { email.CC.Add(word.Trim()); }
				}

				if (attachments == "") { }
				else
				{
					string[] AttachmentsString = attachments.Split(delimiter_Attachments);
					foreach (string word in AttachmentsString) { email.Attachments.Add(new Attachment(word)); }
				}


				client.Credentials = new NetworkCredential(sender, password);
				//client.EnableSsl = true;
				client.Send(email);
				MessageBox.Show("Tarea completada con éxito...");
				CleanTextBoxs();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void btnLoadFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Todos los Archivos | *.*";
			openFile.Title = "Abrir...";
			openFile.InitialDirectory = @"C:\";
			if(openFile.ShowDialog() == DialogResult.OK)
			{
				if (txtFiles.Text == "" || txtFiles.Text == null) txtFiles.Text = openFile.FileName;
				else txtFiles.Text += @"|" + openFile.FileName;
			}
		}

		private void btnClean_Click(object sender, EventArgs e)
		{
			CleanTextBoxs();	
		}

		private void CleanTextBoxs()
		{
			txtCC.Clear();
			txtBody.Clear();
			txtCell.Text = "email";
			txtFiles.Clear();
			txtHoja.Text = "hoja1";
			txtOrigen.Clear();
			txtName.Clear();
			txtSubject.Clear();
			txtReceivers.Clear();
			txtPassword.Clear();
		}
	}
}
