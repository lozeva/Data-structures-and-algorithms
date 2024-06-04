namespace SDA_184knr_180knr_MyProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxGraph;
        private Button btnDrawGraph;
        private TrackBar trackBarZoom; // Added TrackBar control

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
            groupBoxComputers = new GroupBox();
            btnRemoveComputer = new Button();
            btnAddComputer = new Button();
            numericUpDownComputerId = new NumericUpDown();
            label1 = new Label();
            listBoxComputers = new ListBox();
            pictureBoxGraph = new PictureBox();
            btnDrawGraph = new Button();
            groupBoxConnections = new GroupBox();
            btnRemoveConnection = new Button();
            btnAddConnection = new Button();
            label3 = new Label();
            label2 = new Label();
            numericUpDownComputer2 = new NumericUpDown();
            numericUpDownComputer1 = new NumericUpDown();
            listBoxConnections = new ListBox();
            groupBoxDFS = new GroupBox();
            btnDFS = new Button();
            numericUpDownDFS = new NumericUpDown();
            label4 = new Label();
            groupBoxBFS = new GroupBox();
            btnBFS = new Button();
            numericUpDownBFS = new NumericUpDown();
            label5 = new Label();
            numericUpDownNumberOfEdges = new NumericUpDown();
            numericUpDownNumberOfNodes = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            groupBoxShortestPath = new GroupBox();
            btnShortestPath = new Button();
            numericUpDownShortestPathDestination = new NumericUpDown();
            numericUpDownShortestPathSource = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            trackBarZoom = new TrackBar();
            groupBoxComputers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputerId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).BeginInit();
            groupBoxConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputer1).BeginInit();
            groupBoxDFS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDFS).BeginInit();
            groupBoxBFS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBFS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfEdges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfNodes).BeginInit();
            groupBoxShortestPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShortestPathDestination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShortestPathSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).BeginInit();
            SuspendLayout();
            // 
            // groupBoxComputers
            // 
            groupBoxComputers.Controls.Add(btnRemoveComputer);
            groupBoxComputers.Controls.Add(btnAddComputer);
            groupBoxComputers.Controls.Add(numericUpDownComputerId);
            groupBoxComputers.Controls.Add(label1);
            groupBoxComputers.Controls.Add(listBoxComputers);
            groupBoxComputers.Location = new Point(22, 25);
            groupBoxComputers.Margin = new Padding(5, 6, 5, 6);
            groupBoxComputers.Name = "groupBoxComputers";
            groupBoxComputers.Padding = new Padding(5, 6, 5, 6);
            groupBoxComputers.Size = new Size(385, 460);
            groupBoxComputers.TabIndex = 0;
            groupBoxComputers.TabStop = false;
            groupBoxComputers.Text = "Computers";
            // 
            // btnRemoveComputer
            // 
            btnRemoveComputer.Location = new Point(207, 271);
            btnRemoveComputer.Margin = new Padding(5, 6, 5, 6);
            btnRemoveComputer.Name = "btnRemoveComputer";
            btnRemoveComputer.Size = new Size(178, 44);
            btnRemoveComputer.TabIndex = 4;
            btnRemoveComputer.Text = "Remove Computer";
            btnRemoveComputer.UseVisualStyleBackColor = true;
            btnRemoveComputer.Click += BtnRemoveComputer_Click;
            // 
            // btnAddComputer
            // 
            btnAddComputer.Location = new Point(217, 94);
            btnAddComputer.Margin = new Padding(5, 6, 5, 6);
            btnAddComputer.Name = "btnAddComputer";
            btnAddComputer.Size = new Size(158, 44);
            btnAddComputer.TabIndex = 3;
            btnAddComputer.Text = "Add Computer";
            btnAddComputer.UseVisualStyleBackColor = true;
            btnAddComputer.Click += BtnAddComputer_Click;
            // 
            // numericUpDownComputerId
            // 
            numericUpDownComputerId.Location = new Point(160, 44);
            numericUpDownComputerId.Margin = new Padding(5, 6, 5, 6);
            numericUpDownComputerId.Name = "numericUpDownComputerId";
            numericUpDownComputerId.Size = new Size(182, 31);
            numericUpDownComputerId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Computer ID:";
            // 
            // listBoxComputers
            // 
            listBoxComputers.FormattingEnabled = true;
            listBoxComputers.ItemHeight = 25;
            listBoxComputers.Location = new Point(10, 94);
            listBoxComputers.Margin = new Padding(5, 6, 5, 6);
            listBoxComputers.Name = "listBoxComputers";
            listBoxComputers.Size = new Size(197, 354);
            listBoxComputers.TabIndex = 0;
            // 
            // pictureBoxGraph
            // 
            pictureBoxGraph.Enabled = false;
            pictureBoxGraph.Location = new Point(0, 0);
            pictureBoxGraph.Margin = new Padding(5, 6, 5, 6);
            pictureBoxGraph.Name = "pictureBoxGraph";
            pictureBoxGraph.Size = new Size(458, 643);
            pictureBoxGraph.TabIndex = 5;
            pictureBoxGraph.TabStop = false;
            // 
            // btnDrawGraph
            // 
            btnDrawGraph.Location = new Point(1164, 694);
            btnDrawGraph.Margin = new Padding(5, 6, 5, 6);
            btnDrawGraph.Name = "btnDrawGraph";
            btnDrawGraph.Size = new Size(125, 44);
            btnDrawGraph.TabIndex = 4;
            btnDrawGraph.Text = "Draw Graph";
            btnDrawGraph.UseVisualStyleBackColor = true;
            btnDrawGraph.Click += BtnDrawGraph_Click;
            // 
            // groupBoxConnections
            // 
            groupBoxConnections.Controls.Add(btnRemoveConnection);
            groupBoxConnections.Controls.Add(btnAddConnection);
            groupBoxConnections.Controls.Add(label3);
            groupBoxConnections.Controls.Add(label2);
            groupBoxConnections.Controls.Add(numericUpDownComputer2);
            groupBoxConnections.Controls.Add(numericUpDownComputer1);
            groupBoxConnections.Controls.Add(listBoxConnections);
            groupBoxConnections.Location = new Point(417, 25);
            groupBoxConnections.Margin = new Padding(5, 6, 5, 6);
            groupBoxConnections.Name = "groupBoxConnections";
            groupBoxConnections.Padding = new Padding(5, 6, 5, 6);
            groupBoxConnections.Size = new Size(460, 460);
            groupBoxConnections.TabIndex = 1;
            groupBoxConnections.TabStop = false;
            groupBoxConnections.Text = "Connections";
            // 
            // btnRemoveConnection
            // 
            btnRemoveConnection.Location = new Point(250, 271);
            btnRemoveConnection.Margin = new Padding(5, 6, 5, 6);
            btnRemoveConnection.Name = "btnRemoveConnection";
            btnRemoveConnection.Size = new Size(200, 44);
            btnRemoveConnection.TabIndex = 6;
            btnRemoveConnection.Text = "Remove Connection";
            btnRemoveConnection.UseVisualStyleBackColor = true;
            btnRemoveConnection.Click += BtnRemoveConnection_Click;
            // 
            // btnAddConnection
            // 
            btnAddConnection.Location = new Point(250, 94);
            btnAddConnection.Margin = new Padding(5, 6, 5, 6);
            btnAddConnection.Name = "btnAddConnection";
            btnAddConnection.Size = new Size(200, 44);
            btnAddConnection.TabIndex = 5;
            btnAddConnection.Text = "Add Connection";
            btnAddConnection.UseVisualStyleBackColor = true;
            btnAddConnection.Click += BtnAddConnection_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 48);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "Computer 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 3;
            label2.Text = "Computer 1:";
            // 
            // numericUpDownComputer2
            // 
            numericUpDownComputer2.Location = new Point(368, 44);
            numericUpDownComputer2.Margin = new Padding(5, 6, 5, 6);
            numericUpDownComputer2.Name = "numericUpDownComputer2";
            numericUpDownComputer2.Size = new Size(82, 31);
            numericUpDownComputer2.TabIndex = 2;
            // 
            // numericUpDownComputer1
            // 
            numericUpDownComputer1.Location = new Point(133, 44);
            numericUpDownComputer1.Margin = new Padding(5, 6, 5, 6);
            numericUpDownComputer1.Name = "numericUpDownComputer1";
            numericUpDownComputer1.Size = new Size(83, 31);
            numericUpDownComputer1.TabIndex = 1;
            // 
            // listBoxConnections
            // 
            listBoxConnections.FormattingEnabled = true;
            listBoxConnections.ItemHeight = 25;
            listBoxConnections.Location = new Point(10, 94);
            listBoxConnections.Margin = new Padding(5, 6, 5, 6);
            listBoxConnections.Name = "listBoxConnections";
            listBoxConnections.Size = new Size(227, 354);
            listBoxConnections.TabIndex = 0;
            // 
            // groupBoxDFS
            // 
            groupBoxDFS.Controls.Add(btnDFS);
            groupBoxDFS.Controls.Add(numericUpDownDFS);
            groupBoxDFS.Controls.Add(label4);
            groupBoxDFS.Location = new Point(22, 498);
            groupBoxDFS.Margin = new Padding(5, 6, 5, 6);
            groupBoxDFS.Name = "groupBoxDFS";
            groupBoxDFS.Padding = new Padding(5, 6, 5, 6);
            groupBoxDFS.Size = new Size(387, 140);
            groupBoxDFS.TabIndex = 2;
            groupBoxDFS.TabStop = false;
            groupBoxDFS.Text = "Depth First Search (DFS)";
            // 
            // btnDFS
            // 
            btnDFS.Location = new Point(205, 85);
            btnDFS.Margin = new Padding(5, 6, 5, 6);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(125, 44);
            btnDFS.TabIndex = 2;
            btnDFS.Text = "DFS";
            btnDFS.UseVisualStyleBackColor = true;
            btnDFS.Click += BtnDFS_Click;
            // 
            // numericUpDownDFS
            // 
            numericUpDownDFS.Location = new Point(157, 35);
            numericUpDownDFS.Margin = new Padding(5, 6, 5, 6);
            numericUpDownDFS.Name = "numericUpDownDFS";
            numericUpDownDFS.Size = new Size(173, 31);
            numericUpDownDFS.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 38);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 0;
            label4.Text = "Start Node:";
            // 
            // groupBoxBFS
            // 
            groupBoxBFS.Controls.Add(btnBFS);
            groupBoxBFS.Controls.Add(numericUpDownBFS);
            groupBoxBFS.Controls.Add(label5);
            groupBoxBFS.Location = new Point(417, 498);
            groupBoxBFS.Margin = new Padding(5, 6, 5, 6);
            groupBoxBFS.Name = "groupBoxBFS";
            groupBoxBFS.Padding = new Padding(5, 6, 5, 6);
            groupBoxBFS.Size = new Size(460, 140);
            groupBoxBFS.TabIndex = 3;
            groupBoxBFS.TabStop = false;
            groupBoxBFS.Text = "Breadth First Search (BFS)";
            // 
            // btnBFS
            // 
            btnBFS.Location = new Point(278, 85);
            btnBFS.Margin = new Padding(5, 6, 5, 6);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(125, 44);
            btnBFS.TabIndex = 3;
            btnBFS.Text = "BFS";
            btnBFS.UseVisualStyleBackColor = true;
            btnBFS.Click += BtnBFS_Click;
            // 
            // numericUpDownBFS
            // 
            numericUpDownBFS.Location = new Point(223, 35);
            numericUpDownBFS.Margin = new Padding(5, 6, 5, 6);
            numericUpDownBFS.Name = "numericUpDownBFS";
            numericUpDownBFS.Size = new Size(180, 31);
            numericUpDownBFS.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 38);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 1;
            label5.Text = "Start Node:";
            // 
            // numericUpDownNumberOfEdges
            // 
            numericUpDownNumberOfEdges.Location = new Point(498, 37);
            numericUpDownNumberOfEdges.Margin = new Padding(5, 6, 5, 6);
            numericUpDownNumberOfEdges.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownNumberOfEdges.Name = "numericUpDownNumberOfEdges";
            numericUpDownNumberOfEdges.Size = new Size(167, 31);
            numericUpDownNumberOfEdges.TabIndex = 3;
            // 
            // numericUpDownNumberOfNodes
            // 
            numericUpDownNumberOfNodes.Location = new Point(137, 37);
            numericUpDownNumberOfNodes.Margin = new Padding(5, 6, 5, 6);
            numericUpDownNumberOfNodes.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownNumberOfNodes.Name = "numericUpDownNumberOfNodes";
            numericUpDownNumberOfNodes.Size = new Size(180, 31);
            numericUpDownNumberOfNodes.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 40);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 1;
            label7.Text = "Edges:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 40);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 0;
            label6.Text = "Nodes:";
            // 
            // groupBoxShortestPath
            // 
            groupBoxShortestPath.Controls.Add(btnShortestPath);
            groupBoxShortestPath.Controls.Add(numericUpDownShortestPathDestination);
            groupBoxShortestPath.Controls.Add(numericUpDownShortestPathSource);
            groupBoxShortestPath.Controls.Add(label9);
            groupBoxShortestPath.Controls.Add(label8);
            groupBoxShortestPath.Location = new Point(22, 659);
            groupBoxShortestPath.Margin = new Padding(5, 6, 5, 6);
            groupBoxShortestPath.Name = "groupBoxShortestPath";
            groupBoxShortestPath.Padding = new Padding(5, 6, 5, 6);
            groupBoxShortestPath.Size = new Size(855, 104);
            groupBoxShortestPath.TabIndex = 5;
            groupBoxShortestPath.TabStop = false;
            groupBoxShortestPath.Text = "Shortest Path";
            // 
            // btnShortestPath
            // 
            btnShortestPath.Location = new Point(675, 35);
            btnShortestPath.Margin = new Padding(5, 6, 5, 6);
            btnShortestPath.Name = "btnShortestPath";
            btnShortestPath.Size = new Size(170, 44);
            btnShortestPath.TabIndex = 4;
            btnShortestPath.Text = "Find Path";
            btnShortestPath.UseVisualStyleBackColor = true;
            btnShortestPath.Click += BtnShortestPath_Click;
            // 
            // numericUpDownShortestPathDestination
            // 
            numericUpDownShortestPathDestination.Location = new Point(498, 37);
            numericUpDownShortestPathDestination.Margin = new Padding(5, 6, 5, 6);
            numericUpDownShortestPathDestination.Name = "numericUpDownShortestPathDestination";
            numericUpDownShortestPathDestination.Size = new Size(167, 31);
            numericUpDownShortestPathDestination.TabIndex = 3;
            // 
            // numericUpDownShortestPathSource
            // 
            numericUpDownShortestPathSource.Location = new Point(137, 37);
            numericUpDownShortestPathSource.Margin = new Padding(5, 6, 5, 6);
            numericUpDownShortestPathSource.Name = "numericUpDownShortestPathSource";
            numericUpDownShortestPathSource.Size = new Size(180, 31);
            numericUpDownShortestPathSource.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(358, 40);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 1;
            label9.Text = "Destination:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 40);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 0;
            label8.Text = "Source:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBoxGraph);
            panel1.Location = new Point(887, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 644);
            panel1.TabIndex = 6;
            // 
            // trackBarZoom
            // 
            trackBarZoom.Location = new Point(913, 694);
            trackBarZoom.Maximum = 400;
            trackBarZoom.Minimum = 50;
            trackBarZoom.Name = "trackBarZoom";
            trackBarZoom.Size = new Size(151, 69);
            trackBarZoom.TabIndex = 25;
            trackBarZoom.Value = 100;
            trackBarZoom.Scroll += TrackBarZoom_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 789);
            Controls.Add(trackBarZoom);
            Controls.Add(panel1);
            Controls.Add(groupBoxShortestPath);
            Controls.Add(groupBoxBFS);
            Controls.Add(groupBoxDFS);
            Controls.Add(groupBoxConnections);
            Controls.Add(btnDrawGraph);
            Controls.Add(groupBoxComputers);
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(1390, 845);
            MinimumSize = new Size(1390, 845);
            Name = "Form1";
            Text = "Network Simulator";
            groupBoxComputers.ResumeLayout(false);
            groupBoxComputers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputerId).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).EndInit();
            groupBoxConnections.ResumeLayout(false);
            groupBoxConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComputer1).EndInit();
            groupBoxDFS.ResumeLayout(false);
            groupBoxDFS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDFS).EndInit();
            groupBoxBFS.ResumeLayout(false);
            groupBoxBFS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBFS).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfEdges).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfNodes).EndInit();
            groupBoxShortestPath.ResumeLayout(false);
            groupBoxShortestPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShortestPathDestination).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShortestPathSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxComputers;
        private GroupBox groupBoxConnections;
        private NumericUpDown numericUpDownComputerId;
        private Label label1;
        private ListBox listBoxComputers;
        private ListBox listBoxConnections;
        private Button btnRemoveComputer;
        private Button btnAddComputer;
        private Button btnRemoveConnection;
        private Button btnAddConnection;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownComputer2;
        private NumericUpDown numericUpDownComputer1;
        private GroupBox groupBoxDFS;
        private Button btnDFS;
        private NumericUpDown numericUpDownDFS;
        private Label label4;
        private GroupBox groupBoxBFS;
        private Button btnBFS;
        private NumericUpDown numericUpDownBFS;
        private Label label5;
        private GroupBox groupBoxRandomGraph;
        private Button btnGenerateRandomGraph;
        private NumericUpDown numericUpDownNumberOfEdges;
        private NumericUpDown numericUpDownNumberOfNodes;
        private Label label7;
        private Label label6;
        private GroupBox groupBoxShortestPath;
        private Button btnShortestPath;
        private NumericUpDown numericUpDownShortestPathDestination;
        private NumericUpDown numericUpDownShortestPathSource;
        private Label label9;
        private Label label8;
        private Panel panel1;
    }
}