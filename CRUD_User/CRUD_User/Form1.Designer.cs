namespace CRUD_User
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textNickname = new System.Windows.Forms.TextBox();
            this.textCont = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolCancelar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NickName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-mail:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(115, 47);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(182, 20);
            this.textUsuario.TabIndex = 4;
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(115, 74);
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(182, 20);
            this.textNickname.TabIndex = 5;
            // 
            // textCont
            // 
            this.textCont.Location = new System.Drawing.Point(115, 100);
            this.textCont.Name = "textCont";
            this.textCont.Size = new System.Drawing.Size(182, 20);
            this.textCont.TabIndex = 6;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(115, 126);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(182, 20);
            this.textCorreo.TabIndex = 7;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 198);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(414, 297);
            this.dgvUsers.TabIndex = 8;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            this.dgvUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_RowEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregar,
            this.toolActualizar,
            this.toolBorrar,
            this.toolGuardar,
            this.toolCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAgregar
            // 
            this.toolAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolAgregar.Image")));
            this.toolAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAgregar.Name = "toolAgregar";
            this.toolAgregar.Size = new System.Drawing.Size(23, 22);
            this.toolAgregar.Text = "BtnAgregar";
            this.toolAgregar.ToolTipText = "Agregar Usuario";
            this.toolAgregar.Click += new System.EventHandler(this.toolAgregar_Click);
            // 
            // toolActualizar
            // 
            this.toolActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolActualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolActualizar.Image")));
            this.toolActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolActualizar.Name = "toolActualizar";
            this.toolActualizar.Size = new System.Drawing.Size(23, 22);
            this.toolActualizar.Text = "btnActualizar";
            this.toolActualizar.ToolTipText = "Actualizar Usuario";
            this.toolActualizar.Click += new System.EventHandler(this.toolActualizar_Click);
            // 
            // toolBorrar
            // 
            this.toolBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolBorrar.Image")));
            this.toolBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBorrar.Name = "toolBorrar";
            this.toolBorrar.Size = new System.Drawing.Size(23, 22);
            this.toolBorrar.Text = "btnBorrar";
            this.toolBorrar.ToolTipText = "Borrar Usuario";
            this.toolBorrar.Click += new System.EventHandler(this.toolBorrar_Click);
            // 
            // toolGuardar
            // 
            this.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolGuardar.Text = "toolStripButton5";
            this.toolGuardar.ToolTipText = "Guardar";
            this.toolGuardar.Click += new System.EventHandler(this.toolGuardar_Click);
            // 
            // toolCancelar
            // 
            this.toolCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolCancelar.Image")));
            this.toolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(23, 22);
            this.toolCancelar.Text = "btnCancelar";
            this.toolCancelar.ToolTipText = "Cancelar Opción";
            this.toolCancelar.Click += new System.EventHandler(this.toolCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 507);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textCont);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textNickname;
        private System.Windows.Forms.TextBox textCont;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolCancelar;
        private System.Windows.Forms.ToolStripButton toolAgregar;
        private System.Windows.Forms.ToolStripButton toolActualizar;
        private System.Windows.Forms.ToolStripButton toolBorrar;
        private System.Windows.Forms.ToolStripButton toolGuardar;
    }
}

