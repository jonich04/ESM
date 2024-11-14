Imports System.Math
Imports info.lundin.math
Imports aziretParser
Imports System.Threading
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Public Class EvenSearchMethodForm
    Declare Function GetCurrentProcessId Lib "kernel32" () As Long
    Dim PID As Long
    Dim exl As Application
    Dim exlWB As Workbook
    Dim exlSheet As _Worksheet
    Sub Clean()
        solution_TB.Text = ""
        solution_TB.Refresh()
        valueOfSolution_TB.Text = ""
        valueOfSolution_TB.Refresh()
        iterationsAmount_TB.Text = ""
        iterationsAmount_TB.Refresh()
        valueDiffMinus_TB.Text = ""
        valueDiffMinus_TB.Refresh()
        valueDiffPlus_TB.Text = ""
        valueDiffPlus_TB.Refresh()
        h_result_TB.Text = ""
        h_result_TB.Refresh()
        elapsedTime_TB.Refresh()
        elapsedTime_TB.Clear()
        validation_TB.Text = ""
        validation_TB.Refresh()
    End Sub
    Private Sub runESM_BTN_Click(sender As Object, e As EventArgs) Handles runESM_BTN.Click
        Clean()
        Thread.Sleep(2)
        Dim started As DateTime = Now
        Dim finished As DateTime
        ProgressBar1.Value = 0
        x0_TB.ReadOnly = False
        tol_TB.ReadOnly = False
        Try
            If (functions_CB.Text = "" Or x0_TB.Text = "" _
                Or tol_TB.Text = "" Or iterationLimit_TB.Text = "" Or timeLimit_TB.Text = "") Then
                MsgBox("Текстовые поля ввода пусты! Введите данные")
            ElseIf (InStr(functions_CB.Text, "log") Or InStr(functions_CB.Text, "ln")) Then
                If (Double.Parse(x0_TB.Text) <= 0) Then
                    MsgBox("Вы пытаетесь найти ln или log с недопустимым значением." &
                               " Не устанавливайте A или B <= 0")
                    Return
                End If
                'Before a run the subroutine BM.start clearning of the former results will be performed
                Clean()
                Dim ESM As EvenSearchMethod = New EvenSearchMethod()
                'started, finished, LimTime,
                ESM.start(functions_CB, x0_TB, tol_TB,
                         iterationLimit_TB, ProgressBar1, h_result_TB, minimum_RB,
                         maximum_RB, validation_TB, timeLimit_TB, h_TB)
                finished = Now
                elapsedTime_TB.Text = finished.Subtract(started).Seconds
                'Timer to measure elapsed time from click to button and finishing iterations (in seconds)

                If Single.Parse(h_TB.Text) <= Single.Parse(tol_TB.Text) Then
                    ESM.out(valueDiffPlus_TB, valueDiffMinus_TB, tol_TB, solution_TB, valueOfSolution_TB,
                            iterationsAmount_TB, h_result_TB, minimum_RB, maximum_RB, validation_TB, h_TB)
                End If
            End If
        Catch ex As ArithmeticException
            MessageBox.Show("Ошибка, Логорифмическая функция для значения 'X0' должен быть больше 0")
        Catch ex As ParserException
            MessageBox.Show("Ошибка в аналитическом выражении функции f(x)", "Внимание")
        Catch ef As FormatException
            MessageBox.Show("Ошибка в формате входных данных", "Внимание")
        End Try
    End Sub
    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        Clean()
    End Sub
    Private Sub drawGraph_BTN_Click(sender As Object, e As EventArgs) Handles drawGraph_BTN.Click
        If (functions_CB.Text = "") Then
            MessageBox.Show("Текстовое поля для функции пусто! Введите данные!", "Внимание")
        ElseIf (x0_TB.Text = "") Then
            MessageBox.Show("Текстовое поля для X0 пусто! Введите данные!", "Внимание")
        ElseIf (InStr(functions_CB.Text, "log") Or InStr(functions_CB.Text, "ln")) Then
            If (Double.Parse(x0_TB.Text) <= 0) Then
                MsgBox("Вы пытаетесь найти ln или log с недопустимым значением." &
                           " Не устанавливайте A или B <= 0")
                Return
            End If
            exl = New Microsoft.Office.Interop.Excel.Application
            'Dim exlSheet As Excel.Worksheet
            Dim exlWB As Excel.Workbook = exl.Workbooks.Open(Directory.GetCurrentDirectory & "\MO_LookingForOneOptPoint.xlsm")
            exl.Visible = True
            Dim funct As String = functions_CB.Text
            funct = funct.Replace("exp", "!")
            funct = funct.Replace("x", "D4")
            funct = "=" + funct.Replace("!", "exp")
            exlSheet = exlWB.Worksheets(1)
            exlSheet.Range("B2").Value = functions_CB.Text
            exlSheet.Range("E4", "E10003").Value = funct
            exlSheet.Range("I4").Value = x0_TB.Text
            exlSheet.Range("J4").Value = x0_TB.Text + 1
        End If
    End Sub
    Private Sub setPoint_BTN_Click(sender As Object, e As EventArgs) Handles setPoint_BTN.Click
        Dim value, value2 As Decimal
        x0_TB.Text = exlSheet.Range("I4").Value
        'x0_TB.Text = exlSheet.Cells(4, 9).Value
        value = x0_TB.Text
        value2 = exlSheet.Range("J4").Value
        x0_TB.ReadOnly = True
        exl.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(exl)
        exlWB = Nothing
        exlWB = Nothing
        exl = Nothing
        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            If proc.MainWindowTitle = "\MO_LookingForOneOptPoint.xlsm" Then
                proc.Kill()
                Exit For
            End If
        Next
    End Sub
    Private Sub chooseX0_BTN_Click(sender As Object, e As EventArgs)
        Dim msgBoxResult = MsgBox("Сначала выберите функцию или напишите свою, вставьте значение x0, затем нажмите кнопку «Draw Graph»," & vbCrLf _
                                  & "в открывшемся файле выберите значения для a, затем сохраните документ и вернитесь в программу." & vbCrLf _
                                  & "Если вам нужно вставить значение «а», нажмите кнопку «Set point like X0», при открытом окне Excel" & vbCrLf _
                                  & "а затем нажмите кнопку «Run Even Search Method»." & vbCrLf & " Вы хотите открыть файл?", vbInformation + vbYesNo)
        If msgBoxResult = vbYes Then drawGraph_BTN.PerformClick()
    End Sub

    Private Sub x0_TB_TextChanged(sender As Object, e As EventArgs) Handles x0_TB.TextChanged

    End Sub

    Private Sub functions_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles functions_CB.SelectedIndexChanged

    End Sub
End Class