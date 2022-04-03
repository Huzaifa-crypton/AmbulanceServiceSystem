namespace Ambulance_Service_System
{
    partial class UserForm
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPages = new Bunifu.UI.WinForms.BunifuPages();
            this.Call = new System.Windows.Forms.TabPage();
            this.messageTextBox = new Guna.UI.WinForms.GunaLabel();
            this.emergencyTypeTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.citiesDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.closeBtn1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.makeCallBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.History = new System.Windows.Forms.TabPage();
            this.closeBtn2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.callsDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.logoutBtn = new Guna.UI.WinForms.GunaButton();
            this.historyBtn = new Guna.UI.WinForms.GunaButton();
            this.callBtn = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuPages.SuspendLayout();
            this.Call.SuspendLayout();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callsDataGridView)).BeginInit();
            this.bunifuShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPages
            // 
            this.bunifuPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages.AllowTransitions = false;
            this.bunifuPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPages.Controls.Add(this.Call);
            this.bunifuPages.Controls.Add(this.History);
            this.bunifuPages.Location = new System.Drawing.Point(280, -1);
            this.bunifuPages.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPages.Multiline = true;
            this.bunifuPages.Name = "bunifuPages";
            this.bunifuPages.Page = this.Call;
            this.bunifuPages.PageIndex = 0;
            this.bunifuPages.PageName = "Call";
            this.bunifuPages.PageTitle = "Call";
            this.bunifuPages.SelectedIndex = 0;
            this.bunifuPages.Size = new System.Drawing.Size(924, 619);
            this.bunifuPages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages.Transition = animation1;
            this.bunifuPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Call
            // 
            this.Call.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Call.Controls.Add(this.messageTextBox);
            this.Call.Controls.Add(this.emergencyTypeTextBox);
            this.Call.Controls.Add(this.citiesDropdown);
            this.Call.Controls.Add(this.closeBtn1);
            this.Call.Controls.Add(this.makeCallBtn);
            this.Call.Controls.Add(this.gunaLabel2);
            this.Call.Location = new System.Drawing.Point(4, 4);
            this.Call.Margin = new System.Windows.Forms.Padding(4);
            this.Call.Name = "Call";
            this.Call.Padding = new System.Windows.Forms.Padding(4);
            this.Call.Size = new System.Drawing.Size(916, 590);
            this.Call.TabIndex = 0;
            this.Call.Text = "Call";
            // 
            // messageTextBox
            // 
            this.messageTextBox.AutoSize = true;
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.messageTextBox.Location = new System.Drawing.Point(69, 137);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(693, 28);
            this.messageTextBox.TabIndex = 37;
            this.messageTextBox.Text = "When You Arrived at the Hospital with OUR Ambulance then Please Click here..\r\n";
            this.messageTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageTextBox.Visible = false;
            // 
            // emergencyTypeTextBox
            // 
            this.emergencyTypeTextBox.AcceptsReturn = false;
            this.emergencyTypeTextBox.AcceptsTab = false;
            this.emergencyTypeTextBox.AnimationSpeed = 200;
            this.emergencyTypeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emergencyTypeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emergencyTypeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emergencyTypeTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emergencyTypeTextBox.BackgroundImage")));
            this.emergencyTypeTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.emergencyTypeTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.emergencyTypeTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.emergencyTypeTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.emergencyTypeTextBox.BorderRadius = 1;
            this.emergencyTypeTextBox.BorderThickness = 1;
            this.emergencyTypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emergencyTypeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emergencyTypeTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 10.25F);
            this.emergencyTypeTextBox.DefaultText = "";
            this.emergencyTypeTextBox.FillColor = System.Drawing.Color.White;
            this.emergencyTypeTextBox.HideSelection = true;
            this.emergencyTypeTextBox.IconLeft = null;
            this.emergencyTypeTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.emergencyTypeTextBox.IconPadding = 2;
            this.emergencyTypeTextBox.IconRight = null;
            this.emergencyTypeTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.emergencyTypeTextBox.Lines = new string[0];
            this.emergencyTypeTextBox.Location = new System.Drawing.Point(156, 145);
            this.emergencyTypeTextBox.MaxLength = 32767;
            this.emergencyTypeTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.emergencyTypeTextBox.Modified = false;
            this.emergencyTypeTextBox.Multiline = true;
            this.emergencyTypeTextBox.Name = "emergencyTypeTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emergencyTypeTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.emergencyTypeTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emergencyTypeTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emergencyTypeTextBox.OnIdleState = stateProperties4;
            this.emergencyTypeTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.emergencyTypeTextBox.PasswordChar = '\0';
            this.emergencyTypeTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emergencyTypeTextBox.PlaceholderText = "Emergency..";
            this.emergencyTypeTextBox.ReadOnly = false;
            this.emergencyTypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emergencyTypeTextBox.SelectedText = "";
            this.emergencyTypeTextBox.SelectionLength = 0;
            this.emergencyTypeTextBox.SelectionStart = 0;
            this.emergencyTypeTextBox.ShortcutsEnabled = true;
            this.emergencyTypeTextBox.Size = new System.Drawing.Size(373, 66);
            this.emergencyTypeTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.emergencyTypeTextBox.TabIndex = 36;
            this.emergencyTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emergencyTypeTextBox.TextMarginBottom = 0;
            this.emergencyTypeTextBox.TextMarginLeft = 3;
            this.emergencyTypeTextBox.TextMarginTop = 0;
            this.emergencyTypeTextBox.TextPlaceholder = "Emergency..";
            this.emergencyTypeTextBox.UseSystemPasswordChar = false;
            this.emergencyTypeTextBox.WordWrap = true;
            // 
            // citiesDropdown
            // 
            this.citiesDropdown.BackColor = System.Drawing.Color.Transparent;
            this.citiesDropdown.BackgroundColor = System.Drawing.Color.White;
            this.citiesDropdown.BorderColor = System.Drawing.Color.Silver;
            this.citiesDropdown.BorderRadius = 1;
            this.citiesDropdown.Color = System.Drawing.Color.Silver;
            this.citiesDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.citiesDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.citiesDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.citiesDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.citiesDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.citiesDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.citiesDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.citiesDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.citiesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.citiesDropdown.FillDropDown = true;
            this.citiesDropdown.FillIndicator = false;
            this.citiesDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citiesDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.citiesDropdown.ForeColor = System.Drawing.Color.Black;
            this.citiesDropdown.FormattingEnabled = true;
            this.citiesDropdown.Icon = null;
            this.citiesDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.citiesDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.citiesDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.citiesDropdown.ItemBackColor = System.Drawing.Color.White;
            this.citiesDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.citiesDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.citiesDropdown.ItemHeight = 26;
            this.citiesDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.citiesDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.citiesDropdown.Items.AddRange(new object[] {
            "Select City"});
            this.citiesDropdown.ItemTopMargin = 3;
            this.citiesDropdown.Location = new System.Drawing.Point(156, 102);
            this.citiesDropdown.Name = "citiesDropdown";
            this.citiesDropdown.Size = new System.Drawing.Size(373, 32);
            this.citiesDropdown.TabIndex = 35;
            this.citiesDropdown.Text = "Select City";
            this.citiesDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.citiesDropdown.TextLeftMargin = 5;
            // 
            // closeBtn1
            // 
            this.closeBtn1.CheckedState.Parent = this.closeBtn1;
            this.closeBtn1.CustomImages.Parent = this.closeBtn1;
            this.closeBtn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closeBtn1.ForeColor = System.Drawing.Color.White;
            this.closeBtn1.HoverState.Parent = this.closeBtn1;
            this.closeBtn1.Location = new System.Drawing.Point(861, 1);
            this.closeBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn1.ShadowDecoration.Parent = this.closeBtn1;
            this.closeBtn1.Size = new System.Drawing.Size(59, 31);
            this.closeBtn1.TabIndex = 34;
            this.closeBtn1.Text = "X";
            this.closeBtn1.Click += new System.EventHandler(this.closeBtn1_Click);
            // 
            // makeCallBtn
            // 
            this.makeCallBtn.CheckedState.Parent = this.makeCallBtn;
            this.makeCallBtn.CustomImages.Parent = this.makeCallBtn;
            this.makeCallBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.makeCallBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeCallBtn.ForeColor = System.Drawing.Color.White;
            this.makeCallBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.makeCallBtn.HoverState.Parent = this.makeCallBtn;
            this.makeCallBtn.Location = new System.Drawing.Point(319, 266);
            this.makeCallBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeCallBtn.Name = "makeCallBtn";
            this.makeCallBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.makeCallBtn.ShadowDecoration.Parent = this.makeCallBtn;
            this.makeCallBtn.Size = new System.Drawing.Size(288, 265);
            this.makeCallBtn.TabIndex = 1;
            this.makeCallBtn.Text = "Emergency Call";
            this.makeCallBtn.Click += new System.EventHandler(this.makeCallBtn_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(9, 9);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 37);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Call";
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.WhiteSmoke;
            this.History.Controls.Add(this.closeBtn2);
            this.History.Controls.Add(this.callsDataGridView);
            this.History.Controls.Add(this.gunaLabel4);
            this.History.Location = new System.Drawing.Point(4, 4);
            this.History.Margin = new System.Windows.Forms.Padding(4);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(916, 590);
            this.History.TabIndex = 2;
            this.History.Text = "History";
            // 
            // closeBtn2
            // 
            this.closeBtn2.CheckedState.Parent = this.closeBtn2;
            this.closeBtn2.CustomImages.Parent = this.closeBtn2;
            this.closeBtn2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closeBtn2.ForeColor = System.Drawing.Color.White;
            this.closeBtn2.HoverState.Parent = this.closeBtn2;
            this.closeBtn2.Location = new System.Drawing.Point(861, 1);
            this.closeBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn2.Name = "closeBtn2";
            this.closeBtn2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn2.ShadowDecoration.Parent = this.closeBtn2;
            this.closeBtn2.Size = new System.Drawing.Size(59, 31);
            this.closeBtn2.TabIndex = 34;
            this.closeBtn2.Text = "X";
            this.closeBtn2.Click += new System.EventHandler(this.closeBtn2_Click);
            // 
            // callsDataGridView
            // 
            this.callsDataGridView.AllowCustomTheming = false;
            this.callsDataGridView.AllowUserToDeleteRows = false;
            this.callsDataGridView.AllowUserToResizeColumns = false;
            this.callsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.callsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.callsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.callsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.callsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.callsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.callsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.callsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.callsDataGridView.ColumnHeadersHeight = 40;
            this.callsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            this.callsDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.callsDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.callsDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.callsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.callsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.callsDataGridView.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.callsDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.callsDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.callsDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.callsDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.callsDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.callsDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.callsDataGridView.CurrentTheme.Name = null;
            this.callsDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.callsDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.callsDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.callsDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.callsDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.callsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.callsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.callsDataGridView.EnableHeadersVisualStyles = false;
            this.callsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.callsDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.callsDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.callsDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.callsDataGridView.Location = new System.Drawing.Point(8, 38);
            this.callsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.callsDataGridView.Name = "callsDataGridView";
            this.callsDataGridView.ReadOnly = true;
            this.callsDataGridView.RowHeadersVisible = false;
            this.callsDataGridView.RowHeadersWidth = 51;
            this.callsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.callsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.callsDataGridView.RowTemplate.Height = 40;
            this.callsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callsDataGridView.Size = new System.Drawing.Size(667, 461);
            this.callsDataGridView.TabIndex = 3;
            this.callsDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Form Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 93;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Location";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 116;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 179;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Call Time";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 122;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Call Received Time";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 208;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "Ambulance Dispatch Time";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 276;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column9.HeaderText = "Ambulance Arrival Time";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 255;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(4, 7);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(180, 37);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Calls History";
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.BorderRadius = 1;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Controls.Add(this.gunaLabel19);
            this.bunifuShadowPanel2.Controls.Add(this.logoutBtn);
            this.bunifuShadowPanel2.Controls.Add(this.historyBtn);
            this.bunifuShadowPanel2.Controls.Add(this.callBtn);
            this.bunifuShadowPanel2.Controls.Add(this.pictureBox2);
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(-17, -5);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 5;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(296, 623);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 8;
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel19.Location = new System.Drawing.Point(125, 169);
            this.gunaLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel19.TabIndex = 40;
            this.gunaLabel19.Text = "User";
            // 
            // logoutBtn
            // 
            this.logoutBtn.AnimationHoverSpeed = 0.07F;
            this.logoutBtn.AnimationSpeed = 0.03F;
            this.logoutBtn.BaseColor = System.Drawing.Color.White;
            this.logoutBtn.BorderColor = System.Drawing.Color.Black;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Image = global::Ambulance_Service_System.Properties.Resources.power_off;
            this.logoutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutBtn.Location = new System.Drawing.Point(16, 306);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.logoutBtn.OnHoverImage = null;
            this.logoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.logoutBtn.Size = new System.Drawing.Size(272, 52);
            this.logoutBtn.TabIndex = 22;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.AnimationHoverSpeed = 0.07F;
            this.historyBtn.AnimationSpeed = 0.03F;
            this.historyBtn.BaseColor = System.Drawing.Color.White;
            this.historyBtn.BorderColor = System.Drawing.Color.Black;
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.historyBtn.FocusedColor = System.Drawing.Color.Empty;
            this.historyBtn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.historyBtn.ForeColor = System.Drawing.Color.Black;
            this.historyBtn.Image = global::Ambulance_Service_System.Properties.Resources.bullet_list;
            this.historyBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.historyBtn.Location = new System.Drawing.Point(16, 255);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.historyBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.historyBtn.OnHoverImage = null;
            this.historyBtn.OnPressedColor = System.Drawing.Color.Black;
            this.historyBtn.Size = new System.Drawing.Size(272, 52);
            this.historyBtn.TabIndex = 20;
            this.historyBtn.Text = "Calls History";
            this.historyBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // callBtn
            // 
            this.callBtn.AnimationHoverSpeed = 0.07F;
            this.callBtn.AnimationSpeed = 0.03F;
            this.callBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.callBtn.BorderColor = System.Drawing.Color.Black;
            this.callBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.callBtn.FocusedColor = System.Drawing.Color.Empty;
            this.callBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.callBtn.ForeColor = System.Drawing.Color.Black;
            this.callBtn.Image = global::Ambulance_Service_System.Properties.Resources.phone_receiver_silhouette;
            this.callBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.callBtn.Location = new System.Drawing.Point(16, 203);
            this.callBtn.Margin = new System.Windows.Forms.Padding(4);
            this.callBtn.Name = "callBtn";
            this.callBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.callBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.callBtn.OnHoverForeColor = System.Drawing.Color.Black;
            this.callBtn.OnHoverImage = null;
            this.callBtn.OnPressedColor = System.Drawing.Color.Black;
            this.callBtn.Size = new System.Drawing.Size(272, 52);
            this.callBtn.TabIndex = 17;
            this.callBtn.Text = "Call";
            this.callBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.callBtn.Click += new System.EventHandler(this.callBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Ambulance_Service_System.Properties.Resources.large_logo;
            this.pictureBox2.Location = new System.Drawing.Point(17, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.Controls.Add(this.bunifuPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.VisibleChanged += new System.EventHandler(this.UserForm_VisibleChanged);
            this.bunifuPages.ResumeLayout(false);
            this.Call.ResumeLayout(false);
            this.Call.PerformLayout();
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callsDataGridView)).EndInit();
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.bunifuShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPages bunifuPages;
        private System.Windows.Forms.TabPage Call;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.TabPage History;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2CircleButton makeCallBtn;
        private Bunifu.UI.WinForms.BunifuDataGridView callsDataGridView;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private Guna.UI.WinForms.GunaButton logoutBtn;
        private Guna.UI.WinForms.GunaButton historyBtn;
        private Guna.UI.WinForms.GunaButton callBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TileButton closeBtn1;
        private Guna.UI2.WinForms.Guna2TileButton closeBtn2;
        private Bunifu.UI.WinForms.BunifuDropdown citiesDropdown;
        private Bunifu.UI.WinForms.BunifuTextBox emergencyTypeTextBox;
        private Guna.UI.WinForms.GunaLabel messageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
<<<<<<< HEAD
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Guna.UI2.WinForms.Guna2TileButton closeBtn1;
        private Guna.UI2.WinForms.Guna2TileButton closeBtn2;
        private Bunifu.UI.WinForms.BunifuDropdown selectCity;
        private Bunifu.UI.WinForms.BunifuTextBox emrgencyType;
>>>>>>> 741f3e41a654f02f75aeb05538a74915858d404d
    }
}