Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.pdfViewerControl1 = New Bytescout.PDFViewer.PDFViewerControl()
        Me.txtSelectionPixel = New System.Windows.Forms.TextBox()
        Me.txtSelectionPDFUnit = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnGetSelectionPoints = New System.Windows.Forms.Button()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.Sample_UI_Application.My.Resources.Resources.folder_page
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(99, 24)
        Me.tsbOpen.Text = "&Open PDF"
        '
        'toolStrip1
        '
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1240, 27)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'pdfViewerControl1
        '
        Me.pdfViewerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 129)
        Me.pdfViewerControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection
        Me.pdfViewerControl1.Name = "pdfViewerControl1"
        Me.pdfViewerControl1.RegistrationKey = Nothing
        Me.pdfViewerControl1.RegistrationName = Nothing
        Me.pdfViewerControl1.ResetRotationOnPageChange = False
        Me.pdfViewerControl1.Scale = 100
        Me.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red
        Me.pdfViewerControl1.ShowImageObjects = True
        Me.pdfViewerControl1.ShowTextObjects = True
        Me.pdfViewerControl1.ShowVectorObjects = True
        Me.pdfViewerControl1.Size = New System.Drawing.Size(1240, 532)
        Me.pdfViewerControl1.TabIndex = 0
        '
        'txtSelectionPixel
        '
        Me.txtSelectionPixel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectionPixel.Location = New System.Drawing.Point(470, 84)
        Me.txtSelectionPixel.Multiline = True
        Me.txtSelectionPixel.Name = "txtSelectionPixel"
        Me.txtSelectionPixel.ReadOnly = True
        Me.txtSelectionPixel.Size = New System.Drawing.Size(761, 25)
        Me.txtSelectionPixel.TabIndex = 11
        '
        'txtSelectionPDFUnit
        '
        Me.txtSelectionPDFUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectionPDFUnit.Location = New System.Drawing.Point(470, 40)
        Me.txtSelectionPDFUnit.Multiline = True
        Me.txtSelectionPDFUnit.Name = "txtSelectionPDFUnit"
        Me.txtSelectionPDFUnit.ReadOnly = True
        Me.txtSelectionPDFUnit.Size = New System.Drawing.Size(761, 25)
        Me.txtSelectionPDFUnit.TabIndex = 10
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(187, 84)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label2.Size = New System.Drawing.Size(277, 25)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Selection in Pixels"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(187, 40)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label1.Size = New System.Drawing.Size(277, 25)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Selection in PDF Units"
        '
        'btnGetSelectionPoints
        '
        Me.btnGetSelectionPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetSelectionPoints.Location = New System.Drawing.Point(9, 40)
        Me.btnGetSelectionPoints.Name = "btnGetSelectionPoints"
        Me.btnGetSelectionPoints.Size = New System.Drawing.Size(172, 69)
        Me.btnGetSelectionPoints.TabIndex = 7
        Me.btnGetSelectionPoints.Text = "Get Selection Points"
        Me.btnGetSelectionPoints.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 663)
        Me.Controls.Add(Me.txtSelectionPixel)
        Me.Controls.Add(Me.txtSelectionPDFUnit)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnGetSelectionPoints)
        Me.Controls.Add(Me.pdfViewerControl1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tsbOpen As Windows.Forms.ToolStripButton
    Private WithEvents toolStrip1 As Windows.Forms.ToolStrip
    Private WithEvents pdfViewerControl1 As Bytescout.PDFViewer.PDFViewerControl
    Private WithEvents txtSelectionPixel As Windows.Forms.TextBox
    Private WithEvents txtSelectionPDFUnit As Windows.Forms.TextBox
    Private WithEvents label2 As Windows.Forms.Label
    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents btnGetSelectionPoints As Windows.Forms.Button

#End Region
End Class

