Imports System.Data.OleDb
Public Class Form1

    'CONNECTION TO DATABASE
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OperationsDB.accdb;"

    ' Addition
    Private Sub Add3NumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Add3NumbersToolStripMenuItem.Click
        Dim num1, num2, num3 As Double

        If Not Double.TryParse(InputBox("Enter first number:"), num1) Then
            MessageBox.Show("Invalid input for first number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter second number:"), num2) Then
            MessageBox.Show("Invalid input for second number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter third number:"), num3) Then
            MessageBox.Show("Invalid input for third number!")
            Exit Sub
        End If

        Dim result As Double = num1 + num2 + num3
        MessageBox.Show("The sum is: " & result)

        ' Save to database
        SaveToDatabase("Addition", num1, num2, num3, result)
    End Sub


    'Subtraction
    Private Sub SubstrucToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubstrucToolStripMenuItem.Click
        Dim num1, num2, num3 As Double

        If Not Double.TryParse(InputBox("Enter first number:"), num1) Then
            MessageBox.Show("Invalid input for first number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter second number:"), num2) Then
            MessageBox.Show("Invalid input for second number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter third number:"), num3) Then
            MessageBox.Show("Invalid input for third number!")
            Exit Sub
        End If

        Dim result As Double = num1 - num2 - num3
        MessageBox.Show("The result is: " & result)

        ' Save to database
        SaveToDatabase("Subtraction", num1, num2, num3, result)
    End Sub

    'Multiplication
    Private Sub MultiplyBy3NumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplyBy3NumbersToolStripMenuItem.Click
        Dim num1, num2, num3 As Double

        If Not Double.TryParse(InputBox("Enter first number:"), num1) Then
            MessageBox.Show("Invalid input for first number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter second number:"), num2) Then
            MessageBox.Show("Invalid input for second number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter third number:"), num3) Then
            MessageBox.Show("Invalid input for third number!")
            Exit Sub
        End If

        Dim result As Double = num1 * num2 * num3
        MessageBox.Show("The product is: " & result)

        ' Save to database
        SaveToDatabase("Multiplication", num1, num2, num3, result)
    End Sub

    'Division
    Private Sub Divide3NumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Divide3NumbersToolStripMenuItem.Click
        Dim num1, num2, num3 As Double

        If Not Double.TryParse(InputBox("Enter first number:"), num1) Then
            MessageBox.Show("Invalid input for first number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter second number:"), num2) Then
            MessageBox.Show("Invalid input for second number!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter third number:"), num3) Then
            MessageBox.Show("Invalid input for third number!")
            Exit Sub
        End If

        If num2 = 0 Or num3 = 0 Then
            MessageBox.Show("Division by zero is not allowed.")
        Else
            Dim result As Double = num1 / num2 / num3
            MessageBox.Show("The result is: " & result)

            ' Save to database
            SaveToDatabase("Division", num1, num2, num3, result)
        End If
    End Sub

    'Input Numbers 
    Private Sub InputNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputNumbersToolStripMenuItem.Click
        Dim numbers(9) As Integer
        Dim negative, zero, positive, odd, even As Integer

        For i As Integer = 0 To 9
            Dim input As String = InputBox("Enter number " & (i + 1) & ":")
            If Not Integer.TryParse(input, numbers(i)) Then
                MessageBox.Show("Invalid input! Please enter a whole number.")
                i -= 1 ' repeat this iteration until valid input
                Continue For
            End If

            If numbers(i) < 0 Then
                negative += 1
            ElseIf numbers(i) = 0 Then
                zero += 1
            Else
                positive += 1
            End If

            If numbers(i) Mod 2 = 0 Then
                even += 1
            Else
                odd += 1
            End If
        Next

        MessageBox.Show($"Negative: {negative}, Zero: {zero}, Positive: {positive}, Odd: {odd}, Even: {even}")
    End Sub

    'Grades Input and Average
    Private Sub GradesAverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradesAverageToolStripMenuItem.Click
        Dim grade1, grade2, grade3 As Double

        If Not Double.TryParse(InputBox("Enter first grade:"), grade1) Then
            MessageBox.Show("Invalid input for first grade!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter second grade:"), grade2) Then
            MessageBox.Show("Invalid input for second grade!")
            Exit Sub
        End If
        If Not Double.TryParse(InputBox("Enter third grade:"), grade3) Then
            MessageBox.Show("Invalid input for third grade!")
            Exit Sub
        End If

        Dim average As Double = (grade1 + grade2 + grade3) / 3
        Dim result As String

        If average >= 60 And average <= 74 Then
            result = "Failed"
        ElseIf average >= 75 And average <= 80 Then
            result = "3"
        ElseIf average >= 81 And average <= 90 Then
            result = "2"
        ElseIf average >= 91 And average <= 100 Then
            result = "1"
        Else
            result = "Wrong data"
        End If

        MessageBox.Show("Average: " & average & vbCrLf & "Result: " & result)
    End Sub

    'Sum of First and Last Numbers
    Private Sub SumOfFirstLastNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumOfFirstLastNumbersToolStripMenuItem.Click
        Dim initialNum, finalNum As Integer

        If Not Integer.TryParse(InputBox("Enter the initial number:"), initialNum) Then
            MessageBox.Show("Invalid input for initial number!")
            Exit Sub
        End If

        If Not Integer.TryParse(InputBox("Enter the final number:"), finalNum) Then
            MessageBox.Show("Invalid input for final number!")
            Exit Sub
        End If

        Dim sum As Integer = initialNum + finalNum
        MessageBox.Show("The sum is: " & sum)
    End Sub

    'Input Number and Nickname
    Private Sub NicknameRepeaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NicknameRepeaterToolStripMenuItem.Click
        Dim number As Integer
        Dim input As String = InputBox("Enter a number:")

        If Not Integer.TryParse(input, number) OrElse number <= 0 Then
            MessageBox.Show("Invalid input! Please enter a positive whole number.")
            Exit Sub
        End If

        Dim nickname As String = InputBox("Enter your nickname:")
        If String.IsNullOrWhiteSpace(nickname) Then
            MessageBox.Show("Invalid input! Nickname cannot be empty.")
            Exit Sub
        End If

        Dim result As String = ""
        For i As Integer = 1 To number
            result &= nickname & vbCrLf
        Next

        MessageBox.Show(result, "Nickname Repeater")
    End Sub


    'VIEW HISTORY FUNCTION
    Private Sub ViewHistoryToolStripMenuItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHistoryToolStripMenuItemToolStripMenuItem.Click

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT TOP 20 Operation, Input1, Input2, Input3, Result, Timestamp FROM Operations ORDER BY Timestamp DESC"
                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        Dim history As String = "OPERATION HISTORY (Last 20 entries)" & vbCrLf & vbCrLf

                        If Not reader.HasRows Then
                            MessageBox.Show("No operation history found.")
                            Exit Sub
                        End If

                        While reader.Read()
                            history &= String.Format("{0} | {1} {2} {3} = {4} | {5}" & vbCrLf,
                                                   reader("Operation").ToString(),
                                                   reader("Input1"),
                                                   reader("Input2"),
                                                   reader("Input3"),
                                                   reader("Result"),
                                                   Convert.ToDateTime(reader("Timestamp")).ToString("yyyy-MM-dd HH:mm:ss"))
                        End While

                        MessageBox.Show(history, "Operation History", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving history: " & ex.Message)
        End Try

    End Sub

    'CLLEAR HISTORY FUNCTION
    Private Sub ClearHistoryToolStripMenuItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearHistoryToolStripMenuItemToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all operation history?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM Operations"
                    Using command As New OleDbCommand(query, connection)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        MessageBox.Show($"Successfully cleared {rowsAffected} operation(s) from history.",
                                      "History Cleared",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error clearing history: " & ex.Message)
            End Try
        End If
    End Sub

    ' SAVE OPERATION TO THE DATABASE
    Private Sub SaveToDatabase(operation As String, input1 As Double, input2 As Double, input3 As Double, result As Double)
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Operations (Operation, Input1, Input2, Input3, Result, Timestamp) VALUES (@Operation, @Input1, @Input2, @Input3, @Result, @Timestamp)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Operation", operation)
                    command.Parameters.AddWithValue("@Input1", input1)
                    command.Parameters.AddWithValue("@Input2", input2)
                    command.Parameters.AddWithValue("@Input3", input3)
                    command.Parameters.AddWithValue("@Result", result)
                    command.Parameters.AddWithValue("@Timestamp", DateTime.Now)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving to database: " & ex.Message)
        End Try
    End Sub

End Class