namespace OurChat {
    partial class ChatUI {
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
            this.flowLp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLp
            // 
            this.flowLp.AutoScroll = true;
            this.flowLp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLp.Location = new System.Drawing.Point(0, 0);
            this.flowLp.Name = "flowLp";
            this.flowLp.Size = new System.Drawing.Size(253, 442);
            this.flowLp.TabIndex = 0;
            this.flowLp.WrapContents = false;
            // 
            // ChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLp);
            this.DoubleBuffered = true;
            this.Name = "ChatUI";
            this.Size = new System.Drawing.Size(253, 442);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLp;
    }
}
