namespace SimuladorDeUniverso2D
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel displayPanel;

        /// <summary>
        /// Limpa quaisquer recursos em uso.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
        /// Método necessário para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            stopButton = new Button();
            displayPanel = new Panel();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(93, 12);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // displayPanel
            // 
            displayPanel.Location = new Point(12, 41);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(870, 397);
            displayPanel.TabIndex = 2;
            displayPanel.Paint += DisplayPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(displayPanel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Simulador de Universo 2D";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }

}
