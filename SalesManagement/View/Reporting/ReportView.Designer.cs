namespace View
{
    partial class ReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsMain = new View.DsMain();
            this.preporte_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preporte_facturaTableAdapter = new View.DsMainTableAdapters.preporte_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preporte_facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.preporte_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View.Reporting.InvoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsMain
            // 
            this.DsMain.DataSetName = "DsMain";
            this.DsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preporte_facturaBindingSource
            // 
            this.preporte_facturaBindingSource.DataMember = "preporte_factura";
            this.preporte_facturaBindingSource.DataSource = this.DsMain;
            // 
            // preporte_facturaTableAdapter
            // 
            this.preporte_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 498);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportView";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preporte_facturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource preporte_facturaBindingSource;
        private DsMain DsMain;
        private DsMainTableAdapters.preporte_facturaTableAdapter preporte_facturaTableAdapter;
    }
}