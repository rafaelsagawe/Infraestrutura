namespace alimentacaoIeducar
{
    partial class cadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCliente));
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
            this.ieducarDataSet = new alimentacaoIeducar.ieducarDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new alimentacaoIeducar.ieducarDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new alimentacaoIeducar.ieducarDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            this.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = alimentacaoIeducar.ieducarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(549, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // idcliLabel
            // 
            idcliLabel.AutoSize = true;
            idcliLabel.Location = new System.Drawing.Point(56, 54);
            idcliLabel.Name = "idcliLabel";
            idcliLabel.Size = new System.Drawing.Size(28, 13);
            idcliLabel.TabIndex = 1;
            idcliLabel.Text = "idcli:";
            // 
            // idcliTextBox
            // 
            this.idcliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "idcli", true));
            this.idcliTextBox.Location = new System.Drawing.Point(137, 51);
            this.idcliTextBox.Name = "idcliTextBox";
            this.idcliTextBox.Size = new System.Drawing.Size(100, 20);
            this.idcliTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(56, 80);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(137, 77);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(56, 106);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(30, 13);
            cnpjLabel.TabIndex = 5;
            cnpjLabel.Text = "cnpj:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(137, 103);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpjTextBox.TabIndex = 6;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(56, 132);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(137, 129);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(56, 158);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "bairro:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(137, 155);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTextBox.TabIndex = 10;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(56, 184);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 11;
            cidadeLabel.Text = "cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(137, 181);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 12;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(56, 210);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 13;
            cepLabel.Text = "cep:";
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(137, 207);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepTextBox.TabIndex = 14;
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(56, 236);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 15;
            ufLabel.Text = "uf:";
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "uf", true));
            this.ufTextBox.Location = new System.Drawing.Point(137, 233);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(100, 20);
            this.ufTextBox.TabIndex = 16;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(283, 51);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 17;
            telefoneLabel.Text = "telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(364, 48);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 18;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(283, 77);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(24, 13);
            faxLabel.TabIndex = 19;
            faxLabel.Text = "fax:";
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(364, 74);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(100, 20);
            this.faxTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(283, 103);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(364, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 22;
            // 
            // prefeitoLabel
            // 
            prefeitoLabel.AutoSize = true;
            prefeitoLabel.Location = new System.Drawing.Point(283, 129);
            prefeitoLabel.Name = "prefeitoLabel";
            prefeitoLabel.Size = new System.Drawing.Size(45, 13);
            prefeitoLabel.TabIndex = 23;
            prefeitoLabel.Text = "prefeito:";
            // 
            // prefeitoTextBox
            // 
            this.prefeitoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "prefeito", true));
            this.prefeitoTextBox.Location = new System.Drawing.Point(364, 126);
            this.prefeitoTextBox.Name = "prefeitoTextBox";
            this.prefeitoTextBox.Size = new System.Drawing.Size(100, 20);
            this.prefeitoTextBox.TabIndex = 24;
            // 
            // educacaoLabel
            // 
            educacaoLabel.AutoSize = true;
            educacaoLabel.Location = new System.Drawing.Point(283, 155);
            educacaoLabel.Name = "educacaoLabel";
            educacaoLabel.Size = new System.Drawing.Size(58, 13);
            educacaoLabel.TabIndex = 25;
            educacaoLabel.Text = "educacao:";
            // 
            // educacaoTextBox
            // 
            this.educacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "educacao", true));
            this.educacaoTextBox.Location = new System.Drawing.Point(364, 152);
            this.educacaoTextBox.Name = "educacaoTextBox";
            this.educacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.educacaoTextBox.TabIndex = 26;
            // 
            // administracaoLabel
            // 
            administracaoLabel.AutoSize = true;
            administracaoLabel.Location = new System.Drawing.Point(283, 181);
            administracaoLabel.Name = "administracaoLabel";
            administracaoLabel.Size = new System.Drawing.Size(75, 13);
            administracaoLabel.TabIndex = 27;
            administracaoLabel.Text = "administracao:";
            // 
            // administracaoTextBox
            // 
            this.administracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "administracao", true));
            this.administracaoTextBox.Location = new System.Drawing.Point(364, 178);
            this.administracaoTextBox.Name = "administracaoTextBox";
            this.administracaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.administracaoTextBox.TabIndex = 28;
            // 
            // coordenacaoLabel
            // 
            coordenacaoLabel.AutoSize = true;
            coordenacaoLabel.Location = new System.Drawing.Point(283, 207);
            coordenacaoLabel.Name = "coordenacaoLabel";
            coordenacaoLabel.Size = new System.Drawing.Size(73, 13);
            coordenacaoLabel.TabIndex = 29;
            coordenacaoLabel.Text = "coordenacao:";
            // 
            // coordenacaoTextBox
            // 
            this.coordenacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "coordenacao", true));
            this.coordenacaoTextBox.Location = new System.Drawing.Point(364, 204);
            this.coordenacaoTextBox.Name = "coordenacaoTextBox";
            this.coordenacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.coordenacaoTextBox.TabIndex = 30;
            // 
            // inscritosLabel
            // 
            inscritosLabel.AutoSize = true;
            inscritosLabel.Location = new System.Drawing.Point(283, 233);
            inscritosLabel.Name = "inscritosLabel";
            inscritosLabel.Size = new System.Drawing.Size(48, 13);
            inscritosLabel.TabIndex = 31;
            inscritosLabel.Text = "inscritos:";
            // 
            // inscritosTextBox
            // 
            this.inscritosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "inscritos", true));
            this.inscritosTextBox.Location = new System.Drawing.Point(364, 230);
            this.inscritosTextBox.Name = "inscritosTextBox";
            this.inscritosTextBox.Size = new System.Drawing.Size(100, 20);
            this.inscritosTextBox.TabIndex = 32;
            // 
            // idpesLabel
            // 
            idpesLabel.AutoSize = true;
            idpesLabel.Location = new System.Drawing.Point(283, 259);
            idpesLabel.Name = "idpesLabel";
            idpesLabel.Size = new System.Drawing.Size(35, 13);
            idpesLabel.TabIndex = 33;
            idpesLabel.Text = "idpes:";
            // 
            // idpesTextBox
            // 
            this.idpesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "idpes", true));
            this.idpesTextBox.Location = new System.Drawing.Point(364, 256);
            this.idpesTextBox.Name = "idpesTextBox";
            this.idpesTextBox.Size = new System.Drawing.Size(100, 20);
            this.idpesTextBox.TabIndex = 34;
            // 
            // identificacaoLabel
            // 
            identificacaoLabel.AutoSize = true;
            identificacaoLabel.Location = new System.Drawing.Point(283, 285);
            identificacaoLabel.Name = "identificacaoLabel";
            identificacaoLabel.Size = new System.Drawing.Size(70, 13);
            identificacaoLabel.TabIndex = 35;
            identificacaoLabel.Text = "identificacao:";
            // 
            // identificacaoTextBox
            // 
            this.identificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "identificacao", true));
            this.identificacaoTextBox.Location = new System.Drawing.Point(364, 282);
            this.identificacaoTextBox.Name = "identificacaoTextBox";
            this.identificacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificacaoTextBox.TabIndex = 36;
            // 
            // tab_produtosLabel
            // 
            tab_produtosLabel.AutoSize = true;
            tab_produtosLabel.Location = new System.Drawing.Point(283, 311);
            tab_produtosLabel.Name = "tab_produtosLabel";
            tab_produtosLabel.Size = new System.Drawing.Size(69, 13);
            tab_produtosLabel.TabIndex = 37;
            tab_produtosLabel.Text = "tab produtos:";
            // 
            // tab_produtosTextBox
            // 
            this.tab_produtosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tab_produtos", true));
            this.tab_produtosTextBox.Location = new System.Drawing.Point(364, 308);
            this.tab_produtosTextBox.Name = "tab_produtosTextBox";
            this.tab_produtosTextBox.Size = new System.Drawing.Size(100, 20);
            this.tab_produtosTextBox.TabIndex = 38;
            // 
            // cadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 365);
            this.Controls.Add(idcliLabel);
            this.Controls.Add(this.idcliTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(prefeitoLabel);
            this.Controls.Add(this.prefeitoTextBox);
            this.Controls.Add(educacaoLabel);
            this.Controls.Add(this.educacaoTextBox);
            this.Controls.Add(administracaoLabel);
            this.Controls.Add(this.administracaoTextBox);
            this.Controls.Add(coordenacaoLabel);
            this.Controls.Add(this.coordenacaoTextBox);
            this.Controls.Add(inscritosLabel);
            this.Controls.Add(this.inscritosTextBox);
            this.Controls.Add(idpesLabel);
            this.Controls.Add(this.idpesTextBox);
            this.Controls.Add(identificacaoLabel);
            this.Controls.Add(this.identificacaoTextBox);
            this.Controls.Add(tab_produtosLabel);
            this.Controls.Add(this.tab_produtosTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Name = "cadCliente";
            this.Text = "cadCliente";
            this.Load += new System.EventHandler(this.cadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ieducarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ieducarDataSet ieducarDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ieducarDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private ieducarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
    }
}