namespace PicRename
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button711 = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonSuper = new System.Windows.Forms.Button();
            this.buttonGas = new System.Windows.Forms.Button();
            this.buttonPark = new System.Windows.Forms.Button();
            this.buttonRestroom = new System.Windows.Forms.Button();
            this.buttonOpenDir = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelPic = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button711
            // 
            this.button711.Location = new System.Drawing.Point(757, 12);
            this.button711.Name = "button711";
            this.button711.Size = new System.Drawing.Size(75, 39);
            this.button711.TabIndex = 1;
            this.button711.Text = "便利店";
            this.button711.UseVisualStyleBackColor = true;
            this.button711.Click += new System.EventHandler(this.button711_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(757, 57);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 36);
            this.buttonRes.TabIndex = 1;
            this.buttonRes.Text = "餐饮店";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonSuper
            // 
            this.buttonSuper.Location = new System.Drawing.Point(757, 99);
            this.buttonSuper.Name = "buttonSuper";
            this.buttonSuper.Size = new System.Drawing.Size(75, 41);
            this.buttonSuper.TabIndex = 1;
            this.buttonSuper.Text = "超市";
            this.buttonSuper.UseVisualStyleBackColor = true;
            this.buttonSuper.Click += new System.EventHandler(this.buttonSuper_Click);
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(757, 146);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(75, 40);
            this.buttonGas.TabIndex = 1;
            this.buttonGas.Text = "加油站";
            this.buttonGas.UseVisualStyleBackColor = true;
            this.buttonGas.Click += new System.EventHandler(this.buttonGas_Click);
            // 
            // buttonPark
            // 
            this.buttonPark.Location = new System.Drawing.Point(757, 192);
            this.buttonPark.Name = "buttonPark";
            this.buttonPark.Size = new System.Drawing.Size(75, 38);
            this.buttonPark.TabIndex = 1;
            this.buttonPark.Text = "停车区";
            this.buttonPark.UseVisualStyleBackColor = true;
            this.buttonPark.Click += new System.EventHandler(this.buttonPark_Click);
            // 
            // buttonRestroom
            // 
            this.buttonRestroom.Location = new System.Drawing.Point(757, 239);
            this.buttonRestroom.Name = "buttonRestroom";
            this.buttonRestroom.Size = new System.Drawing.Size(75, 40);
            this.buttonRestroom.TabIndex = 1;
            this.buttonRestroom.Text = "卫生间";
            this.buttonRestroom.UseVisualStyleBackColor = true;
            this.buttonRestroom.Click += new System.EventHandler(this.buttonRestroom_Click);
            // 
            // buttonOpenDir
            // 
            this.buttonOpenDir.Location = new System.Drawing.Point(13, 365);
            this.buttonOpenDir.Name = "buttonOpenDir";
            this.buttonOpenDir.Size = new System.Drawing.Size(118, 30);
            this.buttonOpenDir.TabIndex = 2;
            this.buttonOpenDir.Text = "打开路径";
            this.buttonOpenDir.UseVisualStyleBackColor = true;
            this.buttonOpenDir.Click += new System.EventHandler(this.buttonOpenDir_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(154, 371);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(39, 15);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "path";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Location = new System.Drawing.Point(466, 371);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(39, 15);
            this.labelPic.TabIndex = 4;
            this.labelPic.Text = "name";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(641, 157);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 37);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "下一张";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(641, 99);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 41);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "上一张";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 413);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPic);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonOpenDir);
            this.Controls.Add(this.buttonRestroom);
            this.Controls.Add(this.buttonPark);
            this.Controls.Add(this.buttonSuper);
            this.Controls.Add(this.buttonGas);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.button711);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button711;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonSuper;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Button buttonPark;
        private System.Windows.Forms.Button buttonRestroom;
        private System.Windows.Forms.Button buttonOpenDir;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelPic;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonUp;
    }
}

