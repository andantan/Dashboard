
namespace Dashboard
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnComponent = new System.Windows.Forms.Button();
            this.btnPortfolio = new System.Windows.Forms.Button();
            this.btnCryptos = new System.Windows.Forms.Button();
            this.panelUserDescription = new System.Windows.Forms.Panel();
            this.panelFormShadow = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainFormClose = new System.Windows.Forms.Button();
            this.btnMainFormMinimize = new System.Windows.Forms.Button();
            this.textBoxOption = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelFormAttachment = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelUserDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.panelNav);
            this.panelMenu.Controls.Add(this.btnComponent);
            this.panelMenu.Controls.Add(this.btnPortfolio);
            this.panelMenu.Controls.Add(this.btnCryptos);
            this.panelMenu.Controls.Add(this.panelUserDescription);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 620);
            this.panelMenu.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(3, 180);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 100);
            this.panelNav.TabIndex = 3;
            // 
            // btnComponent
            // 
            this.btnComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComponent.FlatAppearance.BorderSize = 0;
            this.btnComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponent.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnComponent.Image = global::Dashboard.Properties.Resources.circle;
            this.btnComponent.Location = new System.Drawing.Point(0, 370);
            this.btnComponent.Name = "btnComponent";
            this.btnComponent.Size = new System.Drawing.Size(220, 110);
            this.btnComponent.TabIndex = 1;
            this.btnComponent.Text = "Component";
            this.btnComponent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnComponent.UseVisualStyleBackColor = true;
            this.btnComponent.Click += new System.EventHandler(this.btnComponent_Click);
            this.btnComponent.Leave += new System.EventHandler(this.btnComponent_Leave);
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPortfolio.Image = global::Dashboard.Properties.Resources.portfolio;
            this.btnPortfolio.Location = new System.Drawing.Point(0, 260);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(220, 110);
            this.btnPortfolio.TabIndex = 1;
            this.btnPortfolio.Text = "Portfolio";
            this.btnPortfolio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPortfolio.UseVisualStyleBackColor = true;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            this.btnPortfolio.Leave += new System.EventHandler(this.btnPortfolio_Leave);
            // 
            // btnCryptos
            // 
            this.btnCryptos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCryptos.FlatAppearance.BorderSize = 0;
            this.btnCryptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCryptos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCryptos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCryptos.Image = global::Dashboard.Properties.Resources.bitcoin;
            this.btnCryptos.Location = new System.Drawing.Point(0, 150);
            this.btnCryptos.Name = "btnCryptos";
            this.btnCryptos.Size = new System.Drawing.Size(220, 110);
            this.btnCryptos.TabIndex = 1;
            this.btnCryptos.Text = "Cryptos";
            this.btnCryptos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCryptos.UseVisualStyleBackColor = true;
            this.btnCryptos.Click += new System.EventHandler(this.btnCryptos_Click);
            this.btnCryptos.Leave += new System.EventHandler(this.btnCryptos_Leave);
            // 
            // panelUserDescription
            // 
            this.panelUserDescription.Controls.Add(this.panelFormShadow);
            this.panelUserDescription.Controls.Add(this.labelDescription);
            this.panelUserDescription.Controls.Add(this.labelUserName);
            this.panelUserDescription.Controls.Add(this.pictureBox1);
            this.panelUserDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserDescription.Location = new System.Drawing.Point(0, 0);
            this.panelUserDescription.Name = "panelUserDescription";
            this.panelUserDescription.Size = new System.Drawing.Size(220, 150);
            this.panelUserDescription.TabIndex = 0;
            // 
            // panelFormShadow
            // 
            this.panelFormShadow.Location = new System.Drawing.Point(220, 40);
            this.panelFormShadow.Name = "panelFormShadow";
            this.panelFormShadow.Size = new System.Drawing.Size(980, 9);
            this.panelFormShadow.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelDescription.Location = new System.Drawing.Point(72, 108);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 12);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelUserName.Location = new System.Drawing.Point(71, 77);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainFormClose
            // 
            this.btnMainFormClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMainFormClose.FlatAppearance.BorderSize = 0;
            this.btnMainFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainFormClose.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMainFormClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.btnMainFormClose.Location = new System.Drawing.Point(943, 0);
            this.btnMainFormClose.Name = "btnMainFormClose";
            this.btnMainFormClose.Size = new System.Drawing.Size(37, 40);
            this.btnMainFormClose.TabIndex = 1;
            this.btnMainFormClose.Text = "X";
            this.btnMainFormClose.UseVisualStyleBackColor = true;
            this.btnMainFormClose.Click += new System.EventHandler(this.btnMainFormClose_Click);
            // 
            // btnMainFormMinimize
            // 
            this.btnMainFormMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMainFormMinimize.FlatAppearance.BorderSize = 0;
            this.btnMainFormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainFormMinimize.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMainFormMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.btnMainFormMinimize.Location = new System.Drawing.Point(906, 0);
            this.btnMainFormMinimize.Name = "btnMainFormMinimize";
            this.btnMainFormMinimize.Size = new System.Drawing.Size(37, 40);
            this.btnMainFormMinimize.TabIndex = 2;
            this.btnMainFormMinimize.Text = "_";
            this.btnMainFormMinimize.UseVisualStyleBackColor = true;
            this.btnMainFormMinimize.Click += new System.EventHandler(this.btnMainFormMinimize_Click);
            // 
            // textBoxOption
            // 
            this.textBoxOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textBoxOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOption.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.textBoxOption.Location = new System.Drawing.Point(351, 0);
            this.textBoxOption.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxOption.Name = "textBoxOption";
            this.textBoxOption.Size = new System.Drawing.Size(249, 36);
            this.textBoxOption.TabIndex = 3;
            this.textBoxOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.textBoxOption);
            this.panelTop.Controls.Add(this.btnMainFormMinimize);
            this.panelTop.Controls.Add(this.btnMainFormClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(980, 40);
            this.panelTop.TabIndex = 4;
            // 
            // panelFormAttachment
            // 
            this.panelFormAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelFormAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormAttachment.Location = new System.Drawing.Point(220, 40);
            this.panelFormAttachment.Name = "panelFormAttachment";
            this.panelFormAttachment.Size = new System.Drawing.Size(980, 580);
            this.panelFormAttachment.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 620);
            this.Controls.Add(this.panelFormAttachment);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUserDescription.ResumeLayout(false);
            this.panelUserDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUserDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCryptos;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnComponent;
        private System.Windows.Forms.Button btnPortfolio;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelFormShadow;
        private System.Windows.Forms.Button btnMainFormClose;
        private System.Windows.Forms.Button btnMainFormMinimize;
        private System.Windows.Forms.TextBox textBoxOption;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFormAttachment;
    }
}

