/*
Created by      :   Chandraprakash
Created date    :   2017-04-24
Modified date   :   2017-05-10
Email           :   frozenprakash@gmail.com
*/

using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Auto_Combined_Script
{
    public partial class frm_Main : Form
    {
        #region Class variables

        bool isempty = true;
        int major = 1,
            minor = 2,
            build = 75,
            revision = 0;

        string str_cs = "";
        string[] str_cs_arr = new string[50];

        string[] str_load_cs_arr = new string[50];

        string mydoc = Environment.ExpandEnvironmentVariables(@"%userprofile%\Documents\Auto Combine Script");
        string mydoc_fn = "configuration_file.txt";

        #endregion

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            isempty = true;

            //Any of the checkbox should be check in order for the program to execute
            if (
                    chk_sp.Checked == false &&
                    chk_table.Checked == false &&
                    chk_initial_script.Checked == false &&
                    chk_constraint.Checked == false &&
                    chk_function.Checked == false &&
                    chk_view.Checked == false &&
                    chk_trigger.Checked == false &&
                    chk_other1.Checked == false &&
                    chk_other2.Checked == false &&
                    chk_other3.Checked == false

                )
            {
                MessageBox.Show("Check any of the checkbox to proceed !!");
            }

            else
            {
                Generate();

                if (isempty == false)
                {
                    MessageBox.Show("Created all the combined scripts successfully !!");
                }
            }
        }//method

        void Generate()
        {
            //Calling combine script function for each folder

            #region 01 - SP

            if (chk_sp.Checked)
            {
                sub_generate(1,
                                txt_ifp_sp.Text.Trim(),
                                txt_ofp_sp.Text.Trim(),
                                txt_ocsn_sp.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 02 - Table

            if (chk_table.Checked)
            {
                sub_generate(2,
                                txt_ifp_table.Text.Trim(),
                                txt_ofp_table.Text.Trim(),
                                txt_ocsn_table.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 03 - Initial Script

            if (chk_initial_script.Checked)
            {
                sub_generate(3,
                                txt_ifp_initial_script.Text.Trim(),
                                txt_ofp_initial_script.Text.Trim(),
                                txt_ocsn_initial_script.Text.Trim()
                            );

                if (isempty)
                    return;                
            }

            #endregion

            #region 04 - Constraint

            if (chk_constraint.Checked)
            {
                sub_generate(4,
                                txt_ifp_constraint.Text.Trim(),
                                txt_ofp_constraint.Text.Trim(),
                                txt_ocsn_constraint.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 05 - Function

            if (chk_function.Checked)
            {
                sub_generate(5,
                                txt_ifp_function.Text.Trim(),
                                txt_ofp_function.Text.Trim(),
                                txt_ocsn_function.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 06 - View

            if (chk_view.Checked)
            {
                sub_generate(6,
                                txt_ifp_view.Text.Trim(),
                                txt_ofp_view.Text.Trim(),
                                txt_ocsn_view.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 07 - Trigger

            if (chk_trigger.Checked)
            {
                sub_generate(7,
                                txt_ifp_trigger.Text.Trim(),
                                txt_ofp_trigger.Text.Trim(),
                                txt_ocsn_trigger.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 08 - Other1

            if (chk_other1.Checked)
            {
                sub_generate(8,
                                txt_ifp_other1.Text.Trim(),
                                txt_ofp_other1.Text.Trim(),
                                txt_ocsn_other1.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 09 - Other2

            if (chk_other2.Checked)
            {
                sub_generate(9,
                                txt_ifp_other2.Text.Trim(),
                                txt_ofp_other2.Text.Trim(),
                                txt_ocsn_other2.Text.Trim()
                            );

                if (isempty)
                    return;
            }

            #endregion

            #region 10 - Other3

            if (chk_other3.Checked)
            {
                sub_generate(10,
                                txt_ifp_other3.Text.Trim(),
                                txt_ofp_other3.Text.Trim(),
                                txt_ocsn_other3.Text.Trim()
                            );

                if (isempty)
                    return;

                #region Old Logic with repetition - for reference [Commented]

                //if (txt_ifp_other3.Text.Trim() != "" &&
                //    txt_ofp_other3.Text.Trim() != "" &&
                //    txt_ocsn_other3.Text.Trim() != "")
                //{
                //    if (!txt_ocsn_other3.Text.Contains("."))
                //    {
                //        isempty = true;
                //        MessageBox.Show("Please include the file extension too !!" + Environment.NewLine +
                //                        "[Field: Output Combined-Script Name (with extension)]" + Environment.NewLine + Environment.NewLine +
                //                        "Example: Script.sql");
                //        return;
                //    }
                //    else
                //    {
                //        isempty = false;
                //        combine_script(10, txt_ifp_other3.Text.Trim(), txt_ofp_other3.Text.Trim(), txt_ocsn_other3.Text.Trim());

                //        if (isempty)
                //            return;
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Please specify the Input path, Output path and Output file name !!");
                //    return;
                //}

                #endregion

            }

            #endregion

        }

        void sub_generate(int num,
                            string input_folder,
                            string output_folder,
                            string ocsn
                        )
        {

            if (input_folder != "" &&
                    output_folder != "" &&
                    ocsn != ""
                )
            {
                if (!ocsn.Contains("."))
                {
                    isempty = true;
                    MessageBox.Show("Please include the file extension too !!" + Environment.NewLine +
                                    "[Field: Output Combined-Script Name (with extension)]" + Environment.NewLine + Environment.NewLine +
                                    "Example: Script.sql");
                    return;
                }
                else
                {
                    isempty = false;
                    combine_script(num, input_folder, output_folder, ocsn);

                    if (isempty)
                        return;
                }
            }

            else
            {
                MessageBox.Show("Please specify the Input path, Output path and Output file name !!");
                return;
            }
        }

        void combine_script(int input_number, 
                            string input_folder, 
                            string output_folder, 
                            string output_name)
        {
            string str_all = "";
            string[] str_files = Directory.GetFiles(input_folder);

            #region Validation to check any combined_files exists in the list of files in directory

            foreach (string str_file in str_files)
            { 
                if (str_file.ToUpper().Contains("COMBINE"))
                {
                    DialogResult dr = MessageBox.Show("There is a File named [" + Path.GetFileName(str_file) + "] in the Folder named [" + string_split_last(input_folder, '\\') + "] !!" + "\n\n" +

                                    "Press [Yes] to proceed to script generation" + "\n" +
                                    "\t" + "(or)" + "\n" +
                                    "[No] to stop the generation process" + "\n\n" +

                                    "Note:" + "\n" +
                                    "You can press [No], then delete the Unwanted files in the folder, double check, and then run the [Auto Combined Script] application again.",
                                    "File name confirmation",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning
                                    );

                    if (dr == DialogResult.No)
                    {
                        isempty = true;
                        return;
                    }

                }//end if
            }//end foreach

            #endregion

            str_all +=  @"/*" +
                        Environment.NewLine +
                        "---------- ";

            //Writing Information
            if (input_number == 1)
                str_all += "Combined Stored Procedures";

            if (input_number == 2)
                str_all += "Combined Tables";

            if (input_number == 3)
                str_all += "Combined Initial Scripts";

            if (input_number == 4)
                str_all += "Combined Constraints";

            if (input_number == 5)
                str_all += "Combined Functions";

            if (input_number == 6)
                str_all += "Combined Views";

            if (input_number == 7)
                str_all += "Combined Trigges";

            if (input_number == 8 || input_number == 9 || input_number == 10)
                str_all += "Combined Script";
            
            str_all +=  " [" +
                        DateTime.Now.ToString("yyyy-MM-dd hh:mm tt") +
                        "] ----------" +
                        Environment.NewLine +
                        Environment.NewLine;

            //Writing list of Filenames of the file to combine
            byte num1 = 1;
            foreach (string str_file in str_files)
            {
                if (num1 <= 9)
                {
                    str_all += "File Number" + "\t\t" + ": 0" + num1.ToString() + Environment.NewLine +
                                "File Name" + "\t\t" + ": " + Path.GetFileName(str_file) + Environment.NewLine +
                                "Date modified" + "\t" + ": " + File.GetLastWriteTime(Path.Combine(input_folder, str_file)).ToString("yyyy-MM-dd hh:mm tt") + Environment.NewLine + Environment.NewLine;
                }

                else if (num1 > 9)
                {
                    str_all += "File Number" + "\t\t" + ": " + num1.ToString() + Environment.NewLine +
                                "File Name" + "\t\t" + ": " + Path.GetFileName(str_file) + Environment.NewLine +
                                "Date modified" + "\t" + ": " + File.GetLastWriteTime(Path.Combine(input_folder, str_file)).ToString("yyyy-MM-dd hh:mm tt") + Environment.NewLine + Environment.NewLine;
                }

                num1++;
            }

            str_all += @"*/";
            str_all += Environment.NewLine;
            str_all += Environment.NewLine;

            //Writing list of contents of the files into one single file
            byte num2 = 1;
            foreach (string str_file in str_files)
            {
                str_all +=  "---+++ " + num2.ToString() + " +++---" +
                            Environment.NewLine +
                            File.ReadAllText(str_file) +
                            Environment.NewLine +
                            Environment.NewLine;
                num2++;
            }
            
            //str_all.TrimEnd(Environment.NewLine.ToCharArray());
            File.WriteAllText(Path.Combine(output_folder, output_name), str_all);

        } //Combine Script

        

        #region Form Load and Closing Triggers

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(mydoc, mydoc_fn)))
            {
                load_config();
                update_version();
            }
            
            lock_input_textbox();
            lock_output_textbox();
            lock_output_script_name_textbox();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_config();
        }

        #endregion

        private void txt_mofp_TextChanged(object sender, EventArgs e)
        {
            if (txt_mofp.Text.Trim() != "")
            {
                replicate_master_output_folder();
            }
        }

        void replicate_master_output_folder()
        {
            txt_ofp_sp.Text = txt_mofp.Text.Trim();
            txt_ofp_table.Text = txt_mofp.Text.Trim();
            txt_ofp_initial_script.Text = txt_mofp.Text.Trim();
            txt_ofp_constraint.Text = txt_mofp.Text.Trim();
            txt_ofp_function.Text = txt_mofp.Text.Trim();
            txt_ofp_view.Text = txt_mofp.Text.Trim();
            txt_ofp_trigger.Text = txt_mofp.Text.Trim();
            txt_ofp_other1.Text = txt_mofp.Text.Trim();
            txt_ofp_other2.Text = txt_mofp.Text.Trim();
            txt_ofp_other3.Text = txt_mofp.Text.Trim();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to clear all the Input folder path, Output folder path and Output file names !?" + "\n\n" +
                                                "Note: When you open the application next time, all the text box will be empty.",
                                                "ClearAll Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                clear_input_folder();
                clear_output_folder();
                clear_output_script_name();

                txt_mofp.Clear();
            }
        }

        #region Clear Textbox

        void clear_input_folder()
        {
            //Clear Input Folder Path
            txt_ifp_sp.Clear();
            txt_ifp_table.Clear();
            txt_ifp_initial_script.Clear();
            txt_ifp_constraint.Clear();
            txt_ifp_function.Clear();
            txt_ifp_view.Clear();
            txt_ifp_trigger.Clear();
            txt_ifp_other1.Clear();
            txt_ifp_other2.Clear();
            txt_ifp_other3.Clear();
        }

        void clear_output_folder()
        {
            //Clear Output Folder Path
            txt_ofp_sp.Clear();
            txt_ofp_table.Clear();
            txt_ofp_initial_script.Clear();
            txt_ofp_constraint.Clear();
            txt_ofp_function.Clear();
            txt_ofp_view.Clear();
            txt_ofp_trigger.Clear();
            txt_ofp_other1.Clear();
            txt_ofp_other2.Clear();
            txt_ofp_other3.Clear();
        }

        void clear_output_script_name()
        {
            //Clear Output Combined Script Name
            txt_ocsn_sp.Clear();
            txt_ocsn_table.Clear();
            txt_ocsn_initial_script.Clear();
            txt_ocsn_constraint.Clear();
            txt_ocsn_function.Clear();
            txt_ocsn_view.Clear();
            txt_ocsn_trigger.Clear();
            txt_ocsn_other1.Clear();
            txt_ocsn_other2.Clear();
            txt_ocsn_other3.Clear();
        }

        #endregion

        #region Configuration Files [Save and Load]
        void load_config()
        {
            str_load_cs_arr = File.ReadAllLines(Path.Combine(mydoc, mydoc_fn));

            #region Loading - Config to Program

            txt_ifp_sp.Text = str_load_cs_arr[1];
            txt_ifp_table.Text = str_load_cs_arr[2];
            txt_ifp_initial_script.Text = str_load_cs_arr[3];
            txt_ifp_constraint.Text = str_load_cs_arr[4];
            txt_ifp_function.Text = str_load_cs_arr[5];
            txt_ifp_view.Text = str_load_cs_arr[6];
            txt_ifp_trigger.Text = str_load_cs_arr[7];
            txt_ifp_other1.Text = str_load_cs_arr[8];
            txt_ifp_other2.Text = str_load_cs_arr[9];
            txt_ifp_other3.Text = str_load_cs_arr[10];

            txt_ofp_sp.Text = str_load_cs_arr[11];
            txt_ofp_table.Text = str_load_cs_arr[12];
            txt_ofp_initial_script.Text = str_load_cs_arr[13];
            txt_ofp_constraint.Text = str_load_cs_arr[14];
            txt_ofp_function.Text = str_load_cs_arr[15];
            txt_ofp_view.Text = str_load_cs_arr[16];
            txt_ofp_trigger.Text = str_load_cs_arr[17];
            txt_ofp_other1.Text = str_load_cs_arr[18];
            txt_ofp_other2.Text = str_load_cs_arr[19];
            txt_ofp_other3.Text = str_load_cs_arr[20];

            txt_ocsn_sp.Text = str_load_cs_arr[21];
            txt_ocsn_table.Text = str_load_cs_arr[22];
            txt_ocsn_initial_script.Text = str_load_cs_arr[23];
            txt_ocsn_constraint.Text = str_load_cs_arr[24];
            txt_ocsn_function.Text = str_load_cs_arr[25];
            txt_ocsn_view.Text = str_load_cs_arr[26];
            txt_ocsn_trigger.Text = str_load_cs_arr[27];
            txt_ocsn_other1.Text = str_load_cs_arr[28];
            txt_ocsn_other2.Text = str_load_cs_arr[29];
            txt_ocsn_other3.Text = str_load_cs_arr[30];

            txt_mofp.Text = str_load_cs_arr[31];

            int.TryParse(str_load_cs_arr[32], out major);
            int.TryParse(str_load_cs_arr[33], out minor);
            int.TryParse(str_load_cs_arr[34], out build);
            int.TryParse(str_load_cs_arr[35], out revision);

            #endregion
        }

        void save_config()
        {
            if (!Directory.Exists(mydoc))
            {
                Directory.CreateDirectory(mydoc);
            }

            #region Saving - Program to Config

            str_cs_arr[1] = txt_ifp_sp.Text.Trim();
            str_cs_arr[2] = txt_ifp_table.Text.Trim();
            str_cs_arr[3] = txt_ifp_initial_script.Text.Trim();
            str_cs_arr[4] = txt_ifp_constraint.Text.Trim();
            str_cs_arr[5] = txt_ifp_function.Text.Trim();
            str_cs_arr[6] = txt_ifp_view.Text.Trim();
            str_cs_arr[7] = txt_ifp_trigger.Text.Trim();
            str_cs_arr[8] = txt_ifp_other1.Text.Trim();
            str_cs_arr[9] = txt_ifp_other2.Text.Trim();
            str_cs_arr[10] = txt_ifp_other3.Text.Trim();

            str_cs_arr[11] = txt_ofp_sp.Text.Trim();
            str_cs_arr[12] = txt_ofp_table.Text.Trim();
            str_cs_arr[13] = txt_ofp_initial_script.Text.Trim();
            str_cs_arr[14] = txt_ofp_constraint.Text.Trim();
            str_cs_arr[15] = txt_ofp_function.Text.Trim();
            str_cs_arr[16] = txt_ofp_view.Text.Trim();
            str_cs_arr[17] = txt_ofp_trigger.Text.Trim();
            str_cs_arr[18] = txt_ofp_other1.Text.Trim();
            str_cs_arr[19] = txt_ofp_other2.Text.Trim();
            str_cs_arr[20] = txt_ofp_other3.Text.Trim();

            str_cs_arr[21] = txt_ocsn_sp.Text.Trim();
            str_cs_arr[22] = txt_ocsn_table.Text.Trim();
            str_cs_arr[23] = txt_ocsn_initial_script.Text.Trim();
            str_cs_arr[24] = txt_ocsn_constraint.Text.Trim();
            str_cs_arr[25] = txt_ocsn_function.Text.Trim();
            str_cs_arr[26] = txt_ocsn_view.Text.Trim();
            str_cs_arr[27] = txt_ocsn_trigger.Text.Trim();
            str_cs_arr[28] = txt_ocsn_other1.Text.Trim();
            str_cs_arr[29] = txt_ocsn_other2.Text.Trim();
            str_cs_arr[30] = txt_ocsn_other3.Text.Trim();

            str_cs_arr[31] = txt_mofp.Text.Trim();

            str_cs_arr[32] = major.ToString();
            str_cs_arr[33] = minor.ToString();
            str_cs_arr[34] = build.ToString();
            str_cs_arr[35] = revision.ToString();

            #endregion

            //Array to str_cs
            str_cs += Environment.NewLine;
            for (int i=1;i<=35;i++)
            {
                str_cs +=   str_cs_arr[i] +
                            Environment.NewLine;
            }
            File.WriteAllText(Path.Combine(mydoc, mydoc_fn), str_cs);
        }

        #endregion

        #region Lock Textbox

        void lock_input_textbox()
        {
            txt_ifp_sp.Enabled = false;
            txt_ifp_table.Enabled = false;
            txt_ifp_initial_script.Enabled = false;
            txt_ifp_constraint.Enabled = false;
            txt_ifp_function.Enabled = false;
            txt_ifp_view.Enabled = false;
            txt_ifp_trigger.Enabled = false;
            txt_ifp_other1.Enabled = false;
            txt_ifp_other2.Enabled = false;
            txt_ifp_other3.Enabled = false;
        }

        void lock_output_textbox()
        {
            txt_ofp_sp.Enabled = false;
            txt_ofp_table.Enabled = false;
            txt_ofp_initial_script.Enabled = false;
            txt_ofp_constraint.Enabled = false;
            txt_ofp_function.Enabled = false;
            txt_ofp_view.Enabled = false;
            txt_ofp_trigger.Enabled = false;
            txt_ofp_other1.Enabled = false;
            txt_ofp_other2.Enabled = false;
            txt_ofp_other3.Enabled = false;
        }

        void lock_output_script_name_textbox()
        {
            txt_ocsn_sp.Enabled = false;
            txt_ocsn_table.Enabled = false;
            txt_ocsn_initial_script.Enabled = false;
            txt_ocsn_constraint.Enabled = false;
            txt_ocsn_function.Enabled = false;
            txt_ocsn_view.Enabled = false;
            txt_ocsn_trigger.Enabled = false;
            txt_ocsn_other1.Enabled = false;
            txt_ocsn_other2.Enabled = false;
            txt_ocsn_other3.Enabled = false;
        }

#endregion

        #region Unlock Textbox

                void unlock_input_textbox()
                {
                    txt_ifp_sp.Enabled = true;
                    txt_ifp_table.Enabled = true;
                    txt_ifp_initial_script.Enabled = true;
                    txt_ifp_constraint.Enabled = true;
                    txt_ifp_function.Enabled = true;
                    txt_ifp_view.Enabled = true;
                    txt_ifp_trigger.Enabled = true;
                    txt_ifp_other1.Enabled = true;
                    txt_ifp_other2.Enabled = true;
                    txt_ifp_other3.Enabled = true;
                }

                void unlock_output_textbox()
                {
                    txt_ofp_sp.Enabled = true;
                    txt_ofp_table.Enabled = true;
                    txt_ofp_initial_script.Enabled = true;
                    txt_ofp_constraint.Enabled = true;
                    txt_ofp_function.Enabled = true;
                    txt_ofp_view.Enabled = true;
                    txt_ofp_trigger.Enabled = true;
                    txt_ofp_other1.Enabled = true;
                    txt_ofp_other2.Enabled = true;
                    txt_ofp_other3.Enabled = true;
                }

                void unlock_output_script_name_textbox()
                {
                    txt_ocsn_sp.Enabled = true;
                    txt_ocsn_table.Enabled = true;
                    txt_ocsn_initial_script.Enabled = true;
                    txt_ocsn_constraint.Enabled = true;
                    txt_ocsn_function.Enabled = true;
                    txt_ocsn_view.Enabled = true;
                    txt_ocsn_trigger.Enabled = true;
                    txt_ocsn_other1.Enabled = true;
                    txt_ocsn_other2.Enabled = true;
                    txt_ocsn_other3.Enabled = true;
                }

        #endregion

        #region Checkbox Changed Trigger

                private void chk_sp_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_sp.Checked==true)
                    {
                        txt_ifp_sp.Enabled = true;
                        txt_ofp_sp.Enabled = true;
                        txt_ocsn_sp.Enabled = true;
                    }
                    else if (chk_sp.Checked==false)
                    {
                        txt_ifp_sp.Enabled = false;
                        txt_ofp_sp.Enabled = false;
                        txt_ocsn_sp.Enabled = false;
                    }
                }

                private void chk_table_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_table.Checked == true)
                    {
                        txt_ifp_table.Enabled = true;
                        txt_ofp_table.Enabled = true;
                        txt_ocsn_table.Enabled = true;
                    }
                    else if (chk_table.Checked == false)
                    {
                        txt_ifp_table.Enabled = false;
                        txt_ofp_table.Enabled = false;
                        txt_ocsn_table.Enabled = false;
                    }
                }

                private void chk_is_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_initial_script.Checked == true)
                    {
                        txt_ifp_initial_script.Enabled = true;
                        txt_ofp_initial_script.Enabled = true;
                        txt_ocsn_initial_script.Enabled = true;
                    }
                    else if (chk_initial_script.Checked == false)
                    {
                        txt_ifp_initial_script.Enabled = false;
                        txt_ofp_initial_script.Enabled = false;
                        txt_ocsn_initial_script.Enabled = false;
                    }
                }

                private void chk_constraint_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_constraint.Checked == true)
                    {
                        txt_ifp_constraint.Enabled = true;
                        txt_ofp_constraint.Enabled = true;
                        txt_ocsn_constraint.Enabled = true;
                    }
                    else if (chk_constraint.Checked == false)
                    {
                        txt_ifp_constraint.Enabled = false;
                        txt_ofp_constraint.Enabled = false;
                        txt_ocsn_constraint.Enabled = false;
                    }
                }

                private void chk_function_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_function.Checked == true)
                    {
                        txt_ifp_function.Enabled = true;
                        txt_ofp_function.Enabled = true;
                        txt_ocsn_function.Enabled = true;
                    }
                    else if (chk_function.Checked == false)
                    {
                        txt_ifp_function.Enabled = false;
                        txt_ofp_function.Enabled = false;
                        txt_ocsn_function.Enabled = false;
                    }
                }

                private void chk_view_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_view.Checked == true)
                    {
                        txt_ifp_view.Enabled = true;
                        txt_ofp_view.Enabled = true;
                        txt_ocsn_view.Enabled = true;
                    }
                    else if (chk_view.Checked == false)
                    {
                        txt_ifp_view.Enabled = false;
                        txt_ofp_view.Enabled = false;
                        txt_ocsn_view.Enabled = false;
                    }
                }

                private void chk_trigger_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_trigger.Checked == true)
                    {
                        txt_ifp_trigger.Enabled = true;
                        txt_ofp_trigger.Enabled = true;
                        txt_ocsn_trigger.Enabled = true;
                    }
                    else if (chk_trigger.Checked == false)
                    {
                        txt_ifp_trigger.Enabled = false;
                        txt_ofp_trigger.Enabled = false;
                        txt_ocsn_trigger.Enabled = false;
                    }
                }

                private void chk_other1_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_other1.Checked == true)
                    {
                        txt_ifp_other1.Enabled = true;
                        txt_ofp_other1.Enabled = true;
                        txt_ocsn_other1.Enabled = true;
                    }
                    else if (chk_other1.Checked == false)
                    {
                        txt_ifp_other1.Enabled = false;
                        txt_ofp_other1.Enabled = false;
                        txt_ocsn_other1.Enabled = false;
                    }
                }

                private void chk_other2_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_other2.Checked == true)
                    {
                        txt_ifp_other2.Enabled = true;
                        txt_ofp_other2.Enabled = true;
                        txt_ocsn_other2.Enabled = true;
                    }
                    else if (chk_other2.Checked == false)
                    {
                        txt_ifp_other2.Enabled = false;
                        txt_ofp_other2.Enabled = false;
                        txt_ocsn_other2.Enabled = false;
                    }
                }

                private void chk_other3_CheckedChanged(object sender, EventArgs e)
                {
                    if (chk_other3.Checked == true)
                    {
                        txt_ifp_other3.Enabled = true;
                        txt_ofp_other3.Enabled = true;
                        txt_ocsn_other3.Enabled = true;
                    }
                    else if (chk_other3.Checked == false)
                    {
                        txt_ifp_other3.Enabled = false;
                        txt_ofp_other3.Enabled = false;
                        txt_ocsn_other3.Enabled = false;
                    }
                }

        #endregion

        [Conditional("DEBUG")]
        void update_version()
        {
            build++;
            this.Text = "Auto Combined Script [Version: " +
                        major.ToString() + "." +
                        minor.ToString() + "." +
                        build.ToString() + "." +
                        revision.ToString() + "]";
            this.Refresh();
        }

        #region Menu Items
        private void mnu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto Combined script - Version 1.2" + Environment.NewLine + Environment.NewLine +

                            "Created by    : Chandraprakash [SCIO1741]" + Environment.NewLine +
                            "Created date  : 2017-04-24" + Environment.NewLine +
                            "Modified date : 2017-04-28" + Environment.NewLine + Environment.NewLine +

                            "Email Address :" + Environment.NewLine +
                            "cganesan@sciohealthanalytics.com" + Environment.NewLine +
                            "frozenprakash@gmail.com"
                            );
        }

        private void mnu_version_updates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("------------------------ Latest - Version 1.2 ------------------------" + Environment.NewLine +
                            "Release date : 2016-04-27" + "\n\n" +
                            "1. Now the output combined script will contain the File Number, File Number and Last Date Modified" + "\n" +
                            "2. Converted Project from Dot Net Framework 3.5 to 2.0 Compatibility issues on Windows Vista [Recommended using at least Windows 7]" + "\n" +
                            "3. Updated the Version Update Submenu" + "\n" +
                            "4. Recommended using shortcuts, by pressing Alt key you will see the underline character for invoking shortcuts for quicker usage" + "\n" +
                            "5. Udated the detailed warning text while clicking the [Clear All] button" + "\n" +
                            "6. Now the validator will check whether the input folder contains file names containing [combine]* Case insensitive, and will warn you before generating combined script" + "\n" +
                            "7. Save history will also store and retain the textbox value of [Master Output Folder Path]" + "\n\n" +

                            "------------------------ Version 1.1 ------------------------" + "\n" +
                            "Release date : 2016-04-25" + "\n\n" +
                            "1. Updated the entire UI from single folder to Multi folder with Input Folder / Output Folder / OutputName" + "\n" +
                            "2. Included list of filenames inside the top of Combined script [*.sql]" + "\n" +
                            "3. Support for upto 10 folders, including Other1, Other2 and Other3" + "\n\n" +

                            "------------------------ Version 1.0 ------------------------" + "\n" +
                            "Release date : 2016-04-24" + "\n\n" +
                            "1. Basic version with predefined folders and minimal functionality"
                            );
        }

        #endregion

        string string_split_last(string str, char split_char)
        {
            string[] split_arr = str.Split('\\');
            return split_arr[split_arr.Length - 1];
        }

    }
}