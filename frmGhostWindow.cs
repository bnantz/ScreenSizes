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

namespace ScreenSizes
{
	/// <summary>
	/// This window is resized by the <see cref="frmSizes"/> window to help size windows to a specified resolution.
	/// </summary>
	public class frmGhostWindow : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components = null;

		public frmGhostWindow()
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
         // 
         // frmGhostWindow
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.ClientSize = new System.Drawing.Size(292, 266);
         this.ControlBox = false;
         this.ForeColor = System.Drawing.Color.LightGray;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmGhostWindow";
         this.Opacity = 0.6;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

      }
		#endregion

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if(components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }
	}
}
