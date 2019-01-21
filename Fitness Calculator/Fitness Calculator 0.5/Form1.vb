Option Explicit Off
Option Strict Off
Imports System.ComponentModel

Public Class Form1
    Dim newUser As New FitnessUser()
    Dim user As New BindingList(Of FitnessUser)
    Public strGender As String

    Public Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intWeightLb As Integer = 0      ' To hold weight in lbs
        Dim intHeightIn As Integer = 0      ' To hold height in inches

        Try
            ' Read the values from the US standard TextBox controls.
            intWeightLb = CInt(txtWeightLb.Text)
            intHeightIn = CInt(txtHeightIn.Text)
        Catch
            ' Error Message
            MessageBox.Show("Enter numeric values to continue.")
        End Try

        ' Convert standard to metric
        intWeightKg = intWeightLb / 2.2046
        intHeightCm = intHeightIn / 0.3937

        ' Display converted values in metric TextBox inputs
        txtWeightKg.Text = intWeightKg.ToString
        txtHeightCm.Text = intHeightCm.ToString
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalcRMR.Click
        Dim intWeightKg As Integer = 0      ' To hold weight
        Dim intHeightCm As Integer = 0      ' To hold height
        Dim intAge As Integer = 0           ' To hold age
        Dim intCalculatedRMR As Integer = 0 ' To hold RMR results
        Dim strGender = cbxGender.SelectedItem()     ' Assign ComboBox value to gender

        Try
            ' Read the values from the metric TextBox controls.
            intWeightKg = CInt(txtWeightKg.Text)
            intHeightCm = CInt(txtHeightCm.Text)
            intAge = CInt(txtAge.Text)


            ' Make sure you have a gender to calculate RMR correctly
            strGender = cbxGender.Items()

            ' Calculate RMR
            If strGender = "Female" Then
                intCalculatedRMR = 10 * intWeightKg + 6.25 * intHeightCm - 5 * intAge - 161
            ElseIf strGender = "Male" Then
                intCalculatedRMR = 10 * intWeightKg + 6.25 * intHeightCm - 5 * intAge + 5
            End If
        Catch
            ' Error Message
            MessageBox.Show("Enter numeric values to continue.")
        End Try

        ' Display RMR
        lblCalculatedRMR.Text = CStr(intCalculatedRMR)

    End Sub


    Public Sub btnCalcBodyFat_Click(sender As Object, e As EventArgs) Handles btnCalcBodyFat.Click
        calcBodyFat()
    End Sub

    Public Function calcBodyFat() As Decimal
        Dim intBodyWeight As Integer = 0       ' To hold bodyweight
        Dim decWrist As Decimal = 0            ' To hold wrist circumference
        Dim decWaist As Decimal = 0            ' To hold waist circumference
        Dim decHip As Decimal = 0              ' To hold hip circumference
        Dim decForearm As Decimal = 0          ' To hold Forearm circumference
        Dim decCalculatedFemaleFat As Decimal = 0   ' To hold calculated body fat percentage for females
        Dim decCalculatedMaleFat As Decimal = 0     ' To hold calculated body fat percentage for males
        Dim decResult1 As Decimal
        Dim decResult2 As Decimal
        Dim decResult3 As Decimal
        Dim decResult4 As Decimal
        Dim decResult5 As Decimal
        Dim decResult6 As Decimal
        Dim decResult7 As Decimal
        Dim decResult8 As Decimal
        Dim decResult9 As Decimal
        Dim decLeanBodyMass As Decimal
        Dim decLeanBodyWeight As Decimal

        Try
            ' Read the user's values from the TextBox controls and convert datatypes
            intBodyWeight = CInt(txtBodyWeight.Text)
            decWaist = CDec(txtWaist.Text)
            decHip = CDec(txtHip.Text)
            decForearm = CDec(txtForearm.Text)
            decWrist = CDec(txtWrist.Text)

            ' Calculate RMR
            If strGender = "Male" Then
                ' Calculate Body Fat Percentage for Males
                decResult1 = (intBodyWeight * 1.082) + 94.42
                decLeanBodyWeight = decResult1 - (decWaist * 4.15)
                decCalculatedMaleFat = ((intBodyWeight - decLeanBodyWeight) * 100) / intBodyWeight
            ElseIf strGender = "Female" Then
                ' Calculate Body Fat Percentage for Females
                decResult1 = intBodyWeight * 0.732
                decResult2 = decResult1 + 8.987
                decResult3 = decWrist / 3.14
                decResult4 = decWaist * 0.157
                decResult5 = decHip * 0.249
                decResult6 = decForearm * 0.434
                decResult7 = decResult2 + decResult3
                decResult8 = decResult7 - decResult4
                decResult9 = decResult8 - decResult5
                decLeanBodyMass = decResult6 + decResult9
                decCalculatedFat = ((intBodyWeight - decLeanBodyMass) * 100) / intBodyWeight
            Else
                MessageBox.Show("Select your gender to continue.")
            End If
        Catch
            ' Error Message
            MessageBox.Show("Enter whole numbers to contine.")
        End Try

        ' Display Calculated Body Fat
        Return lblCalculatedFat.Text = decCalculatedFat.ToString("P")
    End Function

    Private Sub btnClearRMR_Click(sender As Object, e As EventArgs) Handles btnClearRMR.Click
        ' Clear RMR input fields
        txtWeightLb.Clear()
        txtHeightIn.Clear()
        txtWeightKg.Clear()
        txtHeightCm.Clear()
        txtAge.Clear()

        ' Clear calculated fields
        lblCalculatedRMR.Text = String.Empty

        ' Reset the focus to the first field
        txtWeightLb.Focus()
    End Sub

    Private Sub btnClearBodyFat_Click(sender As Object, e As EventArgs) Handles btnClearBodyFat.Click
        ' Call the ClearBodyFatInput procedure.
        ClearBodyFatInput()
    End Sub

    Private Sub ClearBodyFatInput()
        ' Clear body fat input fields procedure.
        txtBodyWeight.Clear()
        txtWrist.Clear()
        txtWaist.Clear()
        txtHip.Clear()
        txtForearm.Clear()

        ' Clear calculated body fat fields
        lblCalculatedFat.Text = String.Empty

        ' Reset focus to the first field
        txtBodyWeight.Focus()
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim newUser As New FitnessUser()
        newUser.Name = txtName.Text

        Dim isValidAge As Boolean = Integer.TryParse(txtAge.Text, newUser.age)

        Try
            newUser.age = CInt(txtAge.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter an integer for your age.")
            txtAge.Text = ""
        End Try

        Try
            newUser.Gender = cbxGender.SelectedItem.ToString
        Catch ex As Exception
            MessageBox.Show("Select a gender to continue")
        End Try

        user.Add(newUser)
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load

        DisplayStats()
        lstUsers.DataSource = (user)                                                '= binding list (user) Assigns to listbox 
        lstUsers.DisplayMember = "Name"                                             'This will display the name in the listbox properly
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged 'Displays stats for selected list item
        user = CType(lstUsers.SelectedItem, FitnessUser)                            'Converts selected list item to FitnessUser type and stores it in user
        DisplayStats()
    End Sub

    Private Sub DisplayStats()
        lblDisplayName.Text = txtName.Text()
        lblDisplayAge.Text = txtAge.Text.ToString()
        lblDisplayGender.Text = cbxGender.SelectedItem()
        lblDisplayHeight.Text = txtHeightCm.ToString()
        lblDisplayWtKg.Text = txtWeightKg.ToString()
        lblDisplayWtLb.Text = txtBodyWeight.Text.ToString()
        lblDisplayRMR.Text = lblCalculatedRMR.Text.ToString()
        lblDisplayFat.Text = lblCalculatedFat.Text.ToString()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub


End Class
