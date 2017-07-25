Public Class Form1
    Public y1, y2, y3, y4 As Integer
    Public e1, e2, e3, e4, ea1, ea2, ea3, ea4 As Integer
    Public r1, r2, r3, r4, ra1, ra2, ra3, ra4 As Integer
    Public puan, rakip_puan As Integer
    Public kalan, cekilen As Integer
    Public deste(55), rakip_el(4) As Integer
    Public yerdekiler(55), alinanlar(55), verilenler(55) As Integer
    Public yerdeki_sira, alinan_sira, verilen_sira As Integer
    Public ilk_el, son_alindi As Boolean

    Private Sub kalan_karti_bul()
        kalan = 0
        For i = 1 To 52
            kalan = kalan + deste(i)
        Next
        '1 -> destede
        '0 -> çekilmiş

        '1 = 14 = 27 = 40 (mod 13)
        'sinek as = karo as = kupa as = maça as 
        '11=j 12=k 13=q
        'valeler: 11, 24, 37, 50
    End Sub
    Private Sub kart_cek()
        kalan_karti_bul()
        Randomize()
        cekilen = CInt(Int((52 * Rnd()) + 1))
        Do While deste(cekilen) = 0
            cekilen = CInt(Int((52 * Rnd()) + 1))
        Loop
        deste.SetValue(0, cekilen)
        kalan_karti_bul()
        Label6.Text = kalan

    End Sub
    Private Sub valesiz_kart_cek()
        kalan_karti_bul()
        Randomize()
        cekilen = CInt(Int((52 * Rnd()) + 1))
        Do While deste(cekilen) = 0 Or cekilen Mod 13 = 11
            cekilen = CInt(Int((52 * Rnd()) + 1))
        Loop
        deste.SetValue(0, cekilen)
        kalan_karti_bul()
        Label6.Text = kalan

    End Sub
    Private Sub gorsel_duzenle()
        If y1 = 0 Then
            PictureBox9.Image = My.Resources.zempty
        ElseIf y1 = 1 Then
            PictureBox9.Image = My.Resources._01
        ElseIf y1 = 2 Then
            PictureBox9.Image = My.Resources._02
        ElseIf y1 = 3 Then
            PictureBox9.Image = My.Resources._03
        ElseIf y1 = 4 Then
            PictureBox9.Image = My.Resources._04
        ElseIf y1 = 5 Then
            PictureBox9.Image = My.Resources._05
        ElseIf y1 = 6 Then
            PictureBox9.Image = My.Resources._06
        ElseIf y1 = 7 Then
            PictureBox9.Image = My.Resources._07
        ElseIf y1 = 8 Then
            PictureBox9.Image = My.Resources._08
        ElseIf y1 = 9 Then
            PictureBox9.Image = My.Resources._09
        ElseIf y1 = 10 Then
            PictureBox9.Image = My.Resources._10
        ElseIf y1 = 11 Then
            PictureBox9.Image = My.Resources._11
        ElseIf y1 = 12 Then
            PictureBox9.Image = My.Resources._12
        ElseIf y1 = 13 Then
            PictureBox9.Image = My.Resources._13
        ElseIf y1 = 14 Then
            PictureBox9.Image = My.Resources._14
        ElseIf y1 = 15 Then
            PictureBox9.Image = My.Resources._15
        ElseIf y1 = 16 Then
            PictureBox9.Image = My.Resources._16
        ElseIf y1 = 17 Then
            PictureBox9.Image = My.Resources._17
        ElseIf y1 = 18 Then
            PictureBox9.Image = My.Resources._18
        ElseIf y1 = 19 Then
            PictureBox9.Image = My.Resources._19
        ElseIf y1 = 20 Then
            PictureBox9.Image = My.Resources._20
        ElseIf y1 = 21 Then
            PictureBox9.Image = My.Resources._21
        ElseIf y1 = 22 Then
            PictureBox9.Image = My.Resources._22
        ElseIf y1 = 23 Then
            PictureBox9.Image = My.Resources._23
        ElseIf y1 = 24 Then
            PictureBox9.Image = My.Resources._24
        ElseIf y1 = 25 Then
            PictureBox9.Image = My.Resources._25
        ElseIf y1 = 26 Then
            PictureBox9.Image = My.Resources._26
        ElseIf y1 = 27 Then
            PictureBox9.Image = My.Resources._27
        ElseIf y1 = 28 Then
            PictureBox9.Image = My.Resources._28
        ElseIf y1 = 29 Then
            PictureBox9.Image = My.Resources._29
        ElseIf y1 = 30 Then
            PictureBox9.Image = My.Resources._30
        ElseIf y1 = 31 Then
            PictureBox9.Image = My.Resources._31
        ElseIf y1 = 32 Then
            PictureBox9.Image = My.Resources._32
        ElseIf y1 = 33 Then
            PictureBox9.Image = My.Resources._33
        ElseIf y1 = 34 Then
            PictureBox9.Image = My.Resources._34
        ElseIf y1 = 35 Then
            PictureBox9.Image = My.Resources._35
        ElseIf y1 = 36 Then
            PictureBox9.Image = My.Resources._36
        ElseIf y1 = 37 Then
            PictureBox9.Image = My.Resources._37
        ElseIf y1 = 38 Then
            PictureBox9.Image = My.Resources._38
        ElseIf y1 = 39 Then
            PictureBox9.Image = My.Resources._39
        ElseIf y1 = 40 Then
            PictureBox9.Image = My.Resources._40
        ElseIf y1 = 41 Then
            PictureBox9.Image = My.Resources._41
        ElseIf y1 = 42 Then
            PictureBox9.Image = My.Resources._42
        ElseIf y1 = 43 Then
            PictureBox9.Image = My.Resources._43
        ElseIf y1 = 44 Then
            PictureBox9.Image = My.Resources._44
        ElseIf y1 = 45 Then
            PictureBox9.Image = My.Resources._45
        ElseIf y1 = 46 Then
            PictureBox9.Image = My.Resources._46
        ElseIf y1 = 47 Then
            PictureBox9.Image = My.Resources._47
        ElseIf y1 = 48 Then
            PictureBox9.Image = My.Resources._48
        ElseIf y1 = 49 Then
            PictureBox9.Image = My.Resources._49
        ElseIf y1 = 50 Then
            PictureBox9.Image = My.Resources._50
        ElseIf y1 = 51 Then
            PictureBox9.Image = My.Resources._51
        ElseIf y1 = 52 Then
            PictureBox9.Image = My.Resources._52
        End If
        If ilk_el = False Then
            If y2 = 0 Then
                PictureBox10.Image = My.Resources.zempty
            ElseIf y2 = 1 Then
                PictureBox10.Image = My.Resources._01
            ElseIf y2 = 2 Then
                PictureBox10.Image = My.Resources._02
            ElseIf y2 = 3 Then
                PictureBox10.Image = My.Resources._03
            ElseIf y2 = 4 Then
                PictureBox10.Image = My.Resources._04
            ElseIf y2 = 5 Then
                PictureBox10.Image = My.Resources._05
            ElseIf y2 = 6 Then
                PictureBox10.Image = My.Resources._06
            ElseIf y2 = 7 Then
                PictureBox10.Image = My.Resources._07
            ElseIf y2 = 8 Then
                PictureBox10.Image = My.Resources._08
            ElseIf y2 = 9 Then
                PictureBox10.Image = My.Resources._09
            ElseIf y2 = 10 Then
                PictureBox10.Image = My.Resources._10
            ElseIf y2 = 11 Then
                PictureBox10.Image = My.Resources._11
            ElseIf y2 = 12 Then
                PictureBox10.Image = My.Resources._12
            ElseIf y2 = 13 Then
                PictureBox10.Image = My.Resources._13
            ElseIf y2 = 14 Then
                PictureBox10.Image = My.Resources._14
            ElseIf y2 = 15 Then
                PictureBox10.Image = My.Resources._15
            ElseIf y2 = 16 Then
                PictureBox10.Image = My.Resources._16
            ElseIf y2 = 17 Then
                PictureBox10.Image = My.Resources._17
            ElseIf y2 = 18 Then
                PictureBox10.Image = My.Resources._18
            ElseIf y2 = 19 Then
                PictureBox10.Image = My.Resources._19
            ElseIf y2 = 20 Then
                PictureBox10.Image = My.Resources._20
            ElseIf y2 = 21 Then
                PictureBox10.Image = My.Resources._21
            ElseIf y2 = 22 Then
                PictureBox10.Image = My.Resources._22
            ElseIf y2 = 23 Then
                PictureBox10.Image = My.Resources._23
            ElseIf y2 = 24 Then
                PictureBox10.Image = My.Resources._24
            ElseIf y2 = 25 Then
                PictureBox10.Image = My.Resources._25
            ElseIf y2 = 26 Then
                PictureBox10.Image = My.Resources._26
            ElseIf y2 = 27 Then
                PictureBox10.Image = My.Resources._27
            ElseIf y2 = 28 Then
                PictureBox10.Image = My.Resources._28
            ElseIf y2 = 29 Then
                PictureBox10.Image = My.Resources._29
            ElseIf y2 = 30 Then
                PictureBox10.Image = My.Resources._30
            ElseIf y2 = 31 Then
                PictureBox10.Image = My.Resources._31
            ElseIf y2 = 32 Then
                PictureBox10.Image = My.Resources._32
            ElseIf y2 = 33 Then
                PictureBox10.Image = My.Resources._33
            ElseIf y2 = 34 Then
                PictureBox10.Image = My.Resources._34
            ElseIf y2 = 35 Then
                PictureBox10.Image = My.Resources._35
            ElseIf y2 = 36 Then
                PictureBox10.Image = My.Resources._36
            ElseIf y2 = 37 Then
                PictureBox10.Image = My.Resources._37
            ElseIf y2 = 38 Then
                PictureBox10.Image = My.Resources._38
            ElseIf y2 = 39 Then
                PictureBox10.Image = My.Resources._39
            ElseIf y2 = 40 Then
                PictureBox10.Image = My.Resources._40
            ElseIf y2 = 41 Then
                PictureBox10.Image = My.Resources._41
            ElseIf y2 = 42 Then
                PictureBox10.Image = My.Resources._42
            ElseIf y2 = 43 Then
                PictureBox10.Image = My.Resources._43
            ElseIf y2 = 44 Then
                PictureBox10.Image = My.Resources._44
            ElseIf y2 = 45 Then
                PictureBox10.Image = My.Resources._45
            ElseIf y2 = 46 Then
                PictureBox10.Image = My.Resources._46
            ElseIf y2 = 47 Then
                PictureBox10.Image = My.Resources._47
            ElseIf y2 = 48 Then
                PictureBox10.Image = My.Resources._48
            ElseIf y2 = 49 Then
                PictureBox10.Image = My.Resources._49
            ElseIf y2 = 50 Then
                PictureBox10.Image = My.Resources._50
            ElseIf y2 = 51 Then
                PictureBox10.Image = My.Resources._51
            ElseIf y2 = 52 Then
                PictureBox10.Image = My.Resources._52
            End If

            If y3 = 0 Then
                PictureBox11.Image = My.Resources.zempty
            ElseIf y3 = 1 Then
                PictureBox11.Image = My.Resources._01
            ElseIf y3 = 2 Then
                PictureBox11.Image = My.Resources._02
            ElseIf y3 = 3 Then
                PictureBox11.Image = My.Resources._03
            ElseIf y3 = 4 Then
                PictureBox11.Image = My.Resources._04
            ElseIf y3 = 5 Then
                PictureBox11.Image = My.Resources._05
            ElseIf y3 = 6 Then
                PictureBox11.Image = My.Resources._06
            ElseIf y3 = 7 Then
                PictureBox11.Image = My.Resources._07
            ElseIf y3 = 8 Then
                PictureBox11.Image = My.Resources._08
            ElseIf y3 = 9 Then
                PictureBox11.Image = My.Resources._09
            ElseIf y3 = 10 Then
                PictureBox11.Image = My.Resources._10
            ElseIf y3 = 11 Then
                PictureBox11.Image = My.Resources._11
            ElseIf y3 = 12 Then
                PictureBox11.Image = My.Resources._12
            ElseIf y3 = 13 Then
                PictureBox11.Image = My.Resources._13
            ElseIf y3 = 14 Then
                PictureBox11.Image = My.Resources._14
            ElseIf y3 = 15 Then
                PictureBox11.Image = My.Resources._15
            ElseIf y3 = 16 Then
                PictureBox11.Image = My.Resources._16
            ElseIf y3 = 17 Then
                PictureBox11.Image = My.Resources._17
            ElseIf y3 = 18 Then
                PictureBox11.Image = My.Resources._18
            ElseIf y3 = 19 Then
                PictureBox11.Image = My.Resources._19
            ElseIf y3 = 20 Then
                PictureBox11.Image = My.Resources._20
            ElseIf y3 = 21 Then
                PictureBox11.Image = My.Resources._21
            ElseIf y3 = 22 Then
                PictureBox11.Image = My.Resources._22
            ElseIf y3 = 23 Then
                PictureBox11.Image = My.Resources._23
            ElseIf y3 = 24 Then
                PictureBox11.Image = My.Resources._24
            ElseIf y3 = 25 Then
                PictureBox11.Image = My.Resources._25
            ElseIf y3 = 26 Then
                PictureBox11.Image = My.Resources._26
            ElseIf y3 = 27 Then
                PictureBox11.Image = My.Resources._27
            ElseIf y3 = 28 Then
                PictureBox11.Image = My.Resources._28
            ElseIf y3 = 29 Then
                PictureBox11.Image = My.Resources._29
            ElseIf y3 = 30 Then
                PictureBox11.Image = My.Resources._30
            ElseIf y3 = 31 Then
                PictureBox11.Image = My.Resources._31
            ElseIf y3 = 32 Then
                PictureBox11.Image = My.Resources._32
            ElseIf y3 = 33 Then
                PictureBox11.Image = My.Resources._33
            ElseIf y3 = 34 Then
                PictureBox11.Image = My.Resources._34
            ElseIf y3 = 35 Then
                PictureBox11.Image = My.Resources._35
            ElseIf y3 = 36 Then
                PictureBox11.Image = My.Resources._36
            ElseIf y3 = 37 Then
                PictureBox11.Image = My.Resources._37
            ElseIf y3 = 38 Then
                PictureBox11.Image = My.Resources._38
            ElseIf y3 = 39 Then
                PictureBox11.Image = My.Resources._39
            ElseIf y3 = 40 Then
                PictureBox11.Image = My.Resources._40
            ElseIf y3 = 41 Then
                PictureBox11.Image = My.Resources._41
            ElseIf y3 = 42 Then
                PictureBox11.Image = My.Resources._42
            ElseIf y3 = 43 Then
                PictureBox11.Image = My.Resources._43
            ElseIf y3 = 44 Then
                PictureBox11.Image = My.Resources._44
            ElseIf y3 = 45 Then
                PictureBox11.Image = My.Resources._45
            ElseIf y3 = 46 Then
                PictureBox11.Image = My.Resources._46
            ElseIf y3 = 47 Then
                PictureBox11.Image = My.Resources._47
            ElseIf y3 = 48 Then
                PictureBox11.Image = My.Resources._48
            ElseIf y3 = 49 Then
                PictureBox11.Image = My.Resources._49
            ElseIf y3 = 50 Then
                PictureBox11.Image = My.Resources._50
            ElseIf y3 = 51 Then
                PictureBox11.Image = My.Resources._51
            ElseIf y3 = 52 Then
                PictureBox11.Image = My.Resources._52
            End If

            If y4 = 0 Then
                PictureBox12.Image = My.Resources.zempty
            ElseIf y4 = 1 Then
                PictureBox12.Image = My.Resources._01
            ElseIf y4 = 2 Then
                PictureBox12.Image = My.Resources._02
            ElseIf y4 = 3 Then
                PictureBox12.Image = My.Resources._03
            ElseIf y4 = 4 Then
                PictureBox12.Image = My.Resources._04
            ElseIf y4 = 5 Then
                PictureBox12.Image = My.Resources._05
            ElseIf y4 = 6 Then
                PictureBox12.Image = My.Resources._06
            ElseIf y4 = 7 Then
                PictureBox12.Image = My.Resources._07
            ElseIf y4 = 8 Then
                PictureBox12.Image = My.Resources._08
            ElseIf y4 = 9 Then
                PictureBox12.Image = My.Resources._09
            ElseIf y4 = 10 Then
                PictureBox12.Image = My.Resources._10
            ElseIf y4 = 11 Then
                PictureBox12.Image = My.Resources._11
            ElseIf y4 = 12 Then
                PictureBox12.Image = My.Resources._12
            ElseIf y4 = 13 Then
                PictureBox12.Image = My.Resources._13
            ElseIf y4 = 14 Then
                PictureBox12.Image = My.Resources._14
            ElseIf y4 = 15 Then
                PictureBox12.Image = My.Resources._15
            ElseIf y4 = 16 Then
                PictureBox12.Image = My.Resources._16
            ElseIf y4 = 17 Then
                PictureBox12.Image = My.Resources._17
            ElseIf y4 = 18 Then
                PictureBox12.Image = My.Resources._18
            ElseIf y4 = 19 Then
                PictureBox12.Image = My.Resources._19
            ElseIf y4 = 20 Then
                PictureBox12.Image = My.Resources._20
            ElseIf y4 = 21 Then
                PictureBox12.Image = My.Resources._21
            ElseIf y4 = 22 Then
                PictureBox12.Image = My.Resources._22
            ElseIf y4 = 23 Then
                PictureBox12.Image = My.Resources._23
            ElseIf y4 = 24 Then
                PictureBox12.Image = My.Resources._24
            ElseIf y4 = 25 Then
                PictureBox12.Image = My.Resources._25
            ElseIf y4 = 26 Then
                PictureBox12.Image = My.Resources._26
            ElseIf y4 = 27 Then
                PictureBox12.Image = My.Resources._27
            ElseIf y4 = 28 Then
                PictureBox12.Image = My.Resources._28
            ElseIf y4 = 29 Then
                PictureBox12.Image = My.Resources._29
            ElseIf y4 = 30 Then
                PictureBox12.Image = My.Resources._30
            ElseIf y4 = 31 Then
                PictureBox12.Image = My.Resources._31
            ElseIf y4 = 32 Then
                PictureBox12.Image = My.Resources._32
            ElseIf y4 = 33 Then
                PictureBox12.Image = My.Resources._33
            ElseIf y4 = 34 Then
                PictureBox12.Image = My.Resources._34
            ElseIf y4 = 35 Then
                PictureBox12.Image = My.Resources._35
            ElseIf y4 = 36 Then
                PictureBox12.Image = My.Resources._36
            ElseIf y4 = 37 Then
                PictureBox12.Image = My.Resources._37
            ElseIf y4 = 38 Then
                PictureBox12.Image = My.Resources._38
            ElseIf y4 = 39 Then
                PictureBox12.Image = My.Resources._39
            ElseIf y4 = 40 Then
                PictureBox12.Image = My.Resources._40
            ElseIf y4 = 41 Then
                PictureBox12.Image = My.Resources._41
            ElseIf y4 = 42 Then
                PictureBox12.Image = My.Resources._42
            ElseIf y4 = 43 Then
                PictureBox12.Image = My.Resources._43
            ElseIf y4 = 44 Then
                PictureBox12.Image = My.Resources._44
            ElseIf y4 = 45 Then
                PictureBox12.Image = My.Resources._45
            ElseIf y4 = 46 Then
                PictureBox12.Image = My.Resources._46
            ElseIf y4 = 47 Then
                PictureBox12.Image = My.Resources._47
            ElseIf y4 = 48 Then
                PictureBox12.Image = My.Resources._48
            ElseIf y4 = 49 Then
                PictureBox12.Image = My.Resources._49
            ElseIf y4 = 50 Then
                PictureBox12.Image = My.Resources._50
            ElseIf y4 = 51 Then
                PictureBox12.Image = My.Resources._51
            ElseIf y4 = 52 Then
                PictureBox12.Image = My.Resources._52
            End If
        End If
        If e1 = 0 Then
            PictureBox1.Image = My.Resources.zempty
        ElseIf e1 = 1 Then
            PictureBox1.Image = My.Resources._01
        ElseIf e1 = 2 Then
            PictureBox1.Image = My.Resources._02
        ElseIf e1 = 3 Then
            PictureBox1.Image = My.Resources._03
        ElseIf e1 = 4 Then
            PictureBox1.Image = My.Resources._04
        ElseIf e1 = 5 Then
            PictureBox1.Image = My.Resources._05
        ElseIf e1 = 6 Then
            PictureBox1.Image = My.Resources._06
        ElseIf e1 = 7 Then
            PictureBox1.Image = My.Resources._07
        ElseIf e1 = 8 Then
            PictureBox1.Image = My.Resources._08
        ElseIf e1 = 9 Then
            PictureBox1.Image = My.Resources._09
        ElseIf e1 = 10 Then
            PictureBox1.Image = My.Resources._10
        ElseIf e1 = 11 Then
            PictureBox1.Image = My.Resources._11
        ElseIf e1 = 12 Then
            PictureBox1.Image = My.Resources._12
        ElseIf e1 = 13 Then
            PictureBox1.Image = My.Resources._13
        ElseIf e1 = 14 Then
            PictureBox1.Image = My.Resources._14
        ElseIf e1 = 15 Then
            PictureBox1.Image = My.Resources._15
        ElseIf e1 = 16 Then
            PictureBox1.Image = My.Resources._16
        ElseIf e1 = 17 Then
            PictureBox1.Image = My.Resources._17
        ElseIf e1 = 18 Then
            PictureBox1.Image = My.Resources._18
        ElseIf e1 = 19 Then
            PictureBox1.Image = My.Resources._19
        ElseIf e1 = 20 Then
            PictureBox1.Image = My.Resources._20
        ElseIf e1 = 21 Then
            PictureBox1.Image = My.Resources._21
        ElseIf e1 = 22 Then
            PictureBox1.Image = My.Resources._22
        ElseIf e1 = 23 Then
            PictureBox1.Image = My.Resources._23
        ElseIf e1 = 24 Then
            PictureBox1.Image = My.Resources._24
        ElseIf e1 = 25 Then
            PictureBox1.Image = My.Resources._25
        ElseIf e1 = 26 Then
            PictureBox1.Image = My.Resources._26
        ElseIf e1 = 27 Then
            PictureBox1.Image = My.Resources._27
        ElseIf e1 = 28 Then
            PictureBox1.Image = My.Resources._28
        ElseIf e1 = 29 Then
            PictureBox1.Image = My.Resources._29
        ElseIf e1 = 30 Then
            PictureBox1.Image = My.Resources._30
        ElseIf e1 = 31 Then
            PictureBox1.Image = My.Resources._31
        ElseIf e1 = 32 Then
            PictureBox1.Image = My.Resources._32
        ElseIf e1 = 33 Then
            PictureBox1.Image = My.Resources._33
        ElseIf e1 = 34 Then
            PictureBox1.Image = My.Resources._34
        ElseIf e1 = 35 Then
            PictureBox1.Image = My.Resources._35
        ElseIf e1 = 36 Then
            PictureBox1.Image = My.Resources._36
        ElseIf e1 = 37 Then
            PictureBox1.Image = My.Resources._37
        ElseIf e1 = 38 Then
            PictureBox1.Image = My.Resources._38
        ElseIf e1 = 39 Then
            PictureBox1.Image = My.Resources._39
        ElseIf e1 = 40 Then
            PictureBox1.Image = My.Resources._40
        ElseIf e1 = 41 Then
            PictureBox1.Image = My.Resources._41
        ElseIf e1 = 42 Then
            PictureBox1.Image = My.Resources._42
        ElseIf e1 = 43 Then
            PictureBox1.Image = My.Resources._43
        ElseIf e1 = 44 Then
            PictureBox1.Image = My.Resources._44
        ElseIf e1 = 45 Then
            PictureBox1.Image = My.Resources._45
        ElseIf e1 = 46 Then
            PictureBox1.Image = My.Resources._46
        ElseIf e1 = 47 Then
            PictureBox1.Image = My.Resources._47
        ElseIf e1 = 48 Then
            PictureBox1.Image = My.Resources._48
        ElseIf e1 = 49 Then
            PictureBox1.Image = My.Resources._49
        ElseIf e1 = 50 Then
            PictureBox1.Image = My.Resources._50
        ElseIf e1 = 51 Then
            PictureBox1.Image = My.Resources._51
        ElseIf e1 = 52 Then
            PictureBox1.Image = My.Resources._52
        End If

        If e2 = 0 Then
            PictureBox2.Image = My.Resources.zempty
        ElseIf e2 = 1 Then
            PictureBox2.Image = My.Resources._01
        ElseIf e2 = 2 Then
            PictureBox2.Image = My.Resources._02
        ElseIf e2 = 3 Then
            PictureBox2.Image = My.Resources._03
        ElseIf e2 = 4 Then
            PictureBox2.Image = My.Resources._04
        ElseIf e2 = 5 Then
            PictureBox2.Image = My.Resources._05
        ElseIf e2 = 6 Then
            PictureBox2.Image = My.Resources._06
        ElseIf e2 = 7 Then
            PictureBox2.Image = My.Resources._07
        ElseIf e2 = 8 Then
            PictureBox2.Image = My.Resources._08
        ElseIf e2 = 9 Then
            PictureBox2.Image = My.Resources._09
        ElseIf e2 = 10 Then
            PictureBox2.Image = My.Resources._10
        ElseIf e2 = 11 Then
            PictureBox2.Image = My.Resources._11
        ElseIf e2 = 12 Then
            PictureBox2.Image = My.Resources._12
        ElseIf e2 = 13 Then
            PictureBox2.Image = My.Resources._13
        ElseIf e2 = 14 Then
            PictureBox2.Image = My.Resources._14
        ElseIf e2 = 15 Then
            PictureBox2.Image = My.Resources._15
        ElseIf e2 = 16 Then
            PictureBox2.Image = My.Resources._16
        ElseIf e2 = 17 Then
            PictureBox2.Image = My.Resources._17
        ElseIf e2 = 18 Then
            PictureBox2.Image = My.Resources._18
        ElseIf e2 = 19 Then
            PictureBox2.Image = My.Resources._19
        ElseIf e2 = 20 Then
            PictureBox2.Image = My.Resources._20
        ElseIf e2 = 21 Then
            PictureBox2.Image = My.Resources._21
        ElseIf e2 = 22 Then
            PictureBox2.Image = My.Resources._22
        ElseIf e2 = 23 Then
            PictureBox2.Image = My.Resources._23
        ElseIf e2 = 24 Then
            PictureBox2.Image = My.Resources._24
        ElseIf e2 = 25 Then
            PictureBox2.Image = My.Resources._25
        ElseIf e2 = 26 Then
            PictureBox2.Image = My.Resources._26
        ElseIf e2 = 27 Then
            PictureBox2.Image = My.Resources._27
        ElseIf e2 = 28 Then
            PictureBox2.Image = My.Resources._28
        ElseIf e2 = 29 Then
            PictureBox2.Image = My.Resources._29
        ElseIf e2 = 30 Then
            PictureBox2.Image = My.Resources._30
        ElseIf e2 = 31 Then
            PictureBox2.Image = My.Resources._31
        ElseIf e2 = 32 Then
            PictureBox2.Image = My.Resources._32
        ElseIf e2 = 33 Then
            PictureBox2.Image = My.Resources._33
        ElseIf e2 = 34 Then
            PictureBox2.Image = My.Resources._34
        ElseIf e2 = 35 Then
            PictureBox2.Image = My.Resources._35
        ElseIf e2 = 36 Then
            PictureBox2.Image = My.Resources._36
        ElseIf e2 = 37 Then
            PictureBox2.Image = My.Resources._37
        ElseIf e2 = 38 Then
            PictureBox2.Image = My.Resources._38
        ElseIf e2 = 39 Then
            PictureBox2.Image = My.Resources._39
        ElseIf e2 = 40 Then
            PictureBox2.Image = My.Resources._40
        ElseIf e2 = 41 Then
            PictureBox2.Image = My.Resources._41
        ElseIf e2 = 42 Then
            PictureBox2.Image = My.Resources._42
        ElseIf e2 = 43 Then
            PictureBox2.Image = My.Resources._43
        ElseIf e2 = 44 Then
            PictureBox2.Image = My.Resources._44
        ElseIf e2 = 45 Then
            PictureBox2.Image = My.Resources._45
        ElseIf e2 = 46 Then
            PictureBox2.Image = My.Resources._46
        ElseIf e2 = 47 Then
            PictureBox2.Image = My.Resources._47
        ElseIf e2 = 48 Then
            PictureBox2.Image = My.Resources._48
        ElseIf e2 = 49 Then
            PictureBox2.Image = My.Resources._49
        ElseIf e2 = 50 Then
            PictureBox2.Image = My.Resources._50
        ElseIf e2 = 51 Then
            PictureBox2.Image = My.Resources._51
        ElseIf e2 = 52 Then
            PictureBox2.Image = My.Resources._52
        End If

        If e3 = 0 Then
            PictureBox3.Image = My.Resources.zempty
        ElseIf e3 = 1 Then
            PictureBox3.Image = My.Resources._01
        ElseIf e3 = 2 Then
            PictureBox3.Image = My.Resources._02
        ElseIf e3 = 3 Then
            PictureBox3.Image = My.Resources._03
        ElseIf e3 = 4 Then
            PictureBox3.Image = My.Resources._04
        ElseIf e3 = 5 Then
            PictureBox3.Image = My.Resources._05
        ElseIf e3 = 6 Then
            PictureBox3.Image = My.Resources._06
        ElseIf e3 = 7 Then
            PictureBox3.Image = My.Resources._07
        ElseIf e3 = 8 Then
            PictureBox3.Image = My.Resources._08
        ElseIf e3 = 9 Then
            PictureBox3.Image = My.Resources._09
        ElseIf e3 = 10 Then
            PictureBox3.Image = My.Resources._10
        ElseIf e3 = 11 Then
            PictureBox3.Image = My.Resources._11
        ElseIf e3 = 12 Then
            PictureBox3.Image = My.Resources._12
        ElseIf e3 = 13 Then
            PictureBox3.Image = My.Resources._13
        ElseIf e3 = 14 Then
            PictureBox3.Image = My.Resources._14
        ElseIf e3 = 15 Then
            PictureBox3.Image = My.Resources._15
        ElseIf e3 = 16 Then
            PictureBox3.Image = My.Resources._16
        ElseIf e3 = 17 Then
            PictureBox3.Image = My.Resources._17
        ElseIf e3 = 18 Then
            PictureBox3.Image = My.Resources._18
        ElseIf e3 = 19 Then
            PictureBox3.Image = My.Resources._19
        ElseIf e3 = 20 Then
            PictureBox3.Image = My.Resources._20
        ElseIf e3 = 21 Then
            PictureBox3.Image = My.Resources._21
        ElseIf e3 = 22 Then
            PictureBox3.Image = My.Resources._22
        ElseIf e3 = 23 Then
            PictureBox3.Image = My.Resources._23
        ElseIf e3 = 24 Then
            PictureBox3.Image = My.Resources._24
        ElseIf e3 = 25 Then
            PictureBox3.Image = My.Resources._25
        ElseIf e3 = 26 Then
            PictureBox3.Image = My.Resources._26
        ElseIf e3 = 27 Then
            PictureBox3.Image = My.Resources._27
        ElseIf e3 = 28 Then
            PictureBox3.Image = My.Resources._28
        ElseIf e3 = 29 Then
            PictureBox3.Image = My.Resources._29
        ElseIf e3 = 30 Then
            PictureBox3.Image = My.Resources._30
        ElseIf e3 = 31 Then
            PictureBox3.Image = My.Resources._31
        ElseIf e3 = 32 Then
            PictureBox3.Image = My.Resources._32
        ElseIf e3 = 33 Then
            PictureBox3.Image = My.Resources._33
        ElseIf e3 = 34 Then
            PictureBox3.Image = My.Resources._34
        ElseIf e3 = 35 Then
            PictureBox3.Image = My.Resources._35
        ElseIf e3 = 36 Then
            PictureBox3.Image = My.Resources._36
        ElseIf e3 = 37 Then
            PictureBox3.Image = My.Resources._37
        ElseIf e3 = 38 Then
            PictureBox3.Image = My.Resources._38
        ElseIf e3 = 39 Then
            PictureBox3.Image = My.Resources._39
        ElseIf e3 = 40 Then
            PictureBox3.Image = My.Resources._40
        ElseIf e3 = 41 Then
            PictureBox3.Image = My.Resources._41
        ElseIf e3 = 42 Then
            PictureBox3.Image = My.Resources._42
        ElseIf e3 = 43 Then
            PictureBox3.Image = My.Resources._43
        ElseIf e3 = 44 Then
            PictureBox3.Image = My.Resources._44
        ElseIf e3 = 45 Then
            PictureBox3.Image = My.Resources._45
        ElseIf e3 = 46 Then
            PictureBox3.Image = My.Resources._46
        ElseIf e3 = 47 Then
            PictureBox3.Image = My.Resources._47
        ElseIf e3 = 48 Then
            PictureBox3.Image = My.Resources._48
        ElseIf e3 = 49 Then
            PictureBox3.Image = My.Resources._49
        ElseIf e3 = 50 Then
            PictureBox3.Image = My.Resources._50
        ElseIf e3 = 51 Then
            PictureBox3.Image = My.Resources._51
        ElseIf e3 = 52 Then
            PictureBox3.Image = My.Resources._52
        End If

        If e4 = 0 Then
            PictureBox4.Image = My.Resources.zempty
        ElseIf e4 = 1 Then
            PictureBox4.Image = My.Resources._01
        ElseIf e4 = 2 Then
            PictureBox4.Image = My.Resources._02
        ElseIf e4 = 3 Then
            PictureBox4.Image = My.Resources._03
        ElseIf e4 = 4 Then
            PictureBox4.Image = My.Resources._04
        ElseIf e4 = 5 Then
            PictureBox4.Image = My.Resources._05
        ElseIf e4 = 6 Then
            PictureBox4.Image = My.Resources._06
        ElseIf e4 = 7 Then
            PictureBox4.Image = My.Resources._07
        ElseIf e4 = 8 Then
            PictureBox4.Image = My.Resources._08
        ElseIf e4 = 9 Then
            PictureBox4.Image = My.Resources._09
        ElseIf e4 = 10 Then
            PictureBox4.Image = My.Resources._10
        ElseIf e4 = 11 Then
            PictureBox4.Image = My.Resources._11
        ElseIf e4 = 12 Then
            PictureBox4.Image = My.Resources._12
        ElseIf e4 = 13 Then
            PictureBox4.Image = My.Resources._13
        ElseIf e4 = 14 Then
            PictureBox4.Image = My.Resources._14
        ElseIf e4 = 15 Then
            PictureBox4.Image = My.Resources._15
        ElseIf e4 = 16 Then
            PictureBox4.Image = My.Resources._16
        ElseIf e4 = 17 Then
            PictureBox4.Image = My.Resources._17
        ElseIf e4 = 18 Then
            PictureBox4.Image = My.Resources._18
        ElseIf e4 = 19 Then
            PictureBox4.Image = My.Resources._19
        ElseIf e4 = 20 Then
            PictureBox4.Image = My.Resources._20
        ElseIf e4 = 21 Then
            PictureBox4.Image = My.Resources._21
        ElseIf e4 = 22 Then
            PictureBox4.Image = My.Resources._22
        ElseIf e4 = 23 Then
            PictureBox4.Image = My.Resources._23
        ElseIf e4 = 24 Then
            PictureBox4.Image = My.Resources._24
        ElseIf e4 = 25 Then
            PictureBox4.Image = My.Resources._25
        ElseIf e4 = 26 Then
            PictureBox4.Image = My.Resources._26
        ElseIf e4 = 27 Then
            PictureBox4.Image = My.Resources._27
        ElseIf e4 = 28 Then
            PictureBox4.Image = My.Resources._28
        ElseIf e4 = 29 Then
            PictureBox4.Image = My.Resources._29
        ElseIf e4 = 30 Then
            PictureBox4.Image = My.Resources._30
        ElseIf e4 = 31 Then
            PictureBox4.Image = My.Resources._31
        ElseIf e4 = 32 Then
            PictureBox4.Image = My.Resources._32
        ElseIf e4 = 33 Then
            PictureBox4.Image = My.Resources._33
        ElseIf e4 = 34 Then
            PictureBox4.Image = My.Resources._34
        ElseIf e4 = 35 Then
            PictureBox4.Image = My.Resources._35
        ElseIf e4 = 36 Then
            PictureBox4.Image = My.Resources._36
        ElseIf e4 = 37 Then
            PictureBox4.Image = My.Resources._37
        ElseIf e4 = 38 Then
            PictureBox4.Image = My.Resources._38
        ElseIf e4 = 39 Then
            PictureBox4.Image = My.Resources._39
        ElseIf e4 = 40 Then
            PictureBox4.Image = My.Resources._40
        ElseIf e4 = 41 Then
            PictureBox4.Image = My.Resources._41
        ElseIf e4 = 42 Then
            PictureBox4.Image = My.Resources._42
        ElseIf e4 = 43 Then
            PictureBox4.Image = My.Resources._43
        ElseIf e4 = 44 Then
            PictureBox4.Image = My.Resources._44
        ElseIf e4 = 45 Then
            PictureBox4.Image = My.Resources._45
        ElseIf e4 = 46 Then
            PictureBox4.Image = My.Resources._46
        ElseIf e4 = 47 Then
            PictureBox4.Image = My.Resources._47
        ElseIf e4 = 48 Then
            PictureBox4.Image = My.Resources._48
        ElseIf e4 = 49 Then
            PictureBox4.Image = My.Resources._49
        ElseIf e4 = 50 Then
            PictureBox4.Image = My.Resources._50
        ElseIf e4 = 51 Then
            PictureBox4.Image = My.Resources._51
        ElseIf e4 = 52 Then
            PictureBox4.Image = My.Resources._52
        End If

        If r1 = 0 Then
            PictureBox5.Visible = False
        Else
            PictureBox5.Visible = True
        End If
        If r2 = 0 Then
            PictureBox6.Visible = False
        Else
            PictureBox6.Visible = True
        End If
        If r3 = 0 Then
            PictureBox7.Visible = False
        Else
            PictureBox7.Visible = True
        End If
        If r4 = 0 Then
            PictureBox8.Visible = False
        Else
            PictureBox8.Visible = True
        End If

        puan_kontrol()
    End Sub
    Private Sub puan_kontrol()
        For i = 1 To 52
            If alinanlar(i) = 1 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button32.Visible = True
            End If
            If alinanlar(i) = 14 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button29.Visible = True
            End If
            If alinanlar(i) = 27 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button30.Visible = True
            End If
            If alinanlar(i) = 40 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button31.Visible = True
            End If
            If alinanlar(i) = 11 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button28.Visible = True
            End If
            If alinanlar(i) = 24 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button25.Visible = True
            End If
            If alinanlar(i) = 37 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button26.Visible = True
            End If
            If alinanlar(i) = 50 Then
                puan = puan + 1
                alinanlar.SetValue(60, i)
                Button27.Visible = True
            End If
            If alinanlar(i) = 2 Then
                puan = puan + 2
                alinanlar.SetValue(60, i)
                Button34.Visible = True
            End If
            If alinanlar(i) = 23 Then
                puan = puan + 3
                alinanlar.SetValue(60, i)
                Button33.Visible = True
            End If

            If verilenler(i) = 1 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button7.Visible = True
            End If
            If verilenler(i) = 14 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button10.Visible = True
            End If
            If verilenler(i) = 27 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button9.Visible = True
            End If
            If verilenler(i) = 40 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button8.Visible = True
            End If
            If verilenler(i) = 11 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button14.Visible = True
            End If
            If verilenler(i) = 24 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button11.Visible = True
            End If
            If verilenler(i) = 37 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button12.Visible = True
            End If
            If verilenler(i) = 50 Then
                rakip_puan = rakip_puan + 1
                verilenler.SetValue(60, i)
                Button13.Visible = True
            End If
            If verilenler(i) = 2 Then
                rakip_puan = rakip_puan + 2
                verilenler.SetValue(60, i)
                Button5.Visible = True
            End If
            If verilenler(i) = 23 Then
                rakip_puan = rakip_puan + 3
                verilenler.SetValue(60, i)
                Button6.Visible = True
            End If

            If alinan_sira > verilen_sira Then
                Button47.Visible = True
                Button48.Visible = False
            ElseIf verilen_sira > alinan_sira Then
                Button47.Visible = False
                Button48.Visible = True
            Else
                If puan > rakip_puan Then
                    Button47.Visible = True
                    Button48.Visible = False
                ElseIf rakip_puan > puan Then
                    Button47.Visible = False
                    Button48.Visible = True
                Else
                    Button47.Visible = False
                    Button48.Visible = False
                End If
            End If
        Next
    End Sub
    Private Sub pisti_kontrol(ByVal eslesen As Integer)
        son_alindi = True
        If PictureBox15.Visible = False Then
            PictureBox15.Visible = True
            Button25.BringToFront()
            Button26.BringToFront()
            Button27.BringToFront()
            Button28.BringToFront()
            Button29.BringToFront()
            Button30.BringToFront()
            Button31.BringToFront()
            Button32.BringToFront()
            Button33.BringToFront()
            Button34.BringToFront()
            Button39.BringToFront()
            Button40.BringToFront()
        End If
        If y2 = 0 Then
            If y1 Mod 13 = eslesen Mod 13 Then
                If y1 Mod 13 = 11 Then
                    puan = puan + 20
                    If Button35.Visible = True Then
                        Button36.Visible = True
                    End If
                    Button35.Visible = True
                Else
                    puan = puan + 10
                    If Button44.Visible = True Then
                        Button43.Visible = True
                    End If
                    If Button40.Visible = True Then
                        Button44.Visible = True
                    End If
                    If Button39.Visible = True Then
                        Button40.Visible = True
                    End If
                    If Button20.Visible = True Then
                        Button39.Visible = True
                    End If
                    If Button21.Visible = True Then
                        Button20.Visible = True
                    End If
                    If Button22.Visible = True Then
                        Button21.Visible = True
                    End If
                    If Button23.Visible = True Then
                        Button22.Visible = True
                    End If
                    If Button24.Visible = True Then
                        Button23.Visible = True
                    End If
                    Button24.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub rakip_pisti_kontrol(ByVal eslesen As Integer)
        son_alindi = False
        If PictureBox14.Visible = False Then
            PictureBox14.Visible = True
            Button5.BringToFront()
            Button6.BringToFront()
            Button7.BringToFront()
            Button8.BringToFront()
            Button9.BringToFront()
            Button10.BringToFront()
            Button11.BringToFront()
            Button12.BringToFront()
            Button13.BringToFront()
            Button14.BringToFront()
            Button41.BringToFront()
            Button42.BringToFront()
        End If
        If y2 = 0 Then
            If y1 Mod 13 = eslesen Mod 13 Then
                If y1 Mod 13 = 11 Then
                    rakip_puan = rakip_puan + 20
                    If Button35.Visible = True Then
                        Button36.Visible = True
                    End If
                    Button35.Visible = True
                Else
                    rakip_puan = rakip_puan + 10
                    If Button46.Visible = True Then
                        Button45.Visible = True
                    End If
                    If Button41.Visible = True Then
                        Button46.Visible = True
                    End If
                    If Button42.Visible = True Then
                        Button41.Visible = True
                    End If
                    If Button19.Visible = True Then
                        Button42.Visible = True
                    End If
                    If Button18.Visible = True Then
                        Button19.Visible = True
                    End If
                    If Button17.Visible = True Then
                        Button18.Visible = True
                    End If
                    If Button16.Visible = True Then
                        Button17.Visible = True
                    End If
                    If Button15.Visible = True Then
                        Button16.Visible = True
                    End If
                    Button15.Visible = True
                End If
            End If
        End If

    End Sub
    Private Sub kartlari_dagit()

        If ilk_el = True Then
            ilk_el = False
        End If

        kart_cek()
        e1 = cekilen
        kart_cek()
        e2 = cekilen
        kart_cek()
        e3 = cekilen
        kart_cek()
        e4 = cekilen
        kart_cek()
        r1 = cekilen
        kart_cek()
        r2 = cekilen
        kart_cek()
        r3 = cekilen
        kart_cek()
        r4 = cekilen
        gorsel_duzenle()

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub
    Private Sub kartlari_kaydir()
        '09>10  10>11  11>12
        'y1>y2  y2>y3  y3>y4

        y4 = y3
        y3 = y2
        y2 = y1

        If ilk_el = True Then
            PictureBox12.Image = PictureBox11.Image
            PictureBox11.Image = PictureBox10.Image
            PictureBox10.Image = PictureBox9.Image
        End If

    End Sub
    Private Sub el_kontrol()
        If ea1 And ea2 And ea3 And ea4 And ra1 And ra2 And ra3 And ra4 = True Then
            If kalan = 0 Then
                If son_alindi = True Then
                    For i = alinan_sira To alinan_sira + yerdeki_sira - 1
                        alinanlar.SetValue(yerdekiler(i - alinan_sira + 1), i)
                    Next
                    alinan_sira = alinan_sira + yerdeki_sira
                    For i = 1 To 52
                        yerdekiler.SetValue(0, i)
                    Next
                    yerdeki_sira = 1
                    y1 = 0
                    y2 = 0
                    y3 = 0
                    y4 = 0
                    gorsel_duzenle()
                Else
                    For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                        verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
                    Next
                    verilen_sira = verilen_sira + yerdeki_sira
                    For i = 1 To 52
                        yerdekiler.SetValue(0, i)
                    Next
                    yerdeki_sira = 1
                    y1 = 0
                    y2 = 0
                    y3 = 0
                    y4 = 0
                    gorsel_duzenle()
                End If
                If Button47.Visible = True Then
                    puan = puan + 3
                Else
                    rakip_puan = rakip_puan + 3
                End If
                MsgBox("Puanınız: " & puan & "     Rakibinizin puanı: " & rakip_puan)
                Application.Restart()
                Me.Refresh()
            Else
                kartlari_dagit()
                ea1 = False
                ea2 = False
                ea3 = False
                ea4 = False
                ra1 = False
                ra2 = False
                ra3 = False
                ra4 = False
                For i = 1 To 4
                    rakip_el.SetValue(1, i)
                Next
            End If
        End If
    End Sub
    Private Sub rakip_hamle()
        If ea1 And ea2 And ea3 And ea4 And ra1 And ra2 And ra3 And ra4 = True Then
            If kalan = 0 Then
                Exit Sub
            End If
        End If

        If r1 Mod 13 = y1 Mod 13 And r1 <> 0 And y1 <> 0 Then
            ra1 = True
            rakip_el.SetValue(0, 1)
            yerdekiler.SetValue(r1, yerdeki_sira)
            rakip_pisti_kontrol(r1)
            For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
            Next
            verilen_sira = verilen_sira + yerdeki_sira
            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next
            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False
            r1 = 0
            el_kontrol()
            gorsel_duzenle()
            Exit Sub
        End If

        If r2 Mod 13 = y1 Mod 13 And r2 <> 0 And y1 <> 0 Then
            ra2 = True
            rakip_el.SetValue(0, 2)
            yerdekiler.SetValue(r2, yerdeki_sira)
            rakip_pisti_kontrol(r2)
            For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
            Next
            verilen_sira = verilen_sira + yerdeki_sira
            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next
            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False
            r2 = 0
            el_kontrol()
            gorsel_duzenle()
            Exit Sub
        End If

        If r3 Mod 13 = y1 Mod 13 And r3 <> 0 And y1 <> 0 Then
            ra3 = True
            rakip_el.SetValue(0, 3)
            yerdekiler.SetValue(r3, yerdeki_sira)
            rakip_pisti_kontrol(r3)
            For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
            Next
            verilen_sira = verilen_sira + yerdeki_sira
            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next
            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False
            r3 = 0
            el_kontrol()
            gorsel_duzenle()
            Exit Sub
        End If

        If r4 Mod 13 = y1 Mod 13 And r4 <> 0 And y1 <> 0 Then
            ra4 = True
            rakip_el.SetValue(0, 4)
            yerdekiler.SetValue(r4, yerdeki_sira)
            rakip_pisti_kontrol(r4)
            For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
            Next
            verilen_sira = verilen_sira + yerdeki_sira
            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next
            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False
            r4 = 0
            el_kontrol()
            gorsel_duzenle()
            Exit Sub
        End If

        '1 -> rakibin elinde
        '0 -> rakip atmış


        Randomize()
        Dim atis As Integer = CInt(Int((4 * Rnd()) + 1))
        Do While rakip_el(atis) = 0
            atis = CInt(Int((4 * Rnd()) + 1))
        Loop
        If atis = 1 Then
            If r1 Mod 13 = 11 And y1 <> 0 Then
                ra1 = True
                rakip_el.SetValue(0, 1)
                yerdekiler.SetValue(r1, yerdeki_sira)
                rakip_pisti_kontrol(r1)
                For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                    verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
                Next
                verilen_sira = verilen_sira + yerdeki_sira
                For i = 1 To 52
                    yerdekiler.SetValue(0, i)
                Next
                yerdeki_sira = 1
                y1 = 0
                y2 = 0
                y3 = 0
                y4 = 0
                ilk_el = False
                r1 = 0
                el_kontrol()
                gorsel_duzenle()
                Exit Sub
            End If

            ra1 = True
            rakip_el.SetValue(0, 1)
            yerdekiler.SetValue(r1, yerdeki_sira)
            kartlari_kaydir()
            y1 = r1
            yerdeki_sira = yerdeki_sira + 1
            r1 = 0
            el_kontrol()
            gorsel_duzenle()
        ElseIf atis = 2 Then
            If r2 Mod 13 = 11 And y1 <> 0 Then
                ra2 = True
                rakip_el.SetValue(0, 2)
                yerdekiler.SetValue(r2, yerdeki_sira)
                rakip_pisti_kontrol(r2)
                For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                    verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
                Next
                verilen_sira = verilen_sira + yerdeki_sira
                For i = 1 To 52
                    yerdekiler.SetValue(0, i)
                Next
                yerdeki_sira = 1
                y1 = 0
                y2 = 0
                y3 = 0
                y4 = 0
                ilk_el = False
                r2 = 0
                el_kontrol()
                gorsel_duzenle()
                Exit Sub
            End If
            ra2 = True
            rakip_el.SetValue(0, 2)
            yerdekiler.SetValue(r2, yerdeki_sira)
            kartlari_kaydir()
            y1 = r2
            yerdeki_sira = yerdeki_sira + 1
            r2 = 0
            el_kontrol()
            gorsel_duzenle()
        ElseIf atis = 3 Then
            If r3 Mod 13 = 11 And y1 <> 0 Then
                ra3 = True
                rakip_el.SetValue(0, 3)
                yerdekiler.SetValue(r3, yerdeki_sira)
                rakip_pisti_kontrol(r3)
                For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                    verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
                Next
                verilen_sira = verilen_sira + yerdeki_sira
                For i = 1 To 52
                    yerdekiler.SetValue(0, i)
                Next
                yerdeki_sira = 1
                y1 = 0
                y2 = 0
                y3 = 0
                y4 = 0
                ilk_el = False
                r3 = 0
                el_kontrol()
                gorsel_duzenle()
                Exit Sub
            End If
            ra3 = True
            rakip_el.SetValue(0, 3)
            yerdekiler.SetValue(r3, yerdeki_sira)
            kartlari_kaydir()
            y1 = r3
            yerdeki_sira = yerdeki_sira + 1
            r3 = 0
            el_kontrol()
            gorsel_duzenle()
        ElseIf atis = 4 Then
            If r4 Mod 13 = 11 And y1 <> 0 Then
                ra4 = True
                rakip_el.SetValue(0, 4)
                yerdekiler.SetValue(r4, yerdeki_sira)
                rakip_pisti_kontrol(r4)
                For i = verilen_sira To verilen_sira + yerdeki_sira - 1
                    verilenler.SetValue(yerdekiler(i - verilen_sira + 1), i)
                Next
                verilen_sira = verilen_sira + yerdeki_sira
                For i = 1 To 52
                    yerdekiler.SetValue(0, i)
                Next
                yerdeki_sira = 1
                y1 = 0
                y2 = 0
                y3 = 0
                y4 = 0
                ilk_el = False
                r4 = 0
                el_kontrol()
                gorsel_duzenle()
                Exit Sub
            End If
            ra4 = True
            rakip_el.SetValue(0, 4)
            yerdekiler.SetValue(r4, yerdeki_sira)
            kartlari_kaydir()
            y1 = r4
            yerdeki_sira = yerdeki_sira + 1
            r4 = 0
            el_kontrol()
            gorsel_duzenle()


        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(5, 5)

        For i = 1 To 52
            deste.SetValue(1, i)
        Next
        For i = 1 To 4
            rakip_el.SetValue(1, i)
        Next

        alinan_sira = 1
        verilen_sira = 1
        ilk_el = True

        valesiz_kart_cek()
        y1 = cekilen
        kart_cek()
        y2 = cekilen
        kart_cek()
        y3 = cekilen
        kart_cek()
        y4 = cekilen

        yerdekiler.SetValue(y1, 4)
        yerdekiler.SetValue(y2, 3)
        yerdekiler.SetValue(y3, 2)
        yerdekiler.SetValue(y4, 1)
        yerdeki_sira = 5

        'kartlari dagit
        kart_cek()
        e1 = cekilen
        kart_cek()
        e2 = cekilen
        kart_cek()
        e3 = cekilen
        kart_cek()
        e4 = cekilen
        kart_cek()
        r1 = cekilen
        kart_cek()
        r2 = cekilen
        kart_cek()
        r3 = cekilen
        kart_cek()
        r4 = cekilen
        '
        gorsel_duzenle()

        puan = 0
        rakip_puan = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ea1 = True
        yerdekiler.SetValue(e1, yerdeki_sira)

        If (e1 Mod 13 = y1 Mod 13 And y1 <> 0) Or (e1 Mod 13 = 11 And y1 <> 0) Then
            pisti_kontrol(e1)

            For i = alinan_sira To alinan_sira + yerdeki_sira - 1
                alinanlar.SetValue(yerdekiler(i - alinan_sira + 1), i)
            Next
            alinan_sira = alinan_sira + yerdeki_sira

            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next

            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False

        Else
            kartlari_kaydir()
            y1 = e1
            yerdeki_sira = yerdeki_sira + 1
        End If


        e1 = 0
        el_kontrol()
        gorsel_duzenle()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Timer1.Start()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ea2 = True
        yerdekiler.SetValue(e2, yerdeki_sira)

        If (e2 Mod 13 = y1 Mod 13 And y1 <> 0) Or (e2 Mod 13 = 11 And y1 <> 0) Then
            pisti_kontrol(e2)

            For i = alinan_sira To alinan_sira + yerdeki_sira - 1
                alinanlar.SetValue(yerdekiler(i - alinan_sira + 1), i)
            Next
            alinan_sira = alinan_sira + yerdeki_sira

            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next

            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False

        Else
            kartlari_kaydir()
            y1 = e2
            yerdeki_sira = yerdeki_sira + 1
        End If


        e2 = 0
        el_kontrol()
        gorsel_duzenle()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Timer1.Start()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ea3 = True
        yerdekiler.SetValue(e3, yerdeki_sira)

        If (e3 Mod 13 = y1 Mod 13 And y1 <> 0) Or (e3 Mod 13 = 11 And y1 <> 0) Then
            pisti_kontrol(e3)

            For i = alinan_sira To alinan_sira + yerdeki_sira - 1
                alinanlar.SetValue(yerdekiler(i - alinan_sira + 1), i)
            Next
            alinan_sira = alinan_sira + yerdeki_sira

            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next

            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False

        Else
            kartlari_kaydir()
            y1 = e3
            yerdeki_sira = yerdeki_sira + 1
        End If


        e3 = 0
        el_kontrol()
        gorsel_duzenle()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Timer1.Start()

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ea4 = True
        yerdekiler.SetValue(e4, yerdeki_sira)

        If (e4 Mod 13 = y1 Mod 13 And y1 <> 0) Or (e4 Mod 13 = 11 And y1 <> 0) Then

            pisti_kontrol(e4)
            For i = alinan_sira To alinan_sira + yerdeki_sira - 1
                alinanlar.SetValue(yerdekiler(i - alinan_sira + 1), i)
            Next
            alinan_sira = alinan_sira + yerdeki_sira

            For i = 1 To 52
                yerdekiler.SetValue(0, i)
            Next

            yerdeki_sira = 1
            y1 = 0
            y2 = 0
            y3 = 0
            y4 = 0
            ilk_el = False

        Else
            kartlari_kaydir()
            y1 = e4
            yerdeki_sira = yerdeki_sira + 1
        End If

        e4 = 0
        el_kontrol()
        gorsel_duzenle()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ea1 = False Then
            Button1.Enabled = True
        End If
        If ea2 = False Then
            Button2.Enabled = True
        End If
        If ea3 = False Then
            Button3.Enabled = True
        End If
        If ea4 = False Then
            Button4.Enabled = True
        End If

        rakip_hamle()
        Timer1.Stop()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        'bu sub'ı yapım aşamasında değerlerin testi için açtım.
        'formu sağa doğru uzattığınızda bu bilgileri taşıyan
        'visible=false olarak ayarlı listbox ve label ları görebilirsiniz.

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        For i = 0 To 52
            ListBox1.Items.Insert(i, yerdekiler(i))
            ListBox2.Items.Add(alinanlar(i))
            ListBox3.Items.Add(verilenler(i))
        Next

        Label2.Text = r1
        Label7.Text = r2
        Label12.Text = r3
        Label4.Text = r4
        Label5.Text = e1
        Label9.Text = e2
        Label10.Text = e3
        Label13.Text = e4
        Label14.Text = yerdeki_sira
        Label15.Text = alinan_sira
        Label16.Text = verilen_sira


    End Sub

End Class

