<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHostName = New System.Windows.Forms.Label()
        Me.lbIP = New System.Windows.Forms.ListBox()
        Me.lblProfiel = New System.Windows.Forms.Label()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHostName
        '
        Me.lblHostName.AutoSize = True
        Me.lblHostName.Location = New System.Drawing.Point(20, 9)
        Me.lblHostName.Name = "lblHostName"
        Me.lblHostName.Size = New System.Drawing.Size(0, 13)
        Me.lblHostName.TabIndex = 0
        '
        'lbIP
        '
        Me.lbIP.FormattingEnabled = True
        Me.lbIP.Location = New System.Drawing.Point(23, 25)
        Me.lbIP.Name = "lbIP"
        Me.lbIP.Size = New System.Drawing.Size(225, 186)
        Me.lbIP.TabIndex = 2
        '
        'lblProfiel
        '
        Me.lblProfiel.AutoSize = True
        Me.lblProfiel.Location = New System.Drawing.Point(20, 230)
        Me.lblProfiel.Name = "lblProfiel"
        Me.lblProfiel.Size = New System.Drawing.Size(42, 13)
        Me.lblProfiel.TabIndex = 3
        Me.lblProfiel.Text = "Profiel: "
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 258)
        Me.Controls.Add(Me.lblProfiel)
        Me.Controls.Add(Me.lbIP)
        Me.Controls.Add(Me.lblHostName)
        Me.Name = "Form1"
        Me.Text = "ProxyOnOff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHostName As System.Windows.Forms.Label
    Friend WithEvents lbIP As System.Windows.Forms.ListBox
    Friend WithEvents lblProfiel As System.Windows.Forms.Label
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer

End Class
