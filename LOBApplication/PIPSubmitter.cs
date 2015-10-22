///////////////////////////////////////////////////////////////////////////////
//
// Copyright (C) 2002 Microsoft Corporation.  All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Solutions.BTARN.Shared;

namespace LOBApplication
{
#pragma warning disable 1634, 1691
    /// <summary>
	/// The form provides simulation for LOB. Confirms that the signal message is received and is valid.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{		
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox sourceParty;
		private System.Windows.Forms.TextBox destinationParty;
		private System.Windows.Forms.TextBox pipVersion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox pipInstance;
		private System.Windows.Forms.Label label7;
		private Guid pipInstanceID;
		private string pipInstanceString;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox fileName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox attFileBox;
		private System.Windows.Forms.Label attCount;
		private System.Windows.Forms.Button browseForFile;
		private System.Windows.Forms.Button submitMessage;
		private System.Windows.Forms.TextBox status;
		private System.Windows.Forms.Button addFile;
		private System.Windows.Forms.Button removeFile;
		private System.Windows.Forms.TextBox pipName;
        private Button button1;
        private TextBox xmlcontenttxt;
		private System.Windows.Forms.ComboBox messageCategory;
		
		public Form1()
		{
			InitializeComponent();
			 
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>		
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sourceParty = new System.Windows.Forms.TextBox();
            this.destinationParty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pipVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pipInstance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.browseForFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attFileBox = new System.Windows.Forms.ListBox();
            this.addFile = new System.Windows.Forms.Button();
            this.removeFile = new System.Windows.Forms.Button();
            this.attCount = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitMessage = new System.Windows.Forms.Button();
            this.messageCategory = new System.Windows.Forms.ComboBox();
            this.pipName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xmlcontenttxt = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML Data File|*.xml|All files (*.*)|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // sourceParty
            // 
            this.sourceParty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sourceParty.Location = new System.Drawing.Point(184, 16);
            this.sourceParty.Name = "sourceParty";
            this.sourceParty.Size = new System.Drawing.Size(160, 20);
            this.sourceParty.TabIndex = 2;
            // 
            // destinationParty
            // 
            this.destinationParty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.destinationParty.Location = new System.Drawing.Point(184, 48);
            this.destinationParty.Name = "destinationParty";
            this.destinationParty.Size = new System.Drawing.Size(160, 20);
            this.destinationParty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Home Profile Name:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Trading Partner Name:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "&PIP Name:";
            // 
            // pipVersion
            // 
            this.pipVersion.Location = new System.Drawing.Point(184, 112);
            this.pipVersion.Name = "pipVersion";
            this.pipVersion.Size = new System.Drawing.Size(72, 20);
            this.pipVersion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "PIP &Version:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "PIP &Instance ID (optional):";
            // 
            // pipInstance
            // 
            this.pipInstance.Location = new System.Drawing.Point(184, 144);
            this.pipInstance.Name = "pipInstance";
            this.pipInstance.Size = new System.Drawing.Size(160, 20);
            this.pipInstance.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "&File Name:";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(184, 184);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(160, 20);
            this.fileName.TabIndex = 12;
            // 
            // browseForFile
            // 
            this.browseForFile.Location = new System.Drawing.Point(344, 184);
            this.browseForFile.Name = "browseForFile";
            this.browseForFile.Size = new System.Drawing.Size(20, 20);
            this.browseForFile.TabIndex = 13;
            this.browseForFile.Text = "?;";
            this.browseForFile.Click += new System.EventHandler(this.browseForFile_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "&Message Category:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.attFileBox);
            this.groupBox2.Controls.Add(this.addFile);
            this.groupBox2.Controls.Add(this.removeFile);
            this.groupBox2.Controls.Add(this.attCount);
            this.groupBox2.Location = new System.Drawing.Point(16, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 128);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attachments";
            this.groupBox2.Visible = false;
            // 
            // attFileBox
            // 
            this.attFileBox.HorizontalScrollbar = true;
            this.attFileBox.Location = new System.Drawing.Point(16, 32);
            this.attFileBox.Name = "attFileBox";
            this.attFileBox.Size = new System.Drawing.Size(320, 82);
            this.attFileBox.TabIndex = 17;
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(352, 32);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(64, 24);
            this.addFile.TabIndex = 18;
            this.addFile.Text = "&Add ...";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // removeFile
            // 
            this.removeFile.Location = new System.Drawing.Point(352, 64);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(64, 24);
            this.removeFile.TabIndex = 19;
            this.removeFile.Text = "&Remove";
            this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
            // 
            // attCount
            // 
            this.attCount.Location = new System.Drawing.Point(360, 104);
            this.attCount.Name = "attCount";
            this.attCount.Size = new System.Drawing.Size(56, 16);
            this.attCount.TabIndex = 7;
            this.attCount.Text = "Count: 0";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(16, 456);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.status.Size = new System.Drawing.Size(432, 80);
            this.status.TabIndex = 13;
            this.status.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Status:";
            // 
            // submitMessage
            // 
            this.submitMessage.Location = new System.Drawing.Point(168, 392);
            this.submitMessage.Name = "submitMessage";
            this.submitMessage.Size = new System.Drawing.Size(120, 32);
            this.submitMessage.TabIndex = 99;
            this.submitMessage.Text = "&Submit Message";
            this.submitMessage.Click += new System.EventHandler(this.submitMessage_Click);
            // 
            // messageCategory
            // 
            this.messageCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.messageCategory.Items.AddRange(new object[] {
            "Action",
            "Response"});
            this.messageCategory.Location = new System.Drawing.Point(184, 216);
            this.messageCategory.Name = "messageCategory";
            this.messageCategory.Size = new System.Drawing.Size(96, 21);
            this.messageCategory.TabIndex = 15;
            // 
            // pipName
            // 
            this.pipName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pipName.Location = new System.Drawing.Point(184, 80);
            this.pipName.Name = "pipName";
            this.pipName.Size = new System.Drawing.Size(72, 20);
            this.pipName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xmlcontenttxt
            // 
            this.xmlcontenttxt.Location = new System.Drawing.Point(19, 243);
            this.xmlcontenttxt.Multiline = true;
            this.xmlcontenttxt.Name = "xmlcontenttxt";
            this.xmlcontenttxt.Size = new System.Drawing.Size(429, 143);
            this.xmlcontenttxt.TabIndex = 101;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(464, 558);
            this.Controls.Add(this.xmlcontenttxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pipName);
            this.Controls.Add(this.status);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.pipInstance);
            this.Controls.Add(this.pipVersion);
            this.Controls.Add(this.destinationParty);
            this.Controls.Add(this.sourceParty);
            this.Controls.Add(this.messageCategory);
            this.Controls.Add(this.submitMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.browseForFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 587);
            this.MinimumSize = new System.Drawing.Size(470, 587);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LOB Application";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		//=====================================================================================================
		/// <summary>
		/// Timer controls tick event
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		

		//=====================================================================================================
		/// <summary>
		/// This method allows for file selection
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================
		
		private void browseForFile_Click(object sender, System.EventArgs e)
		{
			CallFileDialog();
		}

		//=====================================================================================================
		/// <summary>
		/// This method allows for file selection
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		private void CallFileDialog()
		{
			// Select the data file
			openFileDialog1.Title = "Please select the PIP instance file";
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) 
				return;
			fileName.Text = openFileDialog1.FileName;
		}

