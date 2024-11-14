<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvenSearchMethodForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        x0_TB = New TextBox()
        iterationLimit_TB = New TextBox()
        h_TB = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        tol_TB = New TextBox()
        timeLimit_TB = New TextBox()
        minimum_RB = New RadioButton()
        maximum_RB = New RadioButton()
        ProgressBar1 = New ProgressBar()
        runESM_BTN = New Button()
        drawGraph_BTN = New Button()
        setPoint_BTN = New Button()
        clear_BTN = New Button()
        Label7 = New Label()
        solution_TB = New TextBox()
        Label8 = New Label()
        valueOfSolution_TB = New TextBox()
        Label11 = New Label()
        valueDiffPlus_TB = New TextBox()
        Label12 = New Label()
        valueDiffMinus_TB = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        h_result_TB = New TextBox()
        Label15 = New Label()
        iterationsAmount_TB = New TextBox()
        Label16 = New Label()
        elapsedTime_TB = New TextBox()
        functions_CB = New ComboBox()
        validation_TB = New TextBox()
        input_GB = New GroupBox()
        output_GB = New GroupBox()
        input_GB.SuspendLayout()
        output_GB.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "Function f(x)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 20)
        Label2.TabIndex = 1
        Label2.Text = "x0:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 2
        Label3.Text = "Limit of iterations:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 20)
        Label4.TabIndex = 3
        Label4.Text = "H (H <= Tolerance):"
        ' 
        ' x0_TB
        ' 
        x0_TB.Location = New Point(104, 76)
        x0_TB.Margin = New Padding(3, 4, 3, 4)
        x0_TB.Name = "x0_TB"
        x0_TB.Size = New Size(154, 27)
        x0_TB.TabIndex = 5
        x0_TB.Text = "2"
        ' 
        ' iterationLimit_TB
        ' 
        iterationLimit_TB.Location = New Point(153, 210)
        iterationLimit_TB.Margin = New Padding(3, 4, 3, 4)
        iterationLimit_TB.Name = "iterationLimit_TB"
        iterationLimit_TB.Size = New Size(154, 27)
        iterationLimit_TB.TabIndex = 6
        iterationLimit_TB.Text = "100"
        ' 
        ' h_TB
        ' 
        h_TB.Location = New Point(153, 165)
        h_TB.Margin = New Padding(3, 4, 3, 4)
        h_TB.Name = "h_TB"
        h_TB.Size = New Size(149, 27)
        h_TB.TabIndex = 7
        h_TB.Text = "1e-2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 8
        Label5.Text = "Tolerance:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 252)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 20)
        Label6.TabIndex = 9
        Label6.Text = "Limit of time:"
        ' 
        ' tol_TB
        ' 
        tol_TB.Location = New Point(104, 121)
        tol_TB.Margin = New Padding(3, 4, 3, 4)
        tol_TB.Name = "tol_TB"
        tol_TB.Size = New Size(154, 27)
        tol_TB.TabIndex = 10
        tol_TB.Text = "1e-2"
        ' 
        ' timeLimit_TB
        ' 
        timeLimit_TB.Location = New Point(153, 245)
        timeLimit_TB.Margin = New Padding(3, 4, 3, 4)
        timeLimit_TB.Name = "timeLimit_TB"
        timeLimit_TB.Size = New Size(149, 27)
        timeLimit_TB.TabIndex = 11
        timeLimit_TB.Text = "5"
        ' 
        ' minimum_RB
        ' 
        minimum_RB.AutoSize = True
        minimum_RB.Checked = True
        minimum_RB.Location = New Point(54, 307)
        minimum_RB.Margin = New Padding(3, 4, 3, 4)
        minimum_RB.Name = "minimum_RB"
        minimum_RB.Size = New Size(93, 24)
        minimum_RB.TabIndex = 12
        minimum_RB.TabStop = True
        minimum_RB.Text = "Minimum"
        minimum_RB.UseVisualStyleBackColor = True
        ' 
        ' maximum_RB
        ' 
        maximum_RB.AutoSize = True
        maximum_RB.Location = New Point(153, 305)
        maximum_RB.Margin = New Padding(3, 4, 3, 4)
        maximum_RB.Name = "maximum_RB"
        maximum_RB.Size = New Size(96, 24)
        maximum_RB.TabIndex = 13
        maximum_RB.Text = "Maximum"
        maximum_RB.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(34, 356)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(311, 31)
        ProgressBar1.TabIndex = 14
        ' 
        ' runESM_BTN
        ' 
        runESM_BTN.Location = New Point(288, 307)
        runESM_BTN.Margin = New Padding(3, 4, 3, 4)
        runESM_BTN.Name = "runESM_BTN"
        runESM_BTN.Size = New Size(169, 31)
        runESM_BTN.TabIndex = 15
        runESM_BTN.Text = "Run Even Search Method"
        runESM_BTN.UseVisualStyleBackColor = True
        ' 
        ' drawGraph_BTN
        ' 
        drawGraph_BTN.Location = New Point(566, 436)
        drawGraph_BTN.Margin = New Padding(3, 4, 3, 4)
        drawGraph_BTN.Name = "drawGraph_BTN"
        drawGraph_BTN.Size = New Size(135, 31)
        drawGraph_BTN.TabIndex = 16
        drawGraph_BTN.Text = "Draw graph"
        drawGraph_BTN.UseVisualStyleBackColor = True
        ' 
        ' setPoint_BTN
        ' 
        setPoint_BTN.Location = New Point(466, 475)
        setPoint_BTN.Margin = New Padding(3, 4, 3, 4)
        setPoint_BTN.Name = "setPoint_BTN"
        setPoint_BTN.Size = New Size(169, 31)
        setPoint_BTN.TabIndex = 17
        setPoint_BTN.Text = "Set point like X0"
        setPoint_BTN.UseVisualStyleBackColor = True
        ' 
        ' clear_BTN
        ' 
        clear_BTN.Location = New Point(707, 460)
        clear_BTN.Margin = New Padding(3, 4, 3, 4)
        clear_BTN.Name = "clear_BTN"
        clear_BTN.Size = New Size(135, 31)
        clear_BTN.TabIndex = 18
        clear_BTN.Text = "Clear output"
        clear_BTN.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(27, 20)
        Label7.TabIndex = 19
        Label7.Text = "X*:"
        ' 
        ' solution_TB
        ' 
        solution_TB.Location = New Point(7, 47)
        solution_TB.Margin = New Padding(3, 4, 3, 4)
        solution_TB.Name = "solution_TB"
        solution_TB.ReadOnly = True
        solution_TB.Size = New Size(249, 27)
        solution_TB.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(265, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 20)
        Label8.TabIndex = 21
        Label8.Text = "f(X*):"
        ' 
        ' valueOfSolution_TB
        ' 
        valueOfSolution_TB.Location = New Point(265, 47)
        valueOfSolution_TB.Margin = New Padding(3, 4, 3, 4)
        valueOfSolution_TB.Name = "valueOfSolution_TB"
        valueOfSolution_TB.ReadOnly = True
        valueOfSolution_TB.Size = New Size(249, 27)
        valueOfSolution_TB.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 83)
        Label11.Name = "Label11"
        Label11.Size = New Size(156, 20)
        Label11.TabIndex = 27
        Label11.Text = "f(X*) - f(X*-Tolerance):"
        ' 
        ' valueDiffPlus_TB
        ' 
        valueDiffPlus_TB.Location = New Point(7, 107)
        valueDiffPlus_TB.Margin = New Padding(3, 4, 3, 4)
        valueDiffPlus_TB.Name = "valueDiffPlus_TB"
        valueDiffPlus_TB.ReadOnly = True
        valueDiffPlus_TB.Size = New Size(249, 27)
        valueDiffPlus_TB.TabIndex = 28
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(265, 83)
        Label12.Name = "Label12"
        Label12.Size = New Size(160, 20)
        Label12.TabIndex = 29
        Label12.Text = "f(X*) - f(X*+Tolerance):"
        ' 
        ' valueDiffMinus_TB
        ' 
        valueDiffMinus_TB.Location = New Point(265, 107)
        valueDiffMinus_TB.Margin = New Padding(3, 4, 3, 4)
        valueDiffMinus_TB.Name = "valueDiffMinus_TB"
        valueDiffMinus_TB.ReadOnly = True
        valueDiffMinus_TB.Size = New Size(249, 27)
        valueDiffMinus_TB.TabIndex = 30
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(7, 200)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 20)
        Label13.TabIndex = 31
        Label13.Text = "Validation:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(7, 141)
        Label14.Name = "Label14"
        Label14.Size = New Size(23, 20)
        Label14.TabIndex = 33
        Label14.Text = "H:"
        ' 
        ' h_result_TB
        ' 
        h_result_TB.Location = New Point(7, 165)
        h_result_TB.Margin = New Padding(3, 4, 3, 4)
        h_result_TB.Name = "h_result_TB"
        h_result_TB.ReadOnly = True
        h_result_TB.Size = New Size(189, 27)
        h_result_TB.TabIndex = 34
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(203, 141)
        Label15.Name = "Label15"
        Label15.Size = New Size(150, 20)
        Label15.TabIndex = 35
        Label15.Text = "Number of iterations:"
        ' 
        ' iterationsAmount_TB
        ' 
        iterationsAmount_TB.Location = New Point(203, 165)
        iterationsAmount_TB.Margin = New Padding(3, 4, 3, 4)
        iterationsAmount_TB.Name = "iterationsAmount_TB"
        iterationsAmount_TB.ReadOnly = True
        iterationsAmount_TB.Size = New Size(137, 27)
        iterationsAmount_TB.TabIndex = 36
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(345, 141)
        Label16.Name = "Label16"
        Label16.Size = New Size(133, 20)
        Label16.TabIndex = 37
        Label16.Text = "Elapsed time (sec):"
        ' 
        ' elapsedTime_TB
        ' 
        elapsedTime_TB.Location = New Point(345, 165)
        elapsedTime_TB.Margin = New Padding(3, 4, 3, 4)
        elapsedTime_TB.Name = "elapsedTime_TB"
        elapsedTime_TB.ReadOnly = True
        elapsedTime_TB.Size = New Size(169, 27)
        elapsedTime_TB.TabIndex = 38
        ' 
        ' functions_CB
        ' 
        functions_CB.FormattingEnabled = True
        functions_CB.Items.AddRange(New Object() {"(4*sin(x)-((x^2+2)/(2*x-1)))^2", "(x-2)^2-ln(x)", "(x-4)^2", "(x-2)^2-log(x)", "x*exp(-x)"})
        functions_CB.Location = New Point(104, 22)
        functions_CB.Margin = New Padding(3, 4, 3, 4)
        functions_CB.Name = "functions_CB"
        functions_CB.Size = New Size(310, 28)
        functions_CB.TabIndex = 40
        functions_CB.Text = "(4*sin(x)-((x^2+2)/(2*x-1)))^2"
        ' 
        ' validation_TB
        ' 
        validation_TB.Location = New Point(29, 258)
        validation_TB.Margin = New Padding(3, 4, 3, 4)
        validation_TB.Multiline = True
        validation_TB.Name = "validation_TB"
        validation_TB.ReadOnly = True
        validation_TB.Size = New Size(507, 146)
        validation_TB.TabIndex = 41
        ' 
        ' input_GB
        ' 
        input_GB.Controls.Add(Label1)
        input_GB.Controls.Add(Label3)
        input_GB.Controls.Add(runESM_BTN)
        input_GB.Controls.Add(functions_CB)
        input_GB.Controls.Add(Label4)
        input_GB.Controls.Add(x0_TB)
        input_GB.Controls.Add(iterationLimit_TB)
        input_GB.Controls.Add(h_TB)
        input_GB.Controls.Add(Label5)
        input_GB.Controls.Add(Label6)
        input_GB.Controls.Add(tol_TB)
        input_GB.Controls.Add(timeLimit_TB)
        input_GB.Controls.Add(minimum_RB)
        input_GB.Controls.Add(maximum_RB)
        input_GB.Controls.Add(ProgressBar1)
        input_GB.Controls.Add(Label2)
        input_GB.Location = New Point(14, 16)
        input_GB.Margin = New Padding(3, 4, 3, 4)
        input_GB.Name = "input_GB"
        input_GB.Padding = New Padding(3, 4, 3, 4)
        input_GB.Size = New Size(501, 412)
        input_GB.TabIndex = 42
        input_GB.TabStop = False
        input_GB.Text = "Input"
        ' 
        ' output_GB
        ' 
        output_GB.Controls.Add(validation_TB)
        output_GB.Controls.Add(Label7)
        output_GB.Controls.Add(solution_TB)
        output_GB.Controls.Add(elapsedTime_TB)
        output_GB.Controls.Add(Label8)
        output_GB.Controls.Add(Label16)
        output_GB.Controls.Add(valueOfSolution_TB)
        output_GB.Controls.Add(iterationsAmount_TB)
        output_GB.Controls.Add(Label15)
        output_GB.Controls.Add(h_result_TB)
        output_GB.Controls.Add(Label14)
        output_GB.Controls.Add(Label13)
        output_GB.Controls.Add(Label11)
        output_GB.Controls.Add(valueDiffMinus_TB)
        output_GB.Controls.Add(valueDiffPlus_TB)
        output_GB.Controls.Add(Label12)
        output_GB.Location = New Point(521, 16)
        output_GB.Margin = New Padding(3, 4, 3, 4)
        output_GB.Name = "output_GB"
        output_GB.Padding = New Padding(3, 4, 3, 4)
        output_GB.Size = New Size(523, 412)
        output_GB.TabIndex = 43
        output_GB.TabStop = False
        output_GB.Text = "Output"
        ' 
        ' EvenSearchMethodForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1122, 595)
        Controls.Add(output_GB)
        Controls.Add(input_GB)
        Controls.Add(drawGraph_BTN)
        Controls.Add(setPoint_BTN)
        Controls.Add(clear_BTN)
        Margin = New Padding(3, 4, 3, 4)
        Name = "EvenSearchMethodForm"
        Text = "ESM Kopzhasharov Azamat PI-3-21"
        input_GB.ResumeLayout(False)
        input_GB.PerformLayout()
        output_GB.ResumeLayout(False)
        output_GB.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents x0_TB As TextBox
    Friend WithEvents iterationLimit_TB As TextBox
    Friend WithEvents h_TB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tol_TB As TextBox
    Friend WithEvents timeLimit_TB As TextBox
    Friend WithEvents minimum_RB As RadioButton
    Friend WithEvents maximum_RB As RadioButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents runESM_BTN As Button
    Friend WithEvents drawGraph_BTN As Button
    Friend WithEvents setPoint_BTN As Button
    Friend WithEvents clear_BTN As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents solution_TB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents valueOfSolution_TB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents valueDiffPlus_TB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents valueDiffMinus_TB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents h_result_TB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents iterationsAmount_TB As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents elapsedTime_TB As TextBox
    Friend WithEvents functions_CB As ComboBox
    Friend WithEvents validation_TB As TextBox
    Friend WithEvents input_GB As GroupBox
    Friend WithEvents output_GB As GroupBox
End Class
