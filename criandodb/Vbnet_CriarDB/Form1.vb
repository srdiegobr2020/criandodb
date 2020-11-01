Imports System.Data.SqlClient
Imports Microsoft.Win32
Public Class Form1
    Private ConnectionString As String = ""
    Private rdr As SqlDataReader = Nothing
    Private con As SqlConnection = Nothing
    Private cmd As SqlCommand = Nothing
    Private da As SqlDataAdapter = Nothing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIntegrateSecurity.SelectedIndex = 0
    End Sub

    Private Sub btnVerificarSQLServer_Click(sender As Object, e As EventArgs) Handles btnVerificarSQLServer.Click
        Dim registroView As RegistryView = If(Environment.Is64BitOperatingSystem, RegistryView.Registry64, RegistryView.Registry32)
        Using chaveRegistroLocalMachine As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registroView)
            Dim instanciaChave As RegistryKey = chaveRegistroLocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", False)
            lbDados.Items.Add("Nome da máquina\Nome da Instância")
            If instanciaChave IsNot Nothing Then
                For Each nomeInstancia In instanciaChave.GetValueNames()
                    lbDados.Items.Add(Environment.MachineName + "\" + nomeInstancia)
                Next
            Else
                MessageBox.Show("SQL Server e instâncias não localizados")
            End If
        End Using
    End Sub

    Private Sub btnCriarBDSQLServer_Click(sender As Object, e As EventArgs) Handles btnCriarBDSQLServer.Click
        ' Define a string de conexão com o SQL Server : "Data Source=;" + "Initial Catalog=;" + "Integrated Security=I;"
        ConnectionString = MontaStringConexaoSQLServer("Master")
        ' cria e inicializa a string de conexão
        Dim minhaConexaoSQLServer As SqlConnection = New SqlConnection(ConnectionString)
        ' define uma string para armazenar a consulta SQL que vai criar o BD
        Dim sql As String = "CREATE database " & txtNomeBD.Text
        ' cria o comando para execução na conexão atual
        Dim cmd As SqlCommand = New SqlCommand(sql, minhaConexaoSQLServer)
        Try
            cmd.Connection.Open()  'abre a conecao com o cmd
            cmd.ExecuteNonQuery()  'Executa a consulta
            lbDados.Items.Add("O banco de dados " & txtNomeBD.Text & " foi criado com sucesso.")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close() 'Fecha a conexão
        End Try
    End Sub

    Private Sub btnCriarTabela_Click(sender As Object, e As EventArgs) Handles btnCriarTabela.Click
        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            'define a consulta SQL para criar a tabela com os campos :  ID, Nome e Email
            Dim sql As String = "CREATE TABLE " & txtNomeTabela.Text & "(ID int NOT NULL, 
                                                                         Nome varchar(50) NULL,
                                                                         Email varchar(150) NULL)"
            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'abre a conexao
            cmd.Connection.Open()
            'executa o comando
            cmd.ExecuteNonQuery()
            ' Adding records the table
            sql = "INSERT INTO " & txtNomeTabela.Text & "(ID, Nome, Email) " + "VALUES (1001, 'Macoratti', 'macoratti@yahoo.com' ) "
            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            lbDados.Items.Add("A tabela " & txtNomeTabela.Text & " foi criada com sucesso.")
            'lista as tabelas existentes no banco de dados para a conexão atual
            ListaTabelas(GetTabelasBancoDados(ConnectionString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub
    Private Sub ListaTabelas(ByVal nomes As List(Of String))
        lbDados.Items.Add("Tabelas do banco de dados")
        For Each nome In nomes
            lbDados.Items.Add(nome)
        Next
    End Sub

    Private Function MontaStringConexaoSQLServer(ByVal flag As String) As String

        Dim dataSource As String = ""
        Dim initialCatalog As String = ""
        Dim integratedSecurity As Boolean = False
        Dim connectionString As String = ""

        If Not String.IsNullOrWhiteSpace(txtDataSource.Text) Then
            dataSource = txtDataSource.Text
        Else
            MessageBox.Show("Informe o DataSource...")
            Return ""
        End If

        If Not String.IsNullOrWhiteSpace(txtInitialCatalog.Text) Then
            If flag = "Master" Then
                initialCatalog = txtInitialCatalog.Text
            ElseIf flag = "Tabela" Then
                initialCatalog = txtNomeBD.Text
            End If
        Else
            MessageBox.Show("Informe o Initial Catalog...")
            Return ""
        End If

        If cboIntegrateSecurity.Text = "true" Then
            integratedSecurity = True
        ElseIf cboIntegrateSecurity.Text = "false" Then
            integratedSecurity = False
        Else
            MessageBox.Show("Informe o Integrated Security...")
            Return ""
        End If

        connectionString = "Data Source=" & dataSource & ";Initial Catalog=" & initialCatalog & ";Integrated Security=" & integratedSecurity
        Return connectionString

    End Function

    Private Function GetTabelasBancoDados(ByVal conexaoSQLServer As String) As List(Of String)

        'define as variáveis usadas 
        Dim lista_Tabelas As New List(Of String)
        Dim cn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim ds As New DataSet()

        'faz a conexão com o banco de dados e abre a conexao
        cn = New SqlConnection(conexaoSQLServer) '
        cn.Open()
        'define a consulta para retornar as tabelas
        cmd = New SqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.tables ORDER BY TABLE_NAME", cn)

        'preenche o dataset
        cmd.Fill(ds)
        'fecha a conexao
        cn.Close()

        For Each table As DataTable In ds.Tables
            For Each row As DataRow In table.Rows
                'Pega somente as tabelas e emite as Views
                If row.ItemArray(3).ToString = "BASE TABLE" Then
                    For Each col As DataColumn In table.Columns
                        If col.ToString() = "TABLE_NAME" Then
                            lista_Tabelas.Add(row(col).ToString())
                            Exit For
                        End If
                    Next
                End If
            Next
        Next

        'retorna uma lista de strings contendo as tabelas do BD
        Return lista_Tabelas
    End Function

    Private Sub btnListaTabelas_Click(sender As Object, e As EventArgs) Handles btnListaTabelas.Click
        'cria e inicializa uma string de conexão
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            ListaTabelas(GetTabelasBancoDados(ConnectionString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub btnApagarTabela_Click(sender As Object, e As EventArgs) Handles btnApagarTabela.Click
        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            'define a consulta SQL para excluir a tabela
            Dim sql As String = "DROP TABLE " & txtNomeTabela.Text
            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'abre a conexao
            cmd.Connection.Open()
            'executa o comando
            cmd.ExecuteNonQuery()
            lbDados.Items.Add("A tabela " & txtNomeTabela.Text & " foi excluída com sucesso.")
            'lista as tabelas existentes no banco de dados para a conexão atual
            ListaTabelas(GetTabelasBancoDados(ConnectionString))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub
    Private Sub ExibirDadosTabela()

        'define a string de conexão com a banco de dados que foi criado
        ConnectionString = MontaStringConexaoSQLServer("Tabela")
        Try
            'cria e inicializa a string de conexão
            Dim cn As SqlConnection = New SqlConnection(ConnectionString)
            'define a consulta SQL selecionar os dados da tabela
            Dim sql As String = "Select * from " & txtNomeTabela.Text
            'cria comando na conexão para executar a consulta
            cmd = New SqlCommand(sql, cn)
            'define um dataadatper
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "tabela")

            lbDados.Items.Add("Dados da tabela " & txtNomeTabela.Text)

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                Dim i As Integer
                For i = 1 To ds.Tables(0).Columns.Count
                    lbDados.Items.Add(dr(i - 1))
                Next i
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            cmd.Connection.Close()
        End Try
    End Sub

    Private Sub btnExibirDados_Click(sender As Object, e As EventArgs) Handles btnExibirDados.Click
        ExibirDadosTabela()
    End Sub
End Class
