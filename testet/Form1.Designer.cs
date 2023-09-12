namespace testet;

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
        btnFlytta = new Button();
        tbxX = new TextBox();
        tbxY = new TextBox();
        lblX = new Label();
        lblY = new Label();
        SuspendLayout();
        // 
        // btnFlytta
        // 
        btnFlytta.Location = new Point(23, 283);
        btnFlytta.Name = "btnFlytta";
        btnFlytta.Size = new Size(75, 23);
        btnFlytta.TabIndex = 0;
        btnFlytta.Text = "Flytta";
        btnFlytta.UseVisualStyleBackColor = true;
        btnFlytta.Click += btnFlytta_Click;
        // 
        // tbxX
        // 
        tbxX.Location = new Point(245, 186);
        tbxX.Name = "tbxX";
        tbxX.Size = new Size(100, 23);
        tbxX.TabIndex = 1;
        // 
        // tbxY
        // 
        tbxY.Location = new Point(449, 186);
        tbxY.Name = "tbxY";
        tbxY.Size = new Size(100, 23);
        tbxY.TabIndex = 2;
        // 
        // lblX
        // 
        lblX.AutoSize = true;
        lblX.Location = new Point(245, 142);
        lblX.Name = "lblX";
        lblX.Size = new Size(13, 15);
        lblX.TabIndex = 3;
        lblX.Text = "x";
        // 
        // lblY
        // 
        lblY.AutoSize = true;
        lblY.Location = new Point(449, 142);
        lblY.Name = "lblY";
        lblY.Size = new Size(13, 15);
        lblY.TabIndex = 4;
        lblY.Text = "y";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblY);
        Controls.Add(lblX);
        Controls.Add(tbxY);
        Controls.Add(tbxX);
        Controls.Add(btnFlytta);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnFlytta;
    private TextBox tbxX;
    private TextBox tbxY;
    private Label lblX;
    private Label lblY;
}
