<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFallMarathon
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
        Me.lblFallMarathon = New System.Windows.Forms.Label()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.btmStartLocation = New System.Windows.Forms.Button()
        Me.btmExit = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btmDate = New System.Windows.Forms.Button()
        Me.btmDetails = New System.Windows.Forms.Button()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFallMarathon
        '
        Me.lblFallMarathon.AutoSize = True
        Me.lblFallMarathon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFallMarathon.Location = New System.Drawing.Point(119, 9)
        Me.lblFallMarathon.Name = "lblFallMarathon"
        Me.lblFallMarathon.Size = New System.Drawing.Size(119, 20)
        Me.lblFallMarathon.TabIndex = 0
        Me.lblFallMarathon.Text = "Fall Marathon"
        '
        'picMarathon
        '
        Me.picMarathon.Location = New System.Drawing.Point(118, 50)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(120, 62)
        Me.picMarathon.TabIndex = 1
        Me.picMarathon.TabStop = False
        '
        'btmStartLocation
        '
        Me.btmStartLocation.Location = New System.Drawing.Point(124, 172)
        Me.btmStartLocation.Name = "btmStartLocation"
        Me.btmStartLocation.Size = New System.Drawing.Size(100, 23)
        Me.btmStartLocation.TabIndex = 2
        Me.btmStartLocation.Text = "Start Location" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btmStartLocation.UseVisualStyleBackColor = True
        '
        'btmExit
        '
        Me.btmExit.Location = New System.Drawing.Point(269, 284)
        Me.btmExit.Name = "btmExit"
        Me.btmExit.Size = New System.Drawing.Size(75, 23)
        Me.btmExit.TabIndex = 3
        Me.btmExit.Text = "Exit"
        Me.btmExit.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(71, 128)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(215, 13)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "full- and half-marathon runners are welcome."
        '
        'btmDate
        '
        Me.btmDate.Location = New System.Drawing.Point(12, 172)
        Me.btmDate.Name = "btmDate"
        Me.btmDate.Size = New System.Drawing.Size(75, 23)
        Me.btmDate.TabIndex = 5
        Me.btmDate.Text = "Date"
        Me.btmDate.UseVisualStyleBackColor = True
        '
        'btmDetails
        '
        Me.btmDetails.Location = New System.Drawing.Point(244, 172)
        Me.btmDetails.Name = "btmDetails"
        Me.btmDetails.Size = New System.Drawing.Size(75, 23)
        Me.btmDetails.TabIndex = 6
        Me.btmDetails.Text = "Details"
        Me.btmDetails.UseVisualStyleBackColor = True
        '
        'frmFallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 319)
        Me.Controls.Add(Me.btmDetails)
        Me.Controls.Add(Me.btmDate)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btmExit)
        Me.Controls.Add(Me.btmStartLocation)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.lblFallMarathon)
        Me.Name = "frmFallMarathon"
        Me.Text = "Fall Marathon"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFallMarathon As Label
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents btmStartLocation As Button
    Friend WithEvents btmExit As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btmDate As Button
    Friend WithEvents btmDetails As Button
End Class
