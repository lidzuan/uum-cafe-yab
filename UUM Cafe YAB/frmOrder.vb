Imports System.Data.OleDb
Public Class frmOrder
    Dim pro As String
    Dim connstring As String
    Dim commmand As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub CustomerOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UUMCafeDatabase5DataSet)

    End Sub

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UUMCafeDatabase5DataSet.CustomerOrder' table. You can move, or remove it, as needed.
        Me.CustomerOrderTableAdapter.Fill(Me.UUMCafeDatabase5DataSet.CustomerOrder)
        txtCustomerID.Text = frmLogin.txtCustomerID.Text
        txtCustomerName.Text = frmLogin.txtCustomerName.Text

    End Sub


    'User view
    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        pnlOnButtonPosition.Height = btnBeverage.Height
        pnlOnButtonPosition.Top = btnBeverage.Top
        pnlBeverage.Visible = True
        pnlBurger.Visible = False
        pnlDessert.Visible = False
        pnlSideDish.Visible = False
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnBurger_Click(sender As Object, e As EventArgs) Handles btnBurger.Click
        pnlOnButtonPosition.Height = btnBurger.Height
        pnlOnButtonPosition.Top = btnBurger.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = True
        pnlDessert.Visible = False
        pnlSideDish.Visible = False
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        pnlOnButtonPosition.Height = btnDessert.Height
        pnlOnButtonPosition.Top = btnDessert.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = False
        pnlDessert.Visible = True
        pnlSideDish.Visible = False
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnSideDish_Click(sender As Object, e As EventArgs) Handles btnSideDish.Click
        pnlOnButtonPosition.Height = btnSideDish.Height
        pnlOnButtonPosition.Top = btnSideDish.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = False
        pnlDessert.Visible = False
        pnlSideDish.Visible = True
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnSoup_Click(sender As Object, e As EventArgs) Handles btnSoup.Click
        pnlOnButtonPosition.Height = btnSoup.Height
        pnlOnButtonPosition.Top = btnSoup.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = False
        pnlDessert.Visible = False
        pnlSideDish.Visible = False
        pnlSoup.Visible = True
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnSpaghetti_Click(sender As Object, e As EventArgs) Handles btnSpaghetti.Click
        pnlOnButtonPosition.Height = btnSpaghetti.Height
        pnlOnButtonPosition.Top = btnSpaghetti.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = False
        pnlDessert.Visible = False
        pnlSideDish.Visible = False
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = True
        pnlWesternFood.Visible = False
    End Sub

    Private Sub btnWesternFood_Click(sender As Object, e As EventArgs) Handles btnWesternFood.Click
        pnlOnButtonPosition.Height = btnWesternFood.Height
        pnlOnButtonPosition.Top = btnWesternFood.Top
        pnlBeverage.Visible = False
        pnlBurger.Visible = False
        pnlDessert.Visible = False
        pnlSideDish.Visible = False
        pnlSoup.Visible = False
        pnlSpaghetti.Visible = False
        pnlWesternFood.Visible = True
    End Sub

    'Making order
    Private Sub btnMilkTeaAdd_Click(sender As Object, e As EventArgs) Handles btnMilkTeaAdd.Click
        txtMilkTeaAmount.Text += 1
    End Sub

    Private Sub btnMilkTeaMinus_Click(sender As Object, e As EventArgs) Handles btnMilkTeaMinus.Click
        txtMilkTeaAmount.Text -= 1
        If txtMilkTeaAmount.Text <= 0 Then
            txtMilkTeaAmount.Text = 0
        End If
    End Sub

    Private Sub btnGreenTeaAdd_Click(sender As Object, e As EventArgs) Handles btnGreenTeaAdd.Click
        txtGreenTeaAmount.Text += 1
    End Sub

    Private Sub btnGreenTeaMinus_Click(sender As Object, e As EventArgs) Handles btnGreenTeaMinus.Click
        txtGreenTeaAmount.Text -= 1
        If txtGreenTeaAmount.Text <= 0 Then
            txtGreenTeaAmount.Text = 0
        End If
    End Sub

    Private Sub btnLemonTeaAdd_Click(sender As Object, e As EventArgs) Handles btnLemonTeaAdd.Click
        txtLemonTeaAmount.Text += 1
    End Sub

    Private Sub btnLemonTeaMinus_Click(sender As Object, e As EventArgs) Handles btnLemonTeaMinus.Click
        txtLemonTeaAmount.Text -= 1
        If txtLemonTeaAmount.Text <= 0 Then
            txtLemonTeaAmount.Text = 0
        End If
    End Sub

    Private Sub btnChickenBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnChickenBurgerAdd.Click
        txtChickenBurgerAmount.Text += 1
    End Sub

    Private Sub btnChickenBurgerMinus_Click(sender As Object, e As EventArgs) Handles btnChickenBurgerMinus.Click
        txtChickenBurgerAmount.Text -= 1
        If txtChickenBurgerAmount.Text <= 0 Then
            txtChickenBurgerAmount.Text = 0
        End If
    End Sub

    Private Sub btnSpicyChickenBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnSpicyChickenBurgerAdd.Click
        txtSpicyChickenBurgerAmount.Text += 1
    End Sub

    Private Sub btnSpicyChickenBurgerMinus_Click(sender As Object, e As EventArgs) Handles btnSpicyChickenBurgerMinus.Click
        txtSpicyChickenBurgerAmount.Text -= 1
        If txtSpicyChickenBurgerAmount.Text <= 0 Then
            txtSpicyChickenBurgerAmount.Text = 0
        End If
    End Sub

    Private Sub btnCrispyFishBurgerAdd_Click(sender As Object, e As EventArgs) Handles btnCrispyFishBurgerAdd.Click
        txtCrispyFishBurgerAmount.Text += 1
    End Sub

    Private Sub btnCrispyFishBurgerMinus_Click(sender As Object, e As EventArgs) Handles btnCrispyFishBurgerMinus.Click
        txtCrispyFishBurgerAmount.Text -= 1
        If txtCrispyFishBurgerAmount.Text <= 0 Then
            txtCrispyFishBurgerAmount.Text = 0
        End If
    End Sub

    Private Sub btnTiramisuAdd_Click(sender As Object, e As EventArgs) Handles btnTiramisuAdd.Click
        txtTiramisuAmount.Text += 1
    End Sub

    Private Sub btnTiramisuMinus_Click(sender As Object, e As EventArgs) Handles btnTiramisuMinus.Click
        txtTiramisuAmount.Text -= 1
        If txtTiramisuAmount.Text <= 0 Then
            txtTiramisuAmount.Text = 0
        End If
    End Sub

    Private Sub btnCheesecakeAdd_Click(sender As Object, e As EventArgs) Handles btnCheesecakeAdd.Click
        txtCheesecakeAmount.Text += 1
    End Sub

    Private Sub btnCheesecakeMinus_Click(sender As Object, e As EventArgs) Handles btnCheesecakeMinus.Click
        txtCheesecakeAmount.Text -= 1
        If txtCheesecakeAmount.Text <= 0 Then
            txtCheesecakeAmount.Text = 0
        End If
    End Sub

    Private Sub btnChocolateCakeAdd_Click(sender As Object, e As EventArgs) Handles btnChocolateCakeAdd.Click
        txtChocolateCakeAmount.Text += 1
    End Sub

    Private Sub btnChocolateCakeMinus_Click(sender As Object, e As EventArgs) Handles btnChocolateCakeMinus.Click
        txtChocolateCakeAmount.Text -= 1
        If txtChocolateCakeAmount.Text <= 0 Then
            txtChocolateCakeAmount.Text = 0
        End If
    End Sub

    Private Sub btnFrenchFriesAdd_Click(sender As Object, e As EventArgs) Handles btnFrenchFriesAdd.Click
        txtFrenchFriesAmount.Text += 1
    End Sub

    Private Sub btnFrenchFriesMinus_Click(sender As Object, e As EventArgs) Handles btnFrenchFriesMinus.Click
        txtFrenchFriesAmount.Text -= 1
        If txtFrenchFriesAmount.Text <= 0 Then
            txtFrenchFriesAmount.Text = 0
        End If
    End Sub

    Private Sub btnPotatoWedgesAdd_Click(sender As Object, e As EventArgs) Handles btnPotatoWedgesAdd.Click
        txtPotatoWedgesAmount.Text += 1
    End Sub

    Private Sub btnPotatoWedgesMinus_Click(sender As Object, e As EventArgs) Handles btnPotatoWedgesMinus.Click
        txtPotatoWedgesAmount.Text -= 1
        If txtPotatoWedgesAmount.Text <= 0 Then
            txtPotatoWedgesAmount.Text = 0
        End If
    End Sub

    Private Sub btnChickenNuggetAdd_Click(sender As Object, e As EventArgs) Handles btnChickenNuggetAdd.Click
        txtChickenNuggetAmount.Text += 1
    End Sub

    Private Sub btnChickenNuggetMinus_Click(sender As Object, e As EventArgs) Handles btnChickenNuggetMinus.Click
        txtChickenNuggetAmount.Text -= 1
        If txtChickenNuggetAmount.Text <= 0 Then
            txtChickenNuggetAmount.Text = 0
        End If
    End Sub

    Private Sub btnMushroomSoupAdd_Click(sender As Object, e As EventArgs) Handles btnMushroomSoupAdd.Click
        txtMushroomSoupAmount.Text += 1
    End Sub

    Private Sub btnMushroomSoupMinus_Click(sender As Object, e As EventArgs) Handles btnMushroomSoupMinus.Click
        txtMushroomSoupAmount.Text -= 1
        If txtMushroomSoupAmount.Text <= 0 Then
            txtMushroomSoupAmount.Text = 0
        End If
    End Sub

    Private Sub btnPotatoSoupAdd_Click(sender As Object, e As EventArgs) Handles btnPotatoSoupAdd.Click
        txtPotatoSoupAmount.Text += 1
    End Sub

    Private Sub btnPotatoSoupMinus_Click(sender As Object, e As EventArgs) Handles btnPotatoSoupMinus.Click
        txtPotatoSoupAmount.Text -= 1
        If txtPotatoSoupAmount.Text <= 0 Then
            txtPotatoSoupAmount.Text = 0
        End If
    End Sub

    Private Sub btnChickenSoupAdd_Click(sender As Object, e As EventArgs) Handles btnChickenSoupAdd.Click
        txtChickenSoupAmount.Text += 1
    End Sub

    Private Sub btnChickenSoupMinus_Click(sender As Object, e As EventArgs) Handles btnChickenSoupMinus.Click
        txtChickenSoupAmount.Text -= 1
        If txtChickenSoupAmount.Text <= 0 Then
            txtChickenSoupAmount.Text = 0
        End If
    End Sub

    Private Sub btnSpaghettiBologneseAdd_Click(sender As Object, e As EventArgs) Handles btnSpaghettiBologneseAdd.Click
        txtSpaghettiBologneseAmount.Text += 1
    End Sub

    Private Sub btnSpaghettiBologneseMinus_Click(sender As Object, e As EventArgs) Handles btnSpaghettiBologneseMinus.Click
        txtSpaghettiBologneseAmount.Text -= 1
        If txtSpaghettiBologneseAmount.Text <= 0 Then
            txtSpaghettiBologneseAmount.Text = 0
        End If
    End Sub

    Private Sub btnSpaghettiCarbonaraMushroomAdd_Click(sender As Object, e As EventArgs) Handles btnSpaghettiCarbonaraMushroomAdd.Click
        txtSpaghettiCarbonaraMushroomAmount.Text += 1
    End Sub

    Private Sub btnSpaghettiCarbonaraMushroomMinus_Click(sender As Object, e As EventArgs) Handles btnSpaghettiCarbonaraMushroomMinus.Click
        txtSpaghettiCarbonaraMushroomAmount.Text -= 1
        If txtSpaghettiCarbonaraMushroomAmount.Text <= 0 Then
            txtSpaghettiCarbonaraMushroomAmount.Text = 0
        End If
    End Sub

    Private Sub btnSpaghettiAglioOlioAdd_Click(sender As Object, e As EventArgs) Handles btnSpaghettiAglioOlioAdd.Click
        txtSpaghettiAglioOlioAmount.Text += 1
    End Sub

    Private Sub btnSpaghettiAglioOlioMinus_Click(sender As Object, e As EventArgs) Handles btnSpaghettiAglioOlioMinus.Click
        txtSpaghettiAglioOlioAmount.Text -= 1
        If txtSpaghettiAglioOlioAmount.Text <= 0 Then
            txtSpaghettiAglioOlioAmount.Text = 0
        End If
    End Sub

    Private Sub btnChickenChopAdd_Click(sender As Object, e As EventArgs) Handles btnChickenChopAdd.Click
        txtChickenChopAmount.Text += 1
    End Sub

    Private Sub btnChickenChopMinus_Click(sender As Object, e As EventArgs) Handles btnChickenChopMinus.Click
        txtChickenChopAmount.Text -= 1
        If txtChickenChopAmount.Text <= 0 Then
            txtChickenChopAmount.Text = 0
        End If
    End Sub

    Private Sub btnGrilledChickenMushroomAdd_Click(sender As Object, e As EventArgs) Handles btnGrilledChickenMushroomAdd.Click
        txtGrilledChickenMushroomAmount.Text += 1
    End Sub

    Private Sub btnGrilledChickenMushroomMinus_Click(sender As Object, e As EventArgs) Handles btnGrilledChickenMushroomMinus.Click
        txtGrilledChickenMushroomAmount.Text -= 1
        If txtGrilledChickenMushroomAmount.Text <= 0 Then
            txtGrilledChickenMushroomAmount.Text = 0
        End If
    End Sub

    Private Sub btnGrilledChickenBlackPepperAdd_Click(sender As Object, e As EventArgs) Handles btnGrilledChickenBlackPepperAdd.Click
        txtGrilledChickenBlackPepperAmount.Text += 1
    End Sub

    Private Sub btnGrilledChickenBlackPepperMinus_Click(sender As Object, e As EventArgs) Handles btnGrilledChickenBlackPepperMinus.Click
        txtGrilledChickenBlackPepperAmount.Text -= 1
        If txtGrilledChickenBlackPepperAmount.Text <= 0 Then
            txtGrilledChickenBlackPepperAmount.Text = 0
        End If
    End Sub

    'Place order
    Private Sub txtPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        lstPlaceOrderCheck.Items.Clear()

        Dim MilkTeaSubPrice As Single
        Dim GreenTeaSubPrice As Single
        Dim LemonTeaSubPrice As Single
        Dim ChickenBurgerSubPrice As Single
        Dim SpicyChickenBurgerSubPrice As Single
        Dim CrispyFishBurgerSubPrice As Single
        Dim TiramisuSubPrice As Single
        Dim CheesecakeSubPrice As Single
        Dim ChocolateCakeSubPrice As Single
        Dim FrenchFriesSubPrice As Single
        Dim PotatoWedgesSubPrice As Single
        Dim ChickenNuggetSubPrice As Single
        Dim MushroomSoupSubPrice As Single
        Dim PotatoSoupSubPrice As Single
        Dim ChickenSoupSubPrice As Single
        Dim SpaghettiBologneseSubPrice As Single
        Dim SpaghettiCarbonaraMushroomSubPrice As Single
        Dim SpaghettiAglioOlioSubPrice As Single
        Dim ChickenChopSubPrice As Single
        Dim GrilledChickenMushroomSubPrice As Single
        Dim GrilledChickenBlackPepperSubPrice As Single
        Dim TotalPrice As Single


        MilkTeaSubPrice = Format(txtMilkTeaAmount.Text * 3.9, "0.00")
        GreenTeaSubPrice = Format(txtGreenTeaAmount.Text * 3.9, "0.00")
        LemonTeaSubPrice = Format(txtLemonTeaAmount.Text * 3.9, "0.00")
        ChickenBurgerSubPrice = Format(txtChickenBurgerAmount.Text * 9.9, "0.00")
        SpicyChickenBurgerSubPrice = Format(txtSpicyChickenBurgerAmount.Text * 10.9, "0.00")
        CrispyFishBurgerSubPrice = Format(txtCrispyFishBurgerAmount.Text * 9.9, "0.00")
        TiramisuSubPrice = Format(txtTiramisuAmount.Text * 6.9, "0.00")
        CheesecakeSubPrice = Format(txtCheesecakeAmount.Text * 6.9, "0.00")
        ChocolateCakeSubPrice = Format(txtChocolateCakeAmount.Text * 5.9, "0.00")
        FrenchFriesSubPrice = Format(txtFrenchFriesAmount.Text * 5.9, "0.00")
        PotatoWedgesSubPrice = Format(txtPotatoWedgesAmount.Text * 5.9, "0.00")
        ChickenNuggetSubPrice = Format(txtChickenNuggetAmount.Text * 6.9, "0.00")
        MushroomSoupSubPrice = Format(txtMushroomSoupAmount.Text * 5.9, "0.00")
        PotatoSoupSubPrice = Format(txtPotatoSoupAmount.Text * 5.9, "0.00")
        ChickenSoupSubPrice = Format(txtChickenSoupAmount.Text * 6.9, "0.00")
        SpaghettiBologneseSubPrice = Format(txtSpaghettiBologneseAmount.Text * 9.9, "0.00")
        SpaghettiCarbonaraMushroomSubPrice = Format(txtSpaghettiCarbonaraMushroomAmount.Text * 9.9, "0.00")
        SpaghettiAglioOlioSubPrice = Format(txtSpaghettiAglioOlioAmount.Text * 9.9, "0.00")
        ChickenChopSubPrice = Format(txtChickenChopAmount.Text * 10.9, "0.00")
        GrilledChickenMushroomSubPrice = Format(txtGrilledChickenMushroomAmount.Text * 12.3, "0.00")
        GrilledChickenBlackPepperSubPrice = Format(txtGrilledChickenBlackPepperAmount.Text * 12.3, "0.00")

        TotalPrice = Format(MilkTeaSubPrice + GreenTeaSubPrice + LemonTeaSubPrice + ChickenBurgerSubPrice + SpicyChickenBurgerSubPrice + CrispyFishBurgerSubPrice + TiramisuSubPrice + CheesecakeSubPrice + ChocolateCakeSubPrice + FrenchFriesSubPrice + PotatoWedgesSubPrice + ChickenNuggetSubPrice + MushroomSoupSubPrice + PotatoSoupSubPrice + ChickenSoupSubPrice + SpaghettiBologneseSubPrice + SpaghettiCarbonaraMushroomSubPrice + SpaghettiAglioOlioSubPrice + ChickenChopSubPrice + GrilledChickenMushroomSubPrice + GrilledChickenBlackPepperSubPrice, "0.00")

        If (txtMilkTeaAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtMilkTeaAmount.Text & " Milk Tea: RM" & MilkTeaSubPrice & "0")
        End If

        If (txtGreenTeaAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtGreenTeaAmount.Text & " Green Tea: RM" & GreenTeaSubPrice & "0")
        End If

        If (txtLemonTeaAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtLemonTeaAmount.Text & " Lemon Tea: RM" & LemonTeaSubPrice & "0")
        End If

        If (txtChickenBurgerAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtChickenBurgerAmount.Text & " Chicken Burger: RM" & ChickenBurgerSubPrice & "0")
        End If

        If (txtSpicyChickenBurgerAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtSpicyChickenBurgerAmount.Text & " Spicy Chicken Burger: RM" & SpicyChickenBurgerSubPrice & "0")
        End If

        If (txtCrispyFishBurgerAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtCrispyFishBurgerAmount.Text & " Crispy Fish Burger: RM" & CrispyFishBurgerSubPrice & "0")
        End If

        If (txtTiramisuAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtTiramisuAmount.Text & " Tiramisu: RM" & TiramisuSubPrice & "0")
        End If

        If (txtCheesecakeAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtCheesecakeAmount.Text & " Cheesecake: RM" & CheesecakeSubPrice & "0")
        End If

        If (txtChocolateCakeAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtChocolateCakeAmount.Text & " Chocolate Cake: RM" & ChocolateCakeSubPrice & "0")
        End If

        If (txtFrenchFriesAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtFrenchFriesAmount.Text & " French Fries: RM" & FrenchFriesSubPrice & "0")
        End If

        If (txtPotatoWedgesAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtPotatoWedgesAmount.Text & " Potato Wedges: RM" & PotatoWedgesSubPrice & "0")
        End If

        If (txtChickenNuggetAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtChickenNuggetAmount.Text & " Chicken Nuggets (6pcs): RM" & ChickenNuggetSubPrice & "0")
        End If

        If (txtMushroomSoupAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtMushroomSoupAmount.Text & " Mushroom Soup: RM" & MushroomSoupSubPrice & "0")
        End If

        If (txtPotatoSoupAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtPotatoSoupAmount.Text & " Potato Soup: RM" & PotatoSoupSubPrice & "0")
        End If

        If (txtChickenSoupAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtChickenSoupAmount.Text & " Chicken Soup: RM" & ChickenSoupSubPrice & "0")
        End If

        If (txtSpaghettiBologneseAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtSpaghettiBologneseAmount.Text & " Spaghetti Bolognese: RM" & SpaghettiBologneseSubPrice & "0")
        End If

        If (txtSpaghettiCarbonaraMushroomAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtSpaghettiCarbonaraMushroomAmount.Text & " Spaghetti Carbonara with Mushroom: RM" & SpaghettiCarbonaraMushroomSubPrice & "0")
        End If

        If (txtSpaghettiAglioOlioAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtSpaghettiAglioOlioAmount.Text & " Spaghetti Aglio Olio Peperoncino: RM" & SpaghettiAglioOlioSubPrice & "0")
        End If

        If (txtChickenChopAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtChickenChopAmount.Text & " Oriental Chicken Chop: RM" & ChickenChopSubPrice & "0")
        End If

        If (txtGrilledChickenMushroomAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtGrilledChickenMushroomAmount.Text & " Grilled Chicken with Mushroom Sauce: RM" & GrilledChickenMushroomSubPrice & "0")
        End If

        If (txtGrilledChickenBlackPepperAmount.Text >= 1) Then
            lstPlaceOrderCheck.Items.Add(txtGrilledChickenBlackPepperAmount.Text & " Grilled Chicken with Black Pepper Sauce: RM" & GrilledChickenBlackPepperSubPrice & "0")
        End If

        lstPlaceOrderCheck.Items.Add("")
        lstPlaceOrderCheck.Items.Add("------------------------------")
        lstPlaceOrderCheck.Items.Add("Your total is: RM" & TotalPrice & "0")

    End Sub

    'Edit Order
    Private Sub btnEditOrder_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click
        lstPlaceOrderCheck.Items.Clear()
    End Sub

    'Clear Order
    Private Sub btnClearOrder_Click(sender As Object, e As EventArgs) Handles btnClearOrder.Click
        lstPlaceOrderCheck.Items.Clear()
        txtMilkTeaAmount.Text = 0
        txtGreenTeaAmount.Text = 0
        txtLemonTeaAmount.Text = 0
        txtChickenBurgerAmount.Text = 0
        txtSpicyChickenBurgerAmount.Text = 0
        txtCrispyFishBurgerAmount.Text = 0
        txtTiramisuAmount.Text = 0
        txtCheesecakeAmount.Text = 0
        txtChocolateCakeAmount.Text = 0
        txtFrenchFriesAmount.Text = 0
        txtPotatoWedgesAmount.Text = 0
        txtChickenNuggetAmount.Text = 0
        txtMushroomSoupAmount.Text = 0
        txtPotatoSoupAmount.Text = 0
        txtChickenSoupAmount.Text = 0
        txtSpaghettiBologneseAmount.Text = 0
        txtSpaghettiCarbonaraMushroomAmount.Text = 0
        txtSpaghettiAglioOlioAmount.Text = 0
        txtChickenChopAmount.Text = 0
        txtGrilledChickenMushroomAmount.Text = 0
        txtGrilledChickenBlackPepperAmount.Text = 0
    End Sub

    'Pay
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        If lstPlaceOrderCheck.Items.Count > 0 Then

            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            commmand = "insert into Payment (Payment_ID) values ('" & txtPaymentID.Text & "')"
            Dim cmdpayment As OleDbCommand = New OleDbCommand(commmand, myconnection)
            cmdpayment.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))

            cmdpayment.ExecuteNonQuery()

            Dim MilkTeaSubPrice As Single
            Dim GreenTeaSubPrice As Single
            Dim LemonTeaSubPrice As Single
            Dim ChickenBurgerSubPrice As Single
            Dim SpicyChickenBurgerSubPrice As Single
            Dim CrispyFishBurgerSubPrice As Single
            Dim TiramisuSubPrice As Single
            Dim CheesecakeSubPrice As Single
            Dim ChocolateCakeSubPrice As Single
            Dim FrenchFriesSubPrice As Single
            Dim PotatoWedgesSubPrice As Single
            Dim ChickenNuggetSubPrice As Single
            Dim MushroomSoupSubPrice As Single
            Dim PotatoSoupSubPrice As Single
            Dim ChickenSoupSubPrice As Single
            Dim SpaghettiBologneseSubPrice As Single
            Dim SpaghettiCarbonaraMushroomSubPrice As Single
            Dim SpaghettiAglioOlioSubPrice As Single
            Dim ChickenChopSubPrice As Single
            Dim GrilledChickenMushroomSubPrice As Single
            Dim GrilledChickenBlackPepperSubPrice As Single
            Dim TotalPrice As Single


            MilkTeaSubPrice = Format(txtMilkTeaAmount.Text * 3.9, "0.00")
            GreenTeaSubPrice = Format(txtGreenTeaAmount.Text * 3.9, "0.00")
            LemonTeaSubPrice = Format(txtLemonTeaAmount.Text * 3.9, "0.00")
            ChickenBurgerSubPrice = Format(txtChickenBurgerAmount.Text * 9.9, "0.00")
            SpicyChickenBurgerSubPrice = Format(txtSpicyChickenBurgerAmount.Text * 10.9, "0.00")
            CrispyFishBurgerSubPrice = Format(txtCrispyFishBurgerAmount.Text * 9.9, "0.00")
            TiramisuSubPrice = Format(txtTiramisuAmount.Text * 6.9, "0.00")
            CheesecakeSubPrice = Format(txtCheesecakeAmount.Text * 6.9, "0.00")
            ChocolateCakeSubPrice = Format(txtChocolateCakeAmount.Text * 5.9, "0.00")
            FrenchFriesSubPrice = Format(txtFrenchFriesAmount.Text * 5.9, "0.00")
            PotatoWedgesSubPrice = Format(txtPotatoWedgesAmount.Text * 5.9, "0.00")
            ChickenNuggetSubPrice = Format(txtChickenNuggetAmount.Text * 6.9, "0.00")
            MushroomSoupSubPrice = Format(txtMushroomSoupAmount.Text * 5.9, "0.00")
            PotatoSoupSubPrice = Format(txtPotatoSoupAmount.Text * 5.9, "0.00")
            ChickenSoupSubPrice = Format(txtChickenSoupAmount.Text * 6.9, "0.00")
            SpaghettiBologneseSubPrice = Format(txtSpaghettiBologneseAmount.Text * 9.9, "0.00")
            SpaghettiCarbonaraMushroomSubPrice = Format(txtSpaghettiCarbonaraMushroomAmount.Text * 9.9, "0.00")
            SpaghettiAglioOlioSubPrice = Format(txtSpaghettiAglioOlioAmount.Text * 9.9, "0.00")
            ChickenChopSubPrice = Format(txtChickenChopAmount.Text * 10.9, "0.00")
            GrilledChickenMushroomSubPrice = Format(txtGrilledChickenMushroomAmount.Text * 12.3, "0.00")
            GrilledChickenBlackPepperSubPrice = Format(txtGrilledChickenBlackPepperAmount.Text * 12.3, "0.00")

            TotalPrice = Format(MilkTeaSubPrice + GreenTeaSubPrice + LemonTeaSubPrice + ChickenBurgerSubPrice + SpicyChickenBurgerSubPrice + CrispyFishBurgerSubPrice + TiramisuSubPrice + CheesecakeSubPrice + ChocolateCakeSubPrice + FrenchFriesSubPrice + PotatoWedgesSubPrice + ChickenNuggetSubPrice + MushroomSoupSubPrice + PotatoSoupSubPrice + ChickenSoupSubPrice + SpaghettiBologneseSubPrice + SpaghettiCarbonaraMushroomSubPrice + SpaghettiAglioOlioSubPrice + ChickenChopSubPrice + GrilledChickenMushroomSubPrice + GrilledChickenBlackPepperSubPrice, "0.00")


            txtMilkTeaSubPrice.Text = MilkTeaSubPrice
            txtGreenTeaSubPrice.Text = GreenTeaSubPrice
            txtLemonTeaSubPrice.Text = LemonTeaSubPrice
            txtChickenBurgerSubPrice.Text = ChickenBurgerSubPrice
            txtSpicyChickenBurgerSubPrice.Text = SpicyChickenBurgerSubPrice
            txtCrispyFishBurgerSubPrice.Text = CrispyFishBurgerSubPrice
            txtTiramisuSubPrice.Text = TiramisuSubPrice
            txtCheesecakeSubPrice.Text = CheesecakeSubPrice
            txtChocolateCakeSubPrice.Text = ChocolateCakeSubPrice
            txtFrenchFriesSubPrice.Text = FrenchFriesSubPrice
            txtPotatoWedgesSubPrice.Text = PotatoWedgesSubPrice
            txtChickenNuggetSubPrice.Text = ChickenNuggetSubPrice
            txtMushroomSoupSubPrice.Text = MushroomSoupSubPrice
            txtPotatoSoupSubPrice.Text = PotatoSoupSubPrice
            txtChickenSoupSubPrice.Text = ChickenSoupSubPrice
            txtSpaghettiBologneseSubPrice.Text = SpaghettiBologneseSubPrice
            txtSpaghettiCarbonaraMushroomSubPrice.Text = SpaghettiCarbonaraMushroomSubPrice
            txtSpaghettiAglioOlioSubPrice.Text = SpaghettiAglioOlioSubPrice
            txtChickenChopSubPrice.Text = ChickenChopSubPrice
            txtGrilledChickenMushroomSubPrice.Text = GrilledChickenMushroomSubPrice
            txtGrilledChickenBlackPepperSubPrice.Text = GrilledChickenBlackPepperSubPrice
            txtTotalPrice.Text = TotalPrice
            cmdpayment.Dispose()
            myconnection.Close()

            'Into CustomerOrder 
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Access Database\UUMCafeDatabase5.accdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()

            If (txtMilkTeaAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Milk Tea" & "','" & txtMilkTeaSubPrice.Text & "','" & txtMilkTeaAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordermilktea As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordermilktea.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordermilktea.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordermilktea.Parameters.Add(New OleDbParameter("Item_Menu", CType("Milk Tea", String)))
                cmdordermilktea.Parameters.Add(New OleDbParameter("Item_Price", CType(txtMilkTeaSubPrice.Text, String)))
                cmdordermilktea.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtMilkTeaAmount.Text, String)))
                cmdordermilktea.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtGreenTeaAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Green Tea" & "','" & txtGreenTeaSubPrice.Text & "','" & txtGreenTeaAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordergreentea As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordergreentea.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordergreentea.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordergreentea.Parameters.Add(New OleDbParameter("Item_Menu", CType("Green Tea", String)))
                cmdordergreentea.Parameters.Add(New OleDbParameter("Item_Price", CType(txtGreenTeaSubPrice.Text, String)))
                cmdordergreentea.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtGreenTeaAmount.Text, String)))
                cmdordergreentea.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtLemonTeaAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Lemon Tea" & "','" & txtLemonTeaSubPrice.Text & "','" & txtLemonTeaAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderlemontea As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Item_Menu", CType("Lemon Tea", String)))
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Item_Price", CType(txtLemonTeaSubPrice.Text, String)))
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtLemonTeaAmount.Text, String)))
                cmdorderlemontea.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtChickenBurgerAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Chicken Burger" & "','" & txtChickenBurgerSubPrice.Text & "','" & txtChickenBurgerAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderchickenburger As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Item_Menu", CType("Chicken Burger", String)))
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Item_Price", CType(txtChickenBurgerSubPrice.Text, String)))
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtChickenBurgerAmount.Text, String)))
                cmdorderchickenburger.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtSpicyChickenBurgerAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Spicy Chicken Burger" & "','" & txtSpicyChickenBurgerSubPrice.Text & "','" & txtSpicyChickenBurgerAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderspicychickenburger As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Item_Menu", CType("Spicy Chicken Burger", String)))
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Item_Price", CType(txtSpicyChickenBurgerSubPrice.Text, String)))
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtSpicyChickenBurgerAmount.Text, String)))
                cmdorderspicychickenburger.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtCrispyFishBurgerAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Crispy FIsh Burger" & "','" & txtCrispyFishBurgerSubPrice.Text & "','" & txtCrispyFishBurgerAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordercrispyfishburger As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Item_Menu", CType("Crispy Fish Burger", String)))
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Item_Price", CType(txtCrispyFishBurgerSubPrice.Text, String)))
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtCrispyFishBurgerAmount.Text, String)))
                cmdordercrispyfishburger.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtTiramisuAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Tiramisu" & "','" & txtTiramisuSubPrice.Text & "','" & txtTiramisuAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordertiramisu As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Item_Menu", CType("Tiramisu", String)))
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Item_Price", CType(txtTiramisuSubPrice.Text, String)))
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtTiramisuAmount.Text, String)))
                cmdordertiramisu.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtCheesecakeAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Cheesecake" & "','" & txtCheesecakeSubPrice.Text & "','" & txtCheesecakeAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordercheesecake As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Item_Menu", CType("Cheesecake", String)))
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Item_Price", CType(txtCheesecakeSubPrice.Text, String)))
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtCheesecakeAmount.Text, String)))
                cmdordercheesecake.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtChocolateCakeAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Chocolate Cake" & "','" & txtChocolateCakeSubPrice.Text & "','" & txtChocolateCakeAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderchocolatecake As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Item_Menu", CType("Chocolate Cake", String)))
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Item_Price", CType(txtChocolateCakeSubPrice.Text, String)))
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtChocolateCakeAmount.Text, String)))
                cmdorderchocolatecake.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtFrenchFriesAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "French Fries" & "','" & txtFrenchFriesSubPrice.Text & "','" & txtFrenchFriesAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderfrenchfries As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Item_Menu", CType("French Fries", String)))
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Item_Price", CType(txtFrenchFriesSubPrice.Text, String)))
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtFrenchFriesAmount.Text, String)))
                cmdorderfrenchfries.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtPotatoWedgesAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Potawo Wedges" & "','" & txtPotatoWedgesSubPrice.Text & "','" & txtPotatoWedgesAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderpotatowedges As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Item_Menu", CType("Potato Wedges", String)))
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Item_Price", CType(txtPotatoWedgesSubPrice.Text, String)))
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtPotatoWedgesAmount.Text, String)))
                cmdorderpotatowedges.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtChickenNuggetAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Chicken Nuggets (6 pcs)" & "','" & txtChickenNuggetSubPrice.Text & "','" & txtChickenNuggetAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderchickennugget As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Item_Menu", CType("Chicken Nuggets (6pcs)", String)))
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Item_Price", CType(txtChickenNuggetSubPrice.Text, String)))
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtChickenNuggetAmount.Text, String)))
                cmdorderchickennugget.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtMushroomSoupAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Mushroom Soup" & "','" & txtMushroomSoupSubPrice.Text & "','" & txtMushroomSoupAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdordermushroomsoup As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Item_Menu", CType("Mushroom Soup", String)))
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Item_Price", CType(txtMushroomSoupSubPrice.Text, String)))
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtMushroomSoupAmount.Text, String)))
                cmdordermushroomsoup.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtPotatoSoupAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Potato Soup" & "','" & txtPotatoSoupSubPrice.Text & "','" & txtPotatoSoupAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderpotatosoup As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Item_Menu", CType("Potato Soup", String)))
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Item_Price", CType(txtPotatoSoupSubPrice.Text, String)))
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtPotatoSoupAmount.Text, String)))
                cmdorderpotatosoup.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtChickenSoupAmount.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Chicken Soup" & "','" & txtChickenSoupSubPrice.Text & "','" & txtChickenSoupAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdorderchickensoup As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Item_Menu", CType("Chicken Soup", String)))
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Item_Price", CType(txtChickenSoupSubPrice.Text, String)))
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtChickenSoupAmount.Text, String)))
                cmdorderchickensoup.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtSpaghettiBologneseSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Spaghetti Bolognese" & "','" & txtSpaghettiBologneseSubPrice.Text & "','" & txtSpaghettiBologneseAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdspaghettibolognese As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Item_Menu", CType("Spaghetti Bolognese", String)))
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Item_Price", CType(txtSpaghettiBologneseSubPrice.Text, String)))
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtSpaghettiBologneseAmount.Text, String)))
                cmdspaghettibolognese.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtSpaghettiCarbonaraMushroomSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Spaghetti Carbonara Mushroom" & "','" & txtSpaghettiCarbonaraMushroomSubPrice.Text & "','" & txtSpaghettiCarbonaraMushroomAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdspaghetticarbonaramushroom As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Item_Menu", CType("Spaghetti Carbonara with Mushroom", String)))
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Item_Price", CType(txtSpaghettiCarbonaraMushroomSubPrice.Text, String)))
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtSpaghettiCarbonaraMushroomAmount.Text, String)))
                cmdspaghetticarbonaramushroom.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtSpaghettiAglioOlioSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Spaghetti Aglio Olio Peperoncino" & "','" & txtSpaghettiAglioOlioSubPrice.Text & "','" & txtSpaghettiAglioOlioAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdspaghettiaglioolio As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Item_Menu", CType("Spaghetti Aglio Olio Peperoncino", String)))
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Item_Price", CType(txtSpaghettiAglioOlioSubPrice.Text, String)))
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtSpaghettiAglioOlioAmount.Text, String)))
                cmdspaghettiaglioolio.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtChickenChopSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Oriental Chicken Chop" & "','" & txtChickenChopSubPrice.Text & "','" & txtChickenChopAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdchickenchop As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdchickenchop.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdchickenchop.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdchickenchop.Parameters.Add(New OleDbParameter("Item_Menu", CType("Oriental Chicken Chop", String)))
                cmdchickenchop.Parameters.Add(New OleDbParameter("Item_Price", CType(txtChickenChopSubPrice.Text, String)))
                cmdchickenchop.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtChickenChopAmount.Text, String)))
                cmdchickenchop.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtGrilledChickenMushroomSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Grilled Chicken with Mushroom Sauce" & "','" & txtGrilledChickenMushroomSubPrice.Text & "','" & txtGrilledChickenMushroomAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdgrilledchickenmushroom As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Item_Menu", CType("Grilled Chicken with Mushroom Sauce", String)))
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Item_Price", CType(txtGrilledChickenMushroomSubPrice.Text, String)))
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtGrilledChickenMushroomAmount.Text, String)))
                cmdgrilledchickenmushroom.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            If (txtGrilledChickenBlackPepperSubPrice.Text >= 1) Then
                commmand = "insert into CustomerOrder ([Customer_ID] , [Customer_Name] , [Item_Menu] , [Item_Price] , [Item_Quantity] , [Payment_ID]) values ('" & txtCustomerID.Text & "','" & txtCustomerName.Text & "','" & "Grilled Chicken with Black Pepper Sauce" & "','" & txtGrilledChickenBlackPepperSubPrice.Text & "','" & txtGrilledChickenBlackPepperAmount.Text & "','" & txtPaymentID.Text & "') "
                Dim cmdgrilledchickenblackpepper As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Customer_ID", CType(txtCustomerID.Text, String)))
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Customer_Name", CType(txtCustomerName.Text, String)))
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Item_Menu", CType("Grilled Chicken with Black Pepper Sauce", String)))
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Item_Price", CType(txtGrilledChickenBlackPepperSubPrice.Text, String)))
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Item_Quantity", CType(txtGrilledChickenBlackPepperAmount.Text, String)))
                cmdgrilledchickenblackpepper.Parameters.Add(New OleDbParameter("Payment_ID", CType(txtPaymentID.Text, String)))
                Dim cmdorder As OleDbCommand = New OleDbCommand(commmand, myconnection)
                cmdorder.ExecuteNonQuery()
            End If

            myconnection.Close()
            Me.Hide()
            frmPayment.Show()

        Else
            MsgBox("You need to place order to view your ordered food.", MessageBoxIcon.Information, "UUM Cafe YAB")
        End If

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        frmCustMainMenu.Show()
    End Sub
End Class