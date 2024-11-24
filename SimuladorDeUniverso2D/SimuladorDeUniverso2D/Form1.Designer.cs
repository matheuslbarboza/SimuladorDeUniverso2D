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
            displayPanel = new Panel();
            adicionarButton = new Button();
            startButton = new Button();
            nomeTextBox = new TextBox();
            massaTextBox = new TextBox();
            posXTextBox = new TextBox();
            posYTextBox = new TextBox();
            velXTextBox = new TextBox();
            velYTextBox = new TextBox();
            densidadeTextBox = new TextBox();
            SuspendLayout();
            // 
            // displayPanel
            // 
            displayPanel.Dock = DockStyle.Fill;
            displayPanel.Location = new Point(0, 0);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(1350, 749);
            displayPanel.TabIndex = 0;
            displayPanel.Paint += DisplayPanel_Paint;
            // 
            // adicionarButton
            // 
            adicionarButton.Location = new Point(12, 215);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(100, 23);
            adicionarButton.TabIndex = 7;
            adicionarButton.Text = "Adicionar Corpo";
            adicionarButton.UseVisualStyleBackColor = true;
            adicionarButton.Click += AdicionarButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 244);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 23);
            startButton.TabIndex = 8;
            startButton.Text = "Iniciar Simulação";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(12, 12);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.PlaceholderText = "Nome";
            nomeTextBox.Size = new Size(100, 23);
            nomeTextBox.TabIndex = 0;
            // 
            // massaTextBox
            // 
            massaTextBox.Location = new Point(12, 41);
            massaTextBox.Name = "massaTextBox";
            massaTextBox.PlaceholderText = "Massa (kg)";
            massaTextBox.Size = new Size(100, 23);
            massaTextBox.TabIndex = 1;
            // 
            // posXTextBox
            // 
            posXTextBox.Location = new Point(12, 70);
            posXTextBox.Name = "posXTextBox";
            posXTextBox.PlaceholderText = "Posição X (m)";
            posXTextBox.Size = new Size(100, 23);
            posXTextBox.TabIndex = 2;
            // 
            // posYTextBox
            // 
            posYTextBox.Location = new Point(12, 99);
            posYTextBox.Name = "posYTextBox";
            posYTextBox.PlaceholderText = "Posição Y (m)";
            posYTextBox.Size = new Size(100, 23);
            posYTextBox.TabIndex = 3;
            // 
            // velXTextBox
            // 
            velXTextBox.Location = new Point(12, 128);
            velXTextBox.Name = "velXTextBox";
            velXTextBox.PlaceholderText = "Velocidade X (m/s)";
            velXTextBox.Size = new Size(100, 23);
            velXTextBox.TabIndex = 4;
            // 
            // velYTextBox
            // 
            velYTextBox.Location = new Point(12, 157);
            velYTextBox.Name = "velYTextBox";
            velYTextBox.PlaceholderText = "Velocidade Y (m/s)";
            velYTextBox.Size = new Size(100, 23);
            velYTextBox.TabIndex = 5;
            // 
            // densidadeTextBox
            // 
            densidadeTextBox.Location = new Point(12, 186);
            densidadeTextBox.Name = "densidadeTextBox";
            densidadeTextBox.PlaceholderText = "Densidade (kg/m³)";
            densidadeTextBox.Size = new Size(100, 23);
            densidadeTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            ClientSize = new Size(1350, 749);
            Controls.Add(densidadeTextBox);
            Controls.Add(velYTextBox);
            Controls.Add(velXTextBox);
            Controls.Add(posYTextBox);
            Controls.Add(posXTextBox);
            Controls.Add(massaTextBox);
            Controls.Add(nomeTextBox);
            Controls.Add(startButton);
            Controls.Add(adicionarButton);
            Controls.Add(displayPanel);
            Name = "Form1";
            Text = "Simulador de Universo 2D";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
