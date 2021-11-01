
namespace Dashboard
{
    partial class PortfolioForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChartPortfolioComponent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelKRWBalanceTitle = new System.Windows.Forms.Label();
            this.dataGridViewCoins = new System.Windows.Forms.DataGridView();
            this.labelLoadTime = new System.Windows.Forms.Label();
            this.labelKRWBalance = new System.Windows.Forms.Label();
            this.labelTotalAssetTitle = new System.Windows.Forms.Label();
            this.labelTotalAsset = new System.Windows.Forms.Label();
            this.labelTotalBlendedPriceTitle = new System.Windows.Forms.Label();
            this.labelTotalMarketPriceTitle = new System.Windows.Forms.Label();
            this.labelTotalMarketPrice = new System.Windows.Forms.Label();
            this.labelTotalBlendedPrice = new System.Windows.Forms.Label();
            this.labelTotalBidWeight = new System.Windows.Forms.Label();
            this.labelReturnAverageTitle = new System.Windows.Forms.Label();
            this.labelTotalReturnTitle = new System.Windows.Forms.Label();
            this.labelTotalReturn = new System.Windows.Forms.Label();
            this.labelTotalBidWeightTitle = new System.Windows.Forms.Label();
            this.labelReturnAverage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelComponentTitle = new System.Windows.Forms.Label();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartPortfolioComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPortfolioComponent
            // 
            this.ChartPortfolioComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ChartPortfolioComponent.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.Name = "ChartArea1";
            this.ChartPortfolioComponent.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.ChartPortfolioComponent.Legends.Add(legend1);
            this.ChartPortfolioComponent.Location = new System.Drawing.Point(566, 12);
            this.ChartPortfolioComponent.Name = "ChartPortfolioComponent";
            this.ChartPortfolioComponent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Component";
            this.ChartPortfolioComponent.Series.Add(series1);
            this.ChartPortfolioComponent.Size = new System.Drawing.Size(386, 314);
            this.ChartPortfolioComponent.TabIndex = 0;
            this.ChartPortfolioComponent.Text = "chart1";
            // 
            // labelKRWBalanceTitle
            // 
            this.labelKRWBalanceTitle.AutoSize = true;
            this.labelKRWBalanceTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKRWBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKRWBalanceTitle.Location = new System.Drawing.Point(222, 54);
            this.labelKRWBalanceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelKRWBalanceTitle.Name = "labelKRWBalanceTitle";
            this.labelKRWBalanceTitle.Size = new System.Drawing.Size(80, 21);
            this.labelKRWBalanceTitle.TabIndex = 6;
            this.labelKRWBalanceTitle.Text = "보유 KRW";
            // 
            // dataGridViewCoins
            // 
            this.dataGridViewCoins.AllowUserToAddRows = false;
            this.dataGridViewCoins.AllowUserToDeleteRows = false;
            this.dataGridViewCoins.AllowUserToResizeColumns = false;
            this.dataGridViewCoins.AllowUserToResizeRows = false;
            this.dataGridViewCoins.AutoGenerateColumns = false;
            this.dataGridViewCoins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewCoins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCoins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCoins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.quoteDataGridViewTextBoxColumn,
            this.returnDataGridViewTextBoxColumn,
            this.evalamountDataGridViewTextBoxColumn,
            this.marginDataGridViewTextBoxColumn});
            this.dataGridViewCoins.DataSource = this.coinBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCoins.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCoins.Location = new System.Drawing.Point(33, 361);
            this.dataGridViewCoins.Name = "dataGridViewCoins";
            this.dataGridViewCoins.ReadOnly = true;
            this.dataGridViewCoins.RowHeadersVisible = false;
            this.dataGridViewCoins.RowTemplate.Height = 23;
            this.dataGridViewCoins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCoins.Size = new System.Drawing.Size(902, 215);
            this.dataGridViewCoins.TabIndex = 14;
            // 
            // labelLoadTime
            // 
            this.labelLoadTime.AutoSize = true;
            this.labelLoadTime.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelLoadTime.Location = new System.Drawing.Point(675, 329);
            this.labelLoadTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadTime.Name = "labelLoadTime";
            this.labelLoadTime.Size = new System.Drawing.Size(78, 21);
            this.labelLoadTime.TabIndex = 15;
            this.labelLoadTime.Text = "로드 시각";
            // 
            // labelKRWBalance
            // 
            this.labelKRWBalance.AutoSize = true;
            this.labelKRWBalance.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKRWBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKRWBalance.Location = new System.Drawing.Point(332, 39);
            this.labelKRWBalance.Margin = new System.Windows.Forms.Padding(0);
            this.labelKRWBalance.Name = "labelKRWBalance";
            this.labelKRWBalance.Size = new System.Drawing.Size(152, 40);
            this.labelKRWBalance.TabIndex = 16;
            this.labelKRWBalance.Text = "Loading...";
            // 
            // labelTotalAssetTitle
            // 
            this.labelTotalAssetTitle.AutoSize = true;
            this.labelTotalAssetTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAssetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalAssetTitle.Location = new System.Drawing.Point(222, 104);
            this.labelTotalAssetTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalAssetTitle.Name = "labelTotalAssetTitle";
            this.labelTotalAssetTitle.Size = new System.Drawing.Size(98, 21);
            this.labelTotalAssetTitle.TabIndex = 17;
            this.labelTotalAssetTitle.Text = "총 보유 자산";
            // 
            // labelTotalAsset
            // 
            this.labelTotalAsset.AutoSize = true;
            this.labelTotalAsset.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalAsset.Location = new System.Drawing.Point(332, 89);
            this.labelTotalAsset.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalAsset.Name = "labelTotalAsset";
            this.labelTotalAsset.Size = new System.Drawing.Size(152, 40);
            this.labelTotalAsset.TabIndex = 18;
            this.labelTotalAsset.Text = "Loading...";
            // 
            // labelTotalBlendedPriceTitle
            // 
            this.labelTotalBlendedPriceTitle.AutoSize = true;
            this.labelTotalBlendedPriceTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBlendedPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalBlendedPriceTitle.Location = new System.Drawing.Point(32, 184);
            this.labelTotalBlendedPriceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalBlendedPriceTitle.Name = "labelTotalBlendedPriceTitle";
            this.labelTotalBlendedPriceTitle.Size = new System.Drawing.Size(81, 17);
            this.labelTotalBlendedPriceTitle.TabIndex = 19;
            this.labelTotalBlendedPriceTitle.Text = "총 매수 금액";
            // 
            // labelTotalMarketPriceTitle
            // 
            this.labelTotalMarketPriceTitle.AutoSize = true;
            this.labelTotalMarketPriceTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMarketPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalMarketPriceTitle.Location = new System.Drawing.Point(32, 234);
            this.labelTotalMarketPriceTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMarketPriceTitle.Name = "labelTotalMarketPriceTitle";
            this.labelTotalMarketPriceTitle.Size = new System.Drawing.Size(81, 17);
            this.labelTotalMarketPriceTitle.TabIndex = 20;
            this.labelTotalMarketPriceTitle.Text = "총 평가 금액";
            // 
            // labelTotalMarketPrice
            // 
            this.labelTotalMarketPrice.AutoSize = true;
            this.labelTotalMarketPrice.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMarketPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalMarketPrice.Location = new System.Drawing.Point(126, 218);
            this.labelTotalMarketPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalMarketPrice.Name = "labelTotalMarketPrice";
            this.labelTotalMarketPrice.Size = new System.Drawing.Size(142, 37);
            this.labelTotalMarketPrice.TabIndex = 21;
            this.labelTotalMarketPrice.Text = "Loading...";
            // 
            // labelTotalBlendedPrice
            // 
            this.labelTotalBlendedPrice.AutoSize = true;
            this.labelTotalBlendedPrice.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBlendedPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalBlendedPrice.Location = new System.Drawing.Point(126, 164);
            this.labelTotalBlendedPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalBlendedPrice.Name = "labelTotalBlendedPrice";
            this.labelTotalBlendedPrice.Size = new System.Drawing.Size(142, 37);
            this.labelTotalBlendedPrice.TabIndex = 22;
            this.labelTotalBlendedPrice.Text = "Loading...";
            // 
            // labelTotalBidWeight
            // 
            this.labelTotalBidWeight.AutoSize = true;
            this.labelTotalBidWeight.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBidWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalBidWeight.Location = new System.Drawing.Point(430, 184);
            this.labelTotalBidWeight.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalBidWeight.Name = "labelTotalBidWeight";
            this.labelTotalBidWeight.Size = new System.Drawing.Size(142, 37);
            this.labelTotalBidWeight.TabIndex = 23;
            this.labelTotalBidWeight.Text = "Loading...";
            // 
            // labelReturnAverageTitle
            // 
            this.labelReturnAverageTitle.AutoSize = true;
            this.labelReturnAverageTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnAverageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelReturnAverageTitle.Location = new System.Drawing.Point(326, 250);
            this.labelReturnAverageTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelReturnAverageTitle.Name = "labelReturnAverageTitle";
            this.labelReturnAverageTitle.Size = new System.Drawing.Size(94, 17);
            this.labelReturnAverageTitle.TabIndex = 25;
            this.labelReturnAverageTitle.Text = "총 평가 수익률";
            // 
            // labelTotalReturnTitle
            // 
            this.labelTotalReturnTitle.AutoSize = true;
            this.labelTotalReturnTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReturnTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalReturnTitle.Location = new System.Drawing.Point(32, 287);
            this.labelTotalReturnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalReturnTitle.Name = "labelTotalReturnTitle";
            this.labelTotalReturnTitle.Size = new System.Drawing.Size(81, 17);
            this.labelTotalReturnTitle.TabIndex = 26;
            this.labelTotalReturnTitle.Text = "총 평가 손익";
            // 
            // labelTotalReturn
            // 
            this.labelTotalReturn.AutoSize = true;
            this.labelTotalReturn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTotalReturn.Location = new System.Drawing.Point(126, 271);
            this.labelTotalReturn.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalReturn.Name = "labelTotalReturn";
            this.labelTotalReturn.Size = new System.Drawing.Size(142, 37);
            this.labelTotalReturn.TabIndex = 27;
            this.labelTotalReturn.Text = "Loading...";
            // 
            // labelTotalBidWeightTitle
            // 
            this.labelTotalBidWeightTitle.AutoSize = true;
            this.labelTotalBidWeightTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBidWeightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelTotalBidWeightTitle.Location = new System.Drawing.Point(326, 200);
            this.labelTotalBidWeightTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalBidWeightTitle.Name = "labelTotalBidWeightTitle";
            this.labelTotalBidWeightTitle.Size = new System.Drawing.Size(81, 17);
            this.labelTotalBidWeightTitle.TabIndex = 28;
            this.labelTotalBidWeightTitle.Text = "총 매수 비중";
            // 
            // labelReturnAverage
            // 
            this.labelReturnAverage.AutoSize = true;
            this.labelReturnAverage.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnAverage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelReturnAverage.Location = new System.Drawing.Point(430, 236);
            this.labelReturnAverage.Margin = new System.Windows.Forms.Padding(0);
            this.labelReturnAverage.Name = "labelReturnAverage";
            this.labelReturnAverage.Size = new System.Drawing.Size(142, 37);
            this.labelReturnAverage.TabIndex = 29;
            this.labelReturnAverage.Text = "Loading...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Upbit;
            this.pictureBox1.Location = new System.Drawing.Point(33, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 85);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelComponentTitle
            // 
            this.labelComponentTitle.AutoSize = true;
            this.labelComponentTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelComponentTitle.Location = new System.Drawing.Point(30, 333);
            this.labelComponentTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelComponentTitle.Name = "labelComponentTitle";
            this.labelComponentTitle.Size = new System.Drawing.Size(136, 25);
            this.labelComponentTitle.TabIndex = 31;
            this.labelComponentTitle.Text = "보유 자산 목록";
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "심볼";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            this.symbolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "비중";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "보유 수량";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "매수 금액";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "Bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "매수 평균가";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quoteDataGridViewTextBoxColumn
            // 
            this.quoteDataGridViewTextBoxColumn.DataPropertyName = "Quote";
            this.quoteDataGridViewTextBoxColumn.HeaderText = "현재가";
            this.quoteDataGridViewTextBoxColumn.Name = "quoteDataGridViewTextBoxColumn";
            this.quoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDataGridViewTextBoxColumn
            // 
            this.returnDataGridViewTextBoxColumn.DataPropertyName = "Return";
            this.returnDataGridViewTextBoxColumn.HeaderText = "평가 손익";
            this.returnDataGridViewTextBoxColumn.Name = "returnDataGridViewTextBoxColumn";
            this.returnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evalamountDataGridViewTextBoxColumn
            // 
            this.evalamountDataGridViewTextBoxColumn.DataPropertyName = "Eval_amount";
            this.evalamountDataGridViewTextBoxColumn.HeaderText = "평가 금액";
            this.evalamountDataGridViewTextBoxColumn.Name = "evalamountDataGridViewTextBoxColumn";
            this.evalamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marginDataGridViewTextBoxColumn
            // 
            this.marginDataGridViewTextBoxColumn.DataPropertyName = "Margin";
            this.marginDataGridViewTextBoxColumn.HeaderText = "수익률";
            this.marginDataGridViewTextBoxColumn.Name = "marginDataGridViewTextBoxColumn";
            this.marginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coinBindingSource
            // 
            this.coinBindingSource.DataSource = typeof(Dashboard.Coin);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(964, 541);
            this.Controls.Add(this.labelComponentTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelReturnAverage);
            this.Controls.Add(this.labelTotalBidWeightTitle);
            this.Controls.Add(this.labelTotalReturn);
            this.Controls.Add(this.labelTotalReturnTitle);
            this.Controls.Add(this.labelReturnAverageTitle);
            this.Controls.Add(this.labelTotalBidWeight);
            this.Controls.Add(this.labelTotalBlendedPrice);
            this.Controls.Add(this.labelTotalMarketPrice);
            this.Controls.Add(this.labelTotalMarketPriceTitle);
            this.Controls.Add(this.labelTotalBlendedPriceTitle);
            this.Controls.Add(this.labelTotalAsset);
            this.Controls.Add(this.labelTotalAssetTitle);
            this.Controls.Add(this.labelKRWBalance);
            this.Controls.Add(this.labelLoadTime);
            this.Controls.Add(this.dataGridViewCoins);
            this.Controls.Add(this.labelKRWBalanceTitle);
            this.Controls.Add(this.ChartPortfolioComponent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortfolioForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChartPortfolioComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPortfolioComponent;
        private System.Windows.Forms.Label labelKRWBalanceTitle;
        private System.Windows.Forms.DataGridView dataGridViewCoins;
        private System.Windows.Forms.Label labelLoadTime;
        private System.Windows.Forms.Label labelKRWBalance;
        private System.Windows.Forms.Label labelTotalAssetTitle;
        private System.Windows.Forms.Label labelTotalAsset;
        private System.Windows.Forms.Label labelTotalBlendedPriceTitle;
        private System.Windows.Forms.Label labelTotalMarketPriceTitle;
        private System.Windows.Forms.Label labelTotalMarketPrice;
        private System.Windows.Forms.Label labelTotalBlendedPrice;
        private System.Windows.Forms.Label labelTotalBidWeight;
        private System.Windows.Forms.Label labelReturnAverageTitle;
        private System.Windows.Forms.Label labelTotalReturnTitle;
        private System.Windows.Forms.Label labelTotalReturn;
        private System.Windows.Forms.Label labelTotalBidWeightTitle;
        private System.Windows.Forms.Label labelReturnAverage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelComponentTitle;
        private System.Windows.Forms.BindingSource coinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
    }
}