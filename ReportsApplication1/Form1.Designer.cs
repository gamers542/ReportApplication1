//------------------------------------------------------------------
// <copyright company="Microsoft">
//     Copyright (c) Microsoft.  All rights reserved.
// </copyright>
//------------------------------------------------------------------
namespace ReportsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GamesPlayedDataSet = new ReportsApplication1.GamesPlayedDataSet();
            this.AllGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllGamesTableAdapter = new ReportsApplication1.GamesPlayedDataSetTableAdapters.AllGamesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GamesPlayedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // GamesPlayedDataSet
            // 
            this.GamesPlayedDataSet.DataSetName = "GamesPlayedDataSet";
            this.GamesPlayedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllGamesBindingSource
            // 
            this.AllGamesBindingSource.DataMember = "AllGames";
            this.AllGamesBindingSource.DataSource = this.GamesPlayedDataSet;
            // 
            // AllGamesTableAdapter
            // 
            this.AllGamesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GamesPlayedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllGamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AllGamesBindingSource;
        private GamesPlayedDataSet GamesPlayedDataSet;
        private GamesPlayedDataSetTableAdapters.AllGamesTableAdapter AllGamesTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

