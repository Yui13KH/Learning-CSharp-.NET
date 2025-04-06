namespace MovieShop
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.CharType = new System.Windows.Forms.GroupBox();
            this.rbHero = new System.Windows.Forms.RadioButton();
            this.rbVillain = new System.Windows.Forms.RadioButton();
            this.outfits = new System.Windows.Forms.GroupBox();
            this.chkCasual = new System.Windows.Forms.CheckBox();
            this.chkArmor = new System.Windows.Forms.CheckBox();
            this.chkUniform = new System.Windows.Forms.CheckBox();
            this.chkNinja = new System.Windows.Forms.CheckBox();
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.chkHeroCustome = new System.Windows.Forms.CheckBox();
            this.weaponType = new System.Windows.Forms.GroupBox();
            this.rbGun = new System.Windows.Forms.RadioButton();
            this.rbSword = new System.Windows.Forms.RadioButton();
            this.rbFists = new System.Windows.Forms.RadioButton();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.species = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbVampire = new System.Windows.Forms.RadioButton();
            this.rbElf = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbDryad = new System.Windows.Forms.RadioButton();
            this.lblSumarry = new System.Windows.Forms.Label();
            this.CharType.SuspendLayout();
            this.outfits.SuspendLayout();
            this.weaponType.SuspendLayout();
            this.species.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.Title.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.Title.Location = new System.Drawing.Point(259, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(266, 38);
            this.Title.TabIndex = 0;
            this.Title.Text = "Character Maker";
            // 
            // CharType
            // 
            this.CharType.Controls.Add(this.rbVillain);
            this.CharType.Controls.Add(this.rbHero);
            this.CharType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.CharType.Location = new System.Drawing.Point(4, 76);
            this.CharType.Name = "CharType";
            this.CharType.Size = new System.Drawing.Size(177, 112);
            this.CharType.TabIndex = 4;
            this.CharType.TabStop = false;
            this.CharType.Text = "Character Type";
            // 
            // rbHero
            // 
            this.rbHero.AutoSize = true;
            this.rbHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbHero.Location = new System.Drawing.Point(20, 27);
            this.rbHero.Name = "rbHero";
            this.rbHero.Size = new System.Drawing.Size(70, 28);
            this.rbHero.TabIndex = 1;
            this.rbHero.TabStop = true;
            this.rbHero.Text = "Hero";
            this.rbHero.UseVisualStyleBackColor = true;
            // 
            // rbVillain
            // 
            this.rbVillain.AutoSize = true;
            this.rbVillain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVillain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbVillain.Location = new System.Drawing.Point(20, 71);
            this.rbVillain.Name = "rbVillain";
            this.rbVillain.Size = new System.Drawing.Size(78, 28);
            this.rbVillain.TabIndex = 2;
            this.rbVillain.TabStop = true;
            this.rbVillain.Text = "Villain";
            this.rbVillain.UseVisualStyleBackColor = true;
            // 
            // outfits
            // 
            this.outfits.Controls.Add(this.chkHeroCustome);
            this.outfits.Controls.Add(this.chkSpace);
            this.outfits.Controls.Add(this.chkNinja);
            this.outfits.Controls.Add(this.chkUniform);
            this.outfits.Controls.Add(this.chkArmor);
            this.outfits.Controls.Add(this.chkCasual);
            this.outfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outfits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.outfits.Location = new System.Drawing.Point(191, 76);
            this.outfits.Name = "outfits";
            this.outfits.Size = new System.Drawing.Size(198, 222);
            this.outfits.TabIndex = 5;
            this.outfits.TabStop = false;
            this.outfits.Text = "Outfit";
            // 
            // chkCasual
            // 
            this.chkCasual.AutoSize = true;
            this.chkCasual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCasual.Location = new System.Drawing.Point(6, 27);
            this.chkCasual.Name = "chkCasual";
            this.chkCasual.Size = new System.Drawing.Size(135, 24);
            this.chkCasual.TabIndex = 0;
            this.chkCasual.Text = "Casual Clothes";
            this.chkCasual.UseVisualStyleBackColor = true;
            // 
            // chkArmor
            // 
            this.chkArmor.AutoSize = true;
            this.chkArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArmor.Location = new System.Drawing.Point(6, 58);
            this.chkArmor.Name = "chkArmor";
            this.chkArmor.Size = new System.Drawing.Size(117, 24);
            this.chkArmor.TabIndex = 1;
            this.chkArmor.Text = "Battle Armor";
            this.chkArmor.UseVisualStyleBackColor = true;
            // 
            // chkUniform
            // 
            this.chkUniform.AutoSize = true;
            this.chkUniform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUniform.Location = new System.Drawing.Point(6, 89);
            this.chkUniform.Name = "chkUniform";
            this.chkUniform.Size = new System.Drawing.Size(137, 24);
            this.chkUniform.TabIndex = 2;
            this.chkUniform.Text = "School Uniform";
            this.chkUniform.UseVisualStyleBackColor = true;
            // 
            // chkNinja
            // 
            this.chkNinja.AutoSize = true;
            this.chkNinja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNinja.Location = new System.Drawing.Point(6, 120);
            this.chkNinja.Name = "chkNinja";
            this.chkNinja.Size = new System.Drawing.Size(106, 24);
            this.chkNinja.TabIndex = 3;
            this.chkNinja.Text = "Ninja Outfit";
            this.chkNinja.UseVisualStyleBackColor = true;
            // 
            // chkSpace
            // 
            this.chkSpace.AutoSize = true;
            this.chkSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpace.Location = new System.Drawing.Point(6, 151);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(106, 24);
            this.chkSpace.TabIndex = 4;
            this.chkSpace.Text = "Space Suit";
            this.chkSpace.UseVisualStyleBackColor = true;
            // 
            // chkHeroCustome
            // 
            this.chkHeroCustome.AutoSize = true;
            this.chkHeroCustome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeroCustome.Location = new System.Drawing.Point(6, 182);
            this.chkHeroCustome.Name = "chkHeroCustome";
            this.chkHeroCustome.Size = new System.Drawing.Size(171, 24);
            this.chkHeroCustome.TabIndex = 5;
            this.chkHeroCustome.Text = "Superhero Costume";
            this.chkHeroCustome.UseVisualStyleBackColor = true;
            // 
            // weaponType
            // 
            this.weaponType.Controls.Add(this.rbStaff);
            this.weaponType.Controls.Add(this.rbFists);
            this.weaponType.Controls.Add(this.rbGun);
            this.weaponType.Controls.Add(this.rbSword);
            this.weaponType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.weaponType.Location = new System.Drawing.Point(3, 194);
            this.weaponType.Name = "weaponType";
            this.weaponType.Size = new System.Drawing.Size(177, 203);
            this.weaponType.TabIndex = 5;
            this.weaponType.TabStop = false;
            this.weaponType.Text = "Weapon Type";
            // 
            // rbGun
            // 
            this.rbGun.AutoSize = true;
            this.rbGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbGun.Location = new System.Drawing.Point(20, 67);
            this.rbGun.Name = "rbGun";
            this.rbGun.Size = new System.Drawing.Size(64, 28);
            this.rbGun.TabIndex = 2;
            this.rbGun.TabStop = true;
            this.rbGun.Text = "Gun";
            this.rbGun.UseVisualStyleBackColor = true;
            // 
            // rbSword
            // 
            this.rbSword.AutoSize = true;
            this.rbSword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbSword.Location = new System.Drawing.Point(20, 27);
            this.rbSword.Name = "rbSword";
            this.rbSword.Size = new System.Drawing.Size(82, 28);
            this.rbSword.TabIndex = 1;
            this.rbSword.TabStop = true;
            this.rbSword.Text = "Sword";
            this.rbSword.UseVisualStyleBackColor = true;
            // 
            // rbFists
            // 
            this.rbFists.AutoSize = true;
            this.rbFists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbFists.Location = new System.Drawing.Point(21, 147);
            this.rbFists.Name = "rbFists";
            this.rbFists.Size = new System.Drawing.Size(66, 28);
            this.rbFists.TabIndex = 4;
            this.rbFists.TabStop = true;
            this.rbFists.Text = "Fists";
            this.rbFists.UseVisualStyleBackColor = true;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbStaff.Location = new System.Drawing.Point(20, 107);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(118, 28);
            this.rbStaff.TabIndex = 5;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Magic Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // species
            // 
            this.species.Controls.Add(this.rbDryad);
            this.species.Controls.Add(this.rbAndroid);
            this.species.Controls.Add(this.rbElf);
            this.species.Controls.Add(this.rbVampire);
            this.species.Controls.Add(this.rbHuman);
            this.species.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.species.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.species.Location = new System.Drawing.Point(395, 76);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(177, 222);
            this.species.TabIndex = 6;
            this.species.TabStop = false;
            this.species.Text = "Species";
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.btnOrder.Location = new System.Drawing.Point(191, 330);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 50);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Character";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.btnReset.Location = new System.Drawing.Point(395, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(177, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Start Over";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbHuman.Location = new System.Drawing.Point(17, 26);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(79, 24);
            this.rbHuman.TabIndex = 3;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human";
            this.rbHuman.UseVisualStyleBackColor = true;
            // 
            // rbVampire
            // 
            this.rbVampire.AutoSize = true;
            this.rbVampire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVampire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbVampire.Location = new System.Drawing.Point(17, 62);
            this.rbVampire.Name = "rbVampire";
            this.rbVampire.Size = new System.Drawing.Size(86, 24);
            this.rbVampire.TabIndex = 4;
            this.rbVampire.TabStop = true;
            this.rbVampire.Text = "Vampire";
            this.rbVampire.UseVisualStyleBackColor = true;
            // 
            // rbElf
            // 
            this.rbElf.AutoSize = true;
            this.rbElf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbElf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbElf.Location = new System.Drawing.Point(17, 98);
            this.rbElf.Name = "rbElf";
            this.rbElf.Size = new System.Drawing.Size(46, 24);
            this.rbElf.TabIndex = 5;
            this.rbElf.TabStop = true;
            this.rbElf.Text = "Elf";
            this.rbElf.UseVisualStyleBackColor = true;
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAndroid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbAndroid.Location = new System.Drawing.Point(17, 134);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(82, 24);
            this.rbAndroid.TabIndex = 6;
            this.rbAndroid.TabStop = true;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbDryad
            // 
            this.rbDryad.AutoSize = true;
            this.rbDryad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDryad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.rbDryad.Location = new System.Drawing.Point(17, 170);
            this.rbDryad.Name = "rbDryad";
            this.rbDryad.Size = new System.Drawing.Size(69, 24);
            this.rbDryad.TabIndex = 7;
            this.rbDryad.TabStop = true;
            this.rbDryad.Text = "Dryad";
            this.rbDryad.UseVisualStyleBackColor = true;
            // 
            // lblSumarry
            // 
            this.lblSumarry.AutoSize = true;
            this.lblSumarry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.lblSumarry.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumarry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(179)))), ((int)(((byte)(169)))));
            this.lblSumarry.Location = new System.Drawing.Point(589, 76);
            this.lblSumarry.Name = "lblSumarry";
            this.lblSumarry.Size = new System.Drawing.Size(106, 25);
            this.lblSumarry.TabIndex = 8;
            this.lblSumarry.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.lblSumarry);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.species);
            this.Controls.Add(this.weaponType);
            this.Controls.Add(this.outfits);
            this.Controls.Add(this.CharType);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CharType.ResumeLayout(false);
            this.CharType.PerformLayout();
            this.outfits.ResumeLayout(false);
            this.outfits.PerformLayout();
            this.weaponType.ResumeLayout(false);
            this.weaponType.PerformLayout();
            this.species.ResumeLayout(false);
            this.species.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox CharType;
        private System.Windows.Forms.RadioButton rbVillain;
        private System.Windows.Forms.RadioButton rbHero;
        private System.Windows.Forms.GroupBox outfits;
        private System.Windows.Forms.CheckBox chkCasual;
        private System.Windows.Forms.CheckBox chkArmor;
        private System.Windows.Forms.CheckBox chkNinja;
        private System.Windows.Forms.CheckBox chkUniform;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.Windows.Forms.CheckBox chkHeroCustome;
        private System.Windows.Forms.GroupBox weaponType;
        private System.Windows.Forms.RadioButton rbGun;
        private System.Windows.Forms.RadioButton rbSword;
        private System.Windows.Forms.RadioButton rbFists;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.GroupBox species;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbDryad;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbElf;
        private System.Windows.Forms.RadioButton rbVampire;
        private System.Windows.Forms.Label lblSumarry;
    }
}

