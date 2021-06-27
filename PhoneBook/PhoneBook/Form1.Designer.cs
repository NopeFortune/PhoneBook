
namespace PhoneBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbFirstNameAsterisk = new System.Windows.Forms.Label();
            this.lbPhoneAsterisk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFirstName.Location = new System.Drawing.Point(26, 64);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(101, 20);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastName.Location = new System.Drawing.Point(26, 111);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(100, 20);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(56, 165);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(65, 20);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(63, 231);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 20);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdress.Location = new System.Drawing.Point(52, 299);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(70, 20);
            this.lbAdress.TabIndex = 4;
            this.lbAdress.Text = "Adress:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearch.Location = new System.Drawing.Point(514, 12);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(71, 20);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Search:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(144, 64);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(193, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(144, 113);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(193, 20);
            this.tbLastName.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(144, 167);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(193, 20);
            this.tbPhone.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 233);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(144, 299);
            this.tbAdress.Multiline = true;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(193, 98);
            this.tbAdress.TabIndex = 10;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(591, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(326, 20);
            this.tbSearch.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(12, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(131, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(250, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 37);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(371, 47);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(704, 410);
            this.dgvData.TabIndex = 15;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // lbFirstNameAsterisk
            // 
            this.lbFirstNameAsterisk.AutoSize = true;
            this.lbFirstNameAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFirstNameAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lbFirstNameAsterisk.Location = new System.Drawing.Point(343, 64);
            this.lbFirstNameAsterisk.Name = "lbFirstNameAsterisk";
            this.lbFirstNameAsterisk.Size = new System.Drawing.Size(16, 20);
            this.lbFirstNameAsterisk.TabIndex = 16;
            this.lbFirstNameAsterisk.Text = "*";
            // 
            // lbPhoneAsterisk
            // 
            this.lbPhoneAsterisk.AutoSize = true;
            this.lbPhoneAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhoneAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneAsterisk.Location = new System.Drawing.Point(343, 167);
            this.lbPhoneAsterisk.Name = "lbPhoneAsterisk";
            this.lbPhoneAsterisk.Size = new System.Drawing.Size(16, 20);
            this.lbPhoneAsterisk.TabIndex = 17;
            this.lbPhoneAsterisk.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 469);
            this.Controls.Add(this.lbPhoneAsterisk);
            this.Controls.Add(this.lbFirstNameAsterisk);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lbFirstNameAsterisk;
        private System.Windows.Forms.Label lbPhoneAsterisk;
    }
}

