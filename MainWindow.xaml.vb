Class MainWindow
    Private Sub btnVeggie_Click(sender As Object, e As RoutedEventArgs) Handles btnVeggie.Click
        picVeggie.Visibility = Visibility.Visible
        picPrime.Visibility = Visibility.Hidden
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As RoutedEventArgs) Handles btnPrime.Click
        picPrime.Visibility = Visibility.Visible
        picVeggie.Visibility = Visibility.Hidden

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As RoutedEventArgs) Handles btnSelectMeal.Click
        btnPrime.IsEnabled = False
        btnVeggie.IsEnabled = False
        btnExit.IsEnabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
