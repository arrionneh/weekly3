' Program Name: Burger Specials
' Programmer: ArRionne Hickson
' Date: 31 March 2023
' Purpose: user selects burger meal, program displays picture of burger

Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click


        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelect.Enabled = True
        lblEnjoy.Visible = False
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click


        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelect.Enabled = True
        lblEnjoy.Visible = False
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click


        btnPrime.Enabled = False
        btnSelect.Enabled = False
        btnVeggie.Enabled = False
        lblChoose.Visible = False
        lblEnjoy.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picPrime.Visible = True
        lblEnjoy.Visible = False

    End Sub
End Class
