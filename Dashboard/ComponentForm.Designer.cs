
namespace Dashboard
{
    partial class ComponentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainWebViewerByCefSharp = new System.Windows.Forms.Panel();
            this.dataGridViewOwnCoinPairs = new System.Windows.Forms.DataGridView();
            this.labelChartDescription = new System.Windows.Forms.Label();
            this.labelCurrentChart = new System.Windows.Forms.Label();
            this.labelAmountTitle = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelEvalAmountTitle = new System.Windows.Forms.Label();
            this.labelEvalAmount = new System.Windows.Forms.Label();
            this.labelBalanceTitle = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelQuote = new System.Windows.Forms.Label();
            this.labelQuoteTitle = new System.Windows.Forms.Label();
            this.labelBid = new System.Windows.Forms.Label();
            this.labelBidTitle = new System.Windows.Forms.Label();
            this.labelKimchiPremium = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMargin = new System.Windows.Forms.Label();
            this.labelKimchiPremiumTitle = new System.Windows.Forms.Label();
            this.labelWeightTitle = new System.Windows.Forms.Label();
            this.labelMarginTitle = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelReturnTitle = new System.Windows.Forms.Label();
            this.dataGridViewOwnCoins = new System.Windows.Forms.DataGridView();
            this.labelLoadTime = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownCoinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnCoinPairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownCoinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainWebViewerByCefSharp
            // 
            this.panelMainWebViewerByCefSharp.Location = new System.Drawing.Point(348, 12);
            this.panelMainWebViewerByCefSharp.Name = "panelMainWebViewerByCefSharp";
            this.panelMainWebViewerByCefSharp.Size = new System.Drawing.Size(620, 420);
            this.panelMainWebViewerByCefSharp.TabIndex = 1;
            // 
            // dataGridViewOwnCoinPairs
            // 
            this.dataGridViewOwnCoinPairs.AllowUserToAddRows = false;
            this.dataGridViewOwnCoinPairs.AllowUserToDeleteRows = false;
            this.dataGridViewOwnCoinPairs.AllowUserToResizeColumns = false;
            this.dataGridViewOwnCoinPairs.AllowUserToResizeRows = false;
            this.dataGridViewOwnCoinPairs.AutoGenerateColumns = false;
            this.dataGridViewOwnCoinPairs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewOwnCoinPairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOwnCoinPairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnCoinPairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.marketDataGridViewTextBoxColumn});
            this.dataGridViewOwnCoinPairs.DataSource = this.tickerBindingSource;
            this.dataGridViewOwnCoinPairs.Location = new System.Drawing.Point(131, 61);
            this.dataGridViewOwnCoinPairs.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewOwnCoinPairs.Name = "dataGridViewOwnCoinPairs";
            this.dataGridViewOwnCoinPairs.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOwnCoinPairs.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOwnCoinPairs.RowHeadersVisible = false;
            this.dataGridViewOwnCoinPairs.RowTemplate.Height = 23;
            this.dataGridViewOwnCoinPairs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOwnCoinPairs.Size = new System.Drawing.Size(200, 111);
            this.dataGridViewOwnCoinPairs.TabIndex = 16;
            this.dataGridViewOwnCoinPairs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOwnCoinPairs_CellContentDoubleClick);
            // 
            // labelChartDescription
            // 
            this.labelChartDescription.AutoSize = true;
            this.labelChartDescription.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelChartDescription.Location = new System.Drawing.Point(45, 18);
            this.labelChartDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelChartDescription.Name = "labelChartDescription";
            this.labelChartDescription.Size = new System.Drawing.Size(115, 30);
            this.labelChartDescription.TabIndex = 17;
            this.labelChartDescription.Text = "현재 차트: ";
            // 
            // labelCurrentChart
            // 
            this.labelCurrentChart.AutoSize = true;
            this.labelCurrentChart.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelCurrentChart.Location = new System.Drawing.Point(177, 18);
            this.labelCurrentChart.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentChart.Name = "labelCurrentChart";
            this.labelCurrentChart.Size = new System.Drawing.Size(106, 30);
            this.labelCurrentChart.TabIndex = 18;
            this.labelCurrentChart.Text = "BTC-KRW";
            // 
            // labelAmountTitle
            // 
            this.labelAmountTitle.AutoSize = true;
            this.labelAmountTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelAmountTitle.Location = new System.Drawing.Point(31, 195);
            this.labelAmountTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmountTitle.Name = "labelAmountTitle";
            this.labelAmountTitle.Size = new System.Drawing.Size(64, 17);
            this.labelAmountTitle.TabIndex = 20;
            this.labelAmountTitle.Text = "매수 금액";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelAmount.Location = new System.Drawing.Point(153, 179);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(145, 37);
            this.labelAmount.TabIndex = 23;
            this.labelAmount.Text = "     - -- -     ";
            // 
            // labelEvalAmountTitle
            // 
            this.labelEvalAmountTitle.AutoSize = true;
            this.labelEvalAmountTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvalAmountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelEvalAmountTitle.Location = new System.Drawing.Point(31, 248);
            this.labelEvalAmountTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelEvalAmountTitle.Name = "labelEvalAmountTitle";
            this.labelEvalAmountTitle.Size = new System.Drawing.Size(64, 17);
            this.labelEvalAmountTitle.TabIndex = 24;
            this.labelEvalAmountTitle.Text = "평가 금액";
            // 
            // labelEvalAmount
            // 
            this.labelEvalAmount.AutoSize = true;
            this.labelEvalAmount.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelEvalAmount.Location = new System.Drawing.Point(153, 232);
            this.labelEvalAmount.Margin = new System.Windows.Forms.Padding(0);
            this.labelEvalAmount.Name = "labelEvalAmount";
            this.labelEvalAmount.Size = new System.Drawing.Size(145, 37);
            this.labelEvalAmount.TabIndex = 25;
            this.labelEvalAmount.Text = "     - -- -     ";
            // 
            // labelBalanceTitle
            // 
            this.labelBalanceTitle.AutoSize = true;
            this.labelBalanceTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelBalanceTitle.Location = new System.Drawing.Point(31, 411);
            this.labelBalanceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelBalanceTitle.Name = "labelBalanceTitle";
            this.labelBalanceTitle.Size = new System.Drawing.Size(64, 17);
            this.labelBalanceTitle.TabIndex = 29;
            this.labelBalanceTitle.Text = "보유 수량";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelBalance.Location = new System.Drawing.Point(153, 395);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(145, 37);
            this.labelBalance.TabIndex = 30;
            this.labelBalance.Text = "     - -- -     ";
            // 
            // labelQuote
            // 
            this.labelQuote.AutoSize = true;
            this.labelQuote.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelQuote.Location = new System.Drawing.Point(153, 340);
            this.labelQuote.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuote.Name = "labelQuote";
            this.labelQuote.Size = new System.Drawing.Size(145, 37);
            this.labelQuote.TabIndex = 34;
            this.labelQuote.Text = "     - -- -     ";
            // 
            // labelQuoteTitle
            // 
            this.labelQuoteTitle.AutoSize = true;
            this.labelQuoteTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuoteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelQuoteTitle.Location = new System.Drawing.Point(31, 356);
            this.labelQuoteTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuoteTitle.Name = "labelQuoteTitle";
            this.labelQuoteTitle.Size = new System.Drawing.Size(47, 17);
            this.labelQuoteTitle.TabIndex = 33;
            this.labelQuoteTitle.Text = "현재가";
            // 
            // labelBid
            // 
            this.labelBid.AutoSize = true;
            this.labelBid.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelBid.Location = new System.Drawing.Point(153, 285);
            this.labelBid.Margin = new System.Windows.Forms.Padding(0);
            this.labelBid.Name = "labelBid";
            this.labelBid.Size = new System.Drawing.Size(145, 37);
            this.labelBid.TabIndex = 32;
            this.labelBid.Text = "     - -- -     ";
            // 
            // labelBidTitle
            // 
            this.labelBidTitle.AutoSize = true;
            this.labelBidTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelBidTitle.Location = new System.Drawing.Point(31, 301);
            this.labelBidTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelBidTitle.Name = "labelBidTitle";
            this.labelBidTitle.Size = new System.Drawing.Size(77, 17);
            this.labelBidTitle.TabIndex = 31;
            this.labelBidTitle.Text = "매수 평균가";
            // 
            // labelKimchiPremium
            // 
            this.labelKimchiPremium.AutoSize = true;
            this.labelKimchiPremium.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKimchiPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKimchiPremium.Location = new System.Drawing.Point(706, 516);
            this.labelKimchiPremium.Margin = new System.Windows.Forms.Padding(0);
            this.labelKimchiPremium.Name = "labelKimchiPremium";
            this.labelKimchiPremium.Size = new System.Drawing.Size(207, 45);
            this.labelKimchiPremium.TabIndex = 36;
            this.labelKimchiPremium.Text = "        - -- -     ";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelWeight.Location = new System.Drawing.Point(480, 514);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(180, 45);
            this.labelWeight.TabIndex = 42;
            this.labelWeight.Text = "     - -- -     ";
            // 
            // labelMargin
            // 
            this.labelMargin.AutoSize = true;
            this.labelMargin.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMargin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelMargin.Location = new System.Drawing.Point(269, 516);
            this.labelMargin.Margin = new System.Windows.Forms.Padding(0);
            this.labelMargin.Name = "labelMargin";
            this.labelMargin.Size = new System.Drawing.Size(162, 45);
            this.labelMargin.TabIndex = 41;
            this.labelMargin.Text = "   - -- -     ";
            // 
            // labelKimchiPremiumTitle
            // 
            this.labelKimchiPremiumTitle.AutoSize = true;
            this.labelKimchiPremiumTitle.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKimchiPremiumTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKimchiPremiumTitle.Location = new System.Drawing.Point(705, 458);
            this.labelKimchiPremiumTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelKimchiPremiumTitle.Name = "labelKimchiPremiumTitle";
            this.labelKimchiPremiumTitle.Size = new System.Drawing.Size(263, 54);
            this.labelKimchiPremiumTitle.TabIndex = 38;
            this.labelKimchiPremiumTitle.Text = "김치프리미엄";
            // 
            // labelWeightTitle
            // 
            this.labelWeightTitle.AutoSize = true;
            this.labelWeightTitle.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelWeightTitle.Location = new System.Drawing.Point(479, 458);
            this.labelWeightTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelWeightTitle.Name = "labelWeightTitle";
            this.labelWeightTitle.Size = new System.Drawing.Size(194, 54);
            this.labelWeightTitle.TabIndex = 40;
            this.labelWeightTitle.Text = "매수 비중";
            // 
            // labelMarginTitle
            // 
            this.labelMarginTitle.AutoSize = true;
            this.labelMarginTitle.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelMarginTitle.Location = new System.Drawing.Point(268, 458);
            this.labelMarginTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelMarginTitle.Name = "labelMarginTitle";
            this.labelMarginTitle.Size = new System.Drawing.Size(143, 54);
            this.labelMarginTitle.TabIndex = 39;
            this.labelMarginTitle.Text = "수익률";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelReturn.Location = new System.Drawing.Point(24, 516);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(180, 45);
            this.labelReturn.TabIndex = 35;
            this.labelReturn.Text = "     - -- -     ";
            // 
            // labelReturnTitle
            // 
            this.labelReturnTitle.AutoSize = true;
            this.labelReturnTitle.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelReturnTitle.Location = new System.Drawing.Point(23, 458);
            this.labelReturnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelReturnTitle.Name = "labelReturnTitle";
            this.labelReturnTitle.Size = new System.Drawing.Size(194, 54);
            this.labelReturnTitle.TabIndex = 37;
            this.labelReturnTitle.Text = "평가 손익";
            // 
            // dataGridViewOwnCoins
            // 
            this.dataGridViewOwnCoins.AllowUserToAddRows = false;
            this.dataGridViewOwnCoins.AllowUserToDeleteRows = false;
            this.dataGridViewOwnCoins.AllowUserToResizeColumns = false;
            this.dataGridViewOwnCoins.AllowUserToResizeRows = false;
            this.dataGridViewOwnCoins.AutoGenerateColumns = false;
            this.dataGridViewOwnCoins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewOwnCoins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOwnCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnCoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewOwnCoins.DataSource = this.ownCoinsBindingSource;
            this.dataGridViewOwnCoins.Location = new System.Drawing.Point(18, 61);
            this.dataGridViewOwnCoins.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewOwnCoins.Name = "dataGridViewOwnCoins";
            this.dataGridViewOwnCoins.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOwnCoins.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOwnCoins.RowHeadersVisible = false;
            this.dataGridViewOwnCoins.RowTemplate.Height = 23;
            this.dataGridViewOwnCoins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOwnCoins.Size = new System.Drawing.Size(99, 111);
            this.dataGridViewOwnCoins.TabIndex = 44;
            this.dataGridViewOwnCoins.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOwnCoins_CellContentDoubleClick);
            // 
            // labelLoadTime
            // 
            this.labelLoadTime.AutoSize = true;
            this.labelLoadTime.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelLoadTime.Location = new System.Drawing.Point(692, 435);
            this.labelLoadTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadTime.Name = "labelLoadTime";
            this.labelLoadTime.Size = new System.Drawing.Size(78, 21);
            this.labelLoadTime.TabIndex = 17;
            this.labelLoadTime.Text = "로드 시각";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            this.dataGridViewTextBoxColumn1.HeaderText = "코인";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ownCoinsBindingSource
            // 
            this.ownCoinsBindingSource.DataSource = typeof(Dashboard.OwnCoins);
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "코인";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marketDataGridViewTextBoxColumn
            // 
            this.marketDataGridViewTextBoxColumn.DataPropertyName = "Market";
            this.marketDataGridViewTextBoxColumn.HeaderText = "페어";
            this.marketDataGridViewTextBoxColumn.Name = "marketDataGridViewTextBoxColumn";
            this.marketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tickerBindingSource
            // 
            this.tickerBindingSource.DataSource = typeof(Dashboard.Ticker);
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.labelLoadTime);
            this.Controls.Add(this.dataGridViewOwnCoins);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelBalanceTitle);
            this.Controls.Add(this.labelKimchiPremium);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelMargin);
            this.Controls.Add(this.labelKimchiPremiumTitle);
            this.Controls.Add(this.labelWeightTitle);
            this.Controls.Add(this.labelMarginTitle);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelReturnTitle);
            this.Controls.Add(this.labelQuote);
            this.Controls.Add(this.labelQuoteTitle);
            this.Controls.Add(this.labelBid);
            this.Controls.Add(this.labelBidTitle);
            this.Controls.Add(this.labelEvalAmount);
            this.Controls.Add(this.labelEvalAmountTitle);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelAmountTitle);
            this.Controls.Add(this.labelCurrentChart);
            this.Controls.Add(this.labelChartDescription);
            this.Controls.Add(this.dataGridViewOwnCoinPairs);
            this.Controls.Add(this.panelMainWebViewerByCefSharp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComponentForm_FormClosing);
            this.Load += new System.EventHandler(this.ComponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnCoinPairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownCoinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainWebViewerByCefSharp;
        private System.Windows.Forms.DataGridView dataGridViewOwnCoinPairs;
        private System.Windows.Forms.BindingSource tickerBindingSource;
        private System.Windows.Forms.Label labelChartDescription;
        private System.Windows.Forms.Label labelCurrentChart;
        private System.Windows.Forms.Label labelAmountTitle;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelEvalAmountTitle;
        private System.Windows.Forms.Label labelEvalAmount;
        private System.Windows.Forms.Label labelBalanceTitle;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelQuote;
        private System.Windows.Forms.Label labelQuoteTitle;
        private System.Windows.Forms.Label labelBid;
        private System.Windows.Forms.Label labelBidTitle;
        private System.Windows.Forms.Label labelKimchiPremium;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMargin;
        private System.Windows.Forms.Label labelKimchiPremiumTitle;
        private System.Windows.Forms.Label labelWeightTitle;
        private System.Windows.Forms.Label labelMarginTitle;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelReturnTitle;
        private System.Windows.Forms.BindingSource ownCoinsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewOwnCoins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelLoadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketDataGridViewTextBoxColumn;
    }
}