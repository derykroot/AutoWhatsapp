Public Class Form1
    <Runtime.InteropServices.DllImport("user32.dll")> _
    Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Dim idxselold As Integer = -1
    Dim ctdncheck As Integer = 0

    Dim nroinit As String = ""

    Function getonlynumber(value As String) As String
        If value.Length < 1 Then Return ""
        Dim ret As String = ""
        For i = 0 To value.Length - 1
            If IsNumeric(value.Chars(i)) Then ret += value.Chars(i)
        Next
        Return ret
    End Function

    Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then e.KeyChar = ""
    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged, textBox2.TextChanged
        Dim newnro As String = getonlynumber(textBox1.Text)
        If textBox1.Focused And newnro = nroinit Then Exit Sub
        nroinit = newnro
        If IsNumeric(nroinit) And IsNumeric(textBox2.Text) Then
            Dim nro = CLng(nroinit)
            listBox1.Items.Clear()
            idxselold = -1
            ctdncheck = 0
            updatepanel()
            For i = 0 To CInt(textBox2.Text)
                listBox1.Items.Add((nro + i) & ":")
            Next
        End If
    End Sub

    Private Sub updatepanel()
        With FrPanel
            If listBox1.Items.Count < 1 Then
                .setnro = ""
                .setpos = ""
                .setfaltam = ""
            Else
                .setnro = If(listBox1.SelectedIndex > -1, listBox1.Items.Item(listBox1.SelectedIndex).ToString().Split(":")(0), "")
                .setpos = ctdncheck & " / " & listBox1.Items.Count
                .setfaltam = listBox1.Items.Count - ctdncheck
            End If
        End With
       
    End Sub

    Private Sub List_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles listBox1.DrawItem
        If e.Index < 0 Then Exit Sub
        Dim ret As Rectangle = e.Bounds

        Dim txt = sender.Items(e.Index).ToString().Split(":")(0)
        Dim stat = sender.Items(e.Index).ToString().Split(":")(1)

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            Dim cor1 As Color = If(stat = "ok", Color.FromArgb(250, 210, 200), Color.FromArgb(200, 240, 250))
            Dim cor2 As Color = If(stat = "ok", Color.FromArgb(250, 240, 240), Color.FromArgb(240, 240, 250))
            Dim Fundo As New Drawing2D.LinearGradientBrush(ret, cor2, cor1, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(Fundo, ret)
            Dim p As New Pen(New SolidBrush(Color.FromArgb(120, 160, 170)))
            e.Graphics.DrawRectangle(p, ret.X, ret.Y, ret.Width - 1, ret.Height - 1)
        Else
            Dim corf = If(stat = "ok", Color.FromArgb(245, 230, 230), Color.FromArgb(255, 255, 255))
            e.Graphics.FillRectangle(New SolidBrush(corf), ret)
            ' e.Graphics.DrawRectangle(New Pen(Color.FromArgb(255, 255, 255)), ret)
        End If


        Dim f As New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        Dim b As New SolidBrush(Color.FromArgb(70, 100, 120))

        e.Graphics.DrawString(txt, f, b, ret)
        e.Graphics.Dispose()
    End Sub


    Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedIndexChanged
        If listBox1.Items.Count > 0 Then
            'MsgBox(listBox1.SelectedItem)
            Dim lnk = "https://api.whatsapp.com/send?phone="
            ' webBrowser1.Navigate("https://github.com/")
            Me.Enabled = False
            Me.Validate()
            Application.DoEvents()
            loadlink(lnk & listBox1.SelectedItem.ToString().Split(":")(0))

            If listBox1.SelectedItem.ToString().Split(":")(1) <> "ok" Then
                ctdncheck += 1
            End If

            If idxselold >= 0 Then
                listBox1.Items.Item(idxselold) = listBox1.Items.Item(idxselold).ToString().Split(":")(0) & ":ok"
            End If
            idxselold = listBox1.SelectedIndex

            updatepanel()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.Down) <> 0 Then
            If listBox1.SelectedIndex > -1 And Not listBox1.Focused Then
                If listBox1.SelectedIndex < listBox1.Items.Count - 1 Then
                    listBox1.SelectedIndex += 1
                End If
            End If
        ElseIf GetAsyncKeyState(Keys.Up) <> 0 Then
            If listBox1.SelectedIndex > -1 And Not listBox1.Focused Then
                If listBox1.SelectedIndex > 0 Then
                    listBox1.SelectedIndex -= 1
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then FrPanel.Show() Else FrPanel.Hide()
    End Sub


    Delegate Sub delegsub()
    Private Sub loadlink(ln As String)
        Dim t As New Threading.Thread(Sub()
                                          Me.Invoke(New delegsub(Sub()
                                                                     If Me.Enabled Then Exit Sub
                                                                     webBrowser1.Navigate(ln)
                                                                 End Sub))
                                      End Sub)
        t.Start()
    End Sub
    Private Sub webBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles webBrowser1.Navigated
        Me.Enabled = True
    End Sub
End Class
