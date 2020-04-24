<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRenamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRenamo))
        Me.TxtOutputPreview = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFormat = New System.Windows.Forms.TextBox()
        Me.TxtIndexStart = New System.Windows.Forms.TextBox()
        Me.LblFormat = New System.Windows.Forms.Label()
        Me.LblIndexStart = New System.Windows.Forms.Label()
        Me.BtnRenamo = New System.Windows.Forms.Button()
        Me.LblInstructions = New System.Windows.Forms.Label()
        Me.LblForcedDigits = New System.Windows.Forms.Label()
        Me.TxtForcedDigits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtOutputPreview
        '
        Me.TxtOutputPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOutputPreview.Location = New System.Drawing.Point(12, 180)
        Me.TxtOutputPreview.Multiline = True
        Me.TxtOutputPreview.Name = "TxtOutputPreview"
        Me.TxtOutputPreview.ReadOnly = True
        Me.TxtOutputPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutputPreview.Size = New System.Drawing.Size(776, 222)
        Me.TxtOutputPreview.TabIndex = 0
        Me.TxtOutputPreview.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preview of Renaming:"
        '
        'TxtFormat
        '
        Me.TxtFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFormat.Location = New System.Drawing.Point(162, 93)
        Me.TxtFormat.Name = "TxtFormat"
        Me.TxtFormat.Size = New System.Drawing.Size(414, 29)
        Me.TxtFormat.TabIndex = 2
        Me.TxtFormat.Text = "FRIENDS S03 E[#].mkv"
        '
        'TxtIndexStart
        '
        Me.TxtIndexStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIndexStart.Location = New System.Drawing.Point(310, 126)
        Me.TxtIndexStart.Name = "TxtIndexStart"
        Me.TxtIndexStart.Size = New System.Drawing.Size(53, 29)
        Me.TxtIndexStart.TabIndex = 3
        Me.TxtIndexStart.Text = "1"
        Me.TxtIndexStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblFormat
        '
        Me.LblFormat.AutoSize = True
        Me.LblFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormat.Location = New System.Drawing.Point(26, 96)
        Me.LblFormat.Name = "LblFormat"
        Me.LblFormat.Size = New System.Drawing.Size(130, 24)
        Me.LblFormat.TabIndex = 4
        Me.LblFormat.Text = "Name Format:"
        '
        'LblIndexStart
        '
        Me.LblIndexStart.AutoSize = True
        Me.LblIndexStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndexStart.Location = New System.Drawing.Point(175, 129)
        Me.LblIndexStart.Name = "LblIndexStart"
        Me.LblIndexStart.Size = New System.Drawing.Size(129, 24)
        Me.LblIndexStart.TabIndex = 5
        Me.LblIndexStart.Text = "Starting Index:"
        '
        'BtnRenamo
        '
        Me.BtnRenamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRenamo.Location = New System.Drawing.Point(615, 119)
        Me.BtnRenamo.Name = "BtnRenamo"
        Me.BtnRenamo.Size = New System.Drawing.Size(146, 45)
        Me.BtnRenamo.TabIndex = 6
        Me.BtnRenamo.Text = "RENAMO!"
        Me.BtnRenamo.UseVisualStyleBackColor = True
        '
        'LblInstructions
        '
        Me.LblInstructions.AutoSize = True
        Me.LblInstructions.Location = New System.Drawing.Point(22, 9)
        Me.LblInstructions.Name = "LblInstructions"
        Me.LblInstructions.Size = New System.Drawing.Size(503, 78)
        Me.LblInstructions.TabIndex = 7
        Me.LblInstructions.Text = resources.GetString("LblInstructions.Text")
        '
        'LblForcedDigits
        '
        Me.LblForcedDigits.AutoSize = True
        Me.LblForcedDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblForcedDigits.Location = New System.Drawing.Point(369, 129)
        Me.LblForcedDigits.Name = "LblForcedDigits"
        Me.LblForcedDigits.Size = New System.Drawing.Size(126, 24)
        Me.LblForcedDigits.TabIndex = 9
        Me.LblForcedDigits.Text = "Forced Digits:"
        '
        'TxtForcedDigits
        '
        Me.TxtForcedDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForcedDigits.Location = New System.Drawing.Point(501, 126)
        Me.TxtForcedDigits.Name = "TxtForcedDigits"
        Me.TxtForcedDigits.Size = New System.Drawing.Size(53, 29)
        Me.TxtForcedDigits.TabIndex = 8
        Me.TxtForcedDigits.Text = "2"
        Me.TxtForcedDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormRenamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 414)
        Me.Controls.Add(Me.LblForcedDigits)
        Me.Controls.Add(Me.TxtForcedDigits)
        Me.Controls.Add(Me.LblInstructions)
        Me.Controls.Add(Me.BtnRenamo)
        Me.Controls.Add(Me.LblIndexStart)
        Me.Controls.Add(Me.LblFormat)
        Me.Controls.Add(Me.TxtIndexStart)
        Me.Controls.Add(Me.TxtFormat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOutputPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormRenamo"
        Me.Text = "Renamo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOutputPreview As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtFormat As Windows.Forms.TextBox
    Friend WithEvents TxtIndexStart As Windows.Forms.TextBox
    Friend WithEvents LblFormat As Windows.Forms.Label
    Friend WithEvents LblIndexStart As Windows.Forms.Label
    Friend WithEvents BtnRenamo As Windows.Forms.Button
    Friend WithEvents LblInstructions As Windows.Forms.Label
    Friend WithEvents LblForcedDigits As Windows.Forms.Label
    Friend WithEvents TxtForcedDigits As Windows.Forms.TextBox
End Class
