Imports System.Environment
Imports System.Console
Module Module1
    Dim menuoption As Integer
    Dim userinput As String
    Dim userinputtwo As String
    Dim userinputthree As String
    Sub Main()
        Dim path As String
        'Works out if first time setup is needed.
        path = GetFolderPath(SpecialFolder.MyDocuments)
        If (Not System.IO.Directory.Exists(path & "\Auto-XML")) Then
            FirstTimeSetup()
        Else
            MainMenu()

        End If

    End Sub
Sub FirstTimeSetup()
    Dim path As String
    Dim filename As String
    MsgBox("Performing first time setup...", MsgBoxStyle.Information)

    'Creates folder in "My Documents" for XML files to be placed into.
    path = GetFolderPath(SpecialFolder.MyDocuments)

    If (Not System.IO.Directory.Exists(path & "\Auto-XML")) Then
        System.IO.Directory.CreateDirectory(path & "\Auto-XML")
    End If
    'Creates a CSV file to store filenames in
    filename = ("\Auto-XML\filenames.csv")

    FileOpen(1, path & filename, OpenMode.Output)
    FileClose(1)

        WriteLine("First time setup complete")

    MsgBox("A folder has been created in your documents folder named Auto-XML. It will contain all your XML files, and also some program files.", MsgBoxStyle.Information)

    MainMenu()


