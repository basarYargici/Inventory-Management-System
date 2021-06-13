
namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbExit = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.tblLButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCustomers = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnProducts = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnCategories = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnOrders = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnEmployees = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tblBigger = new System.Windows.Forms.TableLayoutPanel();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tblLButtons.SuspendLayout();
            this.tblBigger.SuspendLayout();
            this.hostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.lblProgramName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 121);
            this.panel1.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AllowAnimations = true;
            this.btnLogOut.AllowMouseEffects = true;
            this.btnLogOut.AllowToggling = false;
            this.btnLogOut.AnimationSpeed = 200;
            this.btnLogOut.AutoGenerateColors = false;
            this.btnLogOut.AutoRoundBorders = false;
            this.btnLogOut.AutoSizeLeftIcon = true;
            this.btnLogOut.AutoSizeRightIcon = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackColor1 = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.ButtonText = "<-- LOG OUT";
            this.btnLogOut.ButtonTextMarginLeft = 0;
            this.btnLogOut.ColorContrastOnClick = 45;
            this.btnLogOut.ColorContrastOnHover = 45;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogOut.CustomizableEdges = borderEdges1;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogOut.IconMarginLeft = 11;
            this.btnLogOut.IconPadding = 10;
            this.btnLogOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogOut.IconSize = 25;
            this.btnLogOut.IdleBorderColor = System.Drawing.Color.SlateBlue;
            this.btnLogOut.IdleBorderRadius = 50;
            this.btnLogOut.IdleBorderThickness = 1;
            this.btnLogOut.IdleFillColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.IdleIconLeftImage = null;
            this.btnLogOut.IdleIconRightImage = null;
            this.btnLogOut.IndicateFocus = false;
            this.btnLogOut.Location = new System.Drawing.Point(24, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogOut.OnDisabledState.BorderRadius = 50;
            this.btnLogOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnDisabledState.BorderThickness = 1;
            this.btnLogOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogOut.OnDisabledState.IconLeftImage = null;
            this.btnLogOut.OnDisabledState.IconRightImage = null;
            this.btnLogOut.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogOut.onHoverState.BorderRadius = 50;
            this.btnLogOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.onHoverState.BorderThickness = 1;
            this.btnLogOut.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogOut.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.onHoverState.IconLeftImage = null;
            this.btnLogOut.onHoverState.IconRightImage = null;
            this.btnLogOut.OnIdleState.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnLogOut.OnIdleState.BorderRadius = 50;
            this.btnLogOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnIdleState.BorderThickness = 1;
            this.btnLogOut.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnIdleState.IconLeftImage = null;
            this.btnLogOut.OnIdleState.IconRightImage = null;
            this.btnLogOut.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogOut.OnPressedState.BorderRadius = 50;
            this.btnLogOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogOut.OnPressedState.BorderThickness = 1;
            this.btnLogOut.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogOut.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.OnPressedState.IconLeftImage = null;
            this.btnLogOut.OnPressedState.IconRightImage = null;
            this.btnLogOut.Size = new System.Drawing.Size(137, 63);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.TextMarginLeft = 0;
            this.btnLogOut.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogOut.UseDefaultRadiusAndThickness = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(1317, 8);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(66, 70);
            this.lbExit.TabIndex = 3;
            this.lbExit.Text = "X";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click_1);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgramName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.White;
            this.lblProgramName.Location = new System.Drawing.Point(275, 15);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(886, 55);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "INVENTORY MANAGAMENT SYSTEM";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblLButtons
            // 
            this.tblLButtons.AutoScroll = true;
            this.tblLButtons.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.tblLButtons.AutoSize = true;
            this.tblLButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLButtons.ColumnCount = 1;
            this.tblLButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLButtons.Controls.Add(this.btnCustomers, 0, 3);
            this.tblLButtons.Controls.Add(this.btnProducts, 0, 0);
            this.tblLButtons.Controls.Add(this.btnCategories, 0, 2);
            this.tblLButtons.Controls.Add(this.btnOrders, 0, 1);
            this.tblLButtons.Controls.Add(this.btnEmployees, 0, 4);
            this.tblLButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLButtons.Location = new System.Drawing.Point(3, 3);
            this.tblLButtons.Name = "tblLButtons";
            this.tblLButtons.RowCount = 5;
            this.tblLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLButtons.Size = new System.Drawing.Size(238, 707);
            this.tblLButtons.TabIndex = 7;
            // 
            // btnCustomers
            // 
            this.btnCustomers.ActiveImage = null;
            this.btnCustomers.AllowAnimations = true;
            this.btnCustomers.AllowBuffering = false;
            this.btnCustomers.AllowToggling = false;
            this.btnCustomers.AllowZooming = true;
            this.btnCustomers.AllowZoomingOnFocus = false;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomers.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.ErrorImage")));
            this.btnCustomers.FadeWhenInactive = false;
            this.btnCustomers.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageActive = null;
            this.btnCustomers.ImageLocation = null;
            this.btnCustomers.ImageMargin = 40;
            this.btnCustomers.ImageSize = new System.Drawing.Size(250, 129);
            this.btnCustomers.ImageZoomSize = new System.Drawing.Size(290, 169);
            this.btnCustomers.InitialImage = global::InventoryManagementSystem.Properties.Resources._lock;
            this.btnCustomers.Location = new System.Drawing.Point(4, 533);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Rotation = 0;
            this.btnCustomers.ShowActiveImage = true;
            this.btnCustomers.ShowCursorChanges = true;
            this.btnCustomers.ShowImageBorders = true;
            this.btnCustomers.ShowSizeMarkers = false;
            this.btnCustomers.Size = new System.Drawing.Size(290, 169);
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.ToolTipText = "CUSTOMERS";
            this.btnCustomers.WaitOnLoad = false;
            this.btnCustomers.Zoom = 40;
            this.btnCustomers.ZoomSpeed = 10;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.ActiveImage = null;
            this.btnProducts.AllowAnimations = true;
            this.btnProducts.AllowBuffering = false;
            this.btnProducts.AllowToggling = false;
            this.btnProducts.AllowZooming = true;
            this.btnProducts.AllowZoomingOnFocus = false;
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.ErrorImage")));
            this.btnProducts.FadeWhenInactive = false;
            this.btnProducts.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageActive = null;
            this.btnProducts.ImageLocation = null;
            this.btnProducts.ImageMargin = 40;
            this.btnProducts.ImageSize = new System.Drawing.Size(250, 129);
            this.btnProducts.ImageZoomSize = new System.Drawing.Size(290, 169);
            this.btnProducts.InitialImage = global::InventoryManagementSystem.Properties.Resources._lock;
            this.btnProducts.Location = new System.Drawing.Point(4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Rotation = 0;
            this.btnProducts.ShowActiveImage = true;
            this.btnProducts.ShowCursorChanges = true;
            this.btnProducts.ShowImageBorders = true;
            this.btnProducts.ShowSizeMarkers = false;
            this.btnProducts.Size = new System.Drawing.Size(290, 169);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.ToolTipText = "PRODUCTS";
            this.btnProducts.WaitOnLoad = false;
            this.btnProducts.Zoom = 40;
            this.btnProducts.ZoomSpeed = 10;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.ActiveImage = null;
            this.btnCategories.AllowAnimations = true;
            this.btnCategories.AllowBuffering = false;
            this.btnCategories.AllowToggling = false;
            this.btnCategories.AllowZooming = true;
            this.btnCategories.AllowZoomingOnFocus = false;
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategories.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCategories.ErrorImage")));
            this.btnCategories.FadeWhenInactive = false;
            this.btnCategories.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageActive = null;
            this.btnCategories.ImageLocation = null;
            this.btnCategories.ImageMargin = 40;
            this.btnCategories.ImageSize = new System.Drawing.Size(250, 129);
            this.btnCategories.ImageZoomSize = new System.Drawing.Size(290, 169);
            this.btnCategories.InitialImage = global::InventoryManagementSystem.Properties.Resources._lock;
            this.btnCategories.Location = new System.Drawing.Point(4, 356);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Rotation = 0;
            this.btnCategories.ShowActiveImage = true;
            this.btnCategories.ShowCursorChanges = true;
            this.btnCategories.ShowImageBorders = true;
            this.btnCategories.ShowSizeMarkers = false;
            this.btnCategories.Size = new System.Drawing.Size(290, 169);
            this.btnCategories.TabIndex = 7;
            this.btnCategories.ToolTipText = "CATEGORIES";
            this.btnCategories.WaitOnLoad = false;
            this.btnCategories.Zoom = 40;
            this.btnCategories.ZoomSpeed = 10;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.ActiveImage = null;
            this.btnOrders.AllowAnimations = true;
            this.btnOrders.AllowBuffering = false;
            this.btnOrders.AllowToggling = false;
            this.btnOrders.AllowZooming = true;
            this.btnOrders.AllowZoomingOnFocus = false;
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnOrders.ErrorImage")));
            this.btnOrders.FadeWhenInactive = false;
            this.btnOrders.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageActive = null;
            this.btnOrders.ImageLocation = null;
            this.btnOrders.ImageMargin = 40;
            this.btnOrders.ImageSize = new System.Drawing.Size(250, 129);
            this.btnOrders.ImageZoomSize = new System.Drawing.Size(290, 169);
            this.btnOrders.InitialImage = global::InventoryManagementSystem.Properties.Resources._lock;
            this.btnOrders.Location = new System.Drawing.Point(4, 180);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Rotation = 0;
            this.btnOrders.ShowActiveImage = true;
            this.btnOrders.ShowCursorChanges = true;
            this.btnOrders.ShowImageBorders = true;
            this.btnOrders.ShowSizeMarkers = false;
            this.btnOrders.Size = new System.Drawing.Size(290, 169);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.ToolTipText = "ORDER HISTORY";
            this.btnOrders.WaitOnLoad = false;
            this.btnOrders.Zoom = 40;
            this.btnOrders.ZoomSpeed = 10;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.ActiveImage = null;
            this.btnEmployees.AllowAnimations = true;
            this.btnEmployees.AllowBuffering = false;
            this.btnEmployees.AllowToggling = false;
            this.btnEmployees.AllowZooming = true;
            this.btnEmployees.AllowZoomingOnFocus = false;
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployees.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.ErrorImage")));
            this.btnEmployees.FadeWhenInactive = false;
            this.btnEmployees.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageActive = null;
            this.btnEmployees.ImageLocation = null;
            this.btnEmployees.ImageMargin = 40;
            this.btnEmployees.ImageSize = new System.Drawing.Size(250, 131);
            this.btnEmployees.ImageZoomSize = new System.Drawing.Size(290, 171);
            this.btnEmployees.InitialImage = global::InventoryManagementSystem.Properties.Resources._lock;
            this.btnEmployees.Location = new System.Drawing.Point(4, 709);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Rotation = 0;
            this.btnEmployees.ShowActiveImage = true;
            this.btnEmployees.ShowCursorChanges = true;
            this.btnEmployees.ShowImageBorders = true;
            this.btnEmployees.ShowSizeMarkers = false;
            this.btnEmployees.Size = new System.Drawing.Size(290, 171);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.ToolTipText = "EMPLOYEES";
            this.btnEmployees.WaitOnLoad = false;
            this.btnEmployees.Zoom = 40;
            this.btnEmployees.ZoomSpeed = 10;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // tblBigger
            // 
            this.tblBigger.ColumnCount = 2;
            this.tblBigger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.90821F));
            this.tblBigger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.09179F));
            this.tblBigger.Controls.Add(this.tblLButtons, 0, 0);
            this.tblBigger.Controls.Add(this.hostPanel, 1, 0);
            this.tblBigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBigger.Location = new System.Drawing.Point(0, 121);
            this.tblBigger.Name = "tblBigger";
            this.tblBigger.RowCount = 1;
            this.tblBigger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBigger.Size = new System.Drawing.Size(1449, 713);
            this.tblBigger.TabIndex = 8;
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hostPanel.Controls.Add(this.label1);
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(247, 3);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(1199, 707);
            this.hostPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(504, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1449, 834);
            this.Controls.Add(this.tblBigger);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblLButtons.ResumeLayout(false);
            this.tblBigger.ResumeLayout(false);
            this.tblBigger.PerformLayout();
            this.hostPanel.ResumeLayout(false);
            this.hostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btnProducts;
        private Bunifu.UI.WinForms.BunifuImageButton btnCategories;
        private Bunifu.UI.WinForms.BunifuImageButton btnOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TableLayoutPanel tblLButtons;
        private System.Windows.Forms.TableLayoutPanel tblBigger;
        private System.Windows.Forms.Panel hostPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogOut;
        private Bunifu.UI.WinForms.BunifuImageButton btnEmployees;
        private Bunifu.UI.WinForms.BunifuImageButton btnCustomers;
    }
}