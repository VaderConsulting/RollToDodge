<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.updRoll = New System.Windows.Forms.NumericUpDown()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.lblConditions = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.txtWeapon = New System.Windows.Forms.TextBox()
        Me.lblWeapons = New System.Windows.Forms.Label()
        Me.txtAbility = New System.Windows.Forms.TextBox()
        Me.lblAbilities = New System.Windows.Forms.Label()
        Me.txtInventory = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabNew = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBold = New System.Windows.Forms.ToolStripButton()
        Me.btnItalics = New System.Windows.Forms.ToolStripButton()
        Me.btnUnderline = New System.Windows.Forms.ToolStripButton()
        Me.btnStrikethrough = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditGameEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.tmrButtonSize = New System.Windows.Forms.Timer(Me.components)
        Me.ErrModifier = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tabPage1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.updRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrModifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.pnlMain)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(552, 477)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Player 1"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.updRoll)
        Me.pnlMain.Controls.Add(Me.btnClose)
        Me.pnlMain.Controls.Add(Me.txtModifier)
        Me.pnlMain.Controls.Add(Me.lblModifier)
        Me.pnlMain.Controls.Add(Me.btnRoll)
        Me.pnlMain.Controls.Add(Me.lblRoll)
        Me.pnlMain.Controls.Add(Me.lblAction)
        Me.pnlMain.Controls.Add(Me.txtAction)
        Me.pnlMain.Controls.Add(Me.lblConditions)
        Me.pnlMain.Controls.Add(Me.lblName)
        Me.pnlMain.Controls.Add(Me.txtCondition)
        Me.pnlMain.Controls.Add(Me.lblPlayer)
        Me.pnlMain.Controls.Add(Me.lblInventory)
        Me.pnlMain.Controls.Add(Me.txtWeapon)
        Me.pnlMain.Controls.Add(Me.lblWeapons)
        Me.pnlMain.Controls.Add(Me.txtAbility)
        Me.pnlMain.Controls.Add(Me.lblAbilities)
        Me.pnlMain.Controls.Add(Me.txtInventory)
        Me.pnlMain.Controls.Add(Me.txtname)
        Me.pnlMain.Controls.Add(Me.txtPlayer)
        Me.pnlMain.Controls.Add(Me.ShapeContainer1)
        Me.pnlMain.Location = New System.Drawing.Point(9, 6)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(537, 465)
        Me.pnlMain.TabIndex = 0
        '
        'updRoll
        '
        Me.updRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.updRoll.Location = New System.Drawing.Point(74, 424)
        Me.updRoll.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.updRoll.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updRoll.Name = "updRoll"
        Me.updRoll.Size = New System.Drawing.Size(41, 20)
        Me.updRoll.TabIndex = 11
        Me.updRoll.Tag = "0"
        Me.updRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.updRoll.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Image = Global.RollToDodge.My.Resources.Resources.Close
        Me.btnClose.Location = New System.Drawing.Point(520, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 17)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Tag = "1"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtModifier
        '
        Me.txtModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtModifier.Location = New System.Drawing.Point(266, 424)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(55, 20)
        Me.txtModifier.TabIndex = 9
        Me.txtModifier.Tag = "0"
        Me.txtModifier.Text = "+1"
        Me.txtModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblModifier
        '
        Me.lblModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Location = New System.Drawing.Point(202, 427)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(58, 13)
        Me.lblModifier.TabIndex = 0
        Me.lblModifier.Text = "Modifier(s):"
        '
        'btnRoll
        '
        Me.btnRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRoll.Location = New System.Drawing.Point(121, 422)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 8
        Me.btnRoll.Tag = "1"
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblRoll
        '
        Me.lblRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Location = New System.Drawing.Point(5, 427)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(28, 13)
        Me.lblRoll.TabIndex = 0
        Me.lblRoll.Text = "Roll:"
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(5, 335)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(40, 13)
        Me.lblAction.TabIndex = 0
        Me.lblAction.Text = "Action:"
        '
        'txtAction
        '
        Me.txtAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAction.Location = New System.Drawing.Point(74, 335)
        Me.txtAction.Multiline = True
        Me.txtAction.Name = "txtAction"
        Me.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAction.Size = New System.Drawing.Size(443, 84)
        Me.txtAction.TabIndex = 6
        '
        'lblConditions
        '
        Me.lblConditions.AutoSize = True
        Me.lblConditions.Location = New System.Drawing.Point(3, 254)
        Me.lblConditions.Name = "lblConditions"
        Me.lblConditions.Size = New System.Drawing.Size(65, 13)
        Me.lblConditions.TabIndex = 0
        Me.lblConditions.Text = "Condition(s):"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(5, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtCondition
        '
        Me.txtCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondition.Location = New System.Drawing.Point(74, 254)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCondition.Size = New System.Drawing.Size(443, 60)
        Me.txtCondition.TabIndex = 5
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(5, 35)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(39, 13)
        Me.lblPlayer.TabIndex = 0
        Me.lblPlayer.Text = "Player:"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Location = New System.Drawing.Point(4, 58)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(54, 13)
        Me.lblInventory.TabIndex = 0
        Me.lblInventory.Text = "Inventory:"
        '
        'txtWeapon
        '
        Me.txtWeapon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWeapon.Location = New System.Drawing.Point(74, 187)
        Me.txtWeapon.Multiline = True
        Me.txtWeapon.Name = "txtWeapon"
        Me.txtWeapon.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWeapon.Size = New System.Drawing.Size(443, 60)
        Me.txtWeapon.TabIndex = 4
        '
        'lblWeapons
        '
        Me.lblWeapons.AutoSize = True
        Me.lblWeapons.Location = New System.Drawing.Point(5, 187)
        Me.lblWeapons.Name = "lblWeapons"
        Me.lblWeapons.Size = New System.Drawing.Size(56, 13)
        Me.lblWeapons.TabIndex = 0
        Me.lblWeapons.Text = "Weapons:"
        '
        'txtAbility
        '
        Me.txtAbility.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAbility.Location = New System.Drawing.Point(74, 121)
        Me.txtAbility.Multiline = True
        Me.txtAbility.Name = "txtAbility"
        Me.txtAbility.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAbility.Size = New System.Drawing.Size(443, 60)
        Me.txtAbility.TabIndex = 3
        '
        'lblAbilities
        '
        Me.lblAbilities.AutoSize = True
        Me.lblAbilities.Location = New System.Drawing.Point(4, 124)
        Me.lblAbilities.Name = "lblAbilities"
        Me.lblAbilities.Size = New System.Drawing.Size(45, 13)
        Me.lblAbilities.TabIndex = 0
        Me.lblAbilities.Text = "Abilities:"
        '
        'txtInventory
        '
        Me.txtInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInventory.Location = New System.Drawing.Point(74, 55)
        Me.txtInventory.Multiline = True
        Me.txtInventory.Name = "txtInventory"
        Me.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInventory.Size = New System.Drawing.Size(443, 60)
        Me.txtInventory.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname.Location = New System.Drawing.Point(74, 6)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(443, 20)
        Me.txtname.TabIndex = 0
        '
        'txtPlayer
        '
        Me.txtPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlayer.Location = New System.Drawing.Point(74, 32)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(443, 20)
        Me.txtPlayer.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(537, 465)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -21
        Me.LineShape1.X2 = 580
        Me.LineShape1.Y1 = 323
        Me.LineShape1.Y2 = 323
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabPage1)
        Me.tabMain.Controls.Add(Me.tabNew)
        Me.tabMain.Location = New System.Drawing.Point(12, 53)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(560, 503)
        Me.tabMain.TabIndex = 0
        '
        'tabNew
        '
        Me.tabNew.Location = New System.Drawing.Point(4, 22)
        Me.tabNew.Name = "tabNew"
        Me.tabNew.Size = New System.Drawing.Size(552, 477)
        Me.tabNew.TabIndex = 1
        Me.tabNew.Text = "New Page"
        Me.tabNew.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton, Me.ToolStripSeparator2, Me.btnBold, Me.btnItalics, Me.btnUnderline, Me.btnStrikethrough})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnBold
        '
        Me.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBold.Image = Global.RollToDodge.My.Resources.Resources.Bold
        Me.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(23, 22)
        Me.btnBold.Text = "ToolStripButton2"
        Me.btnBold.ToolTipText = "Bold"
        '
        'btnItalics
        '
        Me.btnItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnItalics.Image = Global.RollToDodge.My.Resources.Resources.Italic
        Me.btnItalics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnItalics.Name = "btnItalics"
        Me.btnItalics.Size = New System.Drawing.Size(23, 22)
        Me.btnItalics.Text = "ToolStripButton1"
        Me.btnItalics.ToolTipText = "Italic"
        '
        'btnUnderline
        '
        Me.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUnderline.Image = Global.RollToDodge.My.Resources.Resources.Underline
        Me.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(23, 22)
        Me.btnUnderline.Text = "ToolStripButton3"
        Me.btnUnderline.ToolTipText = "Underline"
        '
        'btnStrikethrough
        '
        Me.btnStrikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStrikethrough.Image = Global.RollToDodge.My.Resources.Resources.Strikethrough
        Me.btnStrikethrough.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStrikethrough.Name = "btnStrikethrough"
        Me.btnStrikethrough.Size = New System.Drawing.Size(23, 22)
        Me.btnStrikethrough.Text = "ToolStripButton4"
        Me.btnStrikethrough.ToolTipText = "Strikethrough"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PreviewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PreviewToolStripMenuItem
        '
        Me.PreviewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentToolStripMenuItem, Me.AllToolStripMenuItem, Me.EditGameEventToolStripMenuItem})
        Me.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem"
        Me.PreviewToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PreviewToolStripMenuItem.Text = "Preview"
        '
        'CurrentToolStripMenuItem
        '
        Me.CurrentToolStripMenuItem.Name = "CurrentToolStripMenuItem"
        Me.CurrentToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CurrentToolStripMenuItem.Text = "Current"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'EditGameEventToolStripMenuItem
        '
        Me.EditGameEventToolStripMenuItem.Name = "EditGameEventToolStripMenuItem"
        Me.EditGameEventToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.EditGameEventToolStripMenuItem.Text = "End roll"
        '
        'btnPreview
        '
        Me.btnPreview.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPreview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(568, 49)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPreview.MinimumSize = New System.Drawing.Size(12, 253)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(16, 513)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'tmrButtonSize
        '
        Me.tmrButtonSize.Interval = 7
        '
        'ErrModifier
        '
        Me.ErrModifier.ContainerControl = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tabMain)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(3000, 2000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RtD Roll Generator"
        Me.tabPage1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.updRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrModifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabNew As System.Windows.Forms.TabPage
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents txtModifier As System.Windows.Forms.TextBox
    Friend WithEvents lblModifier As System.Windows.Forms.Label
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblRoll As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents lblConditions As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblInventory As System.Windows.Forms.Label
    Friend WithEvents txtWeapon As System.Windows.Forms.TextBox
    Friend WithEvents lblWeapons As System.Windows.Forms.Label
    Friend WithEvents txtAbility As System.Windows.Forms.TextBox
    Friend WithEvents lblAbilities As System.Windows.Forms.Label
    Friend WithEvents txtInventory As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnItalics As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnStrikethrough As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents tmrButtonSize As System.Windows.Forms.Timer
    Friend WithEvents PreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditGameEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updRoll As System.Windows.Forms.NumericUpDown
    Friend WithEvents ErrModifier As System.Windows.Forms.ErrorProvider

End Class
