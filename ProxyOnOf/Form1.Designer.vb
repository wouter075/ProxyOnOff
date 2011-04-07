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
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.lblProfiel = New System.Windows.Forms.Label()
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
        Me.lbIP.Size = New System.Drawing.Size(225, 82)
        Me.lbIP.TabIndex = 2
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1000
        '
        'btnToggle
        '
        Me.btnToggle.Location = New System.Drawing.Point(24, 148)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(224, 32)
        Me.btnToggle.TabIndex = 3
        Me.btnToggle.Text = "Proxy: Inschakelen"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'lblProfiel
        '
        Me.lblProfiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProfiel.Location = New System.Drawing.Point(24, 110)
        Me.lblProfiel.Name = "lblProfiel"
        Me.lblProfiel.Size = New System.Drawing.Size(224, 22)
        Me.lblProfiel.TabIndex = 4
        Me.lblProfiel.Text = "Profiel: ..."
        Me.lblProfiel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 197)
        Me.Controls.Add(Me.lblProfiel)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.lbIP)
        Me.Controls.Add(Me.lblHostName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "ProxyOnOff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHostName As System.Windows.Forms.Label
    Friend WithEvents lbIP As System.Windows.Forms.ListBox
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents lblProfiel As System.Windows.Forms.Label

End Class
