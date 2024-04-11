namespace W7
{
    partial class FormNewCountry
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.tbName.Location = new System.Drawing.Point(84, 77);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(234, 31);
            this.tbName.TabIndex = 0;
            // 
            // tbPopulation
            // 
            this.tbPopulation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Population", true));
            this.tbPopulation.Location = new System.Drawing.Point(84, 139);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(234, 31);
            this.tbPopulation.TabIndex = 1;
            // 
            // tbArea
            // 
            this.tbArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AreaInSquareKm", true));
            this.tbArea.Location = new System.Drawing.Point(84, 201);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(234, 31);
            this.tbArea.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(84, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Country Name:";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(84, 111);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(101, 25);
            this.labelPopulation.TabIndex = 4;
            this.labelPopulation.Text = "Population:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(84, 173);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(108, 25);
            this.labelArea.TabIndex = 5;
            this.labelArea.Text = "Area in km²:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(206, 262);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 34);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(W7.CountryData);
            // 
            // FormNewCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbPopulation);
            this.Controls.Add(this.tbName);
            this.Name = "FormNewCountry";
            this.Text = "FormNewCountry";
            this.Load += new System.EventHandler(this.FormNewCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private TextBox tbPopulation;
        private TextBox tbArea;
        private Label labelName;
        private Label labelPopulation;
        private Label labelArea;
        private Button btnOk;
        private BindingSource bindingSource1;
    }
}