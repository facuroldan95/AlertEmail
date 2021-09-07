
namespace AlertEmail
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnImportar = new System.Windows.Forms.Button();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.txtCell = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClean = new System.Windows.Forms.Button();
			this.txtCC = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.btnLoadFile = new System.Windows.Forms.Button();
			this.txtFiles = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtReceivers = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOrigen = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtHoja = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dgvEmails = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnImportar
			// 
			this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnImportar.Location = new System.Drawing.Point(23, 119);
			this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(283, 82);
			this.btnImportar.TabIndex = 10;
			this.btnImportar.Text = "Importar Correos XLS";
			this.btnImportar.UseVisualStyleBackColor = true;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// btnDisplay
			// 
			this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.btnDisplay.Location = new System.Drawing.Point(8, 363);
			this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(316, 98);
			this.btnDisplay.TabIndex = 9;
			this.btnDisplay.Text = "Envíar";
			this.btnDisplay.UseVisualStyleBackColor = true;
			this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
			// 
			// txtCell
			// 
			this.txtCell.Location = new System.Drawing.Point(25, 39);
			this.txtCell.Margin = new System.Windows.Forms.Padding(4);
			this.txtCell.Name = "txtCell";
			this.txtCell.Size = new System.Drawing.Size(279, 22);
			this.txtCell.TabIndex = 11;
			this.txtCell.Text = "email";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClean);
			this.groupBox1.Controls.Add(this.txtCC);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtSubject);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtBody);
			this.groupBox1.Controls.Add(this.btnLoadFile);
			this.groupBox1.Controls.Add(this.txtFiles);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtReceivers);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnDisplay);
			this.groupBox1.Controls.Add(this.txtOrigen);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(16, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1116, 822);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos";
			// 
			// btnClean
			// 
			this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.btnClean.Location = new System.Drawing.Point(7, 466);
			this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(316, 58);
			this.btnClean.TabIndex = 19;
			this.btnClean.Text = "Limpiar";
			this.btnClean.UseVisualStyleBackColor = true;
			this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
			// 
			// txtCC
			// 
			this.txtCC.Location = new System.Drawing.Point(563, 224);
			this.txtCC.Margin = new System.Windows.Forms.Padding(4);
			this.txtCC.Name = "txtCC";
			this.txtCC.Size = new System.Drawing.Size(480, 22);
			this.txtCC.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(557, 186);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 22);
			this.label9.TabIndex = 17;
			this.label9.Text = "CC:";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(31, 224);
			this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(476, 22);
			this.txtSubject.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(31, 186);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 22);
			this.label7.TabIndex = 13;
			this.label7.Text = "Asunto:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(325, 336);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 22);
			this.label6.TabIndex = 12;
			this.label6.Text = "Mensaje:";
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(331, 363);
			this.txtBody.Margin = new System.Windows.Forms.Padding(4);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(771, 451);
			this.txtBody.TabIndex = 8;
			// 
			// btnLoadFile
			// 
			this.btnLoadFile.Location = new System.Drawing.Point(1051, 298);
			this.btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadFile.Name = "btnLoadFile";
			this.btnLoadFile.Size = new System.Drawing.Size(51, 23);
			this.btnLoadFile.TabIndex = 10;
			this.btnLoadFile.Text = "...";
			this.btnLoadFile.UseVisualStyleBackColor = true;
			this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
			// 
			// txtFiles
			// 
			this.txtFiles.Location = new System.Drawing.Point(31, 298);
			this.txtFiles.Margin = new System.Windows.Forms.Padding(4);
			this.txtFiles.Name = "txtFiles";
			this.txtFiles.Size = new System.Drawing.Size(1012, 22);
			this.txtFiles.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(31, 260);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Archivos (Sep. Por \'|\')";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(701, 58);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(268, 22);
			this.txtName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(696, 28);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 22);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nombre:";
			// 
			// txtReceivers
			// 
			this.txtReceivers.Location = new System.Drawing.Point(31, 144);
			this.txtReceivers.Margin = new System.Windows.Forms.Padding(4);
			this.txtReceivers.Name = "txtReceivers";
			this.txtReceivers.Size = new System.Drawing.Size(1071, 22);
			this.txtReceivers.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Destinatarios (Sep. Por \',\')";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(367, 58);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(268, 22);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(361, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contraseña:";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(31, 58);
			this.txtOrigen.Margin = new System.Windows.Forms.Padding(4);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(268, 22);
			this.txtOrigen.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Correo Origen:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtHoja);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.dgvEmails);
			this.groupBox2.Controls.Add(this.btnImportar);
			this.groupBox2.Controls.Add(this.txtCell);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(0, 530);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(316, 284);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "RELLENAR ANTES DE IMPORTAR !!";
			// 
			// txtHoja
			// 
			this.txtHoja.Location = new System.Drawing.Point(25, 90);
			this.txtHoja.Margin = new System.Windows.Forms.Padding(4);
			this.txtHoja.Name = "txtHoja";
			this.txtHoja.Size = new System.Drawing.Size(279, 22);
			this.txtHoja.TabIndex = 16;
			this.txtHoja.Text = "hoja1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(28, 69);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(130, 17);
			this.label12.TabIndex = 17;
			this.label12.Text = "Nombre de la Hoja:";
			// 
			// dgvEmails
			// 
			this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmails.Location = new System.Drawing.Point(23, 207);
			this.dgvEmails.Margin = new System.Windows.Forms.Padding(4);
			this.dgvEmails.Name = "dgvEmails";
			this.dgvEmails.RowHeadersWidth = 51;
			this.dgvEmails.Size = new System.Drawing.Size(283, 65);
			this.dgvEmails.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 18);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(156, 17);
			this.label8.TabIndex = 15;
			this.label8.Text = "Nombre de la Columna:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 843);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(77, 862);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(762, 17);
			this.label10.TabIndex = 6;
			this.label10.Text = "Software desarrollado para el envío de Emails, utilizando cuenta solamente labora" +
    "l (nombre@sumemergencias.com.ar).";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1137, 911);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximumSize = new System.Drawing.Size(1155, 958);
			this.MinimumSize = new System.Drawing.Size(1155, 958);
			this.Name = "Form1";
			this.Text = "Alert Email V0.1  | SUM | By Facundo Roldán";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.Button btnDisplay;
		private System.Windows.Forms.TextBox txtCell;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.Button btnLoadFile;
		private System.Windows.Forms.TextBox txtFiles;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtReceivers;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvEmails;
		private System.Windows.Forms.TextBox txtCC;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtHoja;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnClean;
	}
}

