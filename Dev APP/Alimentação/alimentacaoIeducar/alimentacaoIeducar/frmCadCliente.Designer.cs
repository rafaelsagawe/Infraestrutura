namespace alimentacaoIeducar
{
    partial class frmCadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idcliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label prefeitoLabel;
            System.Windows.Forms.Label educacaoLabel;
            System.Windows.Forms.Label administracaoLabel;
            System.Windows.Forms.Label coordenacaoLabel;
            System.Windows.Forms.Label inscritosLabel;
            System.Windows.Forms.Label idpesLabel;
            System.Windows.Forms.Label identificacaoLabel;
            System.Windows.Forms.Label tab_produtosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            this.ieducarDataSet = new alimentacaoIeducar.ieducarDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new alimentacaoIeducar.ieducarDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new alimentacaoIeducar.ieducarDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idcliTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prefeitoTextBox = new System.Windows.Forms.TextBox();
            this.educacaoTextBox = new System.Windows.Forms.TextBox();
            this.administracaoTextBox = new System.Windows.Forms.TextBox();
            this.coordenacaoTextBox = new System.Windows.Forms.TextBox();
            this.inscritosTextBox = new System.Windows.Forms.TextBox();
            this.idpesTextBox = new System.Windows.Forms.TextBox();
            this.identificacaoTextBox = new System.Windows.Forms.TextBox();
            this.tab_produtosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            idcliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            prefeitoLabel = new System.Windows.Forms.Label();
            educacaoLabel = new System.Windows.Forms.Label();
            administracaoLabel = new System.Windows.Forms.Label();
            coordenacaoLabel = new System.Windows.Forms.Label();
            inscritosLabel = new System.Windows.Forms.Label();
            idpesLabel = new System.Windows.Forms.Label();
            identificacaoLabel = new System.Windows.Forms.Label();
            tab_produtosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ieducarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idcliLabel
            // 
            idcliLabel.AutoSize = true;
            idcliLabel.Location = new System.Drawing.Point(444, 111);
            idcliLabel.Name = "idcliLabel";
            idcliLabel.Size = new System.Drawing.Size(28, 13);
            idcliLabel.TabIndex = 1;
            idcliLabel.Text = "idcli:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 41);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(453, 41);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 5;
            cnpjLabel.Text = "cnpj:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(10, 22);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "endereco:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(10, 48);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(10, 74);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 11;
            cidadeLabel.Text = "cidade:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(197, 74);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 13;
            cepLabel.Text = "cep:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(10, 103);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 15;
            ufLabel.Text = "uf:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(7, 19);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "telefone:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(7, 45);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 19;
            faxLabel.Text = "fax:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(7, 71);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "email:";
            // 
            // prefeitoLabel
            // 
            prefeitoLabel.AutoSize = true;
            prefeitoLabel.Location = new System.Drawing.Point(10, 22);
            prefeitoLabel.Name = "prefeitoLabel";
            prefeitoLabel.Size = new System.Drawing.Size(45, 13);
            prefeitoLabel.TabIndex = 23;
            prefeitoLabel.Text = "prefeito:";
            // 
            // educacaoLabel
            // 
            educacaoLabel.AutoSize = true;
            educacaoLabel.Location = new System.Drawing.Point(10, 48);
            educacaoLabel.Name = "educacaoLabel";
            educacaoLabel.Size = new System.Drawing.Size(58, 13);
            educacaoLabel.TabIndex = 25;
            educacaoLabel.Text = "educacao:";
            // 
            // administracaoLabel
            // 
            administracaoLabel.AutoSize = true;
            administracaoLabel.Location = new System.Drawing.Point(10, 74);
            administracaoLabel.Name = "administracaoLabel";
            administracaoLabel.Size = new System.Drawing.Size(75, 13);
            administracaoLabel.TabIndex = 27;
            administracaoLabel.Text = "administracao:";
            // 
            // coordenacaoLabel
            // 
            coordenacaoLabel.AutoSize = true;
            coordenacaoLabel.Location = new System.Drawing.Point(10, 100);
            coordenacaoLabel.Name = "coordenacaoLabel";
            coordenacaoLabel.Size = new System.Drawing.Size(73, 13);
            coordenacaoLabel.TabIndex = 29;
            coordenacaoLabel.Text = "coordenacao:";
            // 
            // inscritosLabel
            // 
            inscritosLabel.AutoSize = true;
            inscritosLabel.Location = new System.Drawing.Point(444, 189);
            inscritosLabel.Name = "inscritosLabel";
            inscritosLabel.Size = new System.Drawing.Size(48, 13);
            inscritosLabel.TabIndex = 31;
            inscritosLabel.Text = "inscritos:";
            // 
            // idpesLabel
            // 
            idpesLabel.AutoSize = true;
            idpesLabel.Location = new System.Drawing.Point(444, 215);
            idpesLabel.Name = "idpesLabel";
            idpesLabel.Size = new System.Drawing.Size(35, 13);
            idpesLabel.TabIndex = 33;
            idpesLabel.Text = "idpes:";
            // 
            // identificacaoLabel
            // 
            identificacaoLabel.AutoSize = true;
            identificacaoLabel.Location = new System.Drawing.Point(444, 241);
            identificacaoLabel.Name = "identificacaoLabel";
            identificacaoLabel.Size = new System.Drawing.Size(70, 13);
            identificacaoLabel.TabIndex = 35;
            identificacaoLabel.Text = "identificacao:";
            // 
            // tab_produtosLabel
            // 
            tab_produtosLabel.AutoSize = true;
            tab_produtosLabel.Location = new System.Drawing.Point(444, 267);
            tab_produtosLabel.Name = "tab_produtosLabel";
            tab_produtosLabel.Size = new System.Drawing.Size(69, 13);
            tab_produtosLabel.TabIndex = 37;
            tab_produtosLabel.Text = "tab produtos:";
            // 
            // ieducarDataSet
            // 
            this.ieducarDataSet.DataSetName = "ieducarDataSet";
            this.ieducarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.ieducarDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.pessoaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = alimentacaoIeducar.ieducarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = null;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = null;
            this.clienteBindingNavigator.MoveLastItem = null;
            this.clienteBindingNavigator.MoveNextItem = null;
            this.clienteBindingNavigator.MovePreviousItem = null;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = null;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(674, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // idcliTextBox
            // 
            this.idcliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "idcli", true));
            this.idcliTextBox.Location = new System.Drawing.Point(525, 108);
            this.idcliTextBox.Name = "idcliTextBox";
            this.idcliTextBox.Size = new System.Drawing.Size(100, 20);
            this.idcliTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(55, 38);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(392, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(489, 38);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(145, 20);
            this.cnpjTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(91, 19);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(300, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(91, 45);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(300, 20);
            this.bairroTextBox.TabIndex = 10;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(91, 71);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 12;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(251, 71);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(140, 20);
            this.cepTextBox.TabIndex = 14;
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "uf", true));
            this.ufTextBox.Location = new System.Drawing.Point(91, 100);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(300, 20);
            this.ufTextBox.TabIndex = 16;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(88, 16);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(303, 20);
            this.telefoneTextBox.TabIndex = 18;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(88, 42);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(303, 20);
            this.faxTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(88, 68);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailTextBox.TabIndex = 22;
            // 
            // prefeitoTextBox
            // 
            this.prefeitoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "prefeito", true));
            this.prefeitoTextBox.Location = new System.Drawing.Point(91, 19);
            this.prefeitoTextBox.Name = "prefeitoTextBox";
            this.prefeitoTextBox.Size = new System.Drawing.Size(300, 20);
            this.prefeitoTextBox.TabIndex = 24;
            // 
            // educacaoTextBox
            // 
            this.educacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "educacao", true));
            this.educacaoTextBox.Location = new System.Drawing.Point(91, 45);
            this.educacaoTextBox.Name = "educacaoTextBox";
            this.educacaoTextBox.Size = new System.Drawing.Size(300, 20);
            this.educacaoTextBox.TabIndex = 26;
            // 
            // administracaoTextBox
            // 
            this.administracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "administracao", true));
            this.administracaoTextBox.Location = new System.Drawing.Point(91, 71);
            this.administracaoTextBox.Name = "administracaoTextBox";
            this.administracaoTextBox.Size = new System.Drawing.Size(300, 20);
            this.administracaoTextBox.TabIndex = 28;
            // 
            // coordenacaoTextBox
            // 
            this.coordenacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "coordenacao", true));
            this.coordenacaoTextBox.Location = new System.Drawing.Point(91, 97);
            this.coordenacaoTextBox.Name = "coordenacaoTextBox";
            this.coordenacaoTextBox.Size = new System.Drawing.Size(300, 20);
            this.coordenacaoTextBox.TabIndex = 30;
            // 
            // inscritosTextBox
            // 
            this.inscritosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "inscritos", true));
            this.inscritosTextBox.Location = new System.Drawing.Point(525, 186);
            this.inscritosTextBox.Name = "inscritosTextBox";
            this.inscritosTextBox.Size = new System.Drawing.Size(100, 20);
            this.inscritosTextBox.TabIndex = 32;
            // 
            // idpesTextBox
            // 
            this.idpesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "idpes", true));
            this.idpesTextBox.Location = new System.Drawing.Point(525, 212);
            this.idpesTextBox.Name = "idpesTextBox";
            this.idpesTextBox.Size = new System.Drawing.Size(100, 20);
            this.idpesTextBox.TabIndex = 34;
            // 
            // identificacaoTextBox
            // 
            this.identificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "identificacao", true));
            this.identificacaoTextBox.Location = new System.Drawing.Point(525, 238);
            this.identificacaoTextBox.Name = "identificacaoTextBox";
            this.identificacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificacaoTextBox.TabIndex = 36;
            // 
            // tab_produtosTextBox
            // 
            this.tab_produtosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tab_produtos", true));
            this.tab_produtosTextBox.Location = new System.Drawing.Point(525, 264);
            this.tab_produtosTextBox.Name = "tab_produtosTextBox";
            this.tab_produtosTextBox.Size = new System.Drawing.Size(100, 20);
            this.tab_produtosTextBox.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Controls.Add(this.ufTextBox);
            this.groupBox1.Controls.Add(ufLabel);
            this.groupBox1.Controls.Add(this.cepTextBox);
            this.groupBox1.Controls.Add(cepLabel);
            this.groupBox1.Controls.Add(this.cidadeTextBox);
            this.groupBox1.Controls.Add(cidadeLabel);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.bairroTextBox);
            this.groupBox1.Controls.Add(bairroLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 126);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereçamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prefeitoTextBox);
            this.groupBox2.Controls.Add(this.coordenacaoTextBox);
            this.groupBox2.Controls.Add(coordenacaoLabel);
            this.groupBox2.Controls.Add(this.administracaoTextBox);
            this.groupBox2.Controls.Add(administracaoLabel);
            this.groupBox2.Controls.Add(this.educacaoTextBox);
            this.groupBox2.Controls.Add(educacaoLabel);
            this.groupBox2.Controls.Add(prefeitoLabel);
            this.groupBox2.Location = new System.Drawing.Point(15, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 123);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Responsaveis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(telefoneLabel);
            this.groupBox3.Controls.Add(this.emailTextBox);
            this.groupBox3.Controls.Add(emailLabel);
            this.groupBox3.Controls.Add(this.faxTextBox);
            this.groupBox3.Controls.Add(faxLabel);
            this.groupBox3.Controls.Add(this.telefoneTextBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 100);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contatos";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(idcliLabel);
            this.Controls.Add(this.idcliTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(inscritosLabel);
            this.Controls.Add(this.inscritosTextBox);
            this.Controls.Add(idpesLabel);
            this.Controls.Add(this.idpesTextBox);
            this.Controls.Add(identificacaoLabel);
            this.Controls.Add(this.identificacaoTextBox);
            this.Controls.Add(tab_produtosLabel);
            this.Controls.Add(this.tab_produtosTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Name = "frmCadCliente";
            this.Text = "Cadastro da Prefeitura";
            this.Load += new System.EventHandler(this.cadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ieducarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ieducarDataSet ieducarDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ieducarDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private ieducarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idcliTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox prefeitoTextBox;
        private System.Windows.Forms.TextBox educacaoTextBox;
        private System.Windows.Forms.TextBox administracaoTextBox;
        private System.Windows.Forms.TextBox coordenacaoTextBox;
        private System.Windows.Forms.TextBox inscritosTextBox;
        private System.Windows.Forms.TextBox idpesTextBox;
        private System.Windows.Forms.TextBox identificacaoTextBox;
        private System.Windows.Forms.TextBox tab_produtosTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}