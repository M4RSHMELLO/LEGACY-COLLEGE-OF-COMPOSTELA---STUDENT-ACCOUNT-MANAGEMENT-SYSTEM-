
Imports System.Data
Module lccsams

    '#############################################################Db Connection##########################################################################################
    Public dbConn As MySqlConnection ' This is used to establish connection
    Public sqlCommand As MySqlCommand ' This is used invoking SQL Command and retrieval
    Public sqlCommand2 As MySqlCommand ' This is used invoking SQL Command and retrieval
    Public strConn = "server=localhost; user id=raldz;password=d74r3j93527;database=" 'Connecttion String
    'Public strConn = "server=192.168.254.114; user id=raldz;password=d74r3j93527;database=" 'Connecttion String
    'Public strConn = "server=206.189.80.59;Port=22284; user id=raldz;password=d74r3j93527;database=" 'Connecttion String
    Public da As MySqlDataAdapter ' A bridge between connection and Data
    Public dt As DataTable  'opulate the records from Database
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public current_menu As Integer = 0
    Public current_date As Date = Date.Now()   'Caurrent Date OF THE transaction ocurred
    Public result As Integer
    Public username As String
    Public cashier_name As String
    Public user_type As String
    '#################################################################COLLEGE PUBLIC VARIABLE###############################################################################
    Public slctC As String = "Select * from tbl_coll_course"
    Public slctS As String = "select * from tbl_semester"
    Public slctYL As String = "select * from tbl_year_level order by yl_id desc"
    Public slctSY As String = "select * from tbl_sch_year group by sy_name having count(*) > 0 order by sy_eDate desc "
    Public s_msyR As String = "Select * from schyearrecords order by sy_eDate desc"
    Public sStudR As String = "select * from stud_records"

    Public fname As String = ""
    Public lname As String = ""
    Public stud_id As Integer
    Public stud_name As String
    Public stud_crs As String
    Public stud_sem As String
    Public stud_yl As String
    Public stud_sy As String
    Public stud_nUnits As String
    Public stud_rpu As String
    Public csy_id As String
    Public cyl_id As String
    Public csem_id As String
    Public ccrs_id As String

    Public sy_fid As String
    Public sy_sDate As String
    Public sy_eDate As String



    ''#################################Elementary PUBLIC VARIABLE#################################################################################################
    Public eSelect_SY As String = "select * from tbl_elem_sy order by esy_edate desc"
    Public eSelect_GL As String = "select * from tbl_elem_gradelevel"
    Public eSelect_studRec As String = "select * from tbl_elem_students order by estud_lname asc,estud_fname asc"

    Public eStud_id As Integer
    Public eFname As String
    Public eLname As String
    Public eStudname As String
    Public eStudGL As String
    Public eStudSY As String
    Public eSy_id As String
    Public egl_id As String
    Public esy_sDate As String
    Public esy_eDate As String

    '#############################################################Senior-High PUBLIC VARIABLE#########################################################
    Public sSelect_SY As String = "select * from tbl_seniorhigh_sy"
    Public sSelect_GL As String = "select * from tbl_seniorhigh_gl"
    Public sSelect_studRec As String = "select * from tbl_seniorhigh_students order by sstud_lname asc,sstud_fname asc"

    Public sStud_id As String
    Public sFname As String
    Public sLname As String
    Public sStudname As String
    Public sStudGL As String
    Public sStudSY As String
    Public sSy_sDate As String
    Public sSy_eDate As String
    Public sSy_id As String
    Public sgl_id As String

    '#############################################################Junior-High PUBLIC VARIABLE#########################################################
    Public jSelect_SY As String = "select * from tbl_juniorhigh_sy order by jsy_edate desc "
    Public jSelect_GL As String = "select * from tbl_juniorhigh_gradelevel"
    Public jSelect_studRec As String = "select * from tbl_juniorhigh_students order by jstud_lname asc, jstud_fname asc"

    Public jStud_id As String
    Public jFname As String
    Public jLname As String
    Public jStudname As String
    Public jStudGL As String
    Public jStudSY As String
    Public jSy_sDate As String
    Public jSy_eDate As String
    Public jSy_id As String
    Public jgl_id As String
    '######################################################### Module & function class ##############################################################################
    Public Sub _dbConnection(ByVal dbName As String)
        Try
            dbConn = New MySqlConnection(strConn & dbName)
            dbConn.Open()
        Catch ex As Exception
            erromessage("error 101: Connection to database is faild please contact the administrator " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub _insertData(ByVal sql As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
        Catch ex As Exception
            erromessage("error 102: Insert Data " & ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub

    Public Sub _displayRecords(ByVal sql As String, ByVal dg As DataGridView)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(sql, dbConn)
            dt = New DataTable
            da.Fill(dt)
            dg.DataSource = dt

        Catch ex As Exception
            erromessage("error 103: Display Record" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub _displayToReports(ByVal sql As String)
        Try

            dbConn.Open()
            da = New MySqlDataAdapter(sql, dbConn)
            dt = New DataTable
            da.Fill(dt)


        Catch ex As Exception
            erromessage("error 103: Display Record" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Public Sub _loadToCombobox(ByVal sql As String, ByVal cbo As ComboBox)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(sql, dbConn)
            dt = New DataTable
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ToString 'primary key
            cbo.DisplayMember = dt.Columns(1).ToString 'display value
        Catch ex As Exception
            erromessage("error 104: loadToCombobox  " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub




    Public Sub _retrieveData(ByVal sql As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
            result = 0
            While dr.Read
                username = dr(0).ToString
                cashier_name = dr(1)
                user_type = dr(2).ToString
                result += 1
            End While
        Catch ex As Exception
            erromessage("error 105: Retrieve Data " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub


    Public Sub _loadToListBox(ByVal sql As String, ByVal lbo As ListBox)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(sql, dbConn)
            dt = New DataTable
            da.Fill(dt)
            lbo.DataSource = dt
            lbo.ValueMember = dt.Columns(0).ToString 'primary key
            lbo.DisplayMember = dt.Columns(1).ToString 'display value
        Catch ex As Exception
            erromessage("error 106: loadToListBox  " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub _updateData(ByVal sql As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
        Catch ex As Exception
            erromessage("error 107 Update Data " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub _loadToTextbox(ByVal sql As String, ByVal txtb As TextBox)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()

                txtb.Text = dr(0)
            End While
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Public Sub _loadToTextbox_2col(ByVal sql As String, ByVal txtb As TextBox, ByVal rb As RadioButton)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()

                txtb.Text = dr(0)
                If dr(1) = 1 Then
                    rb.Checked = True
                Else
                    rb.Checked = True
                End If

            End While
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub


    Public Sub _shareID(txtb As TextBox)
        txtb.Text = stud_id
    End Sub

    Function _selectComboBoxText(ByVal sql As String, ByVal cbo As ComboBox) As String
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                cbo.Text = dr(0).ToString
            End While
        Catch ex As Exception
            erromessage("error 108: selectComboBoxText " & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return cbo.Text
    End Function


    Public Sub _loadStudentNameToTextbox(ByVal sql As String, txtb As TextBox)
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            da = New MySqlDataAdapter(sql, dbConn)
            dt = New DataTable
            da.Fill(dt)
            Dim r As DataRow
            txtb.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtb.AutoCompleteCustomSource.Add(r.Item(0).ToString.ToUpper + " " + r.Item(1).ToString.ToUpper)
            Next
        Catch ex As Exception
            erromessage("error 109: " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Function _cancel(ByVal btn As Button, ByVal btnText As String) As String
        If btn.Text = "UPDATE" Then
            btn.Text = "CANCEL"
            Return btn.Text
        ElseIf btn.Text = "CANCEL" Then
            btn.Text = btnText
            Return btn.Text
        End If

    End Function
    Public Sub erromessage(ByVal errMsg As String)
        MessageBox.Show(errMsg)
    End Sub


End Module
