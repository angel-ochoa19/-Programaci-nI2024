namespace PruebaCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_acep = new Button();
            label1 = new Label();
            textBox_nom = new TextBox();
            dataGridView1 = new DataGridView();
            textBox_edad = new TextBox();
            label2 = new Label();
            textBox_Num = new TextBox();
            label3 = new Label();
            button_eli_persona = new Button();
            button_eliminar = new Button();
            textBox_id = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_acep
            // 
            button_acep.Location = new Point(100, 249);
            button_acep.Name = "button_acep";
            button_acep.Size = new Size(127, 38);
            button_acep.TabIndex = 0;
            button_acep.Text = "Aceptar / Guardar";
            button_acep.UseVisualStyleBackColor = true;
            button_acep.Click += button_acep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 137);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(127, 136);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(100, 23);
            textBox_nom.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 332);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBox_edad
            // 
            textBox_edad.Location = new Point(127, 181);
            textBox_edad.Name = "textBox_edad";
            textBox_edad.Size = new Size(100, 23);
            textBox_edad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 181);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // textBox_Num
            // 
            textBox_Num.Location = new Point(127, 220);
            textBox_Num.Name = "textBox_Num";
            textBox_Num.Size = new Size(100, 23);
            textBox_Num.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 220);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Numero";
            // 
            // button_eli_persona
            // 
            button_eli_persona.Location = new Point(100, 304);
            button_eli_persona.Name = "button_eli_persona";
            button_eli_persona.Size = new Size(127, 38);
            button_eli_persona.TabIndex = 8;
            button_eli_persona.Text = "Eliminar";
            button_eli_persona.UseVisualStyleBackColor = true;
            button_eli_persona.Click += button1_Click;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(100, 364);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(127, 36);
            button_eliminar.TabIndex = 9;
            button_eliminar.Text = "Limpiar pantalla";
            button_eliminar.UseVisualStyleBackColor = true;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // textBox_id
            // 
            textBox_id.Enabled = false;
            textBox_id.Location = new Point(127, 90);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 91);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_id);
            Controls.Add(label4);
            Controls.Add(button_eliminar);
            Controls.Add(button_eli_persona);
            Controls.Add(textBox_Num);
            Controls.Add(label3);
            Controls.Add(textBox_edad);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_nom);
            Controls.Add(label1);
            Controls.Add(button_acep);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_acep;
        private Label label1;
        private TextBox textBox_nom;
        private DataGridView dataGridView1;
        private TextBox textBox_edad;
        private Label label2;
        private TextBox textBox_Num;
        private Label label3;
        private Button button_eli_persona;
        private Button button_eliminar;
        private TextBox textBox_id;
        private Label label4;


    }
}
