#region MIT License
/*******************************************************************************************************************************
Copyright (c) 2004 Brian Nantz

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
******************************************************************************************************************************/
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ScreenSizes
{
	public class frmSizes : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TrackBar trkbarResolution;
      private System.Windows.Forms.Label lblResolution;
      private System.Windows.Forms.Label lblLess;
      private System.Windows.Forms.Label lblMore;
		private System.ComponentModel.Container components = null;
      private System.Windows.Forms.GroupBox gbScreenResolution;

      private frmGhostWindow _frmghostwindow;

      /// <summary>
      /// Sizes is the avaliable valid sizes for the window.  The A,B,C prefix is just to order them nicely in then intellisence drop down and to work around the fact that an enum can not begin with a number.  The naming convention of underscores and the "by" word are used by the <see cref="getWindowSize"/> and <see cref="getWindowName"/> function to reutn the proper size and name of the resolution.  Adding more Sizes is simple and the code will automatically re adjust the slider and the all places the Sizes is used for resolution in case I have missed a non-standard resolution.
      /// </summary>
      private enum Sizes
      {
         A640_by_480, 
         B800_by_600, 
         C1024_by_768,
         D1280_by_1024,
         E1600_by_1200
      };
      
      public frmSizes()
		{
			InitializeComponent();
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.trkbarResolution = new System.Windows.Forms.TrackBar();
         this.gbScreenResolution = new System.Windows.Forms.GroupBox();
         this.lblMore = new System.Windows.Forms.Label();
         this.lblLess = new System.Windows.Forms.Label();
         this.lblResolution = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.trkbarResolution)).BeginInit();
         this.gbScreenResolution.SuspendLayout();
         this.SuspendLayout();
         // 
         // trkbarResolution
         // 
         this.trkbarResolution.LargeChange = 1;
         this.trkbarResolution.Location = new System.Drawing.Point(44, 18);
         this.trkbarResolution.Maximum = 5;
         this.trkbarResolution.Name = "trkbarResolution";
         this.trkbarResolution.Size = new System.Drawing.Size(127, 45);
         this.trkbarResolution.TabIndex = 0;
         this.trkbarResolution.ValueChanged += new System.EventHandler(this.trkbarResolution_ValueChanged);
         // 
         // gbScreenResolution
         // 
         this.gbScreenResolution.Controls.Add(this.lblMore);
         this.gbScreenResolution.Controls.Add(this.lblLess);
         this.gbScreenResolution.Controls.Add(this.lblResolution);
         this.gbScreenResolution.Controls.Add(this.trkbarResolution);
         this.gbScreenResolution.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
         this.gbScreenResolution.Location = new System.Drawing.Point(6, 6);
         this.gbScreenResolution.Name = "gbScreenResolution";
         this.gbScreenResolution.Size = new System.Drawing.Size(218, 96);
         this.gbScreenResolution.TabIndex = 1;
         this.gbScreenResolution.TabStop = false;
         this.gbScreenResolution.Text = "&Screen resolution";
         // 
         // lblMore
         // 
         this.lblMore.AutoSize = true;
         this.lblMore.Location = new System.Drawing.Point(176, 16);
         this.lblMore.Name = "lblMore";
         this.lblMore.Size = new System.Drawing.Size(30, 16);
         this.lblMore.TabIndex = 4;
         this.lblMore.Text = "More";
         this.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblLess
         // 
         this.lblLess.AutoSize = true;
         this.lblLess.Location = new System.Drawing.Point(10, 16);
         this.lblLess.Name = "lblLess";
         this.lblLess.Size = new System.Drawing.Size(28, 16);
         this.lblLess.TabIndex = 3;
         this.lblLess.Text = "Less";
         this.lblLess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblResolution
         // 
         this.lblResolution.AutoSize = true;
         this.lblResolution.Location = new System.Drawing.Point(69, 68);
         this.lblResolution.Name = "lblResolution";
         this.lblResolution.Size = new System.Drawing.Size(0, 16);
         this.lblResolution.TabIndex = 1;
         this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // frmSizes
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(228, 104);
         this.Controls.Add(this.gbScreenResolution);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(236, 130);
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(236, 130);
         this.Name = "frmSizes";
         this.Text = "Form Sizes";
         this.Load += new System.EventHandler(this.frmSizes_Load);
         ((System.ComponentModel.ISupportInitialize)(this.trkbarResolution)).EndInit();
         this.gbScreenResolution.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

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
      
      /// <summary>
      /// Entry point for the exe
      /// </summary>
      [STAThread]
		static void Main() 
		{
			Application.Run(new frmSizes());
		}

      #region Event Handlers
      /// <summary>
      /// Initializes all variables on the form load event.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void frmSizes_Load(object sender, System.EventArgs e)
      {
         //set the number of ticks to the number of enum values minus one because zero indexed.
         this.trkbarResolution.Maximum = Enum.GetValues(typeof(Sizes)).Length -1;

         _frmghostwindow = new frmGhostWindow();
         
         //Note that because the slider's value wil be initialized to zero the 800 by 600 is the default starting size.
         _frmghostwindow.Size = getWindowSize();
         _frmghostwindow.Text = getWindowName();
         this.lblResolution.Text = getWindowName();

         _frmghostwindow.Show();
      }

      /// <summary>
      /// This is the envent handler when the slider changes.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void trkbarResolution_ValueChanged(object sender, System.EventArgs e)
      {
         _frmghostwindow.Size = getWindowSize();
         _frmghostwindow.Text = getWindowName();
         this.lblResolution.Text = getWindowName();      
      }
      #endregion

      #region Helper Functions
      /// <summary>
      /// Based on the naming convention of <see cref="Sizes"/> this function returns the size choosen by the index of the slider.
      /// </summary>
      /// <returns>The size of the window</returns>
      private Size getWindowSize()
      {
         string enumstring = Enum.GetName(typeof(Sizes), this.trkbarResolution.Value);
         enumstring = enumstring.Remove(0, 1);

         string [] sizes = enumstring.Split( '_' );

         return new Size(Convert.ToInt32(sizes[0]),
                         Convert.ToInt32(sizes[2]));

      }

      /// <summary>
      /// Based on the naming convention of <see cref="Sizes"/> this function returns the name of the size choosen by the index of the slider.
      /// </summary>
      /// <returns>The size of the window</returns>
      private string getWindowName()
      {
         string enumstring = Enum.GetName(typeof(Sizes), this.trkbarResolution.Value);
         enumstring = enumstring.Remove(0, 1);
         enumstring = enumstring.Replace("_", " ");
         enumstring = enumstring + " pixels";

         return enumstring;
      }
      #endregion
	}
}
