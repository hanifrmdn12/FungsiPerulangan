<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        ListFor = New ListBox()
        GroupBox2 = New GroupBox()
        ListWhile = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ListFor)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 291)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "For"
        ' 
        ' ListFor
        ' 
        ListFor.FormattingEnabled = True
        ListFor.ItemHeight = 25
        ListFor.Location = New Point(12, 30)
        ListFor.Name = "ListFor"
        ListFor.Size = New Size(275, 254)
        ListFor.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListWhile)
        GroupBox2.Location = New Point(338, 0)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 291)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "While"
        ' 
        ' ListWhile
        ' 
        ListWhile.FormattingEnabled = True
        ListWhile.ItemHeight = 25
        ListWhile.Location = New Point(13, 29)
        ListWhile.Name = "ListWhile"
        ListWhile.Size = New Size(275, 254)
        ListWhile.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Belajar Perulangan"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListFor As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListWhile As ListBox

End Class
