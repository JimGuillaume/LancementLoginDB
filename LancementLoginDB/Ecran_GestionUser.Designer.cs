namespace LancementLoginDB
{
  partial class Ecran_GestionUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_GestionUser));
      dataGridView1 = new DataGridView();
      AddUser_Button = new Button();
      DelUser_Button = new Button();
      DisconnectUser_Button = new Button();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(12, 68);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.Size = new Size(300, 370);
      dataGridView1.TabIndex = 0;
      // 
      // AddUser_Button
      // 
      AddUser_Button.Location = new Point(12, 12);
      AddUser_Button.Name = "AddUser_Button";
      AddUser_Button.Size = new Size(96, 50);
      AddUser_Button.TabIndex = 1;
      AddUser_Button.Text = "+ User";
      AddUser_Button.UseVisualStyleBackColor = true;
      // 
      // DelUser_Button
      // 
      DelUser_Button.Location = new Point(114, 12);
      DelUser_Button.Name = "DelUser_Button";
      DelUser_Button.Size = new Size(96, 50);
      DelUser_Button.TabIndex = 2;
      DelUser_Button.Text = "- User";
      DelUser_Button.UseVisualStyleBackColor = true;
      // 
      // DisconnectUser_Button
      // 
      DisconnectUser_Button.Location = new Point(216, 12);
      DisconnectUser_Button.Name = "DisconnectUser_Button";
      DisconnectUser_Button.Size = new Size(96, 50);
      DisconnectUser_Button.TabIndex = 3;
      DisconnectUser_Button.Text = "Disconnect";
      DisconnectUser_Button.UseVisualStyleBackColor = true;
      // 
      // Ecran_GestionUser
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(330, 450);
      Controls.Add(DelUser_Button);
      Controls.Add(DisconnectUser_Button);
      Controls.Add(AddUser_Button);
      Controls.Add(dataGridView1);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "Ecran_GestionUser";
      Text = "Ecran_GestionUser";
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button AddUser_Button;
    private Button DelUser_Button;
    private Button DisconnectUser_Button;
  }
}