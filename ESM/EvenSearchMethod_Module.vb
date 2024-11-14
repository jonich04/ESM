Imports Microsoft.VisualBasic
Imports System.Math
Imports info.lundin.math
Imports System.Threading
Imports aziretParser
Imports System.Reflection.Emit
Imports System

Public Class EvenSearchMethod
    Dim func As String
    Dim k As Integer
    Dim x1 As Decimal
    Dim YF1 As Decimal
    Dim H As Decimal
    Dim F1 As Decimal
    Dim F2 As Decimal

    Public Sub out(Fplus2 As Label, Fminus2 As Label, ToleranceBox As TextBox,
                   
        
        As TextBox, ValueOfFunctionBox As TextBox,
                   NumberOfIterationsBox As TextBox, H_Box As TextBox, xminusBox As TextBox,
                   xplusBox As TextBox, RadioButton1 As RadioButton, RadioButton2 As RadioButton, TextBox1 As TextBox, Step_Search As TextBox)
        solution_TB.Text = x1.ToString("N28")
        solution_TB.ForeColor = System.Drawing.Color.Red
        ValueOfFunctionBox.Text = YF1.ToString("N28")
        NumberOfIterationsBox.Text = k
        H_Box.Text = Step_Search.Text
        xminusBox.Text = F1.ToString("N28")
        xplusBox.Text = F2.ToString("N28")
        Fplus2.Text = Fplus2.Text + " " + (YF1 - F2).ToString("N28")
        Fminus2.Text = Fminus2.Text + " " + (YF1 - F1).ToString("N28")
    End Sub

    Function F(par As Decimal, Search_Step As Decimal) As Decimal

        If Search_Step > 0.000000000000001 Then
            Dim Parser As New ExpressionParser()
            Parser.Values.Add("x", par)
            Return Parser.Parse(func)
        Else
            Return aziretParser.ParserDecimal.Compute(func, par)
        End If
    End Function
    Public Sub start(funcBox As ComboBox, x0_Box As TextBox,
                     ToleranceBox As TextBox, k_maxBox As TextBox,
                     ByRef ProgressBar1 As ProgressBar, H_Box As TextBox,
                     xminusBox As TextBox, xplusBox As TextBox, RadioButton1 As RadioButton, RadioButton2 As RadioButton,
                     TextBox1 As TextBox, Time As TextBox, Search_Step As TextBox)
        Dim started As DateTime = Now
        Dim finished As DateTime
        Dim Tolerance As Decimal
        Dim x0, YF0 As Decimal
        x1 = 0
        H = 0
        YF1 = 0
        Dim cond, k_max As Integer
        cond = 0
        Dim t, ElapsedTime As Double

        func = funcBox.Text
        func = func.ToLower()

        x0 = Double.Parse(x0_Box.Text)
        Tolerance = Double.Parse(ToleranceBox.Text)
        H = Double.Parse(Search_Step.Text).ToString("0E0")
        k_max = Integer.Parse(k_maxBox.Text)


        k = 0
        t = CDbl(Time.Text)


        If H > Tolerance Then
            MessageBox.Show("Шаг поиска H должен быть меньше или ровно Tolerance = " + Tolerance.ToString("0E0"),
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If k_max <= 0 Then
            MessageBox.Show("Количество итераций должно быть не менее 1",
                 "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Tolerance <= 0 Then
            MessageBox.Show("Tolerance должен быть больше нуля",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
        End If


        'минимум===================================================================
        If (Form1.RadioButton1.Checked) Then
            YF0 = F(x0, H)
            x1 = x0 + H
            YF1 = F(x1, H)

            While cond = 0 And k < k_max And (Abs(x1 - x0)) > 0
                k = k + 1

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = k + 1
                ProgressBar1.Value = k
                Thread.Sleep(0.5)

                If YF1 >= YF0 Then
                    If k = 1 Then
                        cond = 1
                    End If
                    x1 = x0
                    YF1 = YF0
                Else
                    x0 = x1
                    YF0 = YF1
                    x1 = x0 + H
                    YF1 = F(x1, H)
                End If
                'лимит итерации=======================================================
                If k >= k_max Then

                    Dim result As DialogResult = MessageBox.Show("Решение не может быть найдено с этим tolerance" & vbCr &
                                            "из-за ограничения количества итераций." & vbCr &
                                            "Вы хотите добавить дополнительную итерацию?" & "(" & k_max & ")", "Внимание",
                                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If (result = DialogResult.OK) Then
                        k_max = k_max + k_max
                        k_maxBox.Text = k_max.ToString()
                    End If
                End If
                'лимит времени=======================================================
                finished = Now
                ElapsedTime = CDbl(finished.Subtract(started).Seconds)
                If ElapsedTime >= t Then
                    Dim result As DialogResult = MessageBox.Show("Решение не может быть найдено с этим tolerance" & vbCr &
                                            "из-за лимита времени." & vbCr &
                                            "Вы хотите добавить время?", "Внимание",
                                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If (result = DialogResult.OK) Then
                        t = t + ElapsedTime
                        Time.Text = t.ToString()
                    Else
                        t = t
                        cond = 1
                    End If
                End If

            End While

            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

            F1 = F(x1 - Tolerance, H)
            F2 = F(x1 + Tolerance, H)
            If YF1 <= F1 And YF1 <= F2 Then
                TextBox1.ForeColor = System.Drawing.Color.Green
                TextBox1.Text = "Результат x* минимизирует эту функцию, потому что" & vbCrLf &
                                "Знак [F(x*)—F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                "и " & vbCrLf &
                                "Знак [F(x*)-F(x*+Tolerance)]  = " & Sign(YF1 - F2) & vbCrLf &
                                "Он был найден с ошибкой H = " & Search_Step.Text & vbCrLf & "Это меньше или равно заданному Tolerance!"
            Else
                TextBox1.ForeColor = System.Drawing.Color.Red
                TextBox1.Text = "Результат x* не является минимизатором этой функции, потому что" & vbCrLf &
                                "Знак [F(x*)-F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                "и " & vbCrLf &
                                "Знак [F(x*)-F(x*+Tolerance)]  = " & Sign(YF1 - F2)
            End If

            If cond = 1 Then

                If Sign(YF1 - F1) = Sign(YF1 - F2) Then
                    TextBox1.ForeColor = System.Drawing.Color.Green
                    TextBox1.Text = "Результат x* минимизирует эту функцию, потому что" & vbCrLf &
                                "Знак [F(x*)-F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                "и" & vbCrLf &
                                "Знак [F(x*)-F(x*+Tolerance)]  = " & Sign(YF1 - F2) & vbCrLf &
                                "Он был найден с ошибкой H = " & Search_Step.Text & vbCrLf & "Это меньше или равно заданному Tolerance!"

                Else
                    TextBox1.ForeColor = System.Drawing.Color.DarkRed
                    Dim result As DialogResult = MessageBox.Show("Метод не выполнил ни одной итерации," & vbCrLf &
                                    "потому что начальное значение уже" & vbCrLf &
                                    "экстреум или находится в правой части от экстреума." & vbCrLf &
                                    "Вы хотите проверить график функции?", "Внимание",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If (result = DialogResult.Yes) Then
                        Form1.DrawFunctionGraph.PerformClick()
                    ElseIf (result = DialogResult.No) Then
                        TextBox1.ForeColor = System.Drawing.Color.Red
                        TextBox1.Text = "Результат x* не является минимизатором этой функции, потому что" & vbCrLf &
                                    "Знак[F(x*)-F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                    "и " & vbCrLf &
                                    "Знак [F(x*)-F(x*+Tolerance)]  = " & Sign(YF1 - F2)

                    End If
                End If
            End If
        End If

        'максимум=======================================================

        If (Form1.RadioButton2.Checked) Then

            YF0 = F(x0, H)
            x1 = x0 + H
            YF1 = F(x1, H)

            While cond = 0 And k < k_max And (Abs(x1 - x0) <> 0)
                k = k + 1

                ProgressBar1.Visible = True
                ProgressBar1.Maximum = k + 1
                ProgressBar1.Value = k
                Thread.Sleep(0.1)

                If YF1 <= YF0 Then
                    If k = 1 Then
                        cond = 1
                    End If
                    x1 = x0
                    YF1 = YF0

                Else
                    x0 = x1
                    YF0 = YF1
                    x1 = x0 + H
                    YF1 = F(x1, H)
                End If
                'лимит итерации=======================================================
                If k >= k_max Then

                    Dim result As DialogResult = MessageBox.Show("Решение не может быть найдено с этим tolerance" & vbCrLf &
                                            "из-за ограничения количества итераций." & vbCrLf &
                                            "Вы хотите добавить дополнительную итерацию?", "Внимание",
                                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If (result = DialogResult.OK) Then
                        k_max = k_max + k_max
                        k_maxBox.Text = k_max.ToString()
                    End If
                End If
                'лимит времени=======================================================
                finished = Now
                ElapsedTime = CDbl(finished.Subtract(started).Seconds)
                If ElapsedTime >= t Then
                    Dim result As DialogResult = MessageBox.Show("Решение не может быть найдено с этим tolerance" & vbCrLf &
                                            "из-за лимита времени." & vbCrLf &
                                            "Вы хотите добавить время?", "Внимание",
                                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If (result = DialogResult.OK) Then
                        t = t + ElapsedTime
                        Time.Text = t.ToString()
                    Else
                        t = t
                        cond = 1
                    End If
                End If
            End While
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

            F1 = F(x1 - Tolerance, H)
            F2 = F(x1 + Tolerance, H)
            If Sign(YF1 - F1) = Sign(YF1 - F2) Then
                TextBox1.ForeColor = System.Drawing.Color.Green
                TextBox1.Text = "Результат x* максимизирует эту функцию, потому что" & vbCrLf &
                                "Знак [F(x*) — F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                "и " & vbCrLf &
                                "Знак [F(x*) — F(x*+Tolerance)]  = " & Sign(YF1 - F2) & vbCrLf &
                                "Он был найден с ошибкой H = " & Search_Step.Text & vbCrLf & "Это меньше или равно заданному Tolerance!"
            Else
                TextBox1.ForeColor = System.Drawing.Color.Red
                TextBox1.Text = "Результат x * не является максимизатором этой функции, потому что" & vbCr &
                                "Знак [F(x*) — F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                "и" & vbCrLf &
                                "Знак[F(x*) — F(x*+Tolerance)]  = " & Sign(YF1 - F2)
                MsgBox("Эта функция не имеет максимизатора")
            End If

            If cond = 1 Then
                If Sign(YF1 - F1) = Sign(YF1 - F2) Then
                    TextBox1.ForeColor = System.Drawing.Color.Green
                    TextBox1.Text = "Результат x* максимизирует эту функцию, потому что" & vbCr &
                                "Знак [F(x*) — F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                " и " & vbCrLf &
                                "Знак [F(x*) — F(x*+Tolerance)]  = " & Sign(YF1 - F2) & vbCrLf &
                                 "Он был найден с ошибкой H = " & Search_Step.Text & vbCrLf & "Это меньше или равно заданному Tolerance!"


                Else
                    TextBox1.ForeColor = System.Drawing.Color.DarkRed
                    Dim result As DialogResult = MessageBox.Show("Метод не выполнил ни одной итерации," & vbCrLf &
                                        "потому что начальное значение уже" & vbCrLf &
                                        "экстреум или находится в правой части от экстреума." & vbCrLf &
                                        "Вы хотите проверить график функции?", "Внимание",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If (result = DialogResult.Yes) Then
                        Form1.DrawFunctionGraph.PerformClick()
                    ElseIf (result = DialogResult.No) Then
                        TextBox1.ForeColor = System.Drawing.Color.Red
                        TextBox1.Text = "Результат x * не является максимизатором этой функции, потому что" & vbCrLf &
                                    "Знак [F(x*)-F(x*–Tolerance)]  = " & Sign(YF1 - F1) & vbCrLf &
                                    "и " & vbCrLf &
                                    "Знак [F(x*)-F(x*+Tolerance)]  = " & Sign(YF1 - F2)

                    End If
                End If
            End If
        End If
    End Sub

End Class
