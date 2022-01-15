namespace Auto_Combined_Script
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_mofp = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chk_sp = new System.Windows.Forms.CheckBox();
            this.chk_table = new System.Windows.Forms.CheckBox();
            this.chk_initial_script = new System.Windows.Forms.CheckBox();
            this.chk_constraint = new System.Windows.Forms.CheckBox();
            this.chk_function = new System.Windows.Forms.CheckBox();
            this.chk_view = new System.Windows.Forms.CheckBox();
            this.chk_trigger = new System.Windows.Forms.CheckBox();
            this.txt_ifp_sp = new System.Windows.Forms.TextBox();
            this.txt_ifp_table = new System.Windows.Forms.TextBox();
            this.txt_ifp_initial_script = new System.Windows.Forms.TextBox();
            this.txt_ifp_constraint = new System.Windows.Forms.TextBox();
            this.txt_ifp_function = new System.Windows.Forms.TextBox();
            this.txt_ifp_view = new System.Windows.Forms.TextBox();
            this.txt_ifp_trigger = new System.Windows.Forms.TextBox();
            this.txt_ofp_trigger = new System.Windows.Forms.TextBox();
            this.txt_ofp_view = new System.Windows.Forms.TextBox();
            this.txt_ofp_function = new System.Windows.Forms.TextBox();
            this.txt_ofp_constraint = new System.Windows.Forms.TextBox();
            this.txt_ofp_initial_script = new System.Windows.Forms.TextBox();
            this.txt_ofp_table = new System.Windows.Forms.TextBox();
            this.txt_ofp_sp = new System.Windows.Forms.TextBox();
            this.txt_ocsn_trigger = new System.Windows.Forms.TextBox();
            this.txt_ocsn_view = new System.Windows.Forms.TextBox();
            this.txt_ocsn_function = new System.Windows.Forms.TextBox();
            this.txt_ocsn_constraint = new System.Windows.Forms.TextBox();
            this.txt_ocsn_initial_script = new System.Windows.Forms.TextBox();
            this.txt_ocsn_table = new System.Windows.Forms.TextBox();
            this.txt_ocsn_sp = new System.Windows.Forms.TextBox();
            this.txt_ocsn_other1 = new System.Windows.Forms.TextBox();
            this.txt_ofp_other1 = new System.Windows.Forms.TextBox();
            this.txt_ifp_other1 = new System.Windows.Forms.TextBox();
            this.chk_other1 = new System.Windows.Forms.CheckBox();
            this.txt_ocsn_other2 = new System.Windows.Forms.TextBox();
            this.txt_ofp_other2 = new System.Windows.Forms.TextBox();
            this.txt_ifp_other2 = new System.Windows.Forms.TextBox();
            this.chk_other2 = new System.Windows.Forms.CheckBox();
            this.txt_ocsn_other3 = new System.Windows.Forms.TextBox();
            this.txt_ofp_other3 = new System.Windows.Forms.TextBox();
            this.txt_ifp_other3 = new System.Windows.Forms.TextBox();
            this.chk_other3 = new System.Windows.Forms.CheckBox();
            this.lbl_ifp = new System.Windows.Forms.Label();
            this.lbl_ofp = new System.Windows.Forms.Label();
            this.lbl_ocsn = new System.Windows.Forms.Label();
            this.lbl_mofp = new System.Windows.Forms.Label();
            this.lbl_or = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_version_updates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(145, 429);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(786, 66);
            this.btn_generate.TabIndex = 43;
            this.btn_generate.Text = "&Generate Combined Scipt";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_mofp
            // 
            this.txt_mofp.Location = new System.Drawing.Point(409, 363);
            this.txt_mofp.Name = "txt_mofp";
            this.txt_mofp.Size = new System.Drawing.Size(258, 20);
            this.txt_mofp.TabIndex = 41;
            this.txt_mofp.TextChanged += new System.EventHandler(this.txt_mofp_TextChanged);
            // 
            // chk_sp
            // 
            this.chk_sp.AutoSize = true;
            this.chk_sp.Location = new System.Drawing.Point(57, 68);
            this.chk_sp.Name = "chk_sp";
            this.chk_sp.Size = new System.Drawing.Size(40, 17);
            this.chk_sp.TabIndex = 0;
            this.chk_sp.Text = "&SP";
            this.chk_sp.UseVisualStyleBackColor = true;
            this.chk_sp.CheckedChanged += new System.EventHandler(this.chk_sp_CheckedChanged);
            // 
            // chk_table
            // 
            this.chk_table.AutoSize = true;
            this.chk_table.Location = new System.Drawing.Point(57, 94);
            this.chk_table.Name = "chk_table";
            this.chk_table.Size = new System.Drawing.Size(53, 17);
            this.chk_table.TabIndex = 4;
            this.chk_table.Text = "&Table";
            this.chk_table.UseVisualStyleBackColor = true;
            this.chk_table.CheckedChanged += new System.EventHandler(this.chk_table_CheckedChanged);
            // 
            // chk_initial_script
            // 
            this.chk_initial_script.AutoSize = true;
            this.chk_initial_script.Location = new System.Drawing.Point(57, 120);
            this.chk_initial_script.Name = "chk_initial_script";
            this.chk_initial_script.Size = new System.Drawing.Size(80, 17);
            this.chk_initial_script.TabIndex = 8;
            this.chk_initial_script.Text = "&Initial Script";
            this.chk_initial_script.UseVisualStyleBackColor = true;
            this.chk_initial_script.CheckedChanged += new System.EventHandler(this.chk_is_CheckedChanged);
            // 
            // chk_constraint
            // 
            this.chk_constraint.AutoSize = true;
            this.chk_constraint.Location = new System.Drawing.Point(57, 146);
            this.chk_constraint.Name = "chk_constraint";
            this.chk_constraint.Size = new System.Drawing.Size(73, 17);
            this.chk_constraint.TabIndex = 12;
            this.chk_constraint.Text = "&Constraint";
            this.chk_constraint.UseVisualStyleBackColor = true;
            this.chk_constraint.CheckedChanged += new System.EventHandler(this.chk_constraint_CheckedChanged);
            // 
            // chk_function
            // 
            this.chk_function.AutoSize = true;
            this.chk_function.Location = new System.Drawing.Point(57, 172);
            this.chk_function.Name = "chk_function";
            this.chk_function.Size = new System.Drawing.Size(67, 17);
            this.chk_function.TabIndex = 16;
            this.chk_function.Text = "&Function";
            this.chk_function.UseVisualStyleBackColor = true;
            this.chk_function.CheckedChanged += new System.EventHandler(this.chk_function_CheckedChanged);
            // 
            // chk_view
            // 
            this.chk_view.AutoSize = true;
            this.chk_view.Location = new System.Drawing.Point(57, 198);
            this.chk_view.Name = "chk_view";
            this.chk_view.Size = new System.Drawing.Size(49, 17);
            this.chk_view.TabIndex = 20;
            this.chk_view.Text = "&View";
            this.chk_view.UseVisualStyleBackColor = true;
            this.chk_view.CheckedChanged += new System.EventHandler(this.chk_view_CheckedChanged);
            // 
            // chk_trigger
            // 
            this.chk_trigger.AutoSize = true;
            this.chk_trigger.Location = new System.Drawing.Point(57, 226);
            this.chk_trigger.Name = "chk_trigger";
            this.chk_trigger.Size = new System.Drawing.Size(59, 17);
            this.chk_trigger.TabIndex = 24;
            this.chk_trigger.Text = "T&rigger";
            this.chk_trigger.UseVisualStyleBackColor = true;
            this.chk_trigger.CheckedChanged += new System.EventHandler(this.chk_trigger_CheckedChanged);
            // 
            // txt_ifp_sp
            // 
            this.txt_ifp_sp.Location = new System.Drawing.Point(145, 65);
            this.txt_ifp_sp.Name = "txt_ifp_sp";
            this.txt_ifp_sp.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_sp.TabIndex = 1;
            // 
            // txt_ifp_table
            // 
            this.txt_ifp_table.Location = new System.Drawing.Point(145, 91);
            this.txt_ifp_table.Name = "txt_ifp_table";
            this.txt_ifp_table.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_table.TabIndex = 5;
            // 
            // txt_ifp_initial_script
            // 
            this.txt_ifp_initial_script.Location = new System.Drawing.Point(145, 117);
            this.txt_ifp_initial_script.Name = "txt_ifp_initial_script";
            this.txt_ifp_initial_script.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_initial_script.TabIndex = 9;
            // 
            // txt_ifp_constraint
            // 
            this.txt_ifp_constraint.Location = new System.Drawing.Point(145, 143);
            this.txt_ifp_constraint.Name = "txt_ifp_constraint";
            this.txt_ifp_constraint.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_constraint.TabIndex = 13;
            // 
            // txt_ifp_function
            // 
            this.txt_ifp_function.Location = new System.Drawing.Point(145, 169);
            this.txt_ifp_function.Name = "txt_ifp_function";
            this.txt_ifp_function.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_function.TabIndex = 17;
            // 
            // txt_ifp_view
            // 
            this.txt_ifp_view.Location = new System.Drawing.Point(145, 195);
            this.txt_ifp_view.Name = "txt_ifp_view";
            this.txt_ifp_view.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_view.TabIndex = 21;
            // 
            // txt_ifp_trigger
            // 
            this.txt_ifp_trigger.Location = new System.Drawing.Point(145, 221);
            this.txt_ifp_trigger.Name = "txt_ifp_trigger";
            this.txt_ifp_trigger.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_trigger.TabIndex = 25;
            // 
            // txt_ofp_trigger
            // 
            this.txt_ofp_trigger.Location = new System.Drawing.Point(409, 222);
            this.txt_ofp_trigger.Name = "txt_ofp_trigger";
            this.txt_ofp_trigger.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_trigger.TabIndex = 26;
            // 
            // txt_ofp_view
            // 
            this.txt_ofp_view.Location = new System.Drawing.Point(409, 196);
            this.txt_ofp_view.Name = "txt_ofp_view";
            this.txt_ofp_view.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_view.TabIndex = 22;
            // 
            // txt_ofp_function
            // 
            this.txt_ofp_function.Location = new System.Drawing.Point(409, 170);
            this.txt_ofp_function.Name = "txt_ofp_function";
            this.txt_ofp_function.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_function.TabIndex = 18;
            // 
            // txt_ofp_constraint
            // 
            this.txt_ofp_constraint.Location = new System.Drawing.Point(409, 144);
            this.txt_ofp_constraint.Name = "txt_ofp_constraint";
            this.txt_ofp_constraint.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_constraint.TabIndex = 14;
            // 
            // txt_ofp_initial_script
            // 
            this.txt_ofp_initial_script.Location = new System.Drawing.Point(409, 118);
            this.txt_ofp_initial_script.Name = "txt_ofp_initial_script";
            this.txt_ofp_initial_script.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_initial_script.TabIndex = 10;
            // 
            // txt_ofp_table
            // 
            this.txt_ofp_table.Location = new System.Drawing.Point(409, 92);
            this.txt_ofp_table.Name = "txt_ofp_table";
            this.txt_ofp_table.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_table.TabIndex = 6;
            // 
            // txt_ofp_sp
            // 
            this.txt_ofp_sp.Location = new System.Drawing.Point(409, 66);
            this.txt_ofp_sp.Name = "txt_ofp_sp";
            this.txt_ofp_sp.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_sp.TabIndex = 2;
            // 
            // txt_ocsn_trigger
            // 
            this.txt_ocsn_trigger.Location = new System.Drawing.Point(673, 221);
            this.txt_ocsn_trigger.Name = "txt_ocsn_trigger";
            this.txt_ocsn_trigger.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_trigger.TabIndex = 27;
            // 
            // txt_ocsn_view
            // 
            this.txt_ocsn_view.Location = new System.Drawing.Point(673, 195);
            this.txt_ocsn_view.Name = "txt_ocsn_view";
            this.txt_ocsn_view.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_view.TabIndex = 23;
            // 
            // txt_ocsn_function
            // 
            this.txt_ocsn_function.Location = new System.Drawing.Point(673, 169);
            this.txt_ocsn_function.Name = "txt_ocsn_function";
            this.txt_ocsn_function.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_function.TabIndex = 19;
            // 
            // txt_ocsn_constraint
            // 
            this.txt_ocsn_constraint.Location = new System.Drawing.Point(673, 143);
            this.txt_ocsn_constraint.Name = "txt_ocsn_constraint";
            this.txt_ocsn_constraint.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_constraint.TabIndex = 15;
            // 
            // txt_ocsn_initial_script
            // 
            this.txt_ocsn_initial_script.Location = new System.Drawing.Point(673, 117);
            this.txt_ocsn_initial_script.Name = "txt_ocsn_initial_script";
            this.txt_ocsn_initial_script.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_initial_script.TabIndex = 11;
            // 
            // txt_ocsn_table
            // 
            this.txt_ocsn_table.Location = new System.Drawing.Point(673, 91);
            this.txt_ocsn_table.Name = "txt_ocsn_table";
            this.txt_ocsn_table.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_table.TabIndex = 7;
            // 
            // txt_ocsn_sp
            // 
            this.txt_ocsn_sp.Location = new System.Drawing.Point(673, 65);
            this.txt_ocsn_sp.Name = "txt_ocsn_sp";
            this.txt_ocsn_sp.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_sp.TabIndex = 3;
            // 
            // txt_ocsn_other1
            // 
            this.txt_ocsn_other1.Location = new System.Drawing.Point(673, 247);
            this.txt_ocsn_other1.Name = "txt_ocsn_other1";
            this.txt_ocsn_other1.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_other1.TabIndex = 31;
            // 
            // txt_ofp_other1
            // 
            this.txt_ofp_other1.Location = new System.Drawing.Point(409, 248);
            this.txt_ofp_other1.Name = "txt_ofp_other1";
            this.txt_ofp_other1.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_other1.TabIndex = 30;
            // 
            // txt_ifp_other1
            // 
            this.txt_ifp_other1.Location = new System.Drawing.Point(145, 247);
            this.txt_ifp_other1.Name = "txt_ifp_other1";
            this.txt_ifp_other1.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_other1.TabIndex = 29;
            // 
            // chk_other1
            // 
            this.chk_other1.AutoSize = true;
            this.chk_other1.Location = new System.Drawing.Point(57, 252);
            this.chk_other1.Name = "chk_other1";
            this.chk_other1.Size = new System.Drawing.Size(61, 17);
            this.chk_other1.TabIndex = 28;
            this.chk_other1.Text = "Other &1";
            this.chk_other1.UseVisualStyleBackColor = true;
            this.chk_other1.CheckedChanged += new System.EventHandler(this.chk_other1_CheckedChanged);
            // 
            // txt_ocsn_other2
            // 
            this.txt_ocsn_other2.Location = new System.Drawing.Point(673, 273);
            this.txt_ocsn_other2.Name = "txt_ocsn_other2";
            this.txt_ocsn_other2.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_other2.TabIndex = 35;
            // 
            // txt_ofp_other2
            // 
            this.txt_ofp_other2.Location = new System.Drawing.Point(409, 274);
            this.txt_ofp_other2.Name = "txt_ofp_other2";
            this.txt_ofp_other2.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_other2.TabIndex = 34;
            // 
            // txt_ifp_other2
            // 
            this.txt_ifp_other2.Location = new System.Drawing.Point(145, 273);
            this.txt_ifp_other2.Name = "txt_ifp_other2";
            this.txt_ifp_other2.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_other2.TabIndex = 33;
            // 
            // chk_other2
            // 
            this.chk_other2.AutoSize = true;
            this.chk_other2.Location = new System.Drawing.Point(57, 278);
            this.chk_other2.Name = "chk_other2";
            this.chk_other2.Size = new System.Drawing.Size(61, 17);
            this.chk_other2.TabIndex = 32;
            this.chk_other2.Text = "Other &2";
            this.chk_other2.UseVisualStyleBackColor = true;
            this.chk_other2.CheckedChanged += new System.EventHandler(this.chk_other2_CheckedChanged);
            // 
            // txt_ocsn_other3
            // 
            this.txt_ocsn_other3.Location = new System.Drawing.Point(673, 299);
            this.txt_ocsn_other3.Name = "txt_ocsn_other3";
            this.txt_ocsn_other3.Size = new System.Drawing.Size(258, 20);
            this.txt_ocsn_other3.TabIndex = 39;
            // 
            // txt_ofp_other3
            // 
            this.txt_ofp_other3.Location = new System.Drawing.Point(409, 300);
            this.txt_ofp_other3.Name = "txt_ofp_other3";
            this.txt_ofp_other3.Size = new System.Drawing.Size(258, 20);
            this.txt_ofp_other3.TabIndex = 38;
            // 
            // txt_ifp_other3
            // 
            this.txt_ifp_other3.Location = new System.Drawing.Point(145, 299);
            this.txt_ifp_other3.Name = "txt_ifp_other3";
            this.txt_ifp_other3.Size = new System.Drawing.Size(258, 20);
            this.txt_ifp_other3.TabIndex = 37;
            // 
            // chk_other3
            // 
            this.chk_other3.AutoSize = true;
            this.chk_other3.Location = new System.Drawing.Point(57, 304);
            this.chk_other3.Name = "chk_other3";
            this.chk_other3.Size = new System.Drawing.Size(61, 17);
            this.chk_other3.TabIndex = 36;
            this.chk_other3.Text = "Other &3";
            this.chk_other3.UseVisualStyleBackColor = true;
            this.chk_other3.CheckedChanged += new System.EventHandler(this.chk_other3_CheckedChanged);
            // 
            // lbl_ifp
            // 
            this.lbl_ifp.AutoSize = true;
            this.lbl_ifp.Location = new System.Drawing.Point(245, 43);
            this.lbl_ifp.Name = "lbl_ifp";
            this.lbl_ifp.Size = new System.Drawing.Size(88, 13);
            this.lbl_ifp.TabIndex = 44;
            this.lbl_ifp.Text = "Input Folder Path";
            // 
            // lbl_ofp
            // 
            this.lbl_ofp.AutoSize = true;
            this.lbl_ofp.Location = new System.Drawing.Point(507, 43);
            this.lbl_ofp.Name = "lbl_ofp";
            this.lbl_ofp.Size = new System.Drawing.Size(96, 13);
            this.lbl_ofp.TabIndex = 45;
            this.lbl_ofp.Text = "Output Folder Path";
            // 
            // lbl_ocsn
            // 
            this.lbl_ocsn.AutoSize = true;
            this.lbl_ocsn.Location = new System.Drawing.Point(690, 43);
            this.lbl_ocsn.Name = "lbl_ocsn";
            this.lbl_ocsn.Size = new System.Drawing.Size(226, 13);
            this.lbl_ocsn.TabIndex = 46;
            this.lbl_ocsn.Text = "Output Combined-Script Name (with extension)";
            // 
            // lbl_mofp
            // 
            this.lbl_mofp.AutoSize = true;
            this.lbl_mofp.Location = new System.Drawing.Point(272, 366);
            this.lbl_mofp.Name = "lbl_mofp";
            this.lbl_mofp.Size = new System.Drawing.Size(131, 13);
            this.lbl_mofp.TabIndex = 40;
            this.lbl_mofp.Text = "&Master Output Folder Path";
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Location = new System.Drawing.Point(531, 333);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.Size = new System.Drawing.Size(22, 13);
            this.lbl_or.TabIndex = 47;
            this.lbl_or.Text = "(or)";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(699, 391);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(232, 32);
            this.btn_clear.TabIndex = 42;
            this.btn_clear.Text = "Clear &All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_help
            // 
            this.mnu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_about,
            this.mnu_version_updates});
            this.mnu_help.Name = "mnu_help";
            this.mnu_help.Size = new System.Drawing.Size(44, 20);
            this.mnu_help.Text = "&Help";
            // 
            // mnu_about
            // 
            this.mnu_about.Name = "mnu_about";
            this.mnu_about.Size = new System.Drawing.Size(158, 22);
            this.mnu_about.Text = "&About";
            this.mnu_about.Click += new System.EventHandler(this.mnu_about_Click);
            // 
            // mnu_version_updates
            // 
            this.mnu_version_updates.Name = "mnu_version_updates";
            this.mnu_version_updates.Size = new System.Drawing.Size(158, 22);
            this.mnu_version_updates.Text = "&Version Updates";
            this.mnu_version_updates.Click += new System.EventHandler(this.mnu_version_updates_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 537);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_or);
            this.Controls.Add(this.lbl_mofp);
            this.Controls.Add(this.lbl_ocsn);
            this.Controls.Add(this.lbl_ofp);
            this.Controls.Add(this.lbl_ifp);
            this.Controls.Add(this.txt_ocsn_other3);
            this.Controls.Add(this.txt_ofp_other3);
            this.Controls.Add(this.txt_ifp_other3);
            this.Controls.Add(this.chk_other3);
            this.Controls.Add(this.txt_ocsn_other2);
            this.Controls.Add(this.txt_ofp_other2);
            this.Controls.Add(this.txt_ifp_other2);
            this.Controls.Add(this.chk_other2);
            this.Controls.Add(this.txt_ocsn_other1);
            this.Controls.Add(this.txt_ofp_other1);
            this.Controls.Add(this.txt_ifp_other1);
            this.Controls.Add(this.chk_other1);
            this.Controls.Add(this.txt_ocsn_trigger);
            this.Controls.Add(this.txt_ocsn_view);
            this.Controls.Add(this.txt_ocsn_function);
            this.Controls.Add(this.txt_ocsn_constraint);
            this.Controls.Add(this.txt_ocsn_initial_script);
            this.Controls.Add(this.txt_ocsn_table);
            this.Controls.Add(this.txt_ocsn_sp);
            this.Controls.Add(this.txt_ofp_trigger);
            this.Controls.Add(this.txt_ofp_view);
            this.Controls.Add(this.txt_ofp_function);
            this.Controls.Add(this.txt_ofp_constraint);
            this.Controls.Add(this.txt_ofp_initial_script);
            this.Controls.Add(this.txt_ofp_table);
            this.Controls.Add(this.txt_ofp_sp);
            this.Controls.Add(this.txt_ifp_trigger);
            this.Controls.Add(this.txt_ifp_view);
            this.Controls.Add(this.txt_ifp_function);
            this.Controls.Add(this.txt_ifp_constraint);
            this.Controls.Add(this.txt_ifp_initial_script);
            this.Controls.Add(this.txt_ifp_table);
            this.Controls.Add(this.txt_ifp_sp);
            this.Controls.Add(this.chk_trigger);
            this.Controls.Add(this.chk_view);
            this.Controls.Add(this.chk_function);
            this.Controls.Add(this.chk_constraint);
            this.Controls.Add(this.chk_initial_script);
            this.Controls.Add(this.chk_table);
            this.Controls.Add(this.chk_sp);
            this.Controls.Add(this.txt_mofp);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Auto Combined Script [Version: 1.2]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_mofp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chk_sp;
        private System.Windows.Forms.CheckBox chk_table;
        private System.Windows.Forms.CheckBox chk_initial_script;
        private System.Windows.Forms.CheckBox chk_constraint;
        private System.Windows.Forms.CheckBox chk_function;
        private System.Windows.Forms.CheckBox chk_view;
        private System.Windows.Forms.CheckBox chk_trigger;
        private System.Windows.Forms.TextBox txt_ifp_sp;
        private System.Windows.Forms.TextBox txt_ifp_table;
        private System.Windows.Forms.TextBox txt_ifp_initial_script;
        private System.Windows.Forms.TextBox txt_ifp_constraint;
        private System.Windows.Forms.TextBox txt_ifp_function;
        private System.Windows.Forms.TextBox txt_ifp_view;
        private System.Windows.Forms.TextBox txt_ifp_trigger;
        private System.Windows.Forms.TextBox txt_ofp_trigger;
        private System.Windows.Forms.TextBox txt_ofp_view;
        private System.Windows.Forms.TextBox txt_ofp_function;
        private System.Windows.Forms.TextBox txt_ofp_constraint;
        private System.Windows.Forms.TextBox txt_ofp_initial_script;
        private System.Windows.Forms.TextBox txt_ofp_table;
        private System.Windows.Forms.TextBox txt_ofp_sp;
        private System.Windows.Forms.TextBox txt_ocsn_trigger;
        private System.Windows.Forms.TextBox txt_ocsn_view;
        private System.Windows.Forms.TextBox txt_ocsn_function;
        private System.Windows.Forms.TextBox txt_ocsn_constraint;
        private System.Windows.Forms.TextBox txt_ocsn_initial_script;
        private System.Windows.Forms.TextBox txt_ocsn_table;
        private System.Windows.Forms.TextBox txt_ocsn_sp;
        private System.Windows.Forms.TextBox txt_ocsn_other1;
        private System.Windows.Forms.TextBox txt_ofp_other1;
        private System.Windows.Forms.TextBox txt_ifp_other1;
        private System.Windows.Forms.CheckBox chk_other1;
        private System.Windows.Forms.TextBox txt_ocsn_other2;
        private System.Windows.Forms.TextBox txt_ofp_other2;
        private System.Windows.Forms.TextBox txt_ifp_other2;
        private System.Windows.Forms.CheckBox chk_other2;
        private System.Windows.Forms.TextBox txt_ocsn_other3;
        private System.Windows.Forms.TextBox txt_ofp_other3;
        private System.Windows.Forms.TextBox txt_ifp_other3;
        private System.Windows.Forms.CheckBox chk_other3;
        private System.Windows.Forms.Label lbl_ifp;
        private System.Windows.Forms.Label lbl_ofp;
        private System.Windows.Forms.Label lbl_ocsn;
        private System.Windows.Forms.Label lbl_mofp;
        private System.Windows.Forms.Label lbl_or;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_help;
        private System.Windows.Forms.ToolStripMenuItem mnu_about;
        private System.Windows.Forms.ToolStripMenuItem mnu_version_updates;
    }
}

