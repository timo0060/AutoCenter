namespace AutoCenter
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab = new System.Windows.Forms.TabControl();
            this.BaseCostTab = new System.Windows.Forms.TabPage();
            this.AppearanceTab = new System.Windows.Forms.TabPage();
            this.AppearanceCalculateButton = new System.Windows.Forms.Button();
            this.OtherGroupBox = new System.Windows.Forms.GroupBox();
            this.SunroofCheckBox = new System.Windows.Forms.CheckBox();
            this.TintCheckBox = new System.Windows.Forms.CheckBox();
            this.RimGroupBox = new System.Windows.Forms.GroupBox();
            this.TwentyOneAeroRadioButton = new System.Windows.Forms.RadioButton();
            this.TwentyOneRadioButton = new System.Windows.Forms.RadioButton();
            this.NineTeenAeroRadioButton = new System.Windows.Forms.RadioButton();
            this.NineTeenRadioButton = new System.Windows.Forms.RadioButton();
            this.ColourGroupBox = new System.Windows.Forms.GroupBox();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.WhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.AddOnTab = new System.Windows.Forms.TabPage();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalCalculateButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppearanceTotalTextBox = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.Tab.SuspendLayout();
            this.AppearanceTab.SuspendLayout();
            this.OtherGroupBox.SuspendLayout();
            this.RimGroupBox.SuspendLayout();
            this.ColourGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(471, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 24);
            this.FileMenu.Text = "File";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitMenu.Size = new System.Drawing.Size(152, 24);
            this.ExitMenu.Text = "Exit";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.BaseCostTab);
            this.Tab.Controls.Add(this.AppearanceTab);
            this.Tab.Controls.Add(this.AddOnTab);
            this.Tab.Location = new System.Drawing.Point(12, 177);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(309, 395);
            this.Tab.TabIndex = 1;
            // 
            // BaseCostTab
            // 
            this.BaseCostTab.Location = new System.Drawing.Point(4, 25);
            this.BaseCostTab.Name = "BaseCostTab";
            this.BaseCostTab.Padding = new System.Windows.Forms.Padding(3);
            this.BaseCostTab.Size = new System.Drawing.Size(301, 366);
            this.BaseCostTab.TabIndex = 0;
            this.BaseCostTab.Text = "Base Cost";
            this.BaseCostTab.UseVisualStyleBackColor = true;
            // 
            // AppearanceTab
            // 
            this.AppearanceTab.Controls.Add(this.AppearanceTotalTextBox);
            this.AppearanceTab.Controls.Add(this.label1);
            this.AppearanceTab.Controls.Add(this.AppearanceCalculateButton);
            this.AppearanceTab.Controls.Add(this.OtherGroupBox);
            this.AppearanceTab.Controls.Add(this.RimGroupBox);
            this.AppearanceTab.Controls.Add(this.ColourGroupBox);
            this.AppearanceTab.Location = new System.Drawing.Point(4, 25);
            this.AppearanceTab.Name = "AppearanceTab";
            this.AppearanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppearanceTab.Size = new System.Drawing.Size(301, 366);
            this.AppearanceTab.TabIndex = 1;
            this.AppearanceTab.Text = "Appearance";
            this.AppearanceTab.UseVisualStyleBackColor = true;
            // 
            // AppearanceCalculateButton
            // 
            this.AppearanceCalculateButton.Location = new System.Drawing.Point(89, 275);
            this.AppearanceCalculateButton.Name = "AppearanceCalculateButton";
            this.AppearanceCalculateButton.Size = new System.Drawing.Size(78, 28);
            this.AppearanceCalculateButton.TabIndex = 6;
            this.AppearanceCalculateButton.Text = "Calculate";
            this.AppearanceCalculateButton.UseVisualStyleBackColor = true;
            this.AppearanceCalculateButton.Click += new System.EventHandler(this.AppearenceCalculateButton_Click);
            // 
            // OtherGroupBox
            // 
            this.OtherGroupBox.Controls.Add(this.SunroofCheckBox);
            this.OtherGroupBox.Controls.Add(this.TintCheckBox);
            this.OtherGroupBox.Location = new System.Drawing.Point(147, 154);
            this.OtherGroupBox.Name = "OtherGroupBox";
            this.OtherGroupBox.Size = new System.Drawing.Size(135, 100);
            this.OtherGroupBox.TabIndex = 5;
            this.OtherGroupBox.TabStop = false;
            this.OtherGroupBox.Text = "Other";
            // 
            // SunroofCheckBox
            // 
            this.SunroofCheckBox.AutoSize = true;
            this.SunroofCheckBox.Location = new System.Drawing.Point(7, 50);
            this.SunroofCheckBox.Name = "SunroofCheckBox";
            this.SunroofCheckBox.Size = new System.Drawing.Size(126, 21);
            this.SunroofCheckBox.TabIndex = 1;
            this.SunroofCheckBox.Text = "Sunroof (+450)";
            this.SunroofCheckBox.UseVisualStyleBackColor = true;
            // 
            // TintCheckBox
            // 
            this.TintCheckBox.AutoCheck = false;
            this.TintCheckBox.AutoSize = true;
            this.TintCheckBox.Location = new System.Drawing.Point(7, 22);
            this.TintCheckBox.Name = "TintCheckBox";
            this.TintCheckBox.Size = new System.Drawing.Size(100, 21);
            this.TintCheckBox.TabIndex = 0;
            this.TintCheckBox.Text = "Tint (+400)";
            this.TintCheckBox.UseVisualStyleBackColor = true;
            // 
            // RimGroupBox
            // 
            this.RimGroupBox.Controls.Add(this.TwentyOneAeroRadioButton);
            this.RimGroupBox.Controls.Add(this.TwentyOneRadioButton);
            this.RimGroupBox.Controls.Add(this.NineTeenAeroRadioButton);
            this.RimGroupBox.Controls.Add(this.NineTeenRadioButton);
            this.RimGroupBox.Location = new System.Drawing.Point(147, 20);
            this.RimGroupBox.Name = "RimGroupBox";
            this.RimGroupBox.Size = new System.Drawing.Size(138, 127);
            this.RimGroupBox.TabIndex = 4;
            this.RimGroupBox.TabStop = false;
            this.RimGroupBox.Text = "Rims";
            // 
            // TwentyOneAeroRadioButton
            // 
            this.TwentyOneAeroRadioButton.AutoSize = true;
            this.TwentyOneAeroRadioButton.Location = new System.Drawing.Point(7, 104);
            this.TwentyOneAeroRadioButton.Name = "TwentyOneAeroRadioButton";
            this.TwentyOneAeroRadioButton.Size = new System.Drawing.Size(130, 21);
            this.TwentyOneAeroRadioButton.TabIndex = 3;
            this.TwentyOneAeroRadioButton.TabStop = true;
            this.TwentyOneAeroRadioButton.Text = "21\" Aero (+300)";
            this.TwentyOneAeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwentyOneRadioButton
            // 
            this.TwentyOneRadioButton.AutoSize = true;
            this.TwentyOneRadioButton.Location = new System.Drawing.Point(7, 77);
            this.TwentyOneRadioButton.Name = "TwentyOneRadioButton";
            this.TwentyOneRadioButton.Size = new System.Drawing.Size(96, 21);
            this.TwentyOneRadioButton.TabIndex = 2;
            this.TwentyOneRadioButton.TabStop = true;
            this.TwentyOneRadioButton.Text = "21\" (+250)";
            this.TwentyOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // NineTeenAeroRadioButton
            // 
            this.NineTeenAeroRadioButton.AutoSize = true;
            this.NineTeenAeroRadioButton.Location = new System.Drawing.Point(7, 50);
            this.NineTeenAeroRadioButton.Name = "NineTeenAeroRadioButton";
            this.NineTeenAeroRadioButton.Size = new System.Drawing.Size(130, 21);
            this.NineTeenAeroRadioButton.TabIndex = 1;
            this.NineTeenAeroRadioButton.Text = "19\" Aero (+100)";
            this.NineTeenAeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // NineTeenRadioButton
            // 
            this.NineTeenRadioButton.AutoSize = true;
            this.NineTeenRadioButton.Checked = true;
            this.NineTeenRadioButton.Location = new System.Drawing.Point(7, 22);
            this.NineTeenRadioButton.Name = "NineTeenRadioButton";
            this.NineTeenRadioButton.Size = new System.Drawing.Size(50, 21);
            this.NineTeenRadioButton.TabIndex = 0;
            this.NineTeenRadioButton.TabStop = true;
            this.NineTeenRadioButton.Text = "19\"";
            this.NineTeenRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColourGroupBox
            // 
            this.ColourGroupBox.Controls.Add(this.RedRadioButton);
            this.ColourGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColourGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColourGroupBox.Controls.Add(this.BlackRadioButton);
            this.ColourGroupBox.Controls.Add(this.WhiteRadioButton);
            this.ColourGroupBox.Location = new System.Drawing.Point(9, 20);
            this.ColourGroupBox.Name = "ColourGroupBox";
            this.ColourGroupBox.Size = new System.Drawing.Size(123, 163);
            this.ColourGroupBox.TabIndex = 3;
            this.ColourGroupBox.TabStop = false;
            this.ColourGroupBox.Text = "Colour";
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(7, 134);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(101, 21);
            this.RedRadioButton.TabIndex = 4;
            this.RedRadioButton.TabStop = true;
            this.RedRadioButton.Text = "Red (+200)";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(7, 106);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(103, 21);
            this.BlueRadioButton.TabIndex = 3;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Blue (+150)";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(7, 78);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(115, 21);
            this.GreenRadioButton.TabIndex = 2;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Green (+100)";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(7, 50);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(63, 21);
            this.BlackRadioButton.TabIndex = 1;
            this.BlackRadioButton.TabStop = true;
            this.BlackRadioButton.Text = "Black";
            this.BlackRadioButton.UseVisualStyleBackColor = true;
            // 
            // WhiteRadioButton
            // 
            this.WhiteRadioButton.AutoSize = true;
            this.WhiteRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.WhiteRadioButton.Checked = true;
            this.WhiteRadioButton.Location = new System.Drawing.Point(7, 22);
            this.WhiteRadioButton.Name = "WhiteRadioButton";
            this.WhiteRadioButton.Size = new System.Drawing.Size(65, 21);
            this.WhiteRadioButton.TabIndex = 0;
            this.WhiteRadioButton.TabStop = true;
            this.WhiteRadioButton.Text = "White";
            this.WhiteRadioButton.UseVisualStyleBackColor = false;
            // 
            // AddOnTab
            // 
            this.AddOnTab.Location = new System.Drawing.Point(4, 25);
            this.AddOnTab.Name = "AddOnTab";
            this.AddOnTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddOnTab.Size = new System.Drawing.Size(301, 366);
            this.AddOnTab.TabIndex = 2;
            this.AddOnTab.Text = "AddOn";
            this.AddOnTab.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::AutoCenter.Properties.Resources.Sun_LockDown_Logo_100_x_100_Red;
            this.Logo.Location = new System.Drawing.Point(12, 50);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(103, 103);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(366, 202);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(70, 17);
            this.SalesTaxLabel.TabIndex = 3;
            this.SalesTaxLabel.Text = "Sales Tax";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(379, 222);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(47, 22);
            this.SalesTaxTextBox.TabIndex = 4;
            this.SalesTaxTextBox.Text = "0.0%";
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalCalculateButton
            // 
            this.TotalCalculateButton.Location = new System.Drawing.Point(357, 298);
            this.TotalCalculateButton.Name = "TotalCalculateButton";
            this.TotalCalculateButton.Size = new System.Drawing.Size(102, 50);
            this.TotalCalculateButton.TabIndex = 5;
            this.TotalCalculateButton.Text = "Calculate Total";
            this.TotalCalculateButton.UseVisualStyleBackColor = true;
            this.TotalCalculateButton.Click += new System.EventHandler(this.TotalCalculateButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(386, 368);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(357, 388);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 7;
            this.TotalTextBox.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Appearance Cost Total:";
            // 
            // AppearanceTotalTextBox
            // 
            this.AppearanceTotalTextBox.Location = new System.Drawing.Point(167, 326);
            this.AppearanceTotalTextBox.Name = "AppearanceTotalTextBox";
            this.AppearanceTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.AppearanceTotalTextBox.TabIndex = 8;
            this.AppearanceTotalTextBox.Text = "$0.00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(471, 584);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalCalculateButton);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp\'s Auto Center";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.AppearanceTab.ResumeLayout(false);
            this.AppearanceTab.PerformLayout();
            this.OtherGroupBox.ResumeLayout(false);
            this.OtherGroupBox.PerformLayout();
            this.RimGroupBox.ResumeLayout(false);
            this.RimGroupBox.PerformLayout();
            this.ColourGroupBox.ResumeLayout(false);
            this.ColourGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /*private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TextBox TradeInTextBox;
        private System.Windows.Forms.TextBox BaseCostTextBox;
        private System.Windows.Forms.Label TradeInLabel;
        private System.Windows.Forms.Button BaseCalculateButton;
        private System.Windows.Forms.TextBox baseCostTotalTextBox;
        private System.Windows.Forms.Label TotalBaseCostLabel;
        private System.Windows.Forms.GroupBox ColourGroupBox;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton BlackRadioButton;
        private System.Windows.Forms.RadioButton WhiteRadioButton;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Button TotalCalculateButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.GroupBox RimsGroupBox;
        private System.Windows.Forms.TextBox AppearanceTotalTextBox;
        private System.Windows.Forms.Label AppearanceTotalLabel;
        private System.Windows.Forms.RadioButton TwentyOneAeroRadioButton;
        private System.Windows.Forms.RadioButton TwentyOneRadioButton;
        private System.Windows.Forms.RadioButton NineTeenAeroRadioButton;
        private System.Windows.Forms.RadioButton NineTeenRadioButton;
        private System.Windows.Forms.Button AppearenceCalculateButton;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.CheckBox SunroofCheckBox;
        private System.Windows.Forms.CheckBox TintCheckBox;
        private System.Windows.Forms.GroupBox PackagesGroupBox;
        private System.Windows.Forms.CheckBox ComfortCheckBox;
        private System.Windows.Forms.CheckBox EntertainmentCheckBox;
        private System.Windows.Forms.CheckBox TechCheckBox; */
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage BaseCostTab;
        private System.Windows.Forms.TabPage AppearanceTab;
        private System.Windows.Forms.TabPage AddOnTab;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Button TotalCalculateButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button AppearanceCalculateButton;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.CheckBox SunroofCheckBox;
        private System.Windows.Forms.CheckBox TintCheckBox;
        private System.Windows.Forms.GroupBox RimGroupBox;
        private System.Windows.Forms.RadioButton TwentyOneAeroRadioButton;
        private System.Windows.Forms.RadioButton TwentyOneRadioButton;
        private System.Windows.Forms.RadioButton NineTeenAeroRadioButton;
        private System.Windows.Forms.RadioButton NineTeenRadioButton;
        private System.Windows.Forms.GroupBox ColourGroupBox;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton BlackRadioButton;
        private System.Windows.Forms.RadioButton WhiteRadioButton;
        private System.Windows.Forms.TextBox AppearanceTotalTextBox;
        private System.Windows.Forms.Label label1;
    }
}

