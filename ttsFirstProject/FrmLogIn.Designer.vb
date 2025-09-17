<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogIn
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TxtEditUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TxtEditPass = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BtnRegister = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BtnLogIn = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEditPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BtnLogIn)
        Me.LayoutControl1.Controls.Add(Me.BtnRegister)
        Me.LayoutControl1.Controls.Add(Me.TxtEditPass)
        Me.LayoutControl1.Controls.Add(Me.TxtEditUserName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(922, 517)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(922, 517)
        Me.Root.TextVisible = False
        '
        'TxtEditUserName
        '
        Me.TxtEditUserName.Location = New System.Drawing.Point(87, 12)
        Me.TxtEditUserName.Name = "TxtEditUserName"
        Me.TxtEditUserName.Size = New System.Drawing.Size(823, 22)
        Me.TxtEditUserName.StyleController = Me.LayoutControl1
        Me.TxtEditUserName.TabIndex = 1
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtEditUserName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(902, 26)
        Me.LayoutControlItem1.Text = "User Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(63, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 114)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(902, 383)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'TxtEditPass
        '
        Me.TxtEditPass.Location = New System.Drawing.Point(87, 38)
        Me.TxtEditPass.Name = "TxtEditPass"
        Me.TxtEditPass.Size = New System.Drawing.Size(823, 22)
        Me.TxtEditPass.StyleController = Me.LayoutControl1
        Me.TxtEditPass.TabIndex = 4
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtEditPass
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(902, 26)
        Me.LayoutControlItem2.Text = "Password"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(63, 16)
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(12, 64)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(898, 27)
        Me.BtnRegister.StyleController = Me.LayoutControl1
        Me.BtnRegister.TabIndex = 5
        Me.BtnRegister.Text = "Register"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.BtnRegister
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(902, 31)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'BtnLogIn
        '
        Me.BtnLogIn.Location = New System.Drawing.Point(12, 95)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(898, 27)
        Me.BtnLogIn.StyleController = Me.LayoutControl1
        Me.BtnLogIn.TabIndex = 6
        Me.BtnLogIn.Text = "Log in"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.BtnLogIn
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 83)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(902, 31)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 517)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmLogIn"
        Me.Text = "FrmLogIn"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEditPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents BtnRegister As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEditPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEditUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnLogIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
