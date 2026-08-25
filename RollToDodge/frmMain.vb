Public Class frmMain

#Region " New events "

    Private Event Roll_Click(ByRef sender As System.Object, ByVal e As EventArgs)
    Private Event Close_Click(ByRef sender As System.Object, ByVal e As EventArgs)

#End Region

    Private m_TabCount As Int32 = 1
    Public EndRollText As String = ""

    Private Enum SizeDirection As Int32
        [Static] = 0
        Up = 1
        Down = 2
    End Enum

    Private m_ButtonSizeDirection As SizeDirection = SizeDirection.Static

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        AddHandler tabMain.TabPages(0).Controls.Item("pnlMain").Controls("btnClose").Click, AddressOf CloseClick
        AddHandler tabMain.TabPages(0).Controls.Item("pnlMain").Controls("btnRoll").Click, AddressOf btnRoll_Click
    End Sub

    Private Sub tabMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabMain.MouseClick
        AddNewTab()
    End Sub

    Private Function AddNewTab() As TabPage
        If tabMain.SelectedIndex = tabMain.TabCount - 1 Then
            ' Remove existing last page
            tabMain.TabPages.RemoveAt(tabMain.SelectedIndex)

            ' Create new page
            Dim NewTabPage As New System.Windows.Forms.TabPage

            ' Add 1 to our counter
            m_TabCount += 1

            ' Build the page
            BuildPage(NewTabPage, m_TabCount) 'tabMain.TabPages.Count + 1)

            ' Add the page
            tabMain.TabPages.Add(NewTabPage)

            ' Now add the "New Page" tab back
            Dim NewPage As New System.Windows.Forms.TabPage
            NewPage.Text = "New Page"

            ' Add this to the page collection
            tabMain.TabPages.Add(NewPage)

            ' Finally set the focus to the new "Player x" page previously created
            tabMain.SelectedTab = tabMain.TabPages(tabMain.TabCount - 2)

            Return NewTabPage
        End If
        Return Nothing
    End Function

    Private Sub BuildPage(ByVal TheTabPage As TabPage, ByVal Count As Int32)
        Dim pnlMain As New System.Windows.Forms.Panel
        Dim txtModifier As New System.Windows.Forms.TextBox
        Dim updRoll As New System.Windows.Forms.NumericUpDown
        Dim lblModifier As New System.Windows.Forms.Label
        Dim btnRoll As New System.Windows.Forms.Button
        Dim lblRoll As New System.Windows.Forms.Label
        Dim lblAction As New System.Windows.Forms.Label
        Dim txtAction As New System.Windows.Forms.TextBox
        Dim lblConditions As New System.Windows.Forms.Label
        Dim lblName As New System.Windows.Forms.Label
        Dim txtCondition As New System.Windows.Forms.TextBox
        Dim lblPlayer As New System.Windows.Forms.Label
        Dim lblInventory As New System.Windows.Forms.Label
        Dim txtWeapon As New System.Windows.Forms.TextBox
        Dim lblWeapons As New System.Windows.Forms.Label
        Dim txtAbility As New System.Windows.Forms.TextBox
        Dim lblAbilities As New System.Windows.Forms.Label
        Dim txtInventory As New System.Windows.Forms.TextBox
        Dim txtname As New System.Windows.Forms.TextBox
        Dim txtPlayer As New System.Windows.Forms.TextBox
        Dim ShapeContainer1 As New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Dim LineShape1 As New Microsoft.VisualBasic.PowerPacks.LineShape
        Dim btnClose As New System.Windows.Forms.Button

        pnlMain = New System.Windows.Forms.Panel()
        btnClose = New System.Windows.Forms.Button()
        txtModifier = New System.Windows.Forms.TextBox()
        updRoll = New System.Windows.Forms.NumericUpDown()
        lblmodifier = New System.Windows.Forms.Label()
        btnRoll = New System.Windows.Forms.Button()
        lblRoll = New System.Windows.Forms.Label()
        lblAction = New System.Windows.Forms.Label()
        txtAction = New System.Windows.Forms.TextBox()
        lblConditions = New System.Windows.Forms.Label()
        lblName = New System.Windows.Forms.Label()
        txtCondition = New System.Windows.Forms.TextBox()
        lblPlayer = New System.Windows.Forms.Label()
        lblInventory = New System.Windows.Forms.Label()
        txtWeapon = New System.Windows.Forms.TextBox()
        lblWeapons = New System.Windows.Forms.Label()
        txtAbility = New System.Windows.Forms.TextBox()
        lblAbilities = New System.Windows.Forms.Label()
        txtInventory = New System.Windows.Forms.TextBox()
        txtname = New System.Windows.Forms.TextBox()
        txtPlayer = New System.Windows.Forms.TextBox()
        ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()

        TheTabPage.SuspendLayout()
        pnlMain.SuspendLayout()
        CType(updRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        tabMain.SuspendLayout()
        CType(ErrModifier, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'tabPage1
        '
        TheTabPage.Controls.Add(pnlMain)
        TheTabPage.Location = New System.Drawing.Point(4, 22)
        TheTabPage.Name = "tabPage" & CStr(m_TabCount)
        TheTabPage.Padding = New System.Windows.Forms.Padding(3)
        TheTabPage.Size = New System.Drawing.Size(552, 477)
        TheTabPage.TabIndex = 0
        TheTabPage.Text = "Player " & CStr(Count)
        TheTabPage.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pnlMain.AutoScroll = True
        pnlMain.Controls.Add(updRoll)
        pnlMain.Controls.Add(btnClose)
        pnlMain.Controls.Add(txtModifier)
        pnlMain.Controls.Add(lblmodifier)
        pnlMain.Controls.Add(btnRoll)
        pnlMain.Controls.Add(lblRoll)
        pnlMain.Controls.Add(lblAction)
        pnlMain.Controls.Add(txtAction)
        pnlMain.Controls.Add(lblConditions)
        pnlMain.Controls.Add(lblName)
        pnlMain.Controls.Add(txtCondition)
        pnlMain.Controls.Add(lblPlayer)
        pnlMain.Controls.Add(lblInventory)
        pnlMain.Controls.Add(txtWeapon)
        pnlMain.Controls.Add(lblWeapons)
        pnlMain.Controls.Add(txtAbility)
        pnlMain.Controls.Add(lblAbilities)
        pnlMain.Controls.Add(txtInventory)
        pnlMain.Controls.Add(txtname)
        pnlMain.Controls.Add(txtPlayer)
        pnlMain.Controls.Add(ShapeContainer1)
        pnlMain.Location = New System.Drawing.Point(9, 6)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New System.Drawing.Size(537, 465)
        pnlMain.TabIndex = 0
        '
        'updRoll
        '
        updRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        updRoll.Location = New System.Drawing.Point(74, 424)
        updRoll.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        updRoll.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        updRoll.Name = "updRoll"
        updRoll.Size = New System.Drawing.Size(41, 20)
        updRoll.TabIndex = 11
        updRoll.Tag = CStr(m_TabCount)
        updRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        updRoll.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        '
        'btnClose
        '
        btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnClose.Image = Global.RollToDodge.My.Resources.Resources.Close
        btnClose.Location = New System.Drawing.Point(520, 0)
        btnClose.Margin = New System.Windows.Forms.Padding(0)
        btnClose.Name = "btnClose"
        btnClose.Size = New System.Drawing.Size(17, 17)
        btnClose.TabIndex = 10
        btnClose.UseVisualStyleBackColor = True
        btnClose.Tag = CStr(m_TabCount)
        '
        'txtModifier
        '
        txtModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        txtModifier.Location = New System.Drawing.Point(266, 424)
        txtModifier.Name = "txtModifier"
        txtModifier.Size = New System.Drawing.Size(55, 20)
        txtModifier.TabIndex = 9
        txtModifier.Text = "+1"
        txtModifier.Tag = CStr(m_TabCount)
        txtModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblModifier
        '
        lblmodifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lblmodifier.AutoSize = True
        lblmodifier.Location = New System.Drawing.Point(202, 427)
        lblmodifier.Name = "lblModifier"
        lblmodifier.Size = New System.Drawing.Size(58, 13)
        lblmodifier.TabIndex = 0
        lblmodifier.Text = "Modifier(s):"
        '
        'btnRoll
        '
        btnRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btnRoll.Location = New System.Drawing.Point(121, 422)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New System.Drawing.Size(75, 23)
        btnRoll.TabIndex = 8
        btnRoll.Tag = CStr(m_TabCount)
        btnRoll.Text = "Roll"
        btnRoll.UseVisualStyleBackColor = True
        btnRoll.Tag = CStr(m_TabCount)
        '
        'lblRoll
        '
        lblRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        lblRoll.AutoSize = True
        lblRoll.Location = New System.Drawing.Point(5, 427)
        lblRoll.Name = "lblRoll"
        lblRoll.Size = New System.Drawing.Size(28, 13)
        lblRoll.TabIndex = 0
        lblRoll.Text = "Roll:"
        '
        'lblAction
        '
        lblAction.AutoSize = True
        lblAction.Location = New System.Drawing.Point(5, 335)
        lblAction.Name = "lblAction"
        lblAction.Size = New System.Drawing.Size(40, 13)
        lblAction.TabIndex = 0
        lblAction.Text = "Action:"
        '
        'txtAction
        '
        txtAction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtAction.Location = New System.Drawing.Point(74, 335)
        txtAction.Multiline = True
        txtAction.Name = "txtAction"
        txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtAction.Size = New System.Drawing.Size(443, 84)
        txtAction.TabIndex = 6
        '
        'lblConditions
        '
        lblConditions.AutoSize = True
        lblConditions.Location = New System.Drawing.Point(3, 254)
        lblConditions.Name = "lblConditions"
        lblConditions.Size = New System.Drawing.Size(65, 13)
        lblConditions.TabIndex = 0
        lblConditions.Text = "Condition(s):"
        '
        'lblName
        '
        lblName.AutoSize = True
        lblName.Location = New System.Drawing.Point(5, 9)
        lblName.Name = "lblName"
        lblName.Size = New System.Drawing.Size(38, 13)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        '
        'txtCondition
        '
        txtCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtCondition.Location = New System.Drawing.Point(74, 254)
        txtCondition.Multiline = True
        txtCondition.Name = "txtCondition"
        txtCondition.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtCondition.Size = New System.Drawing.Size(443, 60)
        txtCondition.TabIndex = 5
        '
        'lblPlayer
        '
        lblPlayer.AutoSize = True
        lblPlayer.Location = New System.Drawing.Point(5, 35)
        lblPlayer.Name = "lblPlayer"
        lblPlayer.Size = New System.Drawing.Size(39, 13)
        lblPlayer.TabIndex = 0
        lblPlayer.Text = "Player:"
        '
        'lblInventory
        '
        lblInventory.AutoSize = True
        lblInventory.Location = New System.Drawing.Point(4, 58)
        lblInventory.Name = "lblInventory"
        lblInventory.Size = New System.Drawing.Size(54, 13)
        lblInventory.TabIndex = 0
        lblInventory.Text = "Inventory:"
        '
        'txtWeapon
        '
        txtWeapon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtWeapon.Location = New System.Drawing.Point(74, 187)
        txtWeapon.Multiline = True
        txtWeapon.Name = "txtWeapon"
        txtWeapon.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtWeapon.Size = New System.Drawing.Size(443, 60)
        txtWeapon.TabIndex = 4
        '
        'lblWeapons
        '
        lblWeapons.AutoSize = True
        lblWeapons.Location = New System.Drawing.Point(5, 187)
        lblWeapons.Name = "lblWeapons"
        lblWeapons.Size = New System.Drawing.Size(56, 13)
        lblWeapons.TabIndex = 0
        lblWeapons.Text = "Weapons:"
        '
        'txtAbility
        '
        txtAbility.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtAbility.Location = New System.Drawing.Point(74, 121)
        txtAbility.Multiline = True
        txtAbility.Name = "txtAbility"
        txtAbility.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtAbility.Size = New System.Drawing.Size(443, 60)
        txtAbility.TabIndex = 3
        '
        'lblAbilities
        '
        lblAbilities.AutoSize = True
        lblAbilities.Location = New System.Drawing.Point(4, 124)
        lblAbilities.Name = "lblAbilities"
        lblAbilities.Size = New System.Drawing.Size(45, 13)
        lblAbilities.TabIndex = 0
        lblAbilities.Text = "Abilities:"
        '
        'txtInventory
        '
        txtInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtInventory.Location = New System.Drawing.Point(74, 55)
        txtInventory.Multiline = True
        txtInventory.Name = "txtInventory"
        txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtInventory.Size = New System.Drawing.Size(443, 60)
        txtInventory.TabIndex = 2
        '
        'txtname
        '
        txtname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtname.Location = New System.Drawing.Point(74, 6)
        txtname.Name = "txtname"
        txtname.Size = New System.Drawing.Size(443, 20)
        txtname.TabIndex = 0
        '
        'txtPlayer
        '
        txtPlayer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtPlayer.Location = New System.Drawing.Point(74, 32)
        txtPlayer.Name = "txtPlayer"
        txtPlayer.Size = New System.Drawing.Size(443, 20)
        txtPlayer.TabIndex = 1
        '
        'ShapeContainer1
        '
        ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        ShapeContainer1.Name = "ShapeContainer1"
        ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {LineShape1})
        ShapeContainer1.Size = New System.Drawing.Size(452, 465)
        ShapeContainer1.TabIndex = 3
        ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LineShape1.Name = "LineShape1"
        LineShape1.X1 = -21
        LineShape1.X2 = 580
        LineShape1.Y1 = 323
        LineShape1.Y2 = 323

        ' Events
        AddHandler btnClose.Click, AddressOf CloseClick
        AddHandler btnRoll.Click, AddressOf btnRoll_Click
        AddHandler updRoll.KeyDown, AddressOf updRoll_KeyDown
        AddHandler txtModifier.Validated, AddressOf txtModifier_Validated

        TheTabPage.Controls.Add(pnlMain)

        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        CType(updRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ErrModifier, System.ComponentModel.ISupportInitialize).EndInit()
        TheTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub CloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ButtonNumber As Int32 = CInt(sender.tag.ToString) - 1
        Dim Reply As MsgBoxResult = MsgBox("Are you sure?", MsgBoxStyle.ApplicationModal + MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close")

        If Reply = MsgBoxResult.Yes Then
            tabMain.TabPages.RemoveAt(ButtonNumber)
            If ButtonNumber >= 1 Then
                tabMain.SelectedTab = tabMain.TabPages(ButtonNumber - 1)
            Else
                tabMain.SelectedTab = tabMain.TabPages(0)
            End If
        End If
    End Sub

    Private Sub btnBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold.Click
        Dim StartValue As String = "[b]"
        Dim EndValue As String = "[/b]"
        ApplyStyle(StartValue, EndValue)
    End Sub

    Private Sub btnUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnderline.Click
        Dim StartValue As String = "[u]"
        Dim EndValue As String = "[/u]"
        ApplyStyle(StartValue, EndValue)
    End Sub

    Private Sub btnItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItalics.Click
        Dim StartValue As String = "[i]"
        Dim EndValue As String = "[/i]"
        ApplyStyle(StartValue, EndValue)
    End Sub

    Private Sub btnStrikeout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrikethrough.Click
        Dim StartValue As String = "[s]"
        Dim EndValue As String = "[/s]"
        ApplyStyle(StartValue, EndValue)
    End Sub

    Private Sub txtModifier_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModifier.Enter
        txtModifier.Focus()
        txtModifier.SelectAll()
    End Sub

    Private Sub ApplyStyle(ByVal StartText As String, ByVal Endtext As String)
        Dim ControlWithFocus As Control = Me.ActiveControl

        If TypeName(ControlWithFocus) = "TextBox" And ControlWithFocus.Name <> "txtModifier" Then
            Dim SelectedTextbox As TextBox = ControlWithFocus
            Dim SelectedText As String = SelectedTextbox.SelectedText
            Dim NewText As String = StartText & SelectedText & Endtext

            If SelectedText.Length = 0 Then
                SelectedTextbox.SelectedText = NewText
                SendKeys.Send("{left}{left}{left}{left}")
            Else
                SelectedTextbox.SelectedText = NewText
            End If
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge.xml") Then
            Dim ds As New DataSet("RollToDodge")
            Dim table As Data.DataTable = ds.Tables.Add("Character")
            ds.Tables("Character").ReadXmlSchema(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge_Schema.xml")
            ds.Tables("Character").ReadXml(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge.xml")

            Debug.Print("Found " & ds.Tables("Character").Rows.Count & " rows.")

            ' Remove existing pages
            For Each Page As TabPage In Me.tabMain.TabPages
                If Page.Text <> "New Page" Then
                    tabMain.TabPages.Remove(Page)
                End If
            Next

            m_TabCount = 0

            For Each DataRow As DataRow In ds.Tables("Character").Rows()
                'tabMain.SelectedTab = tabMain.TabPages("New Page")
                tabMain.SelectedIndex = tabMain.TabCount - 1
                Dim NewTabPage As TabPage = AddNewTab()
                NewTabPage.Controls("pnlMain").Controls("txtPlayer").Text = DataRow("PlayerName").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtName").Text = DataRow("CharacterName").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtInventory").Text = DataRow("Inventory").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtAbility").Text = DataRow("Abilities").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtWeapon").Text = DataRow("Weapons").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtCondition").Text = DataRow("Conditions").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtAction").Text = DataRow("Action").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("txtModifier").Text = DataRow("Modifiers").ToString & ""
                NewTabPage.Controls("pnlMain").Controls("updRoll").Text = DataRow("RollNumber").ToString & ""
            Next
        Else
            MsgBox("No data to load", MsgBoxStyle.OkOnly + MsgBoxResult.Ok, "Oops")
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        tabMain.SelectedIndex = tabMain.TabPages.Count - 1
        AddNewTab()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim Reply As MsgBoxResult = MsgBoxResult.No

        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge.xml") Then
            Reply = MsgBox("Overwrite existing settings?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Existing settings found!")
        End If

        If Reply = MsgBoxResult.Yes Then
            Dim ds As New DataSet("RollToDodge")
            Dim table As Data.DataTable = ds.Tables.Add("Character")
            table.Columns.Add("PlayerName")
            table.Columns.Add("CharacterName")
            table.Columns.Add("Inventory")
            table.Columns.Add("Abilities")
            table.Columns.Add("Weapons")
            table.Columns.Add("Conditions")
            table.Columns.Add("Action")
            table.Columns.Add("Modifiers")
            table.Columns.Add("RollNumber")

            For Each Page As TabPage In Me.tabMain.TabPages
                If Page.Text <> "New Page" Then
                    tabMain.SelectedTab = Page
                    If Page.Controls("pnlMain").Controls.Count > 0 Then
                        FillDataset(tabMain.SelectedTab, ds)
                    End If
                End If
            Next
            ds.Tables("Character").WriteXmlSchema(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge_Schema.xml")
            ds.Tables("Character").WriteXml(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\RollToDodge.xml")
        End If
    End Sub

    Private Sub FillDataset(ByVal Page As TabPage, ByRef Data As DataSet)
        Dim SelectedPage As TabPage = Page
        Dim PlayerName As String = SelectedPage.Controls("pnlMain").Controls("txtPlayer").Text
        Dim CharacterName As String = SelectedPage.Controls("pnlMain").Controls("txtName").Text
        Dim Inventory As String = SelectedPage.Controls("pnlMain").Controls("txtInventory").Text
        Dim Ability As String = SelectedPage.Controls("pnlMain").Controls("txtAbility").Text
        Dim Weapons As String = SelectedPage.Controls("pnlMain").Controls("txtWeapon").Text
        Dim Condition As String = SelectedPage.Controls("pnlMain").Controls("txtCondition").Text
        Dim Action As String = SelectedPage.Controls("pnlMain").Controls("txtAction").Text
        Dim Modifier As String = SelectedPage.Controls("pnlMain").Controls("txtModifier").Text & ""
        Dim RollNumber As String = SelectedPage.Controls("pnlMain").Controls("updRoll").Text

        If PlayerName.Length > 0 Or CharacterName.Length > 0 Then
            Dim NewData As DataRow = Data.Tables("Character").NewRow
            NewData("PlayerName") = PlayerName & ""
            NewData("CharacterName") = CharacterName & ""
            NewData("Inventory") = Inventory & ""
            NewData("Abilities") = Ability & ""
            NewData("Weapons") = Weapons & ""
            NewData("Conditions") = Condition & ""
            NewData("Action") = Action & ""
            NewData("Modifiers") = Modifier & ""
            NewData("RollNumber") = RollNumber & ""

            Data.Tables("Character").Rows.Add(NewData)
            Data.AcceptChanges()
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        MsgBox("Not implemented")
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        Dim ControlWithFocus As Control = Me.ActiveControl

        If TypeName(ControlWithFocus) = "TextBox" And ControlWithFocus.Name <> "txtModifier" Then
            Dim SelectedTextbox As TextBox = ControlWithFocus
            Dim SelectedText As String = SelectedTextbox.SelectedText

            If SelectedText.Length > 0 Then
                My.Computer.Clipboard.SetText(SelectedText)
                SelectedTextbox.SelectedText = ""
            End If
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        Dim ControlWithFocus As Control = Me.ActiveControl

        If TypeName(ControlWithFocus) = "TextBox" And ControlWithFocus.Name <> "txtModifier" Then
            Dim SelectedTextbox As TextBox = ControlWithFocus
            Dim SelectedText As String = SelectedTextbox.SelectedText

            If SelectedText.Length > 0 Then
                My.Computer.Clipboard.SetText(SelectedText)
            End If
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        Dim ControlWithFocus As Control = Me.ActiveControl

        If TypeName(ControlWithFocus) = "TextBox" And ControlWithFocus.Name <> "txtModifier" Then
            Dim SelectedTextbox As TextBox = ControlWithFocus
            SendKeys.Send(My.Computer.Clipboard.GetText())
        End If
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        MsgBox("no help here")
    End Sub

    Private Sub btnPreview_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.MouseEnter
        m_ButtonSizeDirection = SizeDirection.Up
        tmrButtonSize.Enabled = True
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        ShowPreview()
    End Sub

    Private Sub ShowPreview()
        Dim PreviewWindow As New frmPreview

        PreviewWindow.Show()
        PreviewWindow.Size = Me.Size
        'PreviewWindow.Bounds = Me.Bounds
        PreviewWindow.SetDesktopLocation(Me.Left + Me.Width + 5, Me.Top)

        PreviewWindow.rtbPreview.Text = BuildPreview(tabMain.SelectedTab)
    End Sub

    Private Sub btnPreview_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.MouseLeave
        m_ButtonSizeDirection = SizeDirection.Down
        tmrButtonSize.Enabled = True
    End Sub

    Private Sub tmrButtonSize_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrButtonSize.Tick
        Select Case m_ButtonSizeDirection
            Case SizeDirection.Static
                tmrButtonSize.Enabled = False
            Case SizeDirection.Up
                btnPreview.Width += 2
            Case SizeDirection.Down
                btnPreview.Width -= 2
        End Select

        If btnPreview.Width >= 75 Or btnPreview.Width <= 16 Then tmrButtonSize.Enabled = False

    End Sub

    Private Function BuildPreview(ByVal Page As TabPage) As String
        Dim SelectedPage As TabPage = Page
        Dim PlayerName As String = SelectedPage.Controls("pnlMain").Controls("txtPlayer").Text
        Dim CharacterName As String = SelectedPage.Controls("pnlMain").Controls("txtName").Text
        Dim Inventory As String = SelectedPage.Controls("pnlMain").Controls("txtInventory").Text
        Dim Ability As String = SelectedPage.Controls("pnlMain").Controls("txtAbility").Text
        Dim Weapons As String = SelectedPage.Controls("pnlMain").Controls("txtWeapon").Text
        Dim Condition As String = SelectedPage.Controls("pnlMain").Controls("txtCondition").Text
        Dim Action As String = SelectedPage.Controls("pnlMain").Controls("txtAction").Text
        Dim Modifier As String = SelectedPage.Controls("pnlMain").Controls("txtModifier").Text & ""
        Dim RollNumber As String = SelectedPage.Controls("pnlMain").Controls("updRoll").Text
        Dim Output As String = ""
        Dim Total As Int32 = 0
        If Modifier.Length > 0 Then
            Dim TotalModifier As Int32 = 0
            For i = 0 To txtModifier.Text.Length - 1 Step 2
                Dim ThisModifier As Int32 = 0
                Dim IsPositive As Boolean = True

                ' Work out if positive or negative
                Select Case txtModifier.Text.Substring(i, 1)
                    Case "+"
                        IsPositive = True
                    Case "-"
                        IsPositive = False
                    Case Else
                        ' Huh???
                End Select
                ThisModifier = CInt(txtModifier.Text.Substring(i + 1, 1))
                If Not IsPositive Then ThisModifier = ThisModifier * -1

                TotalModifier += ThisModifier
            Next
            Total = CInt(RollNumber) + CInt(TotalModifier)
        Else
            Total = CInt(RollNumber)
        End If

        If Total < 1 Then Total = 1
        If Total > 6 Then Total = 6

        If PlayerName.Length > 0 Or CharacterName.Length > 0 Then
            If Modifier.Length > 0 Then
                Output &= PlayerName & " (" & RollNumber & Modifier & "=" & Total & ") " & CharacterName & vbCrLf
            Else
                Output &= PlayerName & " (" & RollNumber & ") " & CharacterName & vbCrLf
            End If

            If Action.Length > 0 Then
                Output &= Action & vbCrLf
            End If

            If Ability.Length > 0 Then
                Output &= "[b][u]Abilities[/u][/b]" & vbCrLf
                Output &= Ability & vbCrLf
            End If

            If Weapons.Length > 0 Then
                Output &= "[b][u]Weapons[/u][/b]" & vbCrLf
                Output &= Weapons & vbCrLf
            End If

            If Inventory.Length > 0 Then
                Output &= "[b][u]Inventory[/u][/b]" & vbCrLf
                Output &= Inventory & vbCrLf
            End If

            If Condition.Length > 0 Then
                Output &= "[b][u]Condition(s)[/u][/b]" & vbCrLf
                Output &= Condition & vbCrLf
            End If
        End If

        Return Output
    End Function

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        Dim ButtonNumber As Int32 = CInt(sender.tag.ToString)
        If ButtonNumber > 0 Then ButtonNumber -= 1
        Dim UpDownControl As NumericUpDown = tabMain.TabPages(ButtonNumber).Controls.Item("pnlMain").Controls("updRoll")
        Dim Current As Int32 = CInt(UpDownControl.Text)
        Dim R As New Random

        Do
            UpDownControl.Value = R.Next(1, 7)
        Loop Until CInt(UpDownControl.Text) <> Current
    End Sub

    Private Sub CurrentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentToolStripMenuItem.Click
        ShowPreview()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        Dim PreviewWindow As New frmPreview

        PreviewWindow.Show()
        PreviewWindow.Size = Me.Size
        PreviewWindow.SetDesktopLocation(Me.Left + Me.Width + 10, Me.Top)

        For Each Page As TabPage In Me.tabMain.TabPages
            If Page.Text <> "New Page" Then
                tabMain.SelectedTab = Page
                If Page.Controls("pnlMain").Controls.Count > 0 Then
                    PreviewWindow.rtbPreview.Text &= BuildPreview(tabMain.SelectedTab)
                    PreviewWindow.rtbPreview.Text &= vbCrLf
                End If
            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EditGameEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGameEventToolStripMenuItem.Click
        Dim EndRollForm As New frmEndRoll

        EndRollForm.Show()

    End Sub

    Private Sub updRoll_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles updRoll.KeyDown
        Dim ButtonNumber As Int32 = CInt(sender.tag.ToString)
        If ButtonNumber > 0 Then ButtonNumber -= 1
        Dim UpDownControl As NumericUpDown = tabMain.TabPages(ButtonNumber).Controls.Item("pnlMain").Controls("updRoll")

        If (e.KeyValue >= 49 And e.KeyValue <= 54) Or (e.KeyValue >= 97 And e.KeyValue <= 102) Then
            Select Case e.KeyValue
                Case 49, 97
                    UpDownControl.Value = 1
                Case 50, 98
                    UpDownControl.Value = 2
                Case 51, 99
                    UpDownControl.Value = 3
                Case 52, 100
                    UpDownControl.Value = 4
                Case 53, 101
                    UpDownControl.Value = 5
                Case 54, 102
                    UpDownControl.Value = 6
            End Select
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtModifier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModifier.TextChanged

    End Sub

    Private Sub txtModifier_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModifier.Validated
        Dim ButtonNumber As Int32 = CInt(sender.tag.ToString)
        If ButtonNumber > 0 Then ButtonNumber -= 1

        Try
            Dim txtModifierControl As TextBox = tabMain.TabPages(ButtonNumber).Controls.Item("pnlMain").Controls("txtModifier")

            ErrModifier.SetError(txtModifierControl, "")
            If Not IsModifierValid(txtModifierControl) Then ErrModifier.SetError(txtModifierControl, "You must provide a valid modifier between 1 and 3")
        Catch
        End Try
    End Sub

    Private Function IsModifierValid(ByVal TheTextbox As TextBox) As Boolean
        Dim IsValid As Boolean = True

        TheTextbox.Text = TheTextbox.Text.Trim

        If TheTextbox.TextLength = 0 Then Return True
        If (TheTextbox.TextLength / 2) <> (TheTextbox.TextLength \ 2) Then Return False

        For i = 0 To TheTextbox.Text.Length - 1 Step 2
            ' The first character has to be + or -
            If TheTextbox.Text.Substring(i, 1) <> "+" And TheTextbox.Text.Substring(i, 1) <> "-" Then IsValid = False
            ' The next character has to be numeric and less than 4
            If IsNumeric(TheTextbox.Text.Substring(i + 1, 1)) Then
                If CInt(TheTextbox.Text.Substring(i + 1, 1)) < 1 Or CInt(TheTextbox.Text.Substring(i + 1, 1)) > 3 Then IsValid = False
            Else
                IsValid = False
            End If
        Next

        Return IsValid

    End Function

End Class
