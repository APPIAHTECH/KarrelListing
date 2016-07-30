Public Class Karel

    'Parametres

    Private name As String
    Private quest As String

    'Constructor

    Sub New(ByVal name As String)
        Me.name = name
    End Sub

    'Procedure

    Public Function getName() As String
        If Me.name <> Nothing Then
            Return Me.name
        End If

        Return Nothing
    End Function


    Public Function getQuest() As String

        If Me.quest <> Nothing Then
            Return Me.quest
        End If

        Return Nothing
    End Function


    Public Sub execute(quest As String)


        Dim comand As String = Nothing
        Dim action As String = Nothing

        Dim cad As String = Nothing
        Dim space As String = Nothing

        Dim i As Integer
        Dim res As Integer
        Dim len As Integer

        quest = quest.ToLower

        If quest.StartsWith(Me.name) Then

            len = Me.name.Length + 1
            cad = quest.Substring(len)
            cad = cad.Trim

            ''Prefix
            For i = 1 To cad.Length

                space = GetChar(cad, i)

                If space.Equals(" ") Then

                    If space <> " " Then
                        action += GetChar(cad, i)
                    End If

                    action = cad.Substring(0, i)
                    res = i
                    action = action.Trim
                    Exit For
                Else
                End If
            Next

            If action = Nothing Then
                action = cad.Substring(0, res)
            End If

            res = 0

            If action.Length > len Then
                res = action.Length - len
            Else
                res = len - action.Length
            End If

            comand = cad.Substring(res)

            If comand.StartsWith("earch") Then
                comand = comand.Substring(6)
            End If

            Console.WriteLine(action)
            Console.WriteLine(comand)

            Select Case action
                Case "run"
                    runComand(comand)

                Case "search"
                    searchComand(comand)

                Case "get"
                    Console.WriteLine("My name is " & getName())
            End Select



        Else
            Console.WriteLine("Sintaxi Error")
            Console.WriteLine("Pls follow this sintaxi My name Acction Command")
        End If



    End Sub

    Public Function runComand(cmd As String) As Integer

        Console.WriteLine(Me.name & " is running " & cmd)

        Try
            Shell(cmd)
        Catch ex As Exception
            Console.WriteLine("Someting went wrong check the comand " & cmd)
            Return 1
        End Try

        Return 0
    End Function ''COMPLETAR

    Private Function searchComand(url As String) As Integer

        Try
            Process.Start("http://www." & url)
        Catch ex As Exception
            Console.WriteLine("Someting went wrong check the comand " & url)
            Return 1
        End Try

        Return 0
    End Function ''COMPLETAR

    Private Function calculate() As Decimal
        ''proces
        Return Nothing
    End Function


End Class