		//=====================================================================================================
		/// <summary>
		/// This method allows for file selection
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		private void CallFileDialog2()
		{			
			// Select the data file
			openFileDialog1.Title = "Please select a  file from the folder where the exe is";
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) 
				return;
			attFileBox.Text =openFileDialog1.FileName;

			attFileBox.Items.Add(openFileDialog1.FileName);  
			attCount.Text = "Count: " + attFileBox.Items.Count.ToString() ;			
		}

		//=====================================================================================================
		/// <summary>
		/// This method allows for file selection
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		private void addFile_Click(object sender, System.EventArgs e)
		{
			CallFileDialog2();
		}

		//=====================================================================================================
		/// <summary>
		/// This method allows adding files to the attachment list box
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		private void removeFile_Click(object sender, System.EventArgs e)
		{	
			if (attFileBox.Items.Count==0)
			{
				MessageBox.Show("There are no files to remove.");  
			}
			else if (attFileBox.SelectedIndex==-1)
			{
				MessageBox.Show("Please select a file to remove from the list.");  
			}
			else
			{
				attFileBox.Items.RemoveAt(attFileBox.SelectedIndex);  
			}
			attCount.Text = "Count: " + attFileBox.Items.Count.ToString() ;			
		}
		
		//=====================================================================================================
		/// <summary>
		/// This method is used for submitting Service Content data to the database
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================

		private void submitMessage_Click(object sender, System.EventArgs e)
		{
			try
			{			
				if (CheckValidations()==true)
				{							
					CreatePipInstance(pipName.Text);    //creating instance of PIP 0C1 request and writing to BTARNData DB in table MessagesFromLOB															
				}				
			}
			catch(XmlException xmlExp)
			{				
				status.Text = xmlExp.Message;
			}
//supress PreSharp warning because we set status text
#pragma warning disable 56500
            catch (Exception exp)
			{	
				status.Text = exp.Message;								
			}
		}		

		//=====================================================================================================
		/// <summary>
		/// This method checks whether all required fields are entered before submitting data to the database.
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================
		
		public bool CheckValidations()
		{
			try
			{
				bool returnValue=false;

				if (sourceParty.Text.Trim().Length==0)
				{
					MessageBox.Show("Please enter the Source Party Name.");  
					return returnValue;
				}				
				else if (destinationParty.Text.Trim().Length==0)
				{
					MessageBox.Show("Please enter the Destination Party Name.");  
					return returnValue;
				}				
				else if (pipName.Text.Trim().Length==0)
				{
					MessageBox.Show("Please enter the PIP Name.");  
					return returnValue;
				}				
				else if (pipVersion.Text.Trim().Length==0)
				{
					MessageBox.Show("Please enter the PIP Version.");  
					return returnValue;
				}	
				else if (fileName.Text.Trim().Length==0 && this.xmlcontenttxt.Text.Trim().Length==0)
				{
					MessageBox.Show("Please select the PIP instance file.");  
					return returnValue;
				}			
				else if (messageCategory.SelectedIndex==-1)
				{
					MessageBox.Show("Please select the message category.");  
					return returnValue;
				}
				else
				{
					if ((messageCategory.SelectedIndex == 1) && (pipInstance.Text =="")) 
					{
						MessageBox.Show("Response messages require a specific PIP Instance ID.");
						return returnValue;
					}
					else
					{
						return true;
					}					
				}
			}
//supress PreSharp warning because we return false
#pragma warning disable 56500
            catch (Exception)
			{							
				return false;
			}
		}

		//=====================================================================================================
		/// <summary>
		/// This method creates PIP instance.
		/// </summary>
		/// <returns></returns>
		//=====================================================================================================
				
		public void CreatePipInstance(string pipTypeName)
		{			 	
			try
			{							
				SubmitRNIF submitAPI = new SubmitRNIF();
				int mesgCategory = MessageCategory.AsyncAction;

				switch(messageCategory.Text)
				{
					case "Response": 
						mesgCategory = MessageCategory.AsyncResponse;
						break;
					case "": 
						status.Text = "You must select a message category."; 
						return; 
					default: 
						mesgCategory = MessageCategory.AsyncAction;
						break;
				}
				
				string serviceContent = "";

				if (pipInstance.Text.Trim().Length==0)
				{
					pipInstanceID = Guid.NewGuid();
					pipInstanceString = pipInstanceID.ToString("D");
				}
				else
				{
					pipInstanceString = pipInstance.Text.Trim();
				}								

				if (fileName.Text.Trim().Length>0)
				{
					StreamReader sr = null;
					
					try
					{
						sr = new StreamReader(fileName.Text.Trim());
					}
					catch (ArgumentException argExp)
					{					
						status.Text = argExp.Message;    
					}
					catch (FileNotFoundException fileExp)
					{					
						status.Text = fileExp.Message;
					}
					catch (IOException ioExp)
					{					
						status.Text = ioExp.Message;
					}
					serviceContent = sr.ReadToEnd();
					serviceContent = "<![CDATA[" + serviceContent + "]]>";
					sr.Close();			
				}					
		
				string[] inpFileNames = new string[attFileBox.Items.Count];

				if (attFileBox.Items.Count > 0)
				{
					for (int j=0;j<attFileBox.Items.Count;j++)
					{
						inpFileNames[j] = attFileBox.Items[j].ToString(); 
					}
			

					submitAPI.SubmitMessage(mesgCategory, sourceParty.Text.Trim(), destinationParty.Text.Trim(), pipName.Text.Trim(),
						pipInstanceString,pipVersion.Text.Trim(), serviceContent, inpFileNames); 

				}
				else
				{
                    if (this.xmlcontenttxt.Text.Length > 0 && string.IsNullOrEmpty(this.fileName.Text))
                    {
                        submitAPI.SubmitMessage(mesgCategory, sourceParty.Text.Trim(), destinationParty.Text.Trim(), pipName.Text.Trim(),
                            pipInstanceString, pipVersion.Text.Trim(), this.xmlcontenttxt.Text);
                    }
                    else
                    {
                        submitAPI.SubmitMessage(mesgCategory, sourceParty.Text.Trim(), destinationParty.Text.Trim(), pipName.Text.Trim(),
                            pipInstanceString, pipVersion.Text.Trim(), serviceContent);
                    }
				}

				string statusText = "{0} message submitted from '{2}' to '{3}' with \r\nPip InstanceID: {1}";
				if (mesgCategory == MessageCategory.AsyncResponse)
				{
					status.Text = string.Format(statusText, "Response", pipInstanceString, sourceParty.Text.Trim(), destinationParty.Text.Trim() );	
				}
				else
				{
					status.Text = string.Format(statusText, "Action", pipInstanceString, sourceParty.Text.Trim(), destinationParty.Text.Trim() );	
				}
			}
//supress PreSharp warning because we set status text
#pragma warning disable 56500
            catch (Exception exp)
			{	
				status.Text = exp.ToString();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            FindPIPMessages frm = new FindPIPMessages();
            DialogResult res= frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                PipMessage msg=  frm._pipmessage;
                this.sourceParty.Text = msg.Source;
                this.destinationParty.Text = msg.Destination;
                this.pipName.Text = msg.PipCode;
                this.pipVersion.Text = msg.PipVer;
                this.xmlcontenttxt.Text = msg.XmlContent;
                this.messageCategory.SelectedIndex = 0;

            }
        }					
	}







}