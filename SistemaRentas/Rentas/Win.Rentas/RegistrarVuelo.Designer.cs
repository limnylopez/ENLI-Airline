namespace Win.Rentas
{
    partial class RegistrarVuelo
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label ciudaddestinoLabel;
            System.Windows.Forms.Label ciudadorigenLabel;
            System.Windows.Forms.Label fechavueloLabel;
            System.Windows.Forms.Label horasvueloLabel;
            System.Windows.Forms.Label idclaseLabel;
            System.Windows.Forms.Label idvueloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVuelo));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaRegistroVueloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaRegistroVueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaRegistroVueloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.ciudaddestinoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadorigenTextBox = new System.Windows.Forms.TextBox();
            this.fechavueloDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horasvueloTextBox = new System.Windows.Forms.TextBox();
            this.idclaseTextBox = new System.Windows.Forms.TextBox();
            this.idvueloTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            ciudaddestinoLabel = new System.Windows.Forms.Label();
            ciudadorigenLabel = new System.Windows.Forms.Label();
            fechavueloLabel = new System.Windows.Forms.Label();
            horasvueloLabel = new System.Windows.Forms.Label();
            idclaseLabel = new System.Windows.Forms.Label();
            idvueloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingNavigator)).BeginInit();
            this.listaRegistroVueloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(308, 533);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(89, 25);
            activoLabel.TabIndex = 15;
            activoLabel.Text = "ACTIVO";
            // 
            // ciudaddestinoLabel
            // 
            ciudaddestinoLabel.AutoSize = true;
            ciudaddestinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudaddestinoLabel.Location = new System.Drawing.Point(192, 393);
            ciudaddestinoLabel.Name = "ciudaddestinoLabel";
            ciudaddestinoLabel.Size = new System.Drawing.Size(188, 25);
            ciudaddestinoLabel.TabIndex = 17;
            ciudaddestinoLabel.Text = "CIUDAD DESTINO:";
            // 
            // ciudadorigenLabel
            // 
            ciudadorigenLabel.AutoSize = true;
            ciudadorigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadorigenLabel.Location = new System.Drawing.Point(192, 335);
            ciudadorigenLabel.Name = "ciudadorigenLabel";
            ciudadorigenLabel.Size = new System.Drawing.Size(175, 25);
            ciudadorigenLabel.TabIndex = 19;
            ciudadorigenLabel.Text = "CIUDAD ORIGEN:";
            // 
            // fechavueloLabel
            // 
            fechavueloLabel.AutoSize = true;
            fechavueloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechavueloLabel.Location = new System.Drawing.Point(192, 457);
            fechavueloLabel.Name = "fechavueloLabel";
            fechavueloLabel.Size = new System.Drawing.Size(191, 25);
            fechavueloLabel.TabIndex = 21;
            fechavueloLabel.Text = "FECHA DE VUELO:";
            // 
            // horasvueloLabel
            // 
            horasvueloLabel.AutoSize = true;
            horasvueloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horasvueloLabel.Location = new System.Drawing.Point(192, 283);
            horasvueloLabel.Name = "horasvueloLabel";
            horasvueloLabel.Size = new System.Drawing.Size(137, 25);
            horasvueloLabel.TabIndex = 23;
            horasvueloLabel.Text = "HRS. VUELO:";
            // 
            // idclaseLabel
            // 
            idclaseLabel.AutoSize = true;
            idclaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idclaseLabel.Location = new System.Drawing.Point(192, 229);
            idclaseLabel.Name = "idclaseLabel";
            idclaseLabel.Size = new System.Drawing.Size(85, 25);
            idclaseLabel.TabIndex = 25;
            idclaseLabel.Text = "CLASE:";
            // 
            // idvueloLabel
            // 
            idvueloLabel.AutoSize = true;
            idvueloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idvueloLabel.Location = new System.Drawing.Point(192, 179);
            idvueloLabel.Name = "idvueloLabel";
            idvueloLabel.Size = new System.Drawing.Size(110, 25);
            idvueloLabel.TabIndex = 27;
            idvueloLabel.Text = "ID VUELO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "ENLI AIRLINE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "REGISTRO DE VUELOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(552, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 102);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listaRegistroVueloBindingNavigator
            // 
            this.listaRegistroVueloBindingNavigator.AddNewItem = null;
            this.listaRegistroVueloBindingNavigator.BindingSource = this.listaRegistroVueloBindingSource;
            this.listaRegistroVueloBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaRegistroVueloBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaRegistroVueloBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaRegistroVueloBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaRegistroVueloBindingNavigatorSaveItem,
            this.cancelar});
            this.listaRegistroVueloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaRegistroVueloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaRegistroVueloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaRegistroVueloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaRegistroVueloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaRegistroVueloBindingNavigator.Name = "listaRegistroVueloBindingNavigator";
            this.listaRegistroVueloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaRegistroVueloBindingNavigator.Size = new System.Drawing.Size(881, 27);
            this.listaRegistroVueloBindingNavigator.TabIndex = 15;
            this.listaRegistroVueloBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaRegistroVueloBindingSource
            // 
            this.listaRegistroVueloBindingSource.DataSource = typeof(BL.Rentas.RegistrarVuelo);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // listaRegistroVueloBindingNavigatorSaveItem
            // 
            this.listaRegistroVueloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaRegistroVueloBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaRegistroVueloBindingNavigatorSaveItem.Image")));
            this.listaRegistroVueloBindingNavigatorSaveItem.Name = "listaRegistroVueloBindingNavigatorSaveItem";
            this.listaRegistroVueloBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaRegistroVueloBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaRegistroVueloBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaRegistroVueloBindingNavigatorSaveItem_Click);
            // 
            // cancelar
            // 
            this.cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(70, 24);
            this.cancelar.Text = "Cancelar";
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaRegistroVueloBindingSource, "activo", true));
            this.activoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(413, 533);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 16;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ciudaddestinoTextBox
            // 
            this.ciudaddestinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "ciudaddestino", true));
            this.ciudaddestinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudaddestinoTextBox.Location = new System.Drawing.Point(413, 393);
            this.ciudaddestinoTextBox.Name = "ciudaddestinoTextBox";
            this.ciudaddestinoTextBox.Size = new System.Drawing.Size(391, 30);
            this.ciudaddestinoTextBox.TabIndex = 18;
            // 
            // ciudadorigenTextBox
            // 
            this.ciudadorigenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "ciudadorigen", true));
            this.ciudadorigenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadorigenTextBox.Location = new System.Drawing.Point(413, 335);
            this.ciudadorigenTextBox.Name = "ciudadorigenTextBox";
            this.ciudadorigenTextBox.Size = new System.Drawing.Size(391, 30);
            this.ciudadorigenTextBox.TabIndex = 20;
            // 
            // fechavueloDateTimePicker
            // 
            this.fechavueloDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaRegistroVueloBindingSource, "fechavuelo", true));
            this.fechavueloDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechavueloDateTimePicker.Location = new System.Drawing.Point(413, 452);
            this.fechavueloDateTimePicker.Name = "fechavueloDateTimePicker";
            this.fechavueloDateTimePicker.Size = new System.Drawing.Size(391, 30);
            this.fechavueloDateTimePicker.TabIndex = 22;
            // 
            // horasvueloTextBox
            // 
            this.horasvueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "horasvuelo", true));
            this.horasvueloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horasvueloTextBox.Location = new System.Drawing.Point(413, 283);
            this.horasvueloTextBox.Name = "horasvueloTextBox";
            this.horasvueloTextBox.Size = new System.Drawing.Size(200, 30);
            this.horasvueloTextBox.TabIndex = 24;
            // 
            // idclaseTextBox
            // 
            this.idclaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "idclase", true));
            this.idclaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idclaseTextBox.Location = new System.Drawing.Point(413, 229);
            this.idclaseTextBox.Name = "idclaseTextBox";
            this.idclaseTextBox.Size = new System.Drawing.Size(200, 30);
            this.idclaseTextBox.TabIndex = 26;
            // 
            // idvueloTextBox
            // 
            this.idvueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "idvuelo", true));
            this.idvueloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idvueloTextBox.Location = new System.Drawing.Point(413, 179);
            this.idvueloTextBox.Name = "idvueloTextBox";
            this.idvueloTextBox.ReadOnly = true;
            this.idvueloTextBox.Size = new System.Drawing.Size(200, 30);
            this.idvueloTextBox.TabIndex = 28;
            // 
            // RegistrarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 596);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(ciudaddestinoLabel);
            this.Controls.Add(this.ciudaddestinoTextBox);
            this.Controls.Add(ciudadorigenLabel);
            this.Controls.Add(this.ciudadorigenTextBox);
            this.Controls.Add(fechavueloLabel);
            this.Controls.Add(this.fechavueloDateTimePicker);
            this.Controls.Add(horasvueloLabel);
            this.Controls.Add(this.horasvueloTextBox);
            this.Controls.Add(idclaseLabel);
            this.Controls.Add(this.idclaseTextBox);
            this.Controls.Add(idvueloLabel);
            this.Controls.Add(this.idvueloTextBox);
            this.Controls.Add(this.listaRegistroVueloBindingNavigator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarVuelo";
            this.Text = "RegistrarVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingNavigator)).EndInit();
            this.listaRegistroVueloBindingNavigator.ResumeLayout(false);
            this.listaRegistroVueloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource listaRegistroVueloBindingSource;
        private System.Windows.Forms.BindingNavigator listaRegistroVueloBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaRegistroVueloBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton cancelar;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox ciudaddestinoTextBox;
        private System.Windows.Forms.TextBox ciudadorigenTextBox;
        private System.Windows.Forms.DateTimePicker fechavueloDateTimePicker;
        private System.Windows.Forms.TextBox horasvueloTextBox;
        private System.Windows.Forms.TextBox idclaseTextBox;
        private System.Windows.Forms.TextBox idvueloTextBox;
    }
}