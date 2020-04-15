namespace chaos
{
    partial class main_frame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.output_panel = new System.Windows.Forms.Panel();
            this.UI_panel = new System.Windows.Forms.Panel();
            this.start_poin_button = new System.Windows.Forms.Button();
            this.set_triangle_1_button = new System.Windows.Forms.Button();
            this.space_lable = new System.Windows.Forms.Label();
            this.paly_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.paint_button = new System.Windows.Forms.Button();
            this.UI_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // output_panel
            // 
            this.output_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output_panel.Location = new System.Drawing.Point(194, 12);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(837, 703);
            this.output_panel.TabIndex = 0;
            this.output_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.output_panel_MouseDown);
            // 
            // UI_panel
            // 
            this.UI_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_panel.Controls.Add(this.start_poin_button);
            this.UI_panel.Controls.Add(this.set_triangle_1_button);
            this.UI_panel.Controls.Add(this.space_lable);
            this.UI_panel.Controls.Add(this.paly_button);
            this.UI_panel.Controls.Add(this.stop_button);
            this.UI_panel.Controls.Add(this.paint_button);
            this.UI_panel.Location = new System.Drawing.Point(12, 12);
            this.UI_panel.Name = "UI_panel";
            this.UI_panel.Size = new System.Drawing.Size(176, 578);
            this.UI_panel.TabIndex = 1;
            // 
            // start_poin_button
            // 
            this.start_poin_button.Location = new System.Drawing.Point(3, 446);
            this.start_poin_button.Name = "start_poin_button";
            this.start_poin_button.Size = new System.Drawing.Size(170, 39);
            this.start_poin_button.TabIndex = 8;
            this.start_poin_button.Text = "начальная точка";
            this.start_poin_button.UseVisualStyleBackColor = true;
            this.start_poin_button.Click += new System.EventHandler(this.start_poin_button_Click);
            // 
            // set_triangle_1_button
            // 
            this.set_triangle_1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_triangle_1_button.Location = new System.Drawing.Point(3, 356);
            this.set_triangle_1_button.Name = "set_triangle_1_button";
            this.set_triangle_1_button.Size = new System.Drawing.Size(170, 39);
            this.set_triangle_1_button.TabIndex = 1;
            this.set_triangle_1_button.Text = "добавить треугольник";
            this.set_triangle_1_button.UseVisualStyleBackColor = true;
            this.set_triangle_1_button.Click += new System.EventHandler(this.set_triangle_1_button_Click);
            // 
            // space_lable
            // 
            this.space_lable.BackColor = System.Drawing.SystemColors.WindowText;
            this.space_lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.space_lable.Location = new System.Drawing.Point(3, 0);
            this.space_lable.Name = "space_lable";
            this.space_lable.Size = new System.Drawing.Size(170, 353);
            this.space_lable.TabIndex = 6;
            // 
            // paly_button
            // 
            this.paly_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paly_button.Location = new System.Drawing.Point(3, 491);
            this.paly_button.Name = "paly_button";
            this.paly_button.Size = new System.Drawing.Size(170, 39);
            this.paly_button.TabIndex = 7;
            this.paly_button.Text = "старт/пауза";
            this.paly_button.UseVisualStyleBackColor = true;
            this.paly_button.Click += new System.EventHandler(this.paly_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.Location = new System.Drawing.Point(3, 536);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(170, 39);
            this.stop_button.TabIndex = 4;
            this.stop_button.Text = "стоп";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // paint_button
            // 
            this.paint_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paint_button.Location = new System.Drawing.Point(3, 401);
            this.paint_button.Name = "paint_button";
            this.paint_button.Size = new System.Drawing.Size(170, 39);
            this.paint_button.TabIndex = 3;
            this.paint_button.Text = "рисовать";
            this.paint_button.UseVisualStyleBackColor = true;
            this.paint_button.Click += new System.EventHandler(this.paint_button_Click);
            // 
            // main_frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 727);
            this.Controls.Add(this.UI_panel);
            this.Controls.Add(this.output_panel);
            this.Name = "main_frame";
            this.Text = "chaos";
            this.UI_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel output_panel;
        private System.Windows.Forms.Panel UI_panel;
        private System.Windows.Forms.Button set_triangle_1_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button paint_button;
        private System.Windows.Forms.Label space_lable;
        private System.Windows.Forms.Button paly_button;
        private System.Windows.Forms.Button start_poin_button;
    }
}

