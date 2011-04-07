

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IPListUpdate()

    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick
        Call IPListUpdate()

        ' Controle of daar een ip adres inzit uit de goeie range

        Dim i As Integer
        Dim bolWire As Boolean = False
        Dim bolWifi As Boolean = False
        Dim regKey As Microsoft.Win32.RegistryKey


        For i = 0 To lbIP.Items.Count - 1

            Select Case Mid(lbIP.Items(i), 1, 5)
                Case "10.65"
                    bolWire = True
                Case "10.20"
                    bolWifi = True

            End Select
        Next

        If bolWifi = True And bolWire = True Then
            lblProfiel.Text = "Profiel (automatisch): Bekabeld - Proxy Uit"

            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", True)
            regKey.SetValue("ProxyEnable", 0)
            regKey.SetValue("ProxyServer", "10.100.40.1:8080")

        Else
            lblProfiel.Text = "Profiel (automatisch): Draadloos - Proxy Aan"

            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", True)
            regKey.SetValue("ProxyEnable", 1)
            regKey.SetValue("ProxyServer", "10.100.40.1:8080")

        End If

    End Sub

    Public Sub IPListUpdate()
        Dim strHostname As String
        Dim i As Integer

        strHostname = System.Net.Dns.GetHostName
        lbIP.Items.Clear()

        For i = 0 To System.Net.Dns.GetHostByName(strHostname).AddressList.Count - 1
            lbIP.Items.Add(System.Net.Dns.GetHostByName(strHostname).AddressList(i).ToString)
        Next

        lblHostName.Text = strHostname

    End Sub

    Private Sub btnToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggle.Click
        Dim regKey As Microsoft.Win32.RegistryKey

        Select Case btnToggle.Text
            Case "Proxy: Detecteren"
                tmrCheck.Enabled = True
                btnToggle.Text = "Proxy: Inschakelen"

                lblProfiel.Text = "Profiel (automatisch): ..."

            Case "Proxy: Inschakelen"
                tmrCheck.Enabled = False
                btnToggle.Text = "Proxy: Uitschakelen"

                lblProfiel.Text = "Profiel (handmatig): Proxy Aan"

                regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", True)
                regKey.SetValue("ProxyEnable", 1)
                regKey.SetValue("ProxyServer", "10.100.40.1:8080")

            Case "Proxy: Uitschakelen"
                tmrCheck.Enabled = False
                btnToggle.Text = "Proxy: Detecteren"

                lblProfiel.Text = "Profiel (handmatig): Proxy Uit"

                regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", True)
                regKey.SetValue("ProxyEnable", 0)
                regKey.SetValue("ProxyServer", "10.100.40.1:8080")

        End Select

    End Sub
End Class
