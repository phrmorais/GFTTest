
namespace GFTTest.app
{
    partial class FrmMain
    {
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbValue = new DevExpress.XtraEditors.SpinEdit();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClientSector = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClientSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bdsTrade = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnalyze = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.pnlTopo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbValue.Properties)).BeginInit();
            this.flowLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientSector.Properties)).BeginInit();
            this.pnlTela.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.pnlTopo.Controls.Add(this.btnAnalyze);
            this.pnlTopo.Controls.Add(this.BtnAdd);
            this.pnlTopo.Controls.Add(this.flowLayoutPanel1);
            this.pnlTopo.Controls.Add(this.flowLayoutPanel14);
            this.pnlTopo.Controls.Add(this.panel1);
            this.pnlTopo.Controls.Add(this.lblUsuario);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(800, 90);
            this.pnlTopo.TabIndex = 18;
            this.pnlTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.pnlTopo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.pnlTopo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(376, 50);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cbValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 46);
            this.flowLayoutPanel1.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Value:";
            // 
            // cbValue
            // 
            this.cbValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cbValue.Location = new System.Drawing.Point(3, 16);
            this.cbValue.Name = "cbValue";
            this.cbValue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbValue.Properties.Appearance.Options.UseBackColor = true;
            this.cbValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbValue.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.cbValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cbValue.Properties.NullValuePrompt = "Selecione o resultado";
            this.cbValue.Size = new System.Drawing.Size(148, 20);
            this.cbValue.TabIndex = 127;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.label2);
            this.flowLayoutPanel14.Controls.Add(this.cmbClientSector);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(199, 37);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(171, 46);
            this.flowLayoutPanel14.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Client Sector:";
            // 
            // cmbClientSector
            // 
            this.cmbClientSector.EditValue = " ";
            this.cmbClientSector.Location = new System.Drawing.Point(3, 16);
            this.cmbClientSector.Name = "cmbClientSector";
            this.cmbClientSector.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbClientSector.Properties.Appearance.Options.UseBackColor = true;
            this.cmbClientSector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbClientSector.Properties.DropDownRows = 4;
            this.cmbClientSector.Properties.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.cmbClientSector.Properties.NullValuePrompt = "Selecione o resultado";
            this.cmbClientSector.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbClientSector.Size = new System.Drawing.Size(148, 20);
            this.cmbClientSector.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            this.lblUsuario.Location = new System.Drawing.Point(12, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(139, 15);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "OLÁ, SEJA BEM-VINDO.";
            // 
            // pnlTela
            // 
            this.pnlTela.Controls.Add(this.pnlGrid);
            this.pnlTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTela.Location = new System.Drawing.Point(0, 90);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(800, 338);
            this.pnlTela.TabIndex = 19;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.gridMain);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(800, 338);
            this.pnlGrid.TabIndex = 45;
            // 
            // gridMain
            // 
            this.gridMain.DataSource = this.bdsTrade;
            this.gridMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMain.Location = new System.Drawing.Point(-1, -2);
            this.gridMain.MainView = this.gridView1;
            this.gridMain.Name = "gridMain";
            this.gridMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox1});
            this.gridMain.Size = new System.Drawing.Size(800, 284);
            this.gridMain.TabIndex = 43;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Value,
            this.ClientSector});
            this.gridView1.GridControl = this.gridMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Value
            // 
            this.Value.Caption = "Value";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 0;
            // 
            // ClientSector
            // 
            this.ClientSector.Caption = "Client Sector";
            this.ClientSector.FieldName = "ClientSector";
            this.ClientSector.Name = "ClientSector";
            this.ClientSector.Visible = true;
            this.ClientSector.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 1);
            this.panel3.TabIndex = 9;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(457, 50);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 140;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(713, 14);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 141;
            this.BtnClear.Text = "Clear trades";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GFTTest";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbValue.Properties)).EndInit();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientSector.Properties)).EndInit();
            this.pnlTela.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGrid;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ClientSector;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit cbValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClientSector;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private System.Windows.Forms.BindingSource bdsTrade;
        private DevExpress.XtraEditors.SimpleButton btnAnalyze;
        private DevExpress.XtraEditors.SimpleButton BtnClear;
    }
}

