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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.grpConversions = New System.Windows.Forms.GroupBox()
        Me.radInToM = New System.Windows.Forms.RadioButton()
        Me.radMToIn = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConverted = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(434, 39)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(205, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Converter App"
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.Midterm_ConverterApp_CPSC3118.My.Resources.Resources.building
        Me.picBuilding.Location = New System.Drawing.Point(0, 0)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(274, 211)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBuilding.TabIndex = 1
        Me.picBuilding.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(333, 111)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(228, 50)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and choose a conversion"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMeasurement
        '
        Me.txtMeasurement.BackColor = System.Drawing.Color.Indigo
        Me.txtMeasurement.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeasurement.ForeColor = System.Drawing.Color.White
        Me.txtMeasurement.Location = New System.Drawing.Point(637, 121)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(100, 32)
        Me.txtMeasurement.TabIndex = 3
        Me.txtMeasurement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConversions
        '
        Me.grpConversions.BackColor = System.Drawing.Color.Indigo
        Me.grpConversions.Controls.Add(Me.radMToIn)
        Me.grpConversions.Controls.Add(Me.radInToM)
        Me.grpConversions.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversions.ForeColor = System.Drawing.Color.White
        Me.grpConversions.Location = New System.Drawing.Point(412, 197)
        Me.grpConversions.Name = "grpConversions"
        Me.grpConversions.Size = New System.Drawing.Size(249, 118)
        Me.grpConversions.TabIndex = 4
        Me.grpConversions.TabStop = False
        Me.grpConversions.Text = "Convert Measurement"
        '
        'radInToM
        '
        Me.radInToM.AutoSize = True
        Me.radInToM.Checked = True
        Me.radInToM.Location = New System.Drawing.Point(16, 45)
        Me.radInToM.Name = "radInToM"
        Me.radInToM.Size = New System.Drawing.Size(195, 28)
        Me.radInToM.TabIndex = 0
        Me.radInToM.TabStop = True
        Me.radInToM.Text = "Inches to Meters"
        Me.radInToM.UseVisualStyleBackColor = True
        '
        'radMToIn
        '
        Me.radMToIn.AutoSize = True
        Me.radMToIn.Location = New System.Drawing.Point(16, 80)
        Me.radMToIn.Name = "radMToIn"
        Me.radMToIn.Size = New System.Drawing.Size(195, 28)
        Me.radMToIn.TabIndex = 1
        Me.radMToIn.Text = "Meters to Inches"
        Me.radMToIn.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConvert.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(76, 382)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(152, 45)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(337, 382)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 45)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(585, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConverted
        '
        Me.lblConverted.AutoSize = True
        Me.lblConverted.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverted.Location = New System.Drawing.Point(424, 340)
        Me.lblConverted.Name = "lblConverted"
        Me.lblConverted.Size = New System.Drawing.Size(0, 19)
        Me.lblConverted.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblConverted)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpConversions)
        Me.Controls.Add(Me.txtMeasurement)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picBuilding)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversions.ResumeLayout(False)
        Me.grpConversions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtMeasurement As TextBox
    Friend WithEvents grpConversions As GroupBox
    Friend WithEvents radMToIn As RadioButton
    Friend WithEvents radInToM As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConverted As Label
End Class
