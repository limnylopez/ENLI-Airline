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
            System.Windows.Forms.Label capacidadcargaLabel;
            System.Windows.Forms.Label capacidadpasajeroLabel;
            System.Windows.Forms.Label idavionLabel;
            System.Windows.Forms.Label matriculaavionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVuelo));
            this.listaRegistroVueloBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.listaRegistroVueloBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.capacidadcargaTextBox = new System.Windows.Forms.TextBox();
            this.capacidadpasajeroTextBox = new System.Windows.Forms.TextBox();
            this.idavionTextBox = new System.Windows.Forms.TextBox();
            this.matriculaavionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            activoLabel = new System.Windows.Forms.Label();
            capacidadcargaLabel = new System.Windows.Forms.Label();
            capacidadpasajeroLabel = new System.Windows.Forms.Label();
            idavionLabel = new System.Windows.Forms.Label();
            matriculaavionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingNavigator)).BeginInit();
            this.listaRegistroVueloBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaRegistroVueloBindingNavigator
            // 
            this.listaRegistroVueloBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.listaRegistroVueloBindingNavigatorSaveItem});
            this.listaRegistroVueloBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaRegistroVueloBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaRegistroVueloBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaRegistroVueloBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaRegistroVueloBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaRegistroVueloBindingNavigator.Name = "listaRegistroVueloBindingNavigator";
            this.listaRegistroVueloBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaRegistroVueloBindingNavigator.Size = new System.Drawing.Size(881, 27);
            this.listaRegistroVueloBindingNavigator.TabIndex = 0;
            this.listaRegistroVueloBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
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
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listaRegistroVueloBindingNavigatorSaveItem
            // 
            this.listaRegistroVueloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaRegistroVueloBindingNavigatorSaveItem.Enabled = false;
            this.listaRegistroVueloBindingNavigatorSaveItem.Name = "listaRegistroVueloBindingNavigatorSaveItem";
            this.listaRegistroVueloBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.listaRegistroVueloBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(259, 456);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaRegistroVueloBindingSource, "activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(464, 453);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // capacidadcargaLabel
            // 
            capacidadcargaLabel.AutoSize = true;
            capacidadcargaLabel.Location = new System.Drawing.Point(259, 384);
            capacidadcargaLabel.Name = "capacidadcargaLabel";
            capacidadcargaLabel.Size = new System.Drawing.Size(191, 17);
            capacidadcargaLabel.TabIndex = 3;
            capacidadcargaLabel.Text = "Capacidad de carga en kilos:";
            // 
            // capacidadcargaTextBox
            // 
            this.capacidadcargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "capacidadcarga", true));
            this.capacidadcargaTextBox.Location = new System.Drawing.Point(464, 379);
            this.capacidadcargaTextBox.Name = "capacidadcargaTextBox";
            this.capacidadcargaTextBox.Size = new System.Drawing.Size(175, 22);
            this.capacidadcargaTextBox.TabIndex = 4;
            // 
            // capacidadpasajeroLabel
            // 
            capacidadpasajeroLabel.AutoSize = true;
            capacidadpasajeroLabel.Location = new System.Drawing.Point(259, 322);
            capacidadpasajeroLabel.Name = "capacidadpasajeroLabel";
            capacidadpasajeroLabel.Size = new System.Drawing.Size(165, 17);
            capacidadpasajeroLabel.TabIndex = 5;
            capacidadpasajeroLabel.Text = "Capacidad de pasajeros:";
            // 
            // capacidadpasajeroTextBox
            // 
            this.capacidadpasajeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "capacidadpasajero", true));
            this.capacidadpasajeroTextBox.Location = new System.Drawing.Point(464, 319);
            this.capacidadpasajeroTextBox.Name = "capacidadpasajeroTextBox";
            this.capacidadpasajeroTextBox.Size = new System.Drawing.Size(175, 22);
            this.capacidadpasajeroTextBox.TabIndex = 6;
            // 
            // idavionLabel
            // 
            idavionLabel.AutoSize = true;
            idavionLabel.Location = new System.Drawing.Point(259, 197);
            idavionLabel.Name = "idavionLabel";
            idavionLabel.Size = new System.Drawing.Size(25, 17);
            idavionLabel.TabIndex = 7;
            idavionLabel.Text = "ID:";
            // 
            // idavionTextBox
            // 
            this.idavionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "idavion", true));
            this.idavionTextBox.Location = new System.Drawing.Point(464, 194);
            this.idavionTextBox.Name = "idavionTextBox";
            this.idavionTextBox.Size = new System.Drawing.Size(175, 22);
            this.idavionTextBox.TabIndex = 8;
            // 
            // matriculaavionLabel
            // 
            matriculaavionLabel.AutoSize = true;
            matriculaavionLabel.Location = new System.Drawing.Point(259, 261);
            matriculaavionLabel.Name = "matriculaavionLabel";
            matriculaavionLabel.Size = new System.Drawing.Size(128, 17);
            matriculaavionLabel.TabIndex = 9;
            matriculaavionLabel.Text = "Matricula de Avión:";
            // 
            // matriculaavionTextBox
            // 
            this.matriculaavionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRegistroVueloBindingSource, "matriculaavion", true));
            this.matriculaavionTextBox.Location = new System.Drawing.Point(464, 261);
            this.matriculaavionTextBox.Name = "matriculaavionTextBox";
            this.matriculaavionTextBox.Size = new System.Drawing.Size(175, 22);
            this.matriculaavionTextBox.TabIndex = 10;
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
            // RegistrarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(capacidadcargaLabel);
            this.Controls.Add(this.capacidadcargaTextBox);
            this.Controls.Add(capacidadpasajeroLabel);
            this.Controls.Add(this.capacidadpasajeroTextBox);
            this.Controls.Add(idavionLabel);
            this.Controls.Add(this.idavionTextBox);
            this.Controls.Add(matriculaavionLabel);
            this.Controls.Add(this.matriculaavionTextBox);
            this.Controls.Add(this.listaRegistroVueloBindingNavigator);
            this.Name = "RegistrarVuelo";
            this.Text = "RegistrarVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingNavigator)).EndInit();
            this.listaRegistroVueloBindingNavigator.ResumeLayout(false);
            this.listaRegistroVueloBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistroVueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox capacidadcargaTextBox;
        private System.Windows.Forms.TextBox capacidadpasajeroTextBox;
        private System.Windows.Forms.TextBox idavionTextBox;
        private System.Windows.Forms.TextBox matriculaavionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}