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
        RdioM_to_In = New RadioButton()
        RdioIn_to_M = New RadioButton()
        BtnConvert = New Button()
        BtnClear = New Button()
        BtnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        TextBxInput = New TextBox()
        LblOutput = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSlateBlue
        GroupBox1.Controls.Add(RdioM_to_In)
        GroupBox1.Controls.Add(RdioIn_to_M)
        GroupBox1.Font = New Font("Segoe UI", 15F)
        GroupBox1.ForeColor = Color.Snow
        GroupBox1.Location = New Point(343, 205)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(236, 92)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Convert Measurement"
        ' 
        ' RdioM_to_In
        ' 
        RdioM_to_In.AutoSize = True
        RdioM_to_In.Location = New Point(19, 50)
        RdioM_to_In.Name = "RdioM_to_In"
        RdioM_to_In.Size = New Size(173, 32)
        RdioM_to_In.TabIndex = 1
        RdioM_to_In.TabStop = True
        RdioM_to_In.Text = "Meters to Inches"
        RdioM_to_In.UseVisualStyleBackColor = True
        ' 
        ' RdioIn_to_M
        ' 
        RdioIn_to_M.AutoSize = True
        RdioIn_to_M.Location = New Point(19, 25)
        RdioIn_to_M.Name = "RdioIn_to_M"
        RdioIn_to_M.Size = New Size(173, 32)
        RdioIn_to_M.TabIndex = 0
        RdioIn_to_M.TabStop = True
        RdioIn_to_M.Text = "Inches to Meters"
        RdioIn_to_M.UseVisualStyleBackColor = True
        ' 
        ' BtnConvert
        ' 
        BtnConvert.ForeColor = Color.Black
        BtnConvert.Location = New Point(58, 388)
        BtnConvert.Name = "BtnConvert"
        BtnConvert.Size = New Size(150, 50)
        BtnConvert.TabIndex = 1
        BtnConvert.Text = "Convert"
        BtnConvert.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.ForeColor = Color.Black
        BtnClear.Location = New Point(239, 388)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(150, 50)
        BtnClear.TabIndex = 2
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.ForeColor = Color.Black
        BtnExit.Location = New Point(420, 388)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(150, 50)
        BtnExit.TabIndex = 3
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(337, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 37)
        Label1.TabIndex = 4
        Label1.Text = "Converter App"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(291, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 50)
        Label2.TabIndex = 6
        Label2.Text = "Enter a value and" & vbCrLf & "choose a conversion"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.building
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 211)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' TextBxInput
        ' 
        TextBxInput.BackColor = Color.DarkSlateBlue
        TextBxInput.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBxInput.ForeColor = Color.White
        TextBxInput.Location = New Point(489, 110)
        TextBxInput.Name = "TextBxInput"
        TextBxInput.Size = New Size(100, 33)
        TextBxInput.TabIndex = 5
        TextBxInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblOutput
        ' 
        LblOutput.AutoSize = True
        LblOutput.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblOutput.ForeColor = Color.Black
        LblOutput.Location = New Point(314, 331)
        LblOutput.Name = "LblOutput"
        LblOutput.Size = New Size(0, 25)
        LblOutput.TabIndex = 8
        LblOutput.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(628, 450)
        Controls.Add(LblOutput)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(TextBxInput)
        Controls.Add(Label1)
        Controls.Add(BtnExit)
        Controls.Add(BtnClear)
        Controls.Add(BtnConvert)
        Controls.Add(GroupBox1)
        ForeColor = Color.Coral
        Name = "Form1"
        Text = "Building Plans Conversion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdioM_to_In As RadioButton
    Friend WithEvents RdioIn_to_M As RadioButton
    Friend WithEvents BtnConvert As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBxInput As TextBox
    Friend WithEvents LblOutput As Label

End Class
