namespace calculator
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            Hasil_TextBox = new TextBox();
            pangkatx_btn = new Button();
            tujuh_btn = new Button();
            empat_btn = new Button();
            satu_btn = new Button();
            backspace_btn = new Button();
            dua_btn = new Button();
            lima_btn = new Button();
            delapan_btn = new Button();
            pangkat_btn = new Button();
            tiga_btn = new Button();
            enam_btn = new Button();
            sembilan_btn = new Button();
            akar_btn = new Button();
            clear_btn = new Button();
            clearall_btn = new Button();
            persen_btn = new Button();
            tambah_btn = new Button();
            samadengan_btn = new Button();
            kurang_btn = new Button();
            kali_btn = new Button();
            bagi_btn = new Button();
            koma_btn = new Button();
            nol_btn = new Button();
            Minuplus_btn = new Button();
            SuspendLayout();
            // 
            // Hasil_TextBox
            // 
            Hasil_TextBox.BackColor = Color.FromArgb(250, 248, 241);
            Hasil_TextBox.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Hasil_TextBox.Location = new Point(10, 15);
            Hasil_TextBox.Name = "Hasil_TextBox";
            Hasil_TextBox.ReadOnly = true;
            Hasil_TextBox.Size = new Size(269, 43);
            Hasil_TextBox.TabIndex = 0;
            Hasil_TextBox.Text = "0";
            Hasil_TextBox.TextAlign = HorizontalAlignment.Right;
            Hasil_TextBox.TextChanged += Hasil_TextBox_TextChanged;
            // 
            // pangkatx_btn
            // 
            pangkatx_btn.BackColor = Color.FromArgb(197, 137, 64);
            pangkatx_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            pangkatx_btn.FlatAppearance.BorderSize = 3;
            pangkatx_btn.FlatStyle = FlatStyle.Flat;
            pangkatx_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pangkatx_btn.ForeColor = Color.White;
            pangkatx_btn.Location = new Point(10, 141);
            pangkatx_btn.Name = "pangkatx_btn";
            pangkatx_btn.Size = new Size(59, 62);
            pangkatx_btn.TabIndex = 1;
            pangkatx_btn.Text = "¹/x";
            pangkatx_btn.UseVisualStyleBackColor = false;
            // 
            // tujuh_btn
            // 
            tujuh_btn.AccessibleDescription = "";
            tujuh_btn.BackColor = Color.FromArgb(197, 137, 64);
            tujuh_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            tujuh_btn.FlatAppearance.BorderSize = 3;
            tujuh_btn.FlatStyle = FlatStyle.Flat;
            tujuh_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tujuh_btn.ForeColor = Color.White;
            tujuh_btn.Location = new Point(10, 209);
            tujuh_btn.Name = "tujuh_btn";
            tujuh_btn.Size = new Size(59, 62);
            tujuh_btn.TabIndex = 2;
            tujuh_btn.Text = "7";
            tujuh_btn.UseVisualStyleBackColor = false;
            tujuh_btn.Click += tujuh_btn_Click;
            // 
            // empat_btn
            // 
            empat_btn.BackColor = Color.FromArgb(197, 137, 64);
            empat_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            empat_btn.FlatAppearance.BorderSize = 3;
            empat_btn.FlatStyle = FlatStyle.Flat;
            empat_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            empat_btn.ForeColor = Color.White;
            empat_btn.Location = new Point(10, 277);
            empat_btn.Name = "empat_btn";
            empat_btn.Size = new Size(59, 62);
            empat_btn.TabIndex = 3;
            empat_btn.Text = "4";
            empat_btn.UseVisualStyleBackColor = false;
            empat_btn.Click += empat_btn_Click;
            // 
            // satu_btn
            // 
            satu_btn.BackColor = Color.FromArgb(197, 137, 64);
            satu_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            satu_btn.FlatAppearance.BorderSize = 3;
            satu_btn.FlatStyle = FlatStyle.Flat;
            satu_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            satu_btn.ForeColor = Color.White;
            satu_btn.Location = new Point(10, 345);
            satu_btn.Name = "satu_btn";
            satu_btn.Size = new Size(59, 62);
            satu_btn.TabIndex = 4;
            satu_btn.Text = "1";
            satu_btn.UseVisualStyleBackColor = false;
            satu_btn.Click += satu_btn_Click;
            // 
            // backspace_btn
            // 
            backspace_btn.BackColor = Color.FromArgb(197, 137, 64);
            backspace_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            backspace_btn.FlatAppearance.BorderSize = 3;
            backspace_btn.FlatStyle = FlatStyle.Flat;
            backspace_btn.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            backspace_btn.ForeColor = Color.White;
            backspace_btn.Location = new Point(220, 73);
            backspace_btn.Name = "backspace_btn";
            backspace_btn.Size = new Size(59, 62);
            backspace_btn.TabIndex = 5;
            backspace_btn.Text = "«";
            backspace_btn.UseVisualStyleBackColor = false;
            backspace_btn.Click += backspace_btn_Click;
            // 
            // dua_btn
            // 
            dua_btn.BackColor = Color.FromArgb(197, 137, 64);
            dua_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            dua_btn.FlatAppearance.BorderSize = 3;
            dua_btn.FlatStyle = FlatStyle.Flat;
            dua_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dua_btn.ForeColor = Color.White;
            dua_btn.Location = new Point(74, 345);
            dua_btn.Name = "dua_btn";
            dua_btn.Size = new Size(59, 62);
            dua_btn.TabIndex = 10;
            dua_btn.Text = "2";
            dua_btn.UseVisualStyleBackColor = false;
            dua_btn.Click += dua_btn_Click;
            // 
            // lima_btn
            // 
            lima_btn.BackColor = Color.FromArgb(197, 137, 64);
            lima_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            lima_btn.FlatAppearance.BorderSize = 3;
            lima_btn.FlatStyle = FlatStyle.Flat;
            lima_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lima_btn.ForeColor = Color.White;
            lima_btn.Location = new Point(74, 277);
            lima_btn.Name = "lima_btn";
            lima_btn.Size = new Size(59, 62);
            lima_btn.TabIndex = 9;
            lima_btn.Text = "5";
            lima_btn.UseVisualStyleBackColor = false;
            lima_btn.Click += lima_btn_Click;
            // 
            // delapan_btn
            // 
            delapan_btn.BackColor = Color.FromArgb(197, 137, 64);
            delapan_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            delapan_btn.FlatAppearance.BorderSize = 3;
            delapan_btn.FlatStyle = FlatStyle.Flat;
            delapan_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delapan_btn.ForeColor = Color.White;
            delapan_btn.Location = new Point(74, 209);
            delapan_btn.Name = "delapan_btn";
            delapan_btn.Size = new Size(59, 62);
            delapan_btn.TabIndex = 8;
            delapan_btn.Text = "8";
            delapan_btn.UseVisualStyleBackColor = false;
            delapan_btn.Click += delapan_btn_Click;
            // 
            // pangkat_btn
            // 
            pangkat_btn.BackColor = Color.FromArgb(197, 137, 64);
            pangkat_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            pangkat_btn.FlatAppearance.BorderSize = 3;
            pangkat_btn.FlatStyle = FlatStyle.Flat;
            pangkat_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pangkat_btn.ForeColor = Color.White;
            pangkat_btn.Location = new Point(74, 141);
            pangkat_btn.Name = "pangkat_btn";
            pangkat_btn.Size = new Size(59, 62);
            pangkat_btn.TabIndex = 7;
            pangkat_btn.Text = "x²";
            pangkat_btn.UseVisualStyleBackColor = false;
            pangkat_btn.Click += pangkat_btn_Click;
            // 
            // tiga_btn
            // 
            tiga_btn.BackColor = Color.FromArgb(197, 137, 64);
            tiga_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            tiga_btn.FlatAppearance.BorderSize = 3;
            tiga_btn.FlatStyle = FlatStyle.Flat;
            tiga_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tiga_btn.ForeColor = Color.White;
            tiga_btn.Location = new Point(139, 345);
            tiga_btn.Name = "tiga_btn";
            tiga_btn.Size = new Size(59, 62);
            tiga_btn.TabIndex = 14;
            tiga_btn.Text = "3";
            tiga_btn.UseVisualStyleBackColor = false;
            tiga_btn.Click += tiga_btn_Click;
            // 
            // enam_btn
            // 
            enam_btn.BackColor = Color.FromArgb(197, 137, 64);
            enam_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            enam_btn.FlatAppearance.BorderSize = 3;
            enam_btn.FlatStyle = FlatStyle.Flat;
            enam_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enam_btn.ForeColor = Color.White;
            enam_btn.Location = new Point(139, 277);
            enam_btn.Name = "enam_btn";
            enam_btn.Size = new Size(59, 62);
            enam_btn.TabIndex = 13;
            enam_btn.Text = "6";
            enam_btn.UseVisualStyleBackColor = false;
            enam_btn.Click += enam_btn_Click;
            // 
            // sembilan_btn
            // 
            sembilan_btn.BackColor = Color.FromArgb(197, 137, 64);
            sembilan_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            sembilan_btn.FlatAppearance.BorderSize = 3;
            sembilan_btn.FlatStyle = FlatStyle.Flat;
            sembilan_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sembilan_btn.ForeColor = Color.White;
            sembilan_btn.Location = new Point(139, 209);
            sembilan_btn.Name = "sembilan_btn";
            sembilan_btn.Size = new Size(59, 62);
            sembilan_btn.TabIndex = 12;
            sembilan_btn.Text = "9";
            sembilan_btn.UseVisualStyleBackColor = false;
            sembilan_btn.Click += sembilan_btn_Click;
            // 
            // akar_btn
            // 
            akar_btn.BackColor = Color.FromArgb(197, 137, 64);
            akar_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            akar_btn.FlatAppearance.BorderSize = 3;
            akar_btn.FlatStyle = FlatStyle.Flat;
            akar_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            akar_btn.ForeColor = Color.White;
            akar_btn.Location = new Point(139, 141);
            akar_btn.Name = "akar_btn";
            akar_btn.Size = new Size(59, 62);
            akar_btn.TabIndex = 11;
            akar_btn.Text = "²√x";
            akar_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(197, 137, 64);
            clear_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            clear_btn.FlatAppearance.BorderSize = 3;
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(139, 73);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(59, 62);
            clear_btn.TabIndex = 17;
            clear_btn.Text = "C";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // clearall_btn
            // 
            clearall_btn.BackColor = Color.FromArgb(197, 137, 64);
            clearall_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            clearall_btn.FlatAppearance.BorderSize = 3;
            clearall_btn.FlatStyle = FlatStyle.Flat;
            clearall_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearall_btn.ForeColor = Color.White;
            clearall_btn.Location = new Point(74, 73);
            clearall_btn.Name = "clearall_btn";
            clearall_btn.Size = new Size(59, 62);
            clearall_btn.TabIndex = 16;
            clearall_btn.Text = "CE";
            clearall_btn.UseVisualStyleBackColor = false;
            // 
            // persen_btn
            // 
            persen_btn.BackColor = Color.FromArgb(197, 137, 64);
            persen_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            persen_btn.FlatAppearance.BorderSize = 3;
            persen_btn.FlatStyle = FlatStyle.Flat;
            persen_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            persen_btn.ForeColor = Color.White;
            persen_btn.Location = new Point(10, 73);
            persen_btn.Name = "persen_btn";
            persen_btn.Size = new Size(59, 62);
            persen_btn.TabIndex = 15;
            persen_btn.Text = "%";
            persen_btn.UseVisualStyleBackColor = false;
            persen_btn.Click += persen_btn_Click;
            // 
            // tambah_btn
            // 
            tambah_btn.BackColor = Color.FromArgb(197, 137, 64);
            tambah_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            tambah_btn.FlatAppearance.BorderSize = 3;
            tambah_btn.FlatStyle = FlatStyle.Flat;
            tambah_btn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tambah_btn.ForeColor = Color.White;
            tambah_btn.Location = new Point(220, 141);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(59, 62);
            tambah_btn.TabIndex = 18;
            tambah_btn.Text = "+";
            tambah_btn.UseVisualStyleBackColor = false;
            tambah_btn.Click += tambah_btn_Click;
            // 
            // samadengan_btn
            // 
            samadengan_btn.BackColor = Color.FromArgb(197, 137, 64);
            samadengan_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            samadengan_btn.FlatAppearance.BorderSize = 3;
            samadengan_btn.FlatStyle = FlatStyle.Flat;
            samadengan_btn.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            samadengan_btn.ForeColor = Color.White;
            samadengan_btn.Location = new Point(220, 413);
            samadengan_btn.Name = "samadengan_btn";
            samadengan_btn.Size = new Size(59, 62);
            samadengan_btn.TabIndex = 19;
            samadengan_btn.Text = "=";
            samadengan_btn.UseVisualStyleBackColor = false;
            samadengan_btn.Click += samadengan_btn_Click;
            // 
            // kurang_btn
            // 
            kurang_btn.BackColor = Color.FromArgb(197, 137, 64);
            kurang_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            kurang_btn.FlatAppearance.BorderSize = 3;
            kurang_btn.FlatStyle = FlatStyle.Flat;
            kurang_btn.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            kurang_btn.ForeColor = Color.White;
            kurang_btn.Location = new Point(220, 209);
            kurang_btn.Name = "kurang_btn";
            kurang_btn.Size = new Size(59, 62);
            kurang_btn.TabIndex = 20;
            kurang_btn.Text = "-";
            kurang_btn.UseVisualStyleBackColor = false;
            kurang_btn.Click += kurang_btn_Click;
            // 
            // kali_btn
            // 
            kali_btn.BackColor = Color.FromArgb(197, 137, 64);
            kali_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            kali_btn.FlatAppearance.BorderSize = 3;
            kali_btn.FlatStyle = FlatStyle.Flat;
            kali_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kali_btn.ForeColor = Color.White;
            kali_btn.Location = new Point(220, 277);
            kali_btn.Name = "kali_btn";
            kali_btn.Size = new Size(59, 62);
            kali_btn.TabIndex = 21;
            kali_btn.Text = "X";
            kali_btn.UseVisualStyleBackColor = false;
            kali_btn.Click += kali_btn_Click;
            // 
            // bagi_btn
            // 
            bagi_btn.BackColor = Color.FromArgb(197, 137, 64);
            bagi_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            bagi_btn.FlatAppearance.BorderSize = 3;
            bagi_btn.FlatStyle = FlatStyle.Flat;
            bagi_btn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bagi_btn.ForeColor = Color.White;
            bagi_btn.Location = new Point(220, 345);
            bagi_btn.Name = "bagi_btn";
            bagi_btn.Size = new Size(59, 62);
            bagi_btn.TabIndex = 23;
            bagi_btn.Text = "÷";
            bagi_btn.UseVisualStyleBackColor = false;
            bagi_btn.Click += bagi_btn_Click;
            // 
            // koma_btn
            // 
            koma_btn.BackColor = Color.FromArgb(197, 137, 64);
            koma_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            koma_btn.FlatAppearance.BorderSize = 3;
            koma_btn.FlatStyle = FlatStyle.Flat;
            koma_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            koma_btn.ForeColor = Color.White;
            koma_btn.Location = new Point(139, 413);
            koma_btn.Name = "koma_btn";
            koma_btn.Size = new Size(59, 62);
            koma_btn.TabIndex = 26;
            koma_btn.Text = ",";
            koma_btn.UseVisualStyleBackColor = false;
            koma_btn.Click += koma_btn_Click;
            // 
            // nol_btn
            // 
            nol_btn.BackColor = Color.FromArgb(197, 137, 64);
            nol_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            nol_btn.FlatAppearance.BorderSize = 3;
            nol_btn.FlatStyle = FlatStyle.Flat;
            nol_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nol_btn.ForeColor = Color.White;
            nol_btn.Location = new Point(74, 413);
            nol_btn.Name = "nol_btn";
            nol_btn.Size = new Size(59, 62);
            nol_btn.TabIndex = 25;
            nol_btn.Text = "0";
            nol_btn.UseVisualStyleBackColor = false;
            nol_btn.Click += nol_btn_Click;
            // 
            // Minuplus_btn
            // 
            Minuplus_btn.BackColor = Color.FromArgb(197, 137, 64);
            Minuplus_btn.FlatAppearance.BorderColor = Color.FromArgb(244, 238, 224);
            Minuplus_btn.FlatAppearance.BorderSize = 3;
            Minuplus_btn.FlatStyle = FlatStyle.Flat;
            Minuplus_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Minuplus_btn.ForeColor = Color.White;
            Minuplus_btn.Location = new Point(10, 413);
            Minuplus_btn.Name = "Minuplus_btn";
            Minuplus_btn.Size = new Size(59, 62);
            Minuplus_btn.TabIndex = 24;
            Minuplus_btn.Text = "+/_";
            Minuplus_btn.UseVisualStyleBackColor = false;
            Minuplus_btn.Click += Minuplus_btn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 186, 115);
            ClientSize = new Size(290, 487);
            Controls.Add(koma_btn);
            Controls.Add(nol_btn);
            Controls.Add(Minuplus_btn);
            Controls.Add(bagi_btn);
            Controls.Add(kali_btn);
            Controls.Add(kurang_btn);
            Controls.Add(samadengan_btn);
            Controls.Add(tambah_btn);
            Controls.Add(clear_btn);
            Controls.Add(clearall_btn);
            Controls.Add(persen_btn);
            Controls.Add(tiga_btn);
            Controls.Add(enam_btn);
            Controls.Add(sembilan_btn);
            Controls.Add(akar_btn);
            Controls.Add(dua_btn);
            Controls.Add(lima_btn);
            Controls.Add(delapan_btn);
            Controls.Add(pangkat_btn);
            Controls.Add(backspace_btn);
            Controls.Add(satu_btn);
            Controls.Add(empat_btn);
            Controls.Add(tujuh_btn);
            Controls.Add(pangkatx_btn);
            Controls.Add(Hasil_TextBox);
            ForeColor = Color.FromArgb(57, 54, 70);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "calculator";
            Text = "Calculator Simulator";
            Load += calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Hasil_TextBox;
        private Button pangkatx_btn;
        private Button tujuh_btn;
        private Button empat_btn;
        private Button satu_btn;
        private Button backspace_btn;
        private Button dua_btn;
        private Button lima_btn;
        private Button delapan_btn;
        private Button pangkat_btn;
        private Button tiga_btn;
        private Button enam_btn;
        private Button sembilan_btn;
        private Button akar_btn;
        private Button clear_btn;
        private Button clearall_btn;
        private Button persen_btn;
        private Button tambah_btn;
        private Button samadengan_btn;
        private Button kurang_btn;
        private Button kali_btn;
        private Button bagi_btn;
        private Button koma_btn;
        private Button nol_btn;
        private Button Minuplus_btn;
    }
}