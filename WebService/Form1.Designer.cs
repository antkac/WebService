
namespace WebService
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
            this.nip_textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nip_Label = new MaterialSkin.Controls.MaterialLabel();
            this.run_Button = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_NIP_list_Button = new MaterialSkin.Controls.MaterialButton();
            this.multiple_NIP_textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.multi_run_Button = new MaterialSkin.Controls.MaterialButton();
            this.input_ListBox = new System.Windows.Forms.ListBox();
            this.multiple_results_TextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.results_Label = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_REGON_list_Button = new MaterialSkin.Controls.MaterialButton();
            this.multiple_REGON_textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.REGON_multiple_results_TextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.REGON_multi_run_Button = new MaterialSkin.Controls.MaterialButton();
            this.regon_results_Label = new MaterialSkin.Controls.MaterialLabel();
            this.REGON_run_Button = new MaterialSkin.Controls.MaterialButton();
            this.REGON_TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.REGON_Label = new MaterialSkin.Controls.MaterialLabel();
            this.REGON_input_ListBox = new System.Windows.Forms.ListBox();
            this.multiple_nips_Checkbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nip_textBox
            // 
            this.nip_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nip_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nip_textBox.Depth = 0;
            this.nip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nip_textBox.Hint = "NIP";
            this.nip_textBox.LeadingIcon = null;
            this.nip_textBox.Location = new System.Drawing.Point(40, 51);
            this.nip_textBox.MaxLength = 50;
            this.nip_textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nip_textBox.Multiline = false;
            this.nip_textBox.Name = "nip_textBox";
            this.nip_textBox.Size = new System.Drawing.Size(229, 50);
            this.nip_textBox.TabIndex = 0;
            this.nip_textBox.Text = "";
            this.nip_textBox.TrailingIcon = null;
            // 
            // nip_Label
            // 
            this.nip_Label.AutoSize = true;
            this.nip_Label.Depth = 0;
            this.nip_Label.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nip_Label.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.nip_Label.Location = new System.Drawing.Point(38, 22);
            this.nip_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.nip_Label.Name = "nip_Label";
            this.nip_Label.Size = new System.Drawing.Size(80, 17);
            this.nip_Label.TabIndex = 1;
            this.nip_Label.Text = "Enter Query:";
            // 
            // run_Button
            // 
            this.run_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.run_Button.BackColor = System.Drawing.Color.White;
            this.run_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.run_Button.Depth = 0;
            this.run_Button.DrawShadows = false;
            this.run_Button.HighEmphasis = true;
            this.run_Button.Icon = null;
            this.run_Button.Location = new System.Drawing.Point(40, 119);
            this.run_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.run_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.run_Button.Name = "run_Button";
            this.run_Button.Size = new System.Drawing.Size(78, 36);
            this.run_Button.TabIndex = 2;
            this.run_Button.Text = "Search";
            this.run_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.run_Button.UseAccentColor = true;
            this.run_Button.UseVisualStyleBackColor = false;
            this.run_Button.Click += new System.EventHandler(this.run_Button_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-7, 121);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1122, 491);
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add_NIP_list_Button);
            this.tabPage1.Controls.Add(this.multiple_NIP_textBox);
            this.tabPage1.Controls.Add(this.multi_run_Button);
            this.tabPage1.Controls.Add(this.nip_textBox);
            this.tabPage1.Controls.Add(this.run_Button);
            this.tabPage1.Controls.Add(this.nip_Label);
            this.tabPage1.Controls.Add(this.input_ListBox);
            this.tabPage1.Controls.Add(this.multiple_results_TextBox);
            this.tabPage1.Controls.Add(this.results_Label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NIP SEARCH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // add_NIP_list_Button
            // 
            this.add_NIP_list_Button.AutoSize = false;
            this.add_NIP_list_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_NIP_list_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_NIP_list_Button.Depth = 0;
            this.add_NIP_list_Button.DrawShadows = false;
            this.add_NIP_list_Button.HighEmphasis = true;
            this.add_NIP_list_Button.Icon = global::WebService.Properties.Resources.add_icon;
            this.add_NIP_list_Button.Location = new System.Drawing.Point(369, 190);
            this.add_NIP_list_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add_NIP_list_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_NIP_list_Button.Name = "add_NIP_list_Button";
            this.add_NIP_list_Button.Size = new System.Drawing.Size(40, 36);
            this.add_NIP_list_Button.TabIndex = 10;
            this.add_NIP_list_Button.Text = " ";
            this.add_NIP_list_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_NIP_list_Button.UseAccentColor = true;
            this.add_NIP_list_Button.UseVisualStyleBackColor = true;
            this.add_NIP_list_Button.Click += new System.EventHandler(this.add_NIP_list_Button_Click);
            // 
            // multiple_NIP_textBox
            // 
            this.multiple_NIP_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multiple_NIP_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.multiple_NIP_textBox.Depth = 0;
            this.multiple_NIP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiple_NIP_textBox.Hint = "NIP";
            this.multiple_NIP_textBox.LeadingIcon = null;
            this.multiple_NIP_textBox.Location = new System.Drawing.Point(18, 184);
            this.multiple_NIP_textBox.MaxLength = 50;
            this.multiple_NIP_textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.multiple_NIP_textBox.Multiline = false;
            this.multiple_NIP_textBox.Name = "multiple_NIP_textBox";
            this.multiple_NIP_textBox.Size = new System.Drawing.Size(291, 50);
            this.multiple_NIP_textBox.TabIndex = 8;
            this.multiple_NIP_textBox.Text = "";
            this.multiple_NIP_textBox.TrailingIcon = null;
            // 
            // multi_run_Button
            // 
            this.multi_run_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multi_run_Button.BackColor = System.Drawing.Color.White;
            this.multi_run_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.multi_run_Button.Depth = 0;
            this.multi_run_Button.DrawShadows = false;
            this.multi_run_Button.HighEmphasis = true;
            this.multi_run_Button.Icon = null;
            this.multi_run_Button.Location = new System.Drawing.Point(40, 416);
            this.multi_run_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.multi_run_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.multi_run_Button.Name = "multi_run_Button";
            this.multi_run_Button.Size = new System.Drawing.Size(78, 36);
            this.multi_run_Button.TabIndex = 5;
            this.multi_run_Button.Text = "Search";
            this.multi_run_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.multi_run_Button.UseAccentColor = true;
            this.multi_run_Button.UseVisualStyleBackColor = false;
            this.multi_run_Button.Click += new System.EventHandler(this.multi_run_Button_Click);
            // 
            // input_ListBox
            // 
            this.input_ListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.input_ListBox.FormattingEnabled = true;
            this.input_ListBox.Location = new System.Drawing.Point(18, 6);
            this.input_ListBox.Name = "input_ListBox";
            this.input_ListBox.Size = new System.Drawing.Size(415, 160);
            this.input_ListBox.TabIndex = 11;
            this.input_ListBox.SelectedIndexChanged += new System.EventHandler(this.input_ListBox_SelectedIndexChanged);
            // 
            // multiple_results_TextBox
            // 
            this.multiple_results_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multiple_results_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multiple_results_TextBox.Depth = 0;
            this.multiple_results_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiple_results_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multiple_results_TextBox.Location = new System.Drawing.Point(450, 3);
            this.multiple_results_TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiple_results_TextBox.Name = "multiple_results_TextBox";
            this.multiple_results_TextBox.ReadOnly = true;
            this.multiple_results_TextBox.Size = new System.Drawing.Size(639, 449);
            this.multiple_results_TextBox.TabIndex = 12;
            this.multiple_results_TextBox.Text = "";
            // 
            // results_Label
            // 
            this.results_Label.Depth = 0;
            this.results_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.results_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.results_Label.Location = new System.Drawing.Point(454, 3);
            this.results_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.results_Label.Name = "results_Label";
            this.results_Label.Size = new System.Drawing.Size(635, 449);
            this.results_Label.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.REGON_multiple_results_TextBox);
            this.tabPage2.Controls.Add(this.add_REGON_list_Button);
            this.tabPage2.Controls.Add(this.multiple_REGON_textBox);
            this.tabPage2.Controls.Add(this.REGON_multi_run_Button);
            this.tabPage2.Controls.Add(this.regon_results_Label);
            this.tabPage2.Controls.Add(this.REGON_run_Button);
            this.tabPage2.Controls.Add(this.REGON_TextBox);
            this.tabPage2.Controls.Add(this.REGON_Label);
            this.tabPage2.Controls.Add(this.REGON_input_ListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REGON SEARCH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_REGON_list_Button
            // 
            this.add_REGON_list_Button.AutoSize = false;
            this.add_REGON_list_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_REGON_list_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_REGON_list_Button.Depth = 0;
            this.add_REGON_list_Button.DrawShadows = false;
            this.add_REGON_list_Button.HighEmphasis = true;
            this.add_REGON_list_Button.Icon = global::WebService.Properties.Resources.add_icon;
            this.add_REGON_list_Button.Location = new System.Drawing.Point(369, 190);
            this.add_REGON_list_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add_REGON_list_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_REGON_list_Button.Name = "add_REGON_list_Button";
            this.add_REGON_list_Button.Size = new System.Drawing.Size(40, 36);
            this.add_REGON_list_Button.TabIndex = 15;
            this.add_REGON_list_Button.Text = " ";
            this.add_REGON_list_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_REGON_list_Button.UseAccentColor = true;
            this.add_REGON_list_Button.UseVisualStyleBackColor = true;
            this.add_REGON_list_Button.Click += new System.EventHandler(this.add_REGON_list_Button_Click);
            // 
            // multiple_REGON_textBox
            // 
            this.multiple_REGON_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multiple_REGON_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.multiple_REGON_textBox.Depth = 0;
            this.multiple_REGON_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiple_REGON_textBox.Hint = "REGON";
            this.multiple_REGON_textBox.LeadingIcon = null;
            this.multiple_REGON_textBox.Location = new System.Drawing.Point(18, 184);
            this.multiple_REGON_textBox.MaxLength = 50;
            this.multiple_REGON_textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.multiple_REGON_textBox.Multiline = false;
            this.multiple_REGON_textBox.Name = "multiple_REGON_textBox";
            this.multiple_REGON_textBox.Size = new System.Drawing.Size(291, 50);
            this.multiple_REGON_textBox.TabIndex = 14;
            this.multiple_REGON_textBox.Text = "";
            this.multiple_REGON_textBox.TrailingIcon = null;
            // 
            // REGON_multiple_results_TextBox
            // 
            this.REGON_multiple_results_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.REGON_multiple_results_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REGON_multiple_results_TextBox.Depth = 0;
            this.REGON_multiple_results_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.REGON_multiple_results_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.REGON_multiple_results_TextBox.Location = new System.Drawing.Point(450, 3);
            this.REGON_multiple_results_TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.REGON_multiple_results_TextBox.Name = "REGON_multiple_results_TextBox";
            this.REGON_multiple_results_TextBox.ReadOnly = true;
            this.REGON_multiple_results_TextBox.Size = new System.Drawing.Size(639, 449);
            this.REGON_multiple_results_TextBox.TabIndex = 13;
            this.REGON_multiple_results_TextBox.Text = "";
            // 
            // REGON_multi_run_Button
            // 
            this.REGON_multi_run_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.REGON_multi_run_Button.BackColor = System.Drawing.Color.White;
            this.REGON_multi_run_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.REGON_multi_run_Button.Depth = 0;
            this.REGON_multi_run_Button.DrawShadows = false;
            this.REGON_multi_run_Button.HighEmphasis = true;
            this.REGON_multi_run_Button.Icon = null;
            this.REGON_multi_run_Button.Location = new System.Drawing.Point(40, 416);
            this.REGON_multi_run_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.REGON_multi_run_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.REGON_multi_run_Button.Name = "REGON_multi_run_Button";
            this.REGON_multi_run_Button.Size = new System.Drawing.Size(78, 36);
            this.REGON_multi_run_Button.TabIndex = 6;
            this.REGON_multi_run_Button.Text = "Search";
            this.REGON_multi_run_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.REGON_multi_run_Button.UseAccentColor = true;
            this.REGON_multi_run_Button.UseVisualStyleBackColor = false;
            this.REGON_multi_run_Button.Click += new System.EventHandler(this.REGON_multi_run_Button_Click);
            // 
            // regon_results_Label
            // 
            this.regon_results_Label.Depth = 0;
            this.regon_results_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regon_results_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regon_results_Label.Location = new System.Drawing.Point(453, 3);
            this.regon_results_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.regon_results_Label.Name = "regon_results_Label";
            this.regon_results_Label.Size = new System.Drawing.Size(635, 449);
            this.regon_results_Label.TabIndex = 5;
            // 
            // REGON_run_Button
            // 
            this.REGON_run_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.REGON_run_Button.BackColor = System.Drawing.Color.White;
            this.REGON_run_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.REGON_run_Button.Depth = 0;
            this.REGON_run_Button.DrawShadows = false;
            this.REGON_run_Button.HighEmphasis = true;
            this.REGON_run_Button.Icon = null;
            this.REGON_run_Button.Location = new System.Drawing.Point(40, 120);
            this.REGON_run_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.REGON_run_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.REGON_run_Button.Name = "REGON_run_Button";
            this.REGON_run_Button.Size = new System.Drawing.Size(78, 36);
            this.REGON_run_Button.TabIndex = 4;
            this.REGON_run_Button.Text = "Search";
            this.REGON_run_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.REGON_run_Button.UseAccentColor = true;
            this.REGON_run_Button.UseVisualStyleBackColor = false;
            this.REGON_run_Button.Click += new System.EventHandler(this.run_Button2_Click);
            // 
            // REGON_TextBox
            // 
            this.REGON_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REGON_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.REGON_TextBox.Depth = 0;
            this.REGON_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.REGON_TextBox.Hint = "REGON";
            this.REGON_TextBox.LeadingIcon = null;
            this.REGON_TextBox.Location = new System.Drawing.Point(40, 51);
            this.REGON_TextBox.MaxLength = 50;
            this.REGON_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.REGON_TextBox.Multiline = false;
            this.REGON_TextBox.Name = "REGON_TextBox";
            this.REGON_TextBox.Size = new System.Drawing.Size(229, 50);
            this.REGON_TextBox.TabIndex = 3;
            this.REGON_TextBox.Text = "";
            this.REGON_TextBox.TrailingIcon = null;
            // 
            // REGON_Label
            // 
            this.REGON_Label.Depth = 0;
            this.REGON_Label.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.REGON_Label.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.REGON_Label.Location = new System.Drawing.Point(38, 22);
            this.REGON_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.REGON_Label.Name = "REGON_Label";
            this.REGON_Label.Size = new System.Drawing.Size(80, 17);
            this.REGON_Label.TabIndex = 2;
            this.REGON_Label.Text = "Enter Query:";
            // 
            // REGON_input_ListBox
            // 
            this.REGON_input_ListBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.REGON_input_ListBox.FormattingEnabled = true;
            this.REGON_input_ListBox.Location = new System.Drawing.Point(18, 6);
            this.REGON_input_ListBox.Name = "REGON_input_ListBox";
            this.REGON_input_ListBox.Size = new System.Drawing.Size(415, 160);
            this.REGON_input_ListBox.TabIndex = 16;
            // 
            // multiple_nips_Checkbox
            // 
            this.multiple_nips_Checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.multiple_nips_Checkbox.Depth = 0;
            this.multiple_nips_Checkbox.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple_nips_Checkbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiple_nips_Checkbox.Location = new System.Drawing.Point(958, 79);
            this.multiple_nips_Checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.multiple_nips_Checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multiple_nips_Checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiple_nips_Checkbox.Name = "multiple_nips_Checkbox";
            this.multiple_nips_Checkbox.Ripple = true;
            this.multiple_nips_Checkbox.Size = new System.Drawing.Size(153, 36);
            this.multiple_nips_Checkbox.TabIndex = 4;
            this.multiple_nips_Checkbox.Text = "Multiple Queries";
            this.multiple_nips_Checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multiple_nips_Checkbox.UseVisualStyleBackColor = true;
            this.multiple_nips_Checkbox.CheckedChanged += new System.EventHandler(this.multiple_nips_Checkbox_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-7, 55);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1122, 60);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "Search by NIP";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WebService.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 612);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.multiple_nips_Checkbox);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox nip_textBox;
        private MaterialSkin.Controls.MaterialLabel nip_Label;
        private MaterialSkin.Controls.MaterialButton run_Button;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel results_Label;
        private MaterialSkin.Controls.MaterialTextBox REGON_TextBox;
        private MaterialSkin.Controls.MaterialLabel REGON_Label;
        private MaterialSkin.Controls.MaterialButton REGON_run_Button;
        private MaterialSkin.Controls.MaterialLabel regon_results_Label;
        private MaterialSkin.Controls.MaterialCheckbox multiple_nips_Checkbox;
        private MaterialSkin.Controls.MaterialButton multi_run_Button;
        private MaterialSkin.Controls.MaterialButton REGON_multi_run_Button;
        private MaterialSkin.Controls.MaterialTextBox multiple_NIP_textBox;
        private MaterialSkin.Controls.MaterialButton add_NIP_list_Button;
        private System.Windows.Forms.ListBox input_ListBox;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private MaterialSkin.Controls.MaterialMultiLineTextBox multiple_results_TextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox REGON_multiple_results_TextBox;
        private MaterialSkin.Controls.MaterialButton add_REGON_list_Button;
        private MaterialSkin.Controls.MaterialTextBox multiple_REGON_textBox;
        private System.Windows.Forms.ListBox REGON_input_ListBox;
    }
}