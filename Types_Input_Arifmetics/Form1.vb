Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("While the cat's away, the mice will play")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strFirtsName As String
        strFirtsName = "Sasha"

        MessageBox.Show("Hello " & strFirtsName & "! " & "Have a good day!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim strMake As String
        Dim StrModule As String
        Dim iDoors As Integer
        Dim color As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDataRegistered As Date

        strMake = "Ford"
        StrModule = "Escort"
        iDoors = 5
        color = "black"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDataRegistered = #11/2/2023#

        MessageBox.Show("This car is " & strMake & StrModule & ". It has " & iDoors & " doors. It is " & color &
                        ". Is it taxed - " & bTaxed & ". Its engine is " & iEngineSize & ". It costs " & decPrice &
                        ". It was registreded " & dtDataRegistered)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim strFisrtName As String
        'strFisrtName = InputBox("Please enter your fisrt name") 
        'MessageBox.Show("Hello " & strFisrtName)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Dim srtFirstName As String
        Dim strLastName As String
        Dim strOcucupation As String

        srtFirstName = TextBox1.Text
        strLastName = TextBox2.Text

        strOcucupation = ListBox1.SelectedItem

        MessageBox.Show(srtFirstName & " " & strLastName & " is a " & strOcucupation)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Повар")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim inum1 As Integer
        Dim inum2 As Integer
        Dim iResultSum As Integer
        Dim iResultSub As Integer

        inum1 = TextBox3.Text
        inum2 = TextBox4.Text

        iResultSum = inum1 + inum2
        iResultSub = inum1 - inum2
        MessageBox.Show(iResultSum)
        MessageBox.Show(iResultSub)

        ' ^ возвести в степень 
        ' \ разделить на цело 
        ' Mod показывает остаток 


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decTotalCost As Decimal
        Dim decDescount As Decimal

        decPrice = 5
        iQuantity = 10
        decDescount = 2

        'используем "()" для определения порядка действия

        decTotalCost = (decPrice - decDescount) * iQuantity

        MessageBox.Show(decTotalCost)
    End Sub
End Class
