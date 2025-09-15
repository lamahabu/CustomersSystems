<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditCustomer
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditCustomer))
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.btnAddContact = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContactPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Savebtn = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.CustomerName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Email = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Phone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.City = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.btnAddContact)
        Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
        Me.DataLayoutControl1.Controls.Add(Me.Savebtn)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit4)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit3)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit2)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(705, 511)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(12, 441)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(671, 27)
        Me.btnAddContact.StyleController = Me.DataLayoutControl1
        Me.btnAddContact.TabIndex = 10
        Me.btnAddContact.Text = "Add contact "
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 116)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(671, 321)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ContactName, Me.ContactPhone, Me.btnDelete})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ContactName
        '
        Me.ContactName.Caption = "Contact name "
        Me.ContactName.MinWidth = 25
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Visible = True
        Me.ContactName.VisibleIndex = 0
        Me.ContactName.Width = 94
        '
        'ContactPhone
        '
        Me.ContactPhone.Caption = "Phone"
        Me.ContactPhone.MinWidth = 25
        Me.ContactPhone.Name = "ContactPhone"
        Me.ContactPhone.Visible = True
        Me.ContactPhone.VisibleIndex = 1
        Me.ContactPhone.Width = 94
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete "
        Me.btnDelete.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.btnDelete.MinWidth = 25
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Visible = True
        Me.btnDelete.VisibleIndex = 2
        Me.btnDelete.Width = 94
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(12, 472)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(681, 27)
        Me.Savebtn.StyleController = Me.DataLayoutControl1
        Me.Savebtn.TabIndex = 8
        Me.Savebtn.Text = "Save"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(112, 90)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(581, 22)
        Me.TextEdit4.StyleController = Me.DataLayoutControl1
        Me.TextEdit4.TabIndex = 7
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(112, 64)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(581, 22)
        Me.TextEdit3.StyleController = Me.DataLayoutControl1
        Me.TextEdit3.TabIndex = 6
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(112, 38)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(581, 22)
        Me.TextEdit2.StyleController = Me.DataLayoutControl1
        Me.TextEdit2.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(112, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(581, 22)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.CustomerName, Me.EmptySpaceItem1, Me.Email, Me.Phone, Me.City, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(705, 511)
        Me.Root.TextVisible = False
        '
        'CustomerName
        '
        Me.CustomerName.Control = Me.TextEdit1
        Me.CustomerName.Location = New System.Drawing.Point(0, 0)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(685, 26)
        Me.CustomerName.TextSize = New System.Drawing.Size(88, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(675, 104)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 356)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Email
        '
        Me.Email.Control = Me.TextEdit2
        Me.Email.Location = New System.Drawing.Point(0, 26)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(685, 26)
        Me.Email.TextSize = New System.Drawing.Size(88, 16)
        '
        'Phone
        '
        Me.Phone.Control = Me.TextEdit3
        Me.Phone.Location = New System.Drawing.Point(0, 52)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(685, 26)
        Me.Phone.TextSize = New System.Drawing.Size(88, 16)
        '
        'City
        '
        Me.City.Control = Me.TextEdit4
        Me.City.Location = New System.Drawing.Point(0, 78)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(685, 26)
        Me.City.TextSize = New System.Drawing.Size(88, 16)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Savebtn
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 460)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(685, 31)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(675, 325)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnAddContact
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 429)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(675, 31)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'FrmEditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Name = "FrmEditCustomer"
        Me.Text = "XtraForm1"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.City, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Email As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Phone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents City As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Savebtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContactPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddContact As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
