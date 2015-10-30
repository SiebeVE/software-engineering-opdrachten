namespace YathzeeTeerling
{
  partial class YahtzeeView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.gooiAlleTeerlingen = new System.Windows.Forms.Button();
      this.startOpnieuw = new System.Windows.Forms.Button();
      this.highscore = new System.Windows.Forms.Label();
      this.huidig = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // gooiAlleTeerlingen
      // 
      this.gooiAlleTeerlingen.Location = new System.Drawing.Point(19, 166);
      this.gooiAlleTeerlingen.Name = "gooiAlleTeerlingen";
      this.gooiAlleTeerlingen.Size = new System.Drawing.Size(80, 23);
      this.gooiAlleTeerlingen.TabIndex = 0;
      this.gooiAlleTeerlingen.Text = "Gooi allemaal";
      this.gooiAlleTeerlingen.UseVisualStyleBackColor = true;
      this.gooiAlleTeerlingen.Click += new System.EventHandler(this.gooiAlleTeerlingen_Click);
      // 
      // startOpnieuw
      // 
      this.startOpnieuw.Location = new System.Drawing.Point(105, 166);
      this.startOpnieuw.Name = "startOpnieuw";
      this.startOpnieuw.Size = new System.Drawing.Size(92, 23);
      this.startOpnieuw.TabIndex = 1;
      this.startOpnieuw.Text = "Start opnieuw";
      this.startOpnieuw.UseVisualStyleBackColor = true;
      this.startOpnieuw.Click += new System.EventHandler(this.startOpnieuw_Click);
      // 
      // highscore
      // 
      this.highscore.AutoSize = true;
      this.highscore.Location = new System.Drawing.Point(204, 175);
      this.highscore.Name = "highscore";
      this.highscore.Size = new System.Drawing.Size(35, 13);
      this.highscore.TabIndex = 2;
      this.highscore.Text = "label1";
      // 
      // huidig
      // 
      this.huidig.AutoSize = true;
      this.huidig.Location = new System.Drawing.Point(104, 93);
      this.huidig.Name = "huidig";
      this.huidig.Size = new System.Drawing.Size(35, 13);
      this.huidig.TabIndex = 3;
      this.huidig.Text = "label1";
      // 
      // YahtzeeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.huidig);
      this.Controls.Add(this.highscore);
      this.Controls.Add(this.startOpnieuw);
      this.Controls.Add(this.gooiAlleTeerlingen);
      this.Name = "YahtzeeView";
      this.Size = new System.Drawing.Size(242, 199);
      this.Load += new System.EventHandler(this.YahtzeeView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button gooiAlleTeerlingen;
    private System.Windows.Forms.Button startOpnieuw;
    private System.Windows.Forms.Label highscore;
    private System.Windows.Forms.Label huidig;
  }
}
