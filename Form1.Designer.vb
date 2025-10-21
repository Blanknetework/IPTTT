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
        MS = New MenuStrip()
        ArithmeticToolStripMenuItem = New ToolStripMenuItem()
        Add3NumbersToolStripMenuItem = New ToolStripMenuItem()
        SubstrucToolStripMenuItem = New ToolStripMenuItem()
        MultiplyBy3NumbersToolStripMenuItem = New ToolStripMenuItem()
        Divide3NumbersToolStripMenuItem = New ToolStripMenuItem()
        SelectionToolStripMenuItem = New ToolStripMenuItem()
        InputNumbersToolStripMenuItem = New ToolStripMenuItem()
        GradesAverageToolStripMenuItem = New ToolStripMenuItem()
        IterationToolStripMenuItem = New ToolStripMenuItem()
        SumOfFirstLastNumbersToolStripMenuItem = New ToolStripMenuItem()
        NicknameRepeaterToolStripMenuItem = New ToolStripMenuItem()
        ViewHistoryToolStripMenuItemToolStripMenuItem = New ToolStripMenuItem()
        ClearHistoryToolStripMenuItemToolStripMenuItem = New ToolStripMenuItem()
        MS.SuspendLayout()
        SuspendLayout()
        ' 
        ' MS
        ' 
        MS.Items.AddRange(New ToolStripItem() {ArithmeticToolStripMenuItem, SelectionToolStripMenuItem, IterationToolStripMenuItem, ViewHistoryToolStripMenuItemToolStripMenuItem, ClearHistoryToolStripMenuItemToolStripMenuItem})
        MS.Location = New Point(0, 0)
        MS.Name = "MS"
        MS.Size = New Size(800, 24)
        MS.TabIndex = 0
        MS.Text = "MenuStrip1"
        ' 
        ' ArithmeticToolStripMenuItem
        ' 
        ArithmeticToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Add3NumbersToolStripMenuItem, SubstrucToolStripMenuItem, MultiplyBy3NumbersToolStripMenuItem, Divide3NumbersToolStripMenuItem})
        ArithmeticToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ArithmeticToolStripMenuItem.Name = "ArithmeticToolStripMenuItem"
        ArithmeticToolStripMenuItem.Size = New Size(79, 20)
        ArithmeticToolStripMenuItem.Text = "Arithmetic"
        ' 
        ' Add3NumbersToolStripMenuItem
        ' 
        Add3NumbersToolStripMenuItem.Name = "Add3NumbersToolStripMenuItem"
        Add3NumbersToolStripMenuItem.Size = New Size(122, 22)
        Add3NumbersToolStripMenuItem.Text = "Add"
        ' 
        ' SubstrucToolStripMenuItem
        ' 
        SubstrucToolStripMenuItem.Name = "SubstrucToolStripMenuItem"
        SubstrucToolStripMenuItem.Size = New Size(122, 22)
        SubstrucToolStripMenuItem.Text = "Subtract"
        ' 
        ' MultiplyBy3NumbersToolStripMenuItem
        ' 
        MultiplyBy3NumbersToolStripMenuItem.Name = "MultiplyBy3NumbersToolStripMenuItem"
        MultiplyBy3NumbersToolStripMenuItem.Size = New Size(122, 22)
        MultiplyBy3NumbersToolStripMenuItem.Text = "Multiply"
        ' 
        ' Divide3NumbersToolStripMenuItem
        ' 
        Divide3NumbersToolStripMenuItem.Name = "Divide3NumbersToolStripMenuItem"
        Divide3NumbersToolStripMenuItem.Size = New Size(122, 22)
        Divide3NumbersToolStripMenuItem.Text = "Divide"
        ' 
        ' SelectionToolStripMenuItem
        ' 
        SelectionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InputNumbersToolStripMenuItem, GradesAverageToolStripMenuItem})
        SelectionToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SelectionToolStripMenuItem.Name = "SelectionToolStripMenuItem"
        SelectionToolStripMenuItem.Size = New Size(71, 20)
        SelectionToolStripMenuItem.Text = "Selection"
        ' 
        ' InputNumbersToolStripMenuItem
        ' 
        InputNumbersToolStripMenuItem.Name = "InputNumbersToolStripMenuItem"
        InputNumbersToolStripMenuItem.Size = New Size(175, 22)
        InputNumbersToolStripMenuItem.Text = "10 Input Numbers"
        ' 
        ' GradesAverageToolStripMenuItem
        ' 
        GradesAverageToolStripMenuItem.Name = "GradesAverageToolStripMenuItem"
        GradesAverageToolStripMenuItem.Size = New Size(175, 22)
        GradesAverageToolStripMenuItem.Text = "3 Grades Average"
        ' 
        ' IterationToolStripMenuItem
        ' 
        IterationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SumOfFirstLastNumbersToolStripMenuItem, NicknameRepeaterToolStripMenuItem})
        IterationToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IterationToolStripMenuItem.Name = "IterationToolStripMenuItem"
        IterationToolStripMenuItem.Size = New Size(68, 20)
        IterationToolStripMenuItem.Text = "Iteration"
        ' 
        ' SumOfFirstLastNumbersToolStripMenuItem
        ' 
        SumOfFirstLastNumbersToolStripMenuItem.Name = "SumOfFirstLastNumbersToolStripMenuItem"
        SumOfFirstLastNumbersToolStripMenuItem.Size = New Size(235, 22)
        SumOfFirstLastNumbersToolStripMenuItem.Text = "Sum of First & Last Numbers"
        ' 
        ' NicknameRepeaterToolStripMenuItem
        ' 
        NicknameRepeaterToolStripMenuItem.Name = "NicknameRepeaterToolStripMenuItem"
        NicknameRepeaterToolStripMenuItem.Size = New Size(235, 22)
        NicknameRepeaterToolStripMenuItem.Text = "Input Number and Nickname"
        ' 
        ' ViewHistoryToolStripMenuItemToolStripMenuItem
        ' 
        ViewHistoryToolStripMenuItemToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewHistoryToolStripMenuItemToolStripMenuItem.Name = "ViewHistoryToolStripMenuItemToolStripMenuItem"
        ViewHistoryToolStripMenuItemToolStripMenuItem.Size = New Size(90, 20)
        ViewHistoryToolStripMenuItemToolStripMenuItem.Text = "View History"
        ' 
        ' ClearHistoryToolStripMenuItemToolStripMenuItem
        ' 
        ClearHistoryToolStripMenuItemToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearHistoryToolStripMenuItemToolStripMenuItem.Name = "ClearHistoryToolStripMenuItemToolStripMenuItem"
        ClearHistoryToolStripMenuItemToolStripMenuItem.Size = New Size(90, 20)
        ClearHistoryToolStripMenuItemToolStripMenuItem.Text = "Clear History"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MS)
        MainMenuStrip = MS
        Name = "Form1"
        Text = "Form1"
        MS.ResumeLayout(False)
        MS.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MS As MenuStrip
    Friend WithEvents ArithmeticToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Add3NumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubstrucToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IterationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplyBy3NumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Divide3NumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradesAverageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumOfFirstLastNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NicknameRepeaterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHistoryToolStripMenuItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItemToolStripMenuItem As ToolStripMenuItem

End Class
