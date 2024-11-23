namespace SimuladorDeUniverso2D
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox massaTextBox;
        private System.Windows.Forms.TextBox posXTextBox;
        private System.Windows.Forms.TextBox posYTextBox;
        private System.Windows.Forms.TextBox velXTextBox;
        private System.Windows.Forms.TextBox velYTextBox;
        private System.Windows.Forms.TextBox densidadeTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.displayPanel = new System.Windows.Forms.Panel();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.massaTextBox = new System.Windows.Forms.TextBox();
            this.posXTextBox = new System.Windows.Forms.TextBox();
            this.posYTextBox = new System.Windows.Forms.TextBox();
            this.velXTextBox = new System.Windows.Forms.TextBox();
            this.velYTextBox = new System.Windows.Forms.TextBox();
            this.densidadeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Location = new System.Drawing.Point(130, 12);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(650, 426);
            this.displayPanel.TabIndex = 0;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(12, 215);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(100, 23);
            this.adicionarButton.TabIndex = 7;
            this.adicionarButton.Text = "Adicionar Corpo";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 244);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Iniciar Simulação";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(12, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 23);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.PlaceholderText = "Nome";
            // 
            // massaTextBox
            // 
            this.massaTextBox.Location = new System.Drawing.Point(12, 41);
            this.massaTextBox.Name = "massaTextBox";
            this.massaTextBox.Size = new System.Drawing.Size(100, 23);
            this.massaTextBox.TabIndex = 1;
            this.massaTextBox.PlaceholderText = "Massa (kg)";
            // 
            // posXTextBox
            // 
            this.posXTextBox.Location = new System.Drawing.Point(12, 70);
            this.posXTextBox.Name = "posXTextBox";
            this.posXTextBox.Size = new System.Drawing.Size(100, 23);
            this.posXTextBox.TabIndex = 2;
            this.posXTextBox.PlaceholderText = "Posição X (m)";
            // 
            // posYTextBox
            // 
            this.posYTextBox.Location = new System.Drawing.Point(12, 99);
            this.posYTextBox.Name = "posYTextBox";
            this.posYTextBox.Size = new System.Drawing.Size(100, 23);
            this.posYTextBox.TabIndex = 3;
            this.posYTextBox.PlaceholderText = "Posição Y (m)";
            // 
            // velXTextBox
            // 
            this.velXTextBox.Location = new System.Drawing.Point(12, 128);
            this.velXTextBox.Name = "velXTextBox";
            this.velXTextBox.Size = new System.Drawing.Size(100, 23);
            this.velXTextBox.TabIndex = 4;
            this.velXTextBox.PlaceholderText = "Velocidade X (m/s)";
            // 
            // velYTextBox
            // 
            this.velYTextBox.Location = new System.Drawing.Point(12, 157);
            this.velYTextBox.Name = "velYTextBox";
            this.velYTextBox.Size = new System.Drawing.Size(100, 23);
            this.velYTextBox.TabIndex = 5;
            this.velYTextBox.PlaceholderText = "Velocidade Y (m/s)";
            // 
            // densidadeTextBox
            // 
            this.densidadeTextBox.Location = new System.Drawing.Point(12, 186);
            this.densidadeTextBox.Name = "densidadeTextBox";
            this.densidadeTextBox.Size = new System.Drawing.Size(100, 23);
            this.densidadeTextBox.TabIndex = 6;
            this.densidadeTextBox.PlaceholderText = "Densidade (kg/m³)";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.densidadeTextBox);
            this.Controls.Add(this.velYTextBox);
            this.Controls.Add(this.velXTextBox);
            this.Controls.Add(this.posYTextBox);
            this.Controls.Add(this.posXTextBox);
            this.Controls.Add(this.massaTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.displayPanel);
            this.Name = "Form1";
            this.Text = "Simulador de Universo 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
