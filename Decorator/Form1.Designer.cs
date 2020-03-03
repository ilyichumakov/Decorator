namespace Decorator
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
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.mushroomBox = new System.Windows.Forms.CheckBox();
            this.salamiBox = new System.Windows.Forms.CheckBox();
            this.beaconBox = new System.Windows.Forms.CheckBox();
            this.tomatoBox = new System.Windows.Forms.CheckBox();
            this.cucumberBox = new System.Windows.Forms.CheckBox();
            this.mayoBox = new System.Windows.Forms.CheckBox();
            this.ketchupBox = new System.Windows.Forms.CheckBox();
            this.fishBox = new System.Windows.Forms.CheckBox();
            this.hamBox = new System.Windows.Forms.CheckBox();
            this.roastbeefBox = new System.Windows.Forms.CheckBox();
            this.chickenBox = new System.Windows.Forms.CheckBox();
            this.mustardBox = new System.Windows.Forms.CheckBox();
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.regularRadio = new System.Windows.Forms.RadioButton();
            this.ExtraRadio = new System.Windows.Forms.RadioButton();
            this.WhiteRadio = new System.Windows.Forms.RadioButton();
            this.GreyRadio = new System.Windows.Forms.RadioButton();
            this.lenBox = new System.Windows.Forms.GroupBox();
            this.BreadBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sandwichDesc = new System.Windows.Forms.Label();
            this.innerBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.lenBox.SuspendLayout();
            this.BreadBox.SuspendLayout();
            this.innerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheeseBox.Location = new System.Drawing.Point(8, 31);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(58, 23);
            this.cheeseBox.TabIndex = 0;
            this.cheeseBox.Text = "Сыр";
            this.cheeseBox.UseVisualStyleBackColor = true;
            this.cheeseBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // mushroomBox
            // 
            this.mushroomBox.AutoSize = true;
            this.mushroomBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mushroomBox.Location = new System.Drawing.Point(8, 60);
            this.mushroomBox.Name = "mushroomBox";
            this.mushroomBox.Size = new System.Drawing.Size(74, 23);
            this.mushroomBox.TabIndex = 0;
            this.mushroomBox.Text = "Грибы";
            this.mushroomBox.UseVisualStyleBackColor = true;
            this.mushroomBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // salamiBox
            // 
            this.salamiBox.AutoSize = true;
            this.salamiBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salamiBox.Location = new System.Drawing.Point(239, 32);
            this.salamiBox.Name = "salamiBox";
            this.salamiBox.Size = new System.Drawing.Size(82, 23);
            this.salamiBox.TabIndex = 0;
            this.salamiBox.Text = "Салями";
            this.salamiBox.UseVisualStyleBackColor = true;
            this.salamiBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // beaconBox
            // 
            this.beaconBox.AutoSize = true;
            this.beaconBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beaconBox.Location = new System.Drawing.Point(239, 61);
            this.beaconBox.Name = "beaconBox";
            this.beaconBox.Size = new System.Drawing.Size(71, 23);
            this.beaconBox.TabIndex = 0;
            this.beaconBox.Text = "Бекон";
            this.beaconBox.UseVisualStyleBackColor = true;
            this.beaconBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // tomatoBox
            // 
            this.tomatoBox.AutoSize = true;
            this.tomatoBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomatoBox.Location = new System.Drawing.Point(8, 89);
            this.tomatoBox.Name = "tomatoBox";
            this.tomatoBox.Size = new System.Drawing.Size(73, 23);
            this.tomatoBox.TabIndex = 0;
            this.tomatoBox.Text = "Томат";
            this.tomatoBox.UseVisualStyleBackColor = true;
            this.tomatoBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // cucumberBox
            // 
            this.cucumberBox.AutoSize = true;
            this.cucumberBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cucumberBox.Location = new System.Drawing.Point(8, 119);
            this.cucumberBox.Name = "cucumberBox";
            this.cucumberBox.Size = new System.Drawing.Size(202, 23);
            this.cucumberBox.TabIndex = 0;
            this.cucumberBox.Text = "Маринованный огурчик";
            this.cucumberBox.UseVisualStyleBackColor = true;
            this.cucumberBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // mayoBox
            // 
            this.mayoBox.AutoSize = true;
            this.mayoBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mayoBox.Location = new System.Drawing.Point(8, 148);
            this.mayoBox.Name = "mayoBox";
            this.mayoBox.Size = new System.Drawing.Size(90, 23);
            this.mayoBox.TabIndex = 0;
            this.mayoBox.Text = "Майонез";
            this.mayoBox.UseVisualStyleBackColor = true;
            this.mayoBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // ketchupBox
            // 
            this.ketchupBox.AutoSize = true;
            this.ketchupBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ketchupBox.Location = new System.Drawing.Point(8, 177);
            this.ketchupBox.Name = "ketchupBox";
            this.ketchupBox.Size = new System.Drawing.Size(80, 23);
            this.ketchupBox.TabIndex = 0;
            this.ketchupBox.Text = "Кетчуп";
            this.ketchupBox.UseVisualStyleBackColor = true;
            this.ketchupBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // fishBox
            // 
            this.fishBox.AutoSize = true;
            this.fishBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fishBox.Location = new System.Drawing.Point(239, 177);
            this.fishBox.Name = "fishBox";
            this.fishBox.Size = new System.Drawing.Size(65, 23);
            this.fishBox.TabIndex = 0;
            this.fishBox.Text = "Рыба";
            this.fishBox.UseVisualStyleBackColor = true;
            this.fishBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // hamBox
            // 
            this.hamBox.AutoSize = true;
            this.hamBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamBox.Location = new System.Drawing.Point(239, 90);
            this.hamBox.Name = "hamBox";
            this.hamBox.Size = new System.Drawing.Size(88, 23);
            this.hamBox.TabIndex = 0;
            this.hamBox.Text = "Ветчина";
            this.hamBox.UseVisualStyleBackColor = true;
            this.hamBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // roastbeefBox
            // 
            this.roastbeefBox.AutoSize = true;
            this.roastbeefBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roastbeefBox.Location = new System.Drawing.Point(239, 119);
            this.roastbeefBox.Name = "roastbeefBox";
            this.roastbeefBox.Size = new System.Drawing.Size(91, 23);
            this.roastbeefBox.TabIndex = 0;
            this.roastbeefBox.Text = "Ростбиф";
            this.roastbeefBox.UseVisualStyleBackColor = true;
            this.roastbeefBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // chickenBox
            // 
            this.chickenBox.AutoSize = true;
            this.chickenBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chickenBox.Location = new System.Drawing.Point(239, 148);
            this.chickenBox.Name = "chickenBox";
            this.chickenBox.Size = new System.Drawing.Size(81, 23);
            this.chickenBox.TabIndex = 0;
            this.chickenBox.Text = "Курица";
            this.chickenBox.UseVisualStyleBackColor = true;
            this.chickenBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // mustardBox
            // 
            this.mustardBox.AutoSize = true;
            this.mustardBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mustardBox.Location = new System.Drawing.Point(8, 206);
            this.mustardBox.Name = "mustardBox";
            this.mustardBox.Size = new System.Drawing.Size(89, 23);
            this.mustardBox.TabIndex = 0;
            this.mustardBox.Text = "Горчица";
            this.mustardBox.UseVisualStyleBackColor = true;
            this.mustardBox.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Checked = true;
            this.smallRadio.Location = new System.Drawing.Point(7, 26);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(67, 23);
            this.smallRadio.TabIndex = 1;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "15 см";
            this.smallRadio.UseVisualStyleBackColor = true;
            this.smallRadio.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // regularRadio
            // 
            this.regularRadio.AutoSize = true;
            this.regularRadio.Location = new System.Drawing.Point(151, 26);
            this.regularRadio.Name = "regularRadio";
            this.regularRadio.Size = new System.Drawing.Size(67, 23);
            this.regularRadio.TabIndex = 1;
            this.regularRadio.Text = "20 см";
            this.regularRadio.UseVisualStyleBackColor = true;
            this.regularRadio.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // ExtraRadio
            // 
            this.ExtraRadio.AutoSize = true;
            this.ExtraRadio.Location = new System.Drawing.Point(289, 26);
            this.ExtraRadio.Name = "ExtraRadio";
            this.ExtraRadio.Size = new System.Drawing.Size(108, 23);
            this.ExtraRadio.TabIndex = 1;
            this.ExtraRadio.Text = "Extra 30 см";
            this.ExtraRadio.UseVisualStyleBackColor = true;
            this.ExtraRadio.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // WhiteRadio
            // 
            this.WhiteRadio.AutoSize = true;
            this.WhiteRadio.Checked = true;
            this.WhiteRadio.Location = new System.Drawing.Point(9, 33);
            this.WhiteRadio.Name = "WhiteRadio";
            this.WhiteRadio.Size = new System.Drawing.Size(110, 23);
            this.WhiteRadio.TabIndex = 1;
            this.WhiteRadio.TabStop = true;
            this.WhiteRadio.Text = "Пшеничная";
            this.WhiteRadio.UseVisualStyleBackColor = true;
            this.WhiteRadio.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // GreyRadio
            // 
            this.GreyRadio.AutoSize = true;
            this.GreyRadio.Location = new System.Drawing.Point(153, 33);
            this.GreyRadio.Name = "GreyRadio";
            this.GreyRadio.Size = new System.Drawing.Size(81, 23);
            this.GreyRadio.TabIndex = 1;
            this.GreyRadio.Text = "Ржаная";
            this.GreyRadio.UseVisualStyleBackColor = true;
            this.GreyRadio.CheckedChanged += new System.EventHandler(this.innerBox_CheckedChanged);
            // 
            // lenBox
            // 
            this.lenBox.Controls.Add(this.ExtraRadio);
            this.lenBox.Controls.Add(this.regularRadio);
            this.lenBox.Controls.Add(this.smallRadio);
            this.lenBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenBox.Location = new System.Drawing.Point(12, 263);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(403, 73);
            this.lenBox.TabIndex = 2;
            this.lenBox.TabStop = false;
            this.lenBox.Text = "Длина";
            // 
            // BreadBox
            // 
            this.BreadBox.Controls.Add(this.GreyRadio);
            this.BreadBox.Controls.Add(this.WhiteRadio);
            this.BreadBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreadBox.Location = new System.Drawing.Point(12, 360);
            this.BreadBox.Name = "BreadBox";
            this.BreadBox.Size = new System.Drawing.Size(403, 114);
            this.BreadBox.TabIndex = 3;
            this.BreadBox.TabStop = false;
            this.BreadBox.Text = "Булочка";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(586, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стоимость бутерброда:";
            // 
            // sandwichDesc
            // 
            this.sandwichDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.sandwichDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sandwichDesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sandwichDesc.Location = new System.Drawing.Point(586, 73);
            this.sandwichDesc.Name = "sandwichDesc";
            this.sandwichDesc.Padding = new System.Windows.Forms.Padding(15);
            this.sandwichDesc.Size = new System.Drawing.Size(281, 373);
            this.sandwichDesc.TabIndex = 4;
            // 
            // innerBox
            // 
            this.innerBox.Controls.Add(this.mustardBox);
            this.innerBox.Controls.Add(this.fishBox);
            this.innerBox.Controls.Add(this.chickenBox);
            this.innerBox.Controls.Add(this.roastbeefBox);
            this.innerBox.Controls.Add(this.ketchupBox);
            this.innerBox.Controls.Add(this.hamBox);
            this.innerBox.Controls.Add(this.mayoBox);
            this.innerBox.Controls.Add(this.cucumberBox);
            this.innerBox.Controls.Add(this.tomatoBox);
            this.innerBox.Controls.Add(this.beaconBox);
            this.innerBox.Controls.Add(this.salamiBox);
            this.innerBox.Controls.Add(this.mushroomBox);
            this.innerBox.Controls.Add(this.cheeseBox);
            this.innerBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.innerBox.Location = new System.Drawing.Point(12, 12);
            this.innerBox.Name = "innerBox";
            this.innerBox.Size = new System.Drawing.Size(403, 244);
            this.innerBox.TabIndex = 5;
            this.innerBox.TabStop = false;
            this.innerBox.Text = "Наполнители";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(770, 17);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 496);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.innerBox);
            this.Controls.Add(this.sandwichDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BreadBox);
            this.Controls.Add(this.lenBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Decorator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lenBox.ResumeLayout(false);
            this.lenBox.PerformLayout();
            this.BreadBox.ResumeLayout(false);
            this.BreadBox.PerformLayout();
            this.innerBox.ResumeLayout(false);
            this.innerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.CheckBox mushroomBox;
        private System.Windows.Forms.CheckBox salamiBox;
        private System.Windows.Forms.CheckBox beaconBox;
        private System.Windows.Forms.CheckBox tomatoBox;
        private System.Windows.Forms.CheckBox cucumberBox;
        private System.Windows.Forms.CheckBox mayoBox;
        private System.Windows.Forms.CheckBox ketchupBox;
        private System.Windows.Forms.CheckBox fishBox;
        private System.Windows.Forms.CheckBox hamBox;
        private System.Windows.Forms.CheckBox roastbeefBox;
        private System.Windows.Forms.CheckBox chickenBox;
        private System.Windows.Forms.CheckBox mustardBox;
        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton regularRadio;
        private System.Windows.Forms.RadioButton ExtraRadio;
        private System.Windows.Forms.RadioButton WhiteRadio;
        private System.Windows.Forms.RadioButton GreyRadio;
        private System.Windows.Forms.GroupBox lenBox;
        private System.Windows.Forms.GroupBox BreadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sandwichDesc;
        private System.Windows.Forms.GroupBox innerBox;
        private System.Windows.Forms.Label priceLabel;
    }
}

