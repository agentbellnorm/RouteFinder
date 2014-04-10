namespace Dijkstra_Full
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addRouteToList = new System.Windows.Forms.ComboBox();
            this.addRouteFromList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.addJourneyCost_Box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addCityName_Box = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectionsList = new System.Windows.Forms.ListBox();
            this.cityList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateRouteToList = new System.Windows.Forms.ComboBox();
            this.calculateRouteFromList = new System.Windows.Forms.ComboBox();
            this.nodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadButton = new System.Windows.Forms.Button();
            this.createNewMapbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.totTimeLabel = new System.Windows.Forms.Label();
            this.graphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createNewMapbtn);
            this.tabPage1.Controls.Add(this.loadButton);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add To Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addRouteToList);
            this.groupBox2.Controls.Add(this.addRouteFromList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addRouteButton);
            this.groupBox2.Controls.Add(this.addJourneyCost_Box);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Route";
            // 
            // addRouteToList
            // 
            this.addRouteToList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addRouteToList.FormattingEnabled = true;
            this.addRouteToList.Location = new System.Drawing.Point(81, 67);
            this.addRouteToList.Name = "addRouteToList";
            this.addRouteToList.Size = new System.Drawing.Size(100, 21);
            this.addRouteToList.TabIndex = 8;
            // 
            // addRouteFromList
            // 
            this.addRouteFromList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addRouteFromList.FormattingEnabled = true;
            this.addRouteFromList.Location = new System.Drawing.Point(81, 41);
            this.addRouteFromList.Name = "addRouteFromList";
            this.addRouteFromList.Size = new System.Drawing.Size(100, 21);
            this.addRouteFromList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // addRouteButton
            // 
            this.addRouteButton.Location = new System.Drawing.Point(106, 119);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(75, 23);
            this.addRouteButton.TabIndex = 3;
            this.addRouteButton.Text = "Add Route";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // addJourneyCost_Box
            // 
            this.addJourneyCost_Box.Location = new System.Drawing.Point(81, 93);
            this.addJourneyCost_Box.Name = "addJourneyCost_Box";
            this.addJourneyCost_Box.Size = new System.Drawing.Size(100, 20);
            this.addJourneyCost_Box.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddCityButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addCityName_Box);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City";
            // 
            // AddCityButton
            // 
            this.AddCityButton.Location = new System.Drawing.Point(106, 55);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(75, 23);
            this.AddCityButton.TabIndex = 2;
            this.AddCityButton.Text = "Add City";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addCityName_Box
            // 
            this.addCityName_Box.Location = new System.Drawing.Point(81, 29);
            this.addCityName_Box.Name = "addCityName_Box";
            this.addCityName_Box.Size = new System.Drawing.Size(100, 20);
            this.addCityName_Box.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.connectionsList);
            this.tabPage2.Controls.Add(this.cityList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Connections";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "City";
            // 
            // connectionsList
            // 
            this.connectionsList.FormattingEnabled = true;
            this.connectionsList.Location = new System.Drawing.Point(127, 20);
            this.connectionsList.Name = "connectionsList";
            this.connectionsList.Size = new System.Drawing.Size(115, 264);
            this.connectionsList.TabIndex = 0;
            // 
            // cityList
            // 
            this.cityList.FormattingEnabled = true;
            this.cityList.Location = new System.Drawing.Point(6, 20);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(115, 264);
            this.cityList.TabIndex = 0;
            this.cityList.SelectedIndexChanged += new System.EventHandler(this.cityList_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.totTimeLabel);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.resultLabel);
            this.tabPage3.Controls.Add(this.calculateButton);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.calculateRouteToList);
            this.tabPage3.Controls.Add(this.calculateRouteFromList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(248, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calculate Route";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 148);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(128, 112);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Go";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Calculate the fastest route from";
            // 
            // calculateRouteToList
            // 
            this.calculateRouteToList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculateRouteToList.FormattingEnabled = true;
            this.calculateRouteToList.Location = new System.Drawing.Point(53, 85);
            this.calculateRouteToList.Name = "calculateRouteToList";
            this.calculateRouteToList.Size = new System.Drawing.Size(150, 21);
            this.calculateRouteToList.TabIndex = 1;
            // 
            // calculateRouteFromList
            // 
            this.calculateRouteFromList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculateRouteFromList.FormattingEnabled = true;
            this.calculateRouteFromList.Location = new System.Drawing.Point(53, 45);
            this.calculateRouteFromList.Name = "calculateRouteFromList";
            this.calculateRouteFromList.Size = new System.Drawing.Size(150, 21);
            this.calculateRouteFromList.TabIndex = 0;
            // 
            // nodesBindingSource
            // 
            this.nodesBindingSource.DataMember = "Nodes";
            this.nodesBindingSource.DataSource = this.graphBindingSource;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(276, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(130, 306);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load Map";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // createNewMapbtn
            // 
            this.createNewMapbtn.Location = new System.Drawing.Point(16, 306);
            this.createNewMapbtn.Name = "createNewMapbtn";
            this.createNewMapbtn.Size = new System.Drawing.Size(99, 23);
            this.createNewMapbtn.TabIndex = 5;
            this.createNewMapbtn.Text = "Create New Map";
            this.createNewMapbtn.UseVisualStyleBackColor = true;
            this.createNewMapbtn.Click += new System.EventHandler(this.createNewMapbtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(9, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(109, 132);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // totTimeLabel
            // 
            this.totTimeLabel.AutoSize = true;
            this.totTimeLabel.Location = new System.Drawing.Point(6, 323);
            this.totTimeLabel.Name = "totTimeLabel";
            this.totTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.totTimeLabel.TabIndex = 7;
            // 
            // graphBindingSource
            // 
            this.graphBindingSource.DataSource = typeof(Dijkstra_Full.Graph);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Route Finder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addJourneyCost_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addCityName_Box;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRouteButton;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox connectionsList;
        private System.Windows.Forms.ListBox cityList;
        private System.Windows.Forms.ComboBox addRouteToList;
        private System.Windows.Forms.ComboBox addRouteFromList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox calculateRouteToList;
        private System.Windows.Forms.ComboBox calculateRouteFromList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.BindingSource nodesBindingSource;
        private System.Windows.Forms.BindingSource graphBindingSource;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button createNewMapbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label totTimeLabel;
    }
}

