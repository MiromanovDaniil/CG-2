
namespace CG_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.start_scale = new System.Windows.Forms.Button();
            this.vector_shift = new System.Windows.Forms.Button();
            this.P1_x = new System.Windows.Forms.TextBox();
            this.P1_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.figure_scaling = new System.Windows.Forms.Button();
            this.P2_k = new System.Windows.Forms.TextBox();
            this.P2_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rotation_relatively_dot = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.P3_y = new System.Windows.Forms.TextBox();
            this.P3_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.P3_deg = new System.Windows.Forms.TextBox();
            this.P4_deg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rotation_relatively_center = new System.Windows.Forms.Button();
            this.reflection_OX = new System.Windows.Forms.Button();
            this.reflection_OY = new System.Windows.Forms.Button();
            this.reflection_y_eql_x = new System.Windows.Forms.Button();
            this.start_fugure_position = new System.Windows.Forms.Button();
            this.WalkAnimation = new System.Windows.Forms.Button();
            this.Draw_Human = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.vector_shift_Human = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Human_scaling = new System.Windows.Forms.Button();
            this.rotation_Human_relatively_dot = new System.Windows.Forms.Button();
            this.rotation_Human_relatively_center = new System.Windows.Forms.Button();
            this.reflection_Human_OX = new System.Windows.Forms.Button();
            this.reflection_Human_OY = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 29);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.PanModifierKeys = System.Windows.Forms.Keys.None;
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(715, 579);
            this.zedGraph.TabIndex = 0;
            // 
            // start_scale
            // 
            this.start_scale.Location = new System.Drawing.Point(877, 552);
            this.start_scale.Name = "start_scale";
            this.start_scale.Size = new System.Drawing.Size(130, 56);
            this.start_scale.TabIndex = 1;
            this.start_scale.Text = "Исходный масштаб";
            this.start_scale.UseVisualStyleBackColor = true;
            this.start_scale.Click += new System.EventHandler(this.start_scale_Click);
            // 
            // vector_shift
            // 
            this.vector_shift.Location = new System.Drawing.Point(733, 45);
            this.vector_shift.Name = "vector_shift";
            this.vector_shift.Size = new System.Drawing.Size(122, 58);
            this.vector_shift.TabIndex = 2;
            this.vector_shift.Text = "Сдивг на вектор (x,y)";
            this.vector_shift.UseVisualStyleBackColor = true;
            this.vector_shift.Click += new System.EventHandler(this.vector_shift_Click);
            // 
            // P1_x
            // 
            this.P1_x.Location = new System.Drawing.Point(937, 45);
            this.P1_x.Name = "P1_x";
            this.P1_x.Size = new System.Drawing.Size(100, 20);
            this.P1_x.TabIndex = 3;
            // 
            // P1_y
            // 
            this.P1_y.Location = new System.Drawing.Point(937, 83);
            this.P1_y.Name = "P1_y";
            this.P1_y.Size = new System.Drawing.Size(100, 20);
            this.P1_y.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "x = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(905, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "y = ";
            // 
            // figure_scaling
            // 
            this.figure_scaling.Location = new System.Drawing.Point(733, 131);
            this.figure_scaling.Name = "figure_scaling";
            this.figure_scaling.Size = new System.Drawing.Size(138, 64);
            this.figure_scaling.TabIndex = 7;
            this.figure_scaling.Text = "Масштабирование \r\nпо осям\r\n";
            this.figure_scaling.UseVisualStyleBackColor = true;
            this.figure_scaling.Click += new System.EventHandler(this.figure_scaling_Click);
            // 
            // P2_k
            // 
            this.P2_k.Location = new System.Drawing.Point(937, 131);
            this.P2_k.Name = "P2_k";
            this.P2_k.Size = new System.Drawing.Size(100, 20);
            this.P2_k.TabIndex = 8;
            // 
            // P2_m
            // 
            this.P2_m.Location = new System.Drawing.Point(937, 178);
            this.P2_m.Name = "P2_m";
            this.P2_m.Size = new System.Drawing.Size(100, 20);
            this.P2_m.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "k = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "m = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(959, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "По X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "По Y";
            // 
            // rotation_relatively_dot
            // 
            this.rotation_relatively_dot.Location = new System.Drawing.Point(733, 224);
            this.rotation_relatively_dot.Name = "rotation_relatively_dot";
            this.rotation_relatively_dot.Size = new System.Drawing.Size(138, 74);
            this.rotation_relatively_dot.TabIndex = 14;
            this.rotation_relatively_dot.Text = "Поворот на угол \r\nотносительно \r\nточки\r\n\r\n";
            this.rotation_relatively_dot.UseVisualStyleBackColor = true;
            this.rotation_relatively_dot.Click += new System.EventHandler(this.rotation_relatively_dot_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(905, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "x = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "y = ";
            // 
            // P3_y
            // 
            this.P3_y.Location = new System.Drawing.Point(937, 252);
            this.P3_y.Name = "P3_y";
            this.P3_y.Size = new System.Drawing.Size(100, 20);
            this.P3_y.TabIndex = 16;
            // 
            // P3_x
            // 
            this.P3_x.Location = new System.Drawing.Point(937, 224);
            this.P3_x.Name = "P3_x";
            this.P3_x.Size = new System.Drawing.Size(100, 20);
            this.P3_x.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "deg = ";
            // 
            // P3_deg
            // 
            this.P3_deg.Location = new System.Drawing.Point(937, 278);
            this.P3_deg.Name = "P3_deg";
            this.P3_deg.Size = new System.Drawing.Size(100, 20);
            this.P3_deg.TabIndex = 21;
            // 
            // P4_deg
            // 
            this.P4_deg.Location = new System.Drawing.Point(937, 345);
            this.P4_deg.Name = "P4_deg";
            this.P4_deg.Size = new System.Drawing.Size(100, 20);
            this.P4_deg.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "deg = ";
            // 
            // rotation_relatively_center
            // 
            this.rotation_relatively_center.Location = new System.Drawing.Point(733, 322);
            this.rotation_relatively_center.Name = "rotation_relatively_center";
            this.rotation_relatively_center.Size = new System.Drawing.Size(138, 64);
            this.rotation_relatively_center.TabIndex = 22;
            this.rotation_relatively_center.Text = "Поворот на угол \r\nотносительно \r\nцентра\r\n\r\n\r\n";
            this.rotation_relatively_center.UseVisualStyleBackColor = true;
            this.rotation_relatively_center.Click += new System.EventHandler(this.rotation_relatively_center_Click);
            // 
            // reflection_OX
            // 
            this.reflection_OX.Location = new System.Drawing.Point(733, 401);
            this.reflection_OX.Name = "reflection_OX";
            this.reflection_OX.Size = new System.Drawing.Size(138, 64);
            this.reflection_OX.TabIndex = 29;
            this.reflection_OX.Text = "Отражение \r\nотносительно \r\nOX\r\n\r\n\r\n\r\n";
            this.reflection_OX.UseVisualStyleBackColor = true;
            this.reflection_OX.Click += new System.EventHandler(this.reflection_OX_Click);
            // 
            // reflection_OY
            // 
            this.reflection_OY.Location = new System.Drawing.Point(877, 401);
            this.reflection_OY.Name = "reflection_OY";
            this.reflection_OY.Size = new System.Drawing.Size(139, 64);
            this.reflection_OY.TabIndex = 30;
            this.reflection_OY.Text = "Отражение \r\nотносительно \r\nOY\r\n\r\n\r\n\r\n";
            this.reflection_OY.UseVisualStyleBackColor = true;
            this.reflection_OY.Click += new System.EventHandler(this.reflection_OY_Click);
            // 
            // reflection_y_eql_x
            // 
            this.reflection_y_eql_x.Location = new System.Drawing.Point(801, 471);
            this.reflection_y_eql_x.Name = "reflection_y_eql_x";
            this.reflection_y_eql_x.Size = new System.Drawing.Size(136, 64);
            this.reflection_y_eql_x.TabIndex = 31;
            this.reflection_y_eql_x.Text = "Отражение относительно \r\nпрямой Y=X";
            this.reflection_y_eql_x.UseVisualStyleBackColor = true;
            this.reflection_y_eql_x.Click += new System.EventHandler(this.reflection_y_eql_x_Click);
            // 
            // start_fugure_position
            // 
            this.start_fugure_position.Location = new System.Drawing.Point(733, 552);
            this.start_fugure_position.Name = "start_fugure_position";
            this.start_fugure_position.Size = new System.Drawing.Size(124, 56);
            this.start_fugure_position.TabIndex = 33;
            this.start_fugure_position.Text = "Начальное положение \r\nфигуры\r\n";
            this.start_fugure_position.UseVisualStyleBackColor = true;
            this.start_fugure_position.Click += new System.EventHandler(this.start_fugure_position_Click);
            // 
            // WalkAnimation
            // 
            this.WalkAnimation.Location = new System.Drawing.Point(1262, 128);
            this.WalkAnimation.Name = "WalkAnimation";
            this.WalkAnimation.Size = new System.Drawing.Size(136, 65);
            this.WalkAnimation.TabIndex = 34;
            this.WalkAnimation.Text = "Ходьба";
            this.WalkAnimation.UseVisualStyleBackColor = true;
            this.WalkAnimation.Click += new System.EventHandler(this.WalkAnimation_Click);
            // 
            // Draw_Human
            // 
            this.Draw_Human.Location = new System.Drawing.Point(1262, 45);
            this.Draw_Human.Name = "Draw_Human";
            this.Draw_Human.Size = new System.Drawing.Size(136, 56);
            this.Draw_Human.TabIndex = 35;
            this.Draw_Human.Text = "Начальное положение человечка";
            this.Draw_Human.UseVisualStyleBackColor = true;
            this.Draw_Human.Click += new System.EventHandler(this.Draw_Human_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Для фигуры";
            // 
            // vector_shift_Human
            // 
            this.vector_shift_Human.Location = new System.Drawing.Point(1085, 45);
            this.vector_shift_Human.Name = "vector_shift_Human";
            this.vector_shift_Human.Size = new System.Drawing.Size(122, 58);
            this.vector_shift_Human.TabIndex = 37;
            this.vector_shift_Human.Text = "Сдивг на вектор (x,y)";
            this.vector_shift_Human.UseVisualStyleBackColor = true;
            this.vector_shift_Human.Click += new System.EventHandler(this.vector_shift_Human_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1101, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Для человечка";
            // 
            // Human_scaling
            // 
            this.Human_scaling.Location = new System.Drawing.Point(1085, 131);
            this.Human_scaling.Name = "Human_scaling";
            this.Human_scaling.Size = new System.Drawing.Size(138, 64);
            this.Human_scaling.TabIndex = 39;
            this.Human_scaling.Text = "Масштабирование \r\nпо осям\r\n";
            this.Human_scaling.UseVisualStyleBackColor = true;
            this.Human_scaling.Click += new System.EventHandler(this.Human_scaling_Click);
            // 
            // rotation_Human_relatively_dot
            // 
            this.rotation_Human_relatively_dot.Location = new System.Drawing.Point(1085, 224);
            this.rotation_Human_relatively_dot.Name = "rotation_Human_relatively_dot";
            this.rotation_Human_relatively_dot.Size = new System.Drawing.Size(138, 74);
            this.rotation_Human_relatively_dot.TabIndex = 40;
            this.rotation_Human_relatively_dot.Text = "Поворот на угол \r\nотносительно \r\nточки\r\n\r\n";
            this.rotation_Human_relatively_dot.UseVisualStyleBackColor = true;
            this.rotation_Human_relatively_dot.Click += new System.EventHandler(this.rotation_Human_relatively_dot_Click);
            // 
            // rotation_Human_relatively_center
            // 
            this.rotation_Human_relatively_center.Location = new System.Drawing.Point(1085, 322);
            this.rotation_Human_relatively_center.Name = "rotation_Human_relatively_center";
            this.rotation_Human_relatively_center.Size = new System.Drawing.Size(138, 64);
            this.rotation_Human_relatively_center.TabIndex = 41;
            this.rotation_Human_relatively_center.Text = "Поворот на угол \r\nотносительно \r\nцентра\r\n\r\n\r\n";
            this.rotation_Human_relatively_center.UseVisualStyleBackColor = true;
            this.rotation_Human_relatively_center.Click += new System.EventHandler(this.rotation_Human_relatively_center_Click);
            // 
            // reflection_Human_OX
            // 
            this.reflection_Human_OX.Location = new System.Drawing.Point(1085, 401);
            this.reflection_Human_OX.Name = "reflection_Human_OX";
            this.reflection_Human_OX.Size = new System.Drawing.Size(138, 64);
            this.reflection_Human_OX.TabIndex = 42;
            this.reflection_Human_OX.Text = "Отражение \r\nотносительно \r\nOX\r\n\r\n\r\n\r\n";
            this.reflection_Human_OX.UseVisualStyleBackColor = true;
            this.reflection_Human_OX.Click += new System.EventHandler(this.reflection_Human_OX_Click);
            // 
            // reflection_Human_OY
            // 
            this.reflection_Human_OY.Location = new System.Drawing.Point(1229, 401);
            this.reflection_Human_OY.Name = "reflection_Human_OY";
            this.reflection_Human_OY.Size = new System.Drawing.Size(139, 64);
            this.reflection_Human_OY.TabIndex = 43;
            this.reflection_Human_OY.Text = "Отражение \r\nотносительно \r\nOY\r\n\r\n\r\n\r\n";
            this.reflection_Human_OY.UseVisualStyleBackColor = true;
            this.reflection_Human_OY.Click += new System.EventHandler(this.reflection_Human_OY_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1163, 471);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 64);
            this.button6.TabIndex = 44;
            this.button6.Text = "Отражение относительно \r\nпрямой Y=X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.reflection_Human_y_eql_x_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 642);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.reflection_Human_OY);
            this.Controls.Add(this.reflection_Human_OX);
            this.Controls.Add(this.rotation_Human_relatively_center);
            this.Controls.Add(this.rotation_Human_relatively_dot);
            this.Controls.Add(this.Human_scaling);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.vector_shift_Human);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Draw_Human);
            this.Controls.Add(this.WalkAnimation);
            this.Controls.Add(this.start_fugure_position);
            this.Controls.Add(this.reflection_y_eql_x);
            this.Controls.Add(this.reflection_OY);
            this.Controls.Add(this.reflection_OX);
            this.Controls.Add(this.P4_deg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rotation_relatively_center);
            this.Controls.Add(this.P3_deg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P3_y);
            this.Controls.Add(this.P3_x);
            this.Controls.Add(this.rotation_relatively_dot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P2_m);
            this.Controls.Add(this.P2_k);
            this.Controls.Add(this.figure_scaling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P1_y);
            this.Controls.Add(this.P1_x);
            this.Controls.Add(this.vector_shift);
            this.Controls.Add(this.start_scale);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button start_scale;
        private System.Windows.Forms.Button vector_shift;
        private System.Windows.Forms.TextBox P1_x;
        private System.Windows.Forms.TextBox P1_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button figure_scaling;
        private System.Windows.Forms.TextBox P2_k;
        private System.Windows.Forms.TextBox P2_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rotation_relatively_dot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P3_y;
        private System.Windows.Forms.TextBox P3_x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox P3_deg;
        private System.Windows.Forms.TextBox P4_deg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button rotation_relatively_center;
        private System.Windows.Forms.Button reflection_OX;
        private System.Windows.Forms.Button reflection_OY;
        private System.Windows.Forms.Button reflection_y_eql_x;
        private System.Windows.Forms.Button start_fugure_position;
        private System.Windows.Forms.Button WalkAnimation;
        private System.Windows.Forms.Button Draw_Human;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button vector_shift_Human;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Human_scaling;
        private System.Windows.Forms.Button rotation_Human_relatively_dot;
        private System.Windows.Forms.Button rotation_Human_relatively_center;
        private System.Windows.Forms.Button reflection_Human_OX;
        private System.Windows.Forms.Button reflection_Human_OY;
        private System.Windows.Forms.Button button6;
    }
}

