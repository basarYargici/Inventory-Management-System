
namespace InventoryManagementSystem
{
    partial class CustomerProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProductsForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productsTableAdapter = new InventoryManagementSystem.finalDBDataSetTableAdapters.productsTableAdapter();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalDBDataSet = new InventoryManagementSystem.finalDBDataSet();
            this.categoriesTableAdapter = new InventoryManagementSystem.finalDBDataSetTableAdapters.categoriesTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tblBack = new System.Windows.Forms.TableLayoutPanel();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuy = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbPiece = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.finalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.tblBack.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.tblRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "categories";
            this.categoriesBindingSource1.DataSource = this.finalDBDataSet;
            // 
            // finalDBDataSet
            // 
            this.finalDBDataSet.DataSetName = "finalDBDataSet";
            this.finalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.finalDBDataSet;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.finalDBDataSet;
            // 
            // tbDescription
            // 
            this.tbDescription.AcceptsReturn = false;
            this.tbDescription.AcceptsTab = false;
            this.tbDescription.AnimationSpeed = 200;
            this.tbDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDescription.BackgroundImage")));
            this.tbDescription.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbDescription.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbDescription.BorderRadius = 1;
            this.tbDescription.BorderThickness = 1;
            this.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
            this.tbDescription.DefaultText = "";
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDescription.HideSelection = true;
            this.tbDescription.IconLeft = null;
            this.tbDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.IconPadding = 10;
            this.tbDescription.IconRight = null;
            this.tbDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.Lines = new string[0];
            this.tbDescription.Location = new System.Drawing.Point(3, 190);
            this.tbDescription.MaxLength = 32767;
            this.tbDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbDescription.Modified = false;
            this.tbDescription.Multiline = false;
            this.tbDescription.Name = "tbDescription";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbDescription.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbDescription.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbDescription.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbDescription.OnIdleState = stateProperties16;
            this.tbDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbDescription.PlaceholderText = "Product Description";
            this.tbDescription.ReadOnly = false;
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.ShortcutsEnabled = true;
            this.tbDescription.Size = new System.Drawing.Size(344, 115);
            this.tbDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbDescription.TabIndex = 39;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescription.TextMarginBottom = 0;
            this.tbDescription.TextMarginLeft = 3;
            this.tbDescription.TextMarginTop = 0;
            this.tbDescription.TextPlaceholder = "Product Description";
            this.tbDescription.UseSystemPasswordChar = false;
            this.tbDescription.WordWrap = true;
            // 
            // tblBack
            // 
            this.tblBack.ColumnCount = 2;
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblBack.Controls.Add(this.tblLeft, 0, 0);
            this.tblBack.Controls.Add(this.tblRight, 1, 0);
            this.tblBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBack.Location = new System.Drawing.Point(0, 0);
            this.tblBack.Name = "tblBack";
            this.tblBack.RowCount = 1;
            this.tblBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBack.Size = new System.Drawing.Size(1189, 702);
            this.tblBack.TabIndex = 5;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.label2, 0, 4);
            this.tblLeft.Controls.Add(this.btnBuy, 0, 6);
            this.tblLeft.Controls.Add(this.cbPiece, 0, 5);
            this.tblLeft.Controls.Add(this.cbCategory, 0, 1);
            this.tblLeft.Controls.Add(this.tbDescription, 0, 2);
            this.tblLeft.Controls.Add(this.tbPrice, 0, 3);
            this.tblLeft.Controls.Add(this.tbName, 0, 0);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(3, 3);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 7;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38697F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.516272F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38699F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38699F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41953F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.516272F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.38699F));
            this.tblLeft.Size = new System.Drawing.Size(350, 696);
            this.tblLeft.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(3, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 79);
            this.label2.TabIndex = 57;
            this.label2.Text = "Number Of Product To Purchase:";
            // 
            // btnBuy
            // 
            this.btnBuy.AllowAnimations = true;
            this.btnBuy.AllowMouseEffects = true;
            this.btnBuy.AllowToggling = false;
            this.btnBuy.AnimationSpeed = 200;
            this.btnBuy.AutoGenerateColors = false;
            this.btnBuy.AutoRoundBorders = false;
            this.btnBuy.AutoSizeLeftIcon = true;
            this.btnBuy.AutoSizeRightIcon = true;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.ButtonText = "Buy Product";
            this.btnBuy.ButtonTextMarginLeft = 0;
            this.btnBuy.ColorContrastOnClick = 45;
            this.btnBuy.ColorContrastOnHover = 45;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnBuy.CustomizableEdges = borderEdges2;
            this.btnBuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuy.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuy.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuy.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuy.IconMarginLeft = 11;
            this.btnBuy.IconPadding = 10;
            this.btnBuy.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuy.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuy.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuy.IconSize = 25;
            this.btnBuy.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.IdleBorderRadius = 1;
            this.btnBuy.IdleBorderThickness = 1;
            this.btnBuy.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.IdleIconLeftImage = null;
            this.btnBuy.IdleIconRightImage = null;
            this.btnBuy.IndicateFocus = false;
            this.btnBuy.Location = new System.Drawing.Point(3, 577);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuy.OnDisabledState.BorderRadius = 1;
            this.btnBuy.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnDisabledState.BorderThickness = 1;
            this.btnBuy.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuy.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuy.OnDisabledState.IconLeftImage = null;
            this.btnBuy.OnDisabledState.IconRightImage = null;
            this.btnBuy.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuy.onHoverState.BorderRadius = 1;
            this.btnBuy.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.onHoverState.BorderThickness = 1;
            this.btnBuy.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnBuy.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.onHoverState.IconLeftImage = null;
            this.btnBuy.onHoverState.IconRightImage = null;
            this.btnBuy.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.OnIdleState.BorderRadius = 1;
            this.btnBuy.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnIdleState.BorderThickness = 1;
            this.btnBuy.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.OnIdleState.IconLeftImage = null;
            this.btnBuy.OnIdleState.IconRightImage = null;
            this.btnBuy.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuy.OnPressedState.BorderRadius = 1;
            this.btnBuy.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBuy.OnPressedState.BorderThickness = 1;
            this.btnBuy.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnBuy.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuy.OnPressedState.IconLeftImage = null;
            this.btnBuy.OnPressedState.IconRightImage = null;
            this.btnBuy.Size = new System.Drawing.Size(344, 116);
            this.btnBuy.TabIndex = 56;
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuy.TextMarginLeft = 0;
            this.btnBuy.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuy.UseDefaultRadiusAndThickness = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cbPiece
            // 
            this.cbPiece.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.finalDBDataSet, "categories.name", true));
            this.cbPiece.DisplayMember = "id";
            this.cbPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPiece.FormattingEnabled = true;
            this.cbPiece.Location = new System.Drawing.Point(3, 511);
            this.cbPiece.Name = "cbPiece";
            this.cbPiece.Size = new System.Drawing.Size(344, 39);
            this.cbPiece.TabIndex = 55;
            this.cbPiece.Tag = "";
            this.cbPiece.ValueMember = "id";
            // 
            // cbCategory
            // 
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.finalDBDataSet, "categories.name", true));
            this.cbCategory.DataSource = this.categoriesBindingSource;
            this.cbCategory.DisplayMember = "name";
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 124);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(344, 39);
            this.cbCategory.TabIndex = 43;
            this.cbCategory.ValueMember = "id";
            // 
            // tbPrice
            // 
            this.tbPrice.AcceptsReturn = false;
            this.tbPrice.AcceptsTab = false;
            this.tbPrice.AnimationSpeed = 200;
            this.tbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPrice.BackgroundImage")));
            this.tbPrice.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbPrice.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPrice.BorderRadius = 1;
            this.tbPrice.BorderThickness = 1;
            this.tbPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
            this.tbPrice.DefaultText = "";
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrice.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPrice.HideSelection = true;
            this.tbPrice.IconLeft = null;
            this.tbPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.IconPadding = 10;
            this.tbPrice.IconRight = null;
            this.tbPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(3, 311);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbPrice.Modified = false;
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPrice.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPrice.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPrice.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPrice.OnIdleState = stateProperties20;
            this.tbPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPrice.PlaceholderText = "Product Price";
            this.tbPrice.ReadOnly = false;
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(344, 115);
            this.tbPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbPrice.TabIndex = 38;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPrice.TextMarginBottom = 0;
            this.tbPrice.TextMarginLeft = 3;
            this.tbPrice.TextMarginTop = 0;
            this.tbPrice.TextPlaceholder = "Product Price";
            this.tbPrice.UseSystemPasswordChar = false;
            this.tbPrice.WordWrap = true;
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = false;
            this.tbName.AcceptsTab = false;
            this.tbName.AnimationSpeed = 200;
            this.tbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbName.BackgroundImage")));
            this.tbName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbName.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbName.BorderRadius = 1;
            this.tbName.BorderThickness = 1;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
            this.tbName.DefaultText = "";
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbName.HideSelection = true;
            this.tbName.IconLeft = null;
            this.tbName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.IconPadding = 10;
            this.tbName.IconRight = null;
            this.tbName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(3, 3);
            this.tbName.MaxLength = 32767;
            this.tbName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbName.Modified = false;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbName.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbName.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbName.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbName.OnIdleState = stateProperties24;
            this.tbName.Padding = new System.Windows.Forms.Padding(3);
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbName.PlaceholderText = "Product Name";
            this.tbName.ReadOnly = false;
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(344, 115);
            this.tbName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbName.TabIndex = 36;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TextMarginBottom = 0;
            this.tbName.TextMarginLeft = 3;
            this.tbName.TextMarginTop = 0;
            this.tbName.TextPlaceholder = "Product Name";
            this.tbName.UseSystemPasswordChar = false;
            this.tbName.WordWrap = true;
            // 
            // tblRight
            // 
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.Controls.Add(this.label1, 0, 0);
            this.tblRight.Controls.Add(this.dgvProducts, 0, 1);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.Location = new System.Drawing.Point(359, 3);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 2;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRight.Size = new System.Drawing.Size(827, 696);
            this.tblRight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 87);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvProducts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.Name = null;
            this.dgvProducts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvProducts.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvProducts.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(3, 90);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(821, 603);
            this.dgvProducts.TabIndex = 5;
            this.dgvProducts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // CustomerProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 702);
            this.Controls.Add(this.tblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerProductsForm";
            this.Text = "CustomerProductsForm";
            this.Load += new System.EventHandler(this.CustomerProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.tblBack.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.tblLeft.PerformLayout();
            this.tblRight.ResumeLayout(false);
            this.tblRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private finalDBDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private finalDBDataSet finalDBDataSet;
        private finalDBDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Bunifu.UI.WinForms.BunifuTextBox tbDescription;
        private System.Windows.Forms.TableLayoutPanel tblBack;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private Bunifu.UI.WinForms.BunifuTextBox tbPrice;
        private Bunifu.UI.WinForms.BunifuTextBox tbName;
        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvProducts;
        private System.Windows.Forms.BindingSource finalDBDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbCategory;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBuy;
        private System.Windows.Forms.ComboBox cbPiece;
        private System.Windows.Forms.Label label2;
    }
}