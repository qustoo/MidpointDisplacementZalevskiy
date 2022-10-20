
namespace MidpointDisplacementZalevskiy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_roughness = new System.Windows.Forms.Label();
            this.textBox_roughness = new System.Windows.Forms.TextBox();
            this.label_iteration = new System.Windows.Forms.Label();
            this.textBox_iterations = new System.Windows.Forms.TextBox();
            this.textBox_time_to_stop = new System.Windows.Forms.TextBox();
            this.label_time_to_stop = new System.Windows.Forms.Label();
            this.button_clear_canvas = new System.Windows.Forms.Button();
            this.radioButton_time_to_stop = new System.Windows.Forms.RadioButton();
            this.radioButton1_disable_time_to_stop = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(20, 92);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(142, 41);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Generate";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_roughness
            // 
            this.label_roughness.AutoSize = true;
            this.label_roughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_roughness.Location = new System.Drawing.Point(16, 186);
            this.label_roughness.Name = "label_roughness";
            this.label_roughness.Size = new System.Drawing.Size(84, 20);
            this.label_roughness.TabIndex = 7;
            this.label_roughness.Text = "roughness";
            // 
            // textBox_roughness
            // 
            this.textBox_roughness.Location = new System.Drawing.Point(121, 186);
            this.textBox_roughness.Name = "textBox_roughness";
            this.textBox_roughness.Size = new System.Drawing.Size(54, 20);
            this.textBox_roughness.TabIndex = 8;
            // 
            // label_iteration
            // 
            this.label_iteration.AutoSize = true;
            this.label_iteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_iteration.Location = new System.Drawing.Point(16, 152);
            this.label_iteration.Name = "label_iteration";
            this.label_iteration.Size = new System.Drawing.Size(74, 20);
            this.label_iteration.TabIndex = 9;
            this.label_iteration.Text = "iterations";
            // 
            // textBox_iterations
            // 
            this.textBox_iterations.Location = new System.Drawing.Point(121, 154);
            this.textBox_iterations.Name = "textBox_iterations";
            this.textBox_iterations.Size = new System.Drawing.Size(54, 20);
            this.textBox_iterations.TabIndex = 10;
            // 
            // textBox_time_to_stop
            // 
            this.textBox_time_to_stop.Location = new System.Drawing.Point(135, 311);
            this.textBox_time_to_stop.Name = "textBox_time_to_stop";
            this.textBox_time_to_stop.Size = new System.Drawing.Size(55, 20);
            this.textBox_time_to_stop.TabIndex = 13;
            // 
            // label_time_to_stop
            // 
            this.label_time_to_stop.AutoSize = true;
            this.label_time_to_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time_to_stop.Location = new System.Drawing.Point(12, 310);
            this.label_time_to_stop.Name = "label_time_to_stop";
            this.label_time_to_stop.Size = new System.Drawing.Size(117, 18);
            this.label_time_to_stop.TabIndex = 14;
            this.label_time_to_stop.Text = "Seconds to stop";
            // 
            // button_clear_canvas
            // 
            this.button_clear_canvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear_canvas.Location = new System.Drawing.Point(20, 212);
            this.button_clear_canvas.Name = "button_clear_canvas";
            this.button_clear_canvas.Size = new System.Drawing.Size(142, 44);
            this.button_clear_canvas.TabIndex = 15;
            this.button_clear_canvas.Text = "Clear Canvas";
            this.button_clear_canvas.UseVisualStyleBackColor = true;
            this.button_clear_canvas.Click += new System.EventHandler(this.button_clear_canvas_Click);
            // 
            // radioButton_time_to_stop
            // 
            this.radioButton_time_to_stop.AutoSize = true;
            this.radioButton_time_to_stop.Location = new System.Drawing.Point(20, 267);
            this.radioButton_time_to_stop.Name = "radioButton_time_to_stop";
            this.radioButton_time_to_stop.Size = new System.Drawing.Size(115, 17);
            this.radioButton_time_to_stop.TabIndex = 16;
            this.radioButton_time_to_stop.TabStop = true;
            this.radioButton_time_to_stop.Text = "Enable time to stop";
            this.radioButton_time_to_stop.UseVisualStyleBackColor = true;
            this.radioButton_time_to_stop.CheckedChanged += new System.EventHandler(this.radioButton_time_to_stop_CheckedChanged);
            // 
            // radioButton1_disable_time_to_stop
            // 
            this.radioButton1_disable_time_to_stop.AutoSize = true;
            this.radioButton1_disable_time_to_stop.Location = new System.Drawing.Point(20, 290);
            this.radioButton1_disable_time_to_stop.Name = "radioButton1_disable_time_to_stop";
            this.radioButton1_disable_time_to_stop.Size = new System.Drawing.Size(117, 17);
            this.radioButton1_disable_time_to_stop.TabIndex = 17;
            this.radioButton1_disable_time_to_stop.TabStop = true;
            this.radioButton1_disable_time_to_stop.Text = "Disable time to stop";
            this.radioButton1_disable_time_to_stop.UseVisualStyleBackColor = true;
            this.radioButton1_disable_time_to_stop.CheckedChanged += new System.EventHandler(this.radioButton1_disable_time_to_stop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1_disable_time_to_stop);
            this.Controls.Add(this.radioButton_time_to_stop);
            this.Controls.Add(this.button_clear_canvas);
            this.Controls.Add(this.label_time_to_stop);
            this.Controls.Add(this.textBox_time_to_stop);
            this.Controls.Add(this.textBox_iterations);
            this.Controls.Add(this.label_iteration);
            this.Controls.Add(this.textBox_roughness);
            this.Controls.Add(this.label_roughness);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_roughness;
        private System.Windows.Forms.TextBox textBox_roughness;
        private System.Windows.Forms.Label label_iteration;
        private System.Windows.Forms.TextBox textBox_iterations;
        private System.Windows.Forms.TextBox textBox_time_to_stop;
        private System.Windows.Forms.Label label_time_to_stop;
        private System.Windows.Forms.Button button_clear_canvas;
        private System.Windows.Forms.RadioButton radioButton_time_to_stop;
        private System.Windows.Forms.RadioButton radioButton1_disable_time_to_stop;
    }
}

