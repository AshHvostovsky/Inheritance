namespace Inheritance
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(326, 23);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(216, 83);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(122, 96);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 41);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(326, 36);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 83);
            txtOut.Name = "txtOut";
            txtOut.ReadOnly = true;
            txtOut.Size = new Size(198, 96);
            txtOut.TabIndex = 4;
            txtOut.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Очередь";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "planet.png");
            imageList1.Images.SetKeyName(1, "star.png");
            imageList1.Images.SetKeyName(2, "meteor.png");
            // 
            // listView1
            // 
            listView1.Location = new Point(356, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 152);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 190);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Label label1;
        private ImageList imageList1;
        private ListView listView1;
    }
}
