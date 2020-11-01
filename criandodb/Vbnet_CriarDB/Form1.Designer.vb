<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControlExtender1 = New TabControlExtender()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeTabela = New System.Windows.Forms.TextBox()
        Me.txtNomeBD = New System.Windows.Forms.TextBox()
        Me.txtInitialCatalog = New System.Windows.Forms.TextBox()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExibirDados = New System.Windows.Forms.Button()
        Me.btnApagarTabela = New System.Windows.Forms.Button()
        Me.btnListaTabelas = New System.Windows.Forms.Button()
        Me.btnCriarTabela = New System.Windows.Forms.Button()
        Me.btnCriarBDSQLServer = New System.Windows.Forms.Button()
        Me.btnVerificarSQLServer = New System.Windows.Forms.Button()
        Me.lbDados = New System.Windows.Forms.ListBox()
        Me.cboIntegrateSecurity = New System.Windows.Forms.ComboBox()
        Me.tabControlExtender1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlExtender1
        '
        Me.tabControlExtender1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabControlExtender1.BackColor = System.Drawing.SystemColors.Control
        Me.tabControlExtender1.Controls.Add(Me.tabPage1)
        Me.tabControlExtender1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlExtender1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tabControlExtender1.HeaderAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.tabControlExtender1.HeaderBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tabControlExtender1.HeaderBorderColor = System.Drawing.Color.RoyalBlue
        Me.tabControlExtender1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlExtender1.HeaderForeColor = System.Drawing.Color.White
        Me.tabControlExtender1.HeaderSelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.tabControlExtender1.ItemSize = New System.Drawing.Size(32, 100)
        Me.tabControlExtender1.Location = New System.Drawing.Point(0, 0)
        Me.tabControlExtender1.Multiline = True
        Me.tabControlExtender1.Name = "tabControlExtender1"
        Me.tabControlExtender1.SelectedIndex = 0
        Me.tabControlExtender1.Size = New System.Drawing.Size(800, 326)
        Me.tabControlExtender1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControlExtender1.TabIndex = 1
        '
        'tabPage1
        '
        Me.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabPage1.Controls.Add(Me.cboIntegrateSecurity)
        Me.tabPage1.Controls.Add(Me.Label5)
        Me.tabPage1.Controls.Add(Me.Label4)
        Me.tabPage1.Controls.Add(Me.Label3)
        Me.tabPage1.Controls.Add(Me.Label2)
        Me.tabPage1.Controls.Add(Me.Label1)
        Me.tabPage1.Controls.Add(Me.txtNomeTabela)
        Me.tabPage1.Controls.Add(Me.txtNomeBD)
        Me.tabPage1.Controls.Add(Me.txtInitialCatalog)
        Me.tabPage1.Controls.Add(Me.txtDataSource)
        Me.tabPage1.Controls.Add(Me.btnSair)
        Me.tabPage1.Controls.Add(Me.btnExibirDados)
        Me.tabPage1.Controls.Add(Me.btnApagarTabela)
        Me.tabPage1.Controls.Add(Me.btnListaTabelas)
        Me.tabPage1.Controls.Add(Me.btnCriarTabela)
        Me.tabPage1.Controls.Add(Me.btnCriarBDSQLServer)
        Me.tabPage1.Controls.Add(Me.btnVerificarSQLServer)
        Me.tabPage1.Controls.Add(Me.lbDados)
        Me.tabPage1.Location = New System.Drawing.Point(104, 4)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(692, 318)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Criando DB"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(545, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nome da Tabela"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(545, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nome do Banco de Dados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Segurança Integrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Catálogo Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fonte de Dados"
        '
        'txtNomeTabela
        '
        Me.txtNomeTabela.Location = New System.Drawing.Point(548, 192)
        Me.txtNomeTabela.Name = "txtNomeTabela"
        Me.txtNomeTabela.Size = New System.Drawing.Size(139, 20)
        Me.txtNomeTabela.TabIndex = 12
        '
        'txtNomeBD
        '
        Me.txtNomeBD.Location = New System.Drawing.Point(548, 153)
        Me.txtNomeBD.Name = "txtNomeBD"
        Me.txtNomeBD.Size = New System.Drawing.Size(139, 20)
        Me.txtNomeBD.TabIndex = 11
        '
        'txtInitialCatalog
        '
        Me.txtInitialCatalog.Location = New System.Drawing.Point(548, 62)
        Me.txtInitialCatalog.Name = "txtInitialCatalog"
        Me.txtInitialCatalog.Size = New System.Drawing.Size(139, 20)
        Me.txtInitialCatalog.TabIndex = 9
        Me.txtInitialCatalog.Text = "Master"
        '
        'txtDataSource
        '
        Me.txtDataSource.Location = New System.Drawing.Point(548, 22)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(139, 20)
        Me.txtDataSource.TabIndex = 8
        Me.txtDataSource.Text = "."
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(1, 180)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(96, 24)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExibirDados
        '
        Me.btnExibirDados.Location = New System.Drawing.Point(1, 151)
        Me.btnExibirDados.Name = "btnExibirDados"
        Me.btnExibirDados.Size = New System.Drawing.Size(96, 23)
        Me.btnExibirDados.TabIndex = 6
        Me.btnExibirDados.Text = "Exibir Tabela"
        Me.btnExibirDados.UseVisualStyleBackColor = True
        '
        'btnApagarTabela
        '
        Me.btnApagarTabela.Location = New System.Drawing.Point(1, 123)
        Me.btnApagarTabela.Name = "btnApagarTabela"
        Me.btnApagarTabela.Size = New System.Drawing.Size(96, 23)
        Me.btnApagarTabela.TabIndex = 5
        Me.btnApagarTabela.Text = "Excluir Tabelas"
        Me.btnApagarTabela.UseVisualStyleBackColor = True
        '
        'btnListaTabelas
        '
        Me.btnListaTabelas.Location = New System.Drawing.Point(1, 93)
        Me.btnListaTabelas.Name = "btnListaTabelas"
        Me.btnListaTabelas.Size = New System.Drawing.Size(96, 23)
        Me.btnListaTabelas.TabIndex = 4
        Me.btnListaTabelas.Text = "Lista de Tabelas"
        Me.btnListaTabelas.UseVisualStyleBackColor = True
        '
        'btnCriarTabela
        '
        Me.btnCriarTabela.Location = New System.Drawing.Point(1, 64)
        Me.btnCriarTabela.Name = "btnCriarTabela"
        Me.btnCriarTabela.Size = New System.Drawing.Size(96, 23)
        Me.btnCriarTabela.TabIndex = 3
        Me.btnCriarTabela.Text = "Criar Tabela"
        Me.btnCriarTabela.UseVisualStyleBackColor = True
        '
        'btnCriarBDSQLServer
        '
        Me.btnCriarBDSQLServer.Location = New System.Drawing.Point(1, 35)
        Me.btnCriarBDSQLServer.Name = "btnCriarBDSQLServer"
        Me.btnCriarBDSQLServer.Size = New System.Drawing.Size(96, 23)
        Me.btnCriarBDSQLServer.TabIndex = 2
        Me.btnCriarBDSQLServer.Text = "Criar DB"
        Me.btnCriarBDSQLServer.UseVisualStyleBackColor = True
        '
        'btnVerificarSQLServer
        '
        Me.btnVerificarSQLServer.Location = New System.Drawing.Point(1, 6)
        Me.btnVerificarSQLServer.Name = "btnVerificarSQLServer"
        Me.btnVerificarSQLServer.Size = New System.Drawing.Size(96, 23)
        Me.btnVerificarSQLServer.TabIndex = 1
        Me.btnVerificarSQLServer.Text = "Verificar SQL"
        Me.btnVerificarSQLServer.UseVisualStyleBackColor = True
        '
        'lbDados
        '
        Me.lbDados.FormattingEnabled = True
        Me.lbDados.Location = New System.Drawing.Point(100, 1)
        Me.lbDados.Name = "lbDados"
        Me.lbDados.ScrollAlwaysVisible = True
        Me.lbDados.Size = New System.Drawing.Size(442, 303)
        Me.lbDados.TabIndex = 0
        '
        'cboIntegrateSecurity
        '
        Me.cboIntegrateSecurity.FormattingEnabled = True
        Me.cboIntegrateSecurity.Items.AddRange(New Object() {"true", "false"})
        Me.cboIntegrateSecurity.Location = New System.Drawing.Point(548, 104)
        Me.cboIntegrateSecurity.Name = "cboIntegrateSecurity"
        Me.cboIntegrateSecurity.Size = New System.Drawing.Size(139, 21)
        Me.cboIntegrateSecurity.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 326)
        Me.Controls.Add(Me.tabControlExtender1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Criando banco de dados Sql server"
        Me.tabControlExtender1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControlExtender1 As TabControlExtender
    Private WithEvents tabPage1 As TabPage
    Friend WithEvents lbDados As ListBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnExibirDados As Button
    Friend WithEvents btnApagarTabela As Button
    Friend WithEvents btnListaTabelas As Button
    Friend WithEvents btnCriarTabela As Button
    Friend WithEvents btnCriarBDSQLServer As Button
    Friend WithEvents btnVerificarSQLServer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeTabela As TextBox
    Friend WithEvents txtNomeBD As TextBox
    Friend WithEvents txtInitialCatalog As TextBox
    Friend WithEvents txtDataSource As TextBox
    Friend WithEvents cboIntegrateSecurity As ComboBox
End Class
