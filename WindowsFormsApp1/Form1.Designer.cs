namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P1Score = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.P2Score = new System.Windows.Forms.NumericUpDown();
            this.P1Tag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P2Tag = new System.Windows.Forms.ComboBox();
            this.Comm1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Comm2 = new System.Windows.Forms.ComboBox();
            this.MatchName = new System.Windows.Forms.ComboBox();
            this.EventName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.P1Character = new System.Windows.Forms.ComboBox();
            this.P2Character = new System.Windows.Forms.ComboBox();
            this.StockIcons = new System.Windows.Forms.ImageList(this.components);
            this.P1Colour = new System.Windows.Forms.ComboBox();
            this.P2Colour = new System.Windows.Forms.ComboBox();
            this.P1Icon = new System.Windows.Forms.PictureBox();
            this.P2Icon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.P1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // P1Score
            // 
            this.P1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.P1Score.Location = new System.Drawing.Point(8, 8);
            this.P1Score.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.P1Score.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(70, 30);
            this.P1Score.TabIndex = 0;
            this.P1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(287, 112);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(387, 20);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveBoard);
            // 
            // P2Score
            // 
            this.P2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.P2Score.Location = new System.Drawing.Point(889, 8);
            this.P2Score.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.P2Score.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(70, 30);
            this.P2Score.TabIndex = 3;
            this.P2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2Score.ValueChanged += new System.EventHandler(this.P2Score_ValueChanged);
            // 
            // P1Tag
            // 
            this.P1Tag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.P1Tag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.P1Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Tag.FormattingEnabled = true;
            this.P1Tag.ItemHeight = 25;
            this.P1Tag.Location = new System.Drawing.Point(89, 5);
            this.P1Tag.MaxDropDownItems = 5;
            this.P1Tag.Name = "P1Tag";
            this.P1Tag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.P1Tag.Size = new System.Drawing.Size(393, 33);
            this.P1Tag.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P1 Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "P2 Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "P1 Tag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "P2 Tag";
            // 
            // P2Tag
            // 
            this.P2Tag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.P2Tag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.P2Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.P2Tag.FormattingEnabled = true;
            this.P2Tag.Location = new System.Drawing.Point(488, 5);
            this.P2Tag.MaxDropDownItems = 5;
            this.P2Tag.Name = "P2Tag";
            this.P2Tag.Size = new System.Drawing.Size(391, 33);
            this.P2Tag.TabIndex = 10;
            // 
            // Comm1
            // 
            this.Comm1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Comm1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Comm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comm1.FormattingEnabled = true;
            this.Comm1.Location = new System.Drawing.Point(134, 40);
            this.Comm1.MaxDropDownItems = 5;
            this.Comm1.Name = "Comm1";
            this.Comm1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Comm1.Size = new System.Drawing.Size(348, 33);
            this.Comm1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Commentator 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(754, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Commentator 2";
            // 
            // Comm2
            // 
            this.Comm2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Comm2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Comm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comm2.FormattingEnabled = true;
            this.Comm2.Location = new System.Drawing.Point(487, 40);
            this.Comm2.MaxDropDownItems = 5;
            this.Comm2.Name = "Comm2";
            this.Comm2.Size = new System.Drawing.Size(345, 33);
            this.Comm2.TabIndex = 15;
            // 
            // MatchName
            // 
            this.MatchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MatchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchName.FormattingEnabled = true;
            this.MatchName.Items.AddRange(new object[] {
            "Winners\'",
            "Loser\'s",
            "Pools",
            "WQs",
            "WSs",
            "WFs",
            "LQs",
            "LSs",
            "LFs",
            "GFs"});
            this.MatchName.Location = new System.Drawing.Point(215, 74);
            this.MatchName.Name = "MatchName";
            this.MatchName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MatchName.Size = new System.Drawing.Size(267, 33);
            this.MatchName.TabIndex = 16;
            this.MatchName.SelectedIndexChanged += new System.EventHandler(this.MatchName_SelectedIndexChanged);
            // 
            // EventName
            // 
            this.EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.FormattingEnabled = true;
            this.EventName.Location = new System.Drawing.Point(487, 74);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(264, 33);
            this.EventName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Match Round";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(685, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Event Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "P1 Character/Colour";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(859, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "P2 Character/Colour";
            // 
            // P1Character
            // 
            this.P1Character.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P1Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Character.FormattingEnabled = true;
            this.P1Character.Items.AddRange(new object[] {
            "(none)",
            "Fox",
            "Falco",
            "Marth",
            "Sheik",
            "Jigglypuff",
            "Peach",
            "Ice Climbers",
            "Captain Falcon",
            "Pikachu",
            "Samus",
            "Doctor Mario",
            "Yoshi",
            "Luigi",
            "Ganondorf",
            "Mario",
            "Young Link",
            "Donkey Kong",
            "Link",
            "Game and Watch",
            "Roy",
            "Mewtwo",
            "Zelda",
            "Ness",
            "Pichu",
            "Bowser",
            "Kirby"});
            this.P1Character.Location = new System.Drawing.Point(4, 53);
            this.P1Character.Name = "P1Character";
            this.P1Character.Size = new System.Drawing.Size(122, 21);
            this.P1Character.TabIndex = 21;
            this.P1Character.SelectedIndexChanged += new System.EventHandler(this.P1CharacterChange);
            // 
            // P2Character
            // 
            this.P2Character.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P2Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Character.FormattingEnabled = true;
            this.P2Character.Items.AddRange(new object[] {
            "(none)",
            "Fox",
            "Falco",
            "Marth",
            "Sheik",
            "Jigglypuff",
            "Peach",
            "Ice Climbers",
            "Captain Falcon",
            "Pikachu",
            "Samus",
            "Doctor Mario",
            "Yoshi",
            "Luigi",
            "Ganondorf",
            "Mario",
            "Young Link",
            "Donkey Kong",
            "Link",
            "Game and Watch",
            "Roy",
            "Mewtwo",
            "Zelda",
            "Ness",
            "Pichu",
            "Bowser",
            "Kirby"});
            this.P2Character.Location = new System.Drawing.Point(838, 53);
            this.P2Character.Name = "P2Character";
            this.P2Character.Size = new System.Drawing.Size(121, 21);
            this.P2Character.TabIndex = 21;
            this.P2Character.SelectedIndexChanged += new System.EventHandler(this.P2CharacterChange);
            // 
            // StockIcons
            // 
            this.StockIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StockIcons.ImageStream")));
            this.StockIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.StockIcons.Images.SetKeyName(0, "000000.png");
            this.StockIcons.Images.SetKeyName(1, "BOWDEF.png");
            this.StockIcons.Images.SetKeyName(2, "BOWRED.png");
            this.StockIcons.Images.SetKeyName(3, "BOWBLU.png");
            this.StockIcons.Images.SetKeyName(4, "BOWBLK.png");
            this.StockIcons.Images.SetKeyName(5, "CPTDEF.png");
            this.StockIcons.Images.SetKeyName(6, "CPTBLK.png");
            this.StockIcons.Images.SetKeyName(7, "CPTRED.png");
            this.StockIcons.Images.SetKeyName(8, "CPTWHT.png");
            this.StockIcons.Images.SetKeyName(9, "CPTGRN.png");
            this.StockIcons.Images.SetKeyName(10, "CPTBLU.png");
            this.StockIcons.Images.SetKeyName(11, "DKGDEF.png");
            this.StockIcons.Images.SetKeyName(12, "DKGBLK.png");
            this.StockIcons.Images.SetKeyName(13, "DKGRED.png");
            this.StockIcons.Images.SetKeyName(14, "DKGBLU.png");
            this.StockIcons.Images.SetKeyName(15, "DKGGRN.png");
            this.StockIcons.Images.SetKeyName(16, "DOCDEF.png");
            this.StockIcons.Images.SetKeyName(17, "DOCRED.png");
            this.StockIcons.Images.SetKeyName(18, "DOCBLU.png");
            this.StockIcons.Images.SetKeyName(19, "DOCGRN.png");
            this.StockIcons.Images.SetKeyName(20, "DOCBLK.png");
            this.StockIcons.Images.SetKeyName(21, "FALDEF.png");
            this.StockIcons.Images.SetKeyName(22, "FALRED.png");
            this.StockIcons.Images.SetKeyName(23, "FALBLU.png");
            this.StockIcons.Images.SetKeyName(24, "FALGRN.png");
            this.StockIcons.Images.SetKeyName(25, "FOXDEF.png");
            this.StockIcons.Images.SetKeyName(26, "FOXRED.png");
            this.StockIcons.Images.SetKeyName(27, "FOXBLU.png");
            this.StockIcons.Images.SetKeyName(28, "FOXGRN.png");
            this.StockIcons.Images.SetKeyName(29, "GANDEF.png");
            this.StockIcons.Images.SetKeyName(30, "GANRED.png");
            this.StockIcons.Images.SetKeyName(31, "GANBLU.png");
            this.StockIcons.Images.SetKeyName(32, "GANGRN.png");
            this.StockIcons.Images.SetKeyName(33, "GANPRP.png");
            this.StockIcons.Images.SetKeyName(34, "GNWDEF.png");
            this.StockIcons.Images.SetKeyName(35, "GNWRED.png");
            this.StockIcons.Images.SetKeyName(36, "GNWBLU.png");
            this.StockIcons.Images.SetKeyName(37, "GNWGRN.png");
            this.StockIcons.Images.SetKeyName(38, "ICSDEF.png");
            this.StockIcons.Images.SetKeyName(39, "ICSGRN.png");
            this.StockIcons.Images.SetKeyName(40, "ICSORA.png");
            this.StockIcons.Images.SetKeyName(41, "ICSRED.png");
            this.StockIcons.Images.SetKeyName(42, "KIRDEF.png");
            this.StockIcons.Images.SetKeyName(43, "KIRYLW.png");
            this.StockIcons.Images.SetKeyName(44, "KIRBLU.png");
            this.StockIcons.Images.SetKeyName(45, "KIRRED.png");
            this.StockIcons.Images.SetKeyName(46, "KIRGRN.png");
            this.StockIcons.Images.SetKeyName(47, "KIRWHT.png");
            this.StockIcons.Images.SetKeyName(48, "LNKDEF.png");
            this.StockIcons.Images.SetKeyName(49, "LNKRED.png");
            this.StockIcons.Images.SetKeyName(50, "LNKBLU.png");
            this.StockIcons.Images.SetKeyName(51, "LNKBLK.png");
            this.StockIcons.Images.SetKeyName(52, "LNKWHT.png");
            this.StockIcons.Images.SetKeyName(53, "LUIDEF.png");
            this.StockIcons.Images.SetKeyName(54, "LUIWHT.png");
            this.StockIcons.Images.SetKeyName(55, "LUIBLU.png");
            this.StockIcons.Images.SetKeyName(56, "LUIRED.png");
            this.StockIcons.Images.SetKeyName(57, "MARDEF.png");
            this.StockIcons.Images.SetKeyName(58, "MARYLW.png");
            this.StockIcons.Images.SetKeyName(59, "MARBLK.png");
            this.StockIcons.Images.SetKeyName(60, "MARBLU.png");
            this.StockIcons.Images.SetKeyName(61, "MARGRN.png");
            this.StockIcons.Images.SetKeyName(62, "MEWDEF.png");
            this.StockIcons.Images.SetKeyName(63, "MEWRED.png");
            this.StockIcons.Images.SetKeyName(64, "MEWBLU.png");
            this.StockIcons.Images.SetKeyName(65, "MEWGRN.png");
            this.StockIcons.Images.SetKeyName(66, "MRTDEF.png");
            this.StockIcons.Images.SetKeyName(67, "MRTRED.png");
            this.StockIcons.Images.SetKeyName(68, "MRTGRN.png");
            this.StockIcons.Images.SetKeyName(69, "MRTBLK.png");
            this.StockIcons.Images.SetKeyName(70, "MRTWHT.png");
            this.StockIcons.Images.SetKeyName(71, "NESDEF.png");
            this.StockIcons.Images.SetKeyName(72, "NESYLW.png");
            this.StockIcons.Images.SetKeyName(73, "NESBLU.png");
            this.StockIcons.Images.SetKeyName(74, "NESGRN.png");
            this.StockIcons.Images.SetKeyName(75, "PCHDEF.png");
            this.StockIcons.Images.SetKeyName(76, "PCHRED.png");
            this.StockIcons.Images.SetKeyName(77, "PCHBLU.png");
            this.StockIcons.Images.SetKeyName(78, "PCHGRN.png");
            this.StockIcons.Images.SetKeyName(79, "PEADEF.png");
            this.StockIcons.Images.SetKeyName(80, "PEAYLW.png");
            this.StockIcons.Images.SetKeyName(81, "PEAWHT.png");
            this.StockIcons.Images.SetKeyName(82, "PEABLU.png");
            this.StockIcons.Images.SetKeyName(83, "PEAGRN.png");
            this.StockIcons.Images.SetKeyName(84, "PIKDEF.png");
            this.StockIcons.Images.SetKeyName(85, "PIKRED.png");
            this.StockIcons.Images.SetKeyName(86, "PIKBLU.png");
            this.StockIcons.Images.SetKeyName(87, "PIKGRN.png");
            this.StockIcons.Images.SetKeyName(88, "PUFDEF.png");
            this.StockIcons.Images.SetKeyName(89, "PUFRED.png");
            this.StockIcons.Images.SetKeyName(90, "PUFBLU.png");
            this.StockIcons.Images.SetKeyName(91, "PUFGRN.png");
            this.StockIcons.Images.SetKeyName(92, "PUFYLW.png");
            this.StockIcons.Images.SetKeyName(93, "ROYDEF.png");
            this.StockIcons.Images.SetKeyName(94, "ROYRED.png");
            this.StockIcons.Images.SetKeyName(95, "ROYBLU.png");
            this.StockIcons.Images.SetKeyName(96, "ROYGRN.png");
            this.StockIcons.Images.SetKeyName(97, "ROYYLW.png");
            this.StockIcons.Images.SetKeyName(98, "SAMDEF.png");
            this.StockIcons.Images.SetKeyName(99, "SAMPNK.png");
            this.StockIcons.Images.SetKeyName(100, "SAMBLK.png");
            this.StockIcons.Images.SetKeyName(101, "SAMGRN.png");
            this.StockIcons.Images.SetKeyName(102, "SAMBLU.png");
            this.StockIcons.Images.SetKeyName(103, "SHKDEF.png");
            this.StockIcons.Images.SetKeyName(104, "SHKRED.png");
            this.StockIcons.Images.SetKeyName(105, "SHKBLU.png");
            this.StockIcons.Images.SetKeyName(106, "SHKGRN.png");
            this.StockIcons.Images.SetKeyName(107, "SHKWHT.png");
            this.StockIcons.Images.SetKeyName(108, "YLKDEF.png");
            this.StockIcons.Images.SetKeyName(109, "YLKRED.png");
            this.StockIcons.Images.SetKeyName(110, "YLKBLU.png");
            this.StockIcons.Images.SetKeyName(111, "YLKWHT.png");
            this.StockIcons.Images.SetKeyName(112, "YLKBLK.png");
            this.StockIcons.Images.SetKeyName(113, "YOSDEF.png");
            this.StockIcons.Images.SetKeyName(114, "YOSRED.png");
            this.StockIcons.Images.SetKeyName(115, "YOSBLU.png");
            this.StockIcons.Images.SetKeyName(116, "YOSYLW.png");
            this.StockIcons.Images.SetKeyName(117, "YOSPNK.png");
            this.StockIcons.Images.SetKeyName(118, "YOSCYN.png");
            this.StockIcons.Images.SetKeyName(119, "ZLDDEF.png");
            this.StockIcons.Images.SetKeyName(120, "ZLDRED.png");
            this.StockIcons.Images.SetKeyName(121, "ZLDBLU.png");
            this.StockIcons.Images.SetKeyName(122, "ZLDGRN.png");
            this.StockIcons.Images.SetKeyName(123, "ZLDWHT.png");
            // 
            // P1Colour
            // 
            this.P1Colour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P1Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Colour.FormattingEnabled = true;
            this.P1Colour.Location = new System.Drawing.Point(3, 76);
            this.P1Colour.Name = "P1Colour";
            this.P1Colour.Size = new System.Drawing.Size(122, 21);
            this.P1Colour.TabIndex = 21;
            this.P1Colour.SelectedIndexChanged += new System.EventHandler(this.P1ColourChange);
            // 
            // P2Colour
            // 
            this.P2Colour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P2Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Colour.FormattingEnabled = true;
            this.P2Colour.Location = new System.Drawing.Point(837, 76);
            this.P2Colour.Name = "P2Colour";
            this.P2Colour.Size = new System.Drawing.Size(122, 21);
            this.P2Colour.TabIndex = 21;
            this.P2Colour.SelectedIndexChanged += new System.EventHandler(this.P2ColourChange);
            // 
            // P1Icon
            // 
            this.P1Icon.Location = new System.Drawing.Point(134, 88);
            this.P1Icon.Name = "P1Icon";
            this.P1Icon.Size = new System.Drawing.Size(75, 44);
            this.P1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P1Icon.TabIndex = 22;
            this.P1Icon.TabStop = false;
            // 
            // P2Icon
            // 
            this.P2Icon.Location = new System.Drawing.Point(756, 88);
            this.P2Icon.Name = "P2Icon";
            this.P2Icon.Size = new System.Drawing.Size(74, 44);
            this.P2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P2Icon.TabIndex = 22;
            this.P2Icon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 23;
            this.button1.Text = "Change Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectDirectory_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(839, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 20);
            this.button2.TabIndex = 23;
            this.button2.Text = "Swap Players";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SwapPlayers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P2Icon);
            this.Controls.Add(this.P1Icon);
            this.Controls.Add(this.P2Character);
            this.Controls.Add(this.P2Colour);
            this.Controls.Add(this.P1Colour);
            this.Controls.Add(this.P1Character);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.MatchName);
            this.Controls.Add(this.Comm2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Comm1);
            this.Controls.Add(this.P2Tag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P1Tag);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.P1Score);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sergio\'s Supreme Smash Scoreboard Software: Sibilance Series";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown P1Score;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown P2Score;
        private System.Windows.Forms.ComboBox P1Tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox P2Tag;
        private System.Windows.Forms.ComboBox Comm1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Comm2;
        private System.Windows.Forms.ComboBox MatchName;
        private System.Windows.Forms.ComboBox EventName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox P1Character;
        private System.Windows.Forms.ComboBox P2Character;
        private System.Windows.Forms.ImageList StockIcons;
        private System.Windows.Forms.ComboBox P1Colour;
        private System.Windows.Forms.ComboBox P2Colour;
        private System.Windows.Forms.PictureBox P1Icon;
        private System.Windows.Forms.PictureBox P2Icon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

