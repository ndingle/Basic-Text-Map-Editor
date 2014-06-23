Public Class frmMain

    Dim roomSpacing As Integer = 50                 'The size of the picturebox's cells

    Sub ChangeRoom()

        'HERE: Update the fields on the form based on what the new coordinates

        txtName.Text = rooms(roomX, roomY).Name                 'Change the text box contents to the room's name
        txtDescription.Text = rooms(roomX, roomY).Description   'Change the text box contents to the room's description
        txtItems.Text = rooms(roomX, roomY).Items               'Change the text box contents to the room's items
        chkUp.Checked = rooms(roomX, roomY).CanMoveUp           'Change the text box contents to the room's up movement
        chkDown.Checked = rooms(roomX, roomY).CanMoveDown       'Change the text box contents to the room's down movement
        chkLeft.Checked = rooms(roomX, roomY).CanMoveLeft       'Change the text box contents to the room's left movement
        chkRight.Checked = rooms(roomX, roomY).CanMoveRight     'Change the text box contents to the room's right movement

    End Sub

    Sub SaveRoom()

        'HERE: Save all of the current fields

        rooms(roomX, roomY).Name = txtName.Text                 'Save the text box contents to the room's name
        rooms(roomX, roomY).Description = txtDescription.Text   'Save the text box contents to the room's description
        rooms(roomX, roomY).Items = txtItems.Text               'Save the text box contents to the room's items
        rooms(roomX, roomY).CanMoveUp = chkUp.Checked           'Save the text box contents to the room's up movement
        rooms(roomX, roomY).CanMoveDown = chkDown.Checked       'Save the text box contents to the room's down movement
        rooms(roomX, roomY).CanMoveLeft = chkLeft.Checked       'Save the text box contents to the room's left movement
        rooms(roomX, roomY).CanMoveRight = chkRight.Checked     'Save the text box contents to the room's right movement

    End Sub

    Sub SetupRooms()

        'HERE: Go through the rooms and make them all blank

        For i = 0 To 9                      'Loop through all the Horizontal Axis
            For j = 0 To 9                  'Loop through all the Vertical Axis
                rooms(i, j) = New Room()    'Create a new room
            Next
        Next

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SetupRooms()                        'Initialise the rooms

    End Sub

    Private Sub picGrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picGrid.MouseDown

        'HERE: When the user clicks the picture box we find out the new room and refresh the form

        SaveRoom()                          'Save the changes they made

        roomX = e.Location.X \ roomSpacing  'Take the Mouse X coord and divide by our cell size to get the X Coordinate
        roomY = e.Location.Y \ roomSpacing  'Take the Mouse Y coord and divide by our cell size to get the Y Coordinate

        picGrid.Refresh()                   'Tell the picture box to redraw so we can see our new selected room

        ChangeRoom()                        'Now we have new coords, load the information into the fields

    End Sub

    Private Sub picGrid_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picGrid.Paint

        'HERE: Draw the grid so the user can see it

        Dim g As Graphics = e.Graphics                          'Get the graphics of the picture box
        Dim pn As New Pen(Color.Black)                          'Create a new pen which will draw the lines black

        Dim x As Integer                                        'X will run left to right
        Dim y As Integer                                        'Y will run up to down

        '~~~ Draw the horizontal lines
        x = picGrid.Width                                       'Set the X coord to the width of the picture box
        For y = 0 To picGrid.Height Step roomSpacing            'Loop for as many vertical cells as we can fit (i.e. 500 pixels across at 50 pixels in width, 500/50 = 10 rooms)
            g.DrawLine(pn, New Point(0, y), New Point(x, y))    'Draw a line across the picture box
        Next

        '~~~ Draw the vertical lines
        y = picGrid.Height                                      'Set the Y coord to the height of the picture box
        For x = 0 To picGrid.Width Step roomSpacing             'Loop for as many vertical cells as we can fit (i.e. 500 pixels across at 50 pixels in width, 500/50 = 10 rooms)
            g.DrawLine(pn, New Point(x, 0), New Point(x, y))    'Draw a line down the picture box
        Next

        'Draw the square of where is selected
        g.FillRectangle(Brushes.Black, New Rectangle(roomSpacing * roomX, roomSpacing * roomY, roomSpacing, roomSpacing))

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        'HERE: We save all of our information to a file

        If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then   'Open the save file dialog and check if they pressed ok

            SaveRoom()                                                  'Save the changes they made

            FileOpen(1, saveFile.FileName, OpenMode.Output)             'Open the file so we can write to it

            For i = 0 To 9                                              'Loop through horizontal rooms
                For j = 0 To 9                                          'Loop through the vertical rooms

                    'We write the whole room to ONE line in the file. The name, description, etc are all separated by ~ so we can break it up when loading
                    PrintLine(1, rooms(i, j).Name & "~" &
                                rooms(i, j).Description & "~" &
                                rooms(i, j).Items & "~" &
                                rooms(i, j).CanMoveUp & "~" &
                                rooms(i, j).CanMoveDown & "~" &
                                rooms(i, j).CanMoveLeft & "~" &
                                rooms(i, j).CanMoveRight)
                Next
            Next


            FileClose(1)                                                'Close the file off

        End If

    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        'HERE: We load the file from and refresh the form

        If openFile.ShowDialog() = Windows.Forms.DialogResult.OK Then   'Open the open file dialog and check if they pressed ok

            FileOpen(1, openFile.FileName, OpenMode.Input)              'Open the file so we can read from it

            For i = 0 To 9                                              'Loop through the horizontal rooms
                For j = 0 To 9                                          'Loop through the vertical rooms

                    Dim fields() As String = LineInput(1).Split("~")    'Load one line from the file, split the information by every ~ you see
                    rooms(i, j).Name = fields(0)                        'Put the name into the room
                    rooms(i, j).Description = fields(1)                 'Put the description into the room
                    rooms(i, j).Items = fields(2)                       'Put the items into the room
                    rooms(i, j).CanMoveUp = fields(3)                   'Put the move up into the room
                    rooms(i, j).CanMoveDown = fields(4)                 'Put the move down into the room
                    rooms(i, j).CanMoveLeft = fields(5)                 'Put the move left into the room
                    rooms(i, j).CanMoveRight = fields(6)                'Put the move right into the room

                Next
            Next

            FileClose(1)                                                'Close the file we're done!

            roomX = 0                                                   'Reset the X to 0 for when we refresh
            roomY = 0                                                   'Reset the Y to 0 for when we refresh
            picGrid.Refresh()                                           'Refresh the picture box
            ChangeRoom()                                                'Refresh the fields on the form

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()            'Close the form

    End Sub
End Class
