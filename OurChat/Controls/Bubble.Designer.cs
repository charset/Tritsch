namespace OurChat {
    partial class Bubble {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Portrait = new System.Windows.Forms.PictureBox();
            this.rtx = new System.Windows.Forms.RichTextBox();
            this.Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.White;
            this.Layout.ColumnCount = 3;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.5F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.5F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout.Controls.Add(this.Portrait, 1, 0);
            this.Layout.Controls.Add(this.rtx, 0, 0);
            this.Layout.Location = new System.Drawing.Point(52, 0);
            this.Layout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 1;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout.Size = new System.Drawing.Size(233, 142);
            this.Layout.TabIndex = 0;
            // 
            // Portrait
            // 
            this.Portrait.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Portrait.BackColor = System.Drawing.Color.White;
            this.Portrait.Location = new System.Drawing.Point(180, 55);
            this.Portrait.Margin = new System.Windows.Forms.Padding(0);
            this.Portrait.MaximumSize = new System.Drawing.Size(32, 32);
            this.Portrait.MinimumSize = new System.Drawing.Size(32, 32);
            this.Portrait.Name = "Portrait";
            this.Portrait.Size = new System.Drawing.Size(32, 32);
            this.Portrait.TabIndex = 1;
            this.Portrait.TabStop = false;
            this.Portrait.Visible = false;
            // 
            // rtx
            // 
            this.rtx.AutoWordSelection = true;
            this.rtx.BackColor = System.Drawing.Color.White;
            this.rtx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtx.DetectUrls = false;
            this.rtx.ForeColor = System.Drawing.Color.White;
            this.rtx.Location = new System.Drawing.Point(1, 1);
            this.rtx.Margin = new System.Windows.Forms.Padding(1);
            this.rtx.Name = "rtx";
            this.rtx.ReadOnly = true;
            this.rtx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtx.Size = new System.Drawing.Size(90, 133);
            this.rtx.TabIndex = 2;
            this.rtx.Text = "";
            this.rtx.Visible = false;
            // 
            // Bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Layout);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(233, 44);
            this.Name = "Bubble";
            this.Size = new System.Drawing.Size(375, 158);
            this.Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Portrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.PictureBox Portrait;
        private System.Windows.Forms.RichTextBox rtx;
    }
}
