using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Frm_HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_MainScreenTitle = new System.Windows.Forms.Label();
            this.Lbl_EnterQuoteNumber = new System.Windows.Forms.Label();
            this.Txt_QuoteNumberSupplied = new System.Windows.Forms.TextBox();
            this.Cmd_GetQuoteInformation = new System.Windows.Forms.Button();
            this.Lbl_Txt_Proquote_CustomerName = new System.Windows.Forms.Label();
            this.Txt_Proquote_CustomerName = new System.Windows.Forms.TextBox();
            this.Lbl_Proquote_BillTo = new System.Windows.Forms.Label();
            this.Txt_Proquote_BillTo = new System.Windows.Forms.TextBox();
            this.Txt_Proquote_Shipto = new System.Windows.Forms.TextBox();
            this.Lbl_Proquote_ShipTo = new System.Windows.Forms.Label();
            this.Txt_Proquote_Scope = new System.Windows.Forms.TextBox();
            this.Lbl_Proquote_Scope = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_Proquote_BOM = new System.Windows.Forms.Label();
            this.Tab_Proquote_Information = new System.Windows.Forms.TabControl();
            this.Tab_Proquote_Tab1_PQInfo = new System.Windows.Forms.TabPage();
            this.Tab_Proquote_BOM = new System.Windows.Forms.TabPage();
            this.Tab_Manpower_Ladders_1 = new System.Windows.Forms.TabPage();
            this.Tab_Proquote_Information_Acceptance = new System.Windows.Forms.TabPage();
            this.Cmd_CustomerInfo_Next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Proquote_ManHours = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lbl_BillOfMaterials = new System.Windows.Forms.Label();
            this.billOfMaterials = new WindowsFormsApp1.BillOfMaterials();
            this.spIdeaBOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Idea_BOMTableAdapter = new WindowsFormsApp1.BillOfMaterialsTableAdapters.sp_Idea_BOMTableAdapter();
            this.DataGrid_ProquoteBOM = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmd_BOM_NextButton = new System.Windows.Forms.Button();
            this.Cmd_BOM_BackButton = new System.Windows.Forms.Button();
            this.Lbl_BOM_DeliveryInstructions = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_AdditionalInfo_TestResults = new System.Windows.Forms.Label();
            this.Lbl__AdditionalInformation_NOWARRANTY = new System.Windows.Forms.Label();
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tab_SpecialNotes = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.Tab_Proquote_Information.SuspendLayout();
            this.Tab_Proquote_Tab1_PQInfo.SuspendLayout();
            this.Tab_Proquote_BOM.SuspendLayout();
            this.Tab_Manpower_Ladders_1.SuspendLayout();
            this.Tab_Proquote_Information_Acceptance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIdeaBOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProquoteBOM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.Tab_SpecialNotes.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_MainScreenTitle
            // 
            this.Lbl_MainScreenTitle.AutoSize = true;
            this.Lbl_MainScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MainScreenTitle.Location = new System.Drawing.Point(13, 13);
            this.Lbl_MainScreenTitle.Name = "Lbl_MainScreenTitle";
            this.Lbl_MainScreenTitle.Size = new System.Drawing.Size(413, 37);
            this.Lbl_MainScreenTitle.TabIndex = 0;
            this.Lbl_MainScreenTitle.Text = "Proquote to TigerPaw Utility";
            // 
            // Lbl_EnterQuoteNumber
            // 
            this.Lbl_EnterQuoteNumber.AutoSize = true;
            this.Lbl_EnterQuoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EnterQuoteNumber.Location = new System.Drawing.Point(15, 62);
            this.Lbl_EnterQuoteNumber.Name = "Lbl_EnterQuoteNumber";
            this.Lbl_EnterQuoteNumber.Size = new System.Drawing.Size(522, 26);
            this.Lbl_EnterQuoteNumber.TabIndex = 1;
            this.Lbl_EnterQuoteNumber.Text = "Please enter the quote number you wish to Transfer :";
            // 
            // Txt_QuoteNumberSupplied
            // 
            this.Txt_QuoteNumberSupplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QuoteNumberSupplied.Location = new System.Drawing.Point(543, 59);
            this.Txt_QuoteNumberSupplied.Name = "Txt_QuoteNumberSupplied";
            this.Txt_QuoteNumberSupplied.Size = new System.Drawing.Size(271, 32);
            this.Txt_QuoteNumberSupplied.TabIndex = 2;
            // 
            // Cmd_GetQuoteInformation
            // 
            this.Cmd_GetQuoteInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_GetQuoteInformation.Location = new System.Drawing.Point(820, 59);
            this.Cmd_GetQuoteInformation.Name = "Cmd_GetQuoteInformation";
            this.Cmd_GetQuoteInformation.Size = new System.Drawing.Size(121, 32);
            this.Cmd_GetQuoteInformation.TabIndex = 3;
            this.Cmd_GetQuoteInformation.Text = "Collect Information";
            this.Cmd_GetQuoteInformation.UseVisualStyleBackColor = true;
            this.Cmd_GetQuoteInformation.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Txt_Proquote_CustomerName
            // 
            this.Lbl_Txt_Proquote_CustomerName.AutoSize = true;
            this.Lbl_Txt_Proquote_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Txt_Proquote_CustomerName.Location = new System.Drawing.Point(6, 14);
            this.Lbl_Txt_Proquote_CustomerName.Name = "Lbl_Txt_Proquote_CustomerName";
            this.Lbl_Txt_Proquote_CustomerName.Size = new System.Drawing.Size(147, 24);
            this.Lbl_Txt_Proquote_CustomerName.TabIndex = 4;
            this.Lbl_Txt_Proquote_CustomerName.Text = "Customer Name";
            this.Lbl_Txt_Proquote_CustomerName.Click += new System.EventHandler(this.Lbl_CustomerName_Click);
            // 
            // Txt_Proquote_CustomerName
            // 
            this.Txt_Proquote_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proquote_CustomerName.Location = new System.Drawing.Point(159, 11);
            this.Txt_Proquote_CustomerName.Name = "Txt_Proquote_CustomerName";
            this.Txt_Proquote_CustomerName.ReadOnly = true;
            this.Txt_Proquote_CustomerName.Size = new System.Drawing.Size(431, 29);
            this.Txt_Proquote_CustomerName.TabIndex = 5;
            // 
            // Lbl_Proquote_BillTo
            // 
            this.Lbl_Proquote_BillTo.AutoSize = true;
            this.Lbl_Proquote_BillTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proquote_BillTo.Location = new System.Drawing.Point(22, 48);
            this.Lbl_Proquote_BillTo.Name = "Lbl_Proquote_BillTo";
            this.Lbl_Proquote_BillTo.Size = new System.Drawing.Size(72, 24);
            this.Lbl_Proquote_BillTo.TabIndex = 6;
            this.Lbl_Proquote_BillTo.Text = "Bill To :";
            // 
            // Txt_Proquote_BillTo
            // 
            this.Txt_Proquote_BillTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proquote_BillTo.Location = new System.Drawing.Point(22, 75);
            this.Txt_Proquote_BillTo.Multiline = true;
            this.Txt_Proquote_BillTo.Name = "Txt_Proquote_BillTo";
            this.Txt_Proquote_BillTo.ReadOnly = true;
            this.Txt_Proquote_BillTo.Size = new System.Drawing.Size(258, 127);
            this.Txt_Proquote_BillTo.TabIndex = 7;
            // 
            // Txt_Proquote_Shipto
            // 
            this.Txt_Proquote_Shipto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proquote_Shipto.Location = new System.Drawing.Point(286, 75);
            this.Txt_Proquote_Shipto.Multiline = true;
            this.Txt_Proquote_Shipto.Name = "Txt_Proquote_Shipto";
            this.Txt_Proquote_Shipto.ReadOnly = true;
            this.Txt_Proquote_Shipto.Size = new System.Drawing.Size(258, 127);
            this.Txt_Proquote_Shipto.TabIndex = 9;
            this.Txt_Proquote_Shipto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lbl_Proquote_ShipTo
            // 
            this.Lbl_Proquote_ShipTo.AutoSize = true;
            this.Lbl_Proquote_ShipTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proquote_ShipTo.Location = new System.Drawing.Point(286, 48);
            this.Lbl_Proquote_ShipTo.Name = "Lbl_Proquote_ShipTo";
            this.Lbl_Proquote_ShipTo.Size = new System.Drawing.Size(86, 24);
            this.Lbl_Proquote_ShipTo.TabIndex = 8;
            this.Lbl_Proquote_ShipTo.Text = "Ship To :";
            this.Lbl_Proquote_ShipTo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Proquote_Scope
            // 
            this.Txt_Proquote_Scope.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proquote_Scope.Location = new System.Drawing.Point(22, 242);
            this.Txt_Proquote_Scope.Multiline = true;
            this.Txt_Proquote_Scope.Name = "Txt_Proquote_Scope";
            this.Txt_Proquote_Scope.ReadOnly = true;
            this.Txt_Proquote_Scope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Proquote_Scope.Size = new System.Drawing.Size(901, 180);
            this.Txt_Proquote_Scope.TabIndex = 11;
            // 
            // Lbl_Proquote_Scope
            // 
            this.Lbl_Proquote_Scope.AutoSize = true;
            this.Lbl_Proquote_Scope.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proquote_Scope.Location = new System.Drawing.Point(25, 215);
            this.Lbl_Proquote_Scope.Name = "Lbl_Proquote_Scope";
            this.Lbl_Proquote_Scope.Size = new System.Drawing.Size(148, 24);
            this.Lbl_Proquote_Scope.TabIndex = 10;
            this.Lbl_Proquote_Scope.Text = "Scope Of Work :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 1199);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(934, 184);
            this.textBox2.TabIndex = 13;
            // 
            // Lbl_Proquote_BOM
            // 
            this.Lbl_Proquote_BOM.AutoSize = true;
            this.Lbl_Proquote_BOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proquote_BOM.Location = new System.Drawing.Point(16, 1172);
            this.Lbl_Proquote_BOM.Name = "Lbl_Proquote_BOM";
            this.Lbl_Proquote_BOM.Size = new System.Drawing.Size(133, 24);
            this.Lbl_Proquote_BOM.TabIndex = 12;
            this.Lbl_Proquote_BOM.Text = "Bill of Materials";
            // 
            // Tab_Proquote_Information
            // 
            this.Tab_Proquote_Information.Controls.Add(this.Tab_Proquote_Tab1_PQInfo);
            this.Tab_Proquote_Information.Controls.Add(this.Tab_Proquote_BOM);
            this.Tab_Proquote_Information.Controls.Add(this.Tab_Manpower_Ladders_1);
            this.Tab_Proquote_Information.Controls.Add(this.Tab_SpecialNotes);
            this.Tab_Proquote_Information.Controls.Add(this.Tab_Proquote_Information_Acceptance);
            this.Tab_Proquote_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Proquote_Information.Location = new System.Drawing.Point(12, 120);
            this.Tab_Proquote_Information.Name = "Tab_Proquote_Information";
            this.Tab_Proquote_Information.SelectedIndex = 0;
            this.Tab_Proquote_Information.Size = new System.Drawing.Size(945, 550);
            this.Tab_Proquote_Information.TabIndex = 14;
            // 
            // Tab_Proquote_Tab1_PQInfo
            // 
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Lbl_Proquote_ManHours);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.textBox3);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.label1);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.textBox1);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Cmd_CustomerInfo_Next);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Lbl_Txt_Proquote_CustomerName);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Lbl_Proquote_BillTo);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Txt_Proquote_BillTo);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Txt_Proquote_CustomerName);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Txt_Proquote_Scope);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Lbl_Proquote_ShipTo);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Txt_Proquote_Shipto);
            this.Tab_Proquote_Tab1_PQInfo.Controls.Add(this.Lbl_Proquote_Scope);
            this.Tab_Proquote_Tab1_PQInfo.Location = new System.Drawing.Point(4, 29);
            this.Tab_Proquote_Tab1_PQInfo.Name = "Tab_Proquote_Tab1_PQInfo";
            this.Tab_Proquote_Tab1_PQInfo.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Proquote_Tab1_PQInfo.Size = new System.Drawing.Size(937, 517);
            this.Tab_Proquote_Tab1_PQInfo.TabIndex = 0;
            this.Tab_Proquote_Tab1_PQInfo.Text = "Customer Info and Scope";
            this.Tab_Proquote_Tab1_PQInfo.UseVisualStyleBackColor = true;
            // 
            // Tab_Proquote_BOM
            // 
            this.Tab_Proquote_BOM.Controls.Add(this.comboBox1);
            this.Tab_Proquote_BOM.Controls.Add(this.Lbl_BOM_DeliveryInstructions);
            this.Tab_Proquote_BOM.Controls.Add(this.Cmd_BOM_BackButton);
            this.Tab_Proquote_BOM.Controls.Add(this.Cmd_BOM_NextButton);
            this.Tab_Proquote_BOM.Controls.Add(this.DataGrid_ProquoteBOM);
            this.Tab_Proquote_BOM.Controls.Add(this.Lbl_BillOfMaterials);
            this.Tab_Proquote_BOM.Location = new System.Drawing.Point(4, 29);
            this.Tab_Proquote_BOM.Name = "Tab_Proquote_BOM";
            this.Tab_Proquote_BOM.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Proquote_BOM.Size = new System.Drawing.Size(937, 517);
            this.Tab_Proquote_BOM.TabIndex = 1;
            this.Tab_Proquote_BOM.Text = "Bill Of Materials";
            this.Tab_Proquote_BOM.UseVisualStyleBackColor = true;
            // 
            // Tab_Manpower_Ladders_1
            // 
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox8);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox6);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox4);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox3);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox2);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.comboBox2);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.Lbl__AdditionalInformation_NOWARRANTY);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.Lbl_AdditionalInfo_TestResults);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.button1);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.button2);
            this.Tab_Manpower_Ladders_1.Controls.Add(this.groupBox1);
            this.Tab_Manpower_Ladders_1.Location = new System.Drawing.Point(4, 29);
            this.Tab_Manpower_Ladders_1.Name = "Tab_Manpower_Ladders_1";
            this.Tab_Manpower_Ladders_1.Size = new System.Drawing.Size(937, 517);
            this.Tab_Manpower_Ladders_1.TabIndex = 2;
            this.Tab_Manpower_Ladders_1.Text = "Manpower/Ladders";
            this.Tab_Manpower_Ladders_1.UseVisualStyleBackColor = true;
            // 
            // Tab_Proquote_Information_Acceptance
            // 
            this.Tab_Proquote_Information_Acceptance.Controls.Add(this.groupBox11);
            this.Tab_Proquote_Information_Acceptance.Controls.Add(this.groupBox9);
            this.Tab_Proquote_Information_Acceptance.Location = new System.Drawing.Point(4, 29);
            this.Tab_Proquote_Information_Acceptance.Name = "Tab_Proquote_Information_Acceptance";
            this.Tab_Proquote_Information_Acceptance.Size = new System.Drawing.Size(937, 517);
            this.Tab_Proquote_Information_Acceptance.TabIndex = 3;
            this.Tab_Proquote_Information_Acceptance.Text = "Confirmation";
            this.Tab_Proquote_Information_Acceptance.UseVisualStyleBackColor = true;
            // 
            // Cmd_CustomerInfo_Next
            // 
            this.Cmd_CustomerInfo_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_CustomerInfo_Next.Location = new System.Drawing.Point(802, 445);
            this.Cmd_CustomerInfo_Next.Name = "Cmd_CustomerInfo_Next";
            this.Cmd_CustomerInfo_Next.Size = new System.Drawing.Size(121, 32);
            this.Cmd_CustomerInfo_Next.TabIndex = 15;
            this.Cmd_CustomerInfo_Next.Text = "Next";
            this.Cmd_CustomerInfo_Next.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(665, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 29);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quote Total";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Lbl_Proquote_ManHours
            // 
            this.Lbl_Proquote_ManHours.AutoSize = true;
            this.Lbl_Proquote_ManHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proquote_ManHours.Location = new System.Drawing.Point(556, 142);
            this.Lbl_Proquote_ManHours.Name = "Lbl_Proquote_ManHours";
            this.Lbl_Proquote_ManHours.Size = new System.Drawing.Size(103, 24);
            this.Lbl_Proquote_ManHours.TabIndex = 18;
            this.Lbl_Proquote_ManHours.Text = "Man Hours";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(665, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(258, 29);
            this.textBox3.TabIndex = 19;
            // 
            // Lbl_BillOfMaterials
            // 
            this.Lbl_BillOfMaterials.AutoSize = true;
            this.Lbl_BillOfMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BillOfMaterials.Location = new System.Drawing.Point(6, 13);
            this.Lbl_BillOfMaterials.Name = "Lbl_BillOfMaterials";
            this.Lbl_BillOfMaterials.Size = new System.Drawing.Size(137, 24);
            this.Lbl_BillOfMaterials.TabIndex = 5;
            this.Lbl_BillOfMaterials.Text = "Bill Of Materials";
            // 
            // billOfMaterials
            // 
            this.billOfMaterials.DataSetName = "BillOfMaterials";
            this.billOfMaterials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spIdeaBOMBindingSource
            // 
            this.spIdeaBOMBindingSource.DataMember = "sp_Idea_BOM";
            this.spIdeaBOMBindingSource.DataSource = this.billOfMaterials;
            // 
            // sp_Idea_BOMTableAdapter
            // 
            this.sp_Idea_BOMTableAdapter.ClearBeforeFill = true;
            // 
            // DataGrid_ProquoteBOM
            // 
            this.DataGrid_ProquoteBOM.AutoGenerateColumns = false;
            this.DataGrid_ProquoteBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_ProquoteBOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.sectionorderDataGridViewTextBoxColumn,
            this.itemnumberDataGridViewTextBoxColumn,
            this.partNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn});
            this.DataGrid_ProquoteBOM.DataSource = this.spIdeaBOMBindingSource;
            this.DataGrid_ProquoteBOM.Location = new System.Drawing.Point(10, 40);
            this.DataGrid_ProquoteBOM.Name = "DataGrid_ProquoteBOM";
            this.DataGrid_ProquoteBOM.Size = new System.Drawing.Size(915, 319);
            this.DataGrid_ProquoteBOM.TabIndex = 6;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // sectionorderDataGridViewTextBoxColumn
            // 
            this.sectionorderDataGridViewTextBoxColumn.DataPropertyName = "sectionorder";
            this.sectionorderDataGridViewTextBoxColumn.HeaderText = "sectionorder";
            this.sectionorderDataGridViewTextBoxColumn.Name = "sectionorderDataGridViewTextBoxColumn";
            // 
            // itemnumberDataGridViewTextBoxColumn
            // 
            this.itemnumberDataGridViewTextBoxColumn.DataPropertyName = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.HeaderText = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.Name = "itemnumberDataGridViewTextBoxColumn";
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cmd_BOM_NextButton
            // 
            this.Cmd_BOM_NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_BOM_NextButton.Location = new System.Drawing.Point(804, 460);
            this.Cmd_BOM_NextButton.Name = "Cmd_BOM_NextButton";
            this.Cmd_BOM_NextButton.Size = new System.Drawing.Size(121, 32);
            this.Cmd_BOM_NextButton.TabIndex = 16;
            this.Cmd_BOM_NextButton.Text = "Next";
            this.Cmd_BOM_NextButton.UseVisualStyleBackColor = true;
            // 
            // Cmd_BOM_BackButton
            // 
            this.Cmd_BOM_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_BOM_BackButton.Location = new System.Drawing.Point(677, 460);
            this.Cmd_BOM_BackButton.Name = "Cmd_BOM_BackButton";
            this.Cmd_BOM_BackButton.Size = new System.Drawing.Size(121, 32);
            this.Cmd_BOM_BackButton.TabIndex = 17;
            this.Cmd_BOM_BackButton.Text = "Back";
            this.Cmd_BOM_BackButton.UseVisualStyleBackColor = true;
            // 
            // Lbl_BOM_DeliveryInstructions
            // 
            this.Lbl_BOM_DeliveryInstructions.AutoSize = true;
            this.Lbl_BOM_DeliveryInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BOM_DeliveryInstructions.Location = new System.Drawing.Point(18, 374);
            this.Lbl_BOM_DeliveryInstructions.Name = "Lbl_BOM_DeliveryInstructions";
            this.Lbl_BOM_DeliveryInstructions.Size = new System.Drawing.Size(246, 24);
            this.Lbl_BOM_DeliveryInstructions.TabIndex = 18;
            this.Lbl_BOM_DeliveryInstructions.Text = "Material Delivery Instructions";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Order & Hold For Delivery Instructions",
            "Do not order without seeing PM",
            "Supply Only- Ship Direct to Customer/ShipTo",
            "Other (Special Instructions)"});
            this.comboBox1.Location = new System.Drawing.Point(22, 402);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 32);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(677, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(804, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Lbl_AdditionalInfo_TestResults
            // 
            this.Lbl_AdditionalInfo_TestResults.AutoSize = true;
            this.Lbl_AdditionalInfo_TestResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AdditionalInfo_TestResults.Location = new System.Drawing.Point(15, 19);
            this.Lbl_AdditionalInfo_TestResults.Name = "Lbl_AdditionalInfo_TestResults";
            this.Lbl_AdditionalInfo_TestResults.Size = new System.Drawing.Size(112, 24);
            this.Lbl_AdditionalInfo_TestResults.TabIndex = 20;
            this.Lbl_AdditionalInfo_TestResults.Text = "Test Results";
            this.Lbl_AdditionalInfo_TestResults.Click += new System.EventHandler(this.Lbl_AdditionalInfo_TestResults_Click);
            // 
            // Lbl__AdditionalInformation_NOWARRANTY
            // 
            this.Lbl__AdditionalInformation_NOWARRANTY.AutoSize = true;
            this.Lbl__AdditionalInformation_NOWARRANTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl__AdditionalInformation_NOWARRANTY.ForeColor = System.Drawing.Color.Red;
            this.Lbl__AdditionalInformation_NOWARRANTY.Location = new System.Drawing.Point(555, 19);
            this.Lbl__AdditionalInformation_NOWARRANTY.Name = "Lbl__AdditionalInformation_NOWARRANTY";
            this.Lbl__AdditionalInformation_NOWARRANTY.Size = new System.Drawing.Size(238, 24);
            this.Lbl__AdditionalInformation_NOWARRANTY.TabIndex = 22;
            this.Lbl__AdditionalInformation_NOWARRANTY.Text = "NO VENDOR WARRANTY";
            // 
            // ChkBox_AdditionalInformation_AcceptNoVendorWarranty
            // 
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.AutoSize = true;
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.Location = new System.Drawing.Point(799, 15);
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.Name = "ChkBox_AdditionalInformation_AcceptNoVendorWarranty";
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.Size = new System.Drawing.Size(110, 28);
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.TabIndex = 23;
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.Text = "Accepted";
            this.ChkBox_AdditionalInformation_AcceptNoVendorWarranty.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Order & Hold For Delivery Instructions",
            "Do not order without seeing PM",
            "Supply Only- Ship Direct to Customer/ShipTo",
            "Other (Special Instructions)"});
            this.comboBox2.Location = new System.Drawing.Point(133, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(416, 32);
            this.comboBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Number of Techs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hours Per Tech";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "# of cable boxes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "8ft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "10ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "12ft";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Extension";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDown9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(32, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 160);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manpower Breakdown";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(187, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown1.TabIndex = 28;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(187, 55);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown2.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(325, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 160);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ladder Requirements";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(133, 20);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown3.TabIndex = 30;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(133, 52);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown4.TabIndex = 33;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(133, 84);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown5.TabIndex = 34;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.Location = new System.Drawing.Point(133, 116);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown6.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numericUpDown7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(582, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 160);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Material Requirements";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown7.Location = new System.Drawing.Point(221, 30);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown7.TabIndex = 36;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown8.Location = new System.Drawing.Point(221, 65);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown8.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Minimum Box Length (ft)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(32, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 210);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Photo Requirements";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 20);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 152);
            this.textBox4.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(94, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "All Standard Photos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown9.Location = new System.Drawing.Point(187, 90);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown9.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Unavailable Hours";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 27);
            this.label11.TabIndex = 32;
            this.label11.Text = "*Unavailable hours are hours that are not available for techs. Example PM Hours.";
            // 
            // Tab_SpecialNotes
            // 
            this.Tab_SpecialNotes.Controls.Add(this.groupBox10);
            this.Tab_SpecialNotes.Controls.Add(this.button3);
            this.Tab_SpecialNotes.Controls.Add(this.button4);
            this.Tab_SpecialNotes.Controls.Add(this.groupBox7);
            this.Tab_SpecialNotes.Controls.Add(this.groupBox5);
            this.Tab_SpecialNotes.Location = new System.Drawing.Point(4, 29);
            this.Tab_SpecialNotes.Name = "Tab_SpecialNotes";
            this.Tab_SpecialNotes.Size = new System.Drawing.Size(937, 517);
            this.Tab_SpecialNotes.TabIndex = 4;
            this.Tab_SpecialNotes.Text = "Special Notes/Deliverables";
            this.Tab_SpecialNotes.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Location = new System.Drawing.Point(13, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(925, 201);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Special Instructions";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Location = new System.Drawing.Point(307, 253);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(295, 210);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Protective Equipment/Certifications";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(157, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Full PPE Required";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(194, 24);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Site Safety Certification";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 68);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(172, 24);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Other Requirements";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 91);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 104);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(906, 170);
            this.textBox6.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox7);
            this.groupBox7.Controls.Add(this.checkBox6);
            this.groupBox7.Controls.Add(this.checkBox5);
            this.groupBox7.Location = new System.Drawing.Point(13, 219);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(912, 78);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Other Deliverable Requirements";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(20, 34);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(234, 28);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "CAD Drawings Required";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(274, 34);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(257, 28);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "Vendor Warranty Certificate";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(537, 34);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(195, 28);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Idea Warranty Letter";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.comboBox3);
            this.groupBox8.Location = new System.Drawing.Point(608, 253);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(301, 210);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Office Ownership";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Greta Shu",
            "Shane Johnson",
            "Monica Lipka",
            "Other Options from TigerPaw Reps"});
            this.comboBox3.Location = new System.Drawing.Point(6, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(257, 28);
            this.comboBox3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Preferred Inside Rep";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(677, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(804, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button5);
            this.groupBox9.Controls.Add(this.dateTimePicker1);
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(14, 370);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(911, 130);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Agreement";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Location = new System.Drawing.Point(13, 303);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(912, 149);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "File Attachments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Need to be able to attach files";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(859, 50);
            this.label14.TabIndex = 0;
            this.label14.Text = "I am opening this job, having checked all my information to the best of my abilit" +
    "y. I understand that operations will follow these instructions.";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Reps from TigerPaw",
            "Leonard Dea",
            "George Chapman",
            "Steve Duguay"});
            this.comboBox4.Location = new System.Drawing.Point(11, 70);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(282, 28);
            this.comboBox4.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(515, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 32);
            this.button5.TabIndex = 15;
            this.button5.Text = "Accept and Transfer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(251, 26);
            this.label15.TabIndex = 15;
            this.label15.Text = "Opportunity Information :";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dateTimePicker3);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.dateTimePicker2);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.comboBox6);
            this.groupBox11.Controls.Add(this.comboBox5);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Location = new System.Drawing.Point(25, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(888, 254);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "CRM Instructions";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Create New Opportunity and Attach Quote",
            "Add this quote to an existing opportunity",
            "Add Quote without opportunity (not recommended)"});
            this.comboBox5.Location = new System.Drawing.Point(264, 32);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(303, 28);
            this.comboBox5.TabIndex = 16;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "List of Existing Opportunities at Ship To Address"});
            this.comboBox6.Location = new System.Drawing.Point(593, 31);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(273, 28);
            this.comboBox6.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(84, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 26);
            this.label16.TabIndex = 18;
            this.label16.Text = "Follow Up Date :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(263, 117);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(229, 26);
            this.label17.TabIndex = 20;
            this.label17.Text = "Expected Close Date :";
            // 
            // Frm_HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 682);
            this.Controls.Add(this.Tab_Proquote_Information);
            this.Controls.Add(this.Cmd_GetQuoteInformation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Txt_QuoteNumberSupplied);
            this.Controls.Add(this.Lbl_EnterQuoteNumber);
            this.Controls.Add(this.Lbl_Proquote_BOM);
            this.Controls.Add(this.Lbl_MainScreenTitle);
            this.Name = "Frm_HomeScreen";
            this.Text = "ProQuote to TigerPaw v1";
            this.Tab_Proquote_Information.ResumeLayout(false);
            this.Tab_Proquote_Tab1_PQInfo.ResumeLayout(false);
            this.Tab_Proquote_Tab1_PQInfo.PerformLayout();
            this.Tab_Proquote_BOM.ResumeLayout(false);
            this.Tab_Proquote_BOM.PerformLayout();
            this.Tab_Manpower_Ladders_1.ResumeLayout(false);
            this.Tab_Manpower_Ladders_1.PerformLayout();
            this.Tab_Proquote_Information_Acceptance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billOfMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIdeaBOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ProquoteBOM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.Tab_SpecialNotes.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_MainScreenTitle;
        private System.Windows.Forms.Label Lbl_EnterQuoteNumber;
        private System.Windows.Forms.TextBox Txt_QuoteNumberSupplied;
        private System.Windows.Forms.Button Cmd_GetQuoteInformation;
        private System.Windows.Forms.Label Lbl_Txt_Proquote_CustomerName;
        private System.Windows.Forms.TextBox Txt_Proquote_CustomerName;
        private System.Windows.Forms.TextBox Txt_Proquote_Shipto;
        private System.Windows.Forms.Label Lbl_Proquote_ShipTo;
        private System.Windows.Forms.TextBox Txt_Proquote_BillTo;
        private System.Windows.Forms.Label Lbl_Proquote_BillTo;
        private System.Windows.Forms.TextBox Txt_Proquote_Scope;
        private System.Windows.Forms.Label Lbl_Proquote_Scope;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lbl_Proquote_BOM;
        private System.Windows.Forms.TabControl Tab_Proquote_Information;
        private System.Windows.Forms.TabPage Tab_Proquote_Tab1_PQInfo;
        private System.Windows.Forms.TabPage Tab_Proquote_BOM;
        private TextBox textBox1;
        private Button Cmd_CustomerInfo_Next;
        private TabPage Tab_Manpower_Ladders_1;
        private TabPage Tab_Proquote_Information_Acceptance;
        private Label Lbl_Proquote_ManHours;
        private TextBox textBox3;
        private Label label1;
        private Label Lbl_BillOfMaterials;
        private BindingSource spIdeaBOMBindingSource;
        private BillOfMaterials billOfMaterials;
        private BillOfMaterialsTableAdapters.sp_Idea_BOMTableAdapter sp_Idea_BOMTableAdapter;
        private ComboBox comboBox1;
        private Label Lbl_BOM_DeliveryInstructions;
        private Button Cmd_BOM_BackButton;
        private Button Cmd_BOM_NextButton;
        private DataGridView DataGrid_ProquoteBOM;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sectionorderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private Label Lbl_AdditionalInfo_TestResults;
        private Button button1;
        private Button button2;
        private GroupBox groupBox4;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown8;
        private Label label10;
        private NumericUpDown numericUpDown7;
        private Label label5;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label9;
        private Label label6;
        private Label label8;
        private Label label7;
        private ComboBox comboBox2;
        private CheckBox ChkBox_AdditionalInformation_AcceptNoVendorWarranty;
        private Label Lbl__AdditionalInformation_NOWARRANTY;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label label11;
        private NumericUpDown numericUpDown9;
        private Label label2;
        private TabPage Tab_SpecialNotes;
        private GroupBox groupBox8;
        private Label label12;
        private ComboBox comboBox3;
        private GroupBox groupBox6;
        private TextBox textBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private GroupBox groupBox10;
        private Label label13;
        private Button button3;
        private Button button4;
        private GroupBox groupBox7;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private GroupBox groupBox5;
        private TextBox textBox6;
        private GroupBox groupBox9;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox4;
        private Label label14;
        private GroupBox groupBox11;
        private DateTimePicker dateTimePicker3;
        private Label label17;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private Label label15;
    }
}

