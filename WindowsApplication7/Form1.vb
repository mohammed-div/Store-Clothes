Imports System.Text
Public Class Form1
    Dim s As String = "welcome in world the clothes ", s1 As String = ""

    Dim i As Integer = 0
    Private browser As Object

    Private Sub guna2Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guna2Button3.Click
        Panel64.BringToFront()
        Panel5.Visible = True
        FlowLayoutPanel3.BringToFront()
        Guna2Panel71.Visible = True
        Guna2Panel69.Visible = True
        Guna2Panel35.Visible = True
        Guna2Panel33.Visible = True
        Guna2Panel31.Visible = True
        Guna2Panel29.Visible = True
        Guna2Panel27.Visible = True
        Guna2Panel25.Visible = True
        Guna2Panel16.Visible = True
        Guna2Panel18.Visible = True
        Guna2Panel21.Visible = True
        Guna2Panel23.Visible = True
        Guna2Panel14.Visible = True
        Guna2Panel12.Visible = True
        Guna2Panel36.Visible = True
        Guna2Panel38.Visible = True
        Guna2Panel40.Visible = True
        Guna2Panel42.Visible = True
        Guna2Panel44.Visible = True
        Guna2Panel46.Visible = True
        Guna2Panel48.Visible = True
        Guna2Panel50.Visible = True
        Guna2Panel52.Visible = True
        Guna2Panel54.Visible = True
        Guna2Panel56.Visible = True
        Guna2Panel58.Visible = True
        guna2Panel4.Visible = True
        guna2Panel6.Visible = True
        guna2Panel8.Visible = True
        guna2Panel10.Visible = True
        guna2Panel20.Visible = True
        guna2Panel61.Visible = True
        guna2Panel63.Visible = True
        guna2Panel65.Visible = True
        guna2Panel67.Visible = True
        guna2Panel74.Visible = True
        guna2Panel80.Visible = True
        guna2Panel82.Visible = True
        guna2Panel84.Visible = True
        guna2Panel86.Visible = True
        guna2Panel88.Visible = True
        guna2Panel90.Visible = True
        guna2Panel92.Visible = True
        guna2Panel94.Visible = True
        guna2Panel96.Visible = True
        guna2Panel98.Visible = True
        guna2Panel100.Visible = True
        guna2Panel102.Visible = True

        guna2Panel76.Visible = True
        guna2Panel78.Visible = True
        guna2Panel104.Visible = True
        Guna2Panel106.Visible = True
        Guna2Panel108.Visible = True
        Guna2Panel110.Visible = True
        Guna2Panel112.Visible = True
        Guna2Panel114.Visible = True
        Guna2Panel116.Visible = True
        Guna2Panel118.Visible = True
        Guna2Panel120.Visible = True
        Guna2Panel122.Visible = True
        Guna2Panel124.Visible = True
        Guna2Panel126.Visible = True
        Guna2Panel128.Visible = True
        Guna2Panel130.Visible = True
        Guna2Panel132.Visible = True
        Guna2Panel134.Visible = True
        Guna2Panel136.Visible = True
        Guna2Panel138.Visible = True
        Guna2Panel140.Visible = True
        Guna2Panel142.Visible = True
        Guna2Panel144.Visible = True
    End Sub

    Private Sub gunaAdvenceButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaAdvenceButton20.Click
        If Guna2ComboBox2.Text = "" Then
            Panel5.Visible = True
            Panel64.BringToFront()
            FlowLayoutPanel3.BringToFront()
            guna2Panel104.Visible = True
            Guna2Panel106.Visible = True
            Guna2Panel108.Visible = True
            Guna2Panel110.Visible = True
            Guna2Panel112.Visible = True
            Guna2Panel114.Visible = True
            Guna2Panel116.Visible = True
            Guna2Panel118.Visible = True
            Guna2Panel120.Visible = True
            Guna2Panel122.Visible = True
            Guna2Panel124.Visible = True
            Guna2Panel71.Visible = True
            Guna2Panel69.Visible = True
            Guna2Panel35.Visible = True
            Guna2Panel33.Visible = True
            Guna2Panel31.Visible = True
            Guna2Panel29.Visible = True
            Guna2Panel27.Visible = True
            Guna2Panel25.Visible = True
            Guna2Panel16.Visible = True
            Guna2Panel18.Visible = True
            Guna2Panel21.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "WOMAN\نساء" Then
            Panel5.Visible = True
            Panel64.BringToFront()
            FlowLayoutPanel3.BringToFront()
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            guna2Panel104.Visible = True
            Guna2Panel106.Visible = True
            Guna2Panel108.Visible = True
            Guna2Panel110.Visible = True
            Guna2Panel112.Visible = True
            Guna2Panel114.Visible = True
            Guna2Panel116.Visible = True
            Guna2Panel118.Visible = True
            Guna2Panel120.Visible = True
            Guna2Panel122.Visible = True
            Guna2Panel124.Visible = True
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "MAN\رجال" Then
            Panel5.Visible = True
            Panel64.BringToFront()
            FlowLayoutPanel3.BringToFront()
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel71.Visible = True
            Guna2Panel69.Visible = True
            Guna2Panel35.Visible = True
            Guna2Panel33.Visible = True
            Guna2Panel31.Visible = True
            Guna2Panel29.Visible = True
            Guna2Panel27.Visible = True
            Guna2Panel25.Visible = True
            Guna2Panel16.Visible = True
            Guna2Panel18.Visible = True
            Guna2Panel21.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "All" Then
            Panel5.Visible = True
            Panel64.BringToFront()
            FlowLayoutPanel3.BringToFront()
            guna2Panel104.Visible = True
            Guna2Panel106.Visible = True
            Guna2Panel108.Visible = True
            Guna2Panel110.Visible = True
            Guna2Panel112.Visible = True
            Guna2Panel114.Visible = True
            Guna2Panel116.Visible = True
            Guna2Panel118.Visible = True
            Guna2Panel120.Visible = True
            Guna2Panel122.Visible = True
            Guna2Panel124.Visible = True
            Guna2Panel71.Visible = True
            Guna2Panel69.Visible = True
            Guna2Panel35.Visible = True
            Guna2Panel33.Visible = True
            Guna2Panel31.Visible = True
            Guna2Panel29.Visible = True
            Guna2Panel27.Visible = True
            Guna2Panel25.Visible = True
            Guna2Panel16.Visible = True
            Guna2Panel18.Visible = True
            Guna2Panel21.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
    End Sub

    Private Sub gunaAdvenceButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaAdvenceButton21.Click
        If Guna2ComboBox2.Text = "" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            Guna2Panel126.Visible = True
            Guna2Panel128.Visible = True
            Guna2Panel130.Visible = True
            Guna2Panel132.Visible = True
            Guna2Panel134.Visible = True
            Guna2Panel136.Visible = True
            Guna2Panel138.Visible = True
            Guna2Panel140.Visible = True
            Guna2Panel142.Visible = True
            Guna2Panel144.Visible = True
            guna2Panel84.Visible = True
            guna2Panel86.Visible = True
            guna2Panel88.Visible = True
            guna2Panel90.Visible = True
            guna2Panel92.Visible = True
            guna2Panel94.Visible = True
            guna2Panel96.Visible = True
            guna2Panel98.Visible = True
            guna2Panel100.Visible = True
            guna2Panel102.Visible = True
            guna2Panel104.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "All" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            Guna2Panel126.Visible = True
            Guna2Panel128.Visible = True
            Guna2Panel130.Visible = True
            Guna2Panel132.Visible = True
            Guna2Panel134.Visible = True
            Guna2Panel136.Visible = True
            Guna2Panel138.Visible = True
            Guna2Panel140.Visible = True
            Guna2Panel142.Visible = True
            Guna2Panel144.Visible = True
            guna2Panel84.Visible = True
            guna2Panel86.Visible = True
            guna2Panel88.Visible = True
            guna2Panel90.Visible = True
            guna2Panel92.Visible = True
            guna2Panel94.Visible = True
            guna2Panel96.Visible = True
            guna2Panel98.Visible = True
            guna2Panel100.Visible = True
            guna2Panel102.Visible = True
            guna2Panel104.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "WOMAN\نساء" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            Guna2Panel126.Visible = True
            Guna2Panel128.Visible = True
            Guna2Panel130.Visible = True
            Guna2Panel132.Visible = True
            Guna2Panel134.Visible = True
            Guna2Panel136.Visible = True
            Guna2Panel138.Visible = True
            Guna2Panel140.Visible = True
            Guna2Panel142.Visible = True
            Guna2Panel144.Visible = True
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "MAN\رجال" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            guna2Panel84.Visible = True
            guna2Panel86.Visible = True
            guna2Panel88.Visible = True
            guna2Panel90.Visible = True
            guna2Panel92.Visible = True
            guna2Panel94.Visible = True
            guna2Panel96.Visible = True
            guna2Panel98.Visible = True
            guna2Panel100.Visible = True
            guna2Panel102.Visible = True
            guna2Panel104.Visible = True
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If Guna2ComboBox2.Text = "" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel146.Visible = True
            Guna2Panel148.Visible = True
            Guna2Panel150.Visible = True
            Guna2Panel152.Visible = True
            Guna2Panel154.Visible = True
            Guna2Panel156.Visible = True
            Guna2Panel158.Visible = True
            Guna2Panel160.Visible = True
            Guna2Panel162.Visible = True
            Guna2Panel164.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = True
            Guna2Panel14.Visible = True
            Guna2Panel12.Visible = True
            Guna2Panel36.Visible = True
            Guna2Panel38.Visible = True
            Guna2Panel40.Visible = True
            Guna2Panel42.Visible = True
            Guna2Panel44.Visible = True
            Guna2Panel46.Visible = True
            Guna2Panel48.Visible = True
            Guna2Panel50.Visible = True
            Guna2Panel52.Visible = True
            Guna2Panel54.Visible = True
            Guna2Panel56.Visible = True
            Guna2Panel58.Visible = True
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "All" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel146.Visible = True
            Guna2Panel148.Visible = True
            Guna2Panel150.Visible = True
            Guna2Panel152.Visible = True
            Guna2Panel154.Visible = True
            Guna2Panel156.Visible = True
            Guna2Panel158.Visible = True
            Guna2Panel160.Visible = True
            Guna2Panel162.Visible = True
            Guna2Panel164.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = True
            Guna2Panel14.Visible = True
            Guna2Panel12.Visible = True
            Guna2Panel36.Visible = True
            Guna2Panel38.Visible = True
            Guna2Panel40.Visible = True
            Guna2Panel42.Visible = True
            Guna2Panel44.Visible = True
            Guna2Panel46.Visible = True
            Guna2Panel48.Visible = True
            Guna2Panel50.Visible = True
            Guna2Panel52.Visible = True
            Guna2Panel54.Visible = True
            Guna2Panel56.Visible = True
            Guna2Panel58.Visible = True
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "WOMAN\نساء" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel146.Visible = True
            Guna2Panel148.Visible = True
            Guna2Panel150.Visible = True
            Guna2Panel152.Visible = True
            Guna2Panel154.Visible = True
            Guna2Panel156.Visible = True
            Guna2Panel158.Visible = True
            Guna2Panel160.Visible = True
            Guna2Panel162.Visible = True
            Guna2Panel164.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
        If Guna2ComboBox2.Text = "MAN\رجال" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = True
            Guna2Panel14.Visible = True
            Guna2Panel12.Visible = True
            Guna2Panel36.Visible = True
            Guna2Panel38.Visible = True
            Guna2Panel40.Visible = True
            Guna2Panel42.Visible = True
            Guna2Panel44.Visible = True
            Guna2Panel46.Visible = True
            Guna2Panel48.Visible = True
            Guna2Panel50.Visible = True
            Guna2Panel52.Visible = True
            Guna2Panel54.Visible = True
            Guna2Panel56.Visible = True
            Guna2Panel58.Visible = True
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
        End If
    End Sub

    Private Sub gunaAdvenceButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaAdvenceButton15.Click
        If Guna2ComboBox2.Text = "" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel166.Visible = True
            Guna2Panel168.Visible = True
            Guna2Panel170.Visible = True
            Guna2Panel172.Visible = True
            Guna2Panel174.Visible = True
            Guna2Panel176.Visible = True
            Guna2Panel178.Visible = True
            Guna2Panel180.Visible = True
            Guna2Panel182.Visible = True
            Guna2Panel184.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = True
            guna2Panel6.Visible = True
            guna2Panel8.Visible = True
            guna2Panel10.Visible = True
            guna2Panel20.Visible = True
            guna2Panel61.Visible = True
            guna2Panel63.Visible = True
            guna2Panel65.Visible = True
            guna2Panel67.Visible = True
            guna2Panel74.Visible = True
            guna2Panel80.Visible = True
            guna2Panel82.Visible = True
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
        End If
        If Guna2ComboBox2.Text = "WOMAN\نساء" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel166.Visible = True
            Guna2Panel168.Visible = True
            Guna2Panel170.Visible = True
            Guna2Panel172.Visible = True
            Guna2Panel174.Visible = True
            Guna2Panel176.Visible = True
            Guna2Panel178.Visible = True
            Guna2Panel180.Visible = True
            Guna2Panel182.Visible = True
            Guna2Panel184.Visible = True
            Guna2Panel2.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = False
            guna2Panel6.Visible = False
            guna2Panel8.Visible = False
            guna2Panel10.Visible = False
            guna2Panel20.Visible = False
            guna2Panel61.Visible = False
            guna2Panel63.Visible = False
            guna2Panel65.Visible = False
            guna2Panel67.Visible = False
            guna2Panel74.Visible = False
            guna2Panel80.Visible = False
            guna2Panel82.Visible = False
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
        End If
        If Guna2ComboBox2.Text = "MAN\رجال" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel166.Visible = False
            Guna2Panel168.Visible = False
            Guna2Panel170.Visible = False
            Guna2Panel172.Visible = False
            Guna2Panel174.Visible = False
            Guna2Panel176.Visible = False
            Guna2Panel178.Visible = False
            Guna2Panel180.Visible = False
            Guna2Panel182.Visible = False
            Guna2Panel184.Visible = False
            Guna2Panel2.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = True
            guna2Panel6.Visible = True
            guna2Panel8.Visible = True
            guna2Panel10.Visible = True
            guna2Panel20.Visible = True
            guna2Panel61.Visible = True
            guna2Panel63.Visible = True
            guna2Panel65.Visible = True
            guna2Panel67.Visible = True
            guna2Panel74.Visible = True
            guna2Panel80.Visible = True
            guna2Panel82.Visible = True
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
        End If
        If Guna2ComboBox2.Text = "All" Then
            Panel64.BringToFront()
            Panel5.Visible = True
            FlowLayoutPanel3.BringToFront()
            Guna2Panel166.Visible = True
            Guna2Panel168.Visible = True
            Guna2Panel170.Visible = True
            Guna2Panel172.Visible = True
            Guna2Panel174.Visible = True
            Guna2Panel176.Visible = True
            Guna2Panel178.Visible = True
            Guna2Panel180.Visible = True
            Guna2Panel182.Visible = True
            Guna2Panel184.Visible = True
            Guna2Panel126.Visible = False
            Guna2Panel128.Visible = False
            Guna2Panel130.Visible = False
            Guna2Panel132.Visible = False
            Guna2Panel134.Visible = False
            Guna2Panel136.Visible = False
            Guna2Panel138.Visible = False
            Guna2Panel140.Visible = False
            Guna2Panel142.Visible = False
            Guna2Panel144.Visible = False
            Guna2Panel71.Visible = False
            Guna2Panel69.Visible = False
            Guna2Panel35.Visible = False
            Guna2Panel33.Visible = False
            Guna2Panel31.Visible = False
            Guna2Panel29.Visible = False
            Guna2Panel27.Visible = False
            Guna2Panel25.Visible = False
            Guna2Panel16.Visible = False
            Guna2Panel18.Visible = False
            Guna2Panel21.Visible = False
            Guna2Panel23.Visible = False
            Guna2Panel14.Visible = False
            Guna2Panel12.Visible = False
            Guna2Panel36.Visible = False
            Guna2Panel38.Visible = False
            Guna2Panel40.Visible = False
            Guna2Panel42.Visible = False
            Guna2Panel44.Visible = False
            Guna2Panel46.Visible = False
            Guna2Panel48.Visible = False
            Guna2Panel50.Visible = False
            Guna2Panel52.Visible = False
            Guna2Panel54.Visible = False
            Guna2Panel56.Visible = False
            Guna2Panel58.Visible = False
            guna2Panel4.Visible = True
            guna2Panel6.Visible = True
            guna2Panel8.Visible = True
            guna2Panel10.Visible = True
            guna2Panel20.Visible = True
            guna2Panel61.Visible = True
            guna2Panel63.Visible = True
            guna2Panel65.Visible = True
            guna2Panel67.Visible = True
            guna2Panel74.Visible = True
            guna2Panel80.Visible = True
            guna2Panel82.Visible = True
            guna2Panel84.Visible = False
            guna2Panel86.Visible = False
            guna2Panel88.Visible = False
            guna2Panel90.Visible = False
            guna2Panel92.Visible = False
            guna2Panel94.Visible = False
            guna2Panel96.Visible = False
            guna2Panel98.Visible = False
            guna2Panel100.Visible = False
            guna2Panel102.Visible = False
            guna2Panel104.Visible = False
            guna2Panel76.Visible = False
            guna2Panel78.Visible = False
            Guna2Panel146.Visible = False
            Guna2Panel148.Visible = False
            Guna2Panel150.Visible = False
            Guna2Panel152.Visible = False
            Guna2Panel154.Visible = False
            Guna2Panel156.Visible = False
            Guna2Panel158.Visible = False
            Guna2Panel160.Visible = False
            Guna2Panel162.Visible = False
            Guna2Panel164.Visible = False
            guna2Panel104.Visible = False
            Guna2Panel106.Visible = False
            Guna2Panel108.Visible = False
            Guna2Panel110.Visible = False
            Guna2Panel112.Visible = False
            Guna2Panel114.Visible = False
            Guna2Panel116.Visible = False
            Guna2Panel118.Visible = False
            Guna2Panel120.Visible = False
            Guna2Panel122.Visible = False
            Guna2Panel124.Visible = False
        End If
    End Sub

    Private Sub GunaLabel38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel38.Click
        panel55.Visible = True
        pictureBox51.Image = Guna2PictureBox39.Image
        textBox51.Text = GunaLabel37.Text
        button57.Visible = True
    End Sub

    Private Sub Guna2PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2PictureBox39.Click

    End Sub

    Private Sub GunaLabel40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel40.Click
        panel6.Visible = True
        pictureBox2.Image = Guna2PictureBox40.Image
        textBox2.Text = GunaLabel39.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel69.Click
        panel7.Visible = True
        pictureBox3.Image = Guna2PictureBox41.Image
        textBox3.Text = GunaLabel68.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel71.Click
        panel8.Visible = True
        pictureBox4.Image = Guna2PictureBox42.Image
        textBox4.Text = GunaLabel70.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel30.Click
        panel9.Visible = True
        pictureBox5.Image = Guna2PictureBox19.Image
        textBox5.Text = GunaLabel29.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel32.Click
        panel10.Visible = True
        pictureBox6.Image = Guna2PictureBox20.Image
        textBox6.Text = GunaLabel31.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel34.Click
        panel11.Visible = True
        pictureBox7.Image = Guna2PictureBox37.Image
        textBox7.Text = GunaLabel33.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel36.Click
        panel12.Visible = True
        pictureBox8.Image = Guna2PictureBox38.Image
        textBox8.Text = GunaLabel35.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel16.Click
        panel60.Visible = True
        pictureBox56.Image = Guna2PictureBox15.Image
        textBox56.Text = GunaLabel15.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel22.Click
        panel14.Visible = True
        pictureBox10.Image = Guna2PictureBox16.Image
        textBox10.Text = GunaLabel17.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel26.Click
        panel15.Visible = True
        pictureBox11.Image = Guna2PictureBox17.Image
        textBox11.Text = GunaLabel24.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel28.Click
        panel16.Visible = True
        pictureBox12.Image = Guna2PictureBox18.Image
        textBox12.Text = GunaLabel27.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel23.Click
        panel20.Visible = True
        pictureBox16.Image = Guna2PictureBox22.Image
        textBox16.Text = GunaLabel21.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel19.Click
        panel19.Visible = True
        pictureBox15.Image = Guna2PictureBox21.Image
        textBox15.Text = GunaLabel18.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel12.Click
        panel18.Visible = True
        pictureBox14.Image = Guna2PictureBox13.Image
        textBox14.Text = GunaLabel11.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel14.Click
        panel17.Visible = True
        pictureBox13.Image = Guna2PictureBox14.Image
        textBox13.Text = GunaLabel13.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel47.Click
        panel24.Visible = True
        pictureBox20.Image = Guna2PictureBox26.Image
        textBox20.Text = GunaLabel46.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel45.Click
        panel23.Visible = True
        pictureBox19.Image = Guna2PictureBox25.Image
        textBox19.Text = GunaLabel44.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel43.Click
        panel22.Visible = True
        pictureBox18.Image = Guna2PictureBox24.Image
        textBox18.Text = GunaLabel42.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel41.Click
        panel21.Visible = True
        pictureBox17.Image = Guna2PictureBox23.Image
        textBox17.Text = GunaLabel25.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel55.Click
        panel28.Visible = True
        pictureBox24.Image = Guna2PictureBox30.Image
        textBox24.Text = GunaLabel54.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel53.Click
        panel27.Visible = True
        pictureBox23.Image = Guna2PictureBox29.Image
        textBox23.Text = GunaLabel52.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel51.Click
        panel26.Visible = True
        pictureBox22.Image = Guna2PictureBox28.Image
        textBox22.Text = GunaLabel50.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel49.Click
        panel25.Visible = True
        pictureBox21.Image = Guna2PictureBox27.Image
        textBox21.Text = GunaLabel48.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel57.Click
        panel29.Visible = True
        pictureBox25.Image = Guna2PictureBox31.Image
        textBox25.Text = GunaLabel56.Text
        button57.Visible = True
    End Sub

    Private Sub GunaLabel59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel59.Click
        panel30.Visible = True
        pictureBox26.Image = Guna2PictureBox32.Image
        textBox26.Text = GunaLabel58.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel2.Click
        panel31.Visible = True
        pictureBox27.Image = guna2PictureBox2.Image
        textBox27.Text = gunaLabel1.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel4.Click
        panel32.Visible = True
        pictureBox28.Image = guna2PictureBox3.Image
        textBox28.Text = gunaLabel3.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel60.Click
        panel35.Visible = True
        pictureBox31.Image = guna2PictureBox7.Image
        textBox31.Text = gunaLabel20.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel10.Click
        panel56.Visible = True
        pictureBox52.Image = guna2PictureBox6.Image
        textBox52.Text = gunaLabel9.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel8.Click
        panel60.Visible = True
        pictureBox56.Image = guna2PictureBox5.Image
        textBox56.Text = gunaLabel7.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel6.Click
        panel32.Visible = True
        pictureBox28.Image = guna2PictureBox4.Image
        textBox28.Text = gunaLabel5.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel62.Click
        panel57.Visible = True
        pictureBox53.Image = guna2PictureBox8.Image
        textBox53.Text = gunaLabel61.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel64.Click
        panel57.Visible = True
        pictureBox53.Image = guna2PictureBox9.Image
        textBox53.Text = gunaLabel63.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel66.Click
        panel38.Visible = True
        pictureBox34.Image = guna2PictureBox10.Image
        textBox34.Text = gunaLabel65.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel72.Click
        panel39.Visible = True
        pictureBox35.Image = guna2PictureBox11.Image
        textBox35.Text = gunaLabel67.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel80.Click
        panel59.Visible = True
        pictureBox55.Image = guna2PictureBox35.Image
        textBox55.Text = gunaLabel79.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel78.Click
        panel42.Visible = True
        pictureBox38.Image = guna2PictureBox34.Image
        textBox38.Text = gunaLabel77.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel76.Click
        panel41.Visible = True
        pictureBox38.Image = guna2PictureBox33.Image
        textBox38.Text = gunaLabel75.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel74.Click
        panel40.Visible = True
        pictureBox37.Image = guna2PictureBox12.Image
        textBox37.Text = gunaLabel73.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel82.Click
        panel48.Visible = True
        pictureBox44.Image = guna2PictureBox36.Image
        textBox44.Text = gunaLabel81.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel84.Click
        panel44.Visible = True
        pictureBox40.Image = guna2PictureBox43.Image
        textBox40.Text = gunaLabel83.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel86.Click
        panel47.Visible = True
        pictureBox43.Image = guna2PictureBox44.Image
        textBox43.Text = gunaLabel85.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel88.Click
        Panel71.Visible = True
        PictureBox57.Image = guna2PictureBox45.Image
        TextBox58.Text = gunaLabel87.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel90.Click
        panel58.Visible = True
        pictureBox54.Image = guna2PictureBox46.Image
        textBox54.Text = gunaLabel89.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel92.Click
        panel50.Visible = True
        pictureBox46.Image = guna2PictureBox47.Image
        textBox46.Text = gunaLabel91.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel94.Click
        panel58.Visible = True
        pictureBox54.Image = guna2PictureBox48.Image
        textBox54.Text = gunaLabel93.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel96.Click
        panel52.Visible = True
        pictureBox48.Image = guna2PictureBox49.Image
        textBox48.Text = gunaLabel95.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel98.Click
        panel60.Visible = True
        pictureBox56.Image = guna2PictureBox50.Image
        textBox56.Text = gunaLabel97.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel100.Click
        panel54.Visible = True
        pictureBox50.Image = guna2PictureBox51.Image
        textBox50.Text = gunaLabel99.Text
        button57.Visible = True
    End Sub

    Private Sub gunaLabel102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaLabel102.Click
        panel55.Visible = True
        pictureBox51.Image = guna2PictureBox52.Image
        textBox51.Text = gunaLabel101.Text
        button57.Visible = True
    End Sub

    Private Sub gunaAdvenceButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaAdvenceButton18.Click
        Panel4.BringToFront()
    End Sub

    Private Sub button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button57.Click
        button58.Visible = True
        textBox57.Visible = True
        textBox57.Text = Val(TextBox58.Text) + Val(textBox56.Text) + Val(textBox55.Text) + Val(textBox54.Text) + Val(textBox53.Text) + Val(textBox52.Text) + Val(textBox51.Text) + Val(textBox50.Text) + Val(textBox49.Text) + Val(textBox48.Text) + Val(textBox47.Text) + Val(textBox46.Text) + Val(textBox45.Text) + Val(textBox44.Text) + Val(textBox43.Text) + Val(textBox42.Text) + Val(textBox41.Text) + Val(textBox40.Text) + Val(textBox39.Text) + Val(textBox38.Text) + Val(textBox37.Text) + Val(textBox36.Text) + Val(textBox35.Text) + Val(textBox34.Text) + Val(textBox33.Text) + Val(textBox32.Text) + Val(textBox31.Text) + Val(textBox30.Text) + Val(textBox29.Text) + Val(textBox28.Text) + Val(textBox27.Text) + Val(textBox26.Text) + Val(textBox25.Text) + Val(textBox24.Text) + Val(textBox23.Text) + Val(textBox22.Text) + Val(textBox21.Text) + Val(textBox20.Text) + Val(textBox19.Text) + Val(textBox18.Text) + Val(textBox17.Text) + Val(textBox16.Text) + Val(textBox15.Text) + Val(textBox14.Text) + Val(textBox13.Text) + Val(textBox12.Text) + Val(textBox11.Text) + Val(textBox10.Text) + Val(textBox9.Text) + Val(textBox8.Text) + Val(textBox7.Text) + Val(textBox6.Text) + Val(textBox5.Text) + Val(textBox4.Text) + Val(textBox3.Text) + Val(textBox2.Text) + Val(textBox1.Text)
    End Sub
    Private Sub button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button58.Click
        If textBox57.Text = 0 Then
            MessageBox.Show(" card is empaty")
        Else
            Panel65.BringToFront()
            pn_login.BringToFront()
            Label20.Text = textBox57.Text
        End If
    End Sub

    Private Sub Panel62_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel62.Paint

    End Sub

    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton3.Click
        Panel80.BringToFront()
        GunaAdvenceButton2.Enabled = False
    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Panel63.BringToFront()
        GunaAdvenceButton3.Enabled = False
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        If Guna2ComboBox1.Text = "" Then
            If BunifuMetroTextbox5.Text = "" And BunifuMetroTextbox6.Text = "" Then
                MessageBox.Show("Compelte the entry requirments")
            Else
                MessageBox.Show("Successful Purchase")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
            End If
        End If

        If Guna2ComboBox1.Text = "English" Then
            If BunifuMetroTextbox5.Text = "" And BunifuMetroTextbox6.Text = "" Then
                MessageBox.Show("Compelte the entry requirments")
            Else
                MessageBox.Show("Successful Purchase")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
            End If
        End If
        If Guna2ComboBox1.Text = "العربية" Then
            If BunifuMetroTextbox5.Text = "" And BunifuMetroTextbox6.Text = "" Then
                MessageBox.Show("اكمل متطلبات الادخال")
            Else
                MessageBox.Show("تم الشراء بنجاح")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
            End If
        End If
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        If Guna2ComboBox1.Text = "" Then
            If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" Then
                MessageBox.Show("Compelte the entry requirments")
            Else
                MessageBox.Show("Successful Purchase")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
                Panel68.BringToFront()
            End If
        End If
        If Guna2ComboBox1.Text = "English" Then
            If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" Then
                MessageBox.Show("Compelte the entry requirments")
            Else
                MessageBox.Show("Successful Purchase")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
                Panel68.BringToFront()
            End If
        End If
        If Guna2ComboBox1.Text = "العربية" Then
            If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" Then
                MessageBox.Show("اكمل متطلبات الادخال")
            Else
                MessageBox.Show("تم الشراء بنجاح")
                Panel5.Visible = False
                button57.Visible = False
                textBox57.Visible = False
                button58.Visible = False
                Panel68.BringToFront()
                Panel68.BringToFront()
            End If
        End If
    End Sub

    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gunaAdvenceButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Panel61.Visible = False
        textBox1.Text = ""

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        panel6.Visible = False
        textBox2.Text = ""
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        panel7.Visible = False
        textBox3.Text = ""
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        panel8.Visible = False
        textBox4.Text = ""
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        panel9.Visible = False
        textBox5.Text = ""
    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        panel11.Visible = False
        textBox7.Text = ""
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        panel6.Visible = False
        textBox6.Text = ""
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        panel12.Visible = False
        textBox8.Text = ""
    End Sub

    Private Sub button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click
        panel13.Visible = False
        textBox9.Text = ""
    End Sub

    Private Sub button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button10.Click
        panel14.Visible = False
        textBox10.Text = ""
    End Sub

    Private Sub button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button11.Click
        panel15.Visible = False
        textBox11.Text = ""
    End Sub

    Private Sub button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button12.Click
        panel16.Visible = False
        textBox12.Text = ""
    End Sub

    Private Sub button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button13.Click
        panel17.Visible = False
        textBox13.Text = ""
    End Sub

    Private Sub button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button14.Click
        panel18.Visible = False
        textBox14.Text = ""
    End Sub

    Private Sub button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button15.Click
        panel19.Visible = False
        textBox15.Text = ""
    End Sub

    Private Sub button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button16.Click
        panel20.Visible = False
        textBox16.Text = ""
    End Sub

    Private Sub button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button17.Click
        panel21.Visible = False
        textBox17.Text = ""
    End Sub

    Private Sub button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button18.Click
        panel22.Visible = False
        textBox18.Text = ""
    End Sub

    Private Sub button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button19.Click
        panel23.Visible = False
        textBox19.Text = ""
    End Sub

    Private Sub button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button20.Click
        panel24.Visible = False
        textBox20.Text = ""
    End Sub

    Private Sub button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button21.Click
        panel25.Visible = False
        textBox21.Text = ""
    End Sub

    Private Sub button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button22.Click
        panel26.Visible = False
        textBox22.Text = ""
    End Sub

    Private Sub button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button23.Click
        panel27.Visible = False
        textBox23.Text = ""
    End Sub

    Private Sub button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button24.Click
        panel28.Visible = False
        textBox24.Text = ""
    End Sub

    Private Sub button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button25.Click
        panel29.Visible = False
        textBox25.Text = ""
    End Sub

    Private Sub button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button26.Click
        panel30.Visible = False
        textBox26.Text = ""
    End Sub

    Private Sub button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button27.Click
        panel31.Visible = False
        textBox27.Text = ""
    End Sub

    Private Sub button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button28.Click
        panel32.Visible = False
        textBox28.Text = ""
    End Sub

    Private Sub button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button29.Click
        panel33.Visible = False
        textBox29.Text = ""
    End Sub

    Private Sub button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button30.Click
        panel34.Visible = False
        textBox30.Text = ""
    End Sub

    Private Sub button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button31.Click
        panel35.Visible = False
        textBox31.Text = ""
    End Sub

    Private Sub button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button32.Click
        panel36.Visible = False
        textBox32.Text = ""
    End Sub

    Private Sub button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button33.Click
        panel37.Visible = False
        textBox33.Text = ""
    End Sub

    Private Sub button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button34.Click
        panel38.Visible = False
        textBox34.Text = ""
    End Sub

    Private Sub button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button35.Click
        panel39.Visible = False
        textBox35.Text = ""
    End Sub

    Private Sub button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button36.Click
        panel40.Visible = False
        textBox36.Text = ""
    End Sub

    Private Sub button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button37.Click
        panel41.Visible = False
        textBox37.Text = ""
    End Sub

    Private Sub button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button38.Click
        panel42.Visible = False
        textBox38.Text = ""
    End Sub

    Private Sub button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button39.Click
        panel43.Visible = False
        textBox39.Text = ""
    End Sub

    Private Sub button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button40.Click
        panel44.Visible = False
        textBox40.Text = ""
    End Sub

    Private Sub button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button41.Click
        panel45.Visible = False
        textBox41.Text = ""
    End Sub

    Private Sub button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button42.Click
        panel46.Visible = False
        textBox42.Text = ""
    End Sub

    Private Sub button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button43.Click
        panel47.Visible = False
        textBox43.Text = ""
    End Sub

    Private Sub button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button44.Click
        panel48.Visible = False
        textBox44.Text = ""
    End Sub

    Private Sub button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button45.Click
        panel49.Visible = False
        textBox45.Text = ""
    End Sub

    Private Sub panel50_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel50.Paint

    End Sub

    Private Sub button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button46.Click
        panel50.Visible = False
        textBox46.Text = ""
    End Sub

    Private Sub button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button47.Click
        panel51.Visible = False
        textBox47.Text = ""
    End Sub

    Private Sub button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button48.Click
        panel52.Visible = False
        textBox48.Text = ""
    End Sub

    Private Sub button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button49.Click
        panel53.Visible = False
        textBox49.Text = ""
    End Sub

    Private Sub button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button50.Click
        panel54.Visible = False
        textBox50.Text = ""
    End Sub

    Private Sub button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button51.Click
        panel55.Visible = False
        textBox51.Text = ""
    End Sub

    Private Sub button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button52.Click
        panel56.Visible = False
        textBox52.Text = ""
    End Sub

    Private Sub button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button53.Click
        panel57.Visible = False
        textBox53.Text = ""
    End Sub

    Private Sub button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button54.Click
        panel58.Visible = False
        textBox54.Text = ""
    End Sub

    Private Sub button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button55.Click
        panel59.Visible = False
        textBox55.Text = ""
    End Sub

    Private Sub button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button56.Click
        panel60.Visible = False
        textBox56.Text = ""
    End Sub

    Private Sub Panel68_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel68.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub gunaAdvenceButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gunaAdvenceButton16.Click
        Panel68.BringToFront()
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button66.Click
        MessageBox.Show("thanks for your rating", "has been sent")
    End Sub

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        MessageBox.Show("thanks", "has been sent ")
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Guna2Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Guna2Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

        If Guna2ComboBox1.Text = "English" Then
            Guna2Button2.Text = "Setting"
            guna2Button3.Text = "ALL..."
            gunaAdvenceButton15.Text = "Shoes"
            GunaAdvenceButton1.Text = "Pants"
            gunaAdvenceButton21.Text = "Jaket"
            gunaAdvenceButton20.Text = "T-Shirt"

            gunaAdvenceButton18.Text = "Cart"
            gunaAdvenceButton16.Text = "Home"
            GunaLabel71.Text = "Add To Cart"
            GunaLabel38.Text = "Add To Cart"
            GunaLabel40.Text = "Add To Cart"
            GunaLabel69.Text = "Add To Cart"
            GunaLabel30.Text = "Add To Cart"
            GunaLabel32.Text = "Add To Cart"
            GunaLabel34.Text = "Add To Cart"

            GunaLabel36.Text = "Add To Cart"
            GunaLabel16.Text = "Add To Cart"
            GunaLabel22.Text = "Add To Cart"
            GunaLabel26.Text = "Add To Cart"
            GunaLabel28.Text = "Add To Cart"
            GunaLabel19.Text = "Add To Cart"
            GunaLabel23.Text = "Add To Cart"
            GunaLabel12.Text = "Add To Cart"
            GunaLabel14.Text = "Add To Cart"
            GunaLabel47.Text = "Add To Cart"
            GunaLabel45.Text = "Add To Cart"
            GunaLabel43.Text = "Add To Cart"
            GunaLabel41.Text = "Add To Cart"
            GunaLabel55.Text = "Add To Cart"
            GunaLabel53.Text = "Add To Cart"
            GunaLabel51.Text = "Add To Cart"
            GunaLabel49.Text = "Add To Cart"
            gunaLabel4.Text = "Add To Cart"

            gunaLabel2.Text = "Add To Cart"
            GunaLabel59.Text = "Add To Cart"
            GunaLabel57.Text = "Add To Cart"
            gunaLabel60.Text = "Add To Cart"
            gunaLabel10.Text = "Add To Cart"
            gunaLabel8.Text = "Add To Cart"
            gunaLabel6.Text = "Add To Cart"
            gunaLabel72.Text = "Add To Cart"
            gunaLabel66.Text = "Add To Cart"
            gunaLabel64.Text = "Add To Cart"
            gunaLabel62.Text = "Add To Cart"
            gunaLabel80.Text = "Add To Cart"
            gunaLabel78.Text = "Add To Cart"
            gunaLabel76.Text = "Add To Cart"
            gunaLabel74.Text = "Add To Cart"
            gunaLabel88.Text = "Add To Cart"
            gunaLabel86.Text = "Add To Cart"
            gunaLabel84.Text = "Add To Cart"
            gunaLabel82.Text = "Add To Cart"
            gunaLabel96.Text = "Add To Cart"
            gunaLabel94.Text = "Add To Cart"
            gunaLabel92.Text = "Add To Cart"
            gunaLabel90.Text = "Add To Cart"
            gunaLabel98.Text = "Add To Cart"
            gunaLabel100.Text = "Add To Cart"
            gunaLabel102.Text = "Add To Cart"
            GunaLabel104.Text = "Add To Cart"
            GunaLabel107.Text = "Add To Cart"
            GunaLabel109.Text = "Add To Cart"
            GunaLabel111.Text = "Add To Cart"
            GunaLabel113.Text = "Add To Cart"
            GunaLabel115.Text = "Add To Cart"
            GunaLabel117.Text = "Add To Cart"
            GunaLabel119.Text = "Add To Cart"
            GunaLabel121.Text = "Add To Cart"
            GunaLabel123.Text = "Add To Cart"
            GunaLabel125.Text = "Add To Cart"
            GunaLabel127.Text = "Add To Cart"
            GunaLabel129.Text = "Add To Cart"
            GunaLabel131.Text = "Add To Cart"
            GunaLabel133.Text = "Add To Cart"
            GunaLabel135.Text = "Add To Cart"
            GunaLabel137.Text = "Add To Cart"
            GunaLabel139.Text = "Add To Cart"
            GunaLabel141.Text = "Add To Cart"
            GunaLabel143.Text = "Add To Cart"
            GunaLabel145.Text = "Add To Cart"

            GunaAdvenceButton2.Text = "Paypal"
            GunaAdvenceButton3.Text = "Visa"
            Label8.Text = "UserName"
            Label7.Text = "Password"
            Button59.Text = "Pay"
            GunaAdvenceButton2.Text = "Paypal"
            GunaAdvenceButton3.Text = "Visa"
            Label1.Text = "Id Card"
            Label2.Text = "Name Card"
            Label3.Text = "EX Date Card"
            Label4.Text = "CVV"
            Button60.Text = "Pay"
            Label15.Text = "Rating"
            Label16.Text = " was it helpful"
            Button66.Text = "Sumbit"
            Button65.Text = "Sumbit"
            RadioButton1.Text = "Yes"
            RadioButton2.Text = "No"
            Label18.Text = "Parogmming"
            button57.Text = "Total"
            button58.Text = "Buy Now"
            Guna2Button1.Text = "Sort"
        End If
        If Guna2ComboBox1.Text = "العربية" Then
            Guna2Button2.Text = "اعدادات"
            guna2Button3.Text = "بحث عام"
            gunaAdvenceButton15.Text = "احذية"
            GunaAdvenceButton1.Text = "بناطيل"
            gunaAdvenceButton21.Text = "جاكيتات"
            gunaAdvenceButton20.Text = "تيشيرتات"

            gunaAdvenceButton18.Text = "السلة"
            gunaAdvenceButton16.Text = " الرئيسية"
            GunaLabel71.Text = "اضف الى السلة"
            GunaLabel38.Text = "اضف الى السلة"
            GunaLabel40.Text = "اضف الى السلة"
            GunaLabel69.Text = "اضف الى السلة"
            GunaLabel30.Text = "اضف الى السلة"
            GunaLabel32.Text = "اضف الى السلة"
            GunaLabel34.Text = "اضف الى السلة"

            GunaLabel36.Text = "اضف الى السلة"
            GunaLabel16.Text = "اضف الى السلة"
            GunaLabel22.Text = "اضف الى السلة"
            GunaLabel26.Text = "اضف الى السلةt"
            GunaLabel28.Text = "اضف الى السلة"
            GunaLabel19.Text = "اضف الى السلة"
            GunaLabel23.Text = "اضف الى السلة"
            GunaLabel12.Text = "اضف الى السلة"
            GunaLabel14.Text = "اضف الى السلة"
            GunaLabel47.Text = "اضف الى السلة"
            GunaLabel45.Text = "اضف الى السلة"
            GunaLabel43.Text = "اضف الى السلة"
            GunaLabel41.Text = "اضف الى السلة"
            GunaLabel55.Text = "اضف الى السلة"
            GunaLabel53.Text = "اضف الى السلة"
            GunaLabel51.Text = "اضف الى السلة"
            GunaLabel49.Text = "اضف الى السلة"
            gunaLabel4.Text = "اضف الى السلة"

            gunaLabel2.Text = "اضف الى السلة"
            GunaLabel59.Text = "اضف الى السلة"
            GunaLabel57.Text = "اضف الى السلة"
            gunaLabel60.Text = "اضف الى السلة"
            gunaLabel10.Text = "اضف الى السلة"
            gunaLabel8.Text = "اضف الى السلة"
            gunaLabel6.Text = "اضف الى السلة"
            gunaLabel72.Text = "اضف الى السلة"
            gunaLabel66.Text = "اضف الى السلة"
            gunaLabel64.Text = "اضف الى السلة"
            gunaLabel62.Text = "اضف الى السلة"
            gunaLabel80.Text = "اضف الى السلة"
            gunaLabel78.Text = "اضف الى السلة"
            gunaLabel76.Text = "اضف الى السلة"
            gunaLabel74.Text = "اضف الى السلة"
            gunaLabel88.Text = "اضف الى السلة"
            gunaLabel86.Text = "اضف الى السلة"
            gunaLabel84.Text = "اضف الى السلة"
            gunaLabel82.Text = "اضف الى السلة"
            gunaLabel96.Text = "اضف الى السلة"
            gunaLabel94.Text = "اضف الى السلة"
            gunaLabel92.Text = "  اضف الى السلة"
            gunaLabel90.Text = " اضف الى السلة "
            gunaLabel98.Text = "اضف الى السلة"
            gunaLabel100.Text = "اضف الى السلة"
            gunaLabel102.Text = "اضف الى السلة"
            GunaLabel104.Text = "اضف الى السلة"
            GunaLabel107.Text = "اضف الى السلة"
            GunaLabel109.Text = "اضف الى السلة"
            GunaLabel111.Text = "اضف الى السلة"
            GunaLabel113.Text = "اضف الى السلة"
            GunaLabel115.Text = "اضف الى السلة"
            GunaLabel117.Text = "اضف الى السلة"
            GunaLabel119.Text = "اضف الى السلة"
            GunaLabel121.Text = "اضف الى السلة"
            GunaLabel123.Text = "اضف الى السلة"
            GunaLabel125.Text = "اضف الى السلة"
            GunaLabel127.Text = "اضف الى السلة"
            GunaLabel129.Text = "اضف الى السلة"
            GunaLabel131.Text = "اضف الى السلة"
            GunaLabel133.Text = "اضف الى السلة"
            GunaLabel135.Text = "اضف الى السلة"
            GunaLabel137.Text = "اضف الى السلة"
            GunaLabel139.Text = "اضف الى السلة"
            GunaLabel141.Text = "اضف الى السلة"
            GunaLabel143.Text = "اضف الى السلة"
            GunaLabel145.Text = "اضف الى السلة"

            GunaAdvenceButton2.Text = "Paypal"
            GunaAdvenceButton3.Text = "Visa"
            Label8.Text = "اسم المستخدم"
            Label7.Text = "كلمة السر"
            Button59.Text = "دفع"
            GunaAdvenceButton2.Text = "Paypal"
            GunaAdvenceButton3.Text = "Visa"
            Label1.Text = "رقم البطاقة"
            Label2.Text = "اسم البطاقة"
            Label3.Text = "تاريخ الانتهاء"
            Label4.Text = "CVV"
            Button60.Text = "دفع"
            Label15.Text = "التقييم"
            Label16.Text = " هل كان مفيدا"
            Button66.Text = "ارسال"
            Button65.Text = "ارسال"
            RadioButton1.Text = "نعم"
            RadioButton2.Text = "لا"
            Label18.Text = "حول المبرمج"
            button57.Text = "المجموع"
            button58.Text = " شراء الان "
            Guna2Button1.Text = "رتب"
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button67.Click
        Panel71.Visible = False
        TextBox58.Text = ""
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged


    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Panel77.Visible = True
    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaWinSwitch1.CheckedChanged

    End Sub

    Private Sub GunaWinSwitch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaWinSwitch1.Click
        If GunaWinSwitch1.Checked = True Then
            Me.BackColor = Color.Gray
            Guna2ComboBox1.FillColor = Color.Gray
            Guna2ComboBox2.FillColor = Color.Gray
            Guna2ComboBox1.BorderColor = Color.White
            Guna2ComboBox2.BorderColor = Color.White
            Panel72.BackColor = Color.Gray
            GunaLabel146.ForeColor = Color.Black
            GunaLabel148.ForeColor = Color.Black
        Else
            Me.BackColor = Color.Black
            Guna2ComboBox1.FillColor = Color.Black
            Guna2ComboBox2.FillColor = Color.Black
            Panel72.BackColor = Color.Black
            GunaLabel146.ForeColor = Color.White
            GunaLabel148.ForeColor = Color.White
        End If
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2RadioButton1.CheckedChanged
        Me.BackColor = Color.Green
        Guna2ComboBox1.FillColor = Color.Gray
        Guna2ComboBox2.FillColor = Color.Gray
        Guna2ComboBox1.BorderColor = Color.White
        Guna2ComboBox2.BorderColor = Color.White
        Panel72.BackColor = Color.Green
        GunaLabel146.ForeColor = Color.Black
        GunaLabel148.ForeColor = Color.Black
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2RadioButton2.CheckedChanged
        Me.BackColor = Color.Beige
        Guna2ComboBox1.FillColor = Color.Gray
        Guna2ComboBox2.FillColor = Color.Gray
        Guna2ComboBox1.BorderColor = Color.White
        Guna2ComboBox2.BorderColor = Color.White
        Panel72.BackColor = Color.Beige
        GunaLabel146.ForeColor = Color.Black
        GunaLabel148.ForeColor = Color.Black
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2RadioButton3.CheckedChanged
        Me.BackColor = Color.BurlyWood
        Guna2ComboBox1.FillColor = Color.Gray
        Guna2ComboBox2.FillColor = Color.Gray
        Guna2ComboBox1.BorderColor = Color.White
        Guna2ComboBox2.BorderColor = Color.White
        Panel72.BackColor = Color.BurlyWood
        GunaLabel146.ForeColor = Color.Black
        GunaLabel148.ForeColor = Color.Black
    End Sub

    Private Sub BunifuCheckbox1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = True Then
            BunifuThinButton22.Visible = True
            BunifuCheckbox2.Checked = False
            BunifuCheckbox3.Checked = False
            Label22.Visible = True
            Label23.Visible = True
            Label22.Text = "Card Name"
            Label23.Text = "Card Number"
            Label24.Visible = True
            Label25.Visible = False
            BunifuMetroTextbox12.Visible = True
            BunifuMetroTextbox13.Visible = True
            BunifuMaterialTextbox1.Visible = True
            BunifuMaterialTextbox2.Visible = True
            BunifuMetroTextbox16.Visible = False
            BunifuMetroTextbox17.Visible = False
            BunifuMetroTextbox18.Visible = False
        End If
    End Sub

    Private Sub BunifuCheckbox2_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuCheckbox2.OnChange
        If BunifuCheckbox2.Checked = True Then
            BunifuThinButton22.Visible = True
            BunifuCheckbox1.Checked = False
            BunifuCheckbox3.Checked = False
            Label22.Visible = True
            Label23.Visible = True
            Label22.Text = "Card Name"
            Label23.Text = "Card Number"
            Label24.Visible = True
            Label25.Visible = True
            BunifuMaterialTextbox1.Visible = True
            BunifuMaterialTextbox2.Visible = True
            BunifuMetroTextbox16.Visible = True
            BunifuMetroTextbox17.Visible = True
            BunifuMetroTextbox18.Visible = True
            BunifuMetroTextbox12.Visible = True
            BunifuMetroTextbox13.Visible = True
        End If
    End Sub

    Private Sub BunifuCheckbox3_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuCheckbox3.OnChange
        If BunifuCheckbox3.Checked = True Then
            BunifuThinButton22.Visible = True
            BunifuCheckbox2.Checked = False
            BunifuCheckbox1.Checked = False
            Label22.Visible = True
            Label23.Visible = True
            Label22.Text = "User Name"
            Label23.Text = "Password"
            Label24.Visible = False
            Label25.Visible = False
            BunifuMaterialTextbox1.Visible = False
            BunifuMaterialTextbox2.Visible = False
            BunifuMetroTextbox16.Visible = False
            BunifuMetroTextbox17.Visible = False
            BunifuMetroTextbox18.Visible = False
            BunifuMetroTextbox12.Visible = True
            BunifuMetroTextbox13.Visible = True
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton21.Click
        Panel4.BringToFront()
    End Sub

    Private Sub BunifuThinButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuThinButton22.Click
        Timer4.Enabled = True
        If BunifuCheckbox1.Checked = True Then
            If BunifuMetroTextbox12.Text = "" And BunifuMetroTextbox13.Text = "" And BunifuMaterialTextbox1.Text = "" And BunifuMaterialTextbox2.Text = "" Then
                MessageBox.Show("enter then data")

            End If
        End If
        If BunifuCheckbox2.Checked = True Then
            If BunifuMetroTextbox12.Text = "" And BunifuMetroTextbox13.Text = "" And BunifuMaterialTextbox1.Text = "" And BunifuMaterialTextbox2.Text = "" And BunifuMetroTextbox16.Text = "" And BunifuMetroTextbox17.Text = "" And BunifuMetroTextbox18.Text = "" Then
                MessageBox.Show("enter then data")

            End If
        End If
        If BunifuCheckbox3.Checked = True Then
            If BunifuMetroTextbox12.Text = "" And BunifuMetroTextbox13.Text = "" Then
                MessageBox.Show("enter then data")

            End If
        End If
        If BunifuCheckbox1.Checked = False And BunifuCheckbox2.Checked = False And BunifuCheckbox3.Checked = False Then
            MessageBox.Show(" Chooese Method payment")
        Else
            Panel78.BringToFront()
        End If
    End Sub

    Private Sub Panel65_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel65.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        s1 = s1 + s.Substring(i, 1)
        i = i + 1

        If i >= s.Length() Then
            Timer2.Stop()
        End If




        GunaLabel190.Text = s1
    End Sub

    Private Sub GunaLabel190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel190.Click


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub


    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub break()
        Throw New NotImplementedException
    End Sub

    Private Sub PictureBox58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub menuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub guna2CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub guna2GradientButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GradientButton1.Click
        If Guna2TextBox1.Text = "" And Guna2TextBox2.Text = "" Then
            MessageBox.Show("enter data")
        End If
        If Guna2TextBox5.Text = Guna2TextBox1.Text And Guna2TextBox6.Text = Guna2TextBox2.Text Then
                MessageBox.Show("suecssful Login")
                Panel75.BringToFront()
            Else
            MessageBox.Show("UserName or Password incorrect !")
        End If
    End Sub

    Private Sub Guna2Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button4.Click
        pn_regis.BringToFront()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ImageSlider1.AnimationTime = 2500
        Dim max As Byte = ImageSlider1.Images.Count
        Dim curpos As Byte = 0
        If curpos < max Then
            ImageSlider1.SlideNext()
        Else
            curpos = 0
            Timer3.Start()
        End If

    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Dim state As String
        Dim city As String
        Dim street As String
        state = TextBox59.Text
        city = TextBox60.Text
        street = TextBox61.Text
        Dim getaddress As New StringBuilder
        getaddress.Append("https://maps.google.com/maps?q=")
        If TextBox59.Text <> "" Then
            getaddress.Append(state + "," & "+")
        End If
        If TextBox60.Text <> "" Then
            getaddress.Append(city + "," & "+")
        End If
        If TextBox61.Text <> "" Then
            getaddress.Append(street + "," & "+")
        End If
        WebBrowser1.Navigate(getaddress.ToString)

    End Sub

    Private Sub GunaLabel191_Click(sender As Object, e As EventArgs) Handles GunaLabel191.Click
        Panel77.Visible = False
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress

    End Sub

    Private Sub Guna2TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub BunifuMetroTextbox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox12.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub BunifuMetroTextbox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox13.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox16_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox16.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox16.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox17_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox17.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox17.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMetroTextbox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox18.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If Guna2TextBox3.Text = "" And Guna2TextBox4.Text = "" And Guna2TextBox5.Text = "" And Guna2TextBox6.Text = "" Then
            MessageBox.Show("enter data")
        Else
            MessageBox.Show("suecssful Account")
            pn_login.BringToFront()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Timer4.Interval = 8000 Then
            MessageBox.Show("sueccessful order")
            Panel68.BringToFront()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        pn_login.BringToFront()
    End Sub
End Class