End Sub
Sub MainMenu()
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Welcome to Auto-XML for PGM")
        WriteLine("Designed to help you write XML files")
        ForegroundColor = ConsoleColor.Gray
        WriteLine("Press 1 to create a new XML file")
        WriteLine("Press 2 to add to an XML file")
        ForegroundColor = ConsoleColor.Red
        WriteLine("Press 3 to exit")
        ForegroundColor = ConsoleColor.Yellow
        menuoption = Console.ReadLine
        If menuoption = "1" Then
            NewFile()

        End If
    End Sub
    Sub NewFile()
        Dim filename As String
        Dim newfilename As String
        Dim path As String

        Console.Clear()
        WriteLine("Please name your new file.")
        Console.WriteLine("If the program crashes in this process, please re-perform first time setup.")

        WriteLine("Enter a file name")
        newfilename = ReadLine()

        'Adds filename to CSV file for storage

        path = GetFolderPath(SpecialFolder.MyDocuments)
        filename = "\Auto-XML\filenames.CSV"
        FileOpen(1, path & filename, OpenMode.Output)
        PrintLine(1, newfilename & ",")

        'Creates file

        FileOpen(2, path & "\Auto-XML\" & newfilename & ".txt", OpenMode.Output)

        WriteLine("File Created. Press Enter To continue")

        ReadLine()
        Clear()
        ForegroundColor = ConsoleColor.Blue
        WriteLine("Currently editing file:" & newfilename)
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Please enter the name of yor map")
        ForegroundColor = ConsoleColor.Red
        userinput = ReadLine()
        'Prints the map proto.
        PrintLine(2, "<" & "map proto=" & Chr(34) & "1.3.0" & Chr(34) & ">")
        PrintLine(2, "<name>" & userinput & "</name>")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Please enter the map version")
        ForegroundColor = ConsoleColor.Red
        userinput = ReadLine()
        PrintLine(2, "<version>" & userinput & "<\version>")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Please enter the objective")
        ForegroundColor = ConsoleColor.Red
        userinput = ReadLine()
        PrintLine(2, "<objective>" & userinput & "</objective>")
        PrintLine(2, "<authors>")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Enter the authours name")
        ForegroundColor = ConsoleColor.Red
        userinput = ReadLine()
        PrintLine(2, "<author>" & userinput & "</author>")
        'Add support for mutiple autors using loop
        PrintLine(2, "</authors>")

        PrintLine(2, "<contributors>")
        PrintLine(2, "<contributor contribution=" & Chr(34) & "XML coding (Auto-XML)" & Chr(34) & ">" & "sillybillypiggy</contributor>")
        PrintLine(2, "<contributors>")
        Teams()
    End Sub


    Sub NewFiletwo()
        PrintLine(2, "<kits>")

        WriteLine("What is the kit called?")
        userinput = ReadLine()

        PrintLine(2, "<kit name=" & Chr(34) & userinput & Chr(34) & ">")
        Do
            WriteLine("Enter an item, or type X to finish")
            If userinput = "X" Or userinput = "x" Or userinputtwo = "x" Or userinputtwo = "X" Then
                Newfilethree()
            Else

                Console.WriteLine("Which slot do you want this in?")
                userinputtwo = ReadLine()
                WriteLine("Which item?")
                userinput = ReadLine()
                PrintLine(2, "<item slot=" & Chr(34) & userinputtwo & Chr(34) & ">" & userinput & "</item>")
            End If

        Loop




    End Sub
    Sub Newfilethree()
        WriteLine("It worked!")
        ReadLine()

    End Sub
    Sub EditFile()

    End Sub
    Sub Teams()
        'Teams
        'Using American English :<, but it'll confuse me later if I don't

        WriteLine("Please enter the team colour")
        WriteLine("Colours:")
        ForegroundColor = ConsoleColor.White
        WriteLine("black")
        ForegroundColor = ConsoleColor.DarkBlue
        WriteLine("dark blue")
        ForegroundColor = ConsoleColor.DarkGreen
        WriteLine("dark green")
        ForegroundColor = ConsoleColor.DarkCyan
        WriteLine("dark aqua")
        ForegroundColor = ConsoleColor.DarkRed
        WriteLine("dark red (Note: Usually used for Red team)")
        ForegroundColor = ConsoleColor.DarkMagenta
        WriteLine("dark purple")
        ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("gold")
        ForegroundColor = ConsoleColor.Gray
        WriteLine("gray")
        ForegroundColor = ConsoleColor.DarkGray
        WriteLine("dark gray")
        ForegroundColor = ConsoleColor.Blue
        WriteLine("blue")
        ForegroundColor = ConsoleColor.Green
        WriteLine("green")
        ForegroundColor = ConsoleColor.Cyan
        WriteLine("aqua")
        ForegroundColor = ConsoleColor.Red
        WriteLine("red")
        ForegroundColor = ConsoleColor.Magenta
        WriteLine("light purple")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("yellow")
        ForegroundColor = ConsoleColor.White
        WriteLine("white")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Please enter the team color from one above")
        'insert checking system later
        userinput = ReadLine()
        ForegroundColor = ConsoleColor.Green
        WriteLine("Please enter the team size")
        userinputtwo = ReadLine()
        ForegroundColor = ConsoleColor.Green
        WriteLine("Please enter the team name")
        userinputthree = ReadLine()
        PrintLine(2, "<teams>")
        PrintLine(2, "<team color =" & Chr(34) & userinput & Chr(34) & "max=" & Chr(34) & userinputtwo & Chr(34) & ">" & userinputthree & "</team>")

        'Teams
        'Using American English :<, but it'll confuse me later if I don't

        WriteLine("Please enter the team colour")
        WriteLine("Colours:")
        ForegroundColor = ConsoleColor.White
        WriteLine("black")
        ForegroundColor = ConsoleColor.DarkBlue
        WriteLine("dark blue")
        ForegroundColor = ConsoleColor.DarkGreen
        WriteLine("dark green")
        ForegroundColor = ConsoleColor.DarkCyan
        WriteLine("dark aqua")
        ForegroundColor = ConsoleColor.DarkRed
        WriteLine("dark red (Note: Usually used for Red team)")
        ForegroundColor = ConsoleColor.DarkMagenta
        WriteLine("dark purple")
        ForegroundColor = ConsoleColor.DarkYellow
        WriteLine("gold")
        ForegroundColor = ConsoleColor.Gray
        WriteLine("gray")
        ForegroundColor = ConsoleColor.DarkGray
        WriteLine("dark gray")
        ForegroundColor = ConsoleColor.Blue
        WriteLine("blue")
        ForegroundColor = ConsoleColor.Green
        WriteLine("green")
        ForegroundColor = ConsoleColor.Cyan
        WriteLine("aqua")
        ForegroundColor = ConsoleColor.Red
        WriteLine("red")
        ForegroundColor = ConsoleColor.Magenta
        WriteLine("light purple")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("yellow")
        ForegroundColor = ConsoleColor.White
        WriteLine("white")
        ForegroundColor = ConsoleColor.Yellow
        WriteLine("Please enter the team color from one above")
        'insert checking system later
        userinput = ReadLine()
        ForegroundColor = ConsoleColor.Green
        WriteLine("Please enter the team size")
        userinputtwo = ReadLine()
        ForegroundColor = ConsoleColor.Green
        WriteLine("Please enter the team name")
        userinputthree = ReadLine()
        PrintLine(2, "<teams>")
        PrintLine(2, "<team color =" & Chr(34) & userinput & Chr(34) & "max=" & Chr(34) & userinputtwo & Chr(34) & ">" & userinputthree & "</team>")

        NewFiletwo()

    End Sub

End Module
