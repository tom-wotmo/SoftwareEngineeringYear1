namespace Soft152_Assignment
{
    partial class mainForm
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
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblNeighbourhood = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtNumberOfNeighbourhoods = new System.Windows.Forms.TextBox();
            this.btnDistrictEdit = new System.Windows.Forms.Button();
            this.btnDistrictAdd = new System.Windows.Forms.Button();
            this.txtNeighbourhoodName = new System.Windows.Forms.TextBox();
            this.txtNoOfNeighbourhoods = new System.Windows.Forms.TextBox();
            this.btnNeighbourhoodEdit = new System.Windows.Forms.Button();
            this.btnNeighbourhoodAdd = new System.Windows.Forms.Button();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtHostProperties = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMinimumNights = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPropertiesAdd = new System.Windows.Forms.Button();
            this.btnPropertiesEdit = new System.Windows.Forms.Button();
            this.btnDistrictClear = new System.Windows.Forms.Button();
            this.btnNeighbourhoodClear = new System.Windows.Forms.Button();
            this.btnPropertyClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 16;
            this.lstDistricts.Location = new System.Drawing.Point(16, 124);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(508, 84);
            this.lstDistricts.TabIndex = 0;
            this.lstDistricts.SelectedIndexChanged += new System.EventHandler(this.lstDistricts_SelectedIndexChanged);
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.ItemHeight = 16;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(16, 234);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(508, 100);
            this.lstNeighbourhoods.TabIndex = 1;
            this.lstNeighbourhoods.SelectedIndexChanged += new System.EventHandler(this.lstNeighbourhoods_SelectedIndexChanged);
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 16;
            this.lstProperties.Location = new System.Drawing.Point(16, 360);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(752, 100);
            this.lstProperties.TabIndex = 2;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Soft152_Assignment.Properties.Resources.airbnb;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(12, 101);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(70, 20);
            this.lblDistrict.TabIndex = 4;
            this.lblDistrict.Text = "Districts:";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhood.Location = new System.Drawing.Point(12, 211);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(130, 20);
            this.lblNeighbourhood.TabIndex = 5;
            this.lblNeighbourhood.Text = "Neighbourhoods:";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(12, 337);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(85, 20);
            this.lblProperties.TabIndex = 6;
            this.lblProperties.Text = "Properties:";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(548, 124);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(190, 20);
            this.txtDistrictName.TabIndex = 7;
            // 
            // txtNumberOfNeighbourhoods
            // 
            this.txtNumberOfNeighbourhoods.Location = new System.Drawing.Point(548, 170);
            this.txtNumberOfNeighbourhoods.Name = "txtNumberOfNeighbourhoods";
            this.txtNumberOfNeighbourhoods.Size = new System.Drawing.Size(190, 20);
            this.txtNumberOfNeighbourhoods.TabIndex = 8;
            // 
            // btnDistrictEdit
            // 
            this.btnDistrictEdit.Location = new System.Drawing.Point(548, 196);
            this.btnDistrictEdit.Name = "btnDistrictEdit";
            this.btnDistrictEdit.Size = new System.Drawing.Size(73, 32);
            this.btnDistrictEdit.TabIndex = 9;
            this.btnDistrictEdit.Text = "Edit";
            this.btnDistrictEdit.UseVisualStyleBackColor = true;
            this.btnDistrictEdit.Click += new System.EventHandler(this.btnDistrictEdit_Click);
            // 
            // btnDistrictAdd
            // 
            this.btnDistrictAdd.Location = new System.Drawing.Point(627, 196);
            this.btnDistrictAdd.Name = "btnDistrictAdd";
            this.btnDistrictAdd.Size = new System.Drawing.Size(69, 32);
            this.btnDistrictAdd.TabIndex = 10;
            this.btnDistrictAdd.Text = "Add";
            this.btnDistrictAdd.UseVisualStyleBackColor = true;
            this.btnDistrictAdd.Click += new System.EventHandler(this.btnDistrictAdd_Click);
            // 
            // txtNeighbourhoodName
            // 
            this.txtNeighbourhoodName.Location = new System.Drawing.Point(548, 250);
            this.txtNeighbourhoodName.Name = "txtNeighbourhoodName";
            this.txtNeighbourhoodName.Size = new System.Drawing.Size(190, 20);
            this.txtNeighbourhoodName.TabIndex = 11;
            // 
            // txtNoOfNeighbourhoods
            // 
            this.txtNoOfNeighbourhoods.Location = new System.Drawing.Point(548, 297);
            this.txtNoOfNeighbourhoods.Name = "txtNoOfNeighbourhoods";
            this.txtNoOfNeighbourhoods.Size = new System.Drawing.Size(190, 20);
            this.txtNoOfNeighbourhoods.TabIndex = 12;
            // 
            // btnNeighbourhoodEdit
            // 
            this.btnNeighbourhoodEdit.Location = new System.Drawing.Point(548, 323);
            this.btnNeighbourhoodEdit.Name = "btnNeighbourhoodEdit";
            this.btnNeighbourhoodEdit.Size = new System.Drawing.Size(73, 32);
            this.btnNeighbourhoodEdit.TabIndex = 13;
            this.btnNeighbourhoodEdit.Text = "Edit";
            this.btnNeighbourhoodEdit.UseVisualStyleBackColor = true;
            this.btnNeighbourhoodEdit.Click += new System.EventHandler(this.btnNeighbourhoodEdit_Click);
            // 
            // btnNeighbourhoodAdd
            // 
            this.btnNeighbourhoodAdd.Location = new System.Drawing.Point(627, 323);
            this.btnNeighbourhoodAdd.Name = "btnNeighbourhoodAdd";
            this.btnNeighbourhoodAdd.Size = new System.Drawing.Size(69, 32);
            this.btnNeighbourhoodAdd.TabIndex = 14;
            this.btnNeighbourhoodAdd.Text = "Add";
            this.btnNeighbourhoodAdd.UseVisualStyleBackColor = true;
            this.btnNeighbourhoodAdd.Click += new System.EventHandler(this.btnNeighbourhoodAdd_Click);
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(17, 487);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.Size = new System.Drawing.Size(190, 20);
            this.txtPropertyID.TabIndex = 15;
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(16, 530);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(190, 20);
            this.txtPropertyName.TabIndex = 16;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(16, 620);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(190, 20);
            this.txtHostName.TabIndex = 17;
            // 
            // txtHostProperties
            // 
            this.txtHostProperties.Location = new System.Drawing.Point(16, 663);
            this.txtHostProperties.Name = "txtHostProperties";
            this.txtHostProperties.Size = new System.Drawing.Size(190, 20);
            this.txtHostProperties.TabIndex = 18;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(334, 487);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(190, 20);
            this.txtLatitude.TabIndex = 19;
            this.txtLatitude.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(334, 530);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(190, 20);
            this.txtLongitude.TabIndex = 20;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(334, 573);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(190, 20);
            this.txtRoomType.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(334, 620);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // txtMinimumNights
            // 
            this.txtMinimumNights.Location = new System.Drawing.Point(334, 663);
            this.txtMinimumNights.Name = "txtMinimumNights";
            this.txtMinimumNights.Size = new System.Drawing.Size(190, 20);
            this.txtMinimumNights.TabIndex = 23;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(334, 710);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(190, 20);
            this.txtAvailability.TabIndex = 24;
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(17, 573);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(190, 20);
            this.txtHostID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "District name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Number of Neighbourhoods:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Neighbourhood Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Number of Properties:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Property ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Property Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "HostID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Host Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 643);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Host Properties:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Latitude:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(331, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Longitude:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Room Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(333, 600);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(333, 643);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Minimum Nights:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(331, 686);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "Yearly Availability(Days):";
            // 
            // btnPropertiesAdd
            // 
            this.btnPropertiesAdd.Location = new System.Drawing.Point(17, 698);
            this.btnPropertiesAdd.Name = "btnPropertiesAdd";
            this.btnPropertiesAdd.Size = new System.Drawing.Size(72, 32);
            this.btnPropertiesAdd.TabIndex = 41;
            this.btnPropertiesAdd.Text = "Add";
            this.btnPropertiesAdd.UseVisualStyleBackColor = true;
            this.btnPropertiesAdd.Click += new System.EventHandler(this.BtnPropertiesAdd_Click);
            // 
            // btnPropertiesEdit
            // 
            this.btnPropertiesEdit.Location = new System.Drawing.Point(95, 698);
            this.btnPropertiesEdit.Name = "btnPropertiesEdit";
            this.btnPropertiesEdit.Size = new System.Drawing.Size(67, 32);
            this.btnPropertiesEdit.TabIndex = 42;
            this.btnPropertiesEdit.Text = "Edit";
            this.btnPropertiesEdit.UseVisualStyleBackColor = true;
            // 
            // btnDistrictClear
            // 
            this.btnDistrictClear.Location = new System.Drawing.Point(702, 196);
            this.btnDistrictClear.Name = "btnDistrictClear";
            this.btnDistrictClear.Size = new System.Drawing.Size(66, 32);
            this.btnDistrictClear.TabIndex = 43;
            this.btnDistrictClear.Text = "Clear";
            this.btnDistrictClear.UseVisualStyleBackColor = true;
            this.btnDistrictClear.Click += new System.EventHandler(this.btnDistrictClear_Click);
            // 
            // btnNeighbourhoodClear
            // 
            this.btnNeighbourhoodClear.Location = new System.Drawing.Point(702, 323);
            this.btnNeighbourhoodClear.Name = "btnNeighbourhoodClear";
            this.btnNeighbourhoodClear.Size = new System.Drawing.Size(66, 32);
            this.btnNeighbourhoodClear.TabIndex = 44;
            this.btnNeighbourhoodClear.Text = "Clear";
            this.btnNeighbourhoodClear.UseVisualStyleBackColor = true;
            this.btnNeighbourhoodClear.Click += new System.EventHandler(this.btnNeighbourhoodClear_Click);
            // 
            // btnPropertyClear
            // 
            this.btnPropertyClear.Location = new System.Drawing.Point(168, 698);
            this.btnPropertyClear.Name = "btnPropertyClear";
            this.btnPropertyClear.Size = new System.Drawing.Size(67, 32);
            this.btnPropertyClear.TabIndex = 45;
            this.btnPropertyClear.Text = "Clear";
            this.btnPropertyClear.UseVisualStyleBackColor = true;
            this.btnPropertyClear.Click += new System.EventHandler(this.btnPropertyClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(627, 703);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "EXIT APPLICATION";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(559, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "Click to Expand Property details";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 768);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPropertyClear);
            this.Controls.Add(this.btnNeighbourhoodClear);
            this.Controls.Add(this.btnDistrictClear);
            this.Controls.Add(this.btnPropertiesEdit);
            this.Controls.Add(this.btnPropertiesAdd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHostID);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.txtMinimumNights);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtHostProperties);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.txtPropertyName);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.btnNeighbourhoodAdd);
            this.Controls.Add(this.btnNeighbourhoodEdit);
            this.Controls.Add(this.txtNoOfNeighbourhoods);
            this.Controls.Add(this.txtNeighbourhoodName);
            this.Controls.Add(this.btnDistrictAdd);
            this.Controls.Add(this.btnDistrictEdit);
            this.Controls.Add(this.txtNumberOfNeighbourhoods);
            this.Controls.Add(this.txtDistrictName);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblNeighbourhood);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "mainForm";
            this.Text = "Admin Airbnb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblNeighbourhood;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtNumberOfNeighbourhoods;
        private System.Windows.Forms.Button btnDistrictEdit;
        private System.Windows.Forms.Button btnDistrictAdd;
        private System.Windows.Forms.TextBox txtNeighbourhoodName;
        private System.Windows.Forms.TextBox txtNoOfNeighbourhoods;
        private System.Windows.Forms.Button btnNeighbourhoodEdit;
        private System.Windows.Forms.Button btnNeighbourhoodAdd;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtHostProperties;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMinimumNights;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPropertiesAdd;
        private System.Windows.Forms.Button btnPropertiesEdit;
        private System.Windows.Forms.Button btnDistrictClear;
        private System.Windows.Forms.Button btnNeighbourhoodClear;
        private System.Windows.Forms.Button btnPropertyClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label16;
    }
}

