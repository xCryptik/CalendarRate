using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using MPK_Calendar;

namespace CalendarTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components=null;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private MPK_Calendar.MPK_Calendar mpK_Calendar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button button8;

		//MPK_Calendar.MPK_Calendar myCal;
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.mpK_Calendar1 = new MPK_Calendar.MPK_Calendar();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Toggle buttons";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Background color";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Active month color";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(514, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "Inactive month color";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 27);
            this.button6.TabIndex = 8;
            this.button6.Text = "Selected day color";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(514, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 27);
            this.button7.TabIndex = 9;
            this.button7.Text = "Selected day font color";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(514, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(192, 26);
            this.button8.TabIndex = 11;
            this.button8.Text = "Bolded date font color";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // mpK_Calendar1
            // 
            this.mpK_Calendar1.AbbreviateWeekDayHeader = true;
            this.mpK_Calendar1.ActiveMonthColor = System.Drawing.Color.White;
            this.mpK_Calendar1.ApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mpK_Calendar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.BoldedDateFontColor = System.Drawing.Color.Red;
            this.mpK_Calendar1.BoldedDates = null;
            this.mpK_Calendar1.DisplayWeekendsDarker = true;
            this.mpK_Calendar1.GridColor = System.Drawing.Color.Black;
            this.mpK_Calendar1.HeaderColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mpK_Calendar1.InactiveMonthColor = System.Drawing.Color.Silver;
            this.mpK_Calendar1.intDay = 24;
            this.mpK_Calendar1.intMonth = 5;
            this.mpK_Calendar1.intYear = 2005;
            this.mpK_Calendar1.Location = new System.Drawing.Point(14, 14);
            this.mpK_Calendar1.Name = "mpK_Calendar1";
            this.mpK_Calendar1.NoApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mpK_Calendar1.NonselectedDayFontColor = System.Drawing.Color.Black;
            this.mpK_Calendar1.SelectedDate = new System.DateTime(2005, 5, 24, 13, 23, 30, 402);
            this.mpK_Calendar1.SelectedDayColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.SelectedDayFontColor = System.Drawing.Color.White;
            this.mpK_Calendar1.ShowCurrentMonthInDay = false;
            this.mpK_Calendar1.ShowGrid = true;
            this.mpK_Calendar1.ShowPrevNextButton = true;
            this.mpK_Calendar1.Size = new System.Drawing.Size(494, 346);
            this.mpK_Calendar1.TabIndex = 12;
            this.mpK_Calendar1.SelectedDateChanged += new MPK_Calendar.SelectedDateChangedEventHandler(this.mpK_Calendar1_SelectedDateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Font";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(717, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mpK_Calendar1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Calendar test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			


			DateTime[] dts = new DateTime[4];
			dts[0] = new DateTime(2005,6,2);
			dts[1] = new DateTime(2005,5,21);
			dts[2] = new DateTime(2005,4,21);
			dts[3] = new DateTime(2005,7,21);
			mpK_Calendar1.BoldedDates = dts;
			mpK_Calendar1.SelectedDate=DateTime.Now;
			
			this.Text = mpK_Calendar1.SelectedDate.ToShortDateString();

		}



		private void button2_Click(object sender, System.EventArgs e)
		{
			this.mpK_Calendar1.ShowPrevNextButton = !mpK_Calendar1.ShowPrevNextButton;

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.BackgroundColor = colorDialog1.Color;;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.ActiveMonthColor = colorDialog1.Color;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.InactiveMonthColor = colorDialog1.Color;
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.SelectedDayColor = colorDialog1.Color;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.SelectedDayFontColor = colorDialog1.Color;
			}
		}



		private void mpK_Calendar1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			if(colorDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.BoldedDateFontColor = colorDialog1.Color;
			}
		}



		private void button1_Click(object sender, System.EventArgs e)
		{
			if(fontDialog1.ShowDialog(this)==DialogResult.OK)
			{
				mpK_Calendar1.ApptFont = fontDialog1.Font;
			}
		}

		private void mpK_Calendar1_SelectedDateChanged(object sender, MPK_Calendar.SelectedDateChangedEventArgs e)
		{
		this.Text = e.SelectedDate.ToShortDateString();
		}
    }
}
