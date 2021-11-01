
namespace Dashboard
{
    partial class CryptosForm
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
            this.panelMainWebViewerByCefSharp = new System.Windows.Forms.Panel();
            this.labelChartDescription = new System.Windows.Forms.Label();
            this.labelCurrentChart = new System.Windows.Forms.Label();
            this.labelShowBTCPrice = new System.Windows.Forms.Label();
            this.labelBTCUSDT = new System.Windows.Forms.Label();
            this.textBoxSearchCoinSymbol = new System.Windows.Forms.TextBox();
            this.btnSearchCoin = new System.Windows.Forms.Button();
            this.dataGridViewPairs = new System.Windows.Forms.DataGridView();
            this.labelETHUSDT = new System.Windows.Forms.Label();
            this.labelXRPUSDT = new System.Windows.Forms.Label();
            this.labelADAUSDT = new System.Windows.Forms.Label();
            this.labelShowETHPrice = new System.Windows.Forms.Label();
            this.labelShowXRPPrice = new System.Windows.Forms.Label();
            this.labelShowADAPrice = new System.Windows.Forms.Label();
            this.labelUSDTPriceOfSelectedSymbol = new System.Windows.Forms.Label();
            this.labelExchangeKRWToDollar = new System.Windows.Forms.Label();
            this.labelKimchiPremium = new System.Windows.Forms.Label();
            this.labelLoadTime = new System.Windows.Forms.Label();
            this.labelKRWPriceOfSelctedSymbol = new System.Windows.Forms.Label();
            this.labelExchangedKRWPrice = new System.Windows.Forms.Label();
            this.labelDifferencePrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainWebViewerByCefSharp
            // 
            this.panelMainWebViewerByCefSharp.Location = new System.Drawing.Point(329, 12);
            this.panelMainWebViewerByCefSharp.Name = "panelMainWebViewerByCefSharp";
            this.panelMainWebViewerByCefSharp.Size = new System.Drawing.Size(620, 420);
            this.panelMainWebViewerByCefSharp.TabIndex = 0;
            // 
            // labelChartDescription
            // 
            this.labelChartDescription.AutoSize = true;
            this.labelChartDescription.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelChartDescription.Location = new System.Drawing.Point(46, 79);
            this.labelChartDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelChartDescription.Name = "labelChartDescription";
            this.labelChartDescription.Size = new System.Drawing.Size(115, 30);
            this.labelChartDescription.TabIndex = 2;
            this.labelChartDescription.Text = "현재 차트: ";
            // 
            // labelCurrentChart
            // 
            this.labelCurrentChart.AutoSize = true;
            this.labelCurrentChart.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelCurrentChart.Location = new System.Drawing.Point(161, 79);
            this.labelCurrentChart.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentChart.Name = "labelCurrentChart";
            this.labelCurrentChart.Size = new System.Drawing.Size(106, 30);
            this.labelCurrentChart.TabIndex = 3;
            this.labelCurrentChart.Text = "BTC-KRW";
            // 
            // labelShowBTCPrice
            // 
            this.labelShowBTCPrice.AutoSize = true;
            this.labelShowBTCPrice.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowBTCPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelShowBTCPrice.Location = new System.Drawing.Point(9, 520);
            this.labelShowBTCPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelShowBTCPrice.Name = "labelShowBTCPrice";
            this.labelShowBTCPrice.Size = new System.Drawing.Size(168, 45);
            this.labelShowBTCPrice.TabIndex = 4;
            this.labelShowBTCPrice.Text = "Loading...";
            // 
            // labelBTCUSDT
            // 
            this.labelBTCUSDT.AutoSize = true;
            this.labelBTCUSDT.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBTCUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelBTCUSDT.Location = new System.Drawing.Point(8, 462);
            this.labelBTCUSDT.Margin = new System.Windows.Forms.Padding(0);
            this.labelBTCUSDT.Name = "labelBTCUSDT";
            this.labelBTCUSDT.Size = new System.Drawing.Size(222, 54);
            this.labelBTCUSDT.TabIndex = 5;
            this.labelBTCUSDT.Text = "BTCUSDT -";
            // 
            // textBoxSearchCoinSymbol
            // 
            this.textBoxSearchCoinSymbol.Location = new System.Drawing.Point(30, 36);
            this.textBoxSearchCoinSymbol.Name = "textBoxSearchCoinSymbol";
            this.textBoxSearchCoinSymbol.Size = new System.Drawing.Size(163, 21);
            this.textBoxSearchCoinSymbol.TabIndex = 6;
            this.textBoxSearchCoinSymbol.Text = "BTC";
            this.textBoxSearchCoinSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchCoin
            // 
            this.btnSearchCoin.Location = new System.Drawing.Point(227, 34);
            this.btnSearchCoin.Name = "btnSearchCoin";
            this.btnSearchCoin.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCoin.TabIndex = 7;
            this.btnSearchCoin.Text = "Search";
            this.btnSearchCoin.UseVisualStyleBackColor = true;
            this.btnSearchCoin.Click += new System.EventHandler(this.btnSearchCoin_Click);
            // 
            // dataGridViewPairs
            // 
            this.dataGridViewPairs.AllowUserToAddRows = false;
            this.dataGridViewPairs.AllowUserToDeleteRows = false;
            this.dataGridViewPairs.AllowUserToResizeColumns = false;
            this.dataGridViewPairs.AllowUserToResizeRows = false;
            this.dataGridViewPairs.AutoGenerateColumns = false;
            this.dataGridViewPairs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewPairs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolDataGridViewTextBoxColumn,
            this.marketDataGridViewTextBoxColumn});
            this.dataGridViewPairs.DataSource = this.tickerBindingSource;
            this.dataGridViewPairs.Location = new System.Drawing.Point(57, 124);
            this.dataGridViewPairs.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPairs.Name = "dataGridViewPairs";
            this.dataGridViewPairs.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPairs.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPairs.RowHeadersVisible = false;
            this.dataGridViewPairs.RowTemplate.Height = 23;
            this.dataGridViewPairs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewPairs.Size = new System.Drawing.Size(200, 111);
            this.dataGridViewPairs.TabIndex = 8;
            this.dataGridViewPairs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPairs_CellContentDoubleClick);
            // 
            // labelETHUSDT
            // 
            this.labelETHUSDT.AutoSize = true;
            this.labelETHUSDT.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelETHUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelETHUSDT.Location = new System.Drawing.Point(253, 462);
            this.labelETHUSDT.Margin = new System.Windows.Forms.Padding(0);
            this.labelETHUSDT.Name = "labelETHUSDT";
            this.labelETHUSDT.Size = new System.Drawing.Size(227, 54);
            this.labelETHUSDT.TabIndex = 9;
            this.labelETHUSDT.Text = "ETHUSDT -";
            // 
            // labelXRPUSDT
            // 
            this.labelXRPUSDT.AutoSize = true;
            this.labelXRPUSDT.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXRPUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelXRPUSDT.Location = new System.Drawing.Point(492, 462);
            this.labelXRPUSDT.Margin = new System.Windows.Forms.Padding(0);
            this.labelXRPUSDT.Name = "labelXRPUSDT";
            this.labelXRPUSDT.Size = new System.Drawing.Size(229, 54);
            this.labelXRPUSDT.TabIndex = 10;
            this.labelXRPUSDT.Text = "XRPUSDT -";
            // 
            // labelADAUSDT
            // 
            this.labelADAUSDT.AutoSize = true;
            this.labelADAUSDT.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelADAUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelADAUSDT.Location = new System.Drawing.Point(732, 462);
            this.labelADAUSDT.Margin = new System.Windows.Forms.Padding(0);
            this.labelADAUSDT.Name = "labelADAUSDT";
            this.labelADAUSDT.Size = new System.Drawing.Size(236, 54);
            this.labelADAUSDT.TabIndex = 6;
            this.labelADAUSDT.Text = "ADAUSDT -";
            // 
            // labelShowETHPrice
            // 
            this.labelShowETHPrice.AutoSize = true;
            this.labelShowETHPrice.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowETHPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelShowETHPrice.Location = new System.Drawing.Point(254, 520);
            this.labelShowETHPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelShowETHPrice.Name = "labelShowETHPrice";
            this.labelShowETHPrice.Size = new System.Drawing.Size(168, 45);
            this.labelShowETHPrice.TabIndex = 11;
            this.labelShowETHPrice.Text = "Loading...";
            // 
            // labelShowXRPPrice
            // 
            this.labelShowXRPPrice.AutoSize = true;
            this.labelShowXRPPrice.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowXRPPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelShowXRPPrice.Location = new System.Drawing.Point(493, 518);
            this.labelShowXRPPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelShowXRPPrice.Name = "labelShowXRPPrice";
            this.labelShowXRPPrice.Size = new System.Drawing.Size(168, 45);
            this.labelShowXRPPrice.TabIndex = 12;
            this.labelShowXRPPrice.Text = "Loading...";
            // 
            // labelShowADAPrice
            // 
            this.labelShowADAPrice.AutoSize = true;
            this.labelShowADAPrice.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowADAPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelShowADAPrice.Location = new System.Drawing.Point(733, 520);
            this.labelShowADAPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelShowADAPrice.Name = "labelShowADAPrice";
            this.labelShowADAPrice.Size = new System.Drawing.Size(168, 45);
            this.labelShowADAPrice.TabIndex = 5;
            this.labelShowADAPrice.Text = "Loading...";
            // 
            // labelUSDTPriceOfSelectedSymbol
            // 
            this.labelUSDTPriceOfSelectedSymbol.AutoSize = true;
            this.labelUSDTPriceOfSelectedSymbol.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSDTPriceOfSelectedSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelUSDTPriceOfSelectedSymbol.Location = new System.Drawing.Point(187, 235);
            this.labelUSDTPriceOfSelectedSymbol.Name = "labelUSDTPriceOfSelectedSymbol";
            this.labelUSDTPriceOfSelectedSymbol.Size = new System.Drawing.Size(90, 23);
            this.labelUSDTPriceOfSelectedSymbol.TabIndex = 13;
            this.labelUSDTPriceOfSelectedSymbol.Text = "Loading...";
            // 
            // labelExchangeKRWToDollar
            // 
            this.labelExchangeKRWToDollar.AutoSize = true;
            this.labelExchangeKRWToDollar.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExchangeKRWToDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelExchangeKRWToDollar.Location = new System.Drawing.Point(187, 398);
            this.labelExchangeKRWToDollar.Name = "labelExchangeKRWToDollar";
            this.labelExchangeKRWToDollar.Size = new System.Drawing.Size(90, 23);
            this.labelExchangeKRWToDollar.TabIndex = 14;
            this.labelExchangeKRWToDollar.Text = "Loading...";
            // 
            // labelKimchiPremium
            // 
            this.labelKimchiPremium.AutoSize = true;
            this.labelKimchiPremium.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKimchiPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKimchiPremium.Location = new System.Drawing.Point(187, 367);
            this.labelKimchiPremium.Name = "labelKimchiPremium";
            this.labelKimchiPremium.Size = new System.Drawing.Size(90, 23);
            this.labelKimchiPremium.TabIndex = 15;
            this.labelKimchiPremium.Text = "Loading...";
            // 
            // labelLoadTime
            // 
            this.labelLoadTime.AutoSize = true;
            this.labelLoadTime.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelLoadTime.Location = new System.Drawing.Point(671, 435);
            this.labelLoadTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadTime.Name = "labelLoadTime";
            this.labelLoadTime.Size = new System.Drawing.Size(78, 21);
            this.labelLoadTime.TabIndex = 16;
            this.labelLoadTime.Text = "로드 시각";
            // 
            // labelKRWPriceOfSelctedSymbol
            // 
            this.labelKRWPriceOfSelctedSymbol.AutoSize = true;
            this.labelKRWPriceOfSelctedSymbol.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKRWPriceOfSelctedSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelKRWPriceOfSelctedSymbol.Location = new System.Drawing.Point(187, 269);
            this.labelKRWPriceOfSelctedSymbol.Name = "labelKRWPriceOfSelctedSymbol";
            this.labelKRWPriceOfSelctedSymbol.Size = new System.Drawing.Size(90, 23);
            this.labelKRWPriceOfSelctedSymbol.TabIndex = 17;
            this.labelKRWPriceOfSelctedSymbol.Text = "Loading...";
            // 
            // labelExchangedKRWPrice
            // 
            this.labelExchangedKRWPrice.AutoSize = true;
            this.labelExchangedKRWPrice.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExchangedKRWPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelExchangedKRWPrice.Location = new System.Drawing.Point(187, 301);
            this.labelExchangedKRWPrice.Name = "labelExchangedKRWPrice";
            this.labelExchangedKRWPrice.Size = new System.Drawing.Size(90, 23);
            this.labelExchangedKRWPrice.TabIndex = 18;
            this.labelExchangedKRWPrice.Text = "Loading...";
            // 
            // labelDifferencePrice
            // 
            this.labelDifferencePrice.AutoSize = true;
            this.labelDifferencePrice.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifferencePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.labelDifferencePrice.Location = new System.Drawing.Point(187, 334);
            this.labelDifferencePrice.Name = "labelDifferencePrice";
            this.labelDifferencePrice.Size = new System.Drawing.Size(90, 23);
            this.labelDifferencePrice.TabIndex = 19;
            this.labelDifferencePrice.Text = "Loading...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(17, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "바이낸스(USDT)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(17, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "업비트(KRW)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(17, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "교환 가격(KRW)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(17, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "가격 차이(KRW)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(17, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "김치 프리미엄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(17, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "환율(1$ = 1USDT)";
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
            // CryptosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDifferencePrice);
            this.Controls.Add(this.labelExchangedKRWPrice);
            this.Controls.Add(this.labelKRWPriceOfSelctedSymbol);
            this.Controls.Add(this.labelLoadTime);
            this.Controls.Add(this.labelKimchiPremium);
            this.Controls.Add(this.labelExchangeKRWToDollar);
            this.Controls.Add(this.labelUSDTPriceOfSelectedSymbol);
            this.Controls.Add(this.labelShowADAPrice);
            this.Controls.Add(this.labelShowXRPPrice);
            this.Controls.Add(this.labelShowETHPrice);
            this.Controls.Add(this.labelADAUSDT);
            this.Controls.Add(this.labelXRPUSDT);
            this.Controls.Add(this.labelETHUSDT);
            this.Controls.Add(this.dataGridViewPairs);
            this.Controls.Add(this.btnSearchCoin);
            this.Controls.Add(this.textBoxSearchCoinSymbol);
            this.Controls.Add(this.labelShowBTCPrice);
            this.Controls.Add(this.labelBTCUSDT);
            this.Controls.Add(this.labelCurrentChart);
            this.Controls.Add(this.labelChartDescription);
            this.Controls.Add(this.panelMainWebViewerByCefSharp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CryptosForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CryptosForm_FormClosing);
            this.Load += new System.EventHandler(this.CryptosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainWebViewerByCefSharp;
        private System.Windows.Forms.Label labelChartDescription;
        private System.Windows.Forms.Label labelCurrentChart;
        private System.Windows.Forms.Label labelShowBTCPrice;
        private System.Windows.Forms.Label labelBTCUSDT;
        private System.Windows.Forms.TextBox textBoxSearchCoinSymbol;
        private System.Windows.Forms.Button btnSearchCoin;
        private System.Windows.Forms.DataGridView dataGridViewPairs;
        private System.Windows.Forms.BindingSource tickerBindingSource;
        private System.Windows.Forms.Label labelETHUSDT;
        private System.Windows.Forms.Label labelXRPUSDT;
        private System.Windows.Forms.Label labelADAUSDT;
        private System.Windows.Forms.Label labelShowETHPrice;
        private System.Windows.Forms.Label labelShowXRPPrice;
        private System.Windows.Forms.Label labelShowADAPrice;
        private System.Windows.Forms.Label labelUSDTPriceOfSelectedSymbol;
        private System.Windows.Forms.Label labelExchangeKRWToDollar;
        private System.Windows.Forms.Label labelKimchiPremium;
        private System.Windows.Forms.Label labelLoadTime;
        private System.Windows.Forms.Label labelKRWPriceOfSelctedSymbol;
        private System.Windows.Forms.Label labelExchangedKRWPrice;
        private System.Windows.Forms.Label labelDifferencePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}