#region MIT License

/*
 * Copyright (c) 2009 Nick Gravelyn (nick@gravelyn.com), Markus Ewald (cygon@nuclex.org)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a 
 * copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software 
 * is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
 * 
 */

#endregion

namespace SpriteSheetPacker
{
	partial class SpriteSheetPackerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeImageBtn = new System.Windows.Forms.Button();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.buildBtn = new System.Windows.Forms.Button();
            this.imageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paddingTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxWidthTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxHeightTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageFileTxtBox = new System.Windows.Forms.TextBox();
            this.browseImageBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mapFileTxtBox = new System.Windows.Forms.TextBox();
            this.browseMapBtn = new System.Windows.Forms.Button();
            this.imageSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mapSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.powOf2CheckBox = new System.Windows.Forms.CheckBox();
            this.squareCheckBox = new System.Windows.Forms.CheckBox();
            this.generateMapCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxSameSize = new System.Windows.Forms.CheckBox();
            this.textBoxNameSplit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(513, 144);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeImageBtn.Location = new System.Drawing.Point(355, 160);
            this.removeImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(84, 38);
            this.removeImageBtn.TabIndex = 6;
            this.removeImageBtn.Tag = "Remove Selected";
            this.removeImageBtn.Text = "移除选择";
            this.removeImageBtn.UseVisualStyleBackColor = true;
            this.removeImageBtn.Click += new System.EventHandler(this.removeImageBtn_Click);
            // 
            // addImageBtn
            // 
            this.addImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addImageBtn.Location = new System.Drawing.Point(266, 160);
            this.addImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(84, 38);
            this.addImageBtn.TabIndex = 5;
            this.addImageBtn.Tag = "Add Images";
            this.addImageBtn.Text = "添加图片";
            this.addImageBtn.UseVisualStyleBackColor = true;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // buildBtn
            // 
            this.buildBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buildBtn.Location = new System.Drawing.Point(355, 285);
            this.buildBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(172, 38);
            this.buildBtn.TabIndex = 12;
            this.buildBtn.Text = "生成动画表";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // imageOpenFileDialog
            // 
            this.imageOpenFileDialog.AddExtension = false;
            this.imageOpenFileDialog.FileName = "openFileDialog1";
            this.imageOpenFileDialog.Filter = "Image Files (png, jpg, bmp)|*.png;*.jpg;*.bmp";
            this.imageOpenFileDialog.Multiselect = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.Location = new System.Drawing.Point(443, 160);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(84, 38);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "移除全部";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Image Padding";
            this.label1.Text = "图像内边距:";
            // 
            // paddingTxtBox
            // 
            this.paddingTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.paddingTxtBox.Location = new System.Drawing.Point(88, 171);
            this.paddingTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.paddingTxtBox.Name = "paddingTxtBox";
            this.paddingTxtBox.Size = new System.Drawing.Size(76, 21);
            this.paddingTxtBox.TabIndex = 0;
            this.paddingTxtBox.Text = "0";
            this.paddingTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Maximum Sheet Size";
            this.label2.Text = "表最大范围:";
            // 
            // maxWidthTxtBox
            // 
            this.maxWidthTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maxWidthTxtBox.Location = new System.Drawing.Point(88, 225);
            this.maxWidthTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxWidthTxtBox.Name = "maxWidthTxtBox";
            this.maxWidthTxtBox.Size = new System.Drawing.Size(76, 21);
            this.maxWidthTxtBox.TabIndex = 1;
            this.maxWidthTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Width";
            this.label3.Text = "宽度:";
            // 
            // maxHeightTxtBox
            // 
            this.maxHeightTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maxHeightTxtBox.Location = new System.Drawing.Point(88, 247);
            this.maxHeightTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxHeightTxtBox.Name = "maxHeightTxtBox";
            this.maxHeightTxtBox.Size = new System.Drawing.Size(76, 21);
            this.maxHeightTxtBox.TabIndex = 2;
            this.maxHeightTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Tag = "Width";
            this.label4.Text = "高度:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 2;
            this.label5.Tag = "Image File";
            this.label5.Text = "图片保存路径:";
            // 
            // imageFileTxtBox
            // 
            this.imageFileTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imageFileTxtBox.Location = new System.Drawing.Point(280, 209);
            this.imageFileTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageFileTxtBox.Name = "imageFileTxtBox";
            this.imageFileTxtBox.ReadOnly = true;
            this.imageFileTxtBox.Size = new System.Drawing.Size(216, 21);
            this.imageFileTxtBox.TabIndex = 8;
            // 
            // browseImageBtn
            // 
            this.browseImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.browseImageBtn.Location = new System.Drawing.Point(499, 209);
            this.browseImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.browseImageBtn.Name = "browseImageBtn";
            this.browseImageBtn.Size = new System.Drawing.Size(28, 16);
            this.browseImageBtn.TabIndex = 9;
            this.browseImageBtn.Text = "...";
            this.browseImageBtn.UseVisualStyleBackColor = true;
            this.browseImageBtn.Click += new System.EventHandler(this.browseImageBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 2;
            this.label6.Tag = "Map File";
            this.label6.Text = "导航保存路径:";
            // 
            // mapFileTxtBox
            // 
            this.mapFileTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mapFileTxtBox.Location = new System.Drawing.Point(280, 232);
            this.mapFileTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.mapFileTxtBox.Name = "mapFileTxtBox";
            this.mapFileTxtBox.ReadOnly = true;
            this.mapFileTxtBox.Size = new System.Drawing.Size(216, 21);
            this.mapFileTxtBox.TabIndex = 10;
            // 
            // browseMapBtn
            // 
            this.browseMapBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.browseMapBtn.Location = new System.Drawing.Point(499, 232);
            this.browseMapBtn.Margin = new System.Windows.Forms.Padding(2);
            this.browseMapBtn.Name = "browseMapBtn";
            this.browseMapBtn.Size = new System.Drawing.Size(28, 16);
            this.browseMapBtn.TabIndex = 11;
            this.browseMapBtn.Text = "...";
            this.browseMapBtn.UseVisualStyleBackColor = true;
            this.browseMapBtn.Click += new System.EventHandler(this.browseMapBtn_Click);
            // 
            // imageSaveFileDialog
            // 
            this.imageSaveFileDialog.DefaultExt = "png";
            this.imageSaveFileDialog.Filter = "PNG Files|*.png";
            // 
            // mapSaveFileDialog
            // 
            this.mapSaveFileDialog.DefaultExt = "txt";
            this.mapSaveFileDialog.Filter = "TXT Files|*.txt";
            // 
            // powOf2CheckBox
            // 
            this.powOf2CheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.powOf2CheckBox.AutoSize = true;
            this.powOf2CheckBox.Location = new System.Drawing.Point(198, 285);
            this.powOf2CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.powOf2CheckBox.Name = "powOf2CheckBox";
            this.powOf2CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.powOf2CheckBox.Size = new System.Drawing.Size(84, 16);
            this.powOf2CheckBox.TabIndex = 3;
            this.powOf2CheckBox.Text = "输出两次方";
            this.powOf2CheckBox.UseVisualStyleBackColor = true;
            // 
            // squareCheckBox
            // 
            this.squareCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.squareCheckBox.AutoSize = true;
            this.squareCheckBox.Location = new System.Drawing.Point(198, 308);
            this.squareCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.squareCheckBox.Name = "squareCheckBox";
            this.squareCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.squareCheckBox.Size = new System.Drawing.Size(84, 16);
            this.squareCheckBox.TabIndex = 4;
            this.squareCheckBox.Text = "输出正方形";
            this.squareCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateMapCheckBox
            // 
            this.generateMapCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generateMapCheckBox.AutoSize = true;
            this.generateMapCheckBox.Checked = true;
            this.generateMapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateMapCheckBox.Location = new System.Drawing.Point(280, 251);
            this.generateMapCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.generateMapCheckBox.Name = "generateMapCheckBox";
            this.generateMapCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateMapCheckBox.Size = new System.Drawing.Size(78, 16);
            this.generateMapCheckBox.TabIndex = 13;
            this.generateMapCheckBox.Tag = "Generate Map";
            this.generateMapCheckBox.Text = "生成导航?";
            this.generateMapCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxSameSize
            // 
            this.checkBoxSameSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxSameSize.AutoSize = true;
            this.checkBoxSameSize.Location = new System.Drawing.Point(68, 308);
            this.checkBoxSameSize.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSameSize.Name = "checkBoxSameSize";
            this.checkBoxSameSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSameSize.Size = new System.Drawing.Size(96, 16);
            this.checkBoxSameSize.TabIndex = 14;
            this.checkBoxSameSize.Text = "相同大小图片";
            this.checkBoxSameSize.UseVisualStyleBackColor = true;
            // 
            // textBoxNameSplit
            // 
            this.textBoxNameSplit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNameSplit.Location = new System.Drawing.Point(88, 280);
            this.textBoxNameSplit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameSplit.Name = "textBoxNameSplit";
            this.textBoxNameSplit.Size = new System.Drawing.Size(76, 21);
            this.textBoxNameSplit.TabIndex = 15;
            this.textBoxNameSplit.Text = "-";
            this.textBoxNameSplit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "文件名分隔符:";
            // 
            // SpriteSheetPackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNameSplit);
            this.Controls.Add(this.checkBoxSameSize);
            this.Controls.Add(this.generateMapCheckBox);
            this.Controls.Add(this.squareCheckBox);
            this.Controls.Add(this.powOf2CheckBox);
            this.Controls.Add(this.browseMapBtn);
            this.Controls.Add(this.browseImageBtn);
            this.Controls.Add(this.maxHeightTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxWidthTxtBox);
            this.Controls.Add(this.mapFileTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageFileTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paddingTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.addImageBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeImageBtn);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(555, 374);
            this.Name = "SpriteSheetPackerForm";
            this.Text = "Sprite Sheet Packer";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button removeImageBtn;
		private System.Windows.Forms.Button addImageBtn;
		private System.Windows.Forms.Button buildBtn;
		private System.Windows.Forms.OpenFileDialog imageOpenFileDialog;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox paddingTxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox maxWidthTxtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox maxHeightTxtBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox imageFileTxtBox;
		private System.Windows.Forms.Button browseImageBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox mapFileTxtBox;
		private System.Windows.Forms.Button browseMapBtn;
		private System.Windows.Forms.SaveFileDialog imageSaveFileDialog;
		private System.Windows.Forms.SaveFileDialog mapSaveFileDialog;
		private System.Windows.Forms.CheckBox powOf2CheckBox;
		private System.Windows.Forms.CheckBox squareCheckBox;
		private System.Windows.Forms.CheckBox generateMapCheckBox;
        private System.Windows.Forms.CheckBox checkBoxSameSize;
        private System.Windows.Forms.TextBox textBoxNameSplit;
        private System.Windows.Forms.Label label7;
    }
}

