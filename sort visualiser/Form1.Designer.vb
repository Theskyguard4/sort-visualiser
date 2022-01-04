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
        Me.bubblesortbut = New System.Windows.Forms.Button()
        Me.mergesortbut = New System.Windows.Forms.Button()
        Me.quicksortbut = New System.Windows.Forms.Button()
        Me.createnewgraphbut = New System.Windows.Forms.Button()
        Me.howmanyitemsinputbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bubblesortbut
        '
        Me.bubblesortbut.Location = New System.Drawing.Point(12, 12)
        Me.bubblesortbut.Name = "bubblesortbut"
        Me.bubblesortbut.Size = New System.Drawing.Size(203, 51)
        Me.bubblesortbut.TabIndex = 0
        Me.bubblesortbut.Text = "Bubble Sort"
        Me.bubblesortbut.UseVisualStyleBackColor = True
        '
        'mergesortbut
        '
        Me.mergesortbut.Location = New System.Drawing.Point(221, 12)
        Me.mergesortbut.Name = "mergesortbut"
        Me.mergesortbut.Size = New System.Drawing.Size(203, 51)
        Me.mergesortbut.TabIndex = 1
        Me.mergesortbut.Text = "Merge Sort"
        Me.mergesortbut.UseVisualStyleBackColor = True
        '
        'quicksortbut
        '
        Me.quicksortbut.BackColor = System.Drawing.Color.Gainsboro
        Me.quicksortbut.Location = New System.Drawing.Point(430, 12)
        Me.quicksortbut.Name = "quicksortbut"
        Me.quicksortbut.Size = New System.Drawing.Size(203, 51)
        Me.quicksortbut.TabIndex = 2
        Me.quicksortbut.Text = "Quick Sort"
        Me.quicksortbut.UseVisualStyleBackColor = False
        '
        'createnewgraphbut
        '
        Me.createnewgraphbut.Location = New System.Drawing.Point(1129, 12)
        Me.createnewgraphbut.Name = "createnewgraphbut"
        Me.createnewgraphbut.Size = New System.Drawing.Size(369, 51)
        Me.createnewgraphbut.TabIndex = 3
        Me.createnewgraphbut.Text = "Create New Graph"
        Me.createnewgraphbut.UseVisualStyleBackColor = True
        '
        'howmanyitemsinputbox
        '
        Me.howmanyitemsinputbox.Location = New System.Drawing.Point(1245, 68)
        Me.howmanyitemsinputbox.Name = "howmanyitemsinputbox"
        Me.howmanyitemsinputbox.Size = New System.Drawing.Size(253, 22)
        Me.howmanyitemsinputbox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1129, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How Many Items"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(639, 12)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(484, 56)
        Me.TrackBar1.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1510, 537)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.howmanyitemsinputbox)
        Me.Controls.Add(Me.createnewgraphbut)
        Me.Controls.Add(Me.quicksortbut)
        Me.Controls.Add(Me.mergesortbut)
        Me.Controls.Add(Me.bubblesortbut)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bubblesortbut As System.Windows.Forms.Button
    Friend WithEvents mergesortbut As System.Windows.Forms.Button
    Friend WithEvents quicksortbut As System.Windows.Forms.Button
    Friend WithEvents createnewgraphbut As System.Windows.Forms.Button
    Friend WithEvents howmanyitemsinputbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
